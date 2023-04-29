namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using ThoughtWorks.QRCode.Codec;

    [DesignerGenerated]
    public class L : Form
    {
        private IContainer A;
        [AccessedThroughProperty("Button2Q"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("MName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("CheckSectionBarCodeStorName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonHelp")]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTW")]
        private TextBox A;
        [AccessedThroughProperty("Label2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTH")]
        private TextBox R;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("Label5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("TxTCRTop"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCRLef")]
        private TextBox Q;
        [AccessedThroughProperty("Label6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [AccessedThroughProperty("Label7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label F;
        [CompilerGenerated, AccessedThroughProperty("Label8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label H;
        [CompilerGenerated, AccessedThroughProperty("TxTCRBot"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCRRit")]
        private TextBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("BCStoreName"), CompilerGenerated]
        private TextBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Panel1")]
        private Panel A;
        [AccessedThroughProperty("GroupBox18"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("CheckSectionBarCodeNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("BCNote")]
        private TextBox H;
        [CompilerGenerated, AccessedThroughProperty("GroupBox16"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckSectionBarCodeDExpier"), CompilerGenerated]
        private CheckBox P;
        [AccessedThroughProperty("BCDateExpire"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox10")]
        private GroupBox D;
        [AccessedThroughProperty("CheckSectionBarCodePrice"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("BCPrice")]
        private TextBox X;
        [CompilerGenerated, AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckSectionBarCodeName")]
        private CheckBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("BCName"), CompilerGenerated]
        private TextBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox4")]
        private GroupBox H;
        [AccessedThroughProperty("CheckSectionBarCodeNumber"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox D;
        [AccessedThroughProperty("BCBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox E;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1")]
        private TabPage A;
        [AccessedThroughProperty("LabelNote128"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label T;
        [AccessedThroughProperty("PictureBox128"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox A;
        [AccessedThroughProperty("ButtonPrint128"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2")]
        private TabPage R;
        [AccessedThroughProperty("ButtonPrintQR"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBoxQR")]
        private PictureBox R;
        [CompilerGenerated, AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox17")]
        private GroupBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ComboBoxFontSize")]
        private ComboBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonPrint39")]
        private Button I;
        [AccessedThroughProperty("LabelBarCode39"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label X;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage4")]
        private TabPage Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox12")]
        private GroupBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("MDisMiWi")]
        private TextBox K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox8")]
        private GroupBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MSale")]
        private TextBox U;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox E;
        [CompilerGenerated, AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [CompilerGenerated, AccessedThroughProperty("MDisVal"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox L;
        [AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox U;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MDarMiWi")]
        private TextBox N;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2"), CompilerGenerated]
        private GroupBox L;
        [AccessedThroughProperty("GroupBox15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox N;
        [AccessedThroughProperty("MDarVal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox11")]
        private GroupBox V;
        [AccessedThroughProperty("MSTotal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Y;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1"), CompilerGenerated]
        private GroupBox Y;
        [CompilerGenerated, AccessedThroughProperty("LabelNote39"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MBarCode")]
        private TextBox O;
        [AccessedThroughProperty("cboCorrectionLevel"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox B;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("cboVersion")]
        private TextBox S;
        [CompilerGenerated, AccessedThroughProperty("txtSize"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Z;
        [AccessedThroughProperty("cboEncoding"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage5")]
        private TabPage I;
        [CompilerGenerated, AccessedThroughProperty("LBErrorEAN13"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label E;
        [AccessedThroughProperty("PictureBoxEAN13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox P;
        [CompilerGenerated, AccessedThroughProperty("ButtonPrintEAN13"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button D;
        [AccessedThroughProperty("Label9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label K;
        [AccessedThroughProperty("GroupBox19"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox O;
        [AccessedThroughProperty("CheckSectionBarCodeImage"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox F;
        [CompilerGenerated, AccessedThroughProperty("TabPage6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBarCodePrint"), CompilerGenerated]
        private CheckBox H;
        [AccessedThroughProperty("GroupBox20"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox B;
        [CompilerGenerated, AccessedThroughProperty("BarCodePrinterList"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox P;
        private SqlConnection A;
        private string A;
        private string R;
        private string P;
        private ArrayList A;

        public L()
        {
            base.Load += new EventHandler(this.A);
            base.FormClosed += new FormClosedEventHandler(this.A);
            base.Closed += new EventHandler(this.V);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = Application.StartupPath + @"\TmpCode128.bmp";
            this.R = Application.StartupPath + @"\TmpCodeQR.bmp";
            this.P = Application.StartupPath + @"\TmpEAN13.bmp";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.Button2Q = new Button();
            this.MName = new ComboBox();
            this.TimersStartUp = new Timer(this.A);
            this.GroupBox5 = new GroupBox();
            this.CheckSectionBarCodeStorName = new CheckBox();
            this.BCStoreName = new TextBox();
            this.GroupBox7 = new GroupBox();
            this.ButtonHelp = new Button();
            this.Label1 = new Label();
            this.TxTW = new TextBox();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.TxTH = new TextBox();
            this.GroupBox9 = new GroupBox();
            this.Label5 = new Label();
            this.TxTCRTop = new TextBox();
            this.TxTCRLef = new TextBox();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.Label8 = new Label();
            this.TxTCRBot = new TextBox();
            this.TxTCRRit = new TextBox();
            this.Panel1 = new Panel();
            this.GroupBox18 = new GroupBox();
            this.CheckSectionBarCodeNote = new CheckBox();
            this.BCNote = new TextBox();
            this.GroupBox16 = new GroupBox();
            this.CheckSectionBarCodeDExpier = new CheckBox();
            this.BCDateExpire = new TextBox();
            this.GroupBox10 = new GroupBox();
            this.CheckSectionBarCodePrice = new CheckBox();
            this.BCPrice = new TextBox();
            this.GroupBox6 = new GroupBox();
            this.CheckSectionBarCodeName = new CheckBox();
            this.BCName = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.CheckSectionBarCodeNumber = new CheckBox();
            this.BCBarCode = new TextBox();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.LabelNote128 = new Label();
            this.PictureBox128 = new PictureBox();
            this.ButtonPrint128 = new Button();
            this.TabPage2 = new TabPage();
            this.ButtonPrintQR = new Button();
            this.PictureBoxQR = new PictureBox();
            this.TabPage3 = new TabPage();
            this.LabelNote39 = new Label();
            this.GroupBox17 = new GroupBox();
            this.ComboBoxFontSize = new ComboBox();
            this.ButtonPrint39 = new Button();
            this.LabelBarCode39 = new Label();
            this.TabPage5 = new TabPage();
            this.Label9 = new Label();
            this.LBErrorEAN13 = new Label();
            this.PictureBoxEAN13 = new PictureBox();
            this.ButtonPrintEAN13 = new Button();
            this.TabPage4 = new TabPage();
            this.TabPage6 = new TabPage();
            this.CheckBarCodePrint = new CheckBox();
            this.GroupBox20 = new GroupBox();
            this.BarCodePrinterList = new ComboBox();
            this.GroupBox12 = new GroupBox();
            this.MDisMiWi = new TextBox();
            this.GroupBox8 = new GroupBox();
            this.MSale = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.MBarCode = new TextBox();
            this.GroupBox14 = new GroupBox();
            this.MDisVal = new TextBox();
            this.GroupBox13 = new GroupBox();
            this.MDarMiWi = new TextBox();
            this.GroupBox2 = new GroupBox();
            this.GroupBox15 = new GroupBox();
            this.MDarVal = new TextBox();
            this.GroupBox11 = new GroupBox();
            this.MSTotal = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.cboCorrectionLevel = new TextBox();
            this.cboVersion = new TextBox();
            this.txtSize = new TextBox();
            this.cboEncoding = new TextBox();
            this.GroupBox19 = new GroupBox();
            this.CheckSectionBarCodeImage = new CheckBox();
            this.GroupBox5.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((ISupportInitialize) this.PictureBox128).BeginInit();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.PictureBoxQR).BeginInit();
            this.TabPage3.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.TabPage5.SuspendLayout();
            ((ISupportInitialize) this.PictureBoxEAN13).BeginInit();
            this.TabPage4.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox20.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            base.SuspendLayout();
            this.Button2Q.FlatAppearance.BorderColor = Color.Green;
            this.Button2Q.FlatAppearance.CheckedBackColor = Color.White;
            this.Button2Q.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Button2Q.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.Button2Q.FlatStyle = FlatStyle.Flat;
            this.Button2Q.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Button2Q.Image = A.F.ImView;
            this.Button2Q.Location = new Point(6, 15);
            this.Button2Q.Margin = new Padding(3, 4, 3, 4);
            this.Button2Q.Name = "Button2Q";
            this.Button2Q.Size = new Size(0x2d, 0x1f);
            this.Button2Q.TabIndex = 0x1ed36d0;
            this.Button2Q.UseVisualStyleBackColor = true;
            this.MName.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.MName.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.MName.BackColor = SystemColors.Info;
            this.MName.Dock = DockStyle.Right;
            this.MName.FormattingEnabled = true;
            this.MName.IntegralHeight = false;
            this.MName.Location = new Point(0x39, 0x13);
            this.MName.Name = "MName";
            this.MName.Size = new Size(0x179, 0x18);
            this.MName.TabIndex = 1;
            this.GroupBox5.Controls.Add(this.CheckSectionBarCodeStorName);
            this.GroupBox5.Controls.Add(this.BCStoreName);
            this.GroupBox5.Dock = DockStyle.Top;
            this.GroupBox5.FlatStyle = FlatStyle.Popup;
            this.GroupBox5.Location = new Point(0, 0xe1);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x29f, 0x2d);
            this.GroupBox5.TabIndex = 0x71;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "اسم المتجر";
            this.CheckSectionBarCodeStorName.Dock = DockStyle.Left;
            this.CheckSectionBarCodeStorName.Location = new Point(3, 0x13);
            this.CheckSectionBarCodeStorName.Name = "CheckSectionBarCodeStorName";
            this.CheckSectionBarCodeStorName.Size = new Size(0x8f, 0x17);
            this.CheckSectionBarCodeStorName.TabIndex = 1;
            this.CheckSectionBarCodeStorName.Text = "اخفاء";
            this.CheckSectionBarCodeStorName.UseVisualStyleBackColor = true;
            this.BCStoreName.BackColor = SystemColors.Info;
            this.BCStoreName.Dock = DockStyle.Right;
            this.BCStoreName.Location = new Point(0xae, 0x13);
            this.BCStoreName.Name = "BCStoreName";
            this.BCStoreName.RightToLeft = RightToLeft.No;
            this.BCStoreName.Size = new Size(0x1ee, 0x17);
            this.BCStoreName.TabIndex = 0;
            this.BCStoreName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox7.Controls.Add(this.ButtonHelp);
            this.GroupBox7.Controls.Add(this.Label1);
            this.GroupBox7.Controls.Add(this.TxTW);
            this.GroupBox7.Controls.Add(this.Label2);
            this.GroupBox7.Controls.Add(this.Label3);
            this.GroupBox7.Controls.Add(this.Label4);
            this.GroupBox7.Controls.Add(this.TxTH);
            this.GroupBox7.Location = new Point(0x12, 0x27);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0xfd, 0x54);
            this.GroupBox7.TabIndex = 0x1ed36e3;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "قياس الملصق";
            this.ButtonHelp.FlatStyle = FlatStyle.Flat;
            this.ButtonHelp.Image = A.F.ImAbout;
            this.ButtonHelp.ImageAlign = ContentAlignment.TopCenter;
            this.ButtonHelp.Location = new Point(6, 11);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new Size(0x60, 0x40);
            this.ButtonHelp.TabIndex = 15;
            this.ButtonHelp.Text = "شاهد الفيديو";
            this.ButtonHelp.TextAlign = ContentAlignment.BottomCenter;
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(200, 0x1b);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x2e, 0x10);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "العرض:";
            this.TxTW.Location = new Point(0x8f, 0x18);
            this.TxTW.Name = "TxTW";
            this.TxTW.RightToLeft = RightToLeft.No;
            this.TxTW.Size = new Size(0x33, 0x17);
            this.TxTW.TabIndex = 12;
            this.TxTW.Text = "5";
            this.TxTW.TextAlign = HorizontalAlignment.Center;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0x6c, 0x1b);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(30, 0x10);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "سم";
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(200, 0x38);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x2b, 0x10);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "الطول:";
            this.Label4.AutoSize = true;
            this.Label4.Location = new Point(0x6c, 0x38);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(30, 0x10);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "سم";
            this.TxTH.Location = new Point(0x90, 0x35);
            this.TxTH.Name = "TxTH";
            this.TxTH.RightToLeft = RightToLeft.No;
            this.TxTH.Size = new Size(50, 0x17);
            this.TxTH.TabIndex = 14;
            this.TxTH.Text = "4";
            this.TxTH.TextAlign = HorizontalAlignment.Center;
            this.GroupBox9.Controls.Add(this.Label5);
            this.GroupBox9.Controls.Add(this.TxTCRTop);
            this.GroupBox9.Controls.Add(this.TxTCRLef);
            this.GroupBox9.Controls.Add(this.Label6);
            this.GroupBox9.Controls.Add(this.Label7);
            this.GroupBox9.Controls.Add(this.Label8);
            this.GroupBox9.Controls.Add(this.TxTCRBot);
            this.GroupBox9.Controls.Add(this.TxTCRRit);
            this.GroupBox9.Location = new Point(0x183, 40);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xfd, 0x53);
            this.GroupBox9.TabIndex = 0x1ed36e2;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "المسافات والهوامش ";
            this.Label5.AutoSize = true;
            this.Label5.Location = new Point(200, 0x19);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x2a, 0x10);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "أعلى:";
            this.TxTCRTop.Location = new Point(0x85, 0x16);
            this.TxTCRTop.Name = "TxTCRTop";
            this.TxTCRTop.RightToLeft = RightToLeft.No;
            this.TxTCRTop.Size = new Size(0x3d, 0x17);
            this.TxTCRTop.TabIndex = 12;
            this.TxTCRTop.Text = "0";
            this.TxTCRTop.TextAlign = HorizontalAlignment.Center;
            this.TxTCRLef.Location = new Point(6, 0x34);
            this.TxTCRLef.Name = "TxTCRLef";
            this.TxTCRLef.RightToLeft = RightToLeft.No;
            this.TxTCRLef.Size = new Size(60, 0x17);
            this.TxTCRLef.TabIndex = 15;
            this.TxTCRLef.Text = "0";
            this.TxTCRLef.TextAlign = HorizontalAlignment.Center;
            this.Label6.AutoSize = true;
            this.Label6.Location = new Point(0x48, 0x19);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(0x2d, 0x10);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "أسفل:";
            this.Label7.AutoSize = true;
            this.Label7.Location = new Point(0xc7, 0x37);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0x26, 0x10);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "أيمن:";
            this.Label8.AutoSize = true;
            this.Label8.Location = new Point(0x48, 0x37);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x27, 0x10);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "أيسر:";
            this.TxTCRBot.Location = new Point(6, 0x16);
            this.TxTCRBot.Name = "TxTCRBot";
            this.TxTCRBot.RightToLeft = RightToLeft.No;
            this.TxTCRBot.Size = new Size(60, 0x17);
            this.TxTCRBot.TabIndex = 13;
            this.TxTCRBot.Text = "0";
            this.TxTCRBot.TextAlign = HorizontalAlignment.Center;
            this.TxTCRRit.Location = new Point(0x85, 0x34);
            this.TxTCRRit.Name = "TxTCRRit";
            this.TxTCRRit.RightToLeft = RightToLeft.No;
            this.TxTCRRit.Size = new Size(60, 0x17);
            this.TxTCRRit.TabIndex = 14;
            this.TxTCRRit.Text = "0";
            this.TxTCRRit.TextAlign = HorizontalAlignment.Center;
            this.Panel1.BorderStyle = BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.GroupBox5);
            this.Panel1.Controls.Add(this.GroupBox18);
            this.Panel1.Controls.Add(this.GroupBox16);
            this.Panel1.Controls.Add(this.GroupBox10);
            this.Panel1.Controls.Add(this.GroupBox6);
            this.Panel1.Controls.Add(this.GroupBox4);
            this.Panel1.Dock = DockStyle.Top;
            this.Panel1.Location = new Point(0, 0x94);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x2a1, 0x11a);
            this.Panel1.TabIndex = 0x1ed36e4;
            this.GroupBox18.Controls.Add(this.CheckSectionBarCodeNote);
            this.GroupBox18.Controls.Add(this.BCNote);
            this.GroupBox18.Dock = DockStyle.Top;
            this.GroupBox18.FlatStyle = FlatStyle.Popup;
            this.GroupBox18.Location = new Point(0, 180);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(0x29f, 0x2d);
            this.GroupBox18.TabIndex = 0x76;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "ملاحظات";
            this.CheckSectionBarCodeNote.Checked = true;
            this.CheckSectionBarCodeNote.CheckState = CheckState.Checked;
            this.CheckSectionBarCodeNote.Dock = DockStyle.Left;
            this.CheckSectionBarCodeNote.Location = new Point(3, 0x13);
            this.CheckSectionBarCodeNote.Name = "CheckSectionBarCodeNote";
            this.CheckSectionBarCodeNote.Size = new Size(0x8f, 0x17);
            this.CheckSectionBarCodeNote.TabIndex = 1;
            this.CheckSectionBarCodeNote.Text = "اخفاء";
            this.CheckSectionBarCodeNote.UseVisualStyleBackColor = true;
            this.BCNote.BackColor = SystemColors.Info;
            this.BCNote.Dock = DockStyle.Right;
            this.BCNote.Location = new Point(0xae, 0x13);
            this.BCNote.Name = "BCNote";
            this.BCNote.RightToLeft = RightToLeft.No;
            this.BCNote.Size = new Size(0x1ee, 0x17);
            this.BCNote.TabIndex = 0;
            this.BCNote.TextAlign = HorizontalAlignment.Center;
            this.GroupBox16.Controls.Add(this.CheckSectionBarCodeDExpier);
            this.GroupBox16.Controls.Add(this.BCDateExpire);
            this.GroupBox16.Dock = DockStyle.Top;
            this.GroupBox16.FlatStyle = FlatStyle.Popup;
            this.GroupBox16.Location = new Point(0, 0x87);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0x29f, 0x2d);
            this.GroupBox16.TabIndex = 0x75;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "تاريخ الانتهاء";
            this.CheckSectionBarCodeDExpier.Checked = true;
            this.CheckSectionBarCodeDExpier.CheckState = CheckState.Checked;
            this.CheckSectionBarCodeDExpier.Dock = DockStyle.Left;
            this.CheckSectionBarCodeDExpier.Location = new Point(3, 0x13);
            this.CheckSectionBarCodeDExpier.Name = "CheckSectionBarCodeDExpier";
            this.CheckSectionBarCodeDExpier.Size = new Size(0x8f, 0x17);
            this.CheckSectionBarCodeDExpier.TabIndex = 1;
            this.CheckSectionBarCodeDExpier.Text = "اخفاء";
            this.CheckSectionBarCodeDExpier.UseVisualStyleBackColor = true;
            this.BCDateExpire.BackColor = SystemColors.Info;
            this.BCDateExpire.Dock = DockStyle.Right;
            this.BCDateExpire.Location = new Point(0xae, 0x13);
            this.BCDateExpire.Name = "BCDateExpire";
            this.BCDateExpire.RightToLeft = RightToLeft.No;
            this.BCDateExpire.Size = new Size(0x1ee, 0x17);
            this.BCDateExpire.TabIndex = 0;
            this.BCDateExpire.TextAlign = HorizontalAlignment.Center;
            this.GroupBox10.Controls.Add(this.CheckSectionBarCodePrice);
            this.GroupBox10.Controls.Add(this.BCPrice);
            this.GroupBox10.Dock = DockStyle.Top;
            this.GroupBox10.FlatStyle = FlatStyle.Popup;
            this.GroupBox10.Location = new Point(0, 90);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x29f, 0x2d);
            this.GroupBox10.TabIndex = 0x74;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "السعر";
            this.CheckSectionBarCodePrice.Dock = DockStyle.Left;
            this.CheckSectionBarCodePrice.Location = new Point(3, 0x13);
            this.CheckSectionBarCodePrice.Name = "CheckSectionBarCodePrice";
            this.CheckSectionBarCodePrice.Size = new Size(0x8f, 0x17);
            this.CheckSectionBarCodePrice.TabIndex = 1;
            this.CheckSectionBarCodePrice.Text = "اخفاء";
            this.CheckSectionBarCodePrice.UseVisualStyleBackColor = true;
            this.BCPrice.BackColor = SystemColors.Info;
            this.BCPrice.Dock = DockStyle.Right;
            this.BCPrice.Location = new Point(0xae, 0x13);
            this.BCPrice.Name = "BCPrice";
            this.BCPrice.RightToLeft = RightToLeft.No;
            this.BCPrice.Size = new Size(0x1ee, 0x17);
            this.BCPrice.TabIndex = 0;
            this.BCPrice.TextAlign = HorizontalAlignment.Center;
            this.GroupBox6.Controls.Add(this.CheckSectionBarCodeName);
            this.GroupBox6.Controls.Add(this.BCName);
            this.GroupBox6.Dock = DockStyle.Top;
            this.GroupBox6.FlatStyle = FlatStyle.Popup;
            this.GroupBox6.Location = new Point(0, 0x2d);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x29f, 0x2d);
            this.GroupBox6.TabIndex = 0x73;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "اسم المادة";
            this.CheckSectionBarCodeName.Dock = DockStyle.Left;
            this.CheckSectionBarCodeName.Location = new Point(3, 0x13);
            this.CheckSectionBarCodeName.Name = "CheckSectionBarCodeName";
            this.CheckSectionBarCodeName.Size = new Size(0x8f, 0x17);
            this.CheckSectionBarCodeName.TabIndex = 1;
            this.CheckSectionBarCodeName.Text = "اخفاء";
            this.CheckSectionBarCodeName.UseVisualStyleBackColor = true;
            this.BCName.BackColor = SystemColors.Info;
            this.BCName.Dock = DockStyle.Right;
            this.BCName.Location = new Point(0xae, 0x13);
            this.BCName.Name = "BCName";
            this.BCName.RightToLeft = RightToLeft.No;
            this.BCName.Size = new Size(0x1ee, 0x17);
            this.BCName.TabIndex = 0;
            this.BCName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox4.Controls.Add(this.CheckSectionBarCodeNumber);
            this.GroupBox4.Controls.Add(this.BCBarCode);
            this.GroupBox4.Dock = DockStyle.Top;
            this.GroupBox4.FlatStyle = FlatStyle.Popup;
            this.GroupBox4.Location = new Point(0, 0);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x29f, 0x2d);
            this.GroupBox4.TabIndex = 0x72;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "رقم/ باركود المادة";
            this.CheckSectionBarCodeNumber.Dock = DockStyle.Left;
            this.CheckSectionBarCodeNumber.Location = new Point(3, 0x13);
            this.CheckSectionBarCodeNumber.Name = "CheckSectionBarCodeNumber";
            this.CheckSectionBarCodeNumber.Size = new Size(0x8f, 0x17);
            this.CheckSectionBarCodeNumber.TabIndex = 1;
            this.CheckSectionBarCodeNumber.Text = "اخفاء";
            this.CheckSectionBarCodeNumber.UseVisualStyleBackColor = true;
            this.BCBarCode.BackColor = SystemColors.Info;
            this.BCBarCode.Dock = DockStyle.Right;
            this.BCBarCode.Location = new Point(0xae, 0x13);
            this.BCBarCode.Name = "BCBarCode";
            this.BCBarCode.RightToLeft = RightToLeft.No;
            this.BCBarCode.Size = new Size(0x1ee, 0x17);
            this.BCBarCode.TabIndex = 0;
            this.BCBarCode.TextAlign = HorizontalAlignment.Center;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Dock = DockStyle.Bottom;
            this.TabControl1.Location = new Point(3, 0x30);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(8, 6);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x29b, 0xc5);
            this.TabControl1.TabIndex = 0x1ed36e5;
            this.TabPage1.Controls.Add(this.LabelNote128);
            this.TabPage1.Controls.Add(this.PictureBox128);
            this.TabPage1.Controls.Add(this.ButtonPrint128);
            this.TabPage1.Location = new Point(4, 0x1f);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x293, 0xa2);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تنسيق 128";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.LabelNote128.Dock = DockStyle.Bottom;
            this.LabelNote128.ForeColor = Color.DarkRed;
            this.LabelNote128.Location = new Point(3, 0x7a);
            this.LabelNote128.Name = "LabelNote128";
            this.LabelNote128.Size = new Size(0x28d, 0x25);
            this.LabelNote128.TabIndex = 0x1ed36df;
            this.LabelNote128.Text = "انت تستخدم ملصق صغير، حاول ان تحدد (مادة) لا يتجاوز رقم الباركود عن 6 الى 8 ارقام.";
            this.LabelNote128.TextAlign = ContentAlignment.MiddleCenter;
            this.PictureBox128.BackColor = Color.White;
            this.PictureBox128.BackgroundImageLayout = ImageLayout.Center;
            this.PictureBox128.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox128.Location = new Point(6, 0x12);
            this.PictureBox128.Margin = new Padding(3, 4, 3, 4);
            this.PictureBox128.Name = "PictureBox128";
            this.PictureBox128.Size = new Size(0x28d, 0x2d);
            this.PictureBox128.SizeMode = PictureBoxSizeMode.CenterImage;
            this.PictureBox128.TabIndex = 0x25;
            this.PictureBox128.TabStop = false;
            this.ButtonPrint128.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPrint128.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPrint128.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPrint128.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPrint128.FlatStyle = FlatStyle.Flat;
            this.ButtonPrint128.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPrint128.Image = A.F.ImView;
            this.ButtonPrint128.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPrint128.Location = new Point(6, 0x47);
            this.ButtonPrint128.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPrint128.Name = "ButtonPrint128";
            this.ButtonPrint128.Size = new Size(0x28d, 0x2f);
            this.ButtonPrint128.TabIndex = 0x1ed36da;
            this.ButtonPrint128.Text = "معاينة وطباعة";
            this.ButtonPrint128.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.ButtonPrintQR);
            this.TabPage2.Controls.Add(this.PictureBoxQR);
            this.TabPage2.Location = new Point(4, 0x1f);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x293, 0xa2);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "تنسيق QR";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonPrintQR.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPrintQR.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPrintQR.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPrintQR.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPrintQR.FlatStyle = FlatStyle.Flat;
            this.ButtonPrintQR.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPrintQR.Image = A.F.ImView;
            this.ButtonPrintQR.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPrintQR.Location = new Point(6, 0x47);
            this.ButtonPrintQR.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPrintQR.Name = "ButtonPrintQR";
            this.ButtonPrintQR.Size = new Size(0x28d, 0x2f);
            this.ButtonPrintQR.TabIndex = 0x1ed36db;
            this.ButtonPrintQR.Text = "معاينة وطباعة";
            this.ButtonPrintQR.UseVisualStyleBackColor = true;
            this.PictureBoxQR.BackColor = Color.White;
            this.PictureBoxQR.BackgroundImageLayout = ImageLayout.Center;
            this.PictureBoxQR.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBoxQR.Location = new Point(6, 0x12);
            this.PictureBoxQR.Margin = new Padding(3, 4, 3, 4);
            this.PictureBoxQR.Name = "PictureBoxQR";
            this.PictureBoxQR.Size = new Size(0x28d, 0x2d);
            this.PictureBoxQR.SizeMode = PictureBoxSizeMode.CenterImage;
            this.PictureBoxQR.TabIndex = 0x25;
            this.PictureBoxQR.TabStop = false;
            this.TabPage3.Controls.Add(this.LabelNote39);
            this.TabPage3.Controls.Add(this.GroupBox17);
            this.TabPage3.Controls.Add(this.ButtonPrint39);
            this.TabPage3.Controls.Add(this.LabelBarCode39);
            this.TabPage3.Location = new Point(4, 0x1f);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new Padding(3);
            this.TabPage3.Size = new Size(0x293, 0xa2);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "تنسيق 39";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.LabelNote39.Dock = DockStyle.Bottom;
            this.LabelNote39.ForeColor = Color.DarkRed;
            this.LabelNote39.Location = new Point(3, 0x7a);
            this.LabelNote39.Name = "LabelNote39";
            this.LabelNote39.Size = new Size(0x28d, 0x25);
            this.LabelNote39.TabIndex = 0x1ed36de;
            this.LabelNote39.Text = "انت تستخدم ملصق صغير، حاول ان تحدد حجم خط صغير او ان لا يتجاوز رقم باركود المادة عن 6 ارقام.";
            this.LabelNote39.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox17.Controls.Add(this.ComboBoxFontSize);
            this.GroupBox17.Location = new Point(0x194, 0x47);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0xff, 0x30);
            this.GroupBox17.TabIndex = 0x1ed36dd;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "حجم خط الباركود";
            this.ComboBoxFontSize.Dock = DockStyle.Fill;
            this.ComboBoxFontSize.FormattingEnabled = true;
            object[] items = new object[0x1d];
            items[0] = "12";
            items[1] = "13";
            items[2] = "14";
            items[3] = "15";
            items[4] = "16";
            items[5] = "17";
            items[6] = "18";
            items[7] = "19";
            items[8] = "20";
            items[9] = "21";
            items[10] = "22";
            items[11] = "23";
            items[12] = "24";
            items[13] = "25";
            items[14] = "26";
            items[15] = "27";
            items[0x10] = "28";
            items[0x11] = "29";
            items[0x12] = "30";
            items[0x13] = "31";
            items[20] = "32";
            items[0x15] = "33";
            items[0x16] = "34";
            items[0x17] = "35";
            items[0x18] = "36";
            items[0x19] = "37";
            items[0x1a] = "38";
            items[0x1b] = "39";
            items[0x1c] = "40";
            this.ComboBoxFontSize.Items.AddRange(items);
            this.ComboBoxFontSize.Location = new Point(3, 0x13);
            this.ComboBoxFontSize.Name = "ComboBoxFontSize";
            this.ComboBoxFontSize.Size = new Size(0xf9, 0x18);
            this.ComboBoxFontSize.TabIndex = 0x1ed36cc;
            this.ComboBoxFontSize.Text = "15";
            this.ButtonPrint39.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPrint39.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPrint39.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPrint39.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPrint39.FlatStyle = FlatStyle.Flat;
            this.ButtonPrint39.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPrint39.Image = A.F.ImView;
            this.ButtonPrint39.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPrint39.Location = new Point(11, 0x51);
            this.ButtonPrint39.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPrint39.Name = "ButtonPrint39";
            this.ButtonPrint39.Size = new Size(0x183, 0x25);
            this.ButtonPrint39.TabIndex = 0x1ed36dc;
            this.ButtonPrint39.Text = "معاينة وطباعة";
            this.ButtonPrint39.UseVisualStyleBackColor = true;
            this.LabelBarCode39.BorderStyle = BorderStyle.FixedSingle;
            this.LabelBarCode39.Font = new Font("Bar-Code 39", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 2);
            this.LabelBarCode39.Location = new Point(11, 15);
            this.LabelBarCode39.Name = "LabelBarCode39";
            this.LabelBarCode39.Size = new Size(0x288, 0x2d);
            this.LabelBarCode39.TabIndex = 0;
            this.LabelBarCode39.Text = "123";
            this.LabelBarCode39.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage5.Controls.Add(this.Label9);
            this.TabPage5.Controls.Add(this.LBErrorEAN13);
            this.TabPage5.Controls.Add(this.PictureBoxEAN13);
            this.TabPage5.Controls.Add(this.ButtonPrintEAN13);
            this.TabPage5.Location = new Point(4, 0x1f);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new Size(0x293, 0xa2);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "تنسيق EAN13";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.Label9.Dock = DockStyle.Bottom;
            this.Label9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = Color.Red;
            this.Label9.Location = new Point(0, 0x66);
            this.Label9.Name = "Label9";
            this.Label9.Size = new Size(0x293, 0x21);
            this.Label9.TabIndex = 0x1ed36e3;
            this.Label9.Text = "لا تستخدم هذا التنسيق مع الارقام العشوائية، فهو خاص للمنتجات التي لها كود من المصنع";
            this.Label9.TextAlign = ContentAlignment.MiddleCenter;
            this.LBErrorEAN13.Dock = DockStyle.Bottom;
            this.LBErrorEAN13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LBErrorEAN13.ForeColor = Color.Red;
            this.LBErrorEAN13.Location = new Point(0, 0x87);
            this.LBErrorEAN13.Name = "LBErrorEAN13";
            this.LBErrorEAN13.Size = new Size(0x293, 0x1b);
            this.LBErrorEAN13.TabIndex = 0x1ed36e2;
            this.LBErrorEAN13.Text = "يجب ان يكون كود المادة رقم وان لا يقل عن 13 خانة";
            this.LBErrorEAN13.TextAlign = ContentAlignment.MiddleCenter;
            this.PictureBoxEAN13.BackColor = Color.White;
            this.PictureBoxEAN13.BackgroundImageLayout = ImageLayout.Center;
            this.PictureBoxEAN13.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBoxEAN13.Location = new Point(6, 9);
            this.PictureBoxEAN13.Margin = new Padding(3, 4, 3, 4);
            this.PictureBoxEAN13.Name = "PictureBoxEAN13";
            this.PictureBoxEAN13.Size = new Size(0x28d, 0x2d);
            this.PictureBoxEAN13.SizeMode = PictureBoxSizeMode.CenterImage;
            this.PictureBoxEAN13.TabIndex = 0x1ed36e0;
            this.PictureBoxEAN13.TabStop = false;
            this.ButtonPrintEAN13.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPrintEAN13.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPrintEAN13.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPrintEAN13.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPrintEAN13.FlatStyle = FlatStyle.Flat;
            this.ButtonPrintEAN13.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPrintEAN13.Image = A.F.ImView;
            this.ButtonPrintEAN13.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPrintEAN13.Location = new Point(6, 0x3e);
            this.ButtonPrintEAN13.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPrintEAN13.Name = "ButtonPrintEAN13";
            this.ButtonPrintEAN13.Size = new Size(0x28d, 0x24);
            this.ButtonPrintEAN13.TabIndex = 0x1ed36e1;
            this.ButtonPrintEAN13.Text = "معاينة وطباعة";
            this.ButtonPrintEAN13.UseVisualStyleBackColor = true;
            this.TabPage4.Controls.Add(this.GroupBox9);
            this.TabPage4.Controls.Add(this.GroupBox7);
            this.TabPage4.Location = new Point(4, 0x1f);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x293, 0xa2);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "إعدادات القياس والهوامش";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.TabPage6.Controls.Add(this.CheckBarCodePrint);
            this.TabPage6.Controls.Add(this.GroupBox20);
            this.TabPage6.Location = new Point(4, 0x1f);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new Padding(3);
            this.TabPage6.Size = new Size(0x293, 0xa2);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "إعدادات الطباعة";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.CheckBarCodePrint.AutoSize = true;
            this.CheckBarCodePrint.Checked = true;
            this.CheckBarCodePrint.CheckState = CheckState.Checked;
            this.CheckBarCodePrint.Location = new Point(0x1f7, 0x1b);
            this.CheckBarCodePrint.Name = "CheckBarCodePrint";
            this.CheckBarCodePrint.Size = new Size(0x7f, 20);
            this.CheckBarCodePrint.TabIndex = 0x3b;
            this.CheckBarCodePrint.Text = "معاينة قبل الطباعة";
            this.CheckBarCodePrint.UseVisualStyleBackColor = true;
            this.GroupBox20.Controls.Add(this.BarCodePrinterList);
            this.GroupBox20.Location = new Point(0x13f, 0x41);
            this.GroupBox20.Name = "GroupBox20";
            this.GroupBox20.Size = new Size(0x13a, 0x35);
            this.GroupBox20.TabIndex = 0x3a;
            this.GroupBox20.TabStop = false;
            this.GroupBox20.Text = "اسم الطابعة";
            this.BarCodePrinterList.Dock = DockStyle.Fill;
            this.BarCodePrinterList.DropDownStyle = ComboBoxStyle.DropDownList;
            this.BarCodePrinterList.Enabled = false;
            this.BarCodePrinterList.FormattingEnabled = true;
            this.BarCodePrinterList.Location = new Point(3, 0x13);
            this.BarCodePrinterList.Name = "BarCodePrinterList";
            this.BarCodePrinterList.Size = new Size(0x134, 0x18);
            this.BarCodePrinterList.TabIndex = 4;
            this.GroupBox12.Controls.Add(this.MDisMiWi);
            this.GroupBox12.Location = new Point(0x1c4, 0x51);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x4d, 0x35);
            this.GroupBox12.TabIndex = 0x1ed36cc;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "الخصم %";
            this.MDisMiWi.BackColor = Color.White;
            this.MDisMiWi.Dock = DockStyle.Fill;
            this.MDisMiWi.Location = new Point(3, 0x13);
            this.MDisMiWi.MaxLength = 5;
            this.MDisMiWi.Name = "MDisMiWi";
            this.MDisMiWi.RightToLeft = RightToLeft.No;
            this.MDisMiWi.Size = new Size(0x47, 0x17);
            this.MDisMiWi.TabIndex = 0;
            this.MDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.GroupBox8.Controls.Add(this.MSale);
            this.GroupBox8.Location = new Point(0x217, 0x51);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x83, 0x35);
            this.GroupBox8.TabIndex = 0x1ed36ca;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "السعر";
            this.MSale.BackColor = SystemColors.Info;
            this.MSale.Dock = DockStyle.Fill;
            this.MSale.Location = new Point(3, 0x13);
            this.MSale.MaxLength = 50;
            this.MSale.Name = "MSale";
            this.MSale.RightToLeft = RightToLeft.No;
            this.MSale.Size = new Size(0x7d, 0x17);
            this.MSale.TabIndex = 0;
            this.MSale.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.MBarCode);
            this.GroupBox3.Location = new Point(0x1c4, 0x16);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0xd6, 0x35);
            this.GroupBox3.TabIndex = 0x1ed36c7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم المادة";
            this.MBarCode.BackColor = SystemColors.Info;
            this.MBarCode.Dock = DockStyle.Fill;
            this.MBarCode.Location = new Point(3, 0x13);
            this.MBarCode.MaxLength = 300;
            this.MBarCode.Name = "MBarCode";
            this.MBarCode.RightToLeft = RightToLeft.No;
            this.MBarCode.Size = new Size(0xd0, 0x17);
            this.MBarCode.TabIndex = 1;
            this.MBarCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox14.Controls.Add(this.MDisVal);
            this.GroupBox14.Location = new Point(0x15f, 0x51);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x5f, 0x35);
            this.GroupBox14.TabIndex = 0x1ed36ce;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "مبلغ الخصم";
            this.MDisVal.BackColor = Color.White;
            this.MDisVal.Dock = DockStyle.Fill;
            this.MDisVal.Location = new Point(3, 0x13);
            this.MDisVal.MaxLength = 5;
            this.MDisVal.Name = "MDisVal";
            this.MDisVal.RightToLeft = RightToLeft.No;
            this.MDisVal.Size = new Size(0x59, 0x17);
            this.MDisVal.TabIndex = 0;
            this.MDisVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox13.Controls.Add(this.MDarMiWi);
            this.GroupBox13.Location = new Point(0x101, 0x51);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x4d, 0x35);
            this.GroupBox13.TabIndex = 0x1ed36cd;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "الضريبة %";
            this.MDarMiWi.BackColor = Color.White;
            this.MDarMiWi.Dock = DockStyle.Fill;
            this.MDarMiWi.Location = new Point(3, 0x13);
            this.MDarMiWi.MaxLength = 5;
            this.MDarMiWi.Name = "MDarMiWi";
            this.MDarMiWi.RightToLeft = RightToLeft.No;
            this.MDarMiWi.Size = new Size(0x47, 0x17);
            this.MDarMiWi.TabIndex = 0;
            this.MDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.GroupBox2.Controls.Add(this.Button2Q);
            this.GroupBox2.Controls.Add(this.MName);
            this.GroupBox2.Location = new Point(9, 0x16);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x1b5, 0x35);
            this.GroupBox2.TabIndex = 0x1ed36c6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "اسم المادة";
            this.GroupBox15.Controls.Add(this.MDarVal);
            this.GroupBox15.Location = new Point(0x9c, 0x51);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x5f, 0x35);
            this.GroupBox15.TabIndex = 0x1ed36cf;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "مبلغ الضريبة";
            this.MDarVal.BackColor = Color.White;
            this.MDarVal.Dock = DockStyle.Fill;
            this.MDarVal.Enabled = false;
            this.MDarVal.Location = new Point(3, 0x13);
            this.MDarVal.MaxLength = 5;
            this.MDarVal.Name = "MDarVal";
            this.MDarVal.RightToLeft = RightToLeft.No;
            this.MDarVal.Size = new Size(0x59, 0x17);
            this.MDarVal.TabIndex = 0;
            this.MDarVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox11.Controls.Add(this.MSTotal);
            this.GroupBox11.Location = new Point(9, 0x51);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x8d, 0x35);
            this.GroupBox11.TabIndex = 0x1ed36cb;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "صافي السعر";
            this.MSTotal.BackColor = SystemColors.Info;
            this.MSTotal.Dock = DockStyle.Fill;
            this.MSTotal.Enabled = false;
            this.MSTotal.Location = new Point(3, 0x13);
            this.MSTotal.MaxLength = 50;
            this.MSTotal.Name = "MSTotal";
            this.MSTotal.RightToLeft = RightToLeft.No;
            this.MSTotal.Size = new Size(0x87, 0x17);
            this.MSTotal.TabIndex = 0;
            this.MSTotal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox1.BackColor = SystemColors.ButtonHighlight;
            this.GroupBox1.Controls.Add(this.GroupBox11);
            this.GroupBox1.Controls.Add(this.GroupBox15);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.GroupBox13);
            this.GroupBox1.Controls.Add(this.GroupBox14);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.GroupBox8);
            this.GroupBox1.Controls.Add(this.GroupBox12);
            this.GroupBox1.Dock = DockStyle.Top;
            this.GroupBox1.FlatStyle = FlatStyle.Popup;
            this.GroupBox1.Location = new Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x2a1, 0x94);
            this.GroupBox1.TabIndex = 0x53;
            this.GroupBox1.TabStop = false;
            this.cboCorrectionLevel.Location = new Point(470, 0x369);
            this.cboCorrectionLevel.Name = "cboCorrectionLevel";
            this.cboCorrectionLevel.Size = new Size(100, 0x17);
            this.cboCorrectionLevel.TabIndex = 0x1ed36ea;
            this.cboCorrectionLevel.Text = "M";
            this.cboVersion.Location = new Point(470, 0x344);
            this.cboVersion.Name = "cboVersion";
            this.cboVersion.Size = new Size(100, 0x17);
            this.cboVersion.TabIndex = 0x1ed36e9;
            this.cboVersion.Text = "1";
            this.txtSize.Location = new Point(250, 0x38c);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new Size(100, 0x17);
            this.txtSize.TabIndex = 0x1ed36e8;
            this.txtSize.Text = "2";
            this.cboEncoding.Location = new Point(470, 0x383);
            this.cboEncoding.Name = "cboEncoding";
            this.cboEncoding.Size = new Size(100, 0x17);
            this.cboEncoding.TabIndex = 0x1ed36e7;
            this.cboEncoding.Text = "Byte";
            this.GroupBox19.Controls.Add(this.TabControl1);
            this.GroupBox19.Controls.Add(this.CheckSectionBarCodeImage);
            this.GroupBox19.Dock = DockStyle.Top;
            this.GroupBox19.FlatStyle = FlatStyle.Popup;
            this.GroupBox19.Location = new Point(0, 430);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(0x2a1, 0xf8);
            this.GroupBox19.TabIndex = 0x1ed36eb;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "شيفرة الباركود";
            this.CheckSectionBarCodeImage.Location = new Point(3, 0x13);
            this.CheckSectionBarCodeImage.Name = "CheckSectionBarCodeImage";
            this.CheckSectionBarCodeImage.Size = new Size(0x90, 0x17);
            this.CheckSectionBarCodeImage.TabIndex = 1;
            this.CheckSectionBarCodeImage.Text = "اخفاء صورة الباركود";
            this.CheckSectionBarCodeImage.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2a1, 0x2a9);
            base.Controls.Add(this.GroupBox19);
            base.Controls.Add(this.cboCorrectionLevel);
            base.Controls.Add(this.cboVersion);
            base.Controls.Add(this.txtSize);
            base.Controls.Add(this.cboEncoding);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.GroupBox1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BarCodeSingle";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "طباعة ملصقات باركود";
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox18.PerformLayout();
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox16.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((ISupportInitialize) this.PictureBox128).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((ISupportInitialize) this.PictureBoxQR).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            ((ISupportInitialize) this.PictureBoxEAN13).EndInit();
            this.TabPage4.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox20.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox13.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox15.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox19.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public Image A(string A)
        {
            // Invalid method body.
        }

        private byte[] A(byte[] A)
        {
            string left = "101";
            object[] arguments = new object[] { 3 };
            string str2 = Conversions.ToString(NewLateBinding.LateIndexGet(this.A[A[0]], arguments, null));
            int index = 1;
            while (true)
            {
                object[] objArray2 = new object[] { Conversions.ToInteger(str2.Substring(index - 1, 1)) };
                left = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(left, NewLateBinding.LateIndexGet(this.A[A[index]], objArray2, null)));
                index++;
                if (index > 6)
                {
                    left = left + "01010";
                    index = 7;
                    while (true)
                    {
                        object[] objArray3 = new object[] { 2 };
                        left = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(left, NewLateBinding.LateIndexGet(this.A[A[index]], objArray3, null)));
                        index++;
                        if (index > 12)
                        {
                            left = left + "101";
                            byte[] buffer2 = new byte[(left.Length - 1) + 1];
                            int num2 = left.Length - 1;
                            for (index = 0; index <= num2; index++)
                            {
                                buffer2[index] = (byte) (Strings.Asc(left[index]) - 0x30);
                            }
                            return buffer2;
                        }
                    }
                }
            }
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, FormClosedEventArgs R)
        {
            this.R();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void D()
        {
            try
            {
                VR vr = new VR();
                if (this.CheckBarCodePrint.Checked)
                {
                    vr.PrintOptions.NoPrinter = true;
                }
                else
                {
                    vr.PrintOptions.NoPrinter = this.BarCodePrinterList.Text == null;
                }
                vr.SetParameterValue("TXTSectionBarCodeImage", this.A);
                vr.SetParameterValue("TXTSectionBarCodeNumber", this.BCBarCode.Text);
                vr.SetParameterValue("TXTSectionBarCodeName", this.BCName.Text);
                vr.SetParameterValue("TXTSectionBarCodePrice", this.BCPrice.Text);
                vr.SetParameterValue("TXTSectionBarCodeDExpier", this.BCDateExpire.Text);
                vr.SetParameterValue("TXTSectionBarCodeNote", this.BCNote.Text);
                vr.SetParameterValue("TXTSectionBarCodeStorName", this.BCStoreName.Text);
                decimal num = new decimal(Conversion.Val(this.TxTCRLef.Text));
                decimal num2 = new decimal(Conversion.Val(this.TxTCRRit.Text));
                decimal num3 = new decimal(Conversion.Val(this.TxTCRTop.Text));
                decimal num4 = new decimal(Conversion.Val(this.TxTCRBot.Text));
                decimal num6 = decimal.Multiply(new decimal(Conversion.Val(this.TxTW.Text) * 0.3937), new decimal((long) 100));
                decimal num8 = decimal.Multiply(new decimal(Conversion.Val(this.TxTH.Text) * 0.3937), new decimal((long) 100));
                vr.ReportDefinition.ReportObjects["TXTSectionBarCodeImage1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                vr.ReportDefinition.ReportObjects["TXTSectionBarCodeNumber1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                vr.ReportDefinition.ReportObjects["TXTSectionBarCodeName1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                vr.ReportDefinition.ReportObjects["TXTSectionBarCodePrice1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                vr.ReportDefinition.ReportObjects["TXTSectionBarCodeDExpier1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                vr.ReportDefinition.ReportObjects["TXTSectionBarCodeNote1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                vr.ReportDefinition.ReportObjects["TXTSectionBarCodeStorName1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                vr.ReportDefinition.Sections["SectionBarCodeImage"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeImage.Checked;
                vr.ReportDefinition.Sections["SectionBarCodeNumber"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNumber.Checked;
                vr.ReportDefinition.Sections["SectionBarCodeName"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeName.Checked;
                vr.ReportDefinition.Sections["SectionBarCodePrice"].SectionFormat.EnableSuppress = this.CheckSectionBarCodePrice.Checked;
                vr.ReportDefinition.Sections["SectionBarCodeDExpier"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeDExpier.Checked;
                vr.ReportDefinition.Sections["SectionBarCodeNote"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNote.Checked;
                vr.ReportDefinition.Sections["SectionBarCodeStorName"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeStorName.Checked;
                PrinterSettings printerSettings = new PrinterSettings();
                PageSettings page = new PageSettings(printerSettings) {
                    Margins = new Margins(Convert.ToInt32(num), Convert.ToInt32(num2), Convert.ToInt32(num3), Convert.ToInt32(num4)),
                    PaperSize = new PaperSize("YAZSYSNEWSIZE", Convert.ToInt32(num6), Convert.ToInt32(num8))
                };
                vr.PrintOptions.DissociatePageSizeAndPrinterPaperSize = true;
                vr.PrintOptions.CopyFrom(printerSettings, page);
                HR hr = new HR {
                    CRViewer = { ReportSource = vr }
                };
                hr.CRViewer.Zoom(200);
                if (this.CheckBarCodePrint.Checked)
                {
                    hr.ShowDialog();
                }
                else if (this.BarCodePrinterList.Text == null)
                {
                    hr.ShowDialog();
                }
                else
                {
                    vr.PrintOptions.NoPrinter = false;
                    vr.PrintOptions.PrinterName = this.BarCodePrinterList.Text;
                    vr.PrintToPrinter(1, false, 0, 0);
                }
                vr.Close();
                vr.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void D(object A, EventArgs R)
        {
            this.Q();
        }

        private void D(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.P();
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.A != null))
                {
                    this.A.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void E(object A, EventArgs R)
        {
            if (Conversion.Val(this.TxTW.Text) <= 4.0)
            {
                this.LabelNote39.Visible = true;
                this.LabelNote128.Visible = true;
            }
            else
            {
                this.LabelNote39.Visible = false;
                this.LabelNote128.Visible = false;
            }
        }

        public void F()
        {
            try
            {
                LR lr = new LR();
                if (this.CheckBarCodePrint.Checked)
                {
                    lr.PrintOptions.NoPrinter = true;
                }
                else
                {
                    lr.PrintOptions.NoPrinter = this.BarCodePrinterList.Text == null;
                }
                lr.SetParameterValue("TXTSectionBarCodeImage", this.P);
                lr.SetParameterValue("TXTSectionBarCodeNumber", this.BCBarCode.Text);
                lr.SetParameterValue("TXTSectionBarCodeName", this.BCName.Text);
                lr.SetParameterValue("TXTSectionBarCodePrice", this.BCPrice.Text);
                lr.SetParameterValue("TXTSectionBarCodeDExpier", this.BCDateExpire.Text);
                lr.SetParameterValue("TXTSectionBarCodeNote", this.BCNote.Text);
                lr.SetParameterValue("TXTSectionBarCodeStorName", this.BCStoreName.Text);
                decimal num = new decimal(Conversion.Val(this.TxTCRLef.Text));
                decimal num2 = new decimal(Conversion.Val(this.TxTCRRit.Text));
                decimal num3 = new decimal(Conversion.Val(this.TxTCRTop.Text));
                decimal num4 = new decimal(Conversion.Val(this.TxTCRBot.Text));
                decimal num6 = decimal.Multiply(new decimal(Conversion.Val(this.TxTW.Text) * 0.3937), new decimal((long) 100));
                decimal num8 = decimal.Multiply(new decimal(Conversion.Val(this.TxTH.Text) * 0.3937), new decimal((long) 100));
                lr.ReportDefinition.ReportObjects["TXTSectionBarCodeImage1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                lr.ReportDefinition.ReportObjects["TXTSectionBarCodeNumber1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                lr.ReportDefinition.ReportObjects["TXTSectionBarCodeName1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                lr.ReportDefinition.ReportObjects["TXTSectionBarCodePrice1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                lr.ReportDefinition.ReportObjects["TXTSectionBarCodeDExpier1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                lr.ReportDefinition.ReportObjects["TXTSectionBarCodeNote1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                lr.ReportDefinition.ReportObjects["TXTSectionBarCodeStorName1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                lr.ReportDefinition.Sections["SectionBarCodeImage"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeImage.Checked;
                this.CheckSectionBarCodeNumber.Checked = true;
                lr.ReportDefinition.Sections["SectionBarCodeNumber"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNumber.Checked;
                lr.ReportDefinition.Sections["SectionBarCodeName"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeName.Checked;
                lr.ReportDefinition.Sections["SectionBarCodePrice"].SectionFormat.EnableSuppress = this.CheckSectionBarCodePrice.Checked;
                lr.ReportDefinition.Sections["SectionBarCodeDExpier"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeDExpier.Checked;
                lr.ReportDefinition.Sections["SectionBarCodeNote"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNote.Checked;
                lr.ReportDefinition.Sections["SectionBarCodeStorName"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeStorName.Checked;
                PrinterSettings printerSettings = new PrinterSettings();
                PageSettings page = new PageSettings(printerSettings) {
                    Margins = new Margins(Convert.ToInt32(num), Convert.ToInt32(num2), Convert.ToInt32(num3), Convert.ToInt32(num4)),
                    PaperSize = new PaperSize("YAZSYSNEWSIZE", Convert.ToInt32(num6), Convert.ToInt32(num8))
                };
                lr.PrintOptions.DissociatePageSizeAndPrinterPaperSize = true;
                lr.PrintOptions.CopyFrom(printerSettings, page);
                HR hr = new HR {
                    CRViewer = { ReportSource = lr }
                };
                hr.CRViewer.Zoom(200);
                if (this.CheckBarCodePrint.Checked)
                {
                    hr.ShowDialog();
                }
                else if (this.BarCodePrinterList.Text == null)
                {
                    hr.ShowDialog();
                }
                else
                {
                    lr.PrintOptions.NoPrinter = false;
                    lr.PrintOptions.PrinterName = this.BarCodePrinterList.Text;
                    lr.PrintToPrinter(1, false, 0, 0);
                }
                lr.Close();
                lr.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void F(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void G(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/SPDetails.aspx?ID=38");
        }

        public void H()
        {
            try
            {
                KR kr = new KR();
                if (this.CheckBarCodePrint.Checked)
                {
                    kr.PrintOptions.NoPrinter = true;
                }
                else
                {
                    kr.PrintOptions.NoPrinter = this.BarCodePrinterList.Text == null;
                }
                kr.SetParameterValue("TXTSectionBarCodeImage", this.R);
                kr.SetParameterValue("TXTSectionBarCodeNumber", this.BCBarCode.Text);
                kr.SetParameterValue("TXTSectionBarCodeName", this.BCName.Text);
                kr.SetParameterValue("TXTSectionBarCodePrice", this.BCPrice.Text);
                kr.SetParameterValue("TXTSectionBarCodeDExpier", this.BCDateExpire.Text);
                kr.SetParameterValue("TXTSectionBarCodeNote", this.BCNote.Text);
                kr.SetParameterValue("TXTSectionBarCodeStorName", this.BCStoreName.Text);
                decimal num = new decimal(Conversion.Val(this.TxTCRLef.Text));
                decimal num2 = new decimal(Conversion.Val(this.TxTCRRit.Text));
                decimal num3 = new decimal(Conversion.Val(this.TxTCRTop.Text));
                decimal num4 = new decimal(Conversion.Val(this.TxTCRBot.Text));
                decimal num6 = decimal.Multiply(new decimal(Conversion.Val(this.TxTW.Text) * 0.3937), new decimal((long) 100));
                decimal num8 = decimal.Multiply(new decimal(Conversion.Val(this.TxTH.Text) * 0.3937), new decimal((long) 100));
                kr.ReportDefinition.ReportObjects["TXTSectionBarCodeNumber1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                kr.ReportDefinition.ReportObjects["TXTSectionBarCodeName1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                kr.ReportDefinition.ReportObjects["TXTSectionBarCodePrice1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                kr.ReportDefinition.ReportObjects["TXTSectionBarCodeDExpier1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                kr.ReportDefinition.ReportObjects["TXTSectionBarCodeNote1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                kr.ReportDefinition.ReportObjects["TXTSectionBarCodeStorName1"].Width = Convert.ToInt32(decimal.Subtract(decimal.Multiply(num6, new decimal((long) 13)), 700M));
                kr.ReportDefinition.Sections["SectionBarCodeImage"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeImage.Checked;
                this.CheckSectionBarCodeNumber.Checked = true;
                kr.ReportDefinition.Sections["SectionBarCodeNumber"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNumber.Checked;
                kr.ReportDefinition.Sections["SectionBarCodeName"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeName.Checked;
                kr.ReportDefinition.Sections["SectionBarCodePrice"].SectionFormat.EnableSuppress = this.CheckSectionBarCodePrice.Checked;
                kr.ReportDefinition.Sections["SectionBarCodeDExpier"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeDExpier.Checked;
                kr.ReportDefinition.Sections["SectionBarCodeNote"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNote.Checked;
                kr.ReportDefinition.ReportObjects["TXTSectionBarCodeStorName1"].ObjectFormat.EnableSuppress = this.CheckSectionBarCodeStorName.Checked;
                PrinterSettings printerSettings = new PrinterSettings();
                PageSettings page = new PageSettings(printerSettings) {
                    Margins = new Margins(Convert.ToInt32(num), Convert.ToInt32(num2), Convert.ToInt32(num3), Convert.ToInt32(num4)),
                    PaperSize = new PaperSize("YAZSYSNEWSIZE", Convert.ToInt32(num6), Convert.ToInt32(num8))
                };
                kr.PrintOptions.DissociatePageSizeAndPrinterPaperSize = true;
                kr.PrintOptions.CopyFrom(printerSettings, page);
                HR hr = new HR {
                    CRViewer = { ReportSource = kr }
                };
                hr.CRViewer.Zoom(200);
                if (this.CheckBarCodePrint.Checked)
                {
                    hr.ShowDialog();
                }
                else if (this.BarCodePrinterList.Text == null)
                {
                    hr.ShowDialog();
                }
                else
                {
                    kr.PrintOptions.NoPrinter = false;
                    kr.PrintOptions.PrinterName = this.BarCodePrinterList.Text;
                    kr.PrintToPrinter(1, false, 0, 0);
                }
                kr.Close();
                kr.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void H(object A, EventArgs R)
        {
            this.MBarCode.Text = Conversions.ToString(this.MName.SelectedValue);
            this.P();
        }

        public void I()
        {
            try
            {
                QRCodeEncoder encoder = new QRCodeEncoder();
                string text = this.cboEncoding.Text;
                if (text == "Byte")
                {
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                }
                else if (text == "AlphaNumeric")
                {
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                }
                else if (text == "Numeric")
                {
                    encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                }
                try
                {
                    encoder.QRCodeScale = Convert.ToInt16(this.txtSize.Text);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    ProjectData.ClearProjectError();
                    return;
                }
                try
                {
                    encoder.QRCodeVersion = Convert.ToInt16(this.cboVersion.Text);
                }
                catch (Exception exception4)
                {
                    Exception ex = exception4;
                    ProjectData.SetProjectError(ex);
                    Exception exception2 = ex;
                    ProjectData.ClearProjectError();
                }
                string str2 = this.cboCorrectionLevel.Text;
                if (str2 == "L")
                {
                    encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                }
                else if (str2 == "M")
                {
                    encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                }
                else if (str2 == "Q")
                {
                    encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                }
                else if (str2 == "H")
                {
                    encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                }
                Image image = encoder.Encode(this.BCBarCode.Text);
                this.PictureBoxQR.Image = image;
            }
            catch (Exception exception5)
            {
                Exception ex = exception5;
                ProjectData.SetProjectError(ex);
                Exception exception3 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void I(object A, EventArgs R)
        {
            this.Q();
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void K(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void L(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void N(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void O(object A, EventArgs R)
        {
            this.BarCodePrinterList.Enabled = !this.CheckBarCodePrint.Checked;
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            this.Q();
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            this.Q();
        }

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void R()
        {
            AR.A = new decimal(Conversion.Val(this.TxTCRTop.Text));
            AR.R = new decimal(Conversion.Val(this.TxTCRBot.Text));
            AR.P = new decimal(Conversion.Val(this.TxTCRRit.Text));
            AR.Q = new decimal(Conversion.Val(this.TxTCRLef.Text));
            AR.I = new decimal(Conversion.Val(this.TxTW.Text));
            AR.D = new decimal(Conversion.Val(this.TxTH.Text));
            AR.O = this.CheckSectionBarCodeNumber.Checked;
            AR.B = this.CheckSectionBarCodeName.Checked;
            AR.S = this.CheckSectionBarCodePrice.Checked;
            AR.Z = this.CheckSectionBarCodeNote.Checked;
            AR.M = this.CheckSectionBarCodeDExpier.Checked;
            AR.C = this.CheckSectionBarCodeStorName.Checked;
            AR.Q = (int) Math.Round(Conversion.Val(this.ComboBoxFontSize.Text));
            AR.U = this.BarCodePrinterList.Text;
            AR.KR = this.CheckBarCodePrint.Checked;
            base.Dispose();
        }

        private void R(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataSet dataSet = new DataSet();
                string selectCommandText = "SELECT * FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataSet, "TaNNMaterial");
                this.A.Close();
                this.MName.ValueMember = "MaterialBarCode";
                this.MName.DisplayMember = "MaterialName";
                this.MName.DataSource = dataSet.Tables[0];
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void T()
        {
            try
            {
                GR gr = new GR();
                if (this.CheckBarCodePrint.Checked)
                {
                    gr.PrintOptions.NoPrinter = true;
                }
                else
                {
                    gr.PrintOptions.NoPrinter = this.BarCodePrinterList.Text == null;
                }
                gr.SetParameterValue("XBarCodeX", "*" + this.BCBarCode.Text + "*");
                gr.SetParameterValue("XFontSize", Conversion.Val(this.ComboBoxFontSize.Text));
                gr.SetParameterValue("TXTSectionBarCodeNumber", this.BCBarCode.Text);
                gr.SetParameterValue("TXTSectionBarCodeName", this.BCName.Text);
                gr.SetParameterValue("TXTSectionBarCodePrice", this.BCPrice.Text);
                gr.SetParameterValue("TXTSectionBarCodeDExpier", this.BCDateExpire.Text);
                gr.SetParameterValue("TXTSectionBarCodeNote", this.BCNote.Text);
                gr.SetParameterValue("TXTSectionBarCodeStorName", this.BCStoreName.Text);
                decimal num = new decimal(Conversion.Val(this.TxTCRLef.Text));
                decimal num2 = new decimal(Conversion.Val(this.TxTCRRit.Text));
                decimal num3 = new decimal(Conversion.Val(this.TxTCRTop.Text));
                decimal num4 = new decimal(Conversion.Val(this.TxTCRBot.Text));
                decimal num6 = decimal.Multiply(new decimal(Conversion.Val(this.TxTW.Text) * 0.3937), new decimal((long) 100));
                decimal num8 = decimal.Multiply(new decimal(Conversion.Val(this.TxTH.Text) * 0.3937), new decimal((long) 100));
                gr.ReportDefinition.ReportObjects["XBarCodeX1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                gr.ReportDefinition.ReportObjects["TXTSectionBarCodeNumber1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                gr.ReportDefinition.ReportObjects["TXTSectionBarCodeName1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                gr.ReportDefinition.ReportObjects["TXTSectionBarCodePrice1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                gr.ReportDefinition.ReportObjects["TXTSectionBarCodeDExpier1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                gr.ReportDefinition.ReportObjects["TXTSectionBarCodeNote1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                gr.ReportDefinition.ReportObjects["TXTSectionBarCodeStorName1"].Width = Convert.ToInt32(decimal.Multiply(num6, new decimal((long) 13)));
                gr.ReportDefinition.Sections["SectionBarCodeImage"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeImage.Checked;
                gr.ReportDefinition.Sections["SectionBarCodeNumber"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNumber.Checked;
                gr.ReportDefinition.Sections["SectionBarCodeName"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeName.Checked;
                gr.ReportDefinition.Sections["SectionBarCodePrice"].SectionFormat.EnableSuppress = this.CheckSectionBarCodePrice.Checked;
                gr.ReportDefinition.Sections["SectionBarCodeDExpier"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeDExpier.Checked;
                gr.ReportDefinition.Sections["SectionBarCodeNote"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeNote.Checked;
                gr.ReportDefinition.Sections["SectionBarCodeStorName"].SectionFormat.EnableSuppress = this.CheckSectionBarCodeStorName.Checked;
                PrinterSettings printerSettings = new PrinterSettings();
                PageSettings page = new PageSettings(printerSettings) {
                    Margins = new Margins(Convert.ToInt32(num), Convert.ToInt32(num2), Convert.ToInt32(num3), Convert.ToInt32(num4)),
                    PaperSize = new PaperSize("YAZSYSNEWSIZE", Convert.ToInt32(num6), Convert.ToInt32(num8))
                };
                gr.PrintOptions.DissociatePageSizeAndPrinterPaperSize = true;
                gr.PrintOptions.CopyFrom(printerSettings, page);
                HR hr = new HR {
                    CRViewer = { ReportSource = gr }
                };
                hr.CRViewer.Zoom(200);
                if (this.CheckBarCodePrint.Checked)
                {
                    hr.ShowDialog();
                }
                else if (this.BarCodePrinterList.Text == null)
                {
                    hr.ShowDialog();
                }
                else
                {
                    gr.PrintOptions.NoPrinter = false;
                    gr.PrintOptions.PrinterName = this.BarCodePrinterList.Text;
                    gr.PrintToPrinter(1, false, 0, 0);
                }
                gr.Close();
                gr.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void T(object A, EventArgs R)
        {
            if (this.BCBarCode.Text != null)
            {
                this.PictureBox128.Image = A.S.A(this.BCBarCode.Text, "A");
                this.I();
                this.LabelBarCode39.Text = "*" + this.BCBarCode.Text + "*";
                this.PictureBoxEAN13.Image = this.A(this.BCBarCode.Text);
            }
        }

        private void U(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void V(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            int num = (int) Math.Round(Conversion.Val(this.ComboBoxFontSize.Text));
            this.LabelBarCode39.Font = new Font("Bar-Code 39", (float) num);
        }

        private void Y(object A, EventArgs R)
        {
        }

        internal virtual Button Button2Q
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                Button a = this.A;
                if (a != null)
                {
                    a.Click -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Click += handler;
                }
            }
        }

        internal virtual ComboBox MName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                ComboBox a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged += handler;
                }
            }
        }

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                Timer a = this.A;
                if (a != null)
                {
                    a.Tick -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Tick += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckSectionBarCodeStorName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonHelp
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                Button r = this.R;
                if (r != null)
                {
                    r.Click -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.Click += handler;
                }
            }
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTW
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                }
            }
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTH
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TxTCRTop
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTCRLef
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label Label6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label Label7
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label Label8
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox TxTCRBot
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TxTCRRit
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox BCStoreName
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Panel Panel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual CheckBox CheckSectionBarCodeNote
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox BCNote
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CheckSectionBarCodeDExpier
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox BCDateExpire
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual CheckBox CheckSectionBarCodePrice
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox BCPrice
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual CheckBox CheckSectionBarCodeName
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox BCName
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual CheckBox CheckSectionBarCodeNumber
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox BCBarCode
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                TextBox e = this.E;
                if (e != null)
                {
                    e.TextChanged -= handler;
                }
                this.E = value;
                e = this.E;
                if (e != null)
                {
                    e.TextChanged += handler;
                }
            }
        }

        internal virtual TabControl TabControl1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label LabelNote128
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual PictureBox PictureBox128
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonPrint128
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                Button p = this.P;
                if (p != null)
                {
                    p.Click -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.Click += handler;
                }
            }
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonPrintQR
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                Button q = this.Q;
                if (q != null)
                {
                    q.Click -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBoxQR
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ComboBox ComboBoxFontSize
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                ComboBox r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual Button ButtonPrint39
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                Button i = this.I;
                if (i != null)
                {
                    i.Click -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Click += handler;
                }
            }
        }

        internal virtual Label LabelBarCode39
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox MDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                TextBox k = this.K;
                if (k != null)
                {
                    k.TextChanged -= handler;
                    k.KeyPress -= handler2;
                }
                this.K = value;
                k = this.K;
                if (k != null)
                {
                    k.TextChanged += handler;
                    k.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox MSale
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox u = this.U;
                if (u != null)
                {
                    u.TextChanged -= handler;
                    u.KeyPress -= handler2;
                }
                this.U = value;
                u = this.U;
                if (u != null)
                {
                    u.TextChanged += handler;
                    u.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual TextBox MDisVal
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                TextBox l = this.L;
                if (l != null)
                {
                    l.TextChanged -= handler;
                    l.KeyPress -= handler2;
                }
                this.L = value;
                l = this.L;
                if (l != null)
                {
                    l.TextChanged += handler;
                    l.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TextBox MDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
                TextBox n = this.N;
                if (n != null)
                {
                    n.TextChanged -= handler;
                    n.KeyPress -= handler2;
                }
                this.N = value;
                n = this.N;
                if (n != null)
                {
                    n.TextChanged += handler;
                    n.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox MDarVal
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual TextBox MSTotal
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.I);
                TextBox y = this.Y;
                if (y != null)
                {
                    y.KeyPress -= handler;
                }
                this.Y = value;
                y = this.Y;
                if (y != null)
                {
                    y.KeyPress += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual Label LabelNote39
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox MBarCode
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.D);
                TextBox o = this.O;
                if (o != null)
                {
                    o.KeyPress -= handler;
                }
                this.O = value;
                o = this.O;
                if (o != null)
                {
                    o.KeyPress += handler;
                }
            }
        }

        internal virtual TextBox cboCorrectionLevel
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual TextBox cboVersion
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual TextBox txtSize
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual TextBox cboEncoding
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label LBErrorEAN13
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual PictureBox PictureBoxEAN13
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonPrintEAN13
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                Button d = this.D;
                if (d != null)
                {
                    d.Click -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Click += handler;
                }
            }
        }

        internal virtual Label Label9
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual CheckBox CheckSectionBarCodeImage
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TabPage TabPage6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual CheckBox CheckBarCodePrint
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
                CheckBox h = this.H;
                if (h != null)
                {
                    h.CheckedChanged -= handler;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.CheckedChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox20
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual ComboBox BarCodePrinterList
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }
    }
}

