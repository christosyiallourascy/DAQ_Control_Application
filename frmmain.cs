using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//-------------------------------------
//Project --> Add Reference --> .NET
//Add --> Microsoft.Office
//Add --> Microsoft.Office.Interop.Excel
//Add --> NationalIstruments.Common
//Add --> NationalInstruments.DAQmx
//Add --> VisaComLib
//-------------------------------------
//National Instruments libraries
using NationalInstruments;
using NationalInstruments.DAQmx;
//Visa connection library for agilent generator
using Ivi.Visa.Interop;
//office library for connecting with the excel application
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
//RFG_1000 Generator Reference
using System.Management;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace RobotControlApplication
{
    public partial class frmmain : Form
    {
        //property variables
        private string _baudRate = string.Empty;
        private string _parity = string.Empty;
        private string _stopBits = string.Empty;
        private string _startBits = string.Empty;
        private string _dataBits = string.Empty;
        private string _portName = string.Empty;
        private string _handshaking = string.Empty;
        private const string Delimiter = "\r";
        private string tString = string.Empty;
        private int voltage = 0;
        private double frequency = 0;
        private int ontimecw = 0;
        private double dutyfactor = 0;
        private double pulserepfreq = 0;
        private int ontimepw = 0;
        private double ncycles = 0;
        private int counter1D = 0;
        private int currx = 20;
        private int curry = 20;
        private Label newlbl;
        private int numberofrepeatscw = 0;
        private int totaltimeofcw = 0;
        private bool cwsignalon = false;
        private int cwcurrentontime = 0;
        private int cwcurrentofftime = 0;
        private bool cwsignalwithrepeats = false;
        private int[,] preset_grid;

        bool typeofsignal_RFG;
        int typeof_JJA;
        int counter = 0;
        bool cwRFG = true;
        int repeatsPWJJA = 1;
        int repeatsJJATotal = 1;
        string deviceid = "";//global variable to store the NI DAQ device ID
        string robottype = "";//global variable to store the robot type
        string excelfilefullpath = "";//global variable to store the selected directory
        private CICountEdgesActiveEdge edgeType = CICountEdgesActiveEdge.Rising;//set the type of being counted
        private CICountEdgesCountDirection countDirection = CICountEdgesCountDirection.Up;//count direction is set to up
        private CounterReader myCounterReader;//declear a counter reader
        //private AsyncCallback myCallBack;
        private Task runningTask;
        //private Task counterReadTask;
        private Ivi.Visa.Interop.FormattedIO488 fg;//set an instance for a visa connection with agilent generator
        private SerialPort comPort = new SerialPort();

        //vacuum
        delegate void SetTextCallback(string text);
        delegate void SetChangeCallback(string text);
        Thread vacuumThread;

        public frmmain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.tabControl1.Height = 700;
            this.gridpattern.Height = 400;
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (comPort.IsOpen) comPort.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Robot and Ultrasound Control Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnxfw_Click(object sender, EventArgs e)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = Double.Parse(txtxfw.Text);
            availablespace = (110 - Convert.ToDouble(txtxposition.Text));
            if ((mm != 0) && (mm <= availablespace))
            {
                mm = ((mm - 0.1) / 25.4) * 500;//get the parameter in millimeters
                Cursor.Current = Cursors.WaitCursor;
                try//try block in order to catch errors if any without crashing the system
                {
                    using (Task digitalWriteTask = new Task())//create digital writer task
                    {
                        //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                        //create a digital output channel by passing the correct parametrs
                        digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                            ChannelLineGrouping.OneChannelForAllLines);
                        //create an array of 8 boolean elements
                        bool[] dataArray = new bool[8];
                        //initialize the elements with the prober parameter
                        //11011111

                        dataArray = DAQsettings.PortsXr;
                        //set the array to digital writer
                        DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                        writer.WriteSingleSampleMultiLine(true, dataArray);
                        //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                        //1 for forward direction
                        getEdgeCounterValue(Convert.ToInt32(mm), 1);
                        

                    }
                }
                catch (DaqException ex)//catch the errors if any
                {
                    MessageBox.Show(ex.Message);//display the errors in a msg box
                }
            finally//after completing the try block
                {
                    Cursor.Current = Cursors.Default;//To return back the default behavior
                }
            }
            else
            {
                btnstopnow_Click(sender, e);//stop motors
                MessageBox.Show("The number of millimetres can not be zero or more than 110 or \n there is no enough space to move. \n The available space is " + availablespace.ToString() + " mm", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnxrev_Click(object sender, EventArgs e)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = Double.Parse(txtxrev.Text);
            availablespace = (Convert.ToDouble(txtxposition.Text) - mm);
            if ((mm != 0) && ((availablespace >= 0)))
            {
                mm = ((mm - 0.1) / 25.4) * 500;
                Cursor.Current = Cursors.WaitCursor;
                try//try block in order to catch errors if any without crashing the system
                {
                    using (Task digitalWriteTask = new Task())
                    {
                        //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                        //create a digital output channel by passing the correct parametrs
                        digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                            ChannelLineGrouping.OneChannelForAllLines);
                        //create an array of 8 boolean elements
                        bool[] dataArray = new bool[8];

                        dataArray = DAQsettings.PortsX;
                        //set the array to digital writer
                        DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                        writer.WriteSingleSampleMultiLine(true, dataArray);
                        //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                        //0 for reverse direction
                        getEdgeCounterValue(Convert.ToInt32(mm), 0);
                        

                    }
                }
                catch (DaqException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                //if (availablespace < 0)
                //{
                    //availablespace = (Convert.ToDouble(txtxposition.Text));
                //}
                btnstopnow_Click(sender, e);//stop motors
                MessageBox.Show("The number of millimetres can not be zero or more than 110 or \n there is no enough space to move. \n The available space is " + availablespace.ToString() + " mm", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnthitacw_Click(object sender, EventArgs e)
        {
            int edgecount = 0;
            int degress = 0;
            int availablespace = 0;
            degress = Int32.Parse(txtthitacw.Text);//get the parameter in degrees
            availablespace = 90 - Int32.Parse(txtthitaposition.Text);
            if ((degress != 0))
            {

                edgecount = (int)(Math.Round((2500 * degress) / 360.0)) - 20;
                
                counter = 0;
                Cursor.Current = Cursors.WaitCursor;
                try//try block for catching unexpected errors
                {
                    using (Task digitalWriteTask = new Task())
                    {
                        //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                        //create a digital output channel by passing the correct parametrs
                        digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                            ChannelLineGrouping.OneChannelForAllLines);
                        //create an array of 8 boolean elements
                        bool[] dataArray = new bool[8];

                        dataArray = DAQsettings.PortsThita;
                        //set the array to digital writer
                        DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                        writer.WriteSingleSampleMultiLine(true, dataArray);
                        //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                        //1 for cw direction
                        getEdgeCounterValuethita(edgecount, 1);
                        
                    }
                }
                catch (DaqException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("The number of degrees can not be zero degrees.", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnthitaccw_Click(object sender, EventArgs e)
        {
            int degress = 0, edgecount = 0;
            int availablespace = 0;
            degress = Int32.Parse(txtthitaccw.Text);//get the parameter in degrees
            availablespace = Int32.Parse(txtthitaposition.Text) - degress;
            if ((degress != 0))
            {

                edgecount = (int)(Math.Round((2500 * degress) / 360.0)) - 20;
                
                counter = 0;
                Cursor.Current = Cursors.WaitCursor;
                try//try block for catching unexpected errors
                {
                    using (Task digitalWriteTask = new Task())
                    {
                        //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                        //create a digital output channel by passing the correct parametrs
                        digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                            ChannelLineGrouping.OneChannelForAllLines);
                        //create an array of 8 boolean elements
                        bool[] dataArray = new bool[8];

                        dataArray = DAQsettings.PortsThitar;
                        //set the array to digital writer
                        DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                        writer.WriteSingleSampleMultiLine(true, dataArray);
                        //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                        //0 for ccw direction
                        getEdgeCounterValuethita(edgecount, 0);
                        
                    }
                }
                catch (DaqException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("The number of degress can not be zero degress", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnxthitaposition_Click(object sender, EventArgs e)
        {
            //set initial robot position
            txtxposition.Text = "0";
            txtthitaposition.Text = "0";
            addCommandToHistoryList("Set Robot Initial Position to zero, ");
        }

        private void xfscroll_Scroll(object sender, ScrollEventArgs e)
        {
            //store the scrollbar value to textbox for x fw motion
            txtxfw.Text = Convert.ToString(xfscroll.Value);
        }

        private void xrscroll_Scroll(object sender, ScrollEventArgs e)
        {
            //store the scrollbar value to textbox for x rev motion
            txtxrev.Text = Convert.ToString(xrscroll.Value);
        }

        private void cwscroll_Scroll(object sender, ScrollEventArgs e)
        {
            //store the scrollbar value to textbox for thita cw motion
            txtthitacw.Text = Convert.ToString(cwscroll.Value);
        }

        private void ccwscroll_Scroll(object sender, ScrollEventArgs e)
        {
            //store the scrollbar value to textbox for thita ccw motion
            txtthitaccw.Text = Convert.ToString(ccwscroll.Value);
        }

        //button used for manual stopping the motors
        private void btnstopnow_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try//try block for catching unnecessary errors
            {
                using (Task digitalWriteTask = new Task())//create new Task and using it
                {
                    //deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of eight booliean elements
                    bool[] dataArray = new bool[8];
                    //set all the elements to true value
                    dataArray[0] = true;
                    dataArray[1] = true;
                    dataArray[2] = true;
                    dataArray[3] = true;
                    dataArray[4] = true;
                    dataArray[5] = true;
                    dataArray[6] = true;
                    dataArray[7] = true;
                    //create an instance of the digital channel writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    addCommandToHistoryList("Manually stop of motor movements, ");

                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void getEdgeCounterValueThitatoX(int maxvaluethita, int direction)
        {
            Cursor.Current = Cursors.WaitCursor;

            //try block for catching unnecessary errors
            try
            {
                using (Task CounterReadTask = new Task())//create new Task and using it
                {
                    //deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    CounterReadTask.CIChannels.CreateCountEdgesChannel(deviceid + "/ctr0",//device ID
                        "", edgeType, Convert.ToInt64("0"), countDirection);//counter type and direction

                    //set timing parameters to the counter reader task
                    CounterReadTask.Timing.ConfigureSampleClock(deviceid + "/PFI8",//device ID
                        Convert.ToDouble("100000.00"), SampleClockActiveEdge.Rising,//set the sample rate and the counting Edge
                        SampleQuantityMode.FiniteSamples, Convert.ToInt32("100000"));//number of samples aquired each time

                    runningTask = CounterReadTask;
                    //create an instance of the counter reader configure above
                    myCounterReader = new CounterReader(CounterReadTask.Stream);

                    //initialize the variables to zero each time the function is called
                    int data = 0;
                    int currposition = 0;
                    while (data < maxvaluethita)//compare current value with requir value
                    {
                        data = myCounterReader.ReadSingleSampleInt32();//getting an integer number of lines read so far during the motion
                    }
                    stopmotors();//stop the motors

                    //if block statement for desiding the correct direction of the motion and update the interface
                    //1 for fw and 0 for rev
                    if (direction == 1)//one is for forward direction
                    {
                        //convertion from angular DPI to mm
                        currposition = Convert.ToInt32(txtxposition_3d.Text) + data;//calculate the current position
                        txtxposition_3d.Text = Convert.ToString(currposition);//store the current postion to the text box control
                        addCommandToHistoryList("Forward movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                    }
                    else
                    {
                        //convertion from angular DPI to mm
                        currposition = Convert.ToInt32(txtxposition_3d.Text) - data;//calculate the current position
                        txtxposition_3d.Text = Convert.ToString(currposition);//store the current position to the text box control
                        addCommandToHistoryList("Reverse movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                    }

                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                stopmotors();
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void getEdgeCounterValueThitatoY(int maxvaluethita, int direction)
        {
            Cursor.Current = Cursors.WaitCursor;

            //try block for catching unnecessary errors
            try
            {
                using (Task CounterReadTask = new Task())//create new Task and using it
                {
                    //deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    CounterReadTask.CIChannels.CreateCountEdgesChannel(deviceid + "/ctr1",//device ID
                        "", edgeType, Convert.ToInt64("0"), countDirection);//counter type and direction

                    //set timing parameters to the counter reader task
                    CounterReadTask.Timing.ConfigureSampleClock(deviceid + "/PFI3",//device ID
                        Convert.ToDouble("100000.00"), SampleClockActiveEdge.Rising,//set the sample rate and the counting Edge
                        SampleQuantityMode.FiniteSamples, Convert.ToInt32("100000"));//number of samples aquired each time

                    runningTask = CounterReadTask;
                    //create an instance of the counter reader configure above
                    myCounterReader = new CounterReader(CounterReadTask.Stream);

                    //initialize the variables to zero each time the function is called
                    int data = 0;
                    int currposition = 0;
                    while (data < maxvaluethita)//compare current value with requir value
                    {
                        data = myCounterReader.ReadSingleSampleInt32();//getting an integer number of lines read so far during the motion
                    }
                    stopmotors();//stop the motors

                    //if block statement for desiding the correct direction of the motion and update the interface
                    //1 for fw and 0 for rev
                    if (direction == 1)//one is for forward direction
                    {
                        //convertion from angular DPI to mm
                        currposition = Convert.ToInt32(txtxposition_3d.Text) + data;//calculate the current position
                        txtyposition_3d.Text = Convert.ToString(currposition);//store the current postion to the text box control
                        addCommandToHistoryList("Forward movement on Y Axis " + Convert.ToInt32(data) + " mm, ");
                    }
                    else
                    {
                        //convertion from angular DPI to mm
                        currposition = Convert.ToInt32(txtxposition_3d.Text) - data;//calculate the current position
                        txtyposition_3d.Text = Convert.ToString(currposition);//store the current position to the text box control
                        addCommandToHistoryList("Reverse movement on Y Axis " + Convert.ToInt32(data) + " mm, ");
                    }

                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                stopmotors();
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        //get angular encoder value
        private void getEdgeCounterValuethita(int maxvaluethita, int direction)
        {
            Cursor.Current = Cursors.WaitCursor;
            try//try block for catching unnecessary errors
            {
                using (Task CounterReadTask = new Task())//create new Task and using it
                {
                    deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    CounterReadTask.CIChannels.CreateCountEdgesChannel(deviceid + "/ctr3",
                        "", edgeType, Convert.ToInt64("0"), countDirection);//counter type and direction
                    //set timing parameters to the counter reader task
                    CounterReadTask.Timing.ConfigureSampleClock(deviceid + "/PFI5",
                        Convert.ToDouble("100000.00"), SampleClockActiveEdge.Rising,
                        SampleQuantityMode.FiniteSamples, Convert.ToInt32("100000"));

                    runningTask = CounterReadTask;
                    //create an instance of the counter reader configure above
                    myCounterReader = new CounterReader(CounterReadTask.Stream);

                    //initialize the variables to zero each time to call the function
                    double data = 0;
                    int currposition = 0;
                    while (data < maxvaluethita)//compare curreent value with requir value
                    {
                        data = myCounterReader.ReadSingleSampleInt32();//getting an integer number of lines read so far during the motion
                    }
                    stopmotors();//stop the current motion
                    //if block statement for desiding the correct direction of the motion and update the interface
                    //1 for cw and 0 for ccw
                    if (direction == 1)
                    {
                        //data = (360 * (data + 30))/2500;//convert the edgacount back to degrees
                        currposition = Convert.ToInt32(txtthitaposition.Text) + Convert.ToInt32 (txtthitacw.Text);//calculate the current position
                        txtthitaposition.Text = currposition.ToString();//store the current postion to the text box control
                        addCommandToHistoryList("ClockWise rotation on Θ Axis " + txtthitacw.Text + " degress, ");
                    }
                    else
                    {
                        //data = (360 * (data + 30)) / 2500;//convert the edgacount back to degrees
                        currposition = Convert.ToInt32(txtthitaposition.Text) - Convert.ToInt32(txtthitaccw.Text);//calculate the current position
                        txtthitaposition.Text = Convert.ToString(currposition);//store the current position to the text box control
                        addCommandToHistoryList("Counter ClockWise rotation on Θ Axis " + txtthitaccw.Text + " degress, ");
                    }
                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                stopmotors();
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        //get the linear encoder value
        private void getEdgeCounterValue(int maxvalue, int direction)
        {
            Cursor.Current = Cursors.WaitCursor;
            //initialize the variables to zero each time the function is called
            int data = 0;
            int currposition = 0;
            //try block for catching unnecessary errors
            try
            {
                using (Task CounterReadTask = new Task())//create new Task and using it
                {
                    //deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    CounterReadTask.CIChannels.CreateCountEdgesChannel(deviceid + "/ctr0",//device ID
                        "", edgeType, Convert.ToInt64("0"), countDirection);//counter type and direction

                    //set timing parameters to the counter reader task
                    CounterReadTask.Timing.ConfigureSampleClock(deviceid + "/PFI8",//device ID
                        Convert.ToDouble("100000.00"), SampleClockActiveEdge.Rising,//set the sample rate and the counting Edge
                        SampleQuantityMode.FiniteSamples, Convert.ToInt32("100000"));//number of samples aquired each time

                    runningTask = CounterReadTask;
                    //create an instance of the counter reader configure above
                    myCounterReader = new CounterReader(CounterReadTask.Stream);


                    while (data < maxvalue)//compare current value with requir value
                    {
                        data = myCounterReader.ReadSingleSampleInt32();//getting an integer number of lines read so far during the motion
                    }
                    stopmotors();//stop the motors

                    //if block statement for desiding the correct direction of the motion and update the interface
                    //1 for fw and 0 for rev
                    if (direction == 1)//one is for forward direction
                    {
                        data = Convert.ToInt32((data * 25.4)/500);
                        currposition = Convert.ToInt32(txtxposition.Text) + data;//calculate the current position
                        txtxposition.Text = Convert.ToString(currposition);//store the current postion to the text box control
                        addCommandToHistoryList("Forward movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                    }
                    else
                    {
                        data = Convert.ToInt32((data * 25.4) / 500);
                        currposition = Convert.ToInt32(txtxposition.Text) - data;//calculate the current position
                        txtxposition.Text = Convert.ToString(currposition);//store the current position to the text box control
                        addCommandToHistoryList("Reverse movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                    }

                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                stopmotors();
                //if block statement for desiding the correct direction of the motion and update the interface
                //1 for fw and 0 for rev
                if (direction == 1)//one is for forward direction
                {
                    data = Convert.ToInt32((data * 25.4) / 500);
                    currposition = Convert.ToInt32(txtxposition.Text) + data;//calculate the current position
                    txtxposition.Text = Convert.ToString(currposition);//store the current postion to the text box control
                    addCommandToHistoryList("Forward movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                }
                else
                {
                    data = Convert.ToInt32((data * 25.4) / 500);
                    currposition = Convert.ToInt32(txtxposition.Text) - data;//calculate the current position
                    txtxposition.Text = Convert.ToString(currposition);//store the current position to the text box control
                    addCommandToHistoryList("Reverse movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                }
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        //get the linear encoder value
        private void getEdgeCounterValue2DX(int maxvalue, int direction)
        {
            Cursor.Current = Cursors.WaitCursor;

            //try block for catching unnecessary errors
            try
            {
                using (Task CounterReadTask = new Task())//create new Task and using it
                {
                    //deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    CounterReadTask.CIChannels.CreateCountEdgesChannel(deviceid + "/ctr0",//device ID
                        "", edgeType, Convert.ToInt64("0"), countDirection);//counter type and direction

                    //set timing parameters to the counter reader task
                    CounterReadTask.Timing.ConfigureSampleClock(deviceid + "/PFI8",//device ID
                        Convert.ToDouble("100000.00"), SampleClockActiveEdge.Rising,//set the sample rate and the counting Edge
                        SampleQuantityMode.FiniteSamples, Convert.ToInt32("100000"));//number of samples aquired each time

                    runningTask = CounterReadTask;
                    //create an instance of the counter reader configure above
                    myCounterReader = new CounterReader(CounterReadTask.Stream);

                    //initialize the variables to zero each time the function is called
                    int data = 0;
                    int currposition = 0;
                    while (data < maxvalue)//compare current value with requir value
                    {
                        data = myCounterReader.ReadSingleSampleInt32();//getting an integer number of lines read so far during the motion
                    }
                    stopmotors();//stop the motors

                    //if block statement for desiding the correct direction of the motion and update the interface
                    //1 for fw and 0 for rev
                    if (direction == 1)//one is for forward direction
                    {
                        data = Convert.ToInt32((data * 25.4) / 500);
                        currposition = Convert.ToInt32(txtxposition_3d.Text) + data;//calculate the current position
                        txtxposition_3d.Text = Convert.ToString(currposition);//store the current postion to the text box control
                        addCommandToHistoryList("Forward movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                    }
                    else
                    {
                        data = Convert.ToInt32((data * 25.4) / 500);
                        currposition = Convert.ToInt32(txtxposition_3d.Text) - data;//calculate the current position
                        txtxposition_3d.Text = Convert.ToString(currposition);//store the current position to the text box control
                        addCommandToHistoryList("Reverse movement on X Axis " + Convert.ToInt32(data) + " mm, ");
                    }

                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                stopmotors();
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        //get the linear encoder value
        private void getEdgeCounterValue2DY(int maxvalue, int direction)
        {
            Cursor.Current = Cursors.WaitCursor;

            //try block for catching unnecessary errors
            try
            {
                using (Task CounterReadTask = new Task())//create new Task and using it
                {
                    //deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    CounterReadTask.CIChannels.CreateCountEdgesChannel(deviceid + "/ctr1",//device ID
                        "", edgeType, Convert.ToInt64("0"), countDirection);//counter type and direction

                    //set timing parameters to the counter reader task
                    CounterReadTask.Timing.ConfigureSampleClock(deviceid + "/PFI3",//device ID
                        Convert.ToDouble("100000.00"), SampleClockActiveEdge.Rising,//set the sample rate and the counting Edge
                        SampleQuantityMode.FiniteSamples, Convert.ToInt32("100000"));//number of samples aquired each time

                    runningTask = CounterReadTask;
                    //create an instance of the counter reader configure above
                    myCounterReader = new CounterReader(CounterReadTask.Stream);

                    //initialize the variables to zero each time the function is called
                    int data = 0;
                    int currposition = 0;
                    while (data < maxvalue)//compare current value with requir value
                    {
                        data = myCounterReader.ReadSingleSampleInt32();//getting an integer number of lines read so far during the motion
                    }
                    stopmotors();//stop the motors

                    //if block statement for desiding the correct direction of the motion and update the interface
                    //1 for fw and 0 for rev
                    if (direction == 1)//one is for forward direction
                    {
                        data = Convert.ToInt32((data * 25.4) / 500);
                        currposition = Convert.ToInt32(txtyposition_3d.Text) - data;//calculate the current position
                        txtyposition_3d.Text = Convert.ToString(currposition);//store the current postion to the text box control
                        addCommandToHistoryList("Forward movement on Y Axis " + Convert.ToInt32(data) + " mm, ");
                    }
                    else
                    {
                        data = Convert.ToInt32((data * 25.4) / 500);
                        currposition = Convert.ToInt32(txtyposition_3d.Text) + data;//calculate the current position
                        txtyposition_3d.Text = Convert.ToString(currposition);//store the current position to the text box control
                        addCommandToHistoryList("Reverse movement on Y Axis " + Convert.ToInt32(data) + " mm, ");
                    }

                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                stopmotors();
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        //get the linear encoder value
        private void getEdgeCounterValue3DZ(int maxvalue, int direction)
        {
            Cursor.Current = Cursors.WaitCursor;

            //try block for catching unnecessary errors
            try
            {
                using (Task CounterReadTask = new Task())//create new Task and using it
                {
                    //deviceid = cmbdeviceid.Text;//store the selected the dev ID
                    //create a counter read task by adding the parameters to the counter input channel
                    CounterReadTask.CIChannels.CreateCountEdgesChannel(deviceid + "/ctr2",//device ID
                        "", edgeType, Convert.ToInt64("0"), countDirection);//counter type and direction

                    //set timing parameters to the counter reader task
                    CounterReadTask.Timing.ConfigureSampleClock(deviceid + "/PFI0",//device ID
                        Convert.ToDouble("100000.00"), SampleClockActiveEdge.Rising,//set the sample rate and the counting Edge
                        SampleQuantityMode.FiniteSamples, Convert.ToInt32("100000"));//number of samples aquired each time

                    runningTask = CounterReadTask;
                    //create an instance of the counter reader configure above
                    myCounterReader = new CounterReader(CounterReadTask.Stream);

                    //initialize the variables to zero each time the function is called
                    int data = 0;
                    int currposition = 0;
                    while (data < maxvalue)//compare current value with requir value
                    {
                        data = myCounterReader.ReadSingleSampleInt32();//getting an integer number of lines read so far during the motion
                    }
                    stopmotors();//stop the motors

                    //if block statement for desiding the correct direction of the motion and update the interface
                    //1 for fw and 0 for rev
                    if (direction == 1)//one is for forward direction
                    {
                        data = Convert.ToInt32((data * 25.4) / 500);
                        currposition = Convert.ToInt32(txtzposition_3d.Text) - data;//calculate the current position
                        txtzposition_3d.Text = Convert.ToString(currposition);//store the current postion to the text box control
                        addCommandToHistoryList("Forward movement on Z Axis " + Convert.ToInt32(data) + " mm, ");
                    }
                    else
                    {
                        data = Convert.ToInt32((data * 25.4) / 500);
                        currposition = Convert.ToInt32(txtzposition_3d.Text) + data;//calculate the current position
                        txtzposition_3d.Text = Convert.ToString(currposition);//store the current position to the text box control
                        addCommandToHistoryList("Reverse movement on Z Axis " + Convert.ToInt32(data) + " mm, ");
                    }

                }
            }
            catch (DaqException ex)//catch any errors during the execution of the try block
            {
                stopmotors();
                MessageBox.Show(ex.Message);//message after catching an error
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void stopmotors()//function used for stop all the motors
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (Task digitalWriteTask = new Task())
                {
                    deviceid = cmbdeviceid.Text;//store the dev ID
                    //create a digigtal output channel
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //declear a boolean array of eight elements
                    bool[] dataArray = new bool[8];
                    //set all array elements to zero for stopping motors
                    dataArray[0] = true;
                    dataArray[1] = true;
                    dataArray[2] = true;
                    dataArray[3] = true;
                    dataArray[4] = true;
                    dataArray[5] = true;
                    dataArray[6] = true;
                    dataArray[7] = true;
                    //create an instance of the digital channel writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    //send the eight element array to the device
                    writer.WriteSingleSampleMultiLine(true, dataArray);

                }
            }
            catch (DaqException ex)//catch the errors within the try block
            {
                MessageBox.Show(ex.Message);//display the errors 
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstcommandhistory.HorizontalScrollbar = true;
            fill_ComboDeviceID();
            typeofsignal_RFG = true;
            //Get a list of serial port names and store it in an array of strings
            getCOMPortNames();
        }

        private void getCOMPortNames()
        {
            string[] ports = SerialPort.GetPortNames();
            cmbportname.Items.Clear();
            cmbportname.Items.Add("Select RFG COM port...");

            //Display each port name to the combo box 
            foreach (string port in ports)
            {
                cmbportname.Items.Add(port.ToString());
            }
            cmbportname.SelectedText = "Select RFG COM port...";
        }

        //button event for enable the grid operation
        private void btnstartgrid_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridpattern2D.Controls.Clear();
                if (gbagilentgenerator.Enabled == true)
                {
                    //store the given parameters for the grid operation
                    double numOfStepsx = Convert.ToInt32(txtnxgrid.Text);
                    double numOfStepsthita = Convert.ToInt32(txtnthitagrid.Text);
                    double numOfStepmmx = Convert.ToInt32(txtnxstep.Text);
                    double numOfStepdegrees = Convert.ToInt32(txtnthitastep.Text);
                    int countsonications = 0;
                    int xcounter = 1;
                    int thitacounter = 1;

                    if (numOfStepsx != 0 || numOfStepsthita != 0 || numOfStepmmx != 0 || numOfStepdegrees != 0)
                    {
                        int timewait = 0;//wait for the generator to finshed its operation
                        int direction = 1;//motion direction
                        int timewaitfornextsonication = 0;//time wait for next operation
                        //set the values of motion duration 
                        txtxfw.Text = numOfStepmmx.ToString();
                        txtxrev.Text = numOfStepmmx.ToString();
                        txtthitacw.Text = numOfStepdegrees.ToString();
                        txtthitaccw.Text = numOfStepdegrees.ToString();

                        change_gui_status(false);
                        //the following neasted loop creates the visual grid pattern
                        currx = 10;
                        curry = 10;
                        for (int i = 0; i < numOfStepsthita; i++)
                        {

                            if (i == 0)
                            {

                            }
                            else
                            {
                                curry = curry + 35;
                            }
                            for (int j = 0; j < numOfStepsx; j++)
                            {

                                createPattern(currx, curry, i, j, "2D", (int)numOfStepsx, (int)numOfStepsthita);
                                if (j == numOfStepsx - 1)
                                {
                                    //...
                                }
                                else
                                {
                                    if (i % 2 != 0)
                                    {
                                        currx = currx - 35;
                                    }
                                    else
                                    {
                                        currx = currx + 35;
                                    }
                                }

                            }
                        }
                        currx = 10;
                        curry = 10;
                        //neasted loop for perform grid operation
                        for (int i = 0; i < numOfStepsthita; i++)//external loop
                        {
                            lstcommandhistory.Invalidate();
                            lstcommandhistory.Update();
                            lstcommandhistory.Refresh();
                            Application.DoEvents();
                            if (i == 0)
                            {
                                //no action for thita for first column of the grid
                            }
                            else
                            {
                                btnthitacw_Click(sender, e);//call thita cw direction button event
                                thitacounter += 1;
                                curry = curry + 35;
                            }

                            for (int j = 0; j < numOfStepsx; j++)//internal loop
                            {
                                if (cmbselectsignal.SelectedIndex == 0)
                                {
                                    btnpoweroncont_Click(sender, e);
                                    //sleep the system and waiting the transducer to make the job done
                                    timewait = 1000 * Convert.ToInt32(txtontimecontinious.Text);
                                    System.Threading.Thread.Sleep(timewait);
                                    timewait = 0;
                                    //stop generator
                                    turnOFFGenerator(0);
                                    //waiting time for the next sonication
                                    timewaitfornextsonication = 1000 * Convert.ToInt32(txttimefornextsonication.Text);
                                    System.Threading.Thread.Sleep(timewaitfornextsonication);
                                }
                                else if (cmbselectsignal.SelectedIndex == 1)
                                {
                                    btnpoweronpulsed_Click(sender, e);
                                    //sleep the system and waiting the transducer to make the job done
                                    timewait = 1000 * Convert.ToInt32(txtontimepulsed.Text);
                                    System.Threading.Thread.Sleep(timewait);
                                    timewait = 0;
                                    //stop generator
                                    turnOFFGenerator(1);
                                    System.Threading.Thread.Sleep(20000);
                                    //waiting time for the next sonication
                                    timewaitfornextsonication = 1000 * Convert.ToInt32(txttimefornextsonication.Text);
                                    System.Threading.Thread.Sleep(timewaitfornextsonication);
                                }
                                else if (cmbselectsignal.SelectedIndex == 4)
                                {
                                    //waiting time for the next sonication
                                    timewaitfornextsonication = 1000 * Convert.ToInt32(txttimefornextsonication.Text);
                                    System.Threading.Thread.Sleep(timewaitfornextsonication);
                                }
                                countsonications += 1;
                                string labelname = "";
                                BurnPattern(currx, curry, i, j, xcounter, thitacounter, labelname, "2D", (int)numOfStepsx, (int)numOfStepsthita);
                                //even numbers for fw direction
                                //odd numbers for rev direction
                                if (j == numOfStepsx - 1)
                                {
                                    //...

                                }
                                else
                                {
                                    lstcommandhistory.Invalidate();
                                    lstcommandhistory.Update();
                                    lstcommandhistory.Refresh();
                                    Application.DoEvents();
                                    if (direction % 2 != 0)
                                    {
                                        btnxfw_Click(sender, e);//call fw button event
                                        xcounter += 1;
                                        currx = currx + 35;
                                    }
                                    else
                                    {
                                        btnxrev_Click(sender, e);//call rev button event
                                        xcounter += 1;
                                        currx = currx - 35;
                                    }
                                }
                            }
                            direction += 1;//increase the steps
                        }
                        addCommandToHistoryList("Grid Operation: X number of steps " + numOfStepsx + " with MM " + numOfStepmmx + " and Θ number of steps " + numOfStepsthita + " with degress " + numOfStepdegrees + ", ");
                        change_gui_status(true);
                    }
                    else
                    {
                        MessageBox.Show("All the required parameters must be filled.", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //.....Grid Operation using RFG_1000 generator
                else if (gbrfg_1000.Enabled == true)
                {
                    //store the given parameters for the grid operation
                    double numOfStepsx = Convert.ToInt32(txtnxgrid.Text);
                    double numOfStepsthita = Convert.ToInt32(txtnthitagrid.Text);
                    double numOfStepmmx = Convert.ToInt32(txtnxstep.Text);
                    double numOfStepdegrees = Convert.ToInt32(txtnthitastep.Text);
                    if (numOfStepsx != 0 || numOfStepsthita != 0 || numOfStepmmx != 0 || numOfStepdegrees != 0)
                    {
                        int timewait = 0;//wait for the generator to finshed its operation
                        int direction = 1;//motion direction
                        int timewaitfornextsonication = 0;//time wait for next operation
                        //set the values of motion duration 
                        txtxfw.Text = numOfStepmmx.ToString();
                        txtxrev.Text = numOfStepmmx.ToString();
                        txtthitacw.Text = numOfStepdegrees.ToString();
                        txtthitaccw.Text = numOfStepdegrees.ToString();
                        //neasted loop for perform grid operation
                        for (int i = 0; i < numOfStepsthita; i++)//external loop
                        {
                            if (i == 0)
                            {
                                //no action for thita for first column of the grid
                            }
                            else
                            {
                                btnthitacw_Click(sender, e);//call thita cw direction button event
                            }

                            for (int j = 0; j < numOfStepsx; j++)//internal loop
                            {
                                if (cmbselectsignal.SelectedIndex == 2)
                                {
                                    btnmode_Click(sender, e);
                                    //sleep the system and waiting the transducer to make the job done
                                    timewait = 1000 * Convert.ToInt32(txtcwtimeonRFG.Text);
                                    System.Threading.Thread.Sleep(timewait);
                                    timewait = 0;
                                    //stop generator
                                    stopW();
                                    //waiting time for the next sonication
                                    timewaitfornextsonication = 1000 * Convert.ToInt32(txttimefornextsonication.Text);
                                    System.Threading.Thread.Sleep(timewaitfornextsonication);
                                }
                                else if (cmbselectsignal.SelectedIndex == 3)
                                {
                                    btnmode_Click(sender, e);
                                    //sleep the system and waiting the transducer to make the job done
                                    timewait = 1000 * Convert.ToInt32(txtpwtineonRFG.Text);
                                    System.Threading.Thread.Sleep(timewait);
                                    timewait = 0;
                                    //stop generator
                                    stopW();
                                    //waiting time for the next sonication
                                    timewaitfornextsonication = 1000 * Convert.ToInt32(txttimefornextsonication.Text);
                                    System.Threading.Thread.Sleep(timewaitfornextsonication);
                                }
                                else if (cmbselectsignal.SelectedIndex == 4)
                                {
                                    //waiting time for the next sonication
                                    timewaitfornextsonication = 1000 * Convert.ToInt32(txttimefornextsonication.Text);
                                    System.Threading.Thread.Sleep(timewaitfornextsonication);
                                }
                                //even numbers for fw direction
                                //odd numbers for rev direction
                                if (direction % 2 != 0)
                                {
                                    btnxfw_Click(sender, e);//call fw button event
                                }
                                else
                                {
                                    btnxrev_Click(sender, e);//call rev button event
                                }
                            }
                            direction += 1;//increase the steps
                        }
                        addCommandToHistoryList("Grid Operation: X number of steps " + numOfStepsx + " with MM " + numOfStepmmx + " and Θ number of steps " + numOfStepsthita + " with degress " + numOfStepdegrees + ", ");

                    }
                    else
                    {
                        MessageBox.Show("All the required parameters must be filled.", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        }

        

        private void cmbselecttransducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"" + excelfilefullpath.Replace(" ", ""));
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            string specs = "";
            int myindex = 0;
            myindex = cmbselecttransducer.SelectedIndex + 1;

            for (int i = 1; i <= rowCount; i++)
            {
                if (i == myindex)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        specs = specs + ", " + xlRange.Cells[i, j].Value.ToString();
                    }
                    txttransducerspecs.Text = specs;
                    return;
                }
                
            }
            xlWorkbook.Close(false, Type.Missing, Type.Missing);
            xlApp.Quit();
            addCommandToHistoryList("Select a transducer ");
            addCommandToHistoryList("A trancduser has been selected. The details has been shown.");
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

 

        //button event used for checking the connection with NI DAQ
        private void btnniconnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            try
            {
                using (Task digitalWriteTask = new Task())
                {
                    //beta connection testing with NI DAQ
                    deviceid = cmbdeviceid.Text;
                    robottype = cmbrobotsection.Text;
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    bool[] dataArray = new bool[8];
                    dataArray[0] = true;
                    dataArray[1] = true;
                    dataArray[2] = true;
                    dataArray[3] = true;
                    dataArray[4] = true;
                    dataArray[5] = true;
                    dataArray[6] = true;
                    dataArray[7] = true;
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    lbldaqstatus.Text = "NI DAQ is connected.";
                    lbldaqstatus.ForeColor = Color.Green;
                    //enable the button used for control the DAQ device
                    if (robottype == "2D_Robot (X - Θ)")
                    {
                        btnxfw.Enabled = true;
                        btnxrev.Enabled = true;
                        btnthitacw.Enabled = true;
                        btnthitaccw.Enabled = true;
                        btnmxfw.Enabled = true;
                        btnmcrev.Enabled = true;
                        btnmcw.Enabled = true;
                        btnmccw.Enabled = true;
                        btnstartgrid.Enabled = true;
                        btnstopnow.Enabled = true;
                        //cmbdeviceid.Enabled = false;
                        btnxthitaposition.Enabled = true;
                        btnyforward_3d.Text = "Y Left";
                        btnyreverse_3d.Text = "Y Right";
                        btnthitacw4d.Text = "Θ CW";
                        btnthitaccw4d.Text = "Θ CCW";
                    }
                    else if (robottype == "3D_Robot (X - Y - Z)")
                    {
                        btnxforward_3d.Enabled = true;
                        btnxreverse_3d.Enabled = true;
                        btnyforward_3d.Enabled = true;
                        btnyreverse_3d.Enabled = true;
                        btnzforward_3d.Enabled = true;
                        btnzreverse_3d.Enabled = true;
                        btnstart3dgrid.Enabled = true;
                        btnXYZzerocurentposition.Enabled = true;
                        btnXYZzerocurentposition.Text = "X - Y - Z";
                        btnstartgridXYImmersed.Visible = false;
                        btnstart3dgrid.Visible = true;
                        btnyforward_3d.Text = "Y Left";
                        btnyreverse_3d.Text = "Y Right";
                        btnthitacw4d.Text = "Θ CW";
                        btnthitaccw4d.Text = "Θ CCW";
                    }
                    else if (robottype == "4D_Robot (X - Y - Z - Θ)")
                    {
                        btnxforward_3d.Enabled = true;
                        btnxreverse_3d.Enabled = true;
                        btnyforward_3d.Enabled = true;
                        btnyreverse_3d.Enabled = true;
                        btnzforward_3d.Enabled = true;
                        btnzreverse_3d.Enabled = true;
                        btnstart3dgrid.Enabled = true;
                        btnthitacw4d.Enabled = true;
                        btnthitaccw4d.Enabled = true;
                        btnXYZzerocurentposition.Enabled = true;
                        btnXYZzerocurentposition.Text = "X - Y - Z - Θ";
                        btnstartgridXYImmersed.Visible = false;
                        btnstart3dgrid.Visible = true;
                        btnyforward_3d.Text = "Y Left";
                        btnyreverse_3d.Text = "Y Right";
                        btnthitacw4d.Text = "Θ CW";
                        btnthitaccw4d.Text = "Θ CCW";
                    }
                    else if (robottype == "2D Robot (X - Y, Immersed)")
                    {
                        btnxforward_3d.Enabled = true;
                        btnxreverse_3d.Enabled = true;
                        btnyforward_3d.Enabled = true;
                        btnyreverse_3d.Enabled = true;
                        btnstart3dgrid.Enabled = true;
                        btnXYZzerocurentposition.Enabled = true;
                        btnXYZzerocurentposition.Text = "X - Y";
                        btnstartgridXYImmersed.Visible = true;
                        btnstart3dgrid.Visible = false;
                        btnyforward_3d.Text = "Y Left";
                        btnyreverse_3d.Text = "Y Right";
                        btnthitacw4d.Text = "Θ CW";
                        btnthitaccw4d.Text = "Θ CCW";
                    }
                    else if (robottype == "4D_Prostate_Robot (X - Θ - Z - VΘ)")
                    {
                        btnxforward_3d.Enabled = true;
                        btnxreverse_3d.Enabled = true;
                        btnyforward_3d.Enabled = true;
                        btnyreverse_3d.Enabled = true;
                        btnzforward_3d.Enabled = true;
                        btnzreverse_3d.Enabled = true;
                        btnstart3dgrid.Enabled = true;
                        btnthitacw4d.Enabled = true;
                        btnthitaccw4d.Enabled = true;
                        btnXYZzerocurentposition.Enabled = true;
                        btnXYZzerocurentposition.Text = "X - Θ - Z - VΘ";
                        btnstartgridXYImmersed.Visible = false;
                        btnstartgridXYImmersed.Visible = true;
                        btnstart3dgrid.Visible = false;
                        btnyforward_3d.Text = "Θ Left";
                        btnyreverse_3d.Text = "Θ Right";
                        btnthitacw4d.Text = "VΘ CW";
                        btnthitaccw4d.Text = "VΘ CCW";
                    }
                    else if (robottype == "1D_Robot (X)")
                    {
                        lbl1Dtitle.Visible = true;
                        lbl1Dtitle1.Visible = true;
                        txt1Drepeats.Visible = true;
                        txt1Dseconds.Visible = true;
                        btn1Dgrid.Visible = true;
                        btnXYZzerocurentposition.Text = "X - Y - Z";
                        btnyforward_3d.Text = "Y Left";
                        btnyreverse_3d.Text = "Y Right";
                        btnthitacw4d.Text = "Θ CW";
                        btnthitaccw4d.Text = "Θ CCW";
                    }
                    addCommandToHistoryList("Successfull trial to connect with DAQ Device, ");
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                lbldaqstatus.Text = "NI DAQ is not connected.";
                lbldaqstatus.ForeColor = Color.Red;
                addCommandToHistoryList("Unsuccessfull trial to connect with DAQ Device, ");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnmcrev_Click(object sender, EventArgs e)
        {
            counter = 0;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (Task digitalWriteTask = new Task())
                {
                    deviceid = cmbdeviceid.Text;
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    bool[] dataArray = new bool[8];
                    dataArray[0] = true;
                    dataArray[1] = true;
                    dataArray[2] = true;
                    dataArray[3] = false;
                    dataArray[4] = true;
                    dataArray[5] = true;
                    dataArray[6] = true;
                    dataArray[7] = true;
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    addCommandToHistoryList("Manual Reverse movement on X Axis, ");

                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnmxfw_Click(object sender, EventArgs e)
        {
            counter = 0;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (Task digitalWriteTask = new Task())
                {
                    deviceid = cmbdeviceid.Text;
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    bool[] dataArray = new bool[8];
                    dataArray[0] = true;
                    dataArray[1] = true;
                    dataArray[2] = false;
                    dataArray[3] = true;
                    dataArray[4] = true;
                    dataArray[5] = true;
                    dataArray[6] = true;
                    dataArray[7] = true;
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    addCommandToHistoryList("Manual Forward movement on X Axis, ");

                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnmcw_Click(object sender, EventArgs e)
        {
            counter = 0;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (Task digitalWriteTask = new Task())
                {
                    deviceid = cmbdeviceid.Text;
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    bool[] dataArray = new bool[8];
                    dataArray[0] = true;
                    dataArray[1] = false;
                    dataArray[2] = true;
                    dataArray[3] = true;
                    dataArray[4] = true;
                    dataArray[5] = true;
                    dataArray[6] = true;
                    dataArray[7] = true;
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    addCommandToHistoryList("Manual Counter ClockWise rotation on Θ Axis ");
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnmccw_Click(object sender, EventArgs e)
        {
            counter = 0;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (Task digitalWriteTask = new Task())
                {
                    deviceid = cmbdeviceid.Text;
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    bool[] dataArray = new bool[8];
                    dataArray[0] = false;
                    dataArray[1] = true;
                    dataArray[2] = true;
                    dataArray[3] = true;
                    dataArray[4] = true;
                    dataArray[5] = true;
                    dataArray[6] = true;
                    dataArray[7] = true;
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    addCommandToHistoryList("Manual ClockWise rotation on Θ Axis ");
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnfolderselection_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFile.ShowDialog();//open the dialog box
                if (result == DialogResult.OK)//check if the user press Ok
                {

                    excelfilefullpath = openFile.FileName.ToString();
                    //Open the MS Excel Application
                    Excel.Application xlApp = new Excel.Application();
                    //Give the file name and location directory to open the file
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"" + excelfilefullpath.Replace(" ", ""));
                    //Give the name of the sheet being open
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    //Give the used cells range
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;//Get the number of rows on the target sheet
                    int colCount = xlRange.Columns.Count;//Get the number of columns on the target sheet

                    for (int i = 1; i <= rowCount; i++)//for loop for accessing all the cells in the sheet range
                    {
                        cmbselecttransducer.Items.Add(xlRange.Cells[i, 1].Value2.ToString());//read the specified cell
                    }
                    xlWorkbook.Close(false, Type.Missing, Type.Missing);//close the excel file when we are ready
                    xlApp.Quit();//close the applicaton
                    
                }
                

            }
            catch (Exception ex)//catch any errors during the execution of the try block
            {
                MessageBox.Show(ex.Message);//give the message in message box
            }

        }
        //function to append operation commands into command history list
        private void addCommandToHistoryList(string commandname)
        {
            try
            {
                string format = "HH:mm:ss";//selected time format
                lstcommandhistory.Items.Add(commandname + DateTime.Now.ToString(format));//add command to listbox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());//error message
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Robot and Ultrasound Control Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void clearCommandHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
        //function to add or delete new DAQ devices using notepad
        private void editDAQDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdaqsettings frmDAQ = new frmdaqsettings();
            frmDAQ.Show();
        }
        //the function fills the combo box that list all the available DAQ devices
        private void fill_ComboDeviceID()
        {
            try
            {
                // Read each line of the file into a string array. Each element 
                // of the array is one line of the file. 
                string[] lines = System.IO.File.ReadAllLines(@"C:\DAQ_Device.txt");
                cmbdeviceid.Items.Clear();
                //write lines to the combobox
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    cmbdeviceid.Items.Add(line);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbdeviceid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill_ComboDeviceID();
        }
        //function to store the commands list on a text file
        private void writeCommandHistoryToTextFile(ListBox commandlist)
        {
            try
            {
                //Open the File using new stream writer object
                System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\MRgFUS_Command_History.txt", true, Encoding.UTF8);

                sw.Write(Environment.NewLine);//store the new line to stream writer
                //store the current data and time on the stream writer
                sw.Write(DateTime.Today + Environment.NewLine + Environment.NewLine);

                //Writeout all the elements on the command history listbox.
                foreach (string item in commandlist.Items)
                {
                    //write the particular command on the stream writer object
                    sw.Write(item + Environment.NewLine);
                }

                //close the file
                sw.Close();
                //inform us about saving of the commands
                MessageBox.Show("The command history has been saved.", "Robot and Ultrasound Control Application",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void saveCommandHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeCommandHistoryToTextFile(lstcommandhistory);
        }

        private void clearCommandHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are going to clear the command history, are you sure?", "Robot and Ultrasound Control Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lstcommandhistory.Items.Clear();
            }
        }
        //function to retrieve the older commands for the text file
        private void openCommandHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string commandhistory;
                DialogResult result = openFile.ShowDialog();//open the dialog box
                if (result == DialogResult.OK)//check if the user press Ok
                {
                    //temporary store the commands on a variable
                    commandhistory = openFile.FileName.ToString();
                    //display the commands using notepad application
                    System.Diagnostics.Process.Start("notepad.exe", commandhistory);
                }
            }
            catch (Exception ex)//catch any errors during the execution of the try block
            {
                MessageBox.Show(ex.Message);//give the message in message box
            }
        }

        private void openPatientsDataFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        


       

        private void btnXYZzerocurentposition_Click(object sender, EventArgs e)
        {
            txtxposition_3d.Text = "0";
            txtyposition_3d.Text = "0";
            txtzposition_3d.Text = "0";
            txtthitaposition_4D.Text = "0";
        }


        private void goxForward(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (110 - Convert.ToDouble(txtxposition_3d.Text));

            mm = ((mm - 0.1) / 25.4) * 500;//get the parameter in millimeters
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())//create digital writer task
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    //initialize the elements with the prober parameter

                    dataArray = DAQsettings.PortsXr;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //1 for forward direction
                    getEdgeCounterValue2DX(Convert.ToInt32(mm), 1);


                }
            }
            catch (DaqException ex)//catch the errors if any
            {
                MessageBox.Show(ex.Message);//display the errors in a msg box
            }
            finally//after completing the try block
            {
                Cursor.Current = Cursors.Default;//To return back the default behavior
            }
        }
        private void btnxforward_3d_Click(object sender, EventArgs e)
        {
            if (robottype == "2D Robot (X - Y, Immersed)")
            {
                goxForwardAtoL(Double.Parse(txtxforward_3d.Text));
            }
            else
            {
                goxForward(Double.Parse(txtxforward_3d.Text));
            }
        }
        private void goxForwardAtoL(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (110 - Convert.ToDouble(txtxposition_3d.Text));

            //convertion formula from mm to angular DPI
            mm = ((int)(Math.Round((2500 * mm) / 360.0)) * 60) - 25;
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())//create digital writer task
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    //initialize the elements with the prober parameter
                    //11011111

                        dataArray = DAQsettings.PortsXr;
                    
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //1 for forward direction
                    getEdgeCounterValueThitatoX(Convert.ToInt32(mm), 0);
                }
            }
            catch (DaqException ex)//catch the errors if any
            {
                MessageBox.Show(ex.Message);//display the errors in a msg box
            }
            finally//after completing the try block
            {
                Cursor.Current = Cursors.Default;//To return back the default behavior
            }
        }
        private void goxReverseAtoL(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (Convert.ToDouble(txtxposition_3d.Text) - mm);

            mm = ((int)(Math.Round((2500 * mm) / 360.0)) * 60) - 25;
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];

                        dataArray = DAQsettings.PortsX;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValueThitatoX(Convert.ToInt32(mm), 1);


                }
            }
            catch (DaqException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void goyForwardAtoL(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (Convert.ToDouble(txtyposition_3d.Text) - mm);

            //convertion formula from mm to angular DPI
            mm = ((int)(Math.Round((2500 * mm) / 360.0)) * 8.4);
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];

                    dataArray = DAQsettings.PortsYr;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValueThitatoY(Convert.ToInt32(mm), 0);


                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void goyReverseAtoL(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (110 - Convert.ToDouble(txtyposition_3d.Text));
            //convertion formula from mm to angular DPI
            mm = ((int)(Math.Round((2500 * mm) / 360.0)) * 8.4);
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];

                    dataArray = DAQsettings.PortsY;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValueThitatoY(Convert.ToInt32(mm), 1);


                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void goxReverse(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (Convert.ToDouble(txtxposition_3d.Text) - mm);

            mm = ((mm - 0.1) / 25.4) * 500;
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];

                    dataArray = DAQsettings.PortsX;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValue2DX(Convert.ToInt32(mm), 0);


                }
            }
            catch (DaqException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnxreverse_3d_Click(object sender, EventArgs e)
        {
            if (robottype == "2D Robot (X - Y, Immersed)")
            {
                goxReverseAtoL(Double.Parse(txtxReverse_3d.Text));
            }
            else
            {
                goxReverse(Double.Parse(txtxReverse_3d.Text));
            }
            
        }
        private void goyForward(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (Convert.ToDouble(txtyposition_3d.Text) - mm);

            mm = ((mm - 0.1) / 25.4) * 500;
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];

                    dataArray = DAQsettings.PortsYr;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValue2DY(Convert.ToInt32(mm), 1);


                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnyforward_3d_Click(object sender, EventArgs e)
        {
            if (robottype == "2D Robot (X - Y, Immersed)")
            {
                goyForwardAtoL(Double.Parse(txtyForward_3d.Text));
            }
            else if (robottype == "4D_Prostate_Robot (X - Θ - Z - VΘ)")
            {
                gothitaHcw(Double.Parse(txtyForward_3d.Text));
            }
            else
            {
                goyForward(Double.Parse(txtyForward_3d.Text));
            }
        }
        private void gothitaHcw(double distance)
        {
            int edgecount = 0;
            double degress = 0;

            degress = distance;//get the parameter in degrees
            //edgecount = ((int)(Math.Round((2500 * degress) / 360.0))* 31) - 20;//breast
            edgecount = ((int)(Math.Round((2500 * degress) / 360.0)));
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())//create digital writer task
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    //initialize the elements with the prober parameter
                    dataArray = DAQsettings.PortsThitar;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    getEdgeCounterValuethita(Convert.ToInt32(edgecount), 0);
                }

            }
            catch (DaqException ex)//catch the errors if any
            {
                MessageBox.Show(ex.Message);//display the errors in a msg box
            }
            finally//after completing the try block
            {
                Cursor.Current = Cursors.Default;//To return back the default behavior
            }
        }
        private void gothitaHccw(double distance)
        {
            int edgecount = 0;
            double degress = 0;

            degress = distance;//get the parameter in degrees
            //edgecount = ((int)(Math.Round((2500 * degress) / 360.0))* 31) - 20;//breast
            edgecount = ((int)(Math.Round((2500 * degress) / 360.0)));
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())//create digital writer task
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    //initialize the elements with the prober parameter
                    dataArray = DAQsettings.PortsThita;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    getEdgeCounterValuethita(Convert.ToInt32(edgecount), 0);
                }

            }
            catch (DaqException ex)//catch the errors if any
            {
                MessageBox.Show(ex.Message);//display the errors in a msg box
            }
            finally//after completing the try block
            {
                Cursor.Current = Cursors.Default;//To return back the default behavior
            }
        }
        private void goyReverse(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (110 - Convert.ToDouble(txtyposition_3d.Text));
            mm = ((mm - 0.1) / 25.4) * 500;
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    dataArray = DAQsettings.PortsY;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValue2DY(Convert.ToInt32(mm), 0);


                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnyreverse_3d_Click(object sender, EventArgs e)
        {
            if (robottype == "2D Robot (X - Y, Immersed)")
            {
                goyReverseAtoL(Double.Parse(txtyReverse_3d.Text));
            }
            else if (robottype == "4D_Prostate_Robot (X - Θ - Z - VΘ)")
            {
                gothitaHccw(Double.Parse(txtyReverse_3d.Text));
            }
            else
            {
                goyReverse(Double.Parse(txtyReverse_3d.Text));
            }
        }

        private void gozForward(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            availablespace = (Convert.ToDouble(txtzposition_3d.Text) - mm);

            mm = ((mm - 0.1) / 25.4) * 500;
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];

                    dataArray = DAQsettings.PortsZ;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValue3DZ(Convert.ToInt32(mm), 0);


                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnzforward_3d_Click(object sender, EventArgs e)
        {
            gozForward(Double.Parse(txtzForward_3d.Text));
        }

        private void gozReverse(double distance)
        {
            double mm = 0;//store the number of dots (line) required for completing the motion
            counter = 0;
            //double availablespace = 0;
            //convert the millimeters in dot per inche and substract the error constunt (0.1)
            mm = distance;
            //availablespace = (Convert.ToDouble(txtzposition_3d.Text) - mm);

            mm = ((mm - 0.1) / 25.4) * 500;
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];

                    dataArray = DAQsettings.PortsZr;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    //call the function edge counter value by passing two parameters, the number of lines covered and the direction
                    //0 for reverse direction
                    getEdgeCounterValue3DZ(Convert.ToInt32(mm), 1);


                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnzreverse_3d_Click(object sender, EventArgs e)
        {
            gozReverse(Double.Parse(txtzReverse_3d.Text));           
        }

        
        //function used to get the last two (or any) characters of a string value
        public string GetLast(string source, int tail_length)
        {
            if (tail_length >= source.Length)
            {
                return source;
            }
            return source.Substring(source.Length - tail_length);
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            txtxforward_3d.Text = Convert.ToString(hScrollBar4.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            txtxReverse_3d.Text = Convert.ToString(hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            txtyForward_3d.Text = Convert.ToString(hScrollBar2.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txtyReverse_3d.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void hScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {
            txtzForward_3d.Text = Convert.ToString(hScrollBar6.Value);
        }

        private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
        {
            txtzReverse_3d.Text = Convert.ToString(hScrollBar5.Value);
        }


        //visual pattern functions
        private void createPattern(int x, int y, int i, int j, string whatpattern, int nofx, int nofy)
        {
            newlbl = new Label();
            newlbl.Name = "lbl" + i.ToString() + "_" + j.ToString();
            newlbl.Text = "";
            if((nofx > 8) || (nofy > 8))
            {
                newlbl.Size = new System.Drawing.Size(10, 10);

            }
            else
            {
                newlbl.Size = new System.Drawing.Size(30, 30);
                
            }
            newlbl.Location = new System.Drawing.Point(x, y);
            newlbl.BackColor = System.Drawing.Color.Blue;
            if (whatpattern != "3D")
            {
                this.gridpattern2D.Controls.Add(newlbl);
            }
            else
            {
                this.gridpattern.Controls.Add(newlbl);
            }
        }

        private void BurnPattern(int x, int y, int i, int j, int nx, int ny, string whatpattern, string type, int nofx, int nofy)
        {
            newlbl = new Label();
            newlbl.Name = "Blbl" + i.ToString() + "_" + j.ToString();
            newlbl.Text = ""; //whatpattern + "_" + n.ToString();
            if ((nofx > 8) || (nofy > 8))
            {
                newlbl.Size = new System.Drawing.Size(10, 10);

            }
            else
            {
                newlbl.Size = new System.Drawing.Size(30, 30);
                
            }
            newlbl.Location = new System.Drawing.Point(x, y);
            newlbl.BackColor = System.Drawing.Color.Red;
            if (type != "3D")
            {
                this.gridpattern2D.Controls.Add(newlbl);
            }
            else
            {
                this.gridpattern.Controls.Add(newlbl);
                lblvisualX.Text = nx.ToString();
                lblvisualY.Text = ny.ToString();
                lblvisualZ.Text = (int.Parse(txt3dgridzsteps.Text) + 1).ToString();
            }
            
            newlbl.BringToFront();
            
        }
        private void btnstart3dgrid_Click(object sender, EventArgs e)
        {
            //clear the visual pattern
            this.gridpattern.Controls.Clear();
            //store the given parameters for the grid operation
            double numOfStepsx = Convert.ToInt32(txt3dgrid_xsteps.Text);
            double numOfStepsy = Convert.ToInt32(txt3dgrid_ysteps.Text);
            double numOfStepmmx = Convert.ToInt32(txt3dgrid_xsteps_mm.Text);
            double numOfStepmmy = Convert.ToInt32(txt3dgrid_ysteps_mm.Text);
            double numOfStepsz = Convert.ToInt32(txt3dgridzsteps.Text);
            double numOfStepmmz = Convert.ToInt32(txt3dgrid_zsteps_mm.Text);
            int countsonications = 0;
            double totalmmyaxis = (numOfStepmmy * numOfStepsy) - numOfStepmmy;
            double totalmmxaxis = (numOfStepmmx * numOfStepsx) - numOfStepmmx;
            int xcounter = 1;
            int ycounter = 1;
            int zcounter = 1;
            //plot the pattern
            //int currdirectionsX = 0;
            //int currdirectionsY = 0;
            lbltotalnumberofsonications.Text = ((numOfStepsx * numOfStepsy)* (numOfStepsz + 1)).ToString();


            if (numOfStepsx != 0 || numOfStepsy != 0 || numOfStepmmx != 0 || numOfStepmmy != 0)
            {
                //hide grid operation
                //coverform hidegrid = new coverform();
                //hidegrid.Show();

                frmgridactions gridactions = new frmgridactions();
                gridactions.Show();
                gridactions.gridCancel = false;
                gridactions.gridPause = false;

                //frmgridprogress gridprogress = new frmgridprogress();
                //gridprogress.Show();

                int timewait = 0;//wait for the generator to finshed its operation
                int direction = 1;//motion direction
                int timewaitfornextsonication = 0;//time wait for next operation
                //set the values of motion duration 
                txtxforward_3d.Text = numOfStepmmx.ToString();
                txtxReverse_3d.Text = numOfStepmmx.ToString();
                txtyForward_3d.Text = numOfStepmmy.ToString();
                txtyReverse_3d.Text = numOfStepmmy.ToString();
                txtzForward_3d.Text = numOfStepmmz.ToString();
                txtzReverse_3d.Text = numOfStepmmz.ToString();

                //disable GUI
                change_gui_status(false);
                //the following neasted loop creates the visual grid pattern
                currx = 10;
                curry = 10;
                for (int i = 0; i < numOfStepsy; i++)
                {

                    if (i == 0)
                    {

                    }
                    else
                    {
                        curry = curry + 35;
                    }
                    for (int j = 0; j < numOfStepsx; j++)
                    {

                        createPattern(currx, curry, i, j, "3D", (int)numOfStepsx, (int)numOfStepsy);
                        if (j == numOfStepsx - 1)
                        {
                            //...
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                currx = currx - 35;
                            }
                            else
                            {
                                currx = currx + 35;
                            }
                        }

                    }
                }
                currx = 10;
                curry = 10;
                //Z stage loop
                for(int z = 0; z <= numOfStepsz; z++)
                {
                    lstcommandhistory.Invalidate();
                    lstcommandhistory.Update();
                    lstcommandhistory.Refresh();
                    Application.DoEvents();
                    if (gridactions.gridCancel == true)
                    {
                        change_gui_status(true);
                        gridactions.Close();
                        MessageBox.Show("The grid operation has been canceled.");
                        return;
                    }
                    else if (gridactions.gridPause == true)
                    {
                        while (gridactions.gridPause == true)
                        {
                            //wait here....
                            Application.DoEvents();
                        }
                    }
                     if(z == 0)
                      {
                          //no action for Z stage
                      }
                      else
                      {
                          //go to initial position
                         currx = 10; 
                         curry = 10;
                         direction = 1;
                         if (numOfStepsy % 2 != 0)
                         {
                             goxReverse(totalmmxaxis);
                         }
                         goyForward(totalmmyaxis);
                         gozForward(numOfStepmmz);
                         zcounter += 1;
                      }
                    //neasted loop for perform grid operation
                    for (int i = 0; i < numOfStepsy; i++)//external loop
                    {
                        lstcommandhistory.Invalidate();
                        lstcommandhistory.Update();
                        lstcommandhistory.Refresh();
                        Application.DoEvents();
                        if (gridactions.gridCancel == true)
                        {
                            change_gui_status(true);
                            gridactions.Close();
                            MessageBox.Show("The grid operation has been canceled.");
                            return;
                        }
                        else if (gridactions.gridPause == true)
                        {
                            while (gridactions.gridPause == true)
                            {
                                //wait here....
                                Application.DoEvents();
                            }
                        }
                        if (i == 0)
                        {
                            //no action for y for first column of the grid
                        }
                        else
                        {
                            btnyreverse_3d_Click(sender, e);//call y forward direction button event
                            ycounter += 1;
                            curry = curry + 35;
                        }

                        for (int j = 0; j < numOfStepsx; j++)//internal loop
                        {
                            lstcommandhistory.Invalidate();
                            lstcommandhistory.Update();
                            lstcommandhistory.Refresh();
                            Application.DoEvents();
                            if (gridactions.gridCancel == true)
                            {
                                change_gui_status(true);
                                gridactions.Close();
                                //gridprogress.Close();
                                MessageBox.Show("The grid operation has been canceled.");
                                return;
                            }
                            else if (gridactions.gridPause == true)
                            {
                                while (gridactions.gridPause == true)
                                {
                                    //wait here....
                                    Application.DoEvents();
                                }
                            }
                            if (cmbXYZselectsignal.SelectedIndex == 0)
                            {
                                btnpoweroncont_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtontimecontinious.Text);
                                //display progress settings

                                
                                System.Threading.Thread.Sleep(timewait);


                                timewait = 0;
                                //stop generator
                                turnOFFGenerator(0);
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);

                                System.Threading.Thread.Sleep(timewaitfornextsonication);

                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 1)
                            {
                                btnpoweronpulsed_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtontimepulsed.Text);
                               
                                
                                System.Threading.Thread.Sleep(timewait);
                                timewait = 0;
                                //stop generator
                                turnOFFGenerator(1);
                                
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 2)
                            {
                                btnmode_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtcwtimeonRFG.Text);
                                System.Threading.Thread.Sleep(timewait);
                                timewait = 0;
                                //stop generator
                                stopW();
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 3)
                            {
                                btnmode_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtpwtineonRFG.Text);
                                System.Threading.Thread.Sleep(timewait);
                                timewait = 0;
                                //stop generator
                                stopW();
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 4)
                            {
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            countsonications += 1;
                            string labelname = "Z" + z.ToString();
                            BurnPattern(currx, curry, i, j, xcounter, ycounter, labelname, "3D", (int)numOfStepsx, (int)numOfStepsy);
                            lblcurrentsonication.Text = countsonications.ToString();
                            //even numbers for fw direction
                            //odd numbers for rev direction
                            if (j == numOfStepsx - 1)
                            {
                                //...

                            }
                            else
                            {
                                lstcommandhistory.Invalidate();
                                lstcommandhistory.Update();
                                lstcommandhistory.Refresh();
                                Application.DoEvents();
                                if (gridactions.gridCancel == true)
                                {
                                    change_gui_status(true);
                                    gridactions.Close();
                                    MessageBox.Show("The grid operation has been canceled.");
                                    return;
                                }
                                else if (gridactions.gridPause == true)
                                {
                                    while (gridactions.gridPause == true)
                                    {
                                        //wait here....
                                        Application.DoEvents();
                                    }
                                }
                                if (direction % 2 != 0)
                                {
                                    btnxforward_3d_Click(sender, e);//call fw button event
                                    xcounter += 1;
                                    currx = currx + 35;
                                }
                                else
                                {
                                    btnxreverse_3d_Click(sender, e);//call rev button event
                                    xcounter += 1;
                                    currx = currx - 35;
                                }
                            }
                        }
                        direction += 1;//increase the steps
                    }
                }

                //close cover form
                //hidegrid.Close();
                //Enable GUI
                change_gui_status(true);
                addCommandToHistoryList("Grid Operation: X number of steps " + numOfStepsx + " with MM " + numOfStepmmx + ", Y number of steps " + numOfStepsy + " with MM " + numOfStepmmy + "and Z number of steps " + numOfStepsz + " with MM " + numOfStepmmz + ", ");
                MessageBox.Show("The grid operation has been completed. Pattern: X number of steps " + numOfStepsx + " with MM " + numOfStepmmx + ", Y number of steps " + numOfStepsy + " with MM " + numOfStepmmy + "and Z number of steps " + numOfStepsz + " with MM " + numOfStepmmz + ".");
                gridactions.Close();
            }
            else
            {
                MessageBox.Show("All the required parameters must be filled.", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void change_gui_status(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enabled;
            }
            if (enabled == false)
            {
                btnstart3dgrid.BackColor = Color.Red;
            }
            else
            {
                btnstart3dgrid.BackColor = Color.Transparent;
            }
        }
        private void btn1Dgrid_Click(object sender, EventArgs e)
        {
            int numberOftimetoRepeat = Int16.Parse(txt1Drepeats .Text) * 2;
            //BW_Ultrasound1D.RunWorkerAsync();
            for (int i = 0; i < numberOftimetoRepeat; i++)
            {
                if(i % 2 != 0)
                {
                    btnmxfw_Click(sender, e);
                    //waiting time...
                    System.Threading.Thread.Sleep(200);
                    btnstopnow_Click(sender, e);
                    //btnmode_Click(sender, e);
                    //btnpoweroncont_Click(sender, e);
                    System.Threading.Thread.Sleep((Convert.ToInt32(txt1Dseconds.Text) * 1000));
                    //btnpoweroffcont_Click(sender, e);
                    
                }
                else
                {
                    btnmcrev_Click(sender, e);
                    //waiting time...
                    System.Threading.Thread.Sleep(200);
                    btnstopnow_Click(sender, e);
                   
                }
                
            }

        }

        private void timer1Drobot_Tick(object sender, EventArgs e)
        {
            counter1D = counter1D + 1;
            if (counter1D == int.Parse (txt1Dseconds.Text))
            {
                timer1Drobot.Enabled = false;
                counter1D = 0;
                return;
            }
        }



        private void lstcommandhistory_Click(object sender, EventArgs e)
        {
            
            string line = lstcommandhistory.SelectedItem.ToString();
            string[] separatetokens = line.Split();


        }


        private void txt1Dseconds_TextChanged(object sender, EventArgs e)
        {
            txtontimecontinious.Text = txt1Dseconds.Text;
        }

        private void cmbselectsignal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbXYZselectsignal_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnstart3dgrid.Enabled = true;
        }

        private void txttimedelayforcw_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txttimedelayforcw.Text) > 0)
            {
                txtrepeatsforcw.Enabled = true;
                cwsignalwithrepeats = true;
            }
            else
            {
                txtrepeatsforcw.Enabled = false;
                txtrepeatsforcw.Text = "1";
                cwsignalwithrepeats = false;
            }
        }

        private void hScrollBar8_Scroll(object sender, ScrollEventArgs e)
        {
            txtthitacw4d.Text = Convert.ToString(hScrollBar8.Value);
        }

        private void hScrollBar7_Scroll(object sender, ScrollEventArgs e)
        {
            txtthitaccw4d.Text = Convert.ToString(hScrollBar7.Value);
        }

        private void btnthitacw4d_Click(object sender, EventArgs e)
        {
            gothitacw(Convert.ToDouble(txtthitacw4d.Text));
        }

        private void gothitacw(double distance)
        {
            int edgecount = 0;
            double degress = 0;

            degress = distance;//get the parameter in degrees
            //edgecount = ((int)(Math.Round((2500 * degress) / 360.0))* 31) - 20;//breast
            edgecount = ((int)(Math.Round((2500 * degress) / 360.0)));
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())//create digital writer task
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    //initialize the elements with the prober parameter
                    dataArray = DAQsettings.PortsThitar;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    getEdgeCounterValuethita(Convert.ToInt32(edgecount), 0);
                }
                
            }
            catch (DaqException ex)//catch the errors if any
            {
                MessageBox.Show(ex.Message);//display the errors in a msg box
            }
            finally//after completing the try block
            {
                Cursor.Current = Cursors.Default;//To return back the default behavior
            }
        }

        private void gothitaccw(double distance)
        {
            int edgecount = 0;
            double degress = 0;

            degress = distance;//get the parameter in degrees
            //edgecount = ((int)(Math.Round((2500 * degress) / 360.0))* 31) - 20;//breast
            edgecount = ((int)(Math.Round((2500 * degress) / 360.0)));
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())//create digital writer task
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(deviceid + "/Port0/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    //initialize the elements with the prober parameter

                    dataArray = DAQsettings.PortsThita;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                    getEdgeCounterValuethita(Convert.ToInt32(edgecount), 1);
                }
            }
            catch (DaqException ex)//catch the errors if any
            {
                MessageBox.Show(ex.Message);//display the errors in a msg box
            }
            finally//after completing the try block
            {
                Cursor.Current = Cursors.Default;//To return back the default behavior
            }
        }

        private void btnthitaccw4d_Click(object sender, EventArgs e)
        {
            gothitaccw(Convert.ToDouble(txtthitaccw4d.Text));
        }

        private void rBsetgrid_CheckedChanged(object sender, EventArgs e)
        {
            txt3dgrid_xsteps.Text = "0";
            txt3dgrid_xsteps_mm.Text = "0";
            txt3dgrid_ysteps.Text = "0";
            txt3dgrid_ysteps_mm.Text = "0";
            txt3dgridzsteps.Text = "0";
            txt3dgrid_zsteps_mm.Text = "0";
            addCommandToHistoryList("Set manual grid operation.");
        }

        private void rBgetgrid_CheckedChanged(object sender, EventArgs e)
        {
            preset_grid = read_Grid_Pattern();
            addCommandToHistoryList("Get preset grid operation.");
            txt3dgrid_xsteps.Text = preset_grid.GetLength(0).ToString();
            txt3dgrid_ysteps.Text = preset_grid.GetLength(1).ToString();
        }

        int[,] read_Grid_Pattern()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\WriteGridPattern.txt");
            int i = 0, j = 0;
            foreach (var row in lines)
            {
                j = 0;
                foreach (var col in row.Trim().Split(','))
                {
                    int number;
                    if (int.TryParse(col.Trim(), out number) == true)
                    {
                        j++;
                    }
                }
                i++;
            }
            int[,] result = new int[i, j];
            i = 0;
            j = 0;

            foreach (var row in lines)
            {
                j = 0;
                foreach (var col in row.Trim().Split(','))
                {
                    int number;
                    if (int.TryParse(col.Trim(), out number) == true)
                    {
                        result[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                }
                i++;
            }


            return result;
        }

        private void clearPresetGridOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\WriteGridPattern.txt"))
            {
                File.Delete(@"C:\WriteGridPattern.txt");
            }
            File.Create(@"C:\WriteGridPattern.txt").Close();
            
            MessageBox.Show("The grid operation has been cleared!!!");
        }

        private void btnstartgridXYImmersed_Click(object sender, EventArgs e)
        {
            //clear the visual pattern
            this.gridpattern.Controls.Clear();
            //store the given parameters for the grid operation
            double numOfStepsx = Convert.ToInt32(txt3dgrid_xsteps.Text);
            double numOfStepsy = Convert.ToInt32(txt3dgrid_ysteps.Text);
            double numOfStepmmx = Convert.ToInt32(txt3dgrid_xsteps_mm.Text);
            double numOfStepmmy = Convert.ToInt32(txt3dgrid_ysteps_mm.Text);
            int countsonications = 0;
            double totalmmyaxis = (numOfStepmmy * numOfStepsy) - numOfStepmmy;
            double totalmmxaxis = (numOfStepmmx * numOfStepsx) - numOfStepmmx;
            int xcounter = 1;
            int ycounter = 1;
            lbltotalnumberofsonications.Text = (numOfStepsx * numOfStepsy).ToString();
            //plot the pattern
            //int currdirectionsX = 0;
            //int currdirectionsY = 0;

            

            if (numOfStepsx != 0 || numOfStepsy != 0 || numOfStepmmx != 0 || numOfStepmmy != 0)
            {
                //hide grid operation
                //coverform hidegrid = new coverform();
                //hidegrid.Show();

                //enable grid actions
                frmgridactions gridactions = new frmgridactions();
                gridactions.Show();
                gridactions.gridCancel = false;
                gridactions.gridPause = false;

                int timewait = 0;//wait for the generator to finshed its operation
                int direction = 1;//motion direction
                int timewaitfornextsonication = 0;//time wait for next operation
                //set the values of motion duration 
                txtxforward_3d.Text = numOfStepmmx.ToString();
                txtxReverse_3d.Text = numOfStepmmx.ToString();
                txtyForward_3d.Text = numOfStepmmy.ToString();
                txtyReverse_3d.Text = numOfStepmmy.ToString();

                //disable GUI
                change_gui_status(false);
                //the following neasted loop creates the visual grid pattern
                currx = 10;
                curry = 10;
                for (int i = 0; i < numOfStepsy; i++)
                {
                    

                    if (i == 0)
                    {

                    }
                    else
                    {
                        if (numOfStepsy > 8)
                        {
                            curry = curry + 15;
                        }
                        else
                        {
                            curry = curry + 35;
                        }
                    }
                    for (int j = 0; j < numOfStepsx; j++)
                    {

                        createPattern(currx, curry, i, j, "3D", (int)numOfStepsx, (int)numOfStepsy);
                        if (j == numOfStepsx - 1)
                        {
                            //...
                        }
                        else
                        {
                            if (i % 2 != 0)
                            {
                                if (numOfStepsx > 8)
                                {
                                    currx = currx - 15;
                                }
                                else
                                {
                                    currx = currx - 35;
                                }
                            }
                            else
                            {
                                if (numOfStepsx > 8)
                                {
                                    currx = currx + 15;
                                }
                                else
                                {
                                    currx = currx + 35;
                                }
                            }
                        }

                    }
                }
                currx = 10;
                curry = 10;
               
                    //neasted loop for perform grid operation
                    for (int i = 0; i < numOfStepsy; i++)//external loop
                    {
                        lstcommandhistory.Invalidate();
                        lstcommandhistory.Update();
                        lstcommandhistory.Refresh();
                        Application.DoEvents();
                        if (gridactions.gridCancel == true)
                        {
                            change_gui_status(true);
                            gridactions.Close();
                            MessageBox.Show("The grid operation has been canceled.");
                            return;
                        }
                        else if (gridactions.gridPause == true)
                        {
                            while (gridactions.gridPause == true)
                            {
                                //wait here....
                                Application.DoEvents();
                            }
                        }

                        if (i == 0)
                        {
                            //no action for y for first column of the grid
                        }
                        else
                        {
                            btnyreverse_3d_Click(sender, e);//call y forward direction button event
                            ycounter += 1;
                            if (numOfStepsy > 8)
                            {
                                curry = curry + 15;
                            }
                            else
                            {
                                curry = curry + 35;
                            }
                            
                        }

                        for (int j = 0; j < numOfStepsx; j++)//internal loop
                        {
                            lstcommandhistory.Invalidate();
                            lstcommandhistory.Update();
                            lstcommandhistory.Refresh();
                            Application.DoEvents();
                            if (gridactions.gridCancel == true)
                            {
                                change_gui_status(true);
                                gridactions.Close();
                                MessageBox.Show("The grid operation has been canceled.");
                                return;
                            }
                            else if (gridactions.gridPause == true)
                            {
                                while (gridactions.gridPause == true)
                                {
                                    //wait here....
                                    Application.DoEvents();
                                }
                            }

                            if (cmbXYZselectsignal.SelectedIndex == 0)
                            {
                                btnpoweroncont_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtontimecontinious.Text);
                                System.Threading.Thread.Sleep(timewait);
                                timewait = 0;
                                //stop generator
                                turnOFFGenerator(0);
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 1)
                            {
                                btnpoweronpulsed_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtontimepulsed.Text);
                                System.Threading.Thread.Sleep(timewait);
                                timewait = 0;
                                //stop generator
                                turnOFFGenerator(1);
                                System.Threading.Thread.Sleep(20000);
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 2)
                            {
                                btnmode_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtcwtimeonRFG.Text);
                                System.Threading.Thread.Sleep(timewait);
                                timewait = 0;
                                //stop generator
                                stopW();
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 3)
                            {
                                btnmode_Click(sender, e);
                                //sleep the system and waiting the transducer to make the job done
                                timewait = 1000 * Convert.ToInt32(txtpwtineonRFG.Text);
                                System.Threading.Thread.Sleep(timewait);
                                timewait = 0;
                                //stop generator
                                stopW();
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            else if (cmbXYZselectsignal.SelectedIndex == 4)
                            {
                                //waiting time for the next sonication
                                timewaitfornextsonication = 1000 * Convert.ToInt32(txtXYZwaitingtime.Text);
                                System.Threading.Thread.Sleep(timewaitfornextsonication);
                            }
                            countsonications += 1;
                            string labelname = "";
                            BurnPattern(currx, curry, i, j, xcounter, ycounter, labelname, "3D", (int)numOfStepsx, (int)numOfStepsy);
                            lblcurrentsonication.Text = countsonications.ToString();
                            //even numbers for fw direction
                            //odd numbers for rev direction
                            if (j == numOfStepsx - 1)
                            {
                                //...

                            }
                            else
                            {
                                lstcommandhistory.Invalidate();
                                lstcommandhistory.Update();
                                lstcommandhistory.Refresh();
                                Application.DoEvents();
                                if (gridactions.gridCancel == true)
                                {
                                    change_gui_status(true);
                                    gridactions.Close();
                                    MessageBox.Show("The grid operation has been canceled.");
                                    return;
                                }
                                else if (gridactions.gridPause == true)
                                {
                                    while (gridactions.gridPause == true)
                                    {
                                        //wait here....
                                        Application.DoEvents();
                                    }
                                }

                                if (direction % 2 != 0)
                                {
                                    btnxforward_3d_Click(sender, e);//call fw button event
                                    xcounter += 1;
                                    if (numOfStepsx > 8)
                                    {
                                        currx = currx + 15;
                                    }
                                    else
                                    {
                                        currx = currx + 35;
                                    }
                                    
                                }
                                else
                                {
                                    btnxreverse_3d_Click(sender, e);//call rev button event
                                    xcounter += 1;
                                    if (numOfStepsx > 8)
                                    {
                                        currx = currx - 15;
                                    }
                                    else
                                    {
                                        currx = currx - 35;
                                    }
                                }
                            }
                        }
                        direction += 1;//increase the steps
                    }

                //close cover form
                //hidegrid.Close();
                //Enable GUI
                change_gui_status(true);
                addCommandToHistoryList("Grid Operation: X number of steps " + numOfStepsx + " with MM " + numOfStepmmx + ", Y number of steps " + numOfStepsy + " with MM " + numOfStepmmy + ".");
                MessageBox.Show("The grid operation has been completed. Pattern: X number of steps " + numOfStepsx + " with MM " + numOfStepmmx + ", Y number of steps " + numOfStepsy + " with MM " + numOfStepmmy + ".");
                gridactions.Close();
            }
            else
            {
                MessageBox.Show("All the required parameters must be filled.", "Robot and Ultrasound Control Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

            

        //vacuum
        private void SetText(string text)
        {
            if (this.pbvacuum.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.pbvacuum.Value = Convert.ToInt32(text);
            }
        }
        private void SetChange(string text)
        {
            if (this.lblvacuumresult.InvokeRequired)
            {
                SetChangeCallback d = new SetChangeCallback(SetChange);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblvacuumresult.Text = text;
                vacuumThread.Abort();
                vacuumThread = null;
                pbvacuum.Value = 0;
                btnstopvacuum.Enabled = false;
            }
        }
        private void StartVacuum()
        {
            StartVacuumCleaner("/Dev3");
            for (int i = 1; i <= int.Parse(txtvacuumOntime.Text); i++)
            {
                System.Threading.Thread.Sleep(1000);
                SetText(i.ToString());
            }
            StopVacuum("/Dev3");
            SetChange("Vacuum operation has been completed!");

        }

        private void btnstartvacuum_Click(object sender, EventArgs e)
        {
            lblvacuumresult.Text = "";
            btnstopvacuum.Enabled = true;
            pbvacuum.Maximum = Convert.ToInt32(txtvacuumOntime.Text);
            vacuumThread = new Thread(StartVacuum);
            vacuumThread.Start();
        }

        private void btnstopvacuum_Click(object sender, EventArgs e)
        {
            StopVacuum("/Dev3");
            vacuumThread.Abort();
            vacuumThread = null;
            pbvacuum.Value = 0;
            btnstopvacuum.Enabled = false;
        }

        private void StartVacuumCleaner(string devID)
        {
            Cursor.Current = Cursors.WaitCursor;
            try//try block in order to catch errors if any without crashing the system
            {
                using (Task digitalWriteTask = new Task())//create digital writer task
                {
                    //deviceid = cmbdeviceid.Text;//get the selected NI DAQ device ID
                    //create a digital output channel by passing the correct parametrs
                    digitalWriteTask.DOChannels.CreateChannel(devID + "/Port1/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //create an array of 8 boolean elements
                    bool[] dataArray = new bool[8];
                    //initialize the elements with the prober parameter
                    dataArray[4] = false;
                    //set the array to digital writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    writer.WriteSingleSampleMultiLine(true, dataArray);
                }

            }
            catch (DaqException ex)//catch the errors if any
            {
                MessageBox.Show(ex.Message);//display the errors in a msg box
            }
            finally//after completing the try block
            {
                Cursor.Current = Cursors.Default;//To return back the default behavior
            }
        }

        private void StopVacuum(string devID)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (Task digitalWriteTask = new Task())
                {
                    
                    //create a digigtal output channel
                    digitalWriteTask.DOChannels.CreateChannel(devID + "/Port1/line0:7", "",
                        ChannelLineGrouping.OneChannelForAllLines);
                    //declear a boolean array of eight elements
                    bool[] dataArray = new bool[8];
                    //set all array elements to zero for stopping motors

                    dataArray[4] = true;

                    //create an instance of the digital channel writer
                    DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalWriteTask.Stream);
                    //send the eight element array to the device
                    writer.WriteSingleSampleMultiLine(true, dataArray);

                }
            }
            catch (DaqException ex)//catch the errors within the try block
            {
                MessageBox.Show(ex.Message);//display the errors 
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void txtvolume_TextChanged(object sender, EventArgs e)
        {
            txtvacuumOntime.Text = (Math.Round((Convert.ToInt32(txtvolume.Text) * Convert.ToDouble(txtvacuumrate.Text)), MidpointRounding.AwayFromZero)).ToString();
        }

        private void hScrollBar9_Scroll(object sender, ScrollEventArgs e)
        {
            txtvacuumOntime.Text = hScrollBar9.Value.ToString();
        }

        private void hScrollBar10_Scroll(object sender, ScrollEventArgs e)
        {
            txtvolume.Text = hScrollBar10.Value.ToString();
        }

        private void cmbportname_MouseClick(object sender, MouseEventArgs e)
        {
            getCOMPortNames();
        }
    }
}
