namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class OH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOk"), CompilerGenerated]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox2")]
        private GroupBox A;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("PictureBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTUserPass")]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label10"), CompilerGenerated]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("Label8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTUserLog"), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("TxTUserName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [CompilerGenerated, AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage3")]
        private TabPage P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonCenters")]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("ButtonDb"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonCon"), CompilerGenerated]
        private Button I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTUserID"), CompilerGenerated]
        private TextBox Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("TxTCenterName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox I;
        [CompilerGenerated, AccessedThroughProperty("IsForgetPass"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("ButtonHelpSQL"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button D;
        [CompilerGenerated, AccessedThroughProperty("ButtonChaneName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage4"), CompilerGenerated]
        private TabPage Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonImport"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage5")]
        private TabPage I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxRest")]
        private CheckBox R;
        [CompilerGenerated, AccessedThroughProperty("ButtonrRest"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage6")]
        private TabPage D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonFIX")]
        private Button X;
        [AccessedThroughProperty("ButtonW"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("WebBrowser1"), CompilerGenerated]
        private WebBrowser A;
        private SqlConnection A;
        private M A;

        public OH()
        {
            base.Load += new EventHandler(this.D);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new M();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.GroupBox2 = new GroupBox();
            this.GroupBox1 = new GroupBox();
            this.TxTUserName = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.PictureBox1 = new PictureBox();
            this.TxTUserPass = new TextBox();
            this.Label10 = new Label();
            this.Label8 = new Label();
            this.TxTUserLog = new TextBox();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtonCenters = new Button();
            this.TabPage2 = new TabPage();
            this.ButtonDb = new Button();
            this.TabPage3 = new TabPage();
            this.ButtonW = new Button();
            this.ButtonHelpSQL = new Button();
            this.ButtonCon = new Button();
            this.TabPage4 = new TabPage();
            this.ButtonImport = new Button();
            this.TabPage5 = new TabPage();
            this.CheckBoxRest = new CheckBox();
            this.ButtonrRest = new Button();
            this.TabPage6 = new TabPage();
            this.ButtonFIX = new Button();
            this.TxTUserID = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.ButtonChaneName = new Button();
            this.TxTCenterName = new TextBox();
            this.IsForgetPass = new CheckBox();
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.WebBrowser1 = new WebBrowser();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(650, 0x22);
            this.TxTTitle.TabIndex = 0x63;
            this.TxTTitle.Text = "الإعدادات الرئيسية والمدير العام";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.GroupBox1);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Dock = DockStyle.Top;
            this.GroupBox2.Location = new Point(0, 0x62);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(650, 0x89);
            this.GroupBox2.TabIndex = 0x66;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "بيانات المدير العام";
            this.GroupBox1.Controls.Add(this.TxTUserName);
            this.GroupBox1.Location = new Point(0x174, 0x27);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x105, 0x4a);
            this.GroupBox1.TabIndex = 0x25;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "الأسم:";
            this.TxTUserName.BackColor = SystemColors.Info;
            this.TxTUserName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTUserName.Location = new Point(6, 0x1c);
            this.TxTUserName.MaxLength = 50;
            this.TxTUserName.Name = "TxTUserName";
            this.TxTUserName.Size = new Size(0xf9, 0x17);
            this.TxTUserName.TabIndex = 0x23;
            this.TxTUserName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.PictureBox1);
            this.GroupBox3.Controls.Add(this.TxTUserPass);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.TxTUserLog);
            this.GroupBox3.Location = new Point(4, 0x16);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x16a, 0x68);
            this.GroupBox3.TabIndex = 0x24;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "بينات الدخول";
            this.PictureBox1.Image = A.F.ImLogin;
            this.PictureBox1.Location = new Point(0x138, 0x2a);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x20, 0x20);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 0x26;
            this.PictureBox1.TabStop = false;
            this.TxTUserPass.BackColor = SystemColors.Info;
            this.TxTUserPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTUserPass.Location = new Point(13, 0x3d);
            this.TxTUserPass.MaxLength = 50;
            this.TxTUserPass.Name = "TxTUserPass";
            this.TxTUserPass.RightToLeft = RightToLeft.No;
            this.TxTUserPass.Size = new Size(0xce, 0x17);
            this.TxTUserPass.TabIndex = 0x25;
            this.TxTUserPass.TextAlign = HorizontalAlignment.Center;
            this.TxTUserPass.UseSystemPasswordChar = true;
            this.Label10.AutoSize = true;
            this.Label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label10.Location = new Point(0xe4, 0x40);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x45, 0x10);
            this.Label10.TabIndex = 0x22;
            this.Label10.Text = "كلمة السر:";
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.Location = new Point(0xe4, 0x1c);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x47, 0x10);
            this.Label8.TabIndex = 0x20;
            this.Label8.Text = "رمز الدخول:";
            this.TxTUserLog.BackColor = SystemColors.Info;
            this.TxTUserLog.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTUserLog.Location = new Point(13, 0x19);
            this.TxTUserLog.MaxLength = 50;
            this.TxTUserLog.Name = "TxTUserLog";
            this.TxTUserLog.RightToLeft = RightToLeft.No;
            this.TxTUserLog.Size = new Size(0xce, 0x17);
            this.TxTUserLog.TabIndex = 0x24;
            this.TxTUserLog.TextAlign = HorizontalAlignment.Center;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0xeb);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(650, 0x10a);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x67;
            this.TabPage1.Controls.Add(this.ButtonCenters);
            this.TabPage1.Location = new Point(4, 0x43);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x282, 0xc3);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "  إدارة الفروع / المستودعات";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonCenters.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCenters.FlatStyle = FlatStyle.Flat;
            this.ButtonCenters.Image = A.F.ImCard;
            this.ButtonCenters.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCenters.Location = new Point(13, 0x3e);
            this.ButtonCenters.Name = "ButtonCenters";
            this.ButtonCenters.Size = new Size(600, 0x35);
            this.ButtonCenters.TabIndex = 3;
            this.ButtonCenters.Text = "إدارة الفروع/المستودعات وضبط البيانات";
            this.ButtonCenters.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.ButtonDb);
            this.TabPage2.Location = new Point(4, 0x43);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x282, 0xc3);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "  النسخ الاحتياطي لقاعدة البيانات  ";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonDb.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDb.FlatStyle = FlatStyle.Flat;
            this.ButtonDb.Image = A.F.ImDataRefresh;
            this.ButtonDb.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDb.Location = new Point(13, 0x57);
            this.ButtonDb.Name = "ButtonDb";
            this.ButtonDb.Size = new Size(0x25a, 0x36);
            this.ButtonDb.TabIndex = 2;
            this.ButtonDb.Text = "خيارات النسخ الاحتياطي والاستعادة";
            this.ButtonDb.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.ButtonW);
            this.TabPage3.Controls.Add(this.ButtonHelpSQL);
            this.TabPage3.Controls.Add(this.ButtonCon);
            this.TabPage3.Location = new Point(4, 0x43);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x282, 0xc3);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = " قاعدة البيانات والربط عبر الشبكة المحلية او العالمية";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonW.FlatAppearance.BorderColor = Color.Green;
            this.ButtonW.FlatStyle = FlatStyle.Flat;
            this.ButtonW.Image = A.F.ImNetWork;
            this.ButtonW.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonW.Location = new Point(13, 0x51);
            this.ButtonW.Name = "ButtonW";
            this.ButtonW.Size = new Size(0x259, 0x2f);
            this.ButtonW.TabIndex = 5;
            this.ButtonW.Text = "فتح معالج الاتصال مع نسخة الويب";
            this.ButtonW.UseVisualStyleBackColor = true;
            this.ButtonHelpSQL.BackColor = Color.WhiteSmoke;
            this.ButtonHelpSQL.FlatAppearance.BorderColor = Color.Green;
            this.ButtonHelpSQL.FlatStyle = FlatStyle.Flat;
            this.ButtonHelpSQL.Image = A.F.ImLAbout;
            this.ButtonHelpSQL.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonHelpSQL.Location = new Point(13, 0x86);
            this.ButtonHelpSQL.Name = "ButtonHelpSQL";
            this.ButtonHelpSQL.Size = new Size(0x259, 50);
            this.ButtonHelpSQL.TabIndex = 4;
            this.ButtonHelpSQL.Text = "لشرح طريقة الربط على شبكة محلية او عالمية او لأدارة الاشتراك السحابي انقر هنا";
            this.ButtonHelpSQL.UseVisualStyleBackColor = false;
            this.ButtonCon.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCon.FlatStyle = FlatStyle.Flat;
            this.ButtonCon.Image = A.F.ImNetWork;
            this.ButtonCon.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCon.Location = new Point(13, 0x1c);
            this.ButtonCon.Name = "ButtonCon";
            this.ButtonCon.Size = new Size(0x259, 0x2f);
            this.ButtonCon.TabIndex = 3;
            this.ButtonCon.Text = "فتح معالج جملة الاتصال مع قاعدة البيانات لهذا الجهاز";
            this.ButtonCon.UseVisualStyleBackColor = true;
            this.TabPage4.Controls.Add(this.ButtonImport);
            this.TabPage4.Location = new Point(4, 0x43);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new Padding(3);
            this.TabPage4.Size = new Size(0x282, 0xc3);
            this.TabPage4.TabIndex = 5;
            this.TabPage4.Text = "استيراد من الجيل الثالث";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.ButtonImport.FlatAppearance.BorderColor = Color.Green;
            this.ButtonImport.FlatStyle = FlatStyle.Flat;
            this.ButtonImport.Image = A.F.ImWarining;
            this.ButtonImport.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonImport.Location = new Point(15, 0x45);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new Size(0x259, 0x36);
            this.ButtonImport.TabIndex = 5;
            this.ButtonImport.Text = "لحذف البيانات الحالية واستيراد البيانات من الجيل الثالث انقر هنا";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.TabPage5.Controls.Add(this.CheckBoxRest);
            this.TabPage5.Controls.Add(this.ButtonrRest);
            this.TabPage5.Location = new Point(4, 0x43);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new Padding(3);
            this.TabPage5.Size = new Size(0x282, 0xc3);
            this.TabPage5.TabIndex = 6;
            this.TabPage5.Text = "حذف وإعادة ضبط";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.CheckBoxRest.Location = new Point(0x12, 0x2c);
            this.CheckBoxRest.Name = "CheckBoxRest";
            this.CheckBoxRest.Size = new Size(0x252, 0x29);
            this.CheckBoxRest.TabIndex = 3;
            this.CheckBoxRest.Text = "اوافق على حذف كل شيء، كل الفروع والمستودعات (الفواتير، العملاء ، الموردين، المنتجات ... كل شيء";
            this.CheckBoxRest.UseVisualStyleBackColor = true;
            this.ButtonrRest.BackColor = Color.WhiteSmoke;
            this.ButtonrRest.Enabled = false;
            this.ButtonrRest.ForeColor = Color.Black;
            this.ButtonrRest.Location = new Point(0x12, 0x68);
            this.ButtonrRest.Name = "ButtonrRest";
            this.ButtonrRest.Size = new Size(0x252, 0x2d);
            this.ButtonrRest.TabIndex = 2;
            this.ButtonrRest.Text = "حذف وإعادة ضبط قاعدة البيانات";
            this.ButtonrRest.UseVisualStyleBackColor = false;
            this.TabPage6.Controls.Add(this.ButtonFIX);
            this.TabPage6.Location = new Point(4, 0x43);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new Padding(3);
            this.TabPage6.Size = new Size(0x282, 0xc3);
            this.TabPage6.TabIndex = 7;
            this.TabPage6.Text = "صيانة واصلاح";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.ButtonFIX.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFIX.FlatStyle = FlatStyle.Flat;
            this.ButtonFIX.Image = A.F.ImCard;
            this.ButtonFIX.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFIX.Location = new Point(0x15, 60);
            this.ButtonFIX.Name = "ButtonFIX";
            this.ButtonFIX.Size = new Size(600, 0x35);
            this.ButtonFIX.TabIndex = 5;
            this.ButtonFIX.Text = "فتح معالج الصيانة والاصلاح";
            this.ButtonFIX.UseVisualStyleBackColor = true;
            this.TxTUserID.Location = new Point(0x117, 0x247);
            this.TxTUserID.Name = "TxTUserID";
            this.TxTUserID.Size = new Size(100, 0x17);
            this.TxTUserID.TabIndex = 0x68;
            this.GroupBox4.Controls.Add(this.ButtonChaneName);
            this.GroupBox4.Controls.Add(this.TxTCenterName);
            this.GroupBox4.Dock = DockStyle.Top;
            this.GroupBox4.Location = new Point(0, 0x22);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(650, 0x40);
            this.GroupBox4.TabIndex = 0x69;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "الأسم الرئيسي للمتجر";
            this.ButtonChaneName.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonChaneName.Enabled = false;
            this.ButtonChaneName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonChaneName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonChaneName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonChaneName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonChaneName.FlatStyle = FlatStyle.Flat;
            this.ButtonChaneName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonChaneName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonChaneName.Location = new Point(4, 0x16);
            this.ButtonChaneName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonChaneName.Name = "ButtonChaneName";
            this.ButtonChaneName.Size = new Size(0x6a, 0x1f);
            this.ButtonChaneName.TabIndex = 0x6b;
            this.ButtonChaneName.Text = "تحديث الاسم";
            this.ButtonChaneName.UseVisualStyleBackColor = false;
            this.TxTCenterName.BackColor = SystemColors.Info;
            this.TxTCenterName.Enabled = false;
            this.TxTCenterName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCenterName.Location = new Point(0x74, 0x1a);
            this.TxTCenterName.MaxLength = 50;
            this.TxTCenterName.Name = "TxTCenterName";
            this.TxTCenterName.Size = new Size(0x205, 0x17);
            this.TxTCenterName.TabIndex = 0x24;
            this.TxTCenterName.TextAlign = HorizontalAlignment.Center;
            this.IsForgetPass.AutoSize = true;
            this.IsForgetPass.Location = new Point(0x1d2, 0x238);
            this.IsForgetPass.Name = "IsForgetPass";
            this.IsForgetPass.Size = new Size(0x58, 20);
            this.IsForgetPass.TabIndex = 0x6a;
            this.IsForgetPass.Text = "CheckBox1";
            this.IsForgetPass.UseVisualStyleBackColor = true;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(4, 0x1fc);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x1cd, 0x2d);
            this.ButtonOk.TabIndex = 0x65;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x1d7, 0x1fc);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xac, 0x2d);
            this.ButtonClose.TabIndex = 100;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.WebBrowser1.Location = new Point(0x31, 0x298);
            this.WebBrowser1.MinimumSize = new Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.Size = new Size(250, 250);
            this.WebBrowser1.TabIndex = 0x6b;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(650, 0x232);
            base.ControlBox = false;
            base.Controls.Add(this.WebBrowser1);
            base.Controls.Add(this.IsForgetPass);
            base.Controls.Add(this.TxTUserID);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SettingAdmin";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "الإعدادات الرئيسية والمدير العام";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890asdfghjklzxcvbnmqwertyuiop".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.I.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void A(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            this.TxTCenterName.Text = this.WebBrowser1.DocumentTitle;
            Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
        }

        private void D(object A, EventArgs R)
        {
            // Invalid method body.
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

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void E(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void F(object A, EventArgs R)
        {
            if (PR.Q)
            {
                Interaction.MsgBox("اتصل على رقم المندوب\r\n" + PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                A.D.A.A.ShowDialog();
            }
        }

        private void G(object A, EventArgs R)
        {
            this.ButtonrRest.Enabled = this.CheckBoxRest.Checked;
        }

        private void H(object A, EventArgs R)
        {
            if (!PR.P)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                try
                {
                    this.WebBrowser1.Navigate("https://yazsys.com/ChangeName.aspx?ChangName=" + PR.Z);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox("يجب ان يكون لديك اتصال في الانترنت | او ان خادم yazsys مشغول  في الوقت الحالي >> حاول لاحقا" + ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void I(object A, EventArgs R)
        {
            if ((((this.TxTUserLog.Text == null) | (this.TxTUserName.Text == null)) | (this.TxTUserPass.Text == null)) | (this.TxTCenterName.Text == null))
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE [TaNNUsers] SET [UserName] = @UserName, [UserLog] = @UserLog, [UserPass] = @UserPass WHERE [UserID] = @UserID", this.A);
                    command.Parameters.AddWithValue("UserID", this.TxTUserID.Text);
                    command.Parameters.AddWithValue("UserName", this.TxTUserName.Text.Trim());
                    command.Parameters.AddWithValue("UserLog", this.TxTUserLog.Text.Trim());
                    command.Parameters.AddWithValue("UserPass", this.A.A(this.TxTUserPass.Text.Trim()));
                    SqlCommand command2 = new SqlCommand("UPDATE TaNNCenters SET CenterName =@CenterName WHERE (CenterEditName = @CenterEditName)", this.A);
                    command2.Parameters.AddWithValue("CenterEditName", "1200");
                    command2.Parameters.AddWithValue("CenterName", this.TxTCenterName.Text);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    this.A.Close();
                    PR.ER = this.TxTCenterName.Text;
                    A.D.A.A.PanelHedar.Text = this.TxTCenterName.Text;
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    Interaction.MsgBox("خطأ في عملية الإضافة، تأكد ان اسم الدخول غير مكرر مع اسم موظف آخر", MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void K(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void P(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void R(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890asdfghjklzxcvbnmqwertyuiop".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.I.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void T(object A, EventArgs R)
        {
            A.D.A.A.TabControl1.SelectedIndex = 1;
            A.D.A.A.ShowDialog();
        }

        private void U(object A, EventArgs R)
        {
            if (PR.Z == null)
            {
                Interaction.MsgBox("يجب ان يكون لديك رقم متسلسل. وان تكون هذه النسخة مرخصة", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/POS/DBSetOut.aspx?DBSerialNumber=" + PR.Z.ToString());
            }
        }

        private void X(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonOk
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual PictureBox PictureBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTUserPass
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
                TextBox a = this.A;
                if (a != null)
                {
                    a.KeyPress -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyPress += handler;
                }
            }
        }

        internal virtual Label Label10
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label8
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTUserLog
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox r = this.R;
                if (r != null)
                {
                    r.KeyPress -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.KeyPress += handler;
                }
            }
        }

        internal virtual TextBox TxTUserName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual TabPage TabPage2
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

        internal virtual Button ButtonCenters
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual Button ButtonDb
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual Button ButtonCon
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTUserID
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTCenterName
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox IsForgetPass
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonHelpSQL
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual Button ButtonChaneName
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                Button f = this.F;
                if (f != null)
                {
                    f.Click -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.Click += handler;
                }
            }
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

        internal virtual Button ButtonImport
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                Button h = this.H;
                if (h != null)
                {
                    h.Click -= handler;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.Click += handler;
                }
            }
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

        internal virtual CheckBox CheckBoxRest
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                CheckBox r = this.R;
                if (r != null)
                {
                    r.CheckedChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.CheckedChanged += handler;
                }
            }
        }

        internal virtual Button ButtonrRest
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                Button t = this.T;
                if (t != null)
                {
                    t.Click -= handler;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.Click += handler;
                }
            }
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

        internal virtual Button ButtonFIX
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                Button x = this.X;
                if (x != null)
                {
                    x.Click -= handler;
                }
                this.X = value;
                x = this.X;
                if (x != null)
                {
                    x.Click += handler;
                }
            }
        }

        internal virtual Button ButtonW
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                Button g = this.G;
                if (g != null)
                {
                    g.Click -= handler;
                }
                this.G = value;
                g = this.G;
                if (g != null)
                {
                    g.Click += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowser1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                WebBrowserDocumentCompletedEventHandler handler = new WebBrowserDocumentCompletedEventHandler(this.A);
                WebBrowser a = this.A;
                if (a != null)
                {
                    a.DocumentCompleted -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.DocumentCompleted += handler;
                }
            }
        }
    }
}

