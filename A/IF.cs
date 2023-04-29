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
    public class IF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("TabPage5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [AccessedThroughProperty("ToolStripStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [AccessedThroughProperty("TabPage6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [CompilerGenerated, AccessedThroughProperty("TabPage7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage Q;
        [AccessedThroughProperty("TabPage8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage I;
        [AccessedThroughProperty("TabPage9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage D;
        [AccessedThroughProperty("TabPage10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage F;
        [AccessedThroughProperty("ToolStripLabel2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTItems"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [CompilerGenerated, AccessedThroughProperty("TimerStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("TxTQNow"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [CompilerGenerated, AccessedThroughProperty("ButtonQNow"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox8"), CompilerGenerated]
        private GroupBox R;
        [CompilerGenerated, AccessedThroughProperty("TxTLessQ"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonQLess"), CompilerGenerated]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonGroup")]
        private Button P;
        [AccessedThroughProperty("ComboBoxGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("CheckBoxNoGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox A;
        [AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("ButtonDateExp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("ChKActiveDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox R;
        [AccessedThroughProperty("MaterialExpDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker A;
        [AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("CheckBoxViewNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox P;
        [AccessedThroughProperty("ButtonViewNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button I;
        [AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("TxTNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("ButtonNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button D;
        [AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [AccessedThroughProperty("CheckBoxStopSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox Q;
        [AccessedThroughProperty("ButtonStopSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button F;
        [AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox H;
        [AccessedThroughProperty("TxTDar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [AccessedThroughProperty("ButtonDar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button H;
        [AccessedThroughProperty("GroupBox15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox T;
        [AccessedThroughProperty("TxTDis"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox I;
        [AccessedThroughProperty("ButtonDis"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button T;
        [AccessedThroughProperty("TabPage11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage H;
        [AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox17"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox X;
        [AccessedThroughProperty("RadioButtonOnn"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private RadioButton A;
        [AccessedThroughProperty("RadioButtonBay"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private RadioButton R;
        [AccessedThroughProperty("GroupBox16"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox G;
        [AccessedThroughProperty("TxTDolar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox D;
        [AccessedThroughProperty("LabelTip"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("CheckBoxCon"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox I;
        [AccessedThroughProperty("TabPage12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage T;
        [AccessedThroughProperty("CheckBoxValLess"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox D;
        [AccessedThroughProperty("CheckBoxValSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox F;
        [AccessedThroughProperty("CheckBoxValCost"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox H;
        [AccessedThroughProperty("GroupBox18"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox E;
        [AccessedThroughProperty("TxTEditeSaleVal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox F;
        [AccessedThroughProperty("ButtonEditeSaleVal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button X;
        [AccessedThroughProperty("Label5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("TabPage13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage X;
        [AccessedThroughProperty("CheckBoxMiWiLess"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox T;
        [AccessedThroughProperty("CheckBoxMiWiSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox X;
        [AccessedThroughProperty("CheckBoxMiwiCost"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox G;
        [AccessedThroughProperty("ButtonMiwi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button G;
        [AccessedThroughProperty("GroupBox19"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox K;
        [AccessedThroughProperty("RadioButtonMiwiPlus"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private RadioButton P;
        [AccessedThroughProperty("RadioButtonMiwiMinas"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private RadioButton Q;
        [AccessedThroughProperty("TxTEditeSaleMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox H;
        [AccessedThroughProperty("CheckBoxLessDo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox E;
        [AccessedThroughProperty("CheckBoxSaleDo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox K;
        [AccessedThroughProperty("CheckBoxCostDo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox U;
        [AccessedThroughProperty("ButtonDo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button E;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label F;
        private SqlConnection A;
        private bool A;

        public IF()
        {
            base.Load += new EventHandler(this.P);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage11 = new TabPage();
            this.CheckBoxLessDo = new CheckBox();
            this.CheckBoxSaleDo = new CheckBox();
            this.CheckBoxCostDo = new CheckBox();
            this.ButtonDo = new Button();
            this.CheckBoxCon = new CheckBox();
            this.LabelTip = new Label();
            this.GroupBox17 = new GroupBox();
            this.RadioButtonOnn = new RadioButton();
            this.RadioButtonBay = new RadioButton();
            this.GroupBox16 = new GroupBox();
            this.TxTDolar = new TextBox();
            this.Label4 = new Label();
            this.TabPage4 = new TabPage();
            this.GroupBox8 = new GroupBox();
            this.TxTLessQ = new TextBox();
            this.ButtonQLess = new Button();
            this.GroupBox7 = new GroupBox();
            this.TxTQNow = new TextBox();
            this.ButtonQNow = new Button();
            this.TabPage5 = new TabPage();
            this.GroupBox9 = new GroupBox();
            this.CheckBoxNoGroup = new CheckBox();
            this.ComboBoxGroup = new ComboBox();
            this.ButtonGroup = new Button();
            this.TabPage6 = new TabPage();
            this.GroupBox10 = new GroupBox();
            this.ChKActiveDate = new CheckBox();
            this.MaterialExpDate = new DateTimePicker();
            this.ButtonDateExp = new Button();
            this.TabPage7 = new TabPage();
            this.GroupBox12 = new GroupBox();
            this.CheckBoxViewNote = new CheckBox();
            this.ButtonViewNote = new Button();
            this.GroupBox11 = new GroupBox();
            this.TxTNote = new TextBox();
            this.ButtonNote = new Button();
            this.TabPage8 = new TabPage();
            this.GroupBox15 = new GroupBox();
            this.TxTDis = new TextBox();
            this.ButtonDis = new Button();
            this.TabPage9 = new TabPage();
            this.GroupBox14 = new GroupBox();
            this.TxTDar = new TextBox();
            this.ButtonDar = new Button();
            this.TabPage10 = new TabPage();
            this.GroupBox13 = new GroupBox();
            this.CheckBoxStopSale = new CheckBox();
            this.ButtonStopSale = new Button();
            this.TabPage12 = new TabPage();
            this.CheckBoxValLess = new CheckBox();
            this.CheckBoxValSale = new CheckBox();
            this.CheckBoxValCost = new CheckBox();
            this.GroupBox18 = new GroupBox();
            this.Label3 = new Label();
            this.TxTEditeSaleVal = new TextBox();
            this.ButtonEditeSaleVal = new Button();
            this.Label5 = new Label();
            this.TabPage13 = new TabPage();
            this.Label1 = new Label();
            this.CheckBoxMiWiLess = new CheckBox();
            this.CheckBoxMiWiSale = new CheckBox();
            this.CheckBoxMiwiCost = new CheckBox();
            this.ButtonMiwi = new Button();
            this.GroupBox19 = new GroupBox();
            this.Label2 = new Label();
            this.RadioButtonMiwiPlus = new RadioButton();
            this.RadioButtonMiwiMinas = new RadioButton();
            this.TxTEditeSaleMiWi = new TextBox();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripLabel2 = new ToolStripLabel();
            this.TxTItems = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripButtonClose = new ToolStripButton();
            this.TimerStartUp = new Timer(this.A);
            this.TabControl1.SuspendLayout();
            this.TabPage11.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.TabPage8.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.TabPage10.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.TabPage12.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.TabPage13.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3ad, 0x2a);
            this.TxTTitle.TabIndex = 0x3e;
            this.TxTTitle.Text = "تعديل متعدد في قيمة على المواد المحددة بأمر واحد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage11);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Controls.Add(this.TabPage8);
            this.TabControl1.Controls.Add(this.TabPage9);
            this.TabControl1.Controls.Add(this.TabPage10);
            this.TabControl1.Controls.Add(this.TabPage12);
            this.TabControl1.Controls.Add(this.TabPage13);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(0, 0x2a);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3ad, 0x144);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x3f;
            this.TabPage11.Controls.Add(this.CheckBoxLessDo);
            this.TabPage11.Controls.Add(this.CheckBoxSaleDo);
            this.TabPage11.Controls.Add(this.CheckBoxCostDo);
            this.TabPage11.Controls.Add(this.ButtonDo);
            this.TabPage11.Controls.Add(this.CheckBoxCon);
            this.TabPage11.Controls.Add(this.LabelTip);
            this.TabPage11.Controls.Add(this.GroupBox17);
            this.TabPage11.Controls.Add(this.GroupBox16);
            this.TabPage11.Controls.Add(this.Label4);
            this.TabPage11.Location = new Point(4, 0x2e);
            this.TabPage11.Name = "TabPage11";
            this.TabPage11.Size = new Size(0x3a5, 0x112);
            this.TabPage11.TabIndex = 10;
            this.TabPage11.Text = "تعديل الاسعار حسب سعر الصرف للعملات";
            this.TabPage11.UseVisualStyleBackColor = true;
            this.CheckBoxLessDo.AutoSize = true;
            this.CheckBoxLessDo.Location = new Point(0xa6, 0x6a);
            this.CheckBoxLessDo.Name = "CheckBoxLessDo";
            this.CheckBoxLessDo.Size = new Size(0xca, 20);
            this.CheckBoxLessDo.TabIndex = 0x8d;
            this.CheckBoxLessDo.Text = "التعديل على سعر البيع المخفض";
            this.CheckBoxLessDo.UseVisualStyleBackColor = true;
            this.CheckBoxSaleDo.AutoSize = true;
            this.CheckBoxSaleDo.Location = new Point(0xd8, 80);
            this.CheckBoxSaleDo.Name = "CheckBoxSaleDo";
            this.CheckBoxSaleDo.Size = new Size(0x98, 20);
            this.CheckBoxSaleDo.TabIndex = 140;
            this.CheckBoxSaleDo.Text = "التعديل على سعر البيع";
            this.CheckBoxSaleDo.UseVisualStyleBackColor = true;
            this.CheckBoxCostDo.AutoSize = true;
            this.CheckBoxCostDo.Location = new Point(0xca, 0x36);
            this.CheckBoxCostDo.Name = "CheckBoxCostDo";
            this.CheckBoxCostDo.Size = new Size(0xa5, 20);
            this.CheckBoxCostDo.TabIndex = 0x8b;
            this.CheckBoxCostDo.Text = "التعديل على سعر التكلفة";
            this.CheckBoxCostDo.UseVisualStyleBackColor = true;
            this.ButtonDo.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDo.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDo.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDo.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDo.FlatStyle = FlatStyle.Flat;
            this.ButtonDo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDo.Image = A.F.ImOK;
            this.ButtonDo.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDo.Location = new Point(0xd8, 0x8e);
            this.ButtonDo.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDo.Name = "ButtonDo";
            this.ButtonDo.Size = new Size(0x97, 0x2c);
            this.ButtonDo.TabIndex = 0x8a;
            this.ButtonDo.Text = "موافق";
            this.ButtonDo.UseVisualStyleBackColor = true;
            this.CheckBoxCon.AutoSize = true;
            this.CheckBoxCon.BackColor = Color.WhiteSmoke;
            this.CheckBoxCon.Dock = DockStyle.Bottom;
            this.CheckBoxCon.Location = new Point(0, 0xd6);
            this.CheckBoxCon.Name = "CheckBoxCon";
            this.CheckBoxCon.Padding = new Padding(5);
            this.CheckBoxCon.Size = new Size(0x3a5, 30);
            this.CheckBoxCon.TabIndex = 0x87;
            this.CheckBoxCon.Text = "نعم، ناتج المعادلة في المثال التالي صحيح";
            this.CheckBoxCon.UseVisualStyleBackColor = false;
            this.LabelTip.Dock = DockStyle.Bottom;
            this.LabelTip.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelTip.ForeColor = Color.Red;
            this.LabelTip.Location = new Point(0, 0xf4);
            this.LabelTip.Name = "LabelTip";
            this.LabelTip.Size = new Size(0x3a5, 30);
            this.LabelTip.TabIndex = 0x86;
            this.LabelTip.Text = "مهم: حدد سعر الصرف وطريقة حساب المعادلة لعرض ناتج العملية هنا كمثال قبل إجراء اي تعديل على المستودع";
            this.LabelTip.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox17.Controls.Add(this.RadioButtonOnn);
            this.GroupBox17.Controls.Add(this.RadioButtonBay);
            this.GroupBox17.Location = new Point(0x1b1, 0x42);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0x105, 90);
            this.GroupBox17.TabIndex = 130;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "ثانيا: حدد لنا طريقة الحساب";
            this.RadioButtonOnn.AutoSize = true;
            this.RadioButtonOnn.Location = new Point(0x10, 0x39);
            this.RadioButtonOnn.Name = "RadioButtonOnn";
            this.RadioButtonOnn.Size = new Size(0xe2, 20);
            this.RadioButtonOnn.TabIndex = 1;
            this.RadioButtonOnn.TabStop = true;
            this.RadioButtonOnn.Text = "سعر الصرف قسمة (/) العملة المحلية";
            this.RadioButtonOnn.UseVisualStyleBackColor = true;
            this.RadioButtonBay.AutoSize = true;
            this.RadioButtonBay.Location = new Point(0x15, 0x1d);
            this.RadioButtonBay.Name = "RadioButtonBay";
            this.RadioButtonBay.Size = new Size(0xdd, 20);
            this.RadioButtonBay.TabIndex = 0;
            this.RadioButtonBay.TabStop = true;
            this.RadioButtonBay.Text = "سعر الصرف ضرب (*) العملة المحلية";
            this.RadioButtonBay.UseVisualStyleBackColor = true;
            this.GroupBox16.Controls.Add(this.TxTDolar);
            this.GroupBox16.Location = new Point(700, 0x42);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(200, 0x36);
            this.GroupBox16.TabIndex = 0x81;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "اولا: حدد سعر الصرف:";
            this.TxTDolar.BackColor = SystemColors.Info;
            this.TxTDolar.Dock = DockStyle.Fill;
            this.TxTDolar.Location = new Point(3, 0x13);
            this.TxTDolar.MaxLength = 20;
            this.TxTDolar.Name = "TxTDolar";
            this.TxTDolar.RightToLeft = RightToLeft.No;
            this.TxTDolar.Size = new Size(0xc2, 0x17);
            this.TxTDolar.TabIndex = 0x7b;
            this.TxTDolar.TextAlign = HorizontalAlignment.Center;
            this.Label4.Dock = DockStyle.Top;
            this.Label4.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = Color.Green;
            this.Label4.Location = new Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x3a5, 0x22);
            this.Label4.TabIndex = 0x80;
            this.Label4.Text = "التعديل على الاسعار في المستودع حسب سعر الصرف";
            this.Label4.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage4.Controls.Add(this.GroupBox8);
            this.TabPage4.Controls.Add(this.GroupBox7);
            this.TabPage4.Location = new Point(4, 0x2e);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x3a5, 0x112);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "تعديل الكمية";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.GroupBox8.Controls.Add(this.TxTLessQ);
            this.GroupBox8.Controls.Add(this.ButtonQLess);
            this.GroupBox8.Location = new Point(0x72, 0x30);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(340, 0x62);
            this.GroupBox8.TabIndex = 0x7c;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "التنبيه عندما تصل الكمية للحد الأدنى وهو";
            this.TxTLessQ.BackColor = SystemColors.Info;
            this.TxTLessQ.Location = new Point(0xa3, 0x2d);
            this.TxTLessQ.MaxLength = 20;
            this.TxTLessQ.Name = "TxTLessQ";
            this.TxTLessQ.RightToLeft = RightToLeft.No;
            this.TxTLessQ.Size = new Size(0xa1, 0x17);
            this.TxTLessQ.TabIndex = 0x7a;
            this.TxTLessQ.TextAlign = HorizontalAlignment.Center;
            this.ButtonQLess.FlatAppearance.BorderColor = Color.Green;
            this.ButtonQLess.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonQLess.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonQLess.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonQLess.FlatStyle = FlatStyle.Flat;
            this.ButtonQLess.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonQLess.Image = A.F.ImOK;
            this.ButtonQLess.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonQLess.Location = new Point(6, 0x22);
            this.ButtonQLess.Margin = new Padding(3, 4, 3, 4);
            this.ButtonQLess.Name = "ButtonQLess";
            this.ButtonQLess.Size = new Size(0x97, 0x2c);
            this.ButtonQLess.TabIndex = 0x79;
            this.ButtonQLess.Text = "موافق";
            this.ButtonQLess.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.TxTQNow);
            this.GroupBox7.Controls.Add(this.ButtonQNow);
            this.GroupBox7.Location = new Point(570, 0x30);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(340, 0x62);
            this.GroupBox7.TabIndex = 0x7b;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "التعديل على الكمية الحالية لتصبح";
            this.TxTQNow.BackColor = SystemColors.Info;
            this.TxTQNow.Location = new Point(0xa3, 0x2d);
            this.TxTQNow.MaxLength = 20;
            this.TxTQNow.Name = "TxTQNow";
            this.TxTQNow.RightToLeft = RightToLeft.No;
            this.TxTQNow.Size = new Size(0xa1, 0x17);
            this.TxTQNow.TabIndex = 0x7a;
            this.TxTQNow.TextAlign = HorizontalAlignment.Center;
            this.ButtonQNow.FlatAppearance.BorderColor = Color.Green;
            this.ButtonQNow.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonQNow.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonQNow.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonQNow.FlatStyle = FlatStyle.Flat;
            this.ButtonQNow.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonQNow.Image = A.F.ImOK;
            this.ButtonQNow.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonQNow.Location = new Point(6, 0x22);
            this.ButtonQNow.Margin = new Padding(3, 4, 3, 4);
            this.ButtonQNow.Name = "ButtonQNow";
            this.ButtonQNow.Size = new Size(0x97, 0x2c);
            this.ButtonQNow.TabIndex = 0x79;
            this.ButtonQNow.Text = "موافق";
            this.ButtonQNow.UseVisualStyleBackColor = true;
            this.TabPage5.Controls.Add(this.GroupBox9);
            this.TabPage5.Location = new Point(4, 0x2e);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new Size(0x3a5, 0x112);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "الربط مع مجموعات";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.CheckBoxNoGroup);
            this.GroupBox9.Controls.Add(this.ComboBoxGroup);
            this.GroupBox9.Controls.Add(this.ButtonGroup);
            this.GroupBox9.Location = new Point(0x143, 40);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x246, 0x77);
            this.GroupBox9.TabIndex = 0x7d;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "ربط المواد المحدد مع المجموعة التالية";
            this.CheckBoxNoGroup.AutoSize = true;
            this.CheckBoxNoGroup.Location = new Point(0x1d8, 0x27);
            this.CheckBoxNoGroup.Name = "CheckBoxNoGroup";
            this.CheckBoxNoGroup.Size = new Size(0x59, 20);
            this.CheckBoxNoGroup.TabIndex = 0x7a;
            this.CheckBoxNoGroup.Text = "بلا مجموعة";
            this.CheckBoxNoGroup.UseVisualStyleBackColor = true;
            this.ComboBoxGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxGroup.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.IntegralHeight = false;
            this.ComboBoxGroup.Location = new Point(170, 0x41);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.Size = new Size(0x192, 0x1b);
            this.ComboBoxGroup.TabIndex = 0x3b;
            this.ButtonGroup.FlatAppearance.BorderColor = Color.Green;
            this.ButtonGroup.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonGroup.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonGroup.FlatStyle = FlatStyle.Flat;
            this.ButtonGroup.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonGroup.Image = A.F.ImOK;
            this.ButtonGroup.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonGroup.Location = new Point(13, 0x39);
            this.ButtonGroup.Margin = new Padding(3, 4, 3, 4);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new Size(0x97, 0x2c);
            this.ButtonGroup.TabIndex = 0x79;
            this.ButtonGroup.Text = "موافق";
            this.ButtonGroup.UseVisualStyleBackColor = true;
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Location = new Point(4, 0x2e);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new Size(0x3a5, 0x112);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "تاريخ الانتهاء";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.GroupBox10.Controls.Add(this.ChKActiveDate);
            this.GroupBox10.Controls.Add(this.MaterialExpDate);
            this.GroupBox10.Controls.Add(this.ButtonDateExp);
            this.GroupBox10.Location = new Point(0x18d, 0x22);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x1e3, 0x77);
            this.GroupBox10.TabIndex = 0x7e;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "حدد تاريخ الانتهاء لهذه المواد";
            this.ChKActiveDate.AutoSize = true;
            this.ChKActiveDate.Location = new Point(0x16b, 40);
            this.ChKActiveDate.Name = "ChKActiveDate";
            this.ChKActiveDate.Size = new Size(0x66, 20);
            this.ChKActiveDate.TabIndex = 0x51ec5;
            this.ChKActiveDate.Text = "بلا تاريخ انتهاء";
            this.ChKActiveDate.UseVisualStyleBackColor = true;
            this.MaterialExpDate.CustomFormat = "yyyy/MM/dd";
            this.MaterialExpDate.Format = DateTimePickerFormat.Custom;
            this.MaterialExpDate.Location = new Point(0xc2, 0x43);
            this.MaterialExpDate.Margin = new Padding(3, 4, 3, 4);
            this.MaterialExpDate.Name = "MaterialExpDate";
            this.MaterialExpDate.RightToLeft = RightToLeft.No;
            this.MaterialExpDate.Size = new Size(0x10f, 0x17);
            this.MaterialExpDate.TabIndex = 0x51ec4;
            this.ButtonDateExp.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDateExp.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDateExp.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDateExp.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDateExp.FlatStyle = FlatStyle.Flat;
            this.ButtonDateExp.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDateExp.Image = A.F.ImOK;
            this.ButtonDateExp.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDateExp.Location = new Point(0x13, 0x2e);
            this.ButtonDateExp.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDateExp.Name = "ButtonDateExp";
            this.ButtonDateExp.Size = new Size(0x97, 0x2c);
            this.ButtonDateExp.TabIndex = 0x79;
            this.ButtonDateExp.Text = "موافق";
            this.ButtonDateExp.UseVisualStyleBackColor = true;
            this.TabPage7.Controls.Add(this.GroupBox12);
            this.TabPage7.Controls.Add(this.GroupBox11);
            this.TabPage7.Location = new Point(4, 0x2e);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Size = new Size(0x3a5, 0x112);
            this.TabPage7.TabIndex = 6;
            this.TabPage7.Text = "الملاحظات";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.GroupBox12.Controls.Add(this.CheckBoxViewNote);
            this.GroupBox12.Controls.Add(this.ButtonViewNote);
            this.GroupBox12.Location = new Point(8, 0x21);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x165, 0x62);
            this.GroupBox12.TabIndex = 0x7d;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "عرض الملاحظة بشكل دائمة وتلقائي في الفاتورة";
            this.CheckBoxViewNote.AutoSize = true;
            this.CheckBoxViewNote.Location = new Point(0xb0, 0x2f);
            this.CheckBoxViewNote.Name = "CheckBoxViewNote";
            this.CheckBoxViewNote.Size = new Size(0xa6, 20);
            this.CheckBoxViewNote.TabIndex = 0x7a;
            this.CheckBoxViewNote.Text = "نعم تفعيل عرض الملاحظة";
            this.CheckBoxViewNote.UseVisualStyleBackColor = true;
            this.ButtonViewNote.FlatAppearance.BorderColor = Color.Green;
            this.ButtonViewNote.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonViewNote.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonViewNote.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonViewNote.FlatStyle = FlatStyle.Flat;
            this.ButtonViewNote.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonViewNote.Image = A.F.ImOK;
            this.ButtonViewNote.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonViewNote.Location = new Point(6, 0x22);
            this.ButtonViewNote.Margin = new Padding(3, 4, 3, 4);
            this.ButtonViewNote.Name = "ButtonViewNote";
            this.ButtonViewNote.Size = new Size(0x97, 0x2c);
            this.ButtonViewNote.TabIndex = 0x79;
            this.ButtonViewNote.Text = "موافق";
            this.ButtonViewNote.UseVisualStyleBackColor = true;
            this.GroupBox11.Controls.Add(this.TxTNote);
            this.GroupBox11.Controls.Add(this.ButtonNote);
            this.GroupBox11.Location = new Point(0x17e, 0x21);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x219, 0x62);
            this.GroupBox11.TabIndex = 0x7c;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "ملاحظة";
            this.TxTNote.BackColor = SystemColors.Info;
            this.TxTNote.Location = new Point(0xa9, 0x22);
            this.TxTNote.MaxLength = 300;
            this.TxTNote.Multiline = true;
            this.TxTNote.Name = "TxTNote";
            this.TxTNote.RightToLeft = RightToLeft.No;
            this.TxTNote.Size = new Size(0x15b, 0x2d);
            this.TxTNote.TabIndex = 0x7a;
            this.TxTNote.TextAlign = HorizontalAlignment.Center;
            this.ButtonNote.FlatAppearance.BorderColor = Color.Green;
            this.ButtonNote.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonNote.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonNote.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonNote.FlatStyle = FlatStyle.Flat;
            this.ButtonNote.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonNote.Image = A.F.ImOK;
            this.ButtonNote.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonNote.Location = new Point(12, 0x22);
            this.ButtonNote.Margin = new Padding(3, 4, 3, 4);
            this.ButtonNote.Name = "ButtonNote";
            this.ButtonNote.Size = new Size(0x97, 0x2c);
            this.ButtonNote.TabIndex = 0x79;
            this.ButtonNote.Text = "موافق";
            this.ButtonNote.UseVisualStyleBackColor = true;
            this.TabPage8.Controls.Add(this.GroupBox15);
            this.TabPage8.Location = new Point(4, 0x2e);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Size = new Size(0x3a5, 0x112);
            this.TabPage8.TabIndex = 7;
            this.TabPage8.Text = "الخصم";
            this.TabPage8.UseVisualStyleBackColor = true;
            this.GroupBox15.Controls.Add(this.TxTDis);
            this.GroupBox15.Controls.Add(this.ButtonDis);
            this.GroupBox15.Location = new Point(0x21b, 0x2e);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(340, 0x62);
            this.GroupBox15.TabIndex = 0x7d;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "نسبة الخصم على المواد المحددة %";
            this.TxTDis.BackColor = SystemColors.Info;
            this.TxTDis.Location = new Point(0xa3, 0x2d);
            this.TxTDis.MaxLength = 5;
            this.TxTDis.Name = "TxTDis";
            this.TxTDis.RightToLeft = RightToLeft.No;
            this.TxTDis.Size = new Size(0xa1, 0x17);
            this.TxTDis.TabIndex = 0x7a;
            this.TxTDis.TextAlign = HorizontalAlignment.Center;
            this.ButtonDis.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDis.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDis.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDis.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDis.FlatStyle = FlatStyle.Flat;
            this.ButtonDis.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDis.Image = A.F.ImOK;
            this.ButtonDis.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDis.Location = new Point(6, 0x22);
            this.ButtonDis.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDis.Name = "ButtonDis";
            this.ButtonDis.Size = new Size(0x97, 0x2c);
            this.ButtonDis.TabIndex = 0x79;
            this.ButtonDis.Text = "موافق";
            this.ButtonDis.UseVisualStyleBackColor = true;
            this.TabPage9.Controls.Add(this.GroupBox14);
            this.TabPage9.Location = new Point(4, 0x2e);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Size = new Size(0x3a5, 0x112);
            this.TabPage9.TabIndex = 8;
            this.TabPage9.Text = "الضريبة";
            this.TabPage9.UseVisualStyleBackColor = true;
            this.GroupBox14.Controls.Add(this.TxTDar);
            this.GroupBox14.Controls.Add(this.ButtonDar);
            this.GroupBox14.Location = new Point(0x21e, 0x2d);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(340, 0x62);
            this.GroupBox14.TabIndex = 0x7c;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "نسبة الضريبة على المواد المحددة %";
            this.TxTDar.BackColor = SystemColors.Info;
            this.TxTDar.Location = new Point(0xa3, 0x2d);
            this.TxTDar.MaxLength = 5;
            this.TxTDar.Name = "TxTDar";
            this.TxTDar.RightToLeft = RightToLeft.No;
            this.TxTDar.Size = new Size(0xa1, 0x17);
            this.TxTDar.TabIndex = 0x7a;
            this.TxTDar.TextAlign = HorizontalAlignment.Center;
            this.ButtonDar.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDar.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDar.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDar.FlatStyle = FlatStyle.Flat;
            this.ButtonDar.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDar.Image = A.F.ImOK;
            this.ButtonDar.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDar.Location = new Point(6, 0x22);
            this.ButtonDar.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDar.Name = "ButtonDar";
            this.ButtonDar.Size = new Size(0x97, 0x2c);
            this.ButtonDar.TabIndex = 0x79;
            this.ButtonDar.Text = "موافق";
            this.ButtonDar.UseVisualStyleBackColor = true;
            this.TabPage10.Controls.Add(this.GroupBox13);
            this.TabPage10.Location = new Point(4, 0x2e);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Size = new Size(0x3a5, 0x112);
            this.TabPage10.TabIndex = 9;
            this.TabPage10.Text = "منع/ تعطيل البيع";
            this.TabPage10.UseVisualStyleBackColor = true;
            this.GroupBox13.Controls.Add(this.CheckBoxStopSale);
            this.GroupBox13.Controls.Add(this.ButtonStopSale);
            this.GroupBox13.Location = new Point(0x217, 0x2f);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x153, 0x62);
            this.GroupBox13.TabIndex = 0x7e;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "وقف بيع المواد المحددة";
            this.CheckBoxStopSale.AutoSize = true;
            this.CheckBoxStopSale.Location = new Point(0xc5, 0x2f);
            this.CheckBoxStopSale.Name = "CheckBoxStopSale";
            this.CheckBoxStopSale.Size = new Size(0x6d, 20);
            this.CheckBoxStopSale.TabIndex = 0x7a;
            this.CheckBoxStopSale.Text = "نعم/ اوقف البيع";
            this.CheckBoxStopSale.UseVisualStyleBackColor = true;
            this.ButtonStopSale.FlatAppearance.BorderColor = Color.Green;
            this.ButtonStopSale.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonStopSale.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonStopSale.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonStopSale.FlatStyle = FlatStyle.Flat;
            this.ButtonStopSale.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonStopSale.Image = A.F.ImOK;
            this.ButtonStopSale.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonStopSale.Location = new Point(6, 0x22);
            this.ButtonStopSale.Margin = new Padding(3, 4, 3, 4);
            this.ButtonStopSale.Name = "ButtonStopSale";
            this.ButtonStopSale.Size = new Size(0x97, 0x2c);
            this.ButtonStopSale.TabIndex = 0x79;
            this.ButtonStopSale.Text = "موافق";
            this.ButtonStopSale.UseVisualStyleBackColor = true;
            this.TabPage12.Controls.Add(this.CheckBoxValLess);
            this.TabPage12.Controls.Add(this.CheckBoxValSale);
            this.TabPage12.Controls.Add(this.CheckBoxValCost);
            this.TabPage12.Controls.Add(this.GroupBox18);
            this.TabPage12.Controls.Add(this.ButtonEditeSaleVal);
            this.TabPage12.Controls.Add(this.Label5);
            this.TabPage12.Location = new Point(4, 0x2e);
            this.TabPage12.Name = "TabPage12";
            this.TabPage12.Padding = new Padding(3);
            this.TabPage12.Size = new Size(0x3a5, 0x112);
            this.TabPage12.TabIndex = 11;
            this.TabPage12.Text = "التعديل على الاسعار حسب المبلغ";
            this.TabPage12.UseVisualStyleBackColor = true;
            this.CheckBoxValLess.AutoSize = true;
            this.CheckBoxValLess.Location = new Point(0x144, 0x83);
            this.CheckBoxValLess.Name = "CheckBoxValLess";
            this.CheckBoxValLess.Size = new Size(0xca, 20);
            this.CheckBoxValLess.TabIndex = 0x84;
            this.CheckBoxValLess.Text = "التعديل على سعر البيع المخفض";
            this.CheckBoxValLess.UseVisualStyleBackColor = true;
            this.CheckBoxValSale.AutoSize = true;
            this.CheckBoxValSale.Location = new Point(0x176, 0x69);
            this.CheckBoxValSale.Name = "CheckBoxValSale";
            this.CheckBoxValSale.Size = new Size(0x98, 20);
            this.CheckBoxValSale.TabIndex = 0x83;
            this.CheckBoxValSale.Text = "التعديل على سعر البيع";
            this.CheckBoxValSale.UseVisualStyleBackColor = true;
            this.CheckBoxValCost.AutoSize = true;
            this.CheckBoxValCost.Location = new Point(360, 0x4f);
            this.CheckBoxValCost.Name = "CheckBoxValCost";
            this.CheckBoxValCost.Size = new Size(0xa5, 20);
            this.CheckBoxValCost.TabIndex = 130;
            this.CheckBoxValCost.Text = "التعديل على سعر التكلفة";
            this.CheckBoxValCost.UseVisualStyleBackColor = true;
            this.GroupBox18.Controls.Add(this.Label3);
            this.GroupBox18.Controls.Add(this.TxTEditeSaleVal);
            this.GroupBox18.Location = new Point(0x239, 0x4e);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(310, 0x49);
            this.GroupBox18.TabIndex = 0x81;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "التعديل على السعر ليصبح (ادخل مبلغ)";
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(0x102, 0x1f);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x2e, 0x10);
            this.Label3.TabIndex = 0x7e;
            this.Label3.Text = "المبلغ:";
            this.TxTEditeSaleVal.BackColor = SystemColors.Info;
            this.TxTEditeSaleVal.Location = new Point(0x11, 0x1c);
            this.TxTEditeSaleVal.MaxLength = 20;
            this.TxTEditeSaleVal.Name = "TxTEditeSaleVal";
            this.TxTEditeSaleVal.RightToLeft = RightToLeft.No;
            this.TxTEditeSaleVal.Size = new Size(0xeb, 0x17);
            this.TxTEditeSaleVal.TabIndex = 0x7a;
            this.TxTEditeSaleVal.TextAlign = HorizontalAlignment.Center;
            this.ButtonEditeSaleVal.FlatAppearance.BorderColor = Color.Green;
            this.ButtonEditeSaleVal.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonEditeSaleVal.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonEditeSaleVal.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonEditeSaleVal.FlatStyle = FlatStyle.Flat;
            this.ButtonEditeSaleVal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonEditeSaleVal.Image = A.F.ImOK;
            this.ButtonEditeSaleVal.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonEditeSaleVal.Location = new Point(0x107, 0xaf);
            this.ButtonEditeSaleVal.Margin = new Padding(3, 4, 3, 4);
            this.ButtonEditeSaleVal.Name = "ButtonEditeSaleVal";
            this.ButtonEditeSaleVal.Size = new Size(0x106, 0x2c);
            this.ButtonEditeSaleVal.TabIndex = 0x79;
            this.ButtonEditeSaleVal.Text = "موافق";
            this.ButtonEditeSaleVal.UseVisualStyleBackColor = true;
            this.Label5.Dock = DockStyle.Top;
            this.Label5.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = Color.Green;
            this.Label5.Location = new Point(3, 3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x39f, 0x22);
            this.Label5.TabIndex = 0x80;
            this.Label5.Text = "التعديل على الاسعار حسب المبلغ";
            this.Label5.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage13.Controls.Add(this.Label1);
            this.TabPage13.Controls.Add(this.CheckBoxMiWiLess);
            this.TabPage13.Controls.Add(this.CheckBoxMiWiSale);
            this.TabPage13.Controls.Add(this.CheckBoxMiwiCost);
            this.TabPage13.Controls.Add(this.ButtonMiwi);
            this.TabPage13.Controls.Add(this.GroupBox19);
            this.TabPage13.Location = new Point(4, 0x2e);
            this.TabPage13.Name = "TabPage13";
            this.TabPage13.Size = new Size(0x3a5, 0x112);
            this.TabPage13.TabIndex = 12;
            this.TabPage13.Text = "التعديل على الاسعار حسب نسبة مؤوية";
            this.TabPage13.UseVisualStyleBackColor = true;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Green;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3a5, 0x22);
            this.Label1.TabIndex = 0x88;
            this.Label1.Text = "التعديل على الاسعار حسب نسبة مئوية";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxMiWiLess.AutoSize = true;
            this.CheckBoxMiWiLess.Location = new Point(0x106, 0x73);
            this.CheckBoxMiWiLess.Name = "CheckBoxMiWiLess";
            this.CheckBoxMiWiLess.Size = new Size(0xca, 20);
            this.CheckBoxMiWiLess.TabIndex = 0x87;
            this.CheckBoxMiWiLess.Text = "التعديل على سعر البيع المخفض";
            this.CheckBoxMiWiLess.UseVisualStyleBackColor = true;
            this.CheckBoxMiWiSale.AutoSize = true;
            this.CheckBoxMiWiSale.Location = new Point(0x138, 0x59);
            this.CheckBoxMiWiSale.Name = "CheckBoxMiWiSale";
            this.CheckBoxMiWiSale.Size = new Size(0x98, 20);
            this.CheckBoxMiWiSale.TabIndex = 0x86;
            this.CheckBoxMiWiSale.Text = "التعديل على سعر البيع";
            this.CheckBoxMiWiSale.UseVisualStyleBackColor = true;
            this.CheckBoxMiwiCost.AutoSize = true;
            this.CheckBoxMiwiCost.Location = new Point(0x12a, 0x3f);
            this.CheckBoxMiwiCost.Name = "CheckBoxMiwiCost";
            this.CheckBoxMiwiCost.Size = new Size(0xa5, 20);
            this.CheckBoxMiwiCost.TabIndex = 0x85;
            this.CheckBoxMiwiCost.Text = "التعديل على سعر التكلفة";
            this.CheckBoxMiwiCost.UseVisualStyleBackColor = true;
            this.ButtonMiwi.FlatAppearance.BorderColor = Color.Green;
            this.ButtonMiwi.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonMiwi.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonMiwi.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonMiwi.FlatStyle = FlatStyle.Flat;
            this.ButtonMiwi.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonMiwi.Image = A.F.ImOK;
            this.ButtonMiwi.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonMiwi.Location = new Point(0xeb, 0x97);
            this.ButtonMiwi.Margin = new Padding(3, 4, 3, 4);
            this.ButtonMiwi.Name = "ButtonMiwi";
            this.ButtonMiwi.Size = new Size(0xe4, 0x2c);
            this.ButtonMiwi.TabIndex = 0x79;
            this.ButtonMiwi.Text = "موافق";
            this.ButtonMiwi.UseVisualStyleBackColor = true;
            this.GroupBox19.Controls.Add(this.Label2);
            this.GroupBox19.Controls.Add(this.RadioButtonMiwiPlus);
            this.GroupBox19.Controls.Add(this.RadioButtonMiwiMinas);
            this.GroupBox19.Controls.Add(this.TxTEditeSaleMiWi);
            this.GroupBox19.Location = new Point(0x1f7, 0x3f);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(0x195, 0x62);
            this.GroupBox19.TabIndex = 0x7e;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "التعديل على الاسعار وذلك بنسبة % (ادخل نسبة)";
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0x156, 0x2e);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x33, 0x10);
            this.Label2.TabIndex = 0x7d;
            this.Label2.Text = "النسبة:";
            this.RadioButtonMiwiPlus.AutoSize = true;
            this.RadioButtonMiwiPlus.Location = new Point(10, 0x21);
            this.RadioButtonMiwiPlus.Name = "RadioButtonMiwiPlus";
            this.RadioButtonMiwiPlus.Size = new Size(0xc1, 20);
            this.RadioButtonMiwiPlus.TabIndex = 0x7c;
            this.RadioButtonMiwiPlus.TabStop = true;
            this.RadioButtonMiwiPlus.Text = "هذه نسبة زيادة على السعر  +";
            this.RadioButtonMiwiPlus.UseVisualStyleBackColor = true;
            this.RadioButtonMiwiMinas.AutoSize = true;
            this.RadioButtonMiwiMinas.Location = new Point(10, 0x3b);
            this.RadioButtonMiwiMinas.Name = "RadioButtonMiwiMinas";
            this.RadioButtonMiwiMinas.Size = new Size(0xc1, 20);
            this.RadioButtonMiwiMinas.TabIndex = 0x7b;
            this.RadioButtonMiwiMinas.TabStop = true;
            this.RadioButtonMiwiMinas.Text = "هذه نسبة خصم على السعر  -";
            this.RadioButtonMiwiMinas.UseVisualStyleBackColor = true;
            this.TxTEditeSaleMiWi.BackColor = SystemColors.Info;
            this.TxTEditeSaleMiWi.Location = new Point(220, 0x2b);
            this.TxTEditeSaleMiWi.MaxLength = 5;
            this.TxTEditeSaleMiWi.Name = "TxTEditeSaleMiWi";
            this.TxTEditeSaleMiWi.RightToLeft = RightToLeft.No;
            this.TxTEditeSaleMiWi.Size = new Size(0x74, 0x17);
            this.TxTEditeSaleMiWi.TabIndex = 0x7a;
            this.TxTEditeSaleMiWi.TextAlign = HorizontalAlignment.Center;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripLabel2, this.TxTItems, this.ToolStripSeparator1, this.ToolStripProgressBar1, this.ToolStripButtonClose };
            this.ToolStripStatus.Items.AddRange(toolStripItems);
            this.ToolStripStatus.Location = new Point(0, 0x16e);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3ad, 0x27);
            this.ToolStripStatus.TabIndex = 0x7b;
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new Size(0xae, 0x24);
            this.ToolStripLabel2.Text = "عدد المواد التي سيتم تعديلها:";
            this.TxTItems.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTItems.ForeColor = Color.Green;
            this.TxTItems.Name = "TxTItems";
            this.TxTItems.Size = new Size(0x10, 0x24);
            this.TxTItems.Text = "0";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x27);
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x24);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x24);
            this.ToolStripButtonClose.Text = "اغلاق";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3ad, 0x195);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ToolStripStatus);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialMultiEdit";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تعديل متعدد في قيمة على المواد المحددة بأمر واحد";
            this.TabControl1.ResumeLayout(false);
            this.TabPage11.ResumeLayout(false);
            this.TabPage11.PerformLayout();
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox16.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.TabPage7.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.TabPage8.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox15.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.TabPage10.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox13.PerformLayout();
            this.TabPage12.ResumeLayout(false);
            this.TabPage12.PerformLayout();
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox18.PerformLayout();
            this.TabPage13.ResumeLayout(false);
            this.TabPage13.PerformLayout();
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox19.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            if (this.A)
            {
                A.D.A.A.TimerLoadData.Enabled = true;
            }
            base.Dispose();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void AR(object A, EventArgs R)
        {
        }

        private void B(object A, EventArgs R)
        {
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.A = true;
                        this.CheckBoxCon.BackColor = Color.White;
                        this.CheckBoxCon.Checked = false;
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = 0;
                    num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                    string str = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricCost"].Value);
                    decimal num4 = new decimal(Conversion.Val(str.Replace(",", "")));
                    string str2 = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricSale"].Value);
                    decimal num5 = new decimal(Conversion.Val(str2.Replace(",", "")));
                    string str3 = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricLess"].Value);
                    decimal num6 = new decimal(Conversion.Val(str3.Replace(",", "")));
                    decimal num7 = Conversions.ToDecimal(this.TxTEditeSaleVal.Text);
                    decimal num8 = Conversions.ToDecimal(this.TxTEditeSaleVal.Text);
                    decimal num9 = Conversions.ToDecimal(this.TxTEditeSaleVal.Text);
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        string cmdText = "UPDATE [TaNNMaterial] SET [MaterialPricCost] = @MaterialPricCost, [MaterialPricSale] = @MaterialPricSale, [MaterialPricLess] = @MaterialPricLess WHERE [MaterialID] = @MaterialID";
                        if (!this.CheckBoxValCost.Checked)
                        {
                            cmdText = cmdText.Replace("[MaterialPricCost] = @MaterialPricCost, ", "");
                        }
                        if (!this.CheckBoxValSale.Checked)
                        {
                            cmdText = cmdText.Replace("[MaterialPricSale] = @MaterialPricSale, ", "");
                        }
                        if (!this.CheckBoxValLess.Checked)
                        {
                            cmdText = cmdText.Replace("[MaterialPricLess] = @MaterialPricLess", "");
                        }
                        cmdText = cmdText.Replace("UPDATE [TaNNMaterial] SET ,", "UPDATE [TaNNMaterial] SET ").Replace("UPDATE [TaNNMaterial] SET , ", "UPDATE [TaNNMaterial] SET ").Replace("UPDATE [TaNNMaterial] SET ,  ", "UPDATE [TaNNMaterial] SET ").Replace(", WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID").Replace(",  WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID").Replace(",   WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID");
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand(cmdText, this.A);
                        command.Parameters.AddWithValue("MaterialID", num3);
                        if (this.CheckBoxValCost.Checked)
                        {
                            command.Parameters.AddWithValue("MaterialPricCost", num7.ToString(A.PR.VR));
                        }
                        if (this.CheckBoxValSale.Checked)
                        {
                            command.Parameters.AddWithValue("MaterialPricSale", num8.ToString(A.PR.VR));
                        }
                        if (this.CheckBoxValLess.Checked)
                        {
                            command.Parameters.AddWithValue("MaterialPricLess", num9.ToString(A.PR.VR));
                        }
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void C(object A, EventArgs R)
        {
        }

        private void D(object A, EventArgs R)
        {
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.A = true;
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = 0;
                    num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [GroupIDFrontID] = @GroupIDFrontID WHERE [MaterialID] = @MaterialID", this.A);
                        command.Parameters.AddWithValue("MaterialID", num3);
                        if (this.CheckBoxNoGroup.Checked | (this.ComboBoxGroup.Text == null))
                        {
                            command.Parameters.AddWithValue("GroupIDFrontID", "0");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("GroupIDFrontID", this.ComboBoxGroup.SelectedValue);
                        }
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void D(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
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
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.A = true;
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = 0;
                    num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialIsStop] = @MaterialIsStop WHERE [MaterialID] = @MaterialID", this.A);
                        command.Parameters.AddWithValue("MaterialID", num3);
                        command.Parameters.AddWithValue("MaterialIsStop", this.CheckBoxStopSale.Checked);
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void F(object A, EventArgs R)
        {
            if (!this.CheckBoxNoGroup.Checked)
            {
                this.ComboBoxGroup.Enabled = true;
            }
            else
            {
                this.ComboBoxGroup.Text = null;
                this.ComboBoxGroup.Enabled = false;
            }
        }

        private void F(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void G(object A, EventArgs R)
        {
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.A = true;
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = 0;
                    num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialNotIsView] = @MaterialNotIsView WHERE [MaterialID] = @MaterialID", this.A);
                        command.Parameters.AddWithValue("MaterialID", num3);
                        command.Parameters.AddWithValue("MaterialNotIsView", this.CheckBoxViewNote.Checked);
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void H(object A, EventArgs R)
        {
            this.MaterialExpDate.Enabled = !this.ChKActiveDate.Checked;
        }

        private void I(object A, EventArgs R)
        {
            try
            {
                if (this.TxTLessQ.Text == null)
                {
                    Interaction.MsgBox(A.PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.TxTLessQ.Focus();
                }
                else
                {
                    A.D.A.A.GV.ClearSelection();
                    A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                    A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                    int num = A.D.A.A.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            this.A = true;
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        int num3 = 0;
                        num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                        if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                        {
                            decimal num4 = new decimal(Conversion.Val(this.TxTLessQ.Text.Replace(",", "")));
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantityLess] = @MaterialQuantityLess WHERE [MaterialID] = @MaterialID", this.A);
                            command.Parameters.AddWithValue("MaterialID", num3);
                            command.Parameters.AddWithValue("MaterialQuantityLess", num4.ToString(A.PR.OR));
                            command.ExecuteNonQuery();
                            this.A.Close();
                        }
                        num2++;
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

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void J(object A, EventArgs R)
        {
        }

        private void K(object A, EventArgs R)
        {
            try
            {
                if (this.TxTDar.Text == null)
                {
                    Interaction.MsgBox(A.PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.TxTDar.Focus();
                }
                else
                {
                    A.D.A.A.GV.ClearSelection();
                    A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                    A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                    int num = A.D.A.A.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            this.A = true;
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        int num3 = 0;
                        num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                        if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialDarMiWi] = @MaterialDarMiWi WHERE [MaterialID] = @MaterialID", this.A);
                            command.Parameters.AddWithValue("MaterialID", num3);
                            command.Parameters.AddWithValue("MaterialDarMiWi", Conversion.Val(this.TxTDar.Text));
                            command.ExecuteNonQuery();
                            this.A.Close();
                        }
                        num2++;
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

        private void L(object A, EventArgs R)
        {
            this.R();
        }

        private void M(object A, EventArgs R)
        {
        }

        private void N(object A, EventArgs R)
        {
            this.R();
        }

        private void O(object A, EventArgs R)
        {
            if (this.CheckBoxCon.Checked)
            {
                if (!this.RadioButtonBay.Checked & !this.RadioButtonOnn.Checked)
                {
                    Interaction.MsgBox("حدد معادلة الحساب قسمة او ضرب", MsgBoxStyle.ApplicationModal, null);
                    this.CheckBoxCon.Checked = false;
                }
                if (Conversion.Val(this.TxTDolar.Text) == 0.0)
                {
                    Interaction.MsgBox("حدد سعر الصرف", MsgBoxStyle.ApplicationModal, null);
                    this.CheckBoxCon.Checked = false;
                }
            }
        }

        private void P(object A, EventArgs R)
        {
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerStartUp.Enabled = true;
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void PR(object A, EventArgs R)
        {
        }

        private void Q(object A, EventArgs R)
        {
            try
            {
                if (this.TxTQNow.Text == null)
                {
                    Interaction.MsgBox(A.PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.TxTQNow.Focus();
                }
                else
                {
                    A.D.A.A.GV.ClearSelection();
                    A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                    A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                    int num = A.D.A.A.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            this.A = true;
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        int num3 = 0;
                        num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                        if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                        {
                            decimal num4 = new decimal(Conversion.Val(this.TxTQNow.Text.Replace(",", "")));
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                            command.Parameters.AddWithValue("MaterialID", num3);
                            command.Parameters.AddWithValue("MaterialQuantity", num4.ToString(A.PR.OR));
                            command.ExecuteNonQuery();
                            this.A.Close();
                        }
                        num2++;
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

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void R()
        {
            decimal num = new decimal(Conversion.Val(this.TxTDolar.Text));
            decimal num2 = 0M;
            if (this.RadioButtonBay.Checked)
            {
                num2 = decimal.Multiply(num, new decimal((long) 100));
            }
            if (this.RadioButtonOnn.Checked)
            {
                num2 = decimal.Divide(num, new decimal((long) 100));
            }
            this.LabelTip.Text = "في حال كان لديك مادة سعرها  100  مثلا فأنها ستصبح   " + num2.ToString();
        }

        private void R(object A, EventArgs R)
        {
            this.TimerStartUp.Enabled = false;
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        try
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            DataTable dataTable = new DataTable();
                            string selectCommandText = "SELECT [GroupID], [GroupName] FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                            dataTable.Clear();
                            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                            adapter.Fill(dataTable);
                            this.A.Close();
                            if (dataTable.Rows.Count > 0)
                            {
                                this.ComboBoxGroup.ValueMember = "GroupID";
                                this.ComboBoxGroup.DisplayMember = "GroupName";
                                this.ComboBoxGroup.DataSource = dataTable;
                                this.ComboBoxGroup.SelectedIndex = -1;
                            }
                        }
                        catch (Exception exception1)
                        {
                            Exception ex = exception1;
                            ProjectData.SetProjectError(ex);
                            Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                            ProjectData.ClearProjectError();
                            break;
                        }
                        this.TxTTitle.Text = this.Text;
                        this.TxTTitle.ForeColor = Color.DarkGreen;
                        this.TxTTitle.Font = new Font("Tahoma", 12f);
                        if (Conversion.Val(this.TxTItems.Text) == 0.0)
                        {
                            Interaction.MsgBox("يجب تحديد اكثر من مادة المطلوب اجراء تعديل عليها", MsgBoxStyle.ApplicationModal, null);
                            base.Dispose();
                        }
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        this.TxTItems.Text = Conversions.ToString((double) (Conversion.Val(this.TxTItems.Text) + 1.0));
                    }
                    num2++;
                }
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
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
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void S(object A, EventArgs R)
        {
            if (!this.RadioButtonMiwiPlus.Checked & !this.RadioButtonMiwiMinas.Checked)
            {
                Interaction.MsgBox("حدد طريقة حساب النسبة", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    A.D.A.A.GV.ClearSelection();
                    A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                    A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                    int num = A.D.A.A.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            this.A = true;
                            this.CheckBoxCon.BackColor = Color.White;
                            this.CheckBoxCon.Checked = false;
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        bool flag2 = false;
                        int num3 = 0;
                        flag2 = Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value);
                        num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                        string str = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricCost"].Value);
                        decimal num4 = new decimal(Conversion.Val(str.Replace(",", "")));
                        string str2 = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricSale"].Value);
                        decimal num5 = new decimal(Conversion.Val(str2.Replace(",", "")));
                        string str3 = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricLess"].Value);
                        decimal num6 = new decimal(Conversion.Val(str3.Replace(",", "")));
                        decimal num7 = new decimal(Convert.ToDouble(num4) * (Conversion.Val(this.TxTEditeSaleMiWi.Text) / 100.0));
                        decimal num8 = new decimal(Convert.ToDouble(num5) * (Conversion.Val(this.TxTEditeSaleMiWi.Text) / 100.0));
                        decimal num9 = new decimal(Convert.ToDouble(num6) * (Conversion.Val(this.TxTEditeSaleMiWi.Text) / 100.0));
                        decimal num10 = 0M;
                        decimal num11 = 0M;
                        decimal num12 = 0M;
                        if (this.RadioButtonMiwiPlus.Checked)
                        {
                            num10 = decimal.Add(num4, num7);
                            num11 = decimal.Add(num5, num8);
                            num6 = decimal.Add(num6, num9);
                        }
                        if (this.RadioButtonMiwiMinas.Checked)
                        {
                            num10 = decimal.Subtract(num4, num7);
                            num11 = decimal.Subtract(num5, num8);
                            num6 = decimal.Subtract(num6, num9);
                        }
                        if (flag2)
                        {
                            string cmdText = "UPDATE [TaNNMaterial] SET [MaterialPricCost] = @MaterialPricCost, [MaterialPricSale] = @MaterialPricSale, [MaterialPricLess] = @MaterialPricLess WHERE [MaterialID] = @MaterialID";
                            if (!this.CheckBoxMiwiCost.Checked)
                            {
                                cmdText = cmdText.Replace("[MaterialPricCost] = @MaterialPricCost, ", "");
                            }
                            if (!this.CheckBoxMiWiSale.Checked)
                            {
                                cmdText = cmdText.Replace("[MaterialPricSale] = @MaterialPricSale, ", "");
                            }
                            if (!this.CheckBoxMiWiLess.Checked)
                            {
                                cmdText = cmdText.Replace("[MaterialPricLess] = @MaterialPricLess", "");
                            }
                            cmdText = cmdText.Replace("UPDATE [TaNNMaterial] SET ,", "UPDATE [TaNNMaterial] SET ").Replace("UPDATE [TaNNMaterial] SET , ", "UPDATE [TaNNMaterial] SET ").Replace("UPDATE [TaNNMaterial] SET ,  ", "UPDATE [TaNNMaterial] SET ").Replace(", WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID").Replace(",  WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID").Replace(",   WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID");
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand(cmdText, this.A);
                            command.Parameters.AddWithValue("MaterialID", num3);
                            if (this.CheckBoxMiwiCost.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialPricCost", num10.ToString(A.PR.VR));
                            }
                            if (this.CheckBoxMiWiSale.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialPricSale", num11.ToString(A.PR.VR));
                            }
                            if (this.CheckBoxMiWiLess.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialPricLess", num12.ToString(A.PR.VR));
                            }
                            command.ExecuteNonQuery();
                            this.A.Close();
                        }
                        num2++;
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
        }

        private void T(object A, EventArgs R)
        {
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.A = true;
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = 0;
                    num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialExpDate] = @MaterialExpDate WHERE [MaterialID] = @MaterialID", this.A);
                        command.Parameters.AddWithValue("MaterialID", num3);
                        if (this.ChKActiveDate.Checked)
                        {
                            command.Parameters.AddWithValue("MaterialExpDate", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("MaterialExpDate", this.MaterialExpDate.Value.ToString("yyyy/MM/dd"));
                        }
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void U(object A, EventArgs R)
        {
            try
            {
                if (this.TxTDis.Text == null)
                {
                    Interaction.MsgBox(A.PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.TxTDis.Focus();
                }
                else
                {
                    A.D.A.A.GV.ClearSelection();
                    A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                    A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                    int num = A.D.A.A.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            this.A = true;
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        int num3 = 0;
                        num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                        if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialDisMiWi] = @MaterialDisMiWi WHERE [MaterialID] = @MaterialID", this.A);
                            command.Parameters.AddWithValue("MaterialID", num3);
                            command.Parameters.AddWithValue("MaterialDisMiWi", Conversion.Val(this.TxTDis.Text.Replace(",", "")));
                            command.ExecuteNonQuery();
                            this.A.Close();
                        }
                        num2++;
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

        private void V(object A, EventArgs R)
        {
            this.R();
        }

        private void W(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.A = true;
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = 0;
                    num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialNote] = @MaterialNote WHERE [MaterialID] = @MaterialID", this.A);
                        command.Parameters.AddWithValue("MaterialID", num3);
                        command.Parameters.AddWithValue("MaterialNote", this.TxTNote.Text.Trim());
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void Y(object A, EventArgs R)
        {
            this.CheckBoxCon.Checked = false;
        }

        private void Z(object A, EventArgs R)
        {
            if (!this.RadioButtonBay.Checked & !this.RadioButtonOnn.Checked)
            {
                Interaction.MsgBox("حدد طريقة حساب النسبة", MsgBoxStyle.ApplicationModal, null);
            }
            else if (!this.CheckBoxCon.Checked)
            {
                Interaction.MsgBox("يجب تأكيد صحة ناتج المثال", MsgBoxStyle.ApplicationModal, null);
                this.CheckBoxCon.BackColor = Color.Yellow;
            }
            else
            {
                try
                {
                    A.D.A.A.GV.ClearSelection();
                    A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                    A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                    int num = A.D.A.A.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            this.A = true;
                            this.CheckBoxCon.BackColor = Color.White;
                            this.CheckBoxCon.Checked = false;
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        bool flag3 = false;
                        int num3 = 0;
                        flag3 = Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value);
                        num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                        string str = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricCost"].Value);
                        decimal num4 = new decimal(Conversion.Val(str.Replace(",", "")));
                        string str2 = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricSale"].Value);
                        decimal num5 = new decimal(Conversion.Val(str2.Replace(",", "")));
                        string str3 = Conversions.ToString(A.D.A.A.GV.Rows[num2].Cells["MaterialPricLess"].Value);
                        decimal num6 = new decimal(Conversion.Val(str3.Replace(",", "")));
                        decimal num7 = num4;
                        decimal num8 = num5;
                        decimal num9 = num6;
                        decimal num10 = new decimal(Conversion.Val(this.TxTDolar.Text));
                        if (this.RadioButtonBay.Checked)
                        {
                            num7 = decimal.Multiply(num7, num10);
                            num8 = decimal.Multiply(num8, num10);
                            num6 = decimal.Multiply(num6, num10);
                        }
                        if (this.RadioButtonOnn.Checked)
                        {
                            if (decimal.Compare(num7, decimal.Zero) > 0)
                            {
                                num7 = decimal.Divide(num7, num10);
                            }
                            if (decimal.Compare(num8, decimal.Zero) > 0)
                            {
                                num8 = decimal.Divide(num8, num10);
                            }
                            if (decimal.Compare(num6, decimal.Zero) > 0)
                            {
                                num6 = decimal.Divide(num6, num10);
                            }
                        }
                        if (flag3)
                        {
                            string cmdText = "UPDATE [TaNNMaterial] SET [MaterialPricCost] = @MaterialPricCost, [MaterialPricSale] = @MaterialPricSale, [MaterialPricLess] = @MaterialPricLess WHERE [MaterialID] = @MaterialID";
                            if (!this.CheckBoxCostDo.Checked)
                            {
                                cmdText = cmdText.Replace("[MaterialPricCost] = @MaterialPricCost, ", "");
                            }
                            if (!this.CheckBoxSaleDo.Checked)
                            {
                                cmdText = cmdText.Replace("[MaterialPricSale] = @MaterialPricSale, ", "");
                            }
                            if (!this.CheckBoxLessDo.Checked)
                            {
                                cmdText = cmdText.Replace("[MaterialPricLess] = @MaterialPricLess", "");
                            }
                            cmdText = cmdText.Replace("UPDATE [TaNNMaterial] SET ,", "UPDATE [TaNNMaterial] SET ").Replace("UPDATE [TaNNMaterial] SET , ", "UPDATE [TaNNMaterial] SET ").Replace("UPDATE [TaNNMaterial] SET ,  ", "UPDATE [TaNNMaterial] SET ").Replace(", WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID").Replace(",  WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID").Replace(",   WHERE [MaterialID] = @MaterialID", " WHERE [MaterialID] = @MaterialID");
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand(cmdText, this.A);
                            command.Parameters.AddWithValue("MaterialID", num3);
                            if (this.CheckBoxCostDo.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialPricCost", num7.ToString(A.PR.VR));
                            }
                            if (this.CheckBoxSaleDo.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialPricSale", num8.ToString(A.PR.VR));
                            }
                            if (this.CheckBoxLessDo.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialPricLess", num9.ToString(A.PR.VR));
                            }
                            command.ExecuteNonQuery();
                            this.A.Close();
                        }
                        num2++;
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

        internal virtual TabControl TabControl1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStrip ToolStripStatus
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripProgressBar ToolStripProgressBar1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
                ToolStripButton a = this.A;
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

        internal virtual TabPage TabPage6
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TabPage TabPage7
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabPage TabPage8
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TabPage TabPage9
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TabPage TabPage10
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ToolStripLabel ToolStripLabel2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripLabel TxTItems
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerStartUp
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTQNow
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                    a.KeyPress -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                    a.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonQNow
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTLessQ
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                    r.KeyPress -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                    r.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonQLess
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonGroup
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual ComboBox ComboBoxGroup
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxNoGroup
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                CheckBox a = this.A;
                if (a != null)
                {
                    a.CheckedChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CheckedChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonDateExp
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual CheckBox ChKActiveDate
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual DateTimePicker MaterialExpDate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CheckBoxViewNote
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonViewNote
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTNote
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonNote
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual CheckBox CheckBoxStopSale
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonStopSale
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox TxTDar
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.W);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.I);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.TextChanged -= handler;
                    q.KeyPress -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.TextChanged += handler;
                    q.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonDar
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox TxTDis
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
                TextBox i = this.I;
                if (i != null)
                {
                    i.TextChanged -= handler;
                    i.KeyPress -= handler2;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.TextChanged += handler;
                    i.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonDis
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual TabPage TabPage11
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual RadioButton RadioButtonOnn
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
                RadioButton a = this.A;
                if (a != null)
                {
                    a.CheckedChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton RadioButtonBay
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                RadioButton r = this.R;
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

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox TxTDolar
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox d = this.D;
                if (d != null)
                {
                    d.TextChanged -= handler;
                    d.KeyPress -= handler2;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.TextChanged += handler;
                    d.KeyPress += handler2;
                }
            }
        }

        internal virtual Label LabelTip
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
                Label p = this.P;
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

        internal virtual CheckBox CheckBoxCon
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
                CheckBox i = this.I;
                if (i != null)
                {
                    i.CheckedChanged -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.CheckedChanged += handler;
                }
            }
        }

        internal virtual TabPage TabPage12
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual CheckBox CheckBoxValLess
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual CheckBox CheckBoxValSale
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual CheckBox CheckBoxValCost
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual TextBox TxTEditeSaleVal
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AR);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.D);
                TextBox f = this.F;
                if (f != null)
                {
                    f.TextChanged -= handler;
                    f.KeyPress -= handler2;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.TextChanged += handler;
                    f.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonEditeSaleVal
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabPage TabPage13
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual CheckBox CheckBoxMiWiLess
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual CheckBox CheckBoxMiWiSale
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual CheckBox CheckBoxMiwiCost
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Button ButtonMiwi
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual RadioButton RadioButtonMiwiPlus
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual RadioButton RadioButtonMiwiMinas
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTEditeSaleMiWi
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PR);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.F);
                TextBox h = this.H;
                if (h != null)
                {
                    h.TextChanged -= handler;
                    h.KeyPress -= handler2;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.TextChanged += handler;
                    h.KeyPress += handler2;
                }
            }
        }

        internal virtual CheckBox CheckBoxLessDo
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual CheckBox CheckBoxSaleDo
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual CheckBox CheckBoxCostDo
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Button ButtonDo
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
                Button e = this.E;
                if (e != null)
                {
                    e.Click -= handler;
                }
                this.E = value;
                e = this.E;
                if (e != null)
                {
                    e.Click += handler;
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }
    }
}

