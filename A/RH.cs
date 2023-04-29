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
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class RH : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxQ"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("TxTQ"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxS"), CompilerGenerated]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTS")]
        private TextBox R;
        [AccessedThroughProperty("GroupBoxDis1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDisMiWi")]
        private TextBox P;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxDis2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTDisVal")]
        private TextBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("ButtonOk"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox I;
        [AccessedThroughProperty("TxtDarVal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDarMiWi")]
        private TextBox D;
        [AccessedThroughProperty("CheckBoxEditeQQ"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1"), CompilerGenerated]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("TabPageS"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [CompilerGenerated, AccessedThroughProperty("TabPageQ"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [AccessedThroughProperty("TabPageDis"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPageDar")]
        private TabPage Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("LabelTipS")]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LabelTipQ")]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("LabelTipDis")]
        private Label Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonAddLess"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label I;
        [AccessedThroughProperty("CheckBoxShowToutch"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonAddCost"), CompilerGenerated]
        private Button Q;
        private SqlConnection A;
        public static int A = 0;
        public static int R = 0;
        private TextBox F;
        private TextBox H;
        private TextBox T;
        private TextBox X;
        private TextBox G;
        private TextBox E;
        private TextBox K;
        private TextBox U;
        private TextBox L;
        private CheckBox P;
        private TextBox N;
        private TextBox V;
        private CheckBox Q;
        private TextBox Y;
        private TextBox O;
        private TextBox B;
        private TextBox S;
        private TextBox Z;
        private TextBox M;
        private TextBox C;
        private TextBox J;
        private TextBox W;
        private TextBox AR;
        private TextBox PR;
        private TextBox QR;
        private TextBox IR;
        private TextBox DR;
        private CheckBox I;
        private TextBox FR;
        private TextBox HR;

        public RH()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.Q);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.F = new TextBox();
            this.H = new TextBox();
            this.T = new TextBox();
            this.X = new TextBox();
            this.G = new TextBox();
            this.E = new TextBox();
            this.K = new TextBox();
            this.U = new TextBox();
            this.L = new TextBox();
            this.P = new CheckBox();
            this.N = new TextBox();
            this.V = new TextBox();
            this.Q = new CheckBox();
            this.Y = new TextBox();
            this.O = new TextBox();
            this.B = new TextBox();
            this.S = new TextBox();
            this.Z = new TextBox();
            this.M = new TextBox();
            this.C = new TextBox();
            this.J = new TextBox();
            this.W = new TextBox();
            this.AR = new TextBox();
            this.PR = new TextBox();
            this.QR = new TextBox();
            this.IR = new TextBox();
            this.DR = new TextBox();
            this.I = new CheckBox();
            this.FR = new TextBox();
            this.HR = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.GroupBoxQ = new GroupBox();
            this.TxTQ = new TextBox();
            this.GroupBoxS = new GroupBox();
            this.ButtonAddCost = new Button();
            this.ButtonAddLess = new Button();
            this.CheckBoxEditeQQ = new CheckBox();
            this.TxTS = new TextBox();
            this.GroupBoxDis1 = new GroupBox();
            this.TxTDisMiWi = new TextBox();
            this.GroupBoxDis2 = new GroupBox();
            this.TxTDisVal = new TextBox();
            this.TxTTitle = new Label();
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.GroupBox5 = new GroupBox();
            this.TxtDarVal = new TextBox();
            this.GroupBox6 = new GroupBox();
            this.TxTDarMiWi = new TextBox();
            this.TabControl1 = new TabControl();
            this.TabPageS = new TabPage();
            this.LabelTipS = new Label();
            this.TabPageQ = new TabPage();
            this.LabelTipQ = new Label();
            this.TabPageDis = new TabPage();
            this.LabelTipDis = new Label();
            this.TabPageDar = new TabPage();
            this.Label1 = new Label();
            this.CheckBoxShowToutch = new CheckBox();
            this.GroupBoxQ.SuspendLayout();
            this.GroupBoxS.SuspendLayout();
            this.GroupBoxDis1.SuspendLayout();
            this.GroupBoxDis2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPageS.SuspendLayout();
            this.TabPageQ.SuspendLayout();
            this.TabPageDis.SuspendLayout();
            this.TabPageDar.SuspendLayout();
            base.SuspendLayout();
            this.GroupBoxQ.Controls.Add(this.TxTQ);
            this.GroupBoxQ.Dock = DockStyle.Top;
            this.GroupBoxQ.Location = new Point(3, 40);
            this.GroupBoxQ.Name = "GroupBoxQ";
            this.GroupBoxQ.Size = new Size(0x1a2, 0x3a);
            this.GroupBoxQ.TabIndex = 0;
            this.GroupBoxQ.TabStop = false;
            this.GroupBoxQ.Text = "الكمية";
            this.TxTQ.BackColor = SystemColors.Info;
            this.TxTQ.Dock = DockStyle.Fill;
            this.TxTQ.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTQ.Location = new Point(3, 0x13);
            this.TxTQ.MaxLength = 20;
            this.TxTQ.Name = "TxTQ";
            this.TxTQ.RightToLeft = RightToLeft.No;
            this.TxTQ.Size = new Size(0x19c, 0x1a);
            this.TxTQ.TabIndex = 1;
            this.TxTQ.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxS.Controls.Add(this.ButtonAddCost);
            this.GroupBoxS.Controls.Add(this.ButtonAddLess);
            this.GroupBoxS.Controls.Add(this.CheckBoxEditeQQ);
            this.GroupBoxS.Controls.Add(this.TxTS);
            this.GroupBoxS.Dock = DockStyle.Top;
            this.GroupBoxS.Location = new Point(3, 40);
            this.GroupBoxS.Name = "GroupBoxS";
            this.GroupBoxS.Size = new Size(0x1a2, 0xc3);
            this.GroupBoxS.TabIndex = 0;
            this.GroupBoxS.TabStop = false;
            this.GroupBoxS.Text = "السعر";
            this.ButtonAddCost.Location = new Point(10, 0x8b);
            this.ButtonAddCost.Name = "ButtonAddCost";
            this.ButtonAddCost.Size = new Size(0x192, 0x23);
            this.ButtonAddCost.TabIndex = 4;
            this.ButtonAddCost.Text = "اضافة سعر التكلفة";
            this.ButtonAddCost.UseVisualStyleBackColor = true;
            this.ButtonAddLess.Location = new Point(10, 0x62);
            this.ButtonAddLess.Name = "ButtonAddLess";
            this.ButtonAddLess.Size = new Size(0x192, 0x23);
            this.ButtonAddLess.TabIndex = 3;
            this.ButtonAddLess.Text = "اضافة سعر البيع المخفض";
            this.ButtonAddLess.UseVisualStyleBackColor = true;
            this.CheckBoxEditeQQ.AutoSize = true;
            this.CheckBoxEditeQQ.Location = new Point(0x85, 0x3d);
            this.CheckBoxEditeQQ.Name = "CheckBoxEditeQQ";
            this.CheckBoxEditeQQ.Size = new Size(0x117, 20);
            this.CheckBoxEditeQQ.TabIndex = 2;
            this.CheckBoxEditeQQ.Text = "قم بتعديل الكمية حسب السعر الذي احدده هنا";
            this.CheckBoxEditeQQ.UseVisualStyleBackColor = true;
            this.TxTS.BackColor = SystemColors.Info;
            this.TxTS.Dock = DockStyle.Top;
            this.TxTS.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTS.Location = new Point(3, 0x13);
            this.TxTS.MaxLength = 20;
            this.TxTS.Name = "TxTS";
            this.TxTS.RightToLeft = RightToLeft.No;
            this.TxTS.Size = new Size(0x19c, 0x1a);
            this.TxTS.TabIndex = 1;
            this.TxTS.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxDis1.Controls.Add(this.TxTDisMiWi);
            this.GroupBoxDis1.Dock = DockStyle.Top;
            this.GroupBoxDis1.Location = new Point(0, 0x25);
            this.GroupBoxDis1.Name = "GroupBoxDis1";
            this.GroupBoxDis1.Size = new Size(0x1a8, 0x39);
            this.GroupBoxDis1.TabIndex = 0;
            this.GroupBoxDis1.TabStop = false;
            this.GroupBoxDis1.Text = "الخصم %";
            this.TxTDisMiWi.BackColor = SystemColors.Info;
            this.TxTDisMiWi.Dock = DockStyle.Fill;
            this.TxTDisMiWi.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDisMiWi.Location = new Point(3, 0x13);
            this.TxTDisMiWi.MaxLength = 20;
            this.TxTDisMiWi.Name = "TxTDisMiWi";
            this.TxTDisMiWi.RightToLeft = RightToLeft.No;
            this.TxTDisMiWi.Size = new Size(0x1a2, 0x1a);
            this.TxTDisMiWi.TabIndex = 1;
            this.TxTDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxDis2.Controls.Add(this.TxTDisVal);
            this.GroupBoxDis2.Dock = DockStyle.Top;
            this.GroupBoxDis2.Location = new Point(0, 0x5e);
            this.GroupBoxDis2.Name = "GroupBoxDis2";
            this.GroupBoxDis2.Size = new Size(0x1a8, 0x39);
            this.GroupBoxDis2.TabIndex = 4;
            this.GroupBoxDis2.TabStop = false;
            this.GroupBoxDis2.Text = "مبلغ الخصم";
            this.TxTDisVal.BackColor = SystemColors.Info;
            this.TxTDisVal.Dock = DockStyle.Fill;
            this.TxTDisVal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDisVal.Location = new Point(3, 0x13);
            this.TxTDisVal.MaxLength = 20;
            this.TxTDisVal.Name = "TxTDisVal";
            this.TxTDisVal.RightToLeft = RightToLeft.No;
            this.TxTDisVal.Size = new Size(0x1a2, 0x1a);
            this.TxTDisVal.TabIndex = 2;
            this.TxTDisVal.TextAlign = HorizontalAlignment.Center;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1b0, 0x24);
            this.TxTTitle.TabIndex = 0x4e;
            this.TxTTitle.Text = "Edite";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(10, 340);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0xf4, 0x2c);
            this.ButtonOk.TabIndex = 0x51;
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
            this.ButtonClose.Location = new Point(0x103, 340);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xa3, 0x2c);
            this.ButtonClose.TabIndex = 80;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.TxtDarVal);
            this.GroupBox5.Dock = DockStyle.Top;
            this.GroupBox5.Enabled = false;
            this.GroupBox5.Location = new Point(0, 0x5e);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x1a8, 0x39);
            this.GroupBox5.TabIndex = 0x53;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "مبلغ الضريبة";
            this.TxtDarVal.BackColor = SystemColors.Info;
            this.TxtDarVal.Dock = DockStyle.Fill;
            this.TxtDarVal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtDarVal.Location = new Point(3, 0x13);
            this.TxtDarVal.MaxLength = 20;
            this.TxtDarVal.Name = "TxtDarVal";
            this.TxtDarVal.RightToLeft = RightToLeft.No;
            this.TxtDarVal.Size = new Size(0x1a2, 0x1a);
            this.TxtDarVal.TabIndex = 1;
            this.TxtDarVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox6.Controls.Add(this.TxTDarMiWi);
            this.GroupBox6.Dock = DockStyle.Top;
            this.GroupBox6.Location = new Point(0, 0x25);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x1a8, 0x39);
            this.GroupBox6.TabIndex = 0x52;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "الضريبة %";
            this.TxTDarMiWi.BackColor = SystemColors.Info;
            this.TxTDarMiWi.Dock = DockStyle.Fill;
            this.TxTDarMiWi.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDarMiWi.Location = new Point(3, 0x13);
            this.TxTDarMiWi.MaxLength = 20;
            this.TxTDarMiWi.Name = "TxTDarMiWi";
            this.TxTDarMiWi.RightToLeft = RightToLeft.No;
            this.TxTDarMiWi.Size = new Size(0x1a2, 0x1a);
            this.TxTDarMiWi.TabIndex = 1;
            this.TxTDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.TabControl1.Controls.Add(this.TabPageS);
            this.TabControl1.Controls.Add(this.TabPageQ);
            this.TabControl1.Controls.Add(this.TabPageDis);
            this.TabControl1.Controls.Add(this.TabPageDar);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x24);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 10);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x1b0, 0x11c);
            this.TabControl1.TabIndex = 0x54;
            this.TabPageS.Controls.Add(this.GroupBoxS);
            this.TabPageS.Controls.Add(this.LabelTipS);
            this.TabPageS.Location = new Point(4, 0x27);
            this.TabPageS.Name = "TabPageS";
            this.TabPageS.Padding = new Padding(3);
            this.TabPageS.Size = new Size(0x1a8, 0xf1);
            this.TabPageS.TabIndex = 0;
            this.TabPageS.Text = "تعديل السعر";
            this.TabPageS.UseVisualStyleBackColor = true;
            this.LabelTipS.Dock = DockStyle.Top;
            this.LabelTipS.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelTipS.ForeColor = Color.Red;
            this.LabelTipS.Location = new Point(3, 3);
            this.LabelTipS.Name = "LabelTipS";
            this.LabelTipS.Size = new Size(0x1a2, 0x25);
            this.LabelTipS.TabIndex = 3;
            this.LabelTipS.Text = "غير مسموح لك بتعديل السعر من المدير العام";
            this.LabelTipS.TextAlign = ContentAlignment.MiddleCenter;
            this.LabelTipS.Visible = false;
            this.TabPageQ.Controls.Add(this.GroupBoxQ);
            this.TabPageQ.Controls.Add(this.LabelTipQ);
            this.TabPageQ.Location = new Point(4, 0x27);
            this.TabPageQ.Name = "TabPageQ";
            this.TabPageQ.Padding = new Padding(3);
            this.TabPageQ.Size = new Size(0x1a8, 0xf1);
            this.TabPageQ.TabIndex = 1;
            this.TabPageQ.Text = "تعديل الكمية";
            this.TabPageQ.UseVisualStyleBackColor = true;
            this.LabelTipQ.Dock = DockStyle.Top;
            this.LabelTipQ.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelTipQ.ForeColor = Color.Red;
            this.LabelTipQ.Location = new Point(3, 3);
            this.LabelTipQ.Name = "LabelTipQ";
            this.LabelTipQ.Size = new Size(0x1a2, 0x25);
            this.LabelTipQ.TabIndex = 4;
            this.LabelTipQ.Text = "غير مسموح لك بتعديل الكمية من المدير العام";
            this.LabelTipQ.TextAlign = ContentAlignment.MiddleCenter;
            this.LabelTipQ.Visible = false;
            this.TabPageDis.Controls.Add(this.GroupBoxDis2);
            this.TabPageDis.Controls.Add(this.GroupBoxDis1);
            this.TabPageDis.Controls.Add(this.LabelTipDis);
            this.TabPageDis.Location = new Point(4, 0x27);
            this.TabPageDis.Name = "TabPageDis";
            this.TabPageDis.Size = new Size(0x1a8, 0xf1);
            this.TabPageDis.TabIndex = 2;
            this.TabPageDis.Text = "تعديل الخصم";
            this.TabPageDis.UseVisualStyleBackColor = true;
            this.LabelTipDis.Dock = DockStyle.Top;
            this.LabelTipDis.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelTipDis.ForeColor = Color.Red;
            this.LabelTipDis.Location = new Point(0, 0);
            this.LabelTipDis.Name = "LabelTipDis";
            this.LabelTipDis.Size = new Size(0x1a8, 0x25);
            this.LabelTipDis.TabIndex = 5;
            this.LabelTipDis.Text = "غير مسموح لك بتعديل الخصم من المدير العام";
            this.LabelTipDis.TextAlign = ContentAlignment.MiddleCenter;
            this.LabelTipDis.Visible = false;
            this.TabPageDar.Controls.Add(this.GroupBox5);
            this.TabPageDar.Controls.Add(this.GroupBox6);
            this.TabPageDar.Controls.Add(this.Label1);
            this.TabPageDar.Location = new Point(4, 0x27);
            this.TabPageDar.Name = "TabPageDar";
            this.TabPageDar.Size = new Size(0x1a8, 0xf1);
            this.TabPageDar.TabIndex = 3;
            this.TabPageDar.Text = "بيانات الضريبة";
            this.TabPageDar.UseVisualStyleBackColor = true;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Blue;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x1a8, 0x25);
            this.Label1.TabIndex = 0x54;
            this.Label1.Text = "تحسب الضريبة من النسبة المحددة في المستودع";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.Visible = false;
            this.CheckBoxShowToutch.AutoSize = true;
            this.CheckBoxShowToutch.BackColor = Color.WhiteSmoke;
            this.CheckBoxShowToutch.Dock = DockStyle.Bottom;
            this.CheckBoxShowToutch.Location = new Point(0, 0x187);
            this.CheckBoxShowToutch.Name = "CheckBoxShowToutch";
            this.CheckBoxShowToutch.Padding = new Padding(5);
            this.CheckBoxShowToutch.Size = new Size(0x1b0, 30);
            this.CheckBoxShowToutch.TabIndex = 110;
            this.CheckBoxShowToutch.Text = "اظهار لوحة المفاتيح لشاشة اللمس";
            this.CheckBoxShowToutch.UseVisualStyleBackColor = false;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x1b0, 0x1a5);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxShowToutch);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleEditeItems";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تعديل";
            this.GroupBoxQ.ResumeLayout(false);
            this.GroupBoxQ.PerformLayout();
            this.GroupBoxS.ResumeLayout(false);
            this.GroupBoxS.PerformLayout();
            this.GroupBoxDis1.ResumeLayout(false);
            this.GroupBoxDis1.PerformLayout();
            this.GroupBoxDis2.ResumeLayout(false);
            this.GroupBoxDis2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPageS.ResumeLayout(false);
            this.TabPageQ.ResumeLayout(false);
            this.TabPageDis.ResumeLayout(false);
            this.TabPageDar.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void D()
        {
            if (A.PR.MR && this.CheckBoxShowToutch.Checked)
            {
                CD cd2 = new CD {
                    R = this.TxTDisVal
                };
                cd2.SetDesktopLocation(this.TxTDisVal.Location.X - this.TxTDisVal.PointToClient(new Point(this.TxTDisVal.Cursor.HotSpot.X, this.TxTDisVal.Cursor.HotSpot.Y)).X, (this.TxTDisVal.Location.Y - this.TxTDisVal.PointToClient(new Point(this.TxTDisVal.Cursor.HotSpot.X, this.TxTDisVal.Cursor.HotSpot.Y)).Y) + 10);
                cd2.Show();
                cd2 = null;
            }
        }

        private void D(object A, EventArgs R)
        {
            this.P();
        }

        private void D(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
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
            A.AR.PR = this.CheckBoxShowToutch.Checked;
        }

        private void F()
        {
            if (A.PR.CR && this.CheckBoxShowToutch.Checked)
            {
                CD cd2 = new CD {
                    R = this.TxTDarMiWi
                };
                cd2.SetDesktopLocation(this.TxTDarMiWi.Location.X - this.TxTDarMiWi.PointToClient(new Point(this.TxTDarMiWi.Cursor.HotSpot.X, this.TxTDarMiWi.Cursor.HotSpot.Y)).X, (this.TxTDarMiWi.Location.Y - this.TxTDarMiWi.PointToClient(new Point(this.TxTDarMiWi.Cursor.HotSpot.X, this.TxTDarMiWi.Cursor.HotSpot.Y)).Y) + 10);
                cd2.Show();
                cd2 = null;
            }
        }

        private void F(object A, EventArgs R)
        {
            this.Q();
        }

        private void G(object A, EventArgs R)
        {
            if (A.PR.SP)
            {
                this.TxTS.Text = this.K.Text;
            }
            else
            {
                Interaction.MsgBox("غير مسموح لك بعرض سعر التكلفة من صلاحيات المسؤول", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void H(object A, EventArgs R)
        {
            this.I();
        }

        private void I()
        {
            if (A.PR.MR && this.CheckBoxShowToutch.Checked)
            {
                CD cd2 = new CD {
                    R = this.TxTDisMiWi
                };
                cd2.SetDesktopLocation(this.TxTDisMiWi.Location.X - this.TxTDisMiWi.PointToClient(new Point(this.TxTDisMiWi.Cursor.HotSpot.X, this.TxTDisMiWi.Cursor.HotSpot.Y)).X, (this.TxTDisMiWi.Location.Y - this.TxTDisMiWi.PointToClient(new Point(this.TxTDisMiWi.Cursor.HotSpot.X, this.TxTDisMiWi.Cursor.HotSpot.Y)).Y) + 10);
                cd2.Show();
                cd2 = null;
            }
        }

        private void I(object A, EventArgs R)
        {
            if (!(Conversion.Val(Conversions.ToDouble(this.U.Text.Replace(",", "")) > 0.0) == 0.0))
            {
                this.TxTS.Text = this.U.Text;
            }
            else
            {
                Interaction.MsgBox("لم يتم تحديد سعر بيع مخفض لهذه المادة", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void P()
        {
            if (A.PR.SR && this.CheckBoxShowToutch.Checked)
            {
                CD cd2 = new CD {
                    R = this.TxTS
                };
                cd2.SetDesktopLocation(this.TxTS.Location.X - this.TxTS.PointToClient(new Point(this.TxTS.Cursor.HotSpot.X, this.TxTS.Cursor.HotSpot.Y)).X, (this.TxTS.Location.Y - this.TxTS.PointToClient(new Point(this.TxTS.Cursor.HotSpot.X, this.TxTS.Cursor.HotSpot.Y)).Y) + 10);
                cd2.ShowDialog();
                cd2 = null;
            }
        }

        private void P(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void Q()
        {
            if (this.CheckBoxShowToutch.Checked)
            {
                CD cd2 = new CD {
                    R = this.TxTQ
                };
                cd2.SetDesktopLocation(this.TxTQ.Location.X - this.TxTQ.PointToClient(new Point(this.TxTQ.Cursor.HotSpot.X, this.TxTQ.Cursor.HotSpot.Y)).X, (this.TxTQ.Location.Y - this.TxTQ.PointToClient(new Point(this.TxTQ.Cursor.HotSpot.X, this.TxTQ.Cursor.HotSpot.Y)).Y) + 10);
                cd2.ShowDialog();
                cd2 = null;
            }
        }

        private void Q(object A, EventArgs R)
        {
            if (!Application.OpenForms.OfType<TH>().Any<TH>())
            {
                if (RH.R == 0)
                {
                    this.TabControl1.SelectedIndex = 0;
                    this.TabControl1.SelectedTab = this.TabPageS;
                    this.TxTS.TabIndex = 0;
                    this.TxTS.Select();
                    this.TxTS.Focus();
                    this.P();
                }
                if (RH.R == 1)
                {
                    this.TabControl1.SelectedIndex = 1;
                    this.TabControl1.SelectedTab = this.TabPageQ;
                    this.TxTQ.TabIndex = 0;
                    this.TxTQ.Select();
                    this.TxTQ.Focus();
                    this.Q();
                }
                if (RH.R == 2)
                {
                    this.TabControl1.SelectedIndex = 2;
                    this.TabControl1.SelectedTab = this.TabPageDis;
                    this.TxTDisMiWi.TabIndex = 0;
                    this.TxTDisMiWi.Focus();
                }
                if (RH.R == 3)
                {
                    this.TabControl1.SelectedIndex = 3;
                    this.TabControl1.SelectedTab = this.TabPageDar;
                    this.TxTDarMiWi.TabIndex = 0;
                    this.TxTDarMiWi.Focus();
                    this.F();
                }
            }
        }

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void R()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvSaleItems] WHERE ([HSaleID] = @HSaleID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("HSaleID", A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    Interaction.MsgBox("خطأ في تحديد المادة من الفاتورة", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    this.S.Text = dataTable.Rows[0]["HSaleID"].ToString();
                    this.Z.Text = dataTable.Rows[0]["HSaleBarCode"].ToString();
                    this.M.Text = dataTable.Rows[0]["HSaleName"].ToString();
                    this.C.Text = dataTable.Rows[0]["HSalePrice"].ToString();
                    this.J.Text = dataTable.Rows[0]["HSaleQuantity"].ToString();
                    this.W.Text = dataTable.Rows[0]["HSalePriceTotal"].ToString();
                    this.AR.Text = dataTable.Rows[0]["HSaleDisMiaWi"].ToString();
                    this.PR.Text = dataTable.Rows[0]["HSaleDisVal"].ToString();
                    this.QR.Text = dataTable.Rows[0]["HSaleDarMiaWi"].ToString();
                    this.IR.Text = dataTable.Rows[0]["HSaleDarVal"].ToString();
                    this.DR.Text = dataTable.Rows[0]["HSaleNetProft"].ToString();
                    this.I.Checked = Conversions.ToBoolean(dataTable.Rows[0]["HSaleIsDelete"].ToString());
                    this.FR.Text = dataTable.Rows[0]["HSaleNETTotal"].ToString();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable table2 = new DataTable();
                    string str2 = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                    table2.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    adapter2.SelectCommand.Parameters.AddWithValue("MaterialBarCode", this.Z.Text);
                    adapter2.Fill(table2);
                    this.A.Close();
                    if (table2.Rows.Count <= 0)
                    {
                        Interaction.MsgBox("لم يتم العثور على المادة في المستودع", MsgBoxStyle.ApplicationModal, null);
                        base.Dispose();
                    }
                    else
                    {
                        this.F.Text = table2.Rows[0]["MaterialID"].ToString();
                        this.H.Text = table2.Rows[0]["GroupIDFrontID"].ToString();
                        this.T.Text = table2.Rows[0]["MaterialBarCode"].ToString();
                        this.X.Text = table2.Rows[0]["MaterialName"].ToString();
                        this.G.Text = table2.Rows[0]["MaterialQuantity"].ToString();
                        this.E.Text = table2.Rows[0]["MaterialUnit"].ToString();
                        this.K.Text = table2.Rows[0]["MaterialPricCost"].ToString();
                        this.U.Text = table2.Rows[0]["MaterialPricLess"].ToString();
                        this.L.Text = table2.Rows[0]["MaterialPricSale"].ToString();
                        this.P.Checked = Conversions.ToBoolean(table2.Rows[0]["MaterialIsStop"].ToString());
                        this.N.Text = table2.Rows[0]["MaterialExpDate"].ToString();
                        this.V.Text = table2.Rows[0]["MaterialNote"].ToString();
                        this.Q.Checked = Conversions.ToBoolean(table2.Rows[0]["MaterialNotIsView"].ToString());
                        this.Y.Text = table2.Rows[0]["MaterialQuantityOffer"].ToString();
                        this.O.Text = table2.Rows[0]["MaterialDisMiWi"].ToString();
                        this.B.Text = table2.Rows[0]["MaterialDarMiWi"].ToString();
                        this.TxTTitle.Text = this.M.Text;
                        decimal num = new decimal(Conversion.Val(this.J.Text.Replace(",", "")));
                        decimal num2 = new decimal(Conversion.Val(this.C.Text.Replace(",", "")));
                        decimal num3 = new decimal(Conversion.Val(this.PR.Text.Replace(",", "")));
                        decimal num4 = new decimal(Conversion.Val(this.IR.Text.Replace(",", "")));
                        this.TxTQ.Text = Conversions.ToString(num);
                        this.J.Text = Conversions.ToString(num);
                        this.TxTS.Text = Conversions.ToString(num2);
                        this.C.Text = Conversions.ToString(num2);
                        this.TxtDarVal.Text = Conversions.ToString(num4);
                        this.IR.Text = Conversions.ToString(num4);
                        this.TxTDisVal.Text = Conversions.ToString(num3);
                        this.PR.Text = Conversions.ToString(num3);
                        this.TxTDisMiWi.Text = this.AR.Text;
                        this.TxTDarMiWi.Text = this.QR.Text;
                        if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                        {
                            this.HR.Text = Conversions.ToString((double) (Conversion.Val(this.G.Text) + Convert.ToDouble(num)));
                        }
                        else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                        {
                            this.HR.Text = Conversions.ToString((double) (Conversion.Val(this.G.Text) - Convert.ToDouble(num)));
                        }
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            if (!(!A.PR.QQ & (Conversion.Val(this.TxTQ.Text.Replace(",", "")) == 0.0)))
            {
                decimal num = new decimal(Conversion.Val(this.K.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.U.Text.Replace(",", "")));
                decimal num3 = new decimal(Conversion.Val(this.L.Text.Replace(",", "")));
                decimal num4 = new decimal(Conversion.Val(this.G.Text.Replace(",", "")));
                decimal num5 = new decimal(Conversion.Val(this.Y.Text.Replace(",", "")));
                decimal num6 = new decimal(Conversion.Val(this.O.Text.Replace(",", "")));
                decimal num7 = new decimal(Conversion.Val(this.B.Text.Replace(",", "")));
                decimal num8 = new decimal(Conversion.Val(this.C.Text.Replace(",", "")));
                decimal num9 = new decimal(Conversion.Val(this.J.Text.Replace(",", "")));
                decimal num10 = new decimal(Conversion.Val(this.AR.Text.Replace(",", "")));
                decimal num11 = new decimal(Conversion.Val(this.QR.Text.Replace(",", "")));
                decimal num12 = new decimal(Conversion.Val(this.TxTQ.Text.Replace(",", "")));
                decimal num13 = new decimal(Conversion.Val(this.TxTS.Text.Replace(",", "")));
                decimal num14 = 0M;
                decimal num15 = 0M;
                if ((this.TxTDisMiWi.Text == "-") | (this.TxTDisVal.Text == "-"))
                {
                    num14 = 0M;
                    num15 = 0M;
                }
                else
                {
                    num14 = new decimal(Conversion.Val(this.TxTDisMiWi.Text.Replace(",", "")));
                    num15 = new decimal(Conversion.Val(this.TxTDisVal.Text.Replace(",", "")));
                }
                decimal num16 = 0M;
                decimal num17 = 0M;
                if ((this.TxTDarMiWi.Text == "-") | (this.TxtDarVal.Text == "-"))
                {
                    num16 = 0M;
                    num17 = 0M;
                }
                else
                {
                    num16 = new decimal(Conversion.Val(this.TxTDarMiWi.Text.Replace(",", "")));
                    num17 = new decimal(Conversion.Val(this.TxtDarVal.Text.Replace(",", "")));
                }
                decimal num18 = 0M;
                decimal num19 = 0M;
                if (!this.CheckBoxEditeQQ.Checked)
                {
                    num13 = new decimal(Conversion.Val(this.TxTS.Text.Replace(",", "")));
                    num12 = new decimal(Conversion.Val(this.TxTQ.Text.Replace(",", "")));
                    num18 = decimal.Multiply(num, num12);
                    num19 = decimal.Multiply(num13, num12);
                }
                else
                {
                    num13 = new decimal(Conversion.Val(this.L.Text.Replace(",", "")));
                    num12 = new decimal(Conversion.Val(this.TxTS.Text.Replace(",", "")) / Conversion.Val(this.L.Text.Replace(",", "")));
                    this.TxTQ.Text = Conversions.ToString(num12);
                    num18 = decimal.Multiply(num, num12);
                    num19 = decimal.Multiply(num13, num12);
                }
                if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                {
                    decimal num26 = new decimal(Conversion.Val(this.HR.Text.Replace(",", "")));
                    if (!A.PR.B && (decimal.Compare(num12, num26) > 0))
                    {
                        Interaction.MsgBox("الكمية المطلوب بيعها اكبر من الكمية الحالية في المستودع", MsgBoxStyle.ApplicationModal, null);
                        if (Interaction.MsgBox("هل تريد فتح نافذة استعراض الوحدات لتحديد مواد مرتبطة معها (كرتونه، رزمة..الخ) لفتحها وترحيل كميتها لهذه المادة", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
                        {
                            XH.A = this.Z.Text;
                            A.D.A.A.ShowDialog();
                        }
                        return;
                    }
                }
                if (!((decimal.Compare(num5, decimal.Zero) > 0) & (decimal.Compare(num2, decimal.Zero) > 0)))
                {
                    num19 = num19;
                }
                else if (decimal.Compare(num12, num5) < 0)
                {
                    num19 = num19;
                }
                else
                {
                    num19 = decimal.Multiply(num2, num12);
                    num13 = num2;
                    this.TxTS.Text = Conversions.ToString(num2);
                }
                decimal num20 = 0M;
                if (decimal.Compare(num14, decimal.Zero) > 0)
                {
                    num15 = decimal.Multiply(num19, decimal.Divide(num14, new decimal((long) 100)));
                    this.TxTDisVal.Text = Conversions.ToString(num15);
                    num20 = decimal.Subtract(num19, num15);
                }
                else
                {
                    this.TxTDisVal.Text = Conversions.ToString(num15);
                    num20 = decimal.Subtract(num19, num15);
                }
                decimal num21 = 0M;
                decimal num22 = 0M;
                if (!(Conversions.ToDouble(A.PR.PP) == 0.0))
                {
                    if (Conversions.ToDouble(A.PR.PP) == 1.0)
                    {
                        num17 = decimal.Multiply(decimal.Multiply(new decimal((long) 100), decimal.Divide(num20, decimal.Add(new decimal((long) 100), num16))), decimal.Divide(num16, new decimal((long) 100)));
                        this.TxtDarVal.Text = Conversions.ToString(num17);
                        num22 = num20;
                        num21 = num18;
                    }
                }
                else
                {
                    if ((decimal.Compare(num20, decimal.Zero) > 0) & (decimal.Compare(num12, decimal.Zero) > 0))
                    {
                        num17 = decimal.Multiply(decimal.Multiply(decimal.Divide(num20, num12), decimal.Divide(num16, new decimal((long) 100))), num12);
                    }
                    else
                    {
                        num17 = 0M;
                    }
                    this.TxtDarVal.Text = Conversions.ToString(num17);
                    num22 = decimal.Add(num20, num17);
                    num21 = decimal.Add(num18, num17);
                }
                decimal num23 = num22;
                decimal num24 = decimal.Subtract(num22, num21);
                if (!A.PR.S && (decimal.Compare(num24, decimal.Zero) < 0))
                {
                    if (Application.OpenForms.OfType<TH>().Any<TH>())
                    {
                        base.Dispose();
                    }
                    else
                    {
                        Interaction.MsgBox("لا يسمح لك بتعديل السعر بأقل من سعر التكلفة او اضافة خصم يسبب خسارة من صلاحيات ادارة النظام ", MsgBoxStyle.ApplicationModal, null);
                    }
                }
                else
                {
                    decimal num25 = 0M;
                    if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                    {
                        num25 = new decimal(Conversion.Val(this.HR.Text) - Convert.ToDouble(num12));
                    }
                    else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                    {
                        num25 = new decimal(Conversion.Val(this.HR.Text) + Convert.ToDouble(num12));
                    }
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                    command.Parameters.AddWithValue("MaterialID", this.F.Text);
                    command.Parameters.AddWithValue("MaterialQuantity", num25.ToString(A.PR.OR));
                    command.ExecuteNonQuery();
                    this.A.Close();
                    num12 = decimal.Multiply(num12, decimal.One);
                    num19 = decimal.Multiply(num19, decimal.One);
                    num15 = decimal.Multiply(num15, decimal.One);
                    num17 = decimal.Multiply(num17, decimal.One);
                    num24 = decimal.Multiply(num24, decimal.One);
                    num23 = decimal.Multiply(num23, decimal.One);
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvSaleItems] SET [HSalePrice] = @HSalePrice, [HSaleQuantity] = @HSaleQuantity, [HSalePriceTotal] = @HSalePriceTotal, [HSaleDisMiaWi] = @HSaleDisMiaWi, [HSaleDisVal] = @HSaleDisVal, [HSaleDarMiaWi] = @HSaleDarMiaWi, [HSaleDarVal] = @HSaleDarVal, [HSaleNETTotal] = @HSaleNETTotal, [HSaleNetProft] = @HSaleNetProft WHERE [HSaleID] = @HSaleID", this.A);
                    command2.Parameters.AddWithValue("HSaleID", RH.A);
                    command2.Parameters.AddWithValue("HSalePrice", num13.ToString(A.PR.VR));
                    command2.Parameters.AddWithValue("HSaleQuantity", num12.ToString(A.PR.OR));
                    command2.Parameters.AddWithValue("HSalePriceTotal", num19.ToString(A.PR.VR));
                    if ((this.TxTDisMiWi.Text == "-") | (this.TxTDisVal.Text == "-"))
                    {
                        command2.Parameters.AddWithValue("HSaleDisMiaWi", "-");
                        command2.Parameters.AddWithValue("HSaleDisVal", "-");
                    }
                    else
                    {
                        command2.Parameters.AddWithValue("HSaleDisMiaWi", num14);
                        command2.Parameters.AddWithValue("HSaleDisVal", num15.ToString(A.PR.VR));
                    }
                    if ((this.TxTDarMiWi.Text == "-") | (this.TxtDarVal.Text == "-"))
                    {
                        command2.Parameters.AddWithValue("HSaleDarMiaWi", "-");
                        command2.Parameters.AddWithValue("HSaleDarVal", "-");
                    }
                    else
                    {
                        command2.Parameters.AddWithValue("HSaleDarMiaWi", num16);
                        command2.Parameters.AddWithValue("HSaleDarVal", num17.ToString(A.PR.VR));
                    }
                    command2.Parameters.AddWithValue("HSaleNETTotal", num23.ToString(A.PR.VR));
                    command2.Parameters.AddWithValue("HSaleNetProft", num24.ToString(A.PR.VR));
                    command2.ExecuteNonQuery();
                    this.A.Close();
                    if (Application.OpenForms.OfType<TH>().Any<TH>())
                    {
                        base.Dispose();
                    }
                    else
                    {
                        A.D.A.A.L();
                        base.Dispose();
                    }
                }
            }
            else
            {
                Interaction.MsgBox("غير مسموح لك في بيع مواد عندما تكون الكمية 0", MsgBoxStyle.ApplicationModal, null);
                this.TxTQ.Focus();
            }
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void T(object A, EventArgs R)
        {
            this.D();
        }

        private void X(object A, EventArgs R)
        {
            this.F();
        }

        internal virtual GroupBox GroupBoxQ
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTQ
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
                EventHandler handler2 = new EventHandler(this.F);
                TextBox a = this.A;
                if (a != null)
                {
                    a.KeyPress -= handler;
                    a.Click -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyPress += handler;
                    a.Click += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBoxS
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTS
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                EventHandler handler2 = new EventHandler(this.D);
                TextBox r = this.R;
                if (r != null)
                {
                    r.KeyPress -= handler;
                    r.Click -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.KeyPress += handler;
                    r.Click += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBoxDis1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.P);
                EventHandler handler2 = new EventHandler(this.H);
                TextBox p = this.P;
                if (p != null)
                {
                    p.KeyPress -= handler;
                    p.Click -= handler2;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.KeyPress += handler;
                    p.Click += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBoxDis2
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTDisVal
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.D);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.Click -= handler;
                    q.KeyPress -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Click += handler;
                    q.KeyPress += handler2;
                }
            }
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
                EventHandler handler = new EventHandler(this.R);
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
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TxtDarVal
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.I);
                TextBox i = this.I;
                if (i != null)
                {
                    i.KeyPress -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.KeyPress += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.Q);
                EventHandler handler2 = new EventHandler(this.X);
                TextBox d = this.D;
                if (d != null)
                {
                    d.KeyPress -= handler;
                    d.Click -= handler2;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.KeyPress += handler;
                    d.Click += handler2;
                }
            }
        }

        internal virtual CheckBox CheckBoxEditeQQ
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TabPage TabPageS
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPageQ
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TabPage TabPageDis
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TabPage TabPageDar
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label LabelTipS
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label LabelTipQ
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label LabelTipDis
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonAddLess
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CheckBoxShowToutch
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                CheckBox r = this.R;
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

        internal virtual Button ButtonAddCost
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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
    }
}

