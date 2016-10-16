using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RobotControlApplication
{
    public partial class frmdaqsettings : Form
    {

             private bool [] X = new bool[8] { false, true, true, true, true, true, true, true };
             private bool [] Xr = new bool[8] { true, false, true, true, true, true, true, true };
             private string ecX = "/ctr0";
             private string scX = "/PFI8";

            private bool [] Y = new bool[8] { true, true, false, true, true, true, true, true };
            private bool [] Yr = new bool[8] { true, true, true, false, true, true, true, true };
            private string ecY = "/ctr1";
            private string scY = "/PFI3";

            private bool [] Z = new bool[8] { true, true, true, true, false, true, true, true };
            private bool [] Zr = new bool[8] { true, true, true, true, true, false, true, true };
            private string ecZ = "/ctr2";
            private string scZ = "/PFI0";

            private bool [] Thita = new bool[8] { true, true, true, true, true, true, false, true };
            private bool [] Thitar = new bool[8] { true, true, true, true, true, true, true, false };
            private string ecThita = "/ctr3";
            private string scThita = "/PFI5";

        public frmdaqsettings()
        {
            InitializeComponent();
        }

        private void frmdaqsettings_Load(object sender, EventArgs e)
        {
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string adddevice;
                DialogResult result = openFile.ShowDialog();//open the dialog box
                if (result == DialogResult.OK)//check if the user press Ok
                {
                    //temporary store the file to a variable
                    adddevice = openFile.FileName.ToString();
                    //display the file using notepad application
                    System.Diagnostics.Process.Start("notepad.exe", adddevice);
                }
            }
            catch (Exception ex)//catch any errors during the execution of the try block
            {
                MessageBox.Show(ex.Message);//give the message in message box
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = false;
            X[1] = true;
            X[2] = true;
            X[3] = true;
            X[4] = true;
            X[5] = true;
            X[6] = true;
            X[7] = true;
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = false;
            Xr[1] = true;
            Xr[2] = true;
            Xr[3] = true;
            Xr[4] = true;
            Xr[5] = true;
            Xr[6] = true;
            Xr[7] = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = true;
            X[1] = false;
            X[2] = true;
            X[3] = true;
            X[4] = true;
            X[5] = true;
            X[6] = true;
            X[7] = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = true;
            X[1] = true;
            X[2] = false;
            X[3] = true;
            X[4] = true;
            X[5] = true;
            X[6] = true;
            X[7] = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = true;
            X[1] = true;
            X[2] = true;
            X[3] = false;
            X[4] = true;
            X[5] = true;
            X[6] = true;
            X[7] = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = true;
            X[1] = true;
            X[2] = true;
            X[3] = true;
            X[4] = false;
            X[5] = true;
            X[6] = true;
            X[7] = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = true;
            X[1] = true;
            X[2] = true;
            X[3] = true;
            X[4] = true;
            X[5] = false;
            X[6] = true;
            X[7] = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = true;
            X[1] = true;
            X[2] = true;
            X[3] = true;
            X[4] = true;
            X[5] = true;
            X[6] = false;
            X[7] = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            X[0] = true;
            X[1] = true;
            X[2] = true;
            X[3] = true;
            X[4] = true;
            X[5] = true;
            X[6] = true;
            X[7] = false;
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = true;
            Xr[1] = false;
            Xr[2] = true;
            Xr[3] = true;
            Xr[4] = true;
            Xr[5] = true;
            Xr[6] = true;
            Xr[7] = true;
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = true;
            Xr[1] = true;
            Xr[2] = false;
            Xr[3] = true;
            Xr[4] = true;
            Xr[5] = true;
            Xr[6] = true;
            Xr[7] = true;
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = true;
            Xr[1] = true;
            Xr[2] = true;
            Xr[3] = false;
            Xr[4] = true;
            Xr[5] = true;
            Xr[6] = true;
            Xr[7] = true;
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = true;
            Xr[1] = true;
            Xr[2] = true;
            Xr[3] = true;
            Xr[4] = false;
            Xr[5] = true;
            Xr[6] = true;
            Xr[7] = true;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = true;
            Xr[1] = true;
            Xr[2] = true;
            Xr[3] = true;
            Xr[4] = true;
            Xr[5] = false;
            Xr[6] = true;
            Xr[7] = true;
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = true;
            Xr[1] = true;
            Xr[2] = true;
            Xr[3] = true;
            Xr[4] = true;
            Xr[5] = true;
            Xr[6] = false;
            Xr[7] = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = true;
            Y[1] = true;
            Y[2] = true;
            Y[3] = true;
            Y[4] = true;
            Y[5] = true;
            Y[6] = true;
            Y[7] = false;
            
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = false;
            Y[1] = true;
            Y[2] = true;
            Y[3] = true;
            Y[4] = true;
            Y[5] = true;
            Y[6] = true;
            Y[7] = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = true;
            Y[1] = false;
            Y[2] = true;
            Y[3] = true;
            Y[4] = true;
            Y[5] = true;
            Y[6] = true;
            Y[7] = true;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = true;
            Y[1] = true;
            Y[2] = false;
            Y[3] = true;
            Y[4] = true;
            Y[5] = true;
            Y[6] = true;
            Y[7] = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = true;
            Y[1] = true;
            Y[2] = true;
            Y[3] = false;
            Y[4] = true;
            Y[5] = true;
            Y[6] = true;
            Y[7] = true;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = true;
            Y[1] = true;
            Y[2] = true;
            Y[3] = true;
            Y[4] = false;
            Y[5] = true;
            Y[6] = true;
            Y[7] = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = true;
            Y[1] = true;
            Y[2] = true;
            Y[3] = true;
            Y[4] = true;
            Y[5] = false;
            Y[6] = true;
            Y[7] = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Y[0] = true;
            Y[1] = true;
            Y[2] = true;
            Y[3] = true;
            Y[4] = true;
            Y[5] = true;
            Y[6] = false;
            Y[7] = true;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            Xr[0] = true;
            Xr[1] = true;
            Xr[2] = true;
            Xr[3] = true;
            Xr[4] = true;
            Xr[5] = true;
            Xr[6] = true;
            Xr[7] = false;
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = false;
            Yr[1] = true;
            Yr[2] = true;
            Yr[3] = true;
            Yr[4] = true;
            Yr[5] = true;
            Yr[6] = true;
            Yr[7] = true;
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = true;
            Yr[1] = false;
            Yr[2] = true;
            Yr[3] = true;
            Yr[4] = true;
            Yr[5] = true;
            Yr[6] = true;
            Yr[7] = true;
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = true;
            Yr[1] = true;
            Yr[2] = false;
            Yr[3] = true;
            Yr[4] = true;
            Yr[5] = true;
            Yr[6] = true;
            Yr[7] = true;
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = true;
            Yr[1] = true;
            Yr[2] = true;
            Yr[3] = false;
            Yr[4] = true;
            Yr[5] = true;
            Yr[6] = true;
            Yr[7] = true;
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = true;
            Yr[1] = true;
            Yr[2] = true;
            Yr[3] = true;
            Yr[4] = false;
            Yr[5] = true;
            Yr[6] = true;
            Yr[7] = true;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = true;
            Yr[1] = true;
            Yr[2] = true;
            Yr[3] = true;
            Yr[4] = true;
            Yr[5] = false;
            Yr[6] = true;
            Yr[7] = true;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = true;
            Yr[1] = true;
            Yr[2] = true;
            Yr[3] = true;
            Yr[4] = true;
            Yr[5] = true;
            Yr[6] = false;
            Yr[7] = true;
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            Yr[0] = true;
            Yr[1] = true;
            Yr[2] = true;
            Yr[3] = true;
            Yr[4] = true;
            Yr[5] = true;
            Yr[6] = true;
            Yr[7] = false;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = false;
            Z[1] = true;
            Z[2] = true;
            Z[3] = true;
            Z[4] = true;
            Z[5] = true;
            Z[6] = true;
            Z[7] = true;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = true;
            Z[1] = false;
            Z[2] = true;
            Z[3] = true;
            Z[4] = true;
            Z[5] = true;
            Z[6] = true;
            Z[7] = true;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = true;
            Z[1] = true;
            Z[2] = false;
            Z[3] = true;
            Z[4] = true;
            Z[5] = true;
            Z[6] = true;
            Z[7] = true;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = true;
            Z[1] = true;
            Z[2] = true;
            Z[3] = false;
            Z[4] = true;
            Z[5] = true;
            Z[6] = true;
            Z[7] = true;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = true;
            Z[1] = true;
            Z[2] = true;
            Z[3] = true;
            Z[4] = false;
            Z[5] = true;
            Z[6] = true;
            Z[7] = true;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = true;
            Z[1] = true;
            Z[2] = true;
            Z[3] = true;
            Z[4] = true;
            Z[5] = false;
            Z[6] = true;
            Z[7] = true;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = true;
            Z[1] = true;
            Z[2] = true;
            Z[3] = true;
            Z[4] = true;
            Z[5] = true;
            Z[6] = false;
            Z[7] = true;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            Z[0] = true;
            Z[1] = true;
            Z[2] = true;
            Z[3] = true;
            Z[4] = true;
            Z[5] = true;
            Z[6] = true;
            Z[7] = false;
        }

        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = false;
            Zr[1] = true;
            Zr[2] = true;
            Zr[3] = true;
            Zr[4] = true;
            Zr[5] = true;
            Zr[6] = true;
            Zr[7] = true;
        }

        private void radioButton55_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = true;
            Zr[1] = false;
            Zr[2] = true;
            Zr[3] = true;
            Zr[4] = true;
            Zr[5] = true;
            Zr[6] = true;
            Zr[7] = true;
        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = true;
            Zr[1] = true;
            Zr[2] = false;
            Zr[3] = true;
            Zr[4] = true;
            Zr[5] = true;
            Zr[6] = true;
            Zr[7] = true;
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = true;
            Zr[1] = true;
            Zr[2] = true;
            Zr[3] = false;
            Zr[4] = true;
            Zr[5] = true;
            Zr[6] = true;
            Zr[7] = true;
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = true;
            Zr[1] = true;
            Zr[2] = true;
            Zr[3] = true;
            Zr[4] = false;
            Zr[5] = true;
            Zr[6] = true;
            Zr[7] = true;
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = true;
            Zr[1] = true;
            Zr[2] = true;
            Zr[3] = true;
            Zr[4] = true;
            Zr[5] = false;
            Zr[6] = true;
            Zr[7] = true;
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = true;
            Zr[1] = true;
            Zr[2] = true;
            Zr[3] = true;
            Zr[4] = true;
            Zr[5] = true;
            Zr[6] = false;
            Zr[7] = true;
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            Zr[0] = true;
            Zr[1] = true;
            Zr[2] = true;
            Zr[3] = true;
            Zr[4] = true;
            Zr[5] = true;
            Zr[6] = true;
            Zr[7] = false;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = false;
            Thita[1] = true;
            Thita[2] = true;
            Thita[3] = true;
            Thita[4] = true;
            Thita[5] = true;
            Thita[6] = true;
            Thita[7] = true;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = true;
            Thita[1] = false;
            Thita[2] = true;
            Thita[3] = true;
            Thita[4] = true;
            Thita[5] = true;
            Thita[6] = true;
            Thita[7] = true;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = true;
            Thita[1] = true;
            Thita[2] = false;
            Thita[3] = true;
            Thita[4] = true;
            Thita[5] = true;
            Thita[6] = true;
            Thita[7] = true;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = true;
            Thita[1] = true;
            Thita[2] = true;
            Thita[3] = false;
            Thita[4] = true;
            Thita[5] = true;
            Thita[6] = true;
            Thita[7] = true;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = true;
            Thita[1] = true;
            Thita[2] = true;
            Thita[3] = true;
            Thita[4] = false;
            Thita[5] = true;
            Thita[6] = true;
            Thita[7] = true;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = true;
            Thita[1] = true;
            Thita[2] = true;
            Thita[3] = true;
            Thita[4] = true;
            Thita[5] = false;
            Thita[6] = true;
            Thita[7] = true;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = true;
            Thita[1] = true;
            Thita[2] = true;
            Thita[3] = true;
            Thita[4] = true;
            Thita[5] = true;
            Thita[6] = false;
            Thita[7] = true;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            Thita[0] = true;
            Thita[1] = true;
            Thita[2] = true;
            Thita[3] = true;
            Thita[4] = true;
            Thita[5] = true;
            Thita[6] = true;
            Thita[7] = false;
        }

        private void radioButton64_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = false;
            Thitar[1] = true;
            Thitar[2] = true;
            Thitar[3] = true;
            Thitar[4] = true;
            Thitar[5] = true;
            Thitar[6] = true;
            Thitar[7] = true;
        }

        private void radioButton63_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = true;
            Thitar[1] = false;
            Thitar[2] = true;
            Thitar[3] = true;
            Thitar[4] = true;
            Thitar[5] = true;
            Thitar[6] = true;
            Thitar[7] = true;
        }

        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = true;
            Thitar[1] = true;
            Thitar[2] = false;
            Thitar[3] = true;
            Thitar[4] = true;
            Thitar[5] = true;
            Thitar[6] = true;
            Thitar[7] = true;
        }

        private void radioButton61_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = true;
            Thitar[1] = true;
            Thitar[2] = true;
            Thitar[3] = false;
            Thitar[4] = true;
            Thitar[5] = true;
            Thitar[6] = true;
            Thitar[7] = true;
        }

        private void radioButton60_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = true;
            Thitar[1] = true;
            Thitar[2] = true;
            Thitar[3] = true;
            Thitar[4] = false;
            Thitar[5] = true;
            Thitar[6] = true;
            Thitar[7] = true;
        }

        private void radioButton58_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = true;
            Thitar[1] = true;
            Thitar[2] = true;
            Thitar[3] = true;
            Thitar[4] = true;
            Thitar[5] = false;
            Thitar[6] = true;
            Thitar[7] = true;
        }

        private void radioButton59_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = true;
            Thitar[1] = true;
            Thitar[2] = true;
            Thitar[3] = true;
            Thitar[4] = true;
            Thitar[5] = true;
            Thitar[6] = false;
            Thitar[7] = true;
        }

        private void radioButton57_CheckedChanged(object sender, EventArgs e)
        {
            Thitar[0] = true;
            Thitar[1] = true;
            Thitar[2] = true;
            Thitar[3] = true;
            Thitar[4] = true;
            Thitar[5] = true;
            Thitar[6] = true;
            Thitar[7] = false;
        }

        private void txtedgecounterX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ecX = txtedgecounterX.Text;
        }

        private void txtsourcecounterX_SelectedIndexChanged(object sender, EventArgs e)
        {
            scX = txtsourcecounterX.Text;
        }

        private void txtedgecounterY_SelectedIndexChanged(object sender, EventArgs e)
        {
            ecY = txtedgecounterY.Text;
        }

        private void txtsourcecounterY_SelectedIndexChanged(object sender, EventArgs e)
        {
            scY = txtsourcecounterY.Text;
        }

        private void txtedgecounterZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            ecZ = txtedgecounterZ.Text;
        }

        private void txtsourcecounterZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            scZ = txtsourcecounterZ.Text;
        }

        private void txtedgecounterthita_SelectedIndexChanged(object sender, EventArgs e)
        {
            ecThita = txtedgecounterthita.Text;
        }

        private void txtsourcecounterthita_SelectedIndexChanged(object sender, EventArgs e)
        {
            scThita = txtsourcecounterthita.Text;
        }

        private void btndefaultsettings_Click(object sender, EventArgs e)
        {
            DAQsettings.Default_settings();
            MessageBox.Show("The default settings have been saved!!!");
        }

        private void btnupdateX_Click(object sender, EventArgs e)
        {
            var merged_string = string.Join(", ", X.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsX", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = string.Join(", ",Xr.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsXr", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = ecX;
            Environment.SetEnvironmentVariable("_edgecounterX", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = scX;
            Environment.SetEnvironmentVariable("_sourcecounterX", merged_string, EnvironmentVariableTarget.User);

            MessageBox.Show("The X stage settings have been updated!!!");
        }

        private void btnupdateY_Click(object sender, EventArgs e)
        {
            var merged_string = string.Join(", ", Y.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsY", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = string.Join(", ", Yr.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsYr", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = ecY;
            Environment.SetEnvironmentVariable("_edgecounterY", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = scY;
            Environment.SetEnvironmentVariable("_sourcecounterY", merged_string, EnvironmentVariableTarget.User);

            MessageBox.Show("The Y stage settings have been updated!!!");
        }

        private void btnupdateZ_Click(object sender, EventArgs e)
        {
            var merged_string = string.Join(", ", Z.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsZ", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = string.Join(", ", Zr.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsZr", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = ecZ;
            Environment.SetEnvironmentVariable("_edgecounterZ", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = scZ;
            Environment.SetEnvironmentVariable("_sourcecounterZ", merged_string, EnvironmentVariableTarget.User);

            MessageBox.Show("The Z stage settings have been updated!!!");
        }

        private void btnupdatetheta_Click(object sender, EventArgs e)
        {
            var merged_string = string.Join(", ", Thita.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsThita", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = string.Join(", ", Thitar.Select(b => b.ToString()).ToArray());
            Environment.SetEnvironmentVariable("_portsThitar", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = ecThita;
            Environment.SetEnvironmentVariable("_edgecounterThita", merged_string, EnvironmentVariableTarget.User);
            merged_string = string.Empty;
            merged_string = scThita;
            Environment.SetEnvironmentVariable("_sourcecounterThita", merged_string, EnvironmentVariableTarget.User);

            MessageBox.Show("The Θ stage settings have been updated!!!");
        }


    }
}
