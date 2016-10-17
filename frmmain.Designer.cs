namespace RobotControlApplication
{
    partial class frmmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDAQDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPresetGridOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCommandHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCommandHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCommandHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openCommandHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalGeneratorTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agilentGeneratorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rFG1000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rF05to34MHzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rFG100GeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dICOMImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dICOMFileTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRICameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsDataFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osilloscopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnclose = new System.Windows.Forms.Button();
            this.cmbdeviceid = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lbldaqstatus = new System.Windows.Forms.Label();
            this.btnniconnect = new System.Windows.Forms.Button();
            this.timergeneratorP = new System.Windows.Forms.Timer(this.components);
            this.timergeneratorC = new System.Windows.Forms.Timer(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtvacuumrate = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.hScrollBar10 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar9 = new System.Windows.Forms.HScrollBar();
            this.lblvacuumresult = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.pbvacuum = new System.Windows.Forms.ProgressBar();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txtvacuumOntime = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.btnstopvacuum = new System.Windows.Forms.Button();
            this.btnstartvacuum = new System.Windows.Forms.Button();
            this.lblcurrentsonication = new System.Windows.Forms.Label();
            this.cmbrobotsection = new System.Windows.Forms.ComboBox();
            this.lbltotalnumberofsonications = new System.Windows.Forms.Label();
            this.lblvisualZ = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.lblvisualY = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.lblvisualX = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.lbltotaltimeofsonication = new System.Windows.Forms.Label();
            this.lblsonicationtime = new System.Windows.Forms.Label();
            this.sonicationprogress = new System.Windows.Forms.ProgressBar();
            this.lblinstructionRF = new System.Windows.Forms.Label();
            this.lbltitleinstuctionsRF = new System.Windows.Forms.Label();
            this.btnfolderselection = new System.Windows.Forms.Button();
            this.txttransducerspecs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbselecttransducer = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.gridpattern = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnstartgridXYImmersed = new System.Windows.Forms.Button();
            this.rBgetgrid = new System.Windows.Forms.RadioButton();
            this.rBsetgrid = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txt3dgrid_zsteps_mm = new System.Windows.Forms.TextBox();
            this.txt3dgridzsteps = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtXYZwaitingtime = new System.Windows.Forms.TextBox();
            this.cmbXYZselectsignal = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.btnstart3dgrid = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.txt3dgrid_ysteps_mm = new System.Windows.Forms.TextBox();
            this.txt3dgrid_ysteps = new System.Windows.Forms.TextBox();
            this.txt3dgrid_xsteps_mm = new System.Windows.Forms.TextBox();
            this.txt3dgrid_xsteps = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtthitaposition_4D = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtzposition_3d = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtyposition_3d = new System.Windows.Forms.TextBox();
            this.txtxposition_3d = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.btnXYZzerocurentposition = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hScrollBar7 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar8 = new System.Windows.Forms.HScrollBar();
            this.btnthitaccw4d = new System.Windows.Forms.Button();
            this.btnthitacw4d = new System.Windows.Forms.Button();
            this.txtthitaccw4d = new System.Windows.Forms.TextBox();
            this.txtthitacw4d = new System.Windows.Forms.TextBox();
            this.hScrollBar5 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar6 = new System.Windows.Forms.HScrollBar();
            this.btnzreverse_3d = new System.Windows.Forms.Button();
            this.btnxforward_3d = new System.Windows.Forms.Button();
            this.btnzforward_3d = new System.Windows.Forms.Button();
            this.txtxforward_3d = new System.Windows.Forms.TextBox();
            this.txtzReverse_3d = new System.Windows.Forms.TextBox();
            this.txtxReverse_3d = new System.Windows.Forms.TextBox();
            this.txtzForward_3d = new System.Windows.Forms.TextBox();
            this.btnxreverse_3d = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.btnyreverse_3d = new System.Windows.Forms.Button();
            this.btnyforward_3d = new System.Windows.Forms.Button();
            this.txtyReverse_3d = new System.Windows.Forms.TextBox();
            this.txtyForward_3d = new System.Windows.Forms.TextBox();
            this.gbrfg_1000 = new System.Windows.Forms.GroupBox();
            this.txtrepeatspwRFG = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.btreviewsettings = new System.Windows.Forms.Button();
            this.txtfrequencyRFGFrequency = new System.Windows.Forms.TextBox();
            this.txtvoltageRFGPulsed = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtpwtineonRFG = new System.Windows.Forms.TextBox();
            this.txtcwtimeonRFG = new System.Windows.Forms.TextBox();
            this.txtdutyfactorRFG = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtreaddatainput = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtfrequencyRFG = new System.Windows.Forms.TextBox();
            this.txtpulserepfreqRFG = new System.Windows.Forms.TextBox();
            this.lblconnectionstatusRFG = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtvoltageRFG = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cmbportname = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnmode = new System.Windows.Forms.Button();
            this.btnponcw = new System.Windows.Forms.Button();
            this.btnonpw = new System.Windows.Forms.Button();
            this.btnoffpw = new System.Windows.Forms.Button();
            this.btnoffcw = new System.Windows.Forms.Button();
            this.gbagilentgenerator = new System.Windows.Forms.GroupBox();
            this.txtrepeatsforcw = new System.Windows.Forms.TextBox();
            this.txttimedelayforcw = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtfrequencypulsed = new System.Windows.Forms.TextBox();
            this.txtvoltagepulsed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtagilentvisaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblconnectionstatus = new System.Windows.Forms.Label();
            this.btnconnecttoagilent = new System.Windows.Forms.Button();
            this.btnpoweroffpulsed = new System.Windows.Forms.Button();
            this.btnpoweronpulsed = new System.Windows.Forms.Button();
            this.btnpoweroffcont = new System.Windows.Forms.Button();
            this.btnpoweroncont = new System.Windows.Forms.Button();
            this.txtontimepulsed = new System.Windows.Forms.TextBox();
            this.txtpulserepfreq = new System.Windows.Forms.TextBox();
            this.txtdutyfactor = new System.Windows.Forms.TextBox();
            this.txtontimecontinious = new System.Windows.Forms.TextBox();
            this.txtfrequency = new System.Windows.Forms.TextBox();
            this.txtvoltage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label49 = new System.Windows.Forms.Label();
            this.gridpattern2D = new System.Windows.Forms.Panel();
            this.gbcurrentposition = new System.Windows.Forms.GroupBox();
            this.txtthitaposition = new System.Windows.Forms.TextBox();
            this.txtxposition = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnxthitaposition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txttimefornextsonication = new System.Windows.Forms.TextBox();
            this.cmbselectsignal = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnstartgrid = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnthitastep = new System.Windows.Forms.TextBox();
            this.txtnthitagrid = new System.Windows.Forms.TextBox();
            this.txtnxstep = new System.Windows.Forms.TextBox();
            this.txtnxgrid = new System.Windows.Forms.TextBox();
            this.xthitapanel = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.lbl1Dtitle1 = new System.Windows.Forms.Label();
            this.txt1Dseconds = new System.Windows.Forms.TextBox();
            this.lbl1Dtitle = new System.Windows.Forms.Label();
            this.btn1Dgrid = new System.Windows.Forms.Button();
            this.txt1Drepeats = new System.Windows.Forms.TextBox();
            this.btnmcw = new System.Windows.Forms.Button();
            this.btnmxfw = new System.Windows.Forms.Button();
            this.btnmccw = new System.Windows.Forms.Button();
            this.btnmcrev = new System.Windows.Forms.Button();
            this.ccwscroll = new System.Windows.Forms.HScrollBar();
            this.cwscroll = new System.Windows.Forms.HScrollBar();
            this.btnstopnow = new System.Windows.Forms.Button();
            this.xrscroll = new System.Windows.Forms.HScrollBar();
            this.xfscroll = new System.Windows.Forms.HScrollBar();
            this.btnthitaccw = new System.Windows.Forms.Button();
            this.btnthitacw = new System.Windows.Forms.Button();
            this.btnxrev = new System.Windows.Forms.Button();
            this.btnxfw = new System.Windows.Forms.Button();
            this.txtthitaccw = new System.Windows.Forms.TextBox();
            this.txtthitacw = new System.Windows.Forms.TextBox();
            this.txtxrev = new System.Windows.Forms.TextBox();
            this.txtxfw = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxcommandhistory = new System.Windows.Forms.GroupBox();
            this.lstcommandhistory = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timercw = new System.Windows.Forms.Timer(this.components);
            this.timer1Drobot = new System.Windows.Forms.Timer(this.components);
            this.timerPWrepeats = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbrfg_1000.SuspendLayout();
            this.gbagilentgenerator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbcurrentposition.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.xthitapanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxcommandhistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.signalGeneratorTypeToolStripMenuItem1,
            this.dICOMImagesToolStripMenuItem,
            this.mRICameraToolStripMenuItem,
            this.patientsDataFormToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.osilloscopeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1604, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDAQDevicesToolStripMenuItem,
            this.clearPresetGridOperationToolStripMenuItem,
            this.clearCommandHistoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.menuToolStripMenuItem.Text = "Settings and Options";
            // 
            // editDAQDevicesToolStripMenuItem
            // 
            this.editDAQDevicesToolStripMenuItem.Name = "editDAQDevicesToolStripMenuItem";
            this.editDAQDevicesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.editDAQDevicesToolStripMenuItem.Text = "Edit DAQ Devices";
            this.editDAQDevicesToolStripMenuItem.Click += new System.EventHandler(this.editDAQDevicesToolStripMenuItem_Click);
            // 
            // clearPresetGridOperationToolStripMenuItem
            // 
            this.clearPresetGridOperationToolStripMenuItem.Name = "clearPresetGridOperationToolStripMenuItem";
            this.clearPresetGridOperationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.clearPresetGridOperationToolStripMenuItem.Text = "Clear preset grid operation";
            this.clearPresetGridOperationToolStripMenuItem.Click += new System.EventHandler(this.clearPresetGridOperationToolStripMenuItem_Click);
            // 
            // clearCommandHistoryToolStripMenuItem
            // 
            this.clearCommandHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCommandHistoryToolStripMenuItem,
            this.clearCommandHistoryToolStripMenuItem1,
            this.openCommandHistoryToolStripMenuItem});
            this.clearCommandHistoryToolStripMenuItem.Name = "clearCommandHistoryToolStripMenuItem";
            this.clearCommandHistoryToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.clearCommandHistoryToolStripMenuItem.Text = "Command History";
            this.clearCommandHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearCommandHistoryToolStripMenuItem_Click);
            // 
            // saveCommandHistoryToolStripMenuItem
            // 
            this.saveCommandHistoryToolStripMenuItem.Name = "saveCommandHistoryToolStripMenuItem";
            this.saveCommandHistoryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveCommandHistoryToolStripMenuItem.Text = "Save Command History";
            this.saveCommandHistoryToolStripMenuItem.Click += new System.EventHandler(this.saveCommandHistoryToolStripMenuItem_Click);
            // 
            // clearCommandHistoryToolStripMenuItem1
            // 
            this.clearCommandHistoryToolStripMenuItem1.Name = "clearCommandHistoryToolStripMenuItem1";
            this.clearCommandHistoryToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.clearCommandHistoryToolStripMenuItem1.Text = "Clear Command History";
            this.clearCommandHistoryToolStripMenuItem1.Click += new System.EventHandler(this.clearCommandHistoryToolStripMenuItem1_Click);
            // 
            // openCommandHistoryToolStripMenuItem
            // 
            this.openCommandHistoryToolStripMenuItem.Name = "openCommandHistoryToolStripMenuItem";
            this.openCommandHistoryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openCommandHistoryToolStripMenuItem.Text = "Open Command History";
            this.openCommandHistoryToolStripMenuItem.Click += new System.EventHandler(this.openCommandHistoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // signalGeneratorTypeToolStripMenuItem1
            // 
            this.signalGeneratorTypeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agilentGeneratorToolStripMenuItem1,
            this.rFG1000ToolStripMenuItem,
            this.rF05to34MHzToolStripMenuItem,
            this.rFG100GeneratorToolStripMenuItem});
            this.signalGeneratorTypeToolStripMenuItem1.Name = "signalGeneratorTypeToolStripMenuItem1";
            this.signalGeneratorTypeToolStripMenuItem1.Size = new System.Drawing.Size(135, 20);
            this.signalGeneratorTypeToolStripMenuItem1.Text = "Signal Generator Type";
            // 
            // agilentGeneratorToolStripMenuItem1
            // 
            this.agilentGeneratorToolStripMenuItem1.Name = "agilentGeneratorToolStripMenuItem1";
            this.agilentGeneratorToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.agilentGeneratorToolStripMenuItem1.Text = "Agilent Generator";
            this.agilentGeneratorToolStripMenuItem1.Click += new System.EventHandler(this.agilentGeneratorToolStripMenuItem1_Click);
            // 
            // rFG1000ToolStripMenuItem
            // 
            this.rFG1000ToolStripMenuItem.Name = "rFG1000ToolStripMenuItem";
            this.rFG1000ToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.rFG1000ToolStripMenuItem.Text = "RFG_1000 Generator";
            this.rFG1000ToolStripMenuItem.Click += new System.EventHandler(this.rFG1000ToolStripMenuItem_Click);
            // 
            // rF05to34MHzToolStripMenuItem
            // 
            this.rF05to34MHzToolStripMenuItem.Name = "rF05to34MHzToolStripMenuItem";
            this.rF05to34MHzToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.rF05to34MHzToolStripMenuItem.Text = "RF 750 Generator";
            this.rF05to34MHzToolStripMenuItem.Click += new System.EventHandler(this.rF05to34MHzToolStripMenuItem_Click);
            // 
            // rFG100GeneratorToolStripMenuItem
            // 
            this.rFG100GeneratorToolStripMenuItem.Name = "rFG100GeneratorToolStripMenuItem";
            this.rFG100GeneratorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.rFG100GeneratorToolStripMenuItem.Text = "RFG 100 Generator";
            this.rFG100GeneratorToolStripMenuItem.Click += new System.EventHandler(this.rFG100GeneratorToolStripMenuItem_Click);
            // 
            // dICOMImagesToolStripMenuItem
            // 
            this.dICOMImagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dICOMFileTransferToolStripMenuItem});
            this.dICOMImagesToolStripMenuItem.Name = "dICOMImagesToolStripMenuItem";
            this.dICOMImagesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.dICOMImagesToolStripMenuItem.Text = "DICOM Images";
            // 
            // dICOMFileTransferToolStripMenuItem
            // 
            this.dICOMFileTransferToolStripMenuItem.Name = "dICOMFileTransferToolStripMenuItem";
            this.dICOMFileTransferToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dICOMFileTransferToolStripMenuItem.Text = "DICOM Query/Retreive";
            this.dICOMFileTransferToolStripMenuItem.Click += new System.EventHandler(this.dICOMFileTransferToolStripMenuItem_Click);
            // 
            // mRICameraToolStripMenuItem
            // 
            this.mRICameraToolStripMenuItem.Name = "mRICameraToolStripMenuItem";
            this.mRICameraToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.mRICameraToolStripMenuItem.Text = "MRI Camera";
            this.mRICameraToolStripMenuItem.Click += new System.EventHandler(this.mRICameraToolStripMenuItem_Click);
            // 
            // patientsDataFormToolStripMenuItem
            // 
            this.patientsDataFormToolStripMenuItem.Name = "patientsDataFormToolStripMenuItem";
            this.patientsDataFormToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.patientsDataFormToolStripMenuItem.Text = "Patient\'s Data Form";
            this.patientsDataFormToolStripMenuItem.Click += new System.EventHandler(this.patientsDataFormToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // osilloscopeToolStripMenuItem
            // 
            this.osilloscopeToolStripMenuItem.Name = "osilloscopeToolStripMenuItem";
            this.osilloscopeToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.osilloscopeToolStripMenuItem.Text = "Oscilloscope";
            this.osilloscopeToolStripMenuItem.Click += new System.EventHandler(this.osilloscopeToolStripMenuItem_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Location = new System.Drawing.Point(1404, 647);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(189, 37);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close Application";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cmbdeviceid
            // 
            this.cmbdeviceid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbdeviceid.FormattingEnabled = true;
            this.cmbdeviceid.Items.AddRange(new object[] {
            "/Dev1",
            "/Dev2"});
            this.cmbdeviceid.Location = new System.Drawing.Point(98, 479);
            this.cmbdeviceid.Name = "cmbdeviceid";
            this.cmbdeviceid.Size = new System.Drawing.Size(198, 23);
            this.cmbdeviceid.TabIndex = 24;
            this.cmbdeviceid.Text = "/Dev1";
            this.cmbdeviceid.SelectedIndexChanged += new System.EventHandler(this.cmbdeviceid_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 485);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 15);
            this.label22.TabIndex = 23;
            this.label22.Text = "Select NI DAQ ID";
            // 
            // lbldaqstatus
            // 
            this.lbldaqstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbldaqstatus.AutoSize = true;
            this.lbldaqstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbldaqstatus.Location = new System.Drawing.Point(117, 557);
            this.lbldaqstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldaqstatus.Name = "lbldaqstatus";
            this.lbldaqstatus.Size = new System.Drawing.Size(77, 16);
            this.lbldaqstatus.TabIndex = 22;
            this.lbldaqstatus.Text = "DAQ Status";
            // 
            // btnniconnect
            // 
            this.btnniconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnniconnect.Location = new System.Drawing.Point(10, 546);
            this.btnniconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnniconnect.Name = "btnniconnect";
            this.btnniconnect.Size = new System.Drawing.Size(102, 36);
            this.btnniconnect.TabIndex = 21;
            this.btnniconnect.Text = "Connect DAQ";
            this.btnniconnect.UseVisualStyleBackColor = true;
            this.btnniconnect.Click += new System.EventHandler(this.btnniconnect_Click);
            // 
            // timergeneratorP
            // 
            this.timergeneratorP.Interval = 1000;
            this.timergeneratorP.Tick += new System.EventHandler(this.timergeneratorP_Tick);
            // 
            // timergeneratorC
            // 
            this.timergeneratorC.Interval = 1000;
            this.timergeneratorC.Tick += new System.EventHandler(this.timergeneratorC_Tick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1592, 614);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.lblcurrentsonication);
            this.tabPage2.Controls.Add(this.cmbrobotsection);
            this.tabPage2.Controls.Add(this.lbltotalnumberofsonications);
            this.tabPage2.Controls.Add(this.cmbdeviceid);
            this.tabPage2.Controls.Add(this.lblvisualZ);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label58);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.lblvisualY);
            this.tabPage2.Controls.Add(this.lbldaqstatus);
            this.tabPage2.Controls.Add(this.label56);
            this.tabPage2.Controls.Add(this.btnniconnect);
            this.tabPage2.Controls.Add(this.lblvisualX);
            this.tabPage2.Controls.Add(this.label55);
            this.tabPage2.Controls.Add(this.label54);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.lbltotaltimeofsonication);
            this.tabPage2.Controls.Add(this.lblsonicationtime);
            this.tabPage2.Controls.Add(this.sonicationprogress);
            this.tabPage2.Controls.Add(this.lblinstructionRF);
            this.tabPage2.Controls.Add(this.lbltitleinstuctionsRF);
            this.tabPage2.Controls.Add(this.btnfolderselection);
            this.tabPage2.Controls.Add(this.txttransducerspecs);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cmbselecttransducer);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.gridpattern);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.gbrfg_1000);
            this.tabPage2.Controls.Add(this.gbagilentgenerator);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1584, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "X - Y - Z - Θ Robot Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtvacuumrate);
            this.groupBox5.Controls.Add(this.label62);
            this.groupBox5.Controls.Add(this.hScrollBar10);
            this.groupBox5.Controls.Add(this.hScrollBar9);
            this.groupBox5.Controls.Add(this.lblvacuumresult);
            this.groupBox5.Controls.Add(this.label61);
            this.groupBox5.Controls.Add(this.pbvacuum);
            this.groupBox5.Controls.Add(this.txtvolume);
            this.groupBox5.Controls.Add(this.label60);
            this.groupBox5.Controls.Add(this.txtvacuumOntime);
            this.groupBox5.Controls.Add(this.label59);
            this.groupBox5.Controls.Add(this.btnstopvacuum);
            this.groupBox5.Controls.Add(this.btnstartvacuum);
            this.groupBox5.Location = new System.Drawing.Point(1283, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 327);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vacuum";
            // 
            // txtvacuumrate
            // 
            this.txtvacuumrate.Location = new System.Drawing.Point(119, 139);
            this.txtvacuumrate.Name = "txtvacuumrate";
            this.txtvacuumrate.Size = new System.Drawing.Size(100, 21);
            this.txtvacuumrate.TabIndex = 16;
            this.txtvacuumrate.Text = "0.16";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(8, 142);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(109, 15);
            this.label62.TabIndex = 15;
            this.label62.Text = "Vacuum Rate (ml):";
            // 
            // hScrollBar10
            // 
            this.hScrollBar10.Location = new System.Drawing.Point(119, 108);
            this.hScrollBar10.Maximum = 150;
            this.hScrollBar10.Name = "hScrollBar10";
            this.hScrollBar10.Size = new System.Drawing.Size(102, 18);
            this.hScrollBar10.TabIndex = 14;
            this.hScrollBar10.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar10_Scroll);
            // 
            // hScrollBar9
            // 
            this.hScrollBar9.Location = new System.Drawing.Point(119, 55);
            this.hScrollBar9.Maximum = 150;
            this.hScrollBar9.Name = "hScrollBar9";
            this.hScrollBar9.Size = new System.Drawing.Size(102, 18);
            this.hScrollBar9.TabIndex = 13;
            this.hScrollBar9.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar9_Scroll);
            // 
            // lblvacuumresult
            // 
            this.lblvacuumresult.AutoSize = true;
            this.lblvacuumresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblvacuumresult.Location = new System.Drawing.Point(11, 212);
            this.lblvacuumresult.Name = "lblvacuumresult";
            this.lblvacuumresult.Size = new System.Drawing.Size(0, 13);
            this.lblvacuumresult.TabIndex = 9;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(14, 231);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(104, 15);
            this.label61.TabIndex = 8;
            this.label61.Text = "Vacuum Progress";
            // 
            // pbvacuum
            // 
            this.pbvacuum.Location = new System.Drawing.Point(17, 254);
            this.pbvacuum.Name = "pbvacuum";
            this.pbvacuum.Size = new System.Drawing.Size(237, 19);
            this.pbvacuum.TabIndex = 7;
            // 
            // txtvolume
            // 
            this.txtvolume.Location = new System.Drawing.Point(119, 84);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(100, 21);
            this.txtvolume.TabIndex = 6;
            this.txtvolume.Text = "0";
            this.txtvolume.TextChanged += new System.EventHandler(this.txtvolume_TextChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 87);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(77, 15);
            this.label60.TabIndex = 5;
            this.label60.Text = "Volume (ml):";
            // 
            // txtvacuumOntime
            // 
            this.txtvacuumOntime.Location = new System.Drawing.Point(119, 32);
            this.txtvacuumOntime.Name = "txtvacuumOntime";
            this.txtvacuumOntime.Size = new System.Drawing.Size(100, 21);
            this.txtvacuumOntime.TabIndex = 4;
            this.txtvacuumOntime.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(10, 33);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(55, 15);
            this.label59.TabIndex = 3;
            this.label59.Text = "Time (s):";
            // 
            // btnstopvacuum
            // 
            this.btnstopvacuum.Enabled = false;
            this.btnstopvacuum.Location = new System.Drawing.Point(179, 281);
            this.btnstopvacuum.Name = "btnstopvacuum";
            this.btnstopvacuum.Size = new System.Drawing.Size(75, 27);
            this.btnstopvacuum.TabIndex = 2;
            this.btnstopvacuum.Text = "Stop";
            this.btnstopvacuum.UseVisualStyleBackColor = true;
            this.btnstopvacuum.Click += new System.EventHandler(this.btnstopvacuum_Click);
            // 
            // btnstartvacuum
            // 
            this.btnstartvacuum.Location = new System.Drawing.Point(95, 281);
            this.btnstartvacuum.Name = "btnstartvacuum";
            this.btnstartvacuum.Size = new System.Drawing.Size(75, 27);
            this.btnstartvacuum.TabIndex = 0;
            this.btnstartvacuum.Text = "Start";
            this.btnstartvacuum.UseVisualStyleBackColor = true;
            this.btnstartvacuum.Click += new System.EventHandler(this.btnstartvacuum_Click);
            // 
            // lblcurrentsonication
            // 
            this.lblcurrentsonication.AutoSize = true;
            this.lblcurrentsonication.Location = new System.Drawing.Point(590, 300);
            this.lblcurrentsonication.Name = "lblcurrentsonication";
            this.lblcurrentsonication.Size = new System.Drawing.Size(47, 15);
            this.lblcurrentsonication.TabIndex = 49;
            this.lblcurrentsonication.Text = "----------";
            // 
            // cmbrobotsection
            // 
            this.cmbrobotsection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbrobotsection.FormattingEnabled = true;
            this.cmbrobotsection.Items.AddRange(new object[] {
            "4D_Robot (X - Y - Z - Θ)",
            "3D_Robot (X - Y - Z)",
            "2D Robot (X - Y, Immersed)",
            "2D_Robot (X - Θ)",
            "4D_Prostate_Robot (X - Θ - Z - VΘ)",
            "1D_Robot (X)"});
            this.cmbrobotsection.Location = new System.Drawing.Point(98, 508);
            this.cmbrobotsection.Name = "cmbrobotsection";
            this.cmbrobotsection.Size = new System.Drawing.Size(198, 23);
            this.cmbrobotsection.TabIndex = 24;
            this.cmbrobotsection.Text = "3D_Robot (X - Y - Z)";
            this.cmbrobotsection.SelectedIndexChanged += new System.EventHandler(this.cmbdeviceid_SelectedIndexChanged);
            // 
            // lbltotalnumberofsonications
            // 
            this.lbltotalnumberofsonications.AutoSize = true;
            this.lbltotalnumberofsonications.Location = new System.Drawing.Point(528, 300);
            this.lbltotalnumberofsonications.Name = "lbltotalnumberofsonications";
            this.lbltotalnumberofsonications.Size = new System.Drawing.Size(47, 15);
            this.lbltotalnumberofsonications.TabIndex = 49;
            this.lbltotalnumberofsonications.Text = "----------";
            // 
            // lblvisualZ
            // 
            this.lblvisualZ.AutoSize = true;
            this.lblvisualZ.Location = new System.Drawing.Point(462, 300);
            this.lblvisualZ.Name = "lblvisualZ";
            this.lblvisualZ.Size = new System.Drawing.Size(47, 15);
            this.lblvisualZ.TabIndex = 49;
            this.lblvisualZ.Text = "----------";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 515);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 15);
            this.label27.TabIndex = 23;
            this.label27.Text = "Select Robot";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(590, 280);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(47, 15);
            this.label58.TabIndex = 46;
            this.label58.Text = "Current";
            // 
            // lblvisualY
            // 
            this.lblvisualY.AutoSize = true;
            this.lblvisualY.Location = new System.Drawing.Point(407, 300);
            this.lblvisualY.Name = "lblvisualY";
            this.lblvisualY.Size = new System.Drawing.Size(47, 15);
            this.lblvisualY.TabIndex = 48;
            this.lblvisualY.Text = "----------";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(534, 281);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(34, 15);
            this.label56.TabIndex = 46;
            this.label56.Text = "Total";
            // 
            // lblvisualX
            // 
            this.lblvisualX.AutoSize = true;
            this.lblvisualX.Location = new System.Drawing.Point(353, 300);
            this.lblvisualX.Name = "lblvisualX";
            this.lblvisualX.Size = new System.Drawing.Size(47, 15);
            this.lblvisualX.TabIndex = 47;
            this.lblvisualX.Text = "----------";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(478, 280);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(14, 15);
            this.label55.TabIndex = 46;
            this.label55.Text = "Z";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(423, 281);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(14, 15);
            this.label54.TabIndex = 45;
            this.label54.Text = "Y";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(369, 281);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(15, 15);
            this.label53.TabIndex = 44;
            this.label53.Text = "X";
            // 
            // lbltotaltimeofsonication
            // 
            this.lbltotaltimeofsonication.AutoSize = true;
            this.lbltotaltimeofsonication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbltotaltimeofsonication.Location = new System.Drawing.Point(1177, 448);
            this.lbltotaltimeofsonication.Name = "lbltotaltimeofsonication";
            this.lbltotaltimeofsonication.Size = new System.Drawing.Size(44, 16);
            this.lbltotaltimeofsonication.TabIndex = 43;
            this.lbltotaltimeofsonication.Text = "Total";
            // 
            // lblsonicationtime
            // 
            this.lblsonicationtime.AutoSize = true;
            this.lblsonicationtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblsonicationtime.Location = new System.Drawing.Point(646, 399);
            this.lblsonicationtime.Name = "lblsonicationtime";
            this.lblsonicationtime.Size = new System.Drawing.Size(43, 16);
            this.lblsonicationtime.TabIndex = 42;
            this.lblsonicationtime.Text = "Time";
            // 
            // sonicationprogress
            // 
            this.sonicationprogress.Location = new System.Drawing.Point(901, 402);
            this.sonicationprogress.Name = "sonicationprogress";
            this.sonicationprogress.Size = new System.Drawing.Size(251, 19);
            this.sonicationprogress.TabIndex = 41;
            // 
            // lblinstructionRF
            // 
            this.lblinstructionRF.AutoSize = true;
            this.lblinstructionRF.Location = new System.Drawing.Point(1177, 355);
            this.lblinstructionRF.Name = "lblinstructionRF";
            this.lblinstructionRF.Size = new System.Drawing.Size(127, 75);
            this.lblinstructionRF.TabIndex = 39;
            this.lblinstructionRF.Text = "1) Select COM Port\r\n2) Connect to RFG\r\n3) Set the parameters\r\n4) Press Set up but" +
    "ton\r\n5) Press RUN button";
            this.lblinstructionRF.Visible = false;
            // 
            // lbltitleinstuctionsRF
            // 
            this.lbltitleinstuctionsRF.AutoSize = true;
            this.lbltitleinstuctionsRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbltitleinstuctionsRF.Location = new System.Drawing.Point(1177, 339);
            this.lbltitleinstuctionsRF.Name = "lbltitleinstuctionsRF";
            this.lbltitleinstuctionsRF.Size = new System.Drawing.Size(74, 15);
            this.lbltitleinstuctionsRF.TabIndex = 38;
            this.lbltitleinstuctionsRF.Text = "Intructions";
            this.lbltitleinstuctionsRF.Visible = false;
            // 
            // btnfolderselection
            // 
            this.btnfolderselection.Location = new System.Drawing.Point(1026, 427);
            this.btnfolderselection.Name = "btnfolderselection";
            this.btnfolderselection.Size = new System.Drawing.Size(145, 29);
            this.btnfolderselection.TabIndex = 37;
            this.btnfolderselection.Text = "Select Excel File";
            this.btnfolderselection.UseVisualStyleBackColor = true;
            this.btnfolderselection.Click += new System.EventHandler(this.btnfolderselection_Click);
            // 
            // txttransducerspecs
            // 
            this.txttransducerspecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txttransducerspecs.Location = new System.Drawing.Point(833, 434);
            this.txttransducerspecs.Margin = new System.Windows.Forms.Padding(4);
            this.txttransducerspecs.Name = "txttransducerspecs";
            this.txttransducerspecs.Size = new System.Drawing.Size(186, 22);
            this.txttransducerspecs.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(643, 435);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Transducer";
            // 
            // cmbselecttransducer
            // 
            this.cmbselecttransducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbselecttransducer.FormattingEnabled = true;
            this.cmbselecttransducer.Location = new System.Drawing.Point(721, 432);
            this.cmbselecttransducer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbselecttransducer.Name = "cmbselecttransducer";
            this.cmbselecttransducer.Size = new System.Drawing.Size(106, 24);
            this.cmbselecttransducer.TabIndex = 35;
            this.cmbselecttransducer.SelectedIndexChanged += new System.EventHandler(this.cmbselecttransducer_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label38.Location = new System.Drawing.Point(242, 301);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(108, 15);
            this.label38.TabIndex = 32;
            this.label38.Text = "Visual Grid Pattern";
            // 
            // gridpattern
            // 
            this.gridpattern.Location = new System.Drawing.Point(242, 319);
            this.gridpattern.Name = "gridpattern";
            this.gridpattern.Size = new System.Drawing.Size(398, 201);
            this.gridpattern.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnstartgridXYImmersed);
            this.groupBox4.Controls.Add(this.rBgetgrid);
            this.groupBox4.Controls.Add(this.rBsetgrid);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.txt3dgrid_zsteps_mm);
            this.groupBox4.Controls.Add(this.txt3dgridzsteps);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.txtXYZwaitingtime);
            this.groupBox4.Controls.Add(this.cmbXYZselectsignal);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.btnstart3dgrid);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.txt3dgrid_ysteps_mm);
            this.groupBox4.Controls.Add(this.txt3dgrid_ysteps);
            this.groupBox4.Controls.Add(this.txt3dgrid_xsteps_mm);
            this.groupBox4.Controls.Add(this.txt3dgrid_xsteps);
            this.groupBox4.Location = new System.Drawing.Point(350, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(290, 273);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Automated Motion Control";
            // 
            // btnstartgridXYImmersed
            // 
            this.btnstartgridXYImmersed.Location = new System.Drawing.Point(203, 206);
            this.btnstartgridXYImmersed.Name = "btnstartgridXYImmersed";
            this.btnstartgridXYImmersed.Size = new System.Drawing.Size(77, 28);
            this.btnstartgridXYImmersed.TabIndex = 20;
            this.btnstartgridXYImmersed.Text = "Start Grid";
            this.btnstartgridXYImmersed.UseVisualStyleBackColor = true;
            this.btnstartgridXYImmersed.Visible = false;
            this.btnstartgridXYImmersed.Click += new System.EventHandler(this.btnstartgridXYImmersed_Click);
            // 
            // rBgetgrid
            // 
            this.rBgetgrid.AutoSize = true;
            this.rBgetgrid.Location = new System.Drawing.Point(7, 247);
            this.rBgetgrid.Name = "rBgetgrid";
            this.rBgetgrid.Size = new System.Drawing.Size(123, 19);
            this.rBgetgrid.TabIndex = 19;
            this.rBgetgrid.Text = "Get grid operation";
            this.rBgetgrid.UseVisualStyleBackColor = true;
            this.rBgetgrid.CheckedChanged += new System.EventHandler(this.rBgetgrid_CheckedChanged);
            // 
            // rBsetgrid
            // 
            this.rBsetgrid.AutoSize = true;
            this.rBsetgrid.Checked = true;
            this.rBsetgrid.Location = new System.Drawing.Point(7, 228);
            this.rBsetgrid.Name = "rBsetgrid";
            this.rBsetgrid.Size = new System.Drawing.Size(122, 19);
            this.rBsetgrid.TabIndex = 18;
            this.rBsetgrid.TabStop = true;
            this.rBsetgrid.Text = "Set grid operation";
            this.rBsetgrid.UseVisualStyleBackColor = true;
            this.rBsetgrid.CheckedChanged += new System.EventHandler(this.rBsetgrid_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Step (mm)";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 174);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(14, 15);
            this.label33.TabIndex = 16;
            this.label33.Text = "Z";
            // 
            // txt3dgrid_zsteps_mm
            // 
            this.txt3dgrid_zsteps_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt3dgrid_zsteps_mm.Location = new System.Drawing.Point(218, 168);
            this.txt3dgrid_zsteps_mm.Margin = new System.Windows.Forms.Padding(4);
            this.txt3dgrid_zsteps_mm.Name = "txt3dgrid_zsteps_mm";
            this.txt3dgrid_zsteps_mm.Size = new System.Drawing.Size(49, 22);
            this.txt3dgrid_zsteps_mm.TabIndex = 15;
            this.txt3dgrid_zsteps_mm.Text = "0";
            this.txt3dgrid_zsteps_mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3dgridzsteps
            // 
            this.txt3dgridzsteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt3dgridzsteps.Location = new System.Drawing.Point(43, 169);
            this.txt3dgridzsteps.Margin = new System.Windows.Forms.Padding(4);
            this.txt3dgridzsteps.Name = "txt3dgridzsteps";
            this.txt3dgridzsteps.Size = new System.Drawing.Size(54, 22);
            this.txt3dgridzsteps.TabIndex = 14;
            this.txt3dgridzsteps.Text = "0";
            this.txt3dgridzsteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 17);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(117, 15);
            this.label42.TabIndex = 13;
            this.label42.Text = "Select type of Signal";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(7, 67);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(198, 15);
            this.label43.TabIndex = 12;
            this.label43.Text = "Time between each step (seconds)";
            // 
            // txtXYZwaitingtime
            // 
            this.txtXYZwaitingtime.Location = new System.Drawing.Point(228, 64);
            this.txtXYZwaitingtime.Name = "txtXYZwaitingtime";
            this.txtXYZwaitingtime.Size = new System.Drawing.Size(53, 21);
            this.txtXYZwaitingtime.TabIndex = 11;
            this.txtXYZwaitingtime.Text = "20";
            this.txtXYZwaitingtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbXYZselectsignal
            // 
            this.cmbXYZselectsignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbXYZselectsignal.FormattingEnabled = true;
            this.cmbXYZselectsignal.Items.AddRange(new object[] {
            "Agilent - Continious Signal",
            "Agilent - Pulsed Signal",
            "RFG_1000/750 - Continious Signal",
            "RFG_1000/750 - Pulsed Signal",
            "No Power"});
            this.cmbXYZselectsignal.Location = new System.Drawing.Point(8, 36);
            this.cmbXYZselectsignal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbXYZselectsignal.Name = "cmbXYZselectsignal";
            this.cmbXYZselectsignal.Size = new System.Drawing.Size(273, 24);
            this.cmbXYZselectsignal.TabIndex = 10;
            this.cmbXYZselectsignal.SelectedIndexChanged += new System.EventHandler(this.cmbXYZselectsignal_SelectedIndexChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(123, 140);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(65, 15);
            this.label44.TabIndex = 9;
            this.label44.Text = "Step (mm)";
            // 
            // btnstart3dgrid
            // 
            this.btnstart3dgrid.Enabled = false;
            this.btnstart3dgrid.Location = new System.Drawing.Point(203, 235);
            this.btnstart3dgrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnstart3dgrid.Name = "btnstart3dgrid";
            this.btnstart3dgrid.Size = new System.Drawing.Size(78, 29);
            this.btnstart3dgrid.TabIndex = 8;
            this.btnstart3dgrid.Text = "Start Grid";
            this.btnstart3dgrid.UseVisualStyleBackColor = true;
            this.btnstart3dgrid.Click += new System.EventHandler(this.btnstart3dgrid_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(123, 110);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 15);
            this.label45.TabIndex = 7;
            this.label45.Text = "Step (mm)";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(40, 89);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(63, 15);
            this.label46.TabIndex = 6;
            this.label46.Text = "# Of Steps";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(7, 144);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(14, 15);
            this.label47.TabIndex = 5;
            this.label47.Text = "Y";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(7, 110);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(15, 15);
            this.label48.TabIndex = 4;
            this.label48.Text = "X";
            // 
            // txt3dgrid_ysteps_mm
            // 
            this.txt3dgrid_ysteps_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt3dgrid_ysteps_mm.Location = new System.Drawing.Point(218, 137);
            this.txt3dgrid_ysteps_mm.Margin = new System.Windows.Forms.Padding(4);
            this.txt3dgrid_ysteps_mm.Name = "txt3dgrid_ysteps_mm";
            this.txt3dgrid_ysteps_mm.Size = new System.Drawing.Size(49, 22);
            this.txt3dgrid_ysteps_mm.TabIndex = 3;
            this.txt3dgrid_ysteps_mm.Text = "0";
            this.txt3dgrid_ysteps_mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3dgrid_ysteps
            // 
            this.txt3dgrid_ysteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt3dgrid_ysteps.Location = new System.Drawing.Point(43, 110);
            this.txt3dgrid_ysteps.Margin = new System.Windows.Forms.Padding(4);
            this.txt3dgrid_ysteps.Name = "txt3dgrid_ysteps";
            this.txt3dgrid_ysteps.Size = new System.Drawing.Size(54, 22);
            this.txt3dgrid_ysteps.TabIndex = 2;
            this.txt3dgrid_ysteps.Text = "0";
            this.txt3dgrid_ysteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3dgrid_xsteps_mm
            // 
            this.txt3dgrid_xsteps_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt3dgrid_xsteps_mm.Location = new System.Drawing.Point(218, 106);
            this.txt3dgrid_xsteps_mm.Margin = new System.Windows.Forms.Padding(4);
            this.txt3dgrid_xsteps_mm.Name = "txt3dgrid_xsteps_mm";
            this.txt3dgrid_xsteps_mm.Size = new System.Drawing.Size(49, 22);
            this.txt3dgrid_xsteps_mm.TabIndex = 1;
            this.txt3dgrid_xsteps_mm.Text = "0";
            this.txt3dgrid_xsteps_mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3dgrid_xsteps
            // 
            this.txt3dgrid_xsteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt3dgrid_xsteps.Location = new System.Drawing.Point(43, 138);
            this.txt3dgrid_xsteps.Margin = new System.Windows.Forms.Padding(4);
            this.txt3dgrid_xsteps.Name = "txt3dgrid_xsteps";
            this.txt3dgrid_xsteps.Size = new System.Drawing.Size(54, 22);
            this.txt3dgrid_xsteps.TabIndex = 0;
            this.txt3dgrid_xsteps.Text = "0";
            this.txt3dgrid_xsteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtthitaposition_4D);
            this.groupBox3.Controls.Add(this.label52);
            this.groupBox3.Controls.Add(this.txtzposition_3d);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.txtyposition_3d);
            this.groupBox3.Controls.Add(this.txtxposition_3d);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.btnXYZzerocurentposition);
            this.groupBox3.Location = new System.Drawing.Point(242, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(101, 272);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // txtthitaposition_4D
            // 
            this.txtthitaposition_4D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtthitaposition_4D.Location = new System.Drawing.Point(30, 193);
            this.txtthitaposition_4D.Margin = new System.Windows.Forms.Padding(4);
            this.txtthitaposition_4D.Name = "txtthitaposition_4D";
            this.txtthitaposition_4D.Size = new System.Drawing.Size(36, 22);
            this.txtthitaposition_4D.TabIndex = 6;
            this.txtthitaposition_4D.Text = "0";
            this.txtthitaposition_4D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(39, 174);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(16, 15);
            this.label52.TabIndex = 5;
            this.label52.Text = "Θ";
            // 
            // txtzposition_3d
            // 
            this.txtzposition_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtzposition_3d.Location = new System.Drawing.Point(30, 142);
            this.txtzposition_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtzposition_3d.Name = "txtzposition_3d";
            this.txtzposition_3d.Size = new System.Drawing.Size(36, 22);
            this.txtzposition_3d.TabIndex = 6;
            this.txtzposition_3d.Text = "0";
            this.txtzposition_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(39, 123);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(14, 15);
            this.label41.TabIndex = 5;
            this.label41.Text = "Z";
            // 
            // txtyposition_3d
            // 
            this.txtyposition_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtyposition_3d.Location = new System.Drawing.Point(30, 92);
            this.txtyposition_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtyposition_3d.Name = "txtyposition_3d";
            this.txtyposition_3d.Size = new System.Drawing.Size(36, 22);
            this.txtyposition_3d.TabIndex = 4;
            this.txtyposition_3d.Text = "0";
            this.txtyposition_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtxposition_3d
            // 
            this.txtxposition_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtxposition_3d.Location = new System.Drawing.Point(30, 42);
            this.txtxposition_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtxposition_3d.Name = "txtxposition_3d";
            this.txtxposition_3d.Size = new System.Drawing.Size(36, 22);
            this.txtxposition_3d.TabIndex = 3;
            this.txtxposition_3d.Text = "0";
            this.txtxposition_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(39, 73);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(14, 15);
            this.label39.TabIndex = 2;
            this.label39.Text = "Y";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(39, 23);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(15, 15);
            this.label40.TabIndex = 1;
            this.label40.Text = "X";
            // 
            // btnXYZzerocurentposition
            // 
            this.btnXYZzerocurentposition.Enabled = false;
            this.btnXYZzerocurentposition.Location = new System.Drawing.Point(4, 235);
            this.btnXYZzerocurentposition.Margin = new System.Windows.Forms.Padding(4);
            this.btnXYZzerocurentposition.Name = "btnXYZzerocurentposition";
            this.btnXYZzerocurentposition.Size = new System.Drawing.Size(93, 29);
            this.btnXYZzerocurentposition.TabIndex = 0;
            this.btnXYZzerocurentposition.Text = "Zero X - Y - Z";
            this.btnXYZzerocurentposition.UseVisualStyleBackColor = true;
            this.btnXYZzerocurentposition.Click += new System.EventHandler(this.btnXYZzerocurentposition_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hScrollBar7);
            this.groupBox1.Controls.Add(this.hScrollBar8);
            this.groupBox1.Controls.Add(this.btnthitaccw4d);
            this.groupBox1.Controls.Add(this.btnthitacw4d);
            this.groupBox1.Controls.Add(this.txtthitaccw4d);
            this.groupBox1.Controls.Add(this.txtthitacw4d);
            this.groupBox1.Controls.Add(this.hScrollBar5);
            this.groupBox1.Controls.Add(this.hScrollBar6);
            this.groupBox1.Controls.Add(this.btnzreverse_3d);
            this.groupBox1.Controls.Add(this.btnxforward_3d);
            this.groupBox1.Controls.Add(this.btnzforward_3d);
            this.groupBox1.Controls.Add(this.txtxforward_3d);
            this.groupBox1.Controls.Add(this.txtzReverse_3d);
            this.groupBox1.Controls.Add(this.txtxReverse_3d);
            this.groupBox1.Controls.Add(this.txtzForward_3d);
            this.groupBox1.Controls.Add(this.btnxreverse_3d);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Controls.Add(this.hScrollBar4);
            this.groupBox1.Controls.Add(this.hScrollBar2);
            this.groupBox1.Controls.Add(this.hScrollBar3);
            this.groupBox1.Controls.Add(this.btnyreverse_3d);
            this.groupBox1.Controls.Add(this.btnyforward_3d);
            this.groupBox1.Controls.Add(this.txtyReverse_3d);
            this.groupBox1.Controls.Add(this.txtyForward_3d);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(228, 494);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Robot Manual Control";
            // 
            // hScrollBar7
            // 
            this.hScrollBar7.Location = new System.Drawing.Point(9, 448);
            this.hScrollBar7.Maximum = 150;
            this.hScrollBar7.Name = "hScrollBar7";
            this.hScrollBar7.Size = new System.Drawing.Size(98, 18);
            this.hScrollBar7.TabIndex = 34;
            this.hScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar7_Scroll);
            // 
            // hScrollBar8
            // 
            this.hScrollBar8.Location = new System.Drawing.Point(11, 392);
            this.hScrollBar8.Maximum = 150;
            this.hScrollBar8.Name = "hScrollBar8";
            this.hScrollBar8.Size = new System.Drawing.Size(99, 18);
            this.hScrollBar8.TabIndex = 33;
            this.hScrollBar8.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar8_Scroll);
            // 
            // btnthitaccw4d
            // 
            this.btnthitaccw4d.Enabled = false;
            this.btnthitaccw4d.Location = new System.Drawing.Point(137, 420);
            this.btnthitaccw4d.Margin = new System.Windows.Forms.Padding(4);
            this.btnthitaccw4d.Name = "btnthitaccw4d";
            this.btnthitaccw4d.Size = new System.Drawing.Size(78, 29);
            this.btnthitaccw4d.TabIndex = 32;
            this.btnthitaccw4d.Text = "Θ CCW";
            this.btnthitaccw4d.UseVisualStyleBackColor = true;
            this.btnthitaccw4d.Click += new System.EventHandler(this.btnthitaccw4d_Click);
            // 
            // btnthitacw4d
            // 
            this.btnthitacw4d.Enabled = false;
            this.btnthitacw4d.Location = new System.Drawing.Point(137, 368);
            this.btnthitacw4d.Margin = new System.Windows.Forms.Padding(4);
            this.btnthitacw4d.Name = "btnthitacw4d";
            this.btnthitacw4d.Size = new System.Drawing.Size(78, 29);
            this.btnthitacw4d.TabIndex = 31;
            this.btnthitacw4d.Text = "Θ CW";
            this.btnthitacw4d.UseVisualStyleBackColor = true;
            this.btnthitacw4d.Click += new System.EventHandler(this.btnthitacw4d_Click);
            // 
            // txtthitaccw4d
            // 
            this.txtthitaccw4d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtthitaccw4d.Location = new System.Drawing.Point(8, 422);
            this.txtthitaccw4d.Margin = new System.Windows.Forms.Padding(4);
            this.txtthitaccw4d.Name = "txtthitaccw4d";
            this.txtthitaccw4d.Size = new System.Drawing.Size(102, 22);
            this.txtthitaccw4d.TabIndex = 30;
            this.txtthitaccw4d.Text = "0";
            this.txtthitaccw4d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtthitacw4d
            // 
            this.txtthitacw4d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtthitacw4d.Location = new System.Drawing.Point(8, 368);
            this.txtthitacw4d.Margin = new System.Windows.Forms.Padding(4);
            this.txtthitacw4d.Name = "txtthitacw4d";
            this.txtthitacw4d.Size = new System.Drawing.Size(101, 22);
            this.txtthitacw4d.TabIndex = 29;
            this.txtthitacw4d.Text = "0";
            this.txtthitacw4d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hScrollBar5
            // 
            this.hScrollBar5.Location = new System.Drawing.Point(9, 332);
            this.hScrollBar5.Maximum = 150;
            this.hScrollBar5.Name = "hScrollBar5";
            this.hScrollBar5.Size = new System.Drawing.Size(98, 18);
            this.hScrollBar5.TabIndex = 28;
            this.hScrollBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar5_Scroll);
            // 
            // hScrollBar6
            // 
            this.hScrollBar6.Location = new System.Drawing.Point(11, 276);
            this.hScrollBar6.Maximum = 150;
            this.hScrollBar6.Name = "hScrollBar6";
            this.hScrollBar6.Size = new System.Drawing.Size(99, 18);
            this.hScrollBar6.TabIndex = 27;
            this.hScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar6_Scroll);
            // 
            // btnzreverse_3d
            // 
            this.btnzreverse_3d.Enabled = false;
            this.btnzreverse_3d.Location = new System.Drawing.Point(137, 304);
            this.btnzreverse_3d.Margin = new System.Windows.Forms.Padding(4);
            this.btnzreverse_3d.Name = "btnzreverse_3d";
            this.btnzreverse_3d.Size = new System.Drawing.Size(78, 29);
            this.btnzreverse_3d.TabIndex = 26;
            this.btnzreverse_3d.Text = "Z Down";
            this.btnzreverse_3d.UseVisualStyleBackColor = true;
            this.btnzreverse_3d.Click += new System.EventHandler(this.btnzreverse_3d_Click);
            // 
            // btnxforward_3d
            // 
            this.btnxforward_3d.Enabled = false;
            this.btnxforward_3d.Location = new System.Drawing.Point(138, 25);
            this.btnxforward_3d.Margin = new System.Windows.Forms.Padding(4);
            this.btnxforward_3d.Name = "btnxforward_3d";
            this.btnxforward_3d.Size = new System.Drawing.Size(78, 29);
            this.btnxforward_3d.TabIndex = 8;
            this.btnxforward_3d.Text = "X Forward";
            this.btnxforward_3d.UseVisualStyleBackColor = true;
            this.btnxforward_3d.Click += new System.EventHandler(this.btnxforward_3d_Click);
            // 
            // btnzforward_3d
            // 
            this.btnzforward_3d.Enabled = false;
            this.btnzforward_3d.Location = new System.Drawing.Point(137, 252);
            this.btnzforward_3d.Margin = new System.Windows.Forms.Padding(4);
            this.btnzforward_3d.Name = "btnzforward_3d";
            this.btnzforward_3d.Size = new System.Drawing.Size(78, 29);
            this.btnzforward_3d.TabIndex = 25;
            this.btnzforward_3d.Text = "Z Up";
            this.btnzforward_3d.UseVisualStyleBackColor = true;
            this.btnzforward_3d.Click += new System.EventHandler(this.btnzforward_3d_Click);
            // 
            // txtxforward_3d
            // 
            this.txtxforward_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtxforward_3d.Location = new System.Drawing.Point(11, 27);
            this.txtxforward_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtxforward_3d.Name = "txtxforward_3d";
            this.txtxforward_3d.Size = new System.Drawing.Size(103, 22);
            this.txtxforward_3d.TabIndex = 0;
            this.txtxforward_3d.Text = "0";
            this.txtxforward_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtzReverse_3d
            // 
            this.txtzReverse_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtzReverse_3d.Location = new System.Drawing.Point(8, 306);
            this.txtzReverse_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtzReverse_3d.Name = "txtzReverse_3d";
            this.txtzReverse_3d.Size = new System.Drawing.Size(102, 22);
            this.txtzReverse_3d.TabIndex = 22;
            this.txtzReverse_3d.Text = "0";
            this.txtzReverse_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtxReverse_3d
            // 
            this.txtxReverse_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtxReverse_3d.Location = new System.Drawing.Point(11, 77);
            this.txtxReverse_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtxReverse_3d.Name = "txtxReverse_3d";
            this.txtxReverse_3d.Size = new System.Drawing.Size(102, 22);
            this.txtxReverse_3d.TabIndex = 1;
            this.txtxReverse_3d.Text = "0";
            this.txtxReverse_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtzForward_3d
            // 
            this.txtzForward_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtzForward_3d.Location = new System.Drawing.Point(8, 252);
            this.txtzForward_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtzForward_3d.Name = "txtzForward_3d";
            this.txtzForward_3d.Size = new System.Drawing.Size(101, 22);
            this.txtzForward_3d.TabIndex = 21;
            this.txtzForward_3d.Text = "0";
            this.txtzForward_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnxreverse_3d
            // 
            this.btnxreverse_3d.Enabled = false;
            this.btnxreverse_3d.Location = new System.Drawing.Point(138, 77);
            this.btnxreverse_3d.Margin = new System.Windows.Forms.Padding(4);
            this.btnxreverse_3d.Name = "btnxreverse_3d";
            this.btnxreverse_3d.Size = new System.Drawing.Size(78, 29);
            this.btnxreverse_3d.TabIndex = 9;
            this.btnxreverse_3d.Text = "X Reverse";
            this.btnxreverse_3d.UseVisualStyleBackColor = true;
            this.btnxreverse_3d.Click += new System.EventHandler(this.btnxreverse_3d_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(9, 217);
            this.hScrollBar1.Maximum = 150;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(98, 18);
            this.hScrollBar1.TabIndex = 15;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.Location = new System.Drawing.Point(12, 52);
            this.hScrollBar4.Maximum = 150;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(102, 18);
            this.hScrollBar4.TabIndex = 12;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(11, 161);
            this.hScrollBar2.Maximum = 150;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(99, 18);
            this.hScrollBar2.TabIndex = 14;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(11, 102);
            this.hScrollBar3.Maximum = 150;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(102, 18);
            this.hScrollBar3.TabIndex = 13;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // btnyreverse_3d
            // 
            this.btnyreverse_3d.Enabled = false;
            this.btnyreverse_3d.Location = new System.Drawing.Point(137, 187);
            this.btnyreverse_3d.Margin = new System.Windows.Forms.Padding(4);
            this.btnyreverse_3d.Name = "btnyreverse_3d";
            this.btnyreverse_3d.Size = new System.Drawing.Size(78, 29);
            this.btnyreverse_3d.TabIndex = 11;
            this.btnyreverse_3d.Text = "Y Right";
            this.btnyreverse_3d.UseVisualStyleBackColor = true;
            this.btnyreverse_3d.Click += new System.EventHandler(this.btnyreverse_3d_Click);
            // 
            // btnyforward_3d
            // 
            this.btnyforward_3d.Enabled = false;
            this.btnyforward_3d.Location = new System.Drawing.Point(137, 137);
            this.btnyforward_3d.Margin = new System.Windows.Forms.Padding(4);
            this.btnyforward_3d.Name = "btnyforward_3d";
            this.btnyforward_3d.Size = new System.Drawing.Size(78, 29);
            this.btnyforward_3d.TabIndex = 10;
            this.btnyforward_3d.Text = "Y Left";
            this.btnyforward_3d.UseVisualStyleBackColor = true;
            this.btnyforward_3d.Click += new System.EventHandler(this.btnyforward_3d_Click);
            // 
            // txtyReverse_3d
            // 
            this.txtyReverse_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtyReverse_3d.Location = new System.Drawing.Point(8, 191);
            this.txtyReverse_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtyReverse_3d.Name = "txtyReverse_3d";
            this.txtyReverse_3d.Size = new System.Drawing.Size(102, 22);
            this.txtyReverse_3d.TabIndex = 3;
            this.txtyReverse_3d.Text = "0";
            this.txtyReverse_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtyForward_3d
            // 
            this.txtyForward_3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtyForward_3d.Location = new System.Drawing.Point(8, 137);
            this.txtyForward_3d.Margin = new System.Windows.Forms.Padding(4);
            this.txtyForward_3d.Name = "txtyForward_3d";
            this.txtyForward_3d.Size = new System.Drawing.Size(101, 22);
            this.txtyForward_3d.TabIndex = 2;
            this.txtyForward_3d.Text = "0";
            this.txtyForward_3d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbrfg_1000
            // 
            this.gbrfg_1000.Controls.Add(this.txtrepeatspwRFG);
            this.gbrfg_1000.Controls.Add(this.label57);
            this.gbrfg_1000.Controls.Add(this.btreviewsettings);
            this.gbrfg_1000.Controls.Add(this.txtfrequencyRFGFrequency);
            this.gbrfg_1000.Controls.Add(this.txtvoltageRFGPulsed);
            this.gbrfg_1000.Controls.Add(this.label34);
            this.gbrfg_1000.Controls.Add(this.label35);
            this.gbrfg_1000.Controls.Add(this.label50);
            this.gbrfg_1000.Controls.Add(this.label23);
            this.gbrfg_1000.Controls.Add(this.label24);
            this.gbrfg_1000.Controls.Add(this.txtpwtineonRFG);
            this.gbrfg_1000.Controls.Add(this.txtcwtimeonRFG);
            this.gbrfg_1000.Controls.Add(this.txtdutyfactorRFG);
            this.gbrfg_1000.Controls.Add(this.label25);
            this.gbrfg_1000.Controls.Add(this.txtreaddatainput);
            this.gbrfg_1000.Controls.Add(this.label26);
            this.gbrfg_1000.Controls.Add(this.txtfrequencyRFG);
            this.gbrfg_1000.Controls.Add(this.txtpulserepfreqRFG);
            this.gbrfg_1000.Controls.Add(this.lblconnectionstatusRFG);
            this.gbrfg_1000.Controls.Add(this.label28);
            this.gbrfg_1000.Controls.Add(this.txtvoltageRFG);
            this.gbrfg_1000.Controls.Add(this.label29);
            this.gbrfg_1000.Controls.Add(this.label30);
            this.gbrfg_1000.Controls.Add(this.cmbportname);
            this.gbrfg_1000.Controls.Add(this.label31);
            this.gbrfg_1000.Controls.Add(this.btnconnect);
            this.gbrfg_1000.Controls.Add(this.btnmode);
            this.gbrfg_1000.Controls.Add(this.btnponcw);
            this.gbrfg_1000.Controls.Add(this.btnonpw);
            this.gbrfg_1000.Controls.Add(this.btnoffpw);
            this.gbrfg_1000.Controls.Add(this.btnoffcw);
            this.gbrfg_1000.Location = new System.Drawing.Point(647, 6);
            this.gbrfg_1000.Name = "gbrfg_1000";
            this.gbrfg_1000.Size = new System.Drawing.Size(630, 327);
            this.gbrfg_1000.TabIndex = 40;
            this.gbrfg_1000.TabStop = false;
            this.gbrfg_1000.Text = "Ultrasound Control - RF Generator";
            this.gbrfg_1000.Visible = false;
            // 
            // txtrepeatspwRFG
            // 
            this.txtrepeatspwRFG.Location = new System.Drawing.Point(341, 192);
            this.txtrepeatspwRFG.Name = "txtrepeatspwRFG";
            this.txtrepeatspwRFG.Size = new System.Drawing.Size(54, 21);
            this.txtrepeatspwRFG.TabIndex = 40;
            this.txtrepeatspwRFG.Text = "1";
            this.txtrepeatspwRFG.TextChanged += new System.EventHandler(this.txtrepeatspwRFG_TextChanged);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(220, 194);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(56, 15);
            this.label57.TabIndex = 39;
            this.label57.Text = "Repeats:";
            // 
            // btreviewsettings
            // 
            this.btreviewsettings.Enabled = false;
            this.btreviewsettings.Location = new System.Drawing.Point(275, 293);
            this.btreviewsettings.Name = "btreviewsettings";
            this.btreviewsettings.Size = new System.Drawing.Size(134, 25);
            this.btreviewsettings.TabIndex = 38;
            this.btreviewsettings.Text = "Review Settings";
            this.btreviewsettings.UseVisualStyleBackColor = true;
            this.btreviewsettings.Click += new System.EventHandler(this.btreviewsettings_Click);
            // 
            // txtfrequencyRFGFrequency
            // 
            this.txtfrequencyRFGFrequency.Location = new System.Drawing.Point(341, 84);
            this.txtfrequencyRFGFrequency.Name = "txtfrequencyRFGFrequency";
            this.txtfrequencyRFGFrequency.Size = new System.Drawing.Size(54, 21);
            this.txtfrequencyRFGFrequency.TabIndex = 37;
            this.txtfrequencyRFGFrequency.Text = "1";
            // 
            // txtvoltageRFGPulsed
            // 
            this.txtvoltageRFGPulsed.Location = new System.Drawing.Point(341, 58);
            this.txtvoltageRFGPulsed.Name = "txtvoltageRFGPulsed";
            this.txtvoltageRFGPulsed.Size = new System.Drawing.Size(54, 21);
            this.txtvoltageRFGPulsed.TabIndex = 36;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(219, 87);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(104, 15);
            this.label34.TabIndex = 35;
            this.label34.Text = "Frequency (MHz):";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(219, 58);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 15);
            this.label35.TabIndex = 34;
            this.label35.Text = "Power (W):";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label50.Location = new System.Drawing.Point(422, 17);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(120, 15);
            this.label50.TabIndex = 33;
            this.label50.Text = "List of commands";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label23.Location = new System.Drawing.Point(288, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 16);
            this.label23.TabIndex = 30;
            this.label23.Text = "PULSED";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label24.Location = new System.Drawing.Point(50, 28);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 16);
            this.label24.TabIndex = 29;
            this.label24.Text = "CONTINIOUS";
            // 
            // txtpwtineonRFG
            // 
            this.txtpwtineonRFG.Location = new System.Drawing.Point(341, 164);
            this.txtpwtineonRFG.Name = "txtpwtineonRFG";
            this.txtpwtineonRFG.Size = new System.Drawing.Size(54, 21);
            this.txtpwtineonRFG.TabIndex = 27;
            this.txtpwtineonRFG.Text = "0";
            // 
            // txtcwtimeonRFG
            // 
            this.txtcwtimeonRFG.Location = new System.Drawing.Point(141, 108);
            this.txtcwtimeonRFG.Name = "txtcwtimeonRFG";
            this.txtcwtimeonRFG.Size = new System.Drawing.Size(54, 21);
            this.txtcwtimeonRFG.TabIndex = 28;
            this.txtcwtimeonRFG.Text = "0";
            // 
            // txtdutyfactorRFG
            // 
            this.txtdutyfactorRFG.Location = new System.Drawing.Point(341, 111);
            this.txtdutyfactorRFG.Name = "txtdutyfactorRFG";
            this.txtdutyfactorRFG.Size = new System.Drawing.Size(54, 21);
            this.txtdutyfactorRFG.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(219, 140);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 15);
            this.label25.TabIndex = 25;
            this.label25.Text = "Pulse Rep Freq (ms)";
            // 
            // txtreaddatainput
            // 
            this.txtreaddatainput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtreaddatainput.Location = new System.Drawing.Point(420, 33);
            this.txtreaddatainput.Multiline = true;
            this.txtreaddatainput.Name = "txtreaddatainput";
            this.txtreaddatainput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtreaddatainput.Size = new System.Drawing.Size(200, 240);
            this.txtreaddatainput.TabIndex = 11;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(219, 167);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 15);
            this.label26.TabIndex = 18;
            this.label26.Text = "On Time (s):";
            // 
            // txtfrequencyRFG
            // 
            this.txtfrequencyRFG.Location = new System.Drawing.Point(141, 82);
            this.txtfrequencyRFG.Name = "txtfrequencyRFG";
            this.txtfrequencyRFG.Size = new System.Drawing.Size(54, 21);
            this.txtfrequencyRFG.TabIndex = 26;
            this.txtfrequencyRFG.Text = "1";
            // 
            // txtpulserepfreqRFG
            // 
            this.txtpulserepfreqRFG.Location = new System.Drawing.Point(341, 137);
            this.txtpulserepfreqRFG.Name = "txtpulserepfreqRFG";
            this.txtpulserepfreqRFG.Size = new System.Drawing.Size(54, 21);
            this.txtpulserepfreqRFG.TabIndex = 17;
            // 
            // lblconnectionstatusRFG
            // 
            this.lblconnectionstatusRFG.AutoSize = true;
            this.lblconnectionstatusRFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblconnectionstatusRFG.Location = new System.Drawing.Point(226, 269);
            this.lblconnectionstatusRFG.Name = "lblconnectionstatusRFG";
            this.lblconnectionstatusRFG.Size = new System.Drawing.Size(74, 15);
            this.lblconnectionstatusRFG.TabIndex = 20;
            this.lblconnectionstatusRFG.Text = "Not Connect";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(220, 114);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 15);
            this.label28.TabIndex = 22;
            this.label28.Text = "Duty Factor (%)";
            // 
            // txtvoltageRFG
            // 
            this.txtvoltageRFG.Location = new System.Drawing.Point(141, 56);
            this.txtvoltageRFG.Name = "txtvoltageRFG";
            this.txtvoltageRFG.Size = new System.Drawing.Size(54, 21);
            this.txtvoltageRFG.TabIndex = 23;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 111);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 15);
            this.label29.TabIndex = 19;
            this.label29.Text = "On Time (s):";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 85);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 15);
            this.label30.TabIndex = 16;
            this.label30.Text = "Frequency (MHz):";
            // 
            // cmbportname
            // 
            this.cmbportname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbportname.FormattingEnabled = true;
            this.cmbportname.Location = new System.Drawing.Point(15, 266);
            this.cmbportname.Name = "cmbportname";
            this.cmbportname.Size = new System.Drawing.Size(185, 23);
            this.cmbportname.TabIndex = 21;
            this.cmbportname.SelectedIndexChanged += new System.EventHandler(this.cmbportname_SelectedIndexChanged);
            this.cmbportname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbportname_MouseClick);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(19, 56);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 15);
            this.label31.TabIndex = 10;
            this.label31.Text = "Power (W):";
            // 
            // btnconnect
            // 
            this.btnconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnconnect.Location = new System.Drawing.Point(13, 294);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(185, 25);
            this.btnconnect.TabIndex = 8;
            this.btnconnect.Text = "Connect to RF Generator";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnmode
            // 
            this.btnmode.Enabled = false;
            this.btnmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnmode.Location = new System.Drawing.Point(539, 281);
            this.btnmode.Name = "btnmode";
            this.btnmode.Size = new System.Drawing.Size(80, 36);
            this.btnmode.TabIndex = 24;
            this.btnmode.Text = "RUN";
            this.btnmode.UseVisualStyleBackColor = true;
            this.btnmode.Click += new System.EventHandler(this.btnmode_Click);
            // 
            // btnponcw
            // 
            this.btnponcw.Enabled = false;
            this.btnponcw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnponcw.Location = new System.Drawing.Point(10, 232);
            this.btnponcw.Name = "btnponcw";
            this.btnponcw.Size = new System.Drawing.Size(92, 25);
            this.btnponcw.TabIndex = 14;
            this.btnponcw.Text = "Set-Up CW";
            this.btnponcw.UseVisualStyleBackColor = true;
            this.btnponcw.Click += new System.EventHandler(this.btnponcw_Click);
            // 
            // btnonpw
            // 
            this.btnonpw.Enabled = false;
            this.btnonpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnonpw.Location = new System.Drawing.Point(219, 232);
            this.btnonpw.Name = "btnonpw";
            this.btnonpw.Size = new System.Drawing.Size(92, 25);
            this.btnonpw.TabIndex = 15;
            this.btnonpw.Text = "Set-Up PW";
            this.btnonpw.UseVisualStyleBackColor = true;
            this.btnonpw.Click += new System.EventHandler(this.btnonpw_Click);
            // 
            // btnoffpw
            // 
            this.btnoffpw.Enabled = false;
            this.btnoffpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnoffpw.Location = new System.Drawing.Point(317, 232);
            this.btnoffpw.Name = "btnoffpw";
            this.btnoffpw.Size = new System.Drawing.Size(92, 25);
            this.btnoffpw.TabIndex = 12;
            this.btnoffpw.Text = "Power OFF PW";
            this.btnoffpw.UseVisualStyleBackColor = true;
            this.btnoffpw.Click += new System.EventHandler(this.btnoffpw_Click);
            // 
            // btnoffcw
            // 
            this.btnoffcw.Enabled = false;
            this.btnoffcw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnoffcw.Location = new System.Drawing.Point(118, 232);
            this.btnoffcw.Name = "btnoffcw";
            this.btnoffcw.Size = new System.Drawing.Size(92, 25);
            this.btnoffcw.TabIndex = 13;
            this.btnoffcw.Text = "Power OFF CW";
            this.btnoffcw.UseVisualStyleBackColor = true;
            this.btnoffcw.Click += new System.EventHandler(this.btnoffcw_Click);
            // 
            // gbagilentgenerator
            // 
            this.gbagilentgenerator.Controls.Add(this.txtrepeatsforcw);
            this.gbagilentgenerator.Controls.Add(this.txttimedelayforcw);
            this.gbagilentgenerator.Controls.Add(this.label36);
            this.gbagilentgenerator.Controls.Add(this.label37);
            this.gbagilentgenerator.Controls.Add(this.txtfrequencypulsed);
            this.gbagilentgenerator.Controls.Add(this.txtvoltagepulsed);
            this.gbagilentgenerator.Controls.Add(this.label3);
            this.gbagilentgenerator.Controls.Add(this.label2);
            this.gbagilentgenerator.Controls.Add(this.txtagilentvisaID);
            this.gbagilentgenerator.Controls.Add(this.label1);
            this.gbagilentgenerator.Controls.Add(this.lblconnectionstatus);
            this.gbagilentgenerator.Controls.Add(this.btnconnecttoagilent);
            this.gbagilentgenerator.Controls.Add(this.btnpoweroffpulsed);
            this.gbagilentgenerator.Controls.Add(this.btnpoweronpulsed);
            this.gbagilentgenerator.Controls.Add(this.btnpoweroffcont);
            this.gbagilentgenerator.Controls.Add(this.btnpoweroncont);
            this.gbagilentgenerator.Controls.Add(this.txtontimepulsed);
            this.gbagilentgenerator.Controls.Add(this.txtpulserepfreq);
            this.gbagilentgenerator.Controls.Add(this.txtdutyfactor);
            this.gbagilentgenerator.Controls.Add(this.txtontimecontinious);
            this.gbagilentgenerator.Controls.Add(this.txtfrequency);
            this.gbagilentgenerator.Controls.Add(this.txtvoltage);
            this.gbagilentgenerator.Controls.Add(this.label20);
            this.gbagilentgenerator.Controls.Add(this.label19);
            this.gbagilentgenerator.Controls.Add(this.label18);
            this.gbagilentgenerator.Controls.Add(this.label17);
            this.gbagilentgenerator.Controls.Add(this.label16);
            this.gbagilentgenerator.Controls.Add(this.label15);
            this.gbagilentgenerator.Controls.Add(this.label14);
            this.gbagilentgenerator.Controls.Add(this.label13);
            this.gbagilentgenerator.Location = new System.Drawing.Point(647, 7);
            this.gbagilentgenerator.Margin = new System.Windows.Forms.Padding(4);
            this.gbagilentgenerator.Name = "gbagilentgenerator";
            this.gbagilentgenerator.Padding = new System.Windows.Forms.Padding(4);
            this.gbagilentgenerator.Size = new System.Drawing.Size(395, 388);
            this.gbagilentgenerator.TabIndex = 33;
            this.gbagilentgenerator.TabStop = false;
            this.gbagilentgenerator.Text = "Ultrasound Control ";
            // 
            // txtrepeatsforcw
            // 
            this.txtrepeatsforcw.Enabled = false;
            this.txtrepeatsforcw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtrepeatsforcw.Location = new System.Drawing.Point(129, 220);
            this.txtrepeatsforcw.Margin = new System.Windows.Forms.Padding(4);
            this.txtrepeatsforcw.Name = "txtrepeatsforcw";
            this.txtrepeatsforcw.Size = new System.Drawing.Size(45, 22);
            this.txtrepeatsforcw.TabIndex = 33;
            this.txtrepeatsforcw.Text = "1";
            // 
            // txttimedelayforcw
            // 
            this.txttimedelayforcw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txttimedelayforcw.Location = new System.Drawing.Point(130, 188);
            this.txttimedelayforcw.Margin = new System.Windows.Forms.Padding(4);
            this.txttimedelayforcw.Name = "txttimedelayforcw";
            this.txttimedelayforcw.Size = new System.Drawing.Size(45, 22);
            this.txttimedelayforcw.TabIndex = 32;
            this.txttimedelayforcw.Text = "0";
            this.txttimedelayforcw.TextChanged += new System.EventHandler(this.txttimedelayforcw_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(14, 221);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 15);
            this.label36.TabIndex = 31;
            this.label36.Text = "Repeats";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 189);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(38, 15);
            this.label37.TabIndex = 30;
            this.label37.Text = "Delay";
            // 
            // txtfrequencypulsed
            // 
            this.txtfrequencypulsed.Location = new System.Drawing.Point(333, 121);
            this.txtfrequencypulsed.Name = "txtfrequencypulsed";
            this.txtfrequencypulsed.Size = new System.Drawing.Size(42, 21);
            this.txtfrequencypulsed.TabIndex = 29;
            // 
            // txtvoltagepulsed
            // 
            this.txtvoltagepulsed.Location = new System.Drawing.Point(331, 89);
            this.txtvoltagepulsed.Name = "txtvoltagepulsed";
            this.txtvoltagepulsed.Size = new System.Drawing.Size(44, 21);
            this.txtvoltagepulsed.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Voltage (mV)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Frequency (MHz)";
            // 
            // txtagilentvisaID
            // 
            this.txtagilentvisaID.Location = new System.Drawing.Point(104, 22);
            this.txtagilentvisaID.Name = "txtagilentvisaID";
            this.txtagilentvisaID.Size = new System.Drawing.Size(284, 21);
            this.txtagilentvisaID.TabIndex = 25;
            this.txtagilentvisaID.Text = "USB0::0x0957::0x0407::MY44058626::0::INSTR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Device USB ID";
            // 
            // lblconnectionstatus
            // 
            this.lblconnectionstatus.AutoSize = true;
            this.lblconnectionstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblconnectionstatus.Location = new System.Drawing.Point(137, 348);
            this.lblconnectionstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconnectionstatus.Name = "lblconnectionstatus";
            this.lblconnectionstatus.Size = new System.Drawing.Size(108, 16);
            this.lblconnectionstatus.TabIndex = 23;
            this.lblconnectionstatus.Text = "Generator Status";
            // 
            // btnconnecttoagilent
            // 
            this.btnconnecttoagilent.Location = new System.Drawing.Point(10, 337);
            this.btnconnecttoagilent.Margin = new System.Windows.Forms.Padding(4);
            this.btnconnecttoagilent.Name = "btnconnecttoagilent";
            this.btnconnecttoagilent.Size = new System.Drawing.Size(123, 36);
            this.btnconnecttoagilent.TabIndex = 21;
            this.btnconnecttoagilent.Text = "Connect Generator";
            this.btnconnecttoagilent.UseVisualStyleBackColor = true;
            this.btnconnecttoagilent.Click += new System.EventHandler(this.btnconnecttoagilent_Click);
            // 
            // btnpoweroffpulsed
            // 
            this.btnpoweroffpulsed.Enabled = false;
            this.btnpoweroffpulsed.Location = new System.Drawing.Point(299, 278);
            this.btnpoweroffpulsed.Margin = new System.Windows.Forms.Padding(4);
            this.btnpoweroffpulsed.Name = "btnpoweroffpulsed";
            this.btnpoweroffpulsed.Size = new System.Drawing.Size(88, 52);
            this.btnpoweroffpulsed.TabIndex = 20;
            this.btnpoweroffpulsed.Text = "Power OFF Pulsed";
            this.btnpoweroffpulsed.UseVisualStyleBackColor = true;
            this.btnpoweroffpulsed.Click += new System.EventHandler(this.btnpoweroffpulsed_Click);
            // 
            // btnpoweronpulsed
            // 
            this.btnpoweronpulsed.Enabled = false;
            this.btnpoweronpulsed.Location = new System.Drawing.Point(210, 278);
            this.btnpoweronpulsed.Margin = new System.Windows.Forms.Padding(4);
            this.btnpoweronpulsed.Name = "btnpoweronpulsed";
            this.btnpoweronpulsed.Size = new System.Drawing.Size(88, 52);
            this.btnpoweronpulsed.TabIndex = 19;
            this.btnpoweronpulsed.Text = "Power ON Pulsed";
            this.btnpoweronpulsed.UseVisualStyleBackColor = true;
            this.btnpoweronpulsed.Click += new System.EventHandler(this.btnpoweronpulsed_Click);
            // 
            // btnpoweroffcont
            // 
            this.btnpoweroffcont.Enabled = false;
            this.btnpoweroffcont.Location = new System.Drawing.Point(101, 278);
            this.btnpoweroffcont.Margin = new System.Windows.Forms.Padding(4);
            this.btnpoweroffcont.Name = "btnpoweroffcont";
            this.btnpoweroffcont.Size = new System.Drawing.Size(87, 52);
            this.btnpoweroffcont.TabIndex = 18;
            this.btnpoweroffcont.Text = "Power OFF Continious";
            this.btnpoweroffcont.UseVisualStyleBackColor = true;
            this.btnpoweroffcont.Click += new System.EventHandler(this.btnpoweroffcont_Click);
            // 
            // btnpoweroncont
            // 
            this.btnpoweroncont.Enabled = false;
            this.btnpoweroncont.Location = new System.Drawing.Point(10, 278);
            this.btnpoweroncont.Margin = new System.Windows.Forms.Padding(4);
            this.btnpoweroncont.Name = "btnpoweroncont";
            this.btnpoweroncont.Size = new System.Drawing.Size(87, 52);
            this.btnpoweroncont.TabIndex = 17;
            this.btnpoweroncont.Text = "Power ON Continious";
            this.btnpoweroncont.UseVisualStyleBackColor = true;
            this.btnpoweroncont.Click += new System.EventHandler(this.btnpoweroncont_Click);
            // 
            // txtontimepulsed
            // 
            this.txtontimepulsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtontimepulsed.Location = new System.Drawing.Point(333, 220);
            this.txtontimepulsed.Margin = new System.Windows.Forms.Padding(4);
            this.txtontimepulsed.Name = "txtontimepulsed";
            this.txtontimepulsed.Size = new System.Drawing.Size(42, 22);
            this.txtontimepulsed.TabIndex = 16;
            // 
            // txtpulserepfreq
            // 
            this.txtpulserepfreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtpulserepfreq.Location = new System.Drawing.Point(335, 188);
            this.txtpulserepfreq.Margin = new System.Windows.Forms.Padding(4);
            this.txtpulserepfreq.Name = "txtpulserepfreq";
            this.txtpulserepfreq.Size = new System.Drawing.Size(40, 22);
            this.txtpulserepfreq.TabIndex = 15;
            // 
            // txtdutyfactor
            // 
            this.txtdutyfactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtdutyfactor.Location = new System.Drawing.Point(333, 154);
            this.txtdutyfactor.Margin = new System.Windows.Forms.Padding(4);
            this.txtdutyfactor.Name = "txtdutyfactor";
            this.txtdutyfactor.Size = new System.Drawing.Size(42, 22);
            this.txtdutyfactor.TabIndex = 14;
            // 
            // txtontimecontinious
            // 
            this.txtontimecontinious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtontimecontinious.Location = new System.Drawing.Point(129, 158);
            this.txtontimecontinious.Margin = new System.Windows.Forms.Padding(4);
            this.txtontimecontinious.Name = "txtontimecontinious";
            this.txtontimecontinious.Size = new System.Drawing.Size(45, 22);
            this.txtontimecontinious.TabIndex = 13;
            // 
            // txtfrequency
            // 
            this.txtfrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtfrequency.Location = new System.Drawing.Point(130, 126);
            this.txtfrequency.Margin = new System.Windows.Forms.Padding(4);
            this.txtfrequency.Name = "txtfrequency";
            this.txtfrequency.Size = new System.Drawing.Size(45, 22);
            this.txtfrequency.TabIndex = 12;
            // 
            // txtvoltage
            // 
            this.txtvoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtvoltage.Location = new System.Drawing.Point(130, 96);
            this.txtvoltage.Margin = new System.Windows.Forms.Padding(4);
            this.txtvoltage.Name = "txtvoltage";
            this.txtvoltage.Size = new System.Drawing.Size(45, 22);
            this.txtvoltage.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(207, 225);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "On Time(s)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(205, 191);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 15);
            this.label19.TabIndex = 9;
            this.label19.Text = "Pulse Rep Period (ms)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 157);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "Dutyfactor (%)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 157);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 7;
            this.label17.Text = "On Time(s)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 125);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Frequency (MHz)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 93);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Voltage (mV)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label14.Location = new System.Drawing.Point(272, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "PULSED";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.Location = new System.Drawing.Point(34, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "CONTINIOUS";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label49);
            this.tabPage1.Controls.Add(this.gridpattern2D);
            this.tabPage1.Controls.Add(this.gbcurrentposition);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.xthitapanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1584, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "X - Θ Robot Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label49.Location = new System.Drawing.Point(282, 275);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(108, 15);
            this.label49.TabIndex = 34;
            this.label49.Text = "Visual Grid Pattern";
            // 
            // gridpattern2D
            // 
            this.gridpattern2D.Location = new System.Drawing.Point(281, 291);
            this.gridpattern2D.Name = "gridpattern2D";
            this.gridpattern2D.Size = new System.Drawing.Size(410, 201);
            this.gridpattern2D.TabIndex = 33;
            // 
            // gbcurrentposition
            // 
            this.gbcurrentposition.Controls.Add(this.txtthitaposition);
            this.gbcurrentposition.Controls.Add(this.txtxposition);
            this.gbcurrentposition.Controls.Add(this.label10);
            this.gbcurrentposition.Controls.Add(this.label9);
            this.gbcurrentposition.Controls.Add(this.btnxthitaposition);
            this.gbcurrentposition.Location = new System.Drawing.Point(275, 4);
            this.gbcurrentposition.Margin = new System.Windows.Forms.Padding(4);
            this.gbcurrentposition.Name = "gbcurrentposition";
            this.gbcurrentposition.Padding = new System.Windows.Forms.Padding(4);
            this.gbcurrentposition.Size = new System.Drawing.Size(101, 193);
            this.gbcurrentposition.TabIndex = 28;
            this.gbcurrentposition.TabStop = false;
            this.gbcurrentposition.Text = "Position";
            // 
            // txtthitaposition
            // 
            this.txtthitaposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtthitaposition.Location = new System.Drawing.Point(28, 119);
            this.txtthitaposition.Margin = new System.Windows.Forms.Padding(4);
            this.txtthitaposition.Name = "txtthitaposition";
            this.txtthitaposition.Size = new System.Drawing.Size(36, 22);
            this.txtthitaposition.TabIndex = 4;
            this.txtthitaposition.Text = "0";
            this.txtthitaposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtxposition
            // 
            this.txtxposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtxposition.Location = new System.Drawing.Point(29, 58);
            this.txtxposition.Margin = new System.Windows.Forms.Padding(4);
            this.txtxposition.Name = "txtxposition";
            this.txtxposition.Size = new System.Drawing.Size(36, 22);
            this.txtxposition.TabIndex = 3;
            this.txtxposition.Text = "0";
            this.txtxposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Θ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "X";
            // 
            // btnxthitaposition
            // 
            this.btnxthitaposition.Enabled = false;
            this.btnxthitaposition.Location = new System.Drawing.Point(10, 152);
            this.btnxthitaposition.Margin = new System.Windows.Forms.Padding(4);
            this.btnxthitaposition.Name = "btnxthitaposition";
            this.btnxthitaposition.Size = new System.Drawing.Size(80, 29);
            this.btnxthitaposition.TabIndex = 0;
            this.btnxthitaposition.Text = "Zero X - Θ";
            this.btnxthitaposition.UseVisualStyleBackColor = true;
            this.btnxthitaposition.Click += new System.EventHandler(this.btnxthitaposition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txttimefornextsonication);
            this.groupBox2.Controls.Add(this.cmbselectsignal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnstartgrid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtnthitastep);
            this.groupBox2.Controls.Add(this.txtnthitagrid);
            this.groupBox2.Controls.Add(this.txtnxstep);
            this.groupBox2.Controls.Add(this.txtnxgrid);
            this.groupBox2.Location = new System.Drawing.Point(387, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(314, 267);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automated Motion Control";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 30);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(117, 15);
            this.label32.TabIndex = 13;
            this.label32.Text = "Select type of Signal";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(198, 15);
            this.label21.TabIndex = 12;
            this.label21.Text = "Time between each step (seconds)";
            // 
            // txttimefornextsonication
            // 
            this.txttimefornextsonication.Location = new System.Drawing.Point(211, 86);
            this.txttimefornextsonication.Name = "txttimefornextsonication";
            this.txttimefornextsonication.Size = new System.Drawing.Size(53, 21);
            this.txttimefornextsonication.TabIndex = 11;
            this.txttimefornextsonication.Text = "20";
            this.txttimefornextsonication.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbselectsignal
            // 
            this.cmbselectsignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbselectsignal.FormattingEnabled = true;
            this.cmbselectsignal.Items.AddRange(new object[] {
            "Agilent - Continious Signal",
            "Agilent - Pulsed Signal",
            "RFG_1000 - Continious Signal",
            "RFG_1000 - Pulsed Signal",
            "No Power"});
            this.cmbselectsignal.Location = new System.Drawing.Point(10, 49);
            this.cmbselectsignal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbselectsignal.Name = "cmbselectsignal";
            this.cmbselectsignal.Size = new System.Drawing.Size(254, 24);
            this.cmbselectsignal.TabIndex = 10;
            this.cmbselectsignal.SelectedIndexChanged += new System.EventHandler(this.cmbselectsignal_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Step (Degrees)";
            // 
            // btnstartgrid
            // 
            this.btnstartgrid.Enabled = false;
            this.btnstartgrid.Location = new System.Drawing.Point(199, 230);
            this.btnstartgrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnstartgrid.Name = "btnstartgrid";
            this.btnstartgrid.Size = new System.Drawing.Size(78, 29);
            this.btnstartgrid.TabIndex = 8;
            this.btnstartgrid.Text = "Start Grid";
            this.btnstartgrid.UseVisualStyleBackColor = true;
            this.btnstartgrid.Click += new System.EventHandler(this.btnstartgrid_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Step (mm)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "# Of Steps";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Θ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            // 
            // txtnthitastep
            // 
            this.txtnthitastep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtnthitastep.Location = new System.Drawing.Point(224, 193);
            this.txtnthitastep.Margin = new System.Windows.Forms.Padding(4);
            this.txtnthitastep.Name = "txtnthitastep";
            this.txtnthitastep.Size = new System.Drawing.Size(49, 22);
            this.txtnthitastep.TabIndex = 3;
            this.txtnthitastep.Text = "0";
            this.txtnthitastep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnthitagrid
            // 
            this.txtnthitagrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtnthitagrid.Location = new System.Drawing.Point(53, 194);
            this.txtnthitagrid.Margin = new System.Windows.Forms.Padding(4);
            this.txtnthitagrid.Name = "txtnthitagrid";
            this.txtnthitagrid.Size = new System.Drawing.Size(54, 22);
            this.txtnthitagrid.TabIndex = 2;
            this.txtnthitagrid.Text = "0";
            this.txtnthitagrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnxstep
            // 
            this.txtnxstep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtnxstep.Location = new System.Drawing.Point(224, 138);
            this.txtnxstep.Margin = new System.Windows.Forms.Padding(4);
            this.txtnxstep.Name = "txtnxstep";
            this.txtnxstep.Size = new System.Drawing.Size(53, 22);
            this.txtnxstep.TabIndex = 1;
            this.txtnxstep.Text = "0";
            this.txtnxstep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnxgrid
            // 
            this.txtnxgrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtnxgrid.Location = new System.Drawing.Point(55, 142);
            this.txtnxgrid.Margin = new System.Windows.Forms.Padding(4);
            this.txtnxgrid.Name = "txtnxgrid";
            this.txtnxgrid.Size = new System.Drawing.Size(54, 22);
            this.txtnxgrid.TabIndex = 0;
            this.txtnxgrid.Text = "0";
            this.txtnxgrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xthitapanel
            // 
            this.xthitapanel.Controls.Add(this.label51);
            this.xthitapanel.Controls.Add(this.lbl1Dtitle1);
            this.xthitapanel.Controls.Add(this.txt1Dseconds);
            this.xthitapanel.Controls.Add(this.lbl1Dtitle);
            this.xthitapanel.Controls.Add(this.btn1Dgrid);
            this.xthitapanel.Controls.Add(this.txt1Drepeats);
            this.xthitapanel.Controls.Add(this.btnmcw);
            this.xthitapanel.Controls.Add(this.btnmxfw);
            this.xthitapanel.Controls.Add(this.btnmccw);
            this.xthitapanel.Controls.Add(this.btnmcrev);
            this.xthitapanel.Controls.Add(this.ccwscroll);
            this.xthitapanel.Controls.Add(this.cwscroll);
            this.xthitapanel.Controls.Add(this.btnstopnow);
            this.xthitapanel.Controls.Add(this.xrscroll);
            this.xthitapanel.Controls.Add(this.xfscroll);
            this.xthitapanel.Controls.Add(this.btnthitaccw);
            this.xthitapanel.Controls.Add(this.btnthitacw);
            this.xthitapanel.Controls.Add(this.btnxrev);
            this.xthitapanel.Controls.Add(this.btnxfw);
            this.xthitapanel.Controls.Add(this.txtthitaccw);
            this.xthitapanel.Controls.Add(this.txtthitacw);
            this.xthitapanel.Controls.Add(this.txtxrev);
            this.xthitapanel.Controls.Add(this.txtxfw);
            this.xthitapanel.Location = new System.Drawing.Point(9, 4);
            this.xthitapanel.Margin = new System.Windows.Forms.Padding(4);
            this.xthitapanel.Name = "xthitapanel";
            this.xthitapanel.Padding = new System.Windows.Forms.Padding(4);
            this.xthitapanel.Size = new System.Drawing.Size(257, 490);
            this.xthitapanel.TabIndex = 26;
            this.xthitapanel.TabStop = false;
            this.xthitapanel.Text = "Robot Manual Control";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label51.Location = new System.Drawing.Point(39, 267);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(91, 15);
            this.label51.TabIndex = 35;
            this.label51.Text = "Manual Control";
            // 
            // lbl1Dtitle1
            // 
            this.lbl1Dtitle1.AutoSize = true;
            this.lbl1Dtitle1.Location = new System.Drawing.Point(9, 463);
            this.lbl1Dtitle1.Name = "lbl1Dtitle1";
            this.lbl1Dtitle1.Size = new System.Drawing.Size(55, 15);
            this.lbl1Dtitle1.TabIndex = 25;
            this.lbl1Dtitle1.Text = "Seconds";
            this.lbl1Dtitle1.Visible = false;
            // 
            // txt1Dseconds
            // 
            this.txt1Dseconds.Location = new System.Drawing.Point(69, 460);
            this.txt1Dseconds.Name = "txt1Dseconds";
            this.txt1Dseconds.Size = new System.Drawing.Size(54, 21);
            this.txt1Dseconds.TabIndex = 24;
            this.txt1Dseconds.Visible = false;
            this.txt1Dseconds.TextChanged += new System.EventHandler(this.txt1Dseconds_TextChanged);
            // 
            // lbl1Dtitle
            // 
            this.lbl1Dtitle.AutoSize = true;
            this.lbl1Dtitle.Location = new System.Drawing.Point(8, 439);
            this.lbl1Dtitle.Name = "lbl1Dtitle";
            this.lbl1Dtitle.Size = new System.Drawing.Size(53, 15);
            this.lbl1Dtitle.TabIndex = 23;
            this.lbl1Dtitle.Text = "Repeats";
            this.lbl1Dtitle.Visible = false;
            // 
            // btn1Dgrid
            // 
            this.btn1Dgrid.Location = new System.Drawing.Point(149, 451);
            this.btn1Dgrid.Name = "btn1Dgrid";
            this.btn1Dgrid.Size = new System.Drawing.Size(78, 30);
            this.btn1Dgrid.TabIndex = 22;
            this.btn1Dgrid.Text = "1D Grid";
            this.btn1Dgrid.UseVisualStyleBackColor = true;
            this.btn1Dgrid.Visible = false;
            this.btn1Dgrid.Click += new System.EventHandler(this.btn1Dgrid_Click);
            // 
            // txt1Drepeats
            // 
            this.txt1Drepeats.Location = new System.Drawing.Point(69, 433);
            this.txt1Drepeats.Name = "txt1Drepeats";
            this.txt1Drepeats.Size = new System.Drawing.Size(54, 21);
            this.txt1Drepeats.TabIndex = 21;
            this.txt1Drepeats.Visible = false;
            // 
            // btnmcw
            // 
            this.btnmcw.Enabled = false;
            this.btnmcw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmcw.Location = new System.Drawing.Point(98, 349);
            this.btnmcw.Margin = new System.Windows.Forms.Padding(4);
            this.btnmcw.Name = "btnmcw";
            this.btnmcw.Size = new System.Drawing.Size(48, 55);
            this.btnmcw.TabIndex = 20;
            this.btnmcw.Text = "Right";
            this.btnmcw.UseVisualStyleBackColor = true;
            this.btnmcw.Click += new System.EventHandler(this.btnmcw_Click);
            // 
            // btnmxfw
            // 
            this.btnmxfw.Enabled = false;
            this.btnmxfw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmxfw.Location = new System.Drawing.Point(36, 287);
            this.btnmxfw.Margin = new System.Windows.Forms.Padding(4);
            this.btnmxfw.Name = "btnmxfw";
            this.btnmxfw.Size = new System.Drawing.Size(52, 54);
            this.btnmxfw.TabIndex = 19;
            this.btnmxfw.Text = "Fwd";
            this.btnmxfw.UseVisualStyleBackColor = true;
            this.btnmxfw.Click += new System.EventHandler(this.btnmxfw_Click);
            // 
            // btnmccw
            // 
            this.btnmccw.Enabled = false;
            this.btnmccw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmccw.Location = new System.Drawing.Point(36, 349);
            this.btnmccw.Margin = new System.Windows.Forms.Padding(4);
            this.btnmccw.Name = "btnmccw";
            this.btnmccw.Size = new System.Drawing.Size(52, 55);
            this.btnmccw.TabIndex = 17;
            this.btnmccw.Text = "Left";
            this.btnmccw.UseVisualStyleBackColor = true;
            this.btnmccw.Click += new System.EventHandler(this.btnmccw_Click);
            // 
            // btnmcrev
            // 
            this.btnmcrev.Enabled = false;
            this.btnmcrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmcrev.Location = new System.Drawing.Point(98, 287);
            this.btnmcrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnmcrev.Name = "btnmcrev";
            this.btnmcrev.Size = new System.Drawing.Size(48, 54);
            this.btnmcrev.TabIndex = 16;
            this.btnmcrev.Text = "Rev";
            this.btnmcrev.UseVisualStyleBackColor = true;
            this.btnmcrev.Click += new System.EventHandler(this.btnmcrev_Click);
            // 
            // ccwscroll
            // 
            this.ccwscroll.Location = new System.Drawing.Point(25, 230);
            this.ccwscroll.Maximum = 150;
            this.ccwscroll.Name = "ccwscroll";
            this.ccwscroll.Size = new System.Drawing.Size(98, 18);
            this.ccwscroll.TabIndex = 15;
            this.ccwscroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ccwscroll_Scroll);
            // 
            // cwscroll
            // 
            this.cwscroll.Location = new System.Drawing.Point(27, 174);
            this.cwscroll.Maximum = 150;
            this.cwscroll.Name = "cwscroll";
            this.cwscroll.Size = new System.Drawing.Size(99, 18);
            this.cwscroll.TabIndex = 14;
            this.cwscroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cwscroll_Scroll);
            // 
            // btnstopnow
            // 
            this.btnstopnow.Enabled = false;
            this.btnstopnow.ForeColor = System.Drawing.Color.Red;
            this.btnstopnow.Location = new System.Drawing.Point(157, 287);
            this.btnstopnow.Margin = new System.Windows.Forms.Padding(4);
            this.btnstopnow.Name = "btnstopnow";
            this.btnstopnow.Size = new System.Drawing.Size(54, 117);
            this.btnstopnow.TabIndex = 4;
            this.btnstopnow.Text = "Stop";
            this.btnstopnow.UseVisualStyleBackColor = true;
            this.btnstopnow.Click += new System.EventHandler(this.btnstopnow_Click);
            // 
            // xrscroll
            // 
            this.xrscroll.Location = new System.Drawing.Point(24, 111);
            this.xrscroll.Maximum = 150;
            this.xrscroll.Name = "xrscroll";
            this.xrscroll.Size = new System.Drawing.Size(102, 18);
            this.xrscroll.TabIndex = 13;
            this.xrscroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.xrscroll_Scroll);
            // 
            // xfscroll
            // 
            this.xfscroll.Location = new System.Drawing.Point(25, 61);
            this.xfscroll.Maximum = 150;
            this.xfscroll.Name = "xfscroll";
            this.xfscroll.Size = new System.Drawing.Size(102, 18);
            this.xfscroll.TabIndex = 12;
            this.xfscroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.xfscroll_Scroll);
            // 
            // btnthitaccw
            // 
            this.btnthitaccw.Enabled = false;
            this.btnthitaccw.Location = new System.Drawing.Point(153, 202);
            this.btnthitaccw.Margin = new System.Windows.Forms.Padding(4);
            this.btnthitaccw.Name = "btnthitaccw";
            this.btnthitaccw.Size = new System.Drawing.Size(78, 29);
            this.btnthitaccw.TabIndex = 11;
            this.btnthitaccw.Text = "Θ CCW";
            this.btnthitaccw.UseVisualStyleBackColor = true;
            this.btnthitaccw.Click += new System.EventHandler(this.btnthitaccw_Click);
            // 
            // btnthitacw
            // 
            this.btnthitacw.Enabled = false;
            this.btnthitacw.Location = new System.Drawing.Point(153, 150);
            this.btnthitacw.Margin = new System.Windows.Forms.Padding(4);
            this.btnthitacw.Name = "btnthitacw";
            this.btnthitacw.Size = new System.Drawing.Size(78, 29);
            this.btnthitacw.TabIndex = 10;
            this.btnthitacw.Text = "Θ CW";
            this.btnthitacw.UseVisualStyleBackColor = true;
            this.btnthitacw.Click += new System.EventHandler(this.btnthitacw_Click);
            // 
            // btnxrev
            // 
            this.btnxrev.Enabled = false;
            this.btnxrev.Location = new System.Drawing.Point(151, 86);
            this.btnxrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnxrev.Name = "btnxrev";
            this.btnxrev.Size = new System.Drawing.Size(78, 29);
            this.btnxrev.TabIndex = 9;
            this.btnxrev.Text = "X Reverse";
            this.btnxrev.UseVisualStyleBackColor = true;
            this.btnxrev.Click += new System.EventHandler(this.btnxrev_Click);
            // 
            // btnxfw
            // 
            this.btnxfw.Enabled = false;
            this.btnxfw.Location = new System.Drawing.Point(151, 34);
            this.btnxfw.Margin = new System.Windows.Forms.Padding(4);
            this.btnxfw.Name = "btnxfw";
            this.btnxfw.Size = new System.Drawing.Size(78, 29);
            this.btnxfw.TabIndex = 8;
            this.btnxfw.Text = "X Forward";
            this.btnxfw.UseVisualStyleBackColor = true;
            this.btnxfw.Click += new System.EventHandler(this.btnxfw_Click);
            // 
            // txtthitaccw
            // 
            this.txtthitaccw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtthitaccw.Location = new System.Drawing.Point(24, 204);
            this.txtthitaccw.Margin = new System.Windows.Forms.Padding(4);
            this.txtthitaccw.Name = "txtthitaccw";
            this.txtthitaccw.Size = new System.Drawing.Size(102, 22);
            this.txtthitaccw.TabIndex = 3;
            this.txtthitaccw.Text = "0";
            this.txtthitaccw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtthitacw
            // 
            this.txtthitacw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtthitacw.Location = new System.Drawing.Point(24, 150);
            this.txtthitacw.Margin = new System.Windows.Forms.Padding(4);
            this.txtthitacw.Name = "txtthitacw";
            this.txtthitacw.Size = new System.Drawing.Size(101, 22);
            this.txtthitacw.TabIndex = 2;
            this.txtthitacw.Text = "0";
            this.txtthitacw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtxrev
            // 
            this.txtxrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtxrev.Location = new System.Drawing.Point(24, 86);
            this.txtxrev.Margin = new System.Windows.Forms.Padding(4);
            this.txtxrev.Name = "txtxrev";
            this.txtxrev.Size = new System.Drawing.Size(102, 22);
            this.txtxrev.TabIndex = 1;
            this.txtxrev.Text = "0";
            this.txtxrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtxfw
            // 
            this.txtxfw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtxfw.Location = new System.Drawing.Point(24, 36);
            this.txtxfw.Margin = new System.Windows.Forms.Padding(4);
            this.txtxfw.Name = "txtxfw";
            this.txtxfw.Size = new System.Drawing.Size(103, 22);
            this.txtxfw.TabIndex = 0;
            this.txtxfw.Text = "0";
            this.txtxfw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxcommandhistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1584, 586);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Command History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxcommandhistory
            // 
            this.groupBoxcommandhistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxcommandhistory.Controls.Add(this.lstcommandhistory);
            this.groupBoxcommandhistory.Location = new System.Drawing.Point(4, 9);
            this.groupBoxcommandhistory.Name = "groupBoxcommandhistory";
            this.groupBoxcommandhistory.Size = new System.Drawing.Size(1267, 479);
            this.groupBoxcommandhistory.TabIndex = 32;
            this.groupBoxcommandhistory.TabStop = false;
            this.groupBoxcommandhistory.Text = "Command History";
            // 
            // lstcommandhistory
            // 
            this.lstcommandhistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstcommandhistory.FormattingEnabled = true;
            this.lstcommandhistory.ItemHeight = 15;
            this.lstcommandhistory.Location = new System.Drawing.Point(10, 27);
            this.lstcommandhistory.Name = "lstcommandhistory";
            this.lstcommandhistory.Size = new System.Drawing.Size(1239, 439);
            this.lstcommandhistory.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timercw
            // 
            this.timercw.Interval = 1000;
            this.timercw.Tick += new System.EventHandler(this.timercw_Tick);
            // 
            // timer1Drobot
            // 
            this.timer1Drobot.Interval = 1000;
            this.timer1Drobot.Tick += new System.EventHandler(this.timer1Drobot_Tick);
            // 
            // timerPWrepeats
            // 
            this.timerPWrepeats.Interval = 1000;
            this.timerPWrepeats.Tick += new System.EventHandler(this.timerPWrepeats_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 689);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MRgFUS - Software Platform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbrfg_1000.ResumeLayout(false);
            this.gbrfg_1000.PerformLayout();
            this.gbagilentgenerator.ResumeLayout(false);
            this.gbagilentgenerator.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbcurrentposition.ResumeLayout(false);
            this.gbcurrentposition.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.xthitapanel.ResumeLayout(false);
            this.xthitapanel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxcommandhistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDAQDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCommandHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCommandHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCommandHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openCommandHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbdeviceid;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbldaqstatus;
        private System.Windows.Forms.Button btnniconnect;
        private System.Windows.Forms.Timer timergeneratorP;
        private System.Windows.Forms.Timer timergeneratorC;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbcurrentposition;
        private System.Windows.Forms.TextBox txtthitaposition;
        private System.Windows.Forms.TextBox txtxposition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnxthitaposition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttimefornextsonication;
        private System.Windows.Forms.ComboBox cmbselectsignal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnstartgrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnthitastep;
        private System.Windows.Forms.TextBox txtnthitagrid;
        private System.Windows.Forms.TextBox txtnxstep;
        private System.Windows.Forms.TextBox txtnxgrid;
        private System.Windows.Forms.GroupBox xthitapanel;
        private System.Windows.Forms.Button btnmxfw;
        private System.Windows.Forms.Button btnmccw;
        private System.Windows.Forms.Button btnmcrev;
        private System.Windows.Forms.HScrollBar ccwscroll;
        private System.Windows.Forms.HScrollBar cwscroll;
        private System.Windows.Forms.Button btnstopnow;
        private System.Windows.Forms.HScrollBar xrscroll;
        private System.Windows.Forms.HScrollBar xfscroll;
        private System.Windows.Forms.Button btnthitaccw;
        private System.Windows.Forms.Button btnthitacw;
        private System.Windows.Forms.Button btnxrev;
        private System.Windows.Forms.Button btnxfw;
        private System.Windows.Forms.TextBox txtthitaccw;
        private System.Windows.Forms.TextBox txtthitacw;
        private System.Windows.Forms.TextBox txtxrev;
        private System.Windows.Forms.TextBox txtxfw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.Button btnyreverse_3d;
        private System.Windows.Forms.Button btnyforward_3d;
        private System.Windows.Forms.Button btnxreverse_3d;
        private System.Windows.Forms.Button btnxforward_3d;
        private System.Windows.Forms.TextBox txtyReverse_3d;
        private System.Windows.Forms.TextBox txtyForward_3d;
        private System.Windows.Forms.TextBox txtxReverse_3d;
        private System.Windows.Forms.TextBox txtxforward_3d;
        private System.Windows.Forms.HScrollBar hScrollBar5;
        private System.Windows.Forms.HScrollBar hScrollBar6;
        private System.Windows.Forms.Button btnzreverse_3d;
        private System.Windows.Forms.Button btnzforward_3d;
        private System.Windows.Forms.TextBox txtzReverse_3d;
        private System.Windows.Forms.TextBox txtzForward_3d;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtXYZwaitingtime;
        private System.Windows.Forms.ComboBox cmbXYZselectsignal;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btnstart3dgrid;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txt3dgrid_ysteps_mm;
        private System.Windows.Forms.TextBox txt3dgrid_ysteps;
        private System.Windows.Forms.TextBox txt3dgrid_xsteps_mm;
        private System.Windows.Forms.TextBox txt3dgrid_xsteps;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtzposition_3d;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtyposition_3d;
        private System.Windows.Forms.TextBox txtxposition_3d;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button btnXYZzerocurentposition;
        private System.Windows.Forms.ToolStripMenuItem mRICameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signalGeneratorTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agilentGeneratorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rFG1000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsDataFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dICOMImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dICOMFileTransferToolStripMenuItem;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbrobotsection;
        private System.Windows.Forms.Timer timercw;
        private System.Windows.Forms.Button btnmcw;
        private System.Windows.Forms.Label lbl1Dtitle;
        private System.Windows.Forms.Button btn1Dgrid;
        private System.Windows.Forms.TextBox txt1Drepeats;
        private System.Windows.Forms.Timer timer1Drobot;
        private System.Windows.Forms.TextBox txt1Dseconds;
        private System.Windows.Forms.Label lbl1Dtitle1;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt3dgrid_zsteps_mm;
        private System.Windows.Forms.TextBox txt3dgridzsteps;
        private System.Windows.Forms.Panel gridpattern;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Panel gridpattern2D;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxcommandhistory;
        private System.Windows.Forms.ListBox lstcommandhistory;
        private System.Windows.Forms.TextBox txttransducerspecs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbselecttransducer;
        private System.Windows.Forms.GroupBox gbagilentgenerator;
        private System.Windows.Forms.TextBox txtfrequencypulsed;
        private System.Windows.Forms.TextBox txtvoltagepulsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtagilentvisaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconnectionstatus;
        private System.Windows.Forms.Button btnconnecttoagilent;
        private System.Windows.Forms.Button btnpoweroffpulsed;
        private System.Windows.Forms.Button btnpoweronpulsed;
        private System.Windows.Forms.Button btnpoweroffcont;
        private System.Windows.Forms.Button btnpoweroncont;
        private System.Windows.Forms.TextBox txtontimepulsed;
        private System.Windows.Forms.TextBox txtpulserepfreq;
        private System.Windows.Forms.TextBox txtdutyfactor;
        private System.Windows.Forms.TextBox txtontimecontinious;
        private System.Windows.Forms.TextBox txtfrequency;
        private System.Windows.Forms.TextBox txtvoltage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnfolderselection;
        private System.Windows.Forms.GroupBox gbrfg_1000;
        private System.Windows.Forms.Label lblinstructionRF;
        private System.Windows.Forms.Label lbltitleinstuctionsRF;
        private System.Windows.Forms.TextBox txtfrequencyRFGFrequency;
        private System.Windows.Forms.TextBox txtvoltageRFGPulsed;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtpwtineonRFG;
        private System.Windows.Forms.TextBox txtcwtimeonRFG;
        private System.Windows.Forms.TextBox txtdutyfactorRFG;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtreaddatainput;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtfrequencyRFG;
        private System.Windows.Forms.TextBox txtpulserepfreqRFG;
        private System.Windows.Forms.Label lblconnectionstatusRFG;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtvoltageRFG;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cmbportname;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btnmode;
        private System.Windows.Forms.Button btnponcw;
        private System.Windows.Forms.Button btnonpw;
        private System.Windows.Forms.Button btnoffpw;
        private System.Windows.Forms.Button btnoffcw;
        private System.Windows.Forms.Label lblsonicationtime;
        private System.Windows.Forms.ProgressBar sonicationprogress;
        private System.Windows.Forms.ToolStripMenuItem rF05to34MHzToolStripMenuItem;
        private System.Windows.Forms.Button btreviewsettings;
        private System.Windows.Forms.TextBox txtrepeatsforcw;
        private System.Windows.Forms.TextBox txttimedelayforcw;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lbltotaltimeofsonication;
        private System.Windows.Forms.ToolStripMenuItem rFG100GeneratorToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScrollBar7;
        private System.Windows.Forms.HScrollBar hScrollBar8;
        private System.Windows.Forms.Button btnthitaccw4d;
        private System.Windows.Forms.Button btnthitacw4d;
        private System.Windows.Forms.TextBox txtthitaccw4d;
        private System.Windows.Forms.TextBox txtthitacw4d;
        private System.Windows.Forms.RadioButton rBgetgrid;
        private System.Windows.Forms.RadioButton rBsetgrid;
        private System.Windows.Forms.ToolStripMenuItem clearPresetGridOperationToolStripMenuItem;
        private System.Windows.Forms.Button btnstartgridXYImmersed;
        private System.Windows.Forms.TextBox txtthitaposition_4D;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ToolStripMenuItem osilloscopeToolStripMenuItem;
        private System.Windows.Forms.Label lblvisualZ;
        private System.Windows.Forms.Label lblvisualY;
        private System.Windows.Forms.Label lblvisualX;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lblcurrentsonication;
        private System.Windows.Forms.Label lbltotalnumberofsonications;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox txtrepeatspwRFG;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Timer timerPWrepeats;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtvolume;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtvacuumOntime;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button btnstopvacuum;
        private System.Windows.Forms.Button btnstartvacuum;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ProgressBar pbvacuum;
        private System.Windows.Forms.Label lblvacuumresult;
        private System.Windows.Forms.HScrollBar hScrollBar10;
        private System.Windows.Forms.HScrollBar hScrollBar9;
        private System.Windows.Forms.TextBox txtvacuumrate;
        private System.Windows.Forms.Label label62;
    }
}

