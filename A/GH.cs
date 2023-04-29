namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO.Ports;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class GH : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonOk")]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxIsAudio"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxGVAutoSize")]
        private CheckBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage1")]
        private TabPage A;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("ComboBoxNPrinterName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("CheckBoxQPrinterShowSelect"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox P;
        [AccessedThroughProperty("CheckBoxQPrinterPrivew"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox Q;
        [CompilerGenerated, AccessedThroughProperty("ComboBoxQPrinterName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxNPrinterPrivew")]
        private CheckBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxNPrinterShowSelect")]
        private CheckBox D;
        [AccessedThroughProperty("SalListNoGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3"), CompilerGenerated]
        private TabPage P;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxQPrinterSize")]
        private ComboBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox1"), CompilerGenerated]
        private PictureBox A;
        [AccessedThroughProperty("ComboBoxPolySerialPorts"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox Q;
        [AccessedThroughProperty("ButtonPoly"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxComboBoxPolyDisply"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox H;
        [CompilerGenerated, AccessedThroughProperty("SerialPortPoly"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SerialPort A;
        [AccessedThroughProperty("TabPage4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage Q;
        [AccessedThroughProperty("PictureBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox R;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("ComboBoxNPrinterSize"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox I;
        [AccessedThroughProperty("SaleWinHideTab"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox T;
        [AccessedThroughProperty("CheckBoxShowFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox X;
        [AccessedThroughProperty("CheckBoxPrintNAuto"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxPrintQAuto")]
        private CheckBox E;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxMMSortGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("NoPrinter")]
        private CheckBox U;
        [CompilerGenerated, AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("PrintCopie"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("RadioButton2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private RadioButton A;
        [CompilerGenerated, AccessedThroughProperty("RadioButton1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RadioButton R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxShowToutch")]
        private CheckBox L;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("AlarmShowSale")]
        private CheckBox N;
        [CompilerGenerated, AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("TabPage5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage I;
        [CompilerGenerated, AccessedThroughProperty("SSViewNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox V;
        [AccessedThroughProperty("SSViewDar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox Y;
        [AccessedThroughProperty("SSViewDis"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox O;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("SSViewUnit")]
        private CheckBox B;
        [AccessedThroughProperty("SSViewBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox S;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox9")]
        private GroupBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("SaleWinSize"), CompilerGenerated]
        private ComboBox D;
        [AccessedThroughProperty("TabControl2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl R;
        [CompilerGenerated, AccessedThroughProperty("TabPage6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage D;
        [CompilerGenerated, AccessedThroughProperty("TabPage7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage F;
        [CompilerGenerated, AccessedThroughProperty("CheckBoSaleProft"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox Z;
        [AccessedThroughProperty("TrimBarCode16"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBoxMM")]
        private GroupBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckPrintActivCloud")]
        private CheckBox C;
        [AccessedThroughProperty("ButtonPs"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("PrintOrdarMultiGroup"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox J;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("IsShowWindowsAfterFinish")]
        private CheckBox W;

        public GH()
        {
            base.Load += new EventHandler(this.R);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(GH));
            this.CheckBoxIsAudio = new CheckBox();
            this.CheckBoxGVAutoSize = new CheckBox();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.IsShowWindowsAfterFinish = new CheckBox();
            this.TrimBarCode16 = new CheckBox();
            this.GroupBox9 = new GroupBox();
            this.SaleWinSize = new ComboBox();
            this.AlarmShowSale = new CheckBox();
            this.CheckBoxShowToutch = new CheckBox();
            this.GroupBox1 = new GroupBox();
            this.RadioButton2 = new RadioButton();
            this.RadioButton1 = new RadioButton();
            this.CheckBoxMMSortGroup = new CheckBox();
            this.CheckBoxShowFinish = new CheckBox();
            this.SaleWinHideTab = new CheckBox();
            this.SalListNoGroup = new CheckBox();
            this.TabPage2 = new TabPage();
            this.TabControl2 = new TabControl();
            this.TabPage6 = new TabPage();
            this.GroupBox2 = new GroupBox();
            this.ComboBoxNPrinterSize = new ComboBox();
            this.GroupBox6 = new GroupBox();
            this.PrintCopie = new TextBox();
            this.GroupBox7 = new GroupBox();
            this.ComboBoxNPrinterName = new ComboBox();
            this.CheckBoxPrintNAuto = new CheckBox();
            this.CheckBoxNPrinterShowSelect = new CheckBox();
            this.CheckBoxNPrinterPrivew = new CheckBox();
            this.TabPage7 = new TabPage();
            this.GroupBoxMM = new GroupBox();
            this.CheckPrintActivCloud = new CheckBox();
            this.ButtonPs = new Button();
            this.PrintOrdarMultiGroup = new CheckBox();
            this.GroupBox8 = new GroupBox();
            this.ComboBoxQPrinterName = new ComboBox();
            this.GroupBox5 = new GroupBox();
            this.ComboBoxQPrinterSize = new ComboBox();
            this.CheckBoxPrintQAuto = new CheckBox();
            this.CheckBoxQPrinterShowSelect = new CheckBox();
            this.CheckBoxQPrinterPrivew = new CheckBox();
            this.NoPrinter = new CheckBox();
            this.TabPage3 = new TabPage();
            this.ButtonPoly = new Button();
            this.CheckBoxComboBoxPolyDisply = new CheckBox();
            this.ComboBoxPolySerialPorts = new ComboBox();
            this.PictureBox1 = new PictureBox();
            this.TabPage4 = new TabPage();
            this.Label1 = new Label();
            this.PictureBox2 = new PictureBox();
            this.TabPage5 = new TabPage();
            this.CheckBoSaleProft = new CheckBox();
            this.SSViewNote = new CheckBox();
            this.SSViewDar = new CheckBox();
            this.SSViewDis = new CheckBox();
            this.SSViewUnit = new CheckBox();
            this.SSViewBarCode = new CheckBox();
            this.SerialPortPoly = new SerialPort(this.A);
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.GroupBoxMM.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage3.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.TabPage4.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.TabPage5.SuspendLayout();
            base.SuspendLayout();
            this.CheckBoxIsAudio.AutoSize = true;
            this.CheckBoxIsAudio.Checked = true;
            this.CheckBoxIsAudio.CheckState = CheckState.Checked;
            this.CheckBoxIsAudio.Location = new Point(0x1bf, 0x2b);
            this.CheckBoxIsAudio.Name = "CheckBoxIsAudio";
            this.CheckBoxIsAudio.Size = new Size(0xd0, 20);
            this.CheckBoxIsAudio.TabIndex = 0x61;
            this.CheckBoxIsAudio.Text = "تأكيد عملية البيع من خلال الصوت";
            this.CheckBoxIsAudio.UseVisualStyleBackColor = true;
            this.CheckBoxGVAutoSize.AutoSize = true;
            this.CheckBoxGVAutoSize.Checked = true;
            this.CheckBoxGVAutoSize.CheckState = CheckState.Checked;
            this.CheckBoxGVAutoSize.Location = new Point(0xdd, 0x1d);
            this.CheckBoxGVAutoSize.Name = "CheckBoxGVAutoSize";
            this.CheckBoxGVAutoSize.Size = new Size(0x19e, 20);
            this.CheckBoxGVAutoSize.TabIndex = 0x60;
            this.CheckBoxGVAutoSize.Text = "ضغط اعمدة قائمة المواد المباعة (سلة المبيعات) وتنسيقها (مستحسن)";
            this.CheckBoxGVAutoSize.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x2c3, 0x22);
            this.TxTTitle.TabIndex = 0x62;
            this.TxTTitle.Text = "إعدادات شاشة البيع";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x2c3, 0x1a1);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 100;
            this.TabPage1.Controls.Add(this.IsShowWindowsAfterFinish);
            this.TabPage1.Controls.Add(this.TrimBarCode16);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.AlarmShowSale);
            this.TabPage1.Controls.Add(this.CheckBoxShowToutch);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.CheckBoxMMSortGroup);
            this.TabPage1.Controls.Add(this.CheckBoxShowFinish);
            this.TabPage1.Controls.Add(this.SaleWinHideTab);
            this.TabPage1.Controls.Add(this.SalListNoGroup);
            this.TabPage1.Controls.Add(this.CheckBoxIsAudio);
            this.TabPage1.Location = new Point(4, 0x2e);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x2bb, 0x16f);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "  إعدادات شاشة البيع العامة  ";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.IsShowWindowsAfterFinish.AutoSize = true;
            this.IsShowWindowsAfterFinish.Checked = true;
            this.IsShowWindowsAfterFinish.CheckState = CheckState.Checked;
            this.IsShowWindowsAfterFinish.Location = new Point(170, 0xab);
            this.IsShowWindowsAfterFinish.Name = "IsShowWindowsAfterFinish";
            this.IsShowWindowsAfterFinish.Size = new Size(0x1e5, 20);
            this.IsShowWindowsAfterFinish.TabIndex = 0x71;
            this.IsShowWindowsAfterFinish.Text = "عند انهاء الفاتورة، اظهر شاشة الاستعداد وعدم انشاء فاتورة جديدة بهدف عدم تعليقها";
            this.IsShowWindowsAfterFinish.UseVisualStyleBackColor = true;
            this.TrimBarCode16.AutoSize = true;
            this.TrimBarCode16.Location = new Point(0xac, 0x148);
            this.TrimBarCode16.Name = "TrimBarCode16";
            this.TrimBarCode16.Size = new Size(0x1e3, 20);
            this.TrimBarCode16.TabIndex = 0x70;
            this.TrimBarCode16.Text = "معالجة قاريء الباركود الطول واختصر الكود فقط الى 16 بت، لا ينصح بتفعيل هذا الخيار.";
            this.TrimBarCode16.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.SaleWinSize);
            this.GroupBox9.Location = new Point(0xb1, 0x100);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(200, 0x39);
            this.GroupBox9.TabIndex = 0x6f;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "حجم شاشة البيع";
            this.SaleWinSize.Dock = DockStyle.Fill;
            this.SaleWinSize.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SaleWinSize.FormattingEnabled = true;
            object[] items = new object[] { "9.75", "10.75", "11.75" };
            this.SaleWinSize.Items.AddRange(items);
            this.SaleWinSize.Location = new Point(3, 0x13);
            this.SaleWinSize.Name = "SaleWinSize";
            this.SaleWinSize.Size = new Size(0xc2, 0x18);
            this.SaleWinSize.TabIndex = 0;
            this.AlarmShowSale.AutoSize = true;
            this.AlarmShowSale.Checked = true;
            this.AlarmShowSale.CheckState = CheckState.Checked;
            this.AlarmShowSale.Location = new Point(0x43, 0x91);
            this.AlarmShowSale.Name = "AlarmShowSale";
            this.AlarmShowSale.Size = new Size(0x24c, 20);
            this.AlarmShowSale.TabIndex = 110;
            this.AlarmShowSale.Text = "عرض شاشة التنبيه للمواد التي وصلت للحد الأدنى للكمية والمواد منتهية الصلاحية قبل فتح شاشة البيع";
            this.AlarmShowSale.UseVisualStyleBackColor = true;
            this.CheckBoxShowToutch.AutoSize = true;
            this.CheckBoxShowToutch.Checked = true;
            this.CheckBoxShowToutch.CheckState = CheckState.Checked;
            this.CheckBoxShowToutch.Location = new Point(0x1b3, 0x79);
            this.CheckBoxShowToutch.Name = "CheckBoxShowToutch";
            this.CheckBoxShowToutch.Size = new Size(220, 20);
            this.CheckBoxShowToutch.TabIndex = 0x6d;
            this.CheckBoxShowToutch.Text = "اظهار لوحة المفاتيح لشاشة اللمس";
            this.CheckBoxShowToutch.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new Point(0x189, 0x100);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x106, 0x39);
            this.GroupBox1.TabIndex = 0x6b;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "تصميم عرض القوائم";
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new Point(0x1c, 0x17);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new Size(0x44, 20);
            this.RadioButton2.TabIndex = 0x6a;
            this.RadioButton2.Text = "عامودي";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new Point(0x91, 0x17);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new Size(0x66, 20);
            this.RadioButton1.TabIndex = 0x69;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "افقي افتراضي";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.CheckBoxMMSortGroup.AutoSize = true;
            this.CheckBoxMMSortGroup.Checked = true;
            this.CheckBoxMMSortGroup.CheckState = CheckState.Checked;
            this.CheckBoxMMSortGroup.Location = new Point(0x17f, 0x5f);
            this.CheckBoxMMSortGroup.Name = "CheckBoxMMSortGroup";
            this.CheckBoxMMSortGroup.Size = new Size(0x110, 20);
            this.CheckBoxMMSortGroup.TabIndex = 0x68;
            this.CheckBoxMMSortGroup.Text = "فرز المواد في شاشة البيع حسب المجموعات";
            this.CheckBoxMMSortGroup.UseVisualStyleBackColor = true;
            this.CheckBoxShowFinish.AutoSize = true;
            this.CheckBoxShowFinish.Checked = true;
            this.CheckBoxShowFinish.CheckState = CheckState.Checked;
            this.CheckBoxShowFinish.Location = new Point(0xf5, 0x11);
            this.CheckBoxShowFinish.Name = "CheckBoxShowFinish";
            this.CheckBoxShowFinish.Size = new Size(410, 20);
            this.CheckBoxShowFinish.TabIndex = 0x67;
            this.CheckBoxShowFinish.Text = "إظهار نافذة انهاء البيع والمزيد من الخيارات عند الضغط على انهاء الفاتورة";
            this.CheckBoxShowFinish.UseVisualStyleBackColor = true;
            this.SaleWinHideTab.AutoSize = true;
            this.SaleWinHideTab.Location = new Point(0x105, 0x45);
            this.SaleWinHideTab.Name = "SaleWinHideTab";
            this.SaleWinHideTab.Size = new Size(0x18a, 20);
            this.SaleWinHideTab.TabIndex = 0x66;
            this.SaleWinHideTab.Text = "اخفاء تبويب المواد / شاشة اللمس/ البحث المتقدم من شاشة البيع";
            this.SaleWinHideTab.UseVisualStyleBackColor = true;
            this.SalListNoGroup.Location = new Point(0x19, 0xc5);
            this.SalListNoGroup.Name = "SalListNoGroup";
            this.SalListNoGroup.Size = new Size(630, 0x2e);
            this.SalListNoGroup.TabIndex = 0x65;
            this.SalListNoGroup.Text = "بيع المواد بشكل مستقل ومنع تجميع كمية المادة في سجل واحد، يستخدم هذا الخيار ان كنت تريد فصل المادة بسجل مستقل في حال تكرارها بنفس الفاتورة (غير مستحس التفعيل)";
            this.SalListNoGroup.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.TabControl2);
            this.TabPage2.Controls.Add(this.NoPrinter);
            this.TabPage2.Location = new Point(4, 0x2e);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x2bb, 0x16f);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "  طباعة الفواتير | المعاينة | تحديد الطابعات  ";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Dock = DockStyle.Top;
            this.TabControl2.Location = new Point(3, 3);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.Padding = new Point(8, 8);
            this.TabControl2.RightToLeftLayout = true;
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new Size(0x2b5, 0x13c);
            this.TabControl2.SizeMode = TabSizeMode.Fixed;
            this.TabControl2.TabIndex = 0x38;
            this.TabPage6.Controls.Add(this.GroupBox2);
            this.TabPage6.Controls.Add(this.GroupBox6);
            this.TabPage6.Controls.Add(this.GroupBox7);
            this.TabPage6.Controls.Add(this.CheckBoxPrintNAuto);
            this.TabPage6.Controls.Add(this.CheckBoxNPrinterShowSelect);
            this.TabPage6.Controls.Add(this.CheckBoxNPrinterPrivew);
            this.TabPage6.Location = new Point(4, 0x23);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new Padding(3);
            this.TabPage6.Size = new Size(0x2ad, 0x115);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "الفواتير";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.ComboBoxNPrinterSize);
            this.GroupBox2.Location = new Point(0x15d, 0xa1);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x13a, 0x34);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "حجم ونوع الفاتورة";
            this.ComboBoxNPrinterSize.Dock = DockStyle.Fill;
            this.ComboBoxNPrinterSize.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxNPrinterSize.FormattingEnabled = true;
            object[] objArray2 = new object[] { "عربي قياس A4", "عربي قياس A5", "عربي حراري قياس 80", "انجليزي قياس A4", "انجليزي قياس A5", "انجليزي حراري قياس 80", "ضريبية عربي A4", "ضريبية انجليزي A4" };
            this.ComboBoxNPrinterSize.Items.AddRange(objArray2);
            this.ComboBoxNPrinterSize.Location = new Point(3, 0x13);
            this.ComboBoxNPrinterSize.Name = "ComboBoxNPrinterSize";
            this.ComboBoxNPrinterSize.Size = new Size(0x134, 0x18);
            this.ComboBoxNPrinterSize.TabIndex = 0x5f4;
            this.GroupBox6.Controls.Add(this.PrintCopie);
            this.GroupBox6.Location = new Point(0x15d, 0xdb);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x13a, 0x30);
            this.GroupBox6.TabIndex = 0x37;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "عدد نسخ الفاتورة";
            this.PrintCopie.Dock = DockStyle.Top;
            this.PrintCopie.Location = new Point(3, 0x13);
            this.PrintCopie.Name = "PrintCopie";
            this.PrintCopie.RightToLeft = RightToLeft.No;
            this.PrintCopie.Size = new Size(0x134, 0x17);
            this.PrintCopie.TabIndex = 0;
            this.PrintCopie.Text = "1";
            this.PrintCopie.TextAlign = HorizontalAlignment.Center;
            this.GroupBox7.Controls.Add(this.ComboBoxNPrinterName);
            this.GroupBox7.Location = new Point(0x15d, 0x66);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x13a, 0x35);
            this.GroupBox7.TabIndex = 0x39;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "اسم طابعة الفواتير";
            this.ComboBoxNPrinterName.Dock = DockStyle.Fill;
            this.ComboBoxNPrinterName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxNPrinterName.Enabled = false;
            this.ComboBoxNPrinterName.FormattingEnabled = true;
            this.ComboBoxNPrinterName.Location = new Point(3, 0x13);
            this.ComboBoxNPrinterName.Name = "ComboBoxNPrinterName";
            this.ComboBoxNPrinterName.Size = new Size(0x134, 0x18);
            this.ComboBoxNPrinterName.TabIndex = 4;
            this.CheckBoxPrintNAuto.AutoSize = true;
            this.CheckBoxPrintNAuto.Location = new Point(0x196, 0x16);
            this.CheckBoxPrintNAuto.Name = "CheckBoxPrintNAuto";
            this.CheckBoxPrintNAuto.Size = new Size(0x101, 20);
            this.CheckBoxPrintNAuto.TabIndex = 7;
            this.CheckBoxPrintNAuto.Text = "بشكل افتراضي دائماً اطبع فاتورة بعد الانهاء";
            this.CheckBoxPrintNAuto.UseVisualStyleBackColor = true;
            this.CheckBoxNPrinterShowSelect.AutoSize = true;
            this.CheckBoxNPrinterShowSelect.Checked = true;
            this.CheckBoxNPrinterShowSelect.CheckState = CheckState.Checked;
            this.CheckBoxNPrinterShowSelect.Location = new Point(520, 0x4c);
            this.CheckBoxNPrinterShowSelect.Name = "CheckBoxNPrinterShowSelect";
            this.CheckBoxNPrinterShowSelect.Size = new Size(0x8f, 20);
            this.CheckBoxNPrinterShowSelect.TabIndex = 6;
            this.CheckBoxNPrinterShowSelect.Text = "اظهار تحديد الطابعات ";
            this.CheckBoxNPrinterShowSelect.UseVisualStyleBackColor = true;
            this.CheckBoxNPrinterPrivew.AutoSize = true;
            this.CheckBoxNPrinterPrivew.Checked = true;
            this.CheckBoxNPrinterPrivew.CheckState = CheckState.Checked;
            this.CheckBoxNPrinterPrivew.Location = new Point(460, 50);
            this.CheckBoxNPrinterPrivew.Name = "CheckBoxNPrinterPrivew";
            this.CheckBoxNPrinterPrivew.Size = new Size(0xcb, 20);
            this.CheckBoxNPrinterPrivew.TabIndex = 5;
            this.CheckBoxNPrinterPrivew.Text = "اظهار نموذج المعاينة قبل الطباعة";
            this.CheckBoxNPrinterPrivew.UseVisualStyleBackColor = true;
            this.TabPage7.Controls.Add(this.GroupBoxMM);
            this.TabPage7.Controls.Add(this.GroupBox8);
            this.TabPage7.Controls.Add(this.GroupBox5);
            this.TabPage7.Controls.Add(this.CheckBoxPrintQAuto);
            this.TabPage7.Controls.Add(this.CheckBoxQPrinterShowSelect);
            this.TabPage7.Controls.Add(this.CheckBoxQPrinterPrivew);
            this.TabPage7.Location = new Point(4, 0x23);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new Padding(3);
            this.TabPage7.Size = new Size(0x2ad, 0x115);
            this.TabPage7.TabIndex = 1;
            this.TabPage7.Text = "الطلبيات";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.GroupBoxMM.BackColor = Color.WhiteSmoke;
            this.GroupBoxMM.Controls.Add(this.CheckPrintActivCloud);
            this.GroupBoxMM.Controls.Add(this.ButtonPs);
            this.GroupBoxMM.Controls.Add(this.PrintOrdarMultiGroup);
            this.GroupBoxMM.Location = new Point(6, 0x22);
            this.GroupBoxMM.Name = "GroupBoxMM";
            this.GroupBoxMM.Size = new Size(0x14d, 0xca);
            this.GroupBoxMM.TabIndex = 0x3a;
            this.GroupBoxMM.TabStop = false;
            this.GroupBoxMM.Text = "طابعات متعددة حسب المجموعة:";
            this.CheckPrintActivCloud.Dock = DockStyle.Top;
            this.CheckPrintActivCloud.Location = new Point(3, 0x4d);
            this.CheckPrintActivCloud.Name = "CheckPrintActivCloud";
            this.CheckPrintActivCloud.Size = new Size(0x147, 0x34);
            this.CheckPrintActivCloud.TabIndex = 0x33;
            this.CheckPrintActivCloud.Text = "تفعيل استقبال اوامر (طباعة الطلبية، سلة المشتريات) من نسخة الويب السحابية على هذا الجهاز.";
            this.CheckPrintActivCloud.UseVisualStyleBackColor = true;
            this.ButtonPs.Location = new Point(7, 160);
            this.ButtonPs.Name = "ButtonPs";
            this.ButtonPs.Size = new Size(320, 0x21);
            this.ButtonPs.TabIndex = 0x34;
            this.ButtonPs.Text = "ادارة معالج ملف تعريف الطابعات والمجموعات";
            this.ButtonPs.UseVisualStyleBackColor = true;
            this.PrintOrdarMultiGroup.Dock = DockStyle.Top;
            this.PrintOrdarMultiGroup.Location = new Point(3, 0x13);
            this.PrintOrdarMultiGroup.Name = "PrintOrdarMultiGroup";
            this.PrintOrdarMultiGroup.Size = new Size(0x147, 0x3a);
            this.PrintOrdarMultiGroup.TabIndex = 0x35;
            this.PrintOrdarMultiGroup.Text = "تفعيل الطابعات المتعددة، طباعة الطلبية (سلة المشتريات) حسب مجموعة المواد على طابعات متعددة";
            this.PrintOrdarMultiGroup.UseVisualStyleBackColor = true;
            this.GroupBox8.Controls.Add(this.ComboBoxQPrinterName);
            this.GroupBox8.Location = new Point(350, 0x7d);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x13d, 0x35);
            this.GroupBox8.TabIndex = 0x39;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "اسم طابعة الطلبية";
            this.ComboBoxQPrinterName.Dock = DockStyle.Fill;
            this.ComboBoxQPrinterName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxQPrinterName.Enabled = false;
            this.ComboBoxQPrinterName.FormattingEnabled = true;
            this.ComboBoxQPrinterName.Location = new Point(3, 0x13);
            this.ComboBoxQPrinterName.Name = "ComboBoxQPrinterName";
            this.ComboBoxQPrinterName.Size = new Size(0x137, 0x18);
            this.ComboBoxQPrinterName.TabIndex = 4;
            this.GroupBox5.Controls.Add(this.ComboBoxQPrinterSize);
            this.GroupBox5.Location = new Point(350, 0xb8);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x13d, 0x34);
            this.GroupBox5.TabIndex = 5;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "حجم الطلبية الافتراضي:";
            this.ComboBoxQPrinterSize.Dock = DockStyle.Fill;
            this.ComboBoxQPrinterSize.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxQPrinterSize.FormattingEnabled = true;
            object[] objArray3 = new object[] { "طابعة حرارية ورق فقط Roll قياس 80" };
            this.ComboBoxQPrinterSize.Items.AddRange(objArray3);
            this.ComboBoxQPrinterSize.Location = new Point(3, 0x13);
            this.ComboBoxQPrinterSize.Name = "ComboBoxQPrinterSize";
            this.ComboBoxQPrinterSize.Size = new Size(0x137, 0x18);
            this.ComboBoxQPrinterSize.TabIndex = 4;
            this.CheckBoxPrintQAuto.AutoSize = true;
            this.CheckBoxPrintQAuto.Location = new Point(0x199, 0x22);
            this.CheckBoxPrintQAuto.Name = "CheckBoxPrintQAuto";
            this.CheckBoxPrintQAuto.Size = new Size(0x102, 20);
            this.CheckBoxPrintQAuto.TabIndex = 8;
            this.CheckBoxPrintQAuto.Text = "بشكل افتراضي دائماً اطبع طلبية بعد الانهاء";
            this.CheckBoxPrintQAuto.UseVisualStyleBackColor = true;
            this.CheckBoxQPrinterShowSelect.AutoSize = true;
            this.CheckBoxQPrinterShowSelect.Checked = true;
            this.CheckBoxQPrinterShowSelect.CheckState = CheckState.Checked;
            this.CheckBoxQPrinterShowSelect.Location = new Point(0x20f, 0x58);
            this.CheckBoxQPrinterShowSelect.Name = "CheckBoxQPrinterShowSelect";
            this.CheckBoxQPrinterShowSelect.Size = new Size(0x8b, 20);
            this.CheckBoxQPrinterShowSelect.TabIndex = 3;
            this.CheckBoxQPrinterShowSelect.Text = "اظهار تحديد الطابعات";
            this.CheckBoxQPrinterShowSelect.UseVisualStyleBackColor = true;
            this.CheckBoxQPrinterPrivew.AutoSize = true;
            this.CheckBoxQPrinterPrivew.Checked = true;
            this.CheckBoxQPrinterPrivew.CheckState = CheckState.Checked;
            this.CheckBoxQPrinterPrivew.Location = new Point(0x1cf, 0x3e);
            this.CheckBoxQPrinterPrivew.Name = "CheckBoxQPrinterPrivew";
            this.CheckBoxQPrinterPrivew.Size = new Size(0xcb, 20);
            this.CheckBoxQPrinterPrivew.TabIndex = 2;
            this.CheckBoxQPrinterPrivew.Text = "اظهار نموذج المعاينة قبل الطباعة";
            this.CheckBoxQPrinterPrivew.UseVisualStyleBackColor = true;
            this.NoPrinter.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.NoPrinter.Checked = true;
            this.NoPrinter.CheckState = CheckState.Checked;
            this.NoPrinter.Location = new Point(3, 0x145);
            this.NoPrinter.Name = "NoPrinter";
            this.NoPrinter.Size = new Size(0x2ad, 0x1b);
            this.NoPrinter.TabIndex = 0x38;
            this.NoPrinter.Text = "إزالة تأثير الطابعات العشوائية للحجم والقياس";
            this.NoPrinter.UseVisualStyleBackColor = false;
            this.TabPage3.Controls.Add(this.ButtonPoly);
            this.TabPage3.Controls.Add(this.CheckBoxComboBoxPolyDisply);
            this.TabPage3.Controls.Add(this.ComboBoxPolySerialPorts);
            this.TabPage3.Controls.Add(this.PictureBox1);
            this.TabPage3.Location = new Point(4, 0x2e);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new Padding(3);
            this.TabPage3.Size = new Size(0x2bb, 0x16f);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "  شاشة العميل | عرض السعر  ";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonPoly.Location = new Point(0x18a, 0x7e);
            this.ButtonPoly.Name = "ButtonPoly";
            this.ButtonPoly.Size = new Size(220, 0x1f);
            this.ButtonPoly.TabIndex = 3;
            this.ButtonPoly.Text = "تأكيد";
            this.ButtonPoly.UseVisualStyleBackColor = true;
            this.CheckBoxComboBoxPolyDisply.AutoSize = true;
            this.CheckBoxComboBoxPolyDisply.Location = new Point(0x1dc, 0x55);
            this.CheckBoxComboBoxPolyDisply.Name = "CheckBoxComboBoxPolyDisply";
            this.CheckBoxComboBoxPolyDisply.Size = new Size(0x8a, 20);
            this.CheckBoxComboBoxPolyDisply.TabIndex = 2;
            this.CheckBoxComboBoxPolyDisply.Text = "تفعيل شاشة العميل";
            this.CheckBoxComboBoxPolyDisply.UseVisualStyleBackColor = true;
            this.ComboBoxPolySerialPorts.FormattingEnabled = true;
            this.ComboBoxPolySerialPorts.Location = new Point(0x18a, 0x29);
            this.ComboBoxPolySerialPorts.Name = "ComboBoxPolySerialPorts";
            this.ComboBoxPolySerialPorts.Size = new Size(220, 0x18);
            this.ComboBoxPolySerialPorts.TabIndex = 1;
            this.PictureBox1.Image = A.F.PolyCustomer;
            this.PictureBox1.Location = new Point(0x1f, 0x29);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x13d, 0xf4);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            this.TabPage4.Controls.Add(this.Label1);
            this.TabPage4.Controls.Add(this.PictureBox2);
            this.TabPage4.Location = new Point(4, 0x2e);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new Padding(3);
            this.TabPage4.Size = new Size(0x2bb, 0x16f);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "ربط درج الكاش";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.Label1.Location = new Point(0x14b, 0x31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x14b, 0x4d);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "يجب توصيل درج الكاش مع الطابعة، ويمكنك ضبط اعدادات الطابعة لفتح الدرج عند الطباعة او ضغط مفتاح F1";
            this.PictureBox2.Image = (Image) manager.GetObject("PictureBox2.Image");
            this.PictureBox2.Location = new Point(0x11, 0x1d);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0x134, 0xd9);
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.TabStop = false;
            this.TabPage5.Controls.Add(this.CheckBoSaleProft);
            this.TabPage5.Controls.Add(this.SSViewNote);
            this.TabPage5.Controls.Add(this.SSViewDar);
            this.TabPage5.Controls.Add(this.SSViewDis);
            this.TabPage5.Controls.Add(this.SSViewUnit);
            this.TabPage5.Controls.Add(this.CheckBoxGVAutoSize);
            this.TabPage5.Controls.Add(this.SSViewBarCode);
            this.TabPage5.Location = new Point(4, 0x2e);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new Size(0x2bb, 0x16f);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "اخفاء/إظهار الأعمدة";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.CheckBoSaleProft.AutoSize = true;
            this.CheckBoSaleProft.Location = new Point(0x108, 0xc5);
            this.CheckBoSaleProft.Name = "CheckBoSaleProft";
            this.CheckBoSaleProft.Size = new Size(0x173, 20);
            this.CheckBoSaleProft.TabIndex = 0x61;
            this.CheckBoSaleProft.Text = "عرض عامود ربح المواد في شاشة البيع ( متاح فقط للمدير العام)";
            this.CheckBoSaleProft.UseVisualStyleBackColor = true;
            this.SSViewNote.AutoSize = true;
            this.SSViewNote.Checked = true;
            this.SSViewNote.CheckState = CheckState.Checked;
            this.SSViewNote.Location = new Point(0x1e4, 0xab);
            this.SSViewNote.Name = "SSViewNote";
            this.SSViewNote.Size = new Size(0x97, 20);
            this.SSViewNote.TabIndex = 4;
            this.SSViewNote.Text = "عرض عامود الملاحظات";
            this.SSViewNote.UseVisualStyleBackColor = true;
            this.SSViewDar.AutoSize = true;
            this.SSViewDar.Checked = true;
            this.SSViewDar.CheckState = CheckState.Checked;
            this.SSViewDar.Location = new Point(0x1f7, 0x91);
            this.SSViewDar.Name = "SSViewDar";
            this.SSViewDar.Size = new Size(0x84, 20);
            this.SSViewDar.TabIndex = 3;
            this.SSViewDar.Text = "عرض عامود الضريبة";
            this.SSViewDar.UseVisualStyleBackColor = true;
            this.SSViewDis.AutoSize = true;
            this.SSViewDis.Checked = true;
            this.SSViewDis.CheckState = CheckState.Checked;
            this.SSViewDis.Location = new Point(0x1fa, 0x77);
            this.SSViewDis.Name = "SSViewDis";
            this.SSViewDis.Size = new Size(0x81, 20);
            this.SSViewDis.TabIndex = 2;
            this.SSViewDis.Text = "عرض عامود الخصم";
            this.SSViewDis.UseVisualStyleBackColor = true;
            this.SSViewUnit.AutoSize = true;
            this.SSViewUnit.Checked = true;
            this.SSViewUnit.CheckState = CheckState.Checked;
            this.SSViewUnit.Location = new Point(0x1fa, 0x5d);
            this.SSViewUnit.Name = "SSViewUnit";
            this.SSViewUnit.Size = new Size(0x81, 20);
            this.SSViewUnit.TabIndex = 1;
            this.SSViewUnit.Text = "عرض عامود الوحدة";
            this.SSViewUnit.UseVisualStyleBackColor = true;
            this.SSViewBarCode.AutoSize = true;
            this.SSViewBarCode.Checked = true;
            this.SSViewBarCode.CheckState = CheckState.Checked;
            this.SSViewBarCode.Location = new Point(0x1c3, 0x43);
            this.SSViewBarCode.Name = "SSViewBarCode";
            this.SSViewBarCode.Size = new Size(0xb8, 20);
            this.SSViewBarCode.TabIndex = 0;
            this.SSViewBarCode.Text = "عرض عامود باركود/رقم المادة";
            this.SSViewBarCode.UseVisualStyleBackColor = true;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(0x10, 470);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x1eb, 0x2d);
            this.ButtonOk.TabIndex = 0x5f;
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
            this.ButtonClose.Location = new Point(0x215, 470);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xac, 0x2d);
            this.ButtonClose.TabIndex = 0x5e;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x2c3, 0x20d);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleSetting";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إعدادات شاشة البيع";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.GroupBoxMM.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.TabPage4.ResumeLayout(false);
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void D(object A, EventArgs R)
        {
            try
            {
                this.SerialPortPoly.PortName = this.ComboBoxPolySerialPorts.Text.Trim();
                this.SerialPortPoly.Open();
                this.SerialPortPoly.Write(PR.VR);
                this.SerialPortPoly.Close();
                AR.H = this.CheckBoxComboBoxPolyDisply.Checked;
                AR.T = this.ComboBoxPolySerialPorts.Text.Trim();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                AR.H = false;
                ProjectData.ClearProjectError();
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

        private void F(object A, EventArgs R)
        {
        }

        private void G(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void H(object A, EventArgs R)
        {
        }

        private void I(object A, EventArgs R)
        {
            AR.X = this.SalListNoGroup.Checked;
        }

        private void P(object A, EventArgs R)
        {
            try
            {
                AR.R = this.CheckBoxIsAudio.Checked;
                AR.X = this.SalListNoGroup.Checked;
                AR.E = this.CheckBoxShowFinish.Checked;
                AR.G = this.SaleWinHideTab.Checked;
                AR.K = this.CheckBoxPrintNAuto.Checked;
                AR.U = this.CheckBoxNPrinterPrivew.Checked;
                AR.X = this.ComboBoxNPrinterName.Text;
                AR.L = this.CheckBoxNPrinterShowSelect.Checked;
                AR.R = this.ComboBoxNPrinterSize.SelectedIndex;
                AR.N = this.CheckBoxPrintQAuto.Checked;
                AR.V = this.CheckBoxQPrinterPrivew.Checked;
                AR.G = this.ComboBoxQPrinterName.Text;
                AR.Y = this.CheckBoxQPrinterShowSelect.Checked;
                AR.P = this.ComboBoxQPrinterSize.SelectedIndex;
                AR.F = this.CheckBoxMMSortGroup.Checked;
                AR.I = (int) Math.Round(Conversion.Val(this.PrintCopie.Text));
                AR.J = this.NoPrinter.Checked;
                AR.UR = this.CheckBoSaleProft.Checked;
                A.D.A.A.SplitContainer3.Panel1Collapsed = this.SaleWinHideTab.Checked;
                AR.LR = this.TrimBarCode16.Checked;
                A.D.A.A.Y();
                A.D.A.A.O();
                if (this.RadioButton1.Checked)
                {
                    AR.D = 1;
                    A.D.A.A.SplitContainer3.Orientation = Orientation.Horizontal;
                    A.D.A.A.SplitContainer3.SplitterDistance = 0xb9;
                }
                if (this.RadioButton2.Checked)
                {
                    AR.D = 2;
                    A.D.A.A.SplitContainer3.Orientation = Orientation.Vertical;
                    A.D.A.A.SplitContainer3.SplitterDistance = 410;
                }
                AR.PR = this.CheckBoxShowToutch.Checked;
                AR.QR = this.AlarmShowSale.Checked;
                AR.FR = this.SSViewBarCode.Checked;
                AR.HR = this.SSViewUnit.Checked;
                AR.TR = this.SSViewDar.Checked;
                AR.XR = this.SSViewDis.Checked;
                AR.GR = this.SSViewNote.Checked;
                if (Application.OpenForms.OfType<QH>().Any<QH>())
                {
                    A.D.A.A.GV.Columns["HSaleBarCode"].Visible = AR.FR;
                    A.D.A.A.GV.Columns["HSaleUnit"].Visible = AR.HR;
                    if (AR.TR)
                    {
                        A.D.A.A.GV.Columns["HSaleDarMiaWi"].Visible = true;
                        A.D.A.A.GV.Columns["HSaleDarVal"].Visible = true;
                    }
                    else
                    {
                        A.D.A.A.GV.Columns["HSaleDarMiaWi"].Visible = false;
                        A.D.A.A.GV.Columns["HSaleDarVal"].Visible = false;
                    }
                    if (AR.XR)
                    {
                        A.D.A.A.GV.Columns["HSaleDisMiaWi"].Visible = true;
                        A.D.A.A.GV.Columns["HSaleDisVal"].Visible = true;
                    }
                    else
                    {
                        A.D.A.A.GV.Columns["HSaleDisMiaWi"].Visible = false;
                        A.D.A.A.GV.Columns["HSaleDisVal"].Visible = false;
                    }
                    A.D.A.A.GV.Columns["HSaleNote"].Visible = AR.GR;
                    A.D.A.A.GV.Columns["HSaleNetProft"].Visible = PR.LR & AR.UR;
                    decimal f = AR.F;
                    A.D.A.A.Font = new Font("Tahoma", Convert.ToSingle(f));
                    A.D.A.A.GV.Columns["HSaleQuantity"].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToSingle(f), FontStyle.Underline);
                    A.D.A.A.GV.Columns["HSalePrice"].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToSingle(f), FontStyle.Underline);
                    A.D.A.A.GV.Columns["HSaleUnit"].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToSingle(f), FontStyle.Underline);
                    A.D.A.A.GV.Columns["HSaleDisMiaWi"].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToSingle(f), FontStyle.Underline);
                    A.D.A.A.GV.Columns["HSaleDisVal"].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToSingle(f), FontStyle.Underline);
                    A.D.A.A.GV.Columns["HSaleNote"].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToSingle(f), FontStyle.Underline);
                }
                AR.F = Conversions.ToDecimal(this.SaleWinSize.Text);
                AR.W = this.PrintOrdarMultiGroup.Checked;
                AR.AR = this.CheckPrintActivCloud.Checked;
                A.D.A.A.ButtonCloudPrinter.Visible = this.CheckPrintActivCloud.Checked;
                AR.P = this.IsShowWindowsAfterFinish.Checked;
                base.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox("Error in Save: " + ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void Q(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void T(object A, EventArgs R)
        {
            if (!this.CheckBoxNPrinterShowSelect.Checked)
            {
                this.ComboBoxNPrinterName.Enabled = true;
            }
            else
            {
                this.ComboBoxNPrinterName.Text = null;
                this.ComboBoxNPrinterName.Enabled = false;
            }
        }

        private void X(object A, EventArgs R)
        {
            if (!this.CheckBoxQPrinterShowSelect.Checked)
            {
                this.ComboBoxQPrinterName.Enabled = true;
            }
            else
            {
                this.ComboBoxQPrinterName.Text = null;
                this.ComboBoxQPrinterName.Enabled = false;
            }
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual Button ButtonOk
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

        internal virtual CheckBox CheckBoxIsAudio
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxGVAutoSize
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox ComboBoxNPrinterName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxQPrinterShowSelect
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                CheckBox p = this.P;
                if (p != null)
                {
                    p.CheckedChanged -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBoxQPrinterPrivew
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ComboBox ComboBoxQPrinterName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox CheckBoxNPrinterPrivew
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CheckBoxNPrinterShowSelect
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                CheckBox d = this.D;
                if (d != null)
                {
                    d.CheckedChanged -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox SalListNoGroup
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                CheckBox f = this.F;
                if (f != null)
                {
                    f.CheckedChanged -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.CheckedChanged += handler;
                }
            }
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ComboBox ComboBoxQPrinterSize
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual ComboBox ComboBoxPolySerialPorts
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonPoly
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

        internal virtual CheckBox CheckBoxComboBoxPolyDisply
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual SerialPort SerialPortPoly
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ComboBox ComboBoxNPrinterSize
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox SaleWinHideTab
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual CheckBox CheckBoxShowFinish
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual CheckBox CheckBoxPrintNAuto
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                CheckBox g = this.G;
                if (g != null)
                {
                    g.CheckedChanged -= handler;
                }
                this.G = value;
                g = this.G;
                if (g != null)
                {
                    g.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBoxPrintQAuto
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual CheckBox CheckBoxMMSortGroup
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual CheckBox NoPrinter
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox PrintCopie
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual RadioButton RadioButton2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual RadioButton RadioButton1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox CheckBoxShowToutch
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual CheckBox AlarmShowSale
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual CheckBox SSViewNote
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual CheckBox SSViewDar
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual CheckBox SSViewDis
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual CheckBox SSViewUnit
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual CheckBox SSViewBarCode
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ComboBox SaleWinSize
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TabControl TabControl2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual TabPage TabPage7
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual CheckBox CheckBoSaleProft
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual CheckBox TrimBarCode16
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual GroupBox GroupBoxMM
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual CheckBox CheckPrintActivCloud
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual Button ButtonPs
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

        internal virtual CheckBox PrintOrdarMultiGroup
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual CheckBox IsShowWindowsAfterFinish
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }
    }
}

