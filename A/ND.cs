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
    public class ND : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox23")]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserAddBy")]
        private Label R;
        [AccessedThroughProperty("GroupBox22"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("InvSaleOtherCuru"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("GroupBox21"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("InvSaleNote")]
        private Label Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox20")]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleMonRod"), CompilerGenerated]
        private Label I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox19")]
        private GroupBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleMonDem")]
        private Label D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox18")]
        private GroupBox D;
        [CompilerGenerated, AccessedThroughProperty("InvSaleMonBak"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox17")]
        private GroupBox F;
        [AccessedThroughProperty("InvSaleMonPay"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label H;
        [CompilerGenerated, AccessedThroughProperty("GroupBox16"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("InvSaleMonBas"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox15")]
        private GroupBox T;
        [AccessedThroughProperty("InvSaleTotalNET"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label X;
        [AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox X;
        [AccessedThroughProperty("InvSaleDarVal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label G;
        [AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox G;
        [CompilerGenerated, AccessedThroughProperty("InvSaleDisVal"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label E;
        [AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox E;
        [AccessedThroughProperty("InvSaleDarMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label K;
        [AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleDisMaWi")]
        private Label U;
        [AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox U;
        [CompilerGenerated, AccessedThroughProperty("InvSaleTotalAmount"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label L;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox L;
        [AccessedThroughProperty("InvSaleItems"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label N;
        [CompilerGenerated, AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox N;
        [CompilerGenerated, AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox6"), CompilerGenerated]
        private GroupBox Y;
        [CompilerGenerated, AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox O;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox B;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox S;
        [CompilerGenerated, AccessedThroughProperty("InvSaleIDMAX"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label V;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Z;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleID"), CompilerGenerated]
        private Label Y;
        [CompilerGenerated, AccessedThroughProperty("InvSalePayType"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("InvSaleStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [AccessedThroughProperty("InvSaleType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox P;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("GroupBox24"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox M;
        [AccessedThroughProperty("InvSaleTotalProft"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label O;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [CompilerGenerated, AccessedThroughProperty("ComboBoxCustomer"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox Q;
        [CompilerGenerated, AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("InvSaleDateTime"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [CompilerGenerated, AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimersStartUp"), CompilerGenerated]
        private Timer R;
        [CompilerGenerated, AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        private SqlConnection A;
        public static int A;

        public ND()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.GroupBox23 = new GroupBox();
            this.UserAddBy = new Label();
            this.GroupBox22 = new GroupBox();
            this.InvSaleOtherCuru = new Label();
            this.GroupBox21 = new GroupBox();
            this.InvSaleNote = new Label();
            this.GroupBox20 = new GroupBox();
            this.InvSaleMonRod = new Label();
            this.GroupBox19 = new GroupBox();
            this.InvSaleMonDem = new Label();
            this.GroupBox18 = new GroupBox();
            this.InvSaleMonBak = new Label();
            this.GroupBox17 = new GroupBox();
            this.InvSaleMonPay = new Label();
            this.GroupBox16 = new GroupBox();
            this.InvSaleMonBas = new Label();
            this.GroupBox15 = new GroupBox();
            this.InvSaleTotalNET = new Label();
            this.GroupBox13 = new GroupBox();
            this.InvSaleDarVal = new Label();
            this.GroupBox12 = new GroupBox();
            this.InvSaleDisVal = new Label();
            this.GroupBox14 = new GroupBox();
            this.InvSaleDarMiWi = new Label();
            this.GroupBox11 = new GroupBox();
            this.InvSaleDisMaWi = new Label();
            this.GroupBox10 = new GroupBox();
            this.InvSaleTotalAmount = new Label();
            this.GroupBox9 = new GroupBox();
            this.InvSaleItems = new Label();
            this.GroupBox8 = new GroupBox();
            this.ComboBoxCustomer = new ComboBox();
            this.GroupBox7 = new GroupBox();
            this.InvSaleDateTime = new DateTimePicker();
            this.GroupBox6 = new GroupBox();
            this.InvSalePayType = new ComboBox();
            this.GroupBox5 = new GroupBox();
            this.InvSaleStatus = new ComboBox();
            this.GroupBox4 = new GroupBox();
            this.InvSaleType = new ComboBox();
            this.GroupBox3 = new GroupBox();
            this.InvSaleIDMAX = new Label();
            this.GroupBox2 = new GroupBox();
            this.InvSaleID = new Label();
            this.ButtonClose = new Button();
            this.GroupBox24 = new GroupBox();
            this.InvSaleTotalProft = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.TabPage2 = new TabPage();
            this.GV = new DataGridView();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.GroupBox23.SuspendLayout();
            this.GroupBox22.SuspendLayout();
            this.GroupBox21.SuspendLayout();
            this.GroupBox20.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox24.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ToolStripStatus.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3cf, 0x22);
            this.TxTTitle.TabIndex = 0x73;
            this.TxTTitle.Text = "تفاصيل الفاتورة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox23.Controls.Add(this.UserAddBy);
            this.GroupBox23.Location = new Point(14, 190);
            this.GroupBox23.Name = "GroupBox23";
            this.GroupBox23.Size = new Size(0x9b, 50);
            this.GroupBox23.TabIndex = 0x11;
            this.GroupBox23.TabStop = false;
            this.GroupBox23.Text = "الموظف";
            this.UserAddBy.Dock = DockStyle.Fill;
            this.UserAddBy.Location = new Point(3, 0x13);
            this.UserAddBy.Name = "UserAddBy";
            this.UserAddBy.RightToLeft = RightToLeft.No;
            this.UserAddBy.Size = new Size(0x95, 0x1c);
            this.UserAddBy.TabIndex = 0;
            this.UserAddBy.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox22.Controls.Add(this.InvSaleOtherCuru);
            this.GroupBox22.Location = new Point(0x1e8, 0xf6);
            this.GroupBox22.Name = "GroupBox22";
            this.GroupBox22.Size = new Size(0x1d8, 0xa6);
            this.GroupBox22.TabIndex = 0x10;
            this.GroupBox22.TabStop = false;
            this.GroupBox22.Text = "عملات اخرى";
            this.InvSaleOtherCuru.Dock = DockStyle.Fill;
            this.InvSaleOtherCuru.Location = new Point(3, 0x13);
            this.InvSaleOtherCuru.Name = "InvSaleOtherCuru";
            this.InvSaleOtherCuru.RightToLeft = RightToLeft.No;
            this.InvSaleOtherCuru.Size = new Size(0x1d2, 0x90);
            this.InvSaleOtherCuru.TabIndex = 0;
            this.InvSaleOtherCuru.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox21.Controls.Add(this.InvSaleNote);
            this.GroupBox21.Location = new Point(13, 0xf6);
            this.GroupBox21.Name = "GroupBox21";
            this.GroupBox21.Size = new Size(0x1d8, 0xa6);
            this.GroupBox21.TabIndex = 15;
            this.GroupBox21.TabStop = false;
            this.GroupBox21.Text = "ملاحظات";
            this.InvSaleNote.Dock = DockStyle.Fill;
            this.InvSaleNote.Location = new Point(3, 0x13);
            this.InvSaleNote.Name = "InvSaleNote";
            this.InvSaleNote.RightToLeft = RightToLeft.No;
            this.InvSaleNote.Size = new Size(0x1d2, 0x90);
            this.InvSaleNote.TabIndex = 0;
            this.InvSaleNote.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox20.Controls.Add(this.InvSaleMonRod);
            this.GroupBox20.Location = new Point(0xad, 190);
            this.GroupBox20.Name = "GroupBox20";
            this.GroupBox20.Size = new Size(0x9b, 50);
            this.GroupBox20.TabIndex = 14;
            this.GroupBox20.TabStop = false;
            this.GroupBox20.Text = "مبلغ رصيد مدور";
            this.InvSaleMonRod.Dock = DockStyle.Fill;
            this.InvSaleMonRod.Location = new Point(3, 0x13);
            this.InvSaleMonRod.Name = "InvSaleMonRod";
            this.InvSaleMonRod.RightToLeft = RightToLeft.No;
            this.InvSaleMonRod.Size = new Size(0x95, 0x1c);
            this.InvSaleMonRod.TabIndex = 0;
            this.InvSaleMonRod.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox19.Controls.Add(this.InvSaleMonDem);
            this.GroupBox19.Location = new Point(0x14c, 190);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(0x9b, 50);
            this.GroupBox19.TabIndex = 13;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "مبلغ الذمم";
            this.InvSaleMonDem.Dock = DockStyle.Fill;
            this.InvSaleMonDem.Location = new Point(3, 0x13);
            this.InvSaleMonDem.Name = "InvSaleMonDem";
            this.InvSaleMonDem.RightToLeft = RightToLeft.No;
            this.InvSaleMonDem.Size = new Size(0x95, 0x1c);
            this.InvSaleMonDem.TabIndex = 0;
            this.InvSaleMonDem.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox18.Controls.Add(this.InvSaleMonBak);
            this.GroupBox18.Location = new Point(490, 190);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(0x9b, 50);
            this.GroupBox18.TabIndex = 12;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "المبلغ المرتجع للعميل";
            this.InvSaleMonBak.Dock = DockStyle.Fill;
            this.InvSaleMonBak.Location = new Point(3, 0x13);
            this.InvSaleMonBak.Name = "InvSaleMonBak";
            this.InvSaleMonBak.RightToLeft = RightToLeft.No;
            this.InvSaleMonBak.Size = new Size(0x95, 0x1c);
            this.InvSaleMonBak.TabIndex = 0;
            this.InvSaleMonBak.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox17.Controls.Add(this.InvSaleMonPay);
            this.GroupBox17.Location = new Point(0x288, 190);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0x9b, 50);
            this.GroupBox17.TabIndex = 11;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "المبلغ المسدد الفعلي";
            this.InvSaleMonPay.Dock = DockStyle.Fill;
            this.InvSaleMonPay.Location = new Point(3, 0x13);
            this.InvSaleMonPay.Name = "InvSaleMonPay";
            this.InvSaleMonPay.RightToLeft = RightToLeft.No;
            this.InvSaleMonPay.Size = new Size(0x95, 0x1c);
            this.InvSaleMonPay.TabIndex = 0;
            this.InvSaleMonPay.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox16.Controls.Add(this.InvSaleMonBas);
            this.GroupBox16.Location = new Point(0x326, 190);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0x9b, 50);
            this.GroupBox16.TabIndex = 10;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "المبلغ المدفوع المستلم";
            this.InvSaleMonBas.Dock = DockStyle.Fill;
            this.InvSaleMonBas.Location = new Point(3, 0x13);
            this.InvSaleMonBas.Name = "InvSaleMonBas";
            this.InvSaleMonBas.RightToLeft = RightToLeft.No;
            this.InvSaleMonBas.Size = new Size(0x95, 0x1c);
            this.InvSaleMonBas.TabIndex = 0;
            this.InvSaleMonBas.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox15.Controls.Add(this.InvSaleTotalNET);
            this.GroupBox15.Location = new Point(14, 0x86);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x9b, 50);
            this.GroupBox15.TabIndex = 9;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "صافي مبلغ الفاتورة";
            this.InvSaleTotalNET.Dock = DockStyle.Fill;
            this.InvSaleTotalNET.Location = new Point(3, 0x13);
            this.InvSaleTotalNET.Name = "InvSaleTotalNET";
            this.InvSaleTotalNET.RightToLeft = RightToLeft.No;
            this.InvSaleTotalNET.Size = new Size(0x95, 0x1c);
            this.InvSaleTotalNET.TabIndex = 0;
            this.InvSaleTotalNET.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox13.Controls.Add(this.InvSaleDarVal);
            this.GroupBox13.Location = new Point(0xad, 0x86);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x9b, 50);
            this.GroupBox13.TabIndex = 8;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "مجموع الضريبة";
            this.InvSaleDarVal.Dock = DockStyle.Fill;
            this.InvSaleDarVal.Location = new Point(3, 0x13);
            this.InvSaleDarVal.Name = "InvSaleDarVal";
            this.InvSaleDarVal.RightToLeft = RightToLeft.No;
            this.InvSaleDarVal.Size = new Size(0x95, 0x1c);
            this.InvSaleDarVal.TabIndex = 0;
            this.InvSaleDarVal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox12.Controls.Add(this.InvSaleDisVal);
            this.GroupBox12.Location = new Point(0x1e9, 0x86);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x9b, 50);
            this.GroupBox12.TabIndex = 6;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "مجموع الخصم";
            this.InvSaleDisVal.Dock = DockStyle.Fill;
            this.InvSaleDisVal.Location = new Point(3, 0x13);
            this.InvSaleDisVal.Name = "InvSaleDisVal";
            this.InvSaleDisVal.RightToLeft = RightToLeft.No;
            this.InvSaleDisVal.Size = new Size(0x95, 0x1c);
            this.InvSaleDisVal.TabIndex = 0;
            this.InvSaleDisVal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox14.Controls.Add(this.InvSaleDarMiWi);
            this.GroupBox14.Location = new Point(0x14b, 0x86);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x9b, 50);
            this.GroupBox14.TabIndex = 7;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "ضريبة %";
            this.InvSaleDarMiWi.Dock = DockStyle.Fill;
            this.InvSaleDarMiWi.Location = new Point(3, 0x13);
            this.InvSaleDarMiWi.Name = "InvSaleDarMiWi";
            this.InvSaleDarMiWi.RightToLeft = RightToLeft.No;
            this.InvSaleDarMiWi.Size = new Size(0x95, 0x1c);
            this.InvSaleDarMiWi.TabIndex = 0;
            this.InvSaleDarMiWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.InvSaleDisMaWi);
            this.GroupBox11.Location = new Point(0x287, 0x86);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x9b, 50);
            this.GroupBox11.TabIndex = 5;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "خصم %";
            this.InvSaleDisMaWi.Dock = DockStyle.Fill;
            this.InvSaleDisMaWi.Location = new Point(3, 0x13);
            this.InvSaleDisMaWi.Name = "InvSaleDisMaWi";
            this.InvSaleDisMaWi.RightToLeft = RightToLeft.No;
            this.InvSaleDisMaWi.Size = new Size(0x95, 0x1c);
            this.InvSaleDisMaWi.TabIndex = 0;
            this.InvSaleDisMaWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.InvSaleTotalAmount);
            this.GroupBox10.Location = new Point(0x325, 0x86);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x9b, 50);
            this.GroupBox10.TabIndex = 4;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "مبلغ الفاتورة";
            this.InvSaleTotalAmount.Dock = DockStyle.Fill;
            this.InvSaleTotalAmount.Location = new Point(3, 0x13);
            this.InvSaleTotalAmount.Name = "InvSaleTotalAmount";
            this.InvSaleTotalAmount.RightToLeft = RightToLeft.No;
            this.InvSaleTotalAmount.Size = new Size(0x95, 0x1c);
            this.InvSaleTotalAmount.TabIndex = 0;
            this.InvSaleTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox9.Controls.Add(this.InvSaleItems);
            this.GroupBox9.Location = new Point(0x285, 0x4e);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x9b, 50);
            this.GroupBox9.TabIndex = 3;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "عدد المواد";
            this.InvSaleItems.Dock = DockStyle.Fill;
            this.InvSaleItems.Location = new Point(3, 0x13);
            this.InvSaleItems.Name = "InvSaleItems";
            this.InvSaleItems.RightToLeft = RightToLeft.No;
            this.InvSaleItems.Size = new Size(0x95, 0x1c);
            this.InvSaleItems.TabIndex = 0;
            this.InvSaleItems.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox8.Controls.Add(this.ComboBoxCustomer);
            this.GroupBox8.Location = new Point(12, 0x4b);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x1d8, 50);
            this.GroupBox8.TabIndex = 2;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "العميل";
            this.ComboBoxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxCustomer.Dock = DockStyle.Fill;
            this.ComboBoxCustomer.Enabled = false;
            this.ComboBoxCustomer.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxCustomer.FormattingEnabled = true;
            this.ComboBoxCustomer.IntegralHeight = false;
            this.ComboBoxCustomer.Location = new Point(3, 0x13);
            this.ComboBoxCustomer.Name = "ComboBoxCustomer";
            this.ComboBoxCustomer.Size = new Size(0x1d2, 0x18);
            this.ComboBoxCustomer.TabIndex = 0x45;
            this.GroupBox7.Controls.Add(this.InvSaleDateTime);
            this.GroupBox7.Location = new Point(0xac, 0x16);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x10c, 50);
            this.GroupBox7.TabIndex = 2;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "التاريخ والوقت";
            this.InvSaleDateTime.CustomFormat = "yyyy/MM/dd";
            this.InvSaleDateTime.Dock = DockStyle.Fill;
            this.InvSaleDateTime.Enabled = false;
            this.InvSaleDateTime.Format = DateTimePickerFormat.Custom;
            this.InvSaleDateTime.Location = new Point(3, 0x13);
            this.InvSaleDateTime.Name = "InvSaleDateTime";
            this.InvSaleDateTime.RightToLeft = RightToLeft.No;
            this.InvSaleDateTime.Size = new Size(0x106, 0x17);
            this.InvSaleDateTime.TabIndex = 4;
            this.GroupBox6.Controls.Add(this.InvSalePayType);
            this.GroupBox6.Location = new Point(0x323, 0x4e);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x9b, 50);
            this.GroupBox6.TabIndex = 2;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "طريقة الدفع";
            this.InvSalePayType.Dock = DockStyle.Fill;
            this.InvSalePayType.Enabled = false;
            this.InvSalePayType.FormattingEnabled = true;
            object[] items = new object[] { "نقدا", "ذمم", "شبكة", "تحويل", "الرصيد المدور", "شيك", "إئتمان" };
            this.InvSalePayType.Items.AddRange(items);
            this.InvSalePayType.Location = new Point(3, 0x13);
            this.InvSalePayType.Name = "InvSalePayType";
            this.InvSalePayType.Size = new Size(0x95, 0x18);
            this.InvSalePayType.TabIndex = 0x1ed36cd;
            this.GroupBox5.Controls.Add(this.InvSaleStatus);
            this.GroupBox5.Location = new Point(14, 0x16);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x9b, 50);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "الحالة";
            this.InvSaleStatus.Dock = DockStyle.Fill;
            this.InvSaleStatus.Enabled = false;
            this.InvSaleStatus.FormattingEnabled = true;
            object[] objArray2 = new object[] { "مكتملة", "معلقة", "قيد التعديل", "معدلة" };
            this.InvSaleStatus.Items.AddRange(objArray2);
            this.InvSaleStatus.Location = new Point(3, 0x13);
            this.InvSaleStatus.Name = "InvSaleStatus";
            this.InvSaleStatus.Size = new Size(0x95, 0x18);
            this.InvSaleStatus.TabIndex = 0x1ed36cd;
            this.GroupBox4.Controls.Add(this.InvSaleType);
            this.GroupBox4.Location = new Point(0x1bb, 0x16);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0xc9, 50);
            this.GroupBox4.TabIndex = 1;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "نوع الفاتورة";
            this.InvSaleType.Dock = DockStyle.Fill;
            this.InvSaleType.Enabled = false;
            this.InvSaleType.FormattingEnabled = true;
            object[] objArray3 = new object[] { "فاتورة مبيعات", "فاتورة مرتجع مبيعات" };
            this.InvSaleType.Items.AddRange(objArray3);
            this.InvSaleType.Location = new Point(3, 0x13);
            this.InvSaleType.Name = "InvSaleType";
            this.InvSaleType.Size = new Size(0xc3, 0x18);
            this.InvSaleType.TabIndex = 0x2d;
            this.GroupBox3.Controls.Add(this.InvSaleIDMAX);
            this.GroupBox3.Location = new Point(0x285, 0x16);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x9b, 50);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم الفاتورة";
            this.InvSaleIDMAX.Dock = DockStyle.Fill;
            this.InvSaleIDMAX.Location = new Point(3, 0x13);
            this.InvSaleIDMAX.Name = "InvSaleIDMAX";
            this.InvSaleIDMAX.RightToLeft = RightToLeft.No;
            this.InvSaleIDMAX.Size = new Size(0x95, 0x1c);
            this.InvSaleIDMAX.TabIndex = 0;
            this.InvSaleIDMAX.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.InvSaleID);
            this.GroupBox2.Location = new Point(0x323, 0x16);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x9b, 50);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ترميز الفاتورة";
            this.InvSaleID.Dock = DockStyle.Fill;
            this.InvSaleID.Location = new Point(3, 0x13);
            this.InvSaleID.Name = "InvSaleID";
            this.InvSaleID.RightToLeft = RightToLeft.No;
            this.InvSaleID.Size = new Size(0x95, 0x1c);
            this.InvSaleID.TabIndex = 0;
            this.InvSaleID.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0, 0x224);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x3cf, 0x2c);
            this.ButtonClose.TabIndex = 0x77;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBox24.Controls.Add(this.InvSaleTotalProft);
            this.GroupBox24.Location = new Point(0x1e7, 0x4e);
            this.GroupBox24.Name = "GroupBox24";
            this.GroupBox24.Size = new Size(0x9b, 50);
            this.GroupBox24.TabIndex = 10;
            this.GroupBox24.TabStop = false;
            this.GroupBox24.Text = "الربح";
            this.InvSaleTotalProft.Dock = DockStyle.Fill;
            this.InvSaleTotalProft.Location = new Point(3, 0x13);
            this.InvSaleTotalProft.Name = "InvSaleTotalProft";
            this.InvSaleTotalProft.RightToLeft = RightToLeft.No;
            this.InvSaleTotalProft.Size = new Size(0x95, 0x1c);
            this.InvSaleTotalProft.TabIndex = 0;
            this.InvSaleTotalProft.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3cf, 0x1e9);
            this.TabControl1.TabIndex = 120;
            this.TabPage1.Controls.Add(this.GroupBox24);
            this.TabPage1.Controls.Add(this.GroupBox23);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox8);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox4);
            this.TabPage1.Controls.Add(this.GroupBox20);
            this.TabPage1.Controls.Add(this.GroupBox19);
            this.TabPage1.Controls.Add(this.GroupBox21);
            this.TabPage1.Controls.Add(this.GroupBox18);
            this.TabPage1.Controls.Add(this.GroupBox7);
            this.TabPage1.Controls.Add(this.GroupBox17);
            this.TabPage1.Controls.Add(this.GroupBox5);
            this.TabPage1.Controls.Add(this.GroupBox22);
            this.TabPage1.Controls.Add(this.GroupBox16);
            this.TabPage1.Controls.Add(this.GroupBox6);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.GroupBox14);
            this.TabPage1.Controls.Add(this.GroupBox13);
            this.TabPage1.Controls.Add(this.GroupBox15);
            this.TabPage1.Controls.Add(this.GroupBox10);
            this.TabPage1.Controls.Add(this.GroupBox11);
            this.TabPage1.Controls.Add(this.GroupBox12);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3c7, 460);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تفاصيل الفاتورة";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.GV);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3c7, 460);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "المواد/ الاصناف";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AllowUserToOrderColumns = true;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style.SelectionForeColor = Color.Black;
            style.WrapMode = DataGridViewTriState.False;
            this.GV.DefaultCellStyle = style;
            this.GV.Dock = DockStyle.Fill;
            this.GV.Location = new Point(3, 3);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3c1, 0x1c6);
            this.GV.TabIndex = 0x1ed36ce;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripProgressBar1 };
            this.ToolStripStatus.Items.AddRange(toolStripItems);
            this.ToolStripStatus.Location = new Point(0, 0x20b);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3cf, 0x19);
            this.ToolStripStatus.TabIndex = 0x7e;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3cf, 0x250);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "InvoiceSaleCard";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الفاتورة";
            this.GroupBox23.ResumeLayout(false);
            this.GroupBox22.ResumeLayout(false);
            this.GroupBox21.ResumeLayout(false);
            this.GroupBox20.ResumeLayout(false);
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox24.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
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

        private void I(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerLoadData.Enabled = true;
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
            this.P();
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
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
                string selectCommandText = "SELECT [CustomerID], [CustomerName] FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxCustomer.ValueMember = "CustomerID";
                    this.ComboBoxCustomer.DisplayMember = "CustomerName";
                    this.ComboBoxCustomer.DataSource = dataTable;
                    this.ComboBoxCustomer.SelectedIndex = -1;
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable table2 = new DataTable();
                string str2 = "SELECT TOP(1) * FROM [TaNNInvSale] WHERE ([InvSaleID] = @InvSaleID)";
                table2.Clear();
                SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                adapter2.SelectCommand.Parameters.AddWithValue("InvSaleID", A);
                adapter2.Fill(table2);
                this.A.Close();
                if (table2.Rows.Count > 0)
                {
                    this.InvSaleID.Text = table2.Rows[0]["InvSaleID"].ToString();
                    this.ComboBoxCustomer.SelectedValue = table2.Rows[0]["CustomerFrontID"].ToString();
                    this.InvSaleIDMAX.Text = table2.Rows[0]["InvSaleIDMAX"].ToString();
                    this.InvSaleDateTime.Value = Conversions.ToDate(table2.Rows[0]["InvSaleDateTime"].ToString());
                    this.InvSaleType.SelectedIndex = Conversions.ToInteger(table2.Rows[0]["InvSaleType"].ToString());
                    this.InvSaleStatus.SelectedIndex = Conversions.ToInteger(table2.Rows[0]["InvSaleStatus"].ToString());
                    this.InvSalePayType.SelectedIndex = Conversions.ToInteger(table2.Rows[0]["InvSalePayType"].ToString());
                    this.InvSaleItems.Text = table2.Rows[0]["InvSaleItems"].ToString();
                    this.InvSaleTotalAmount.Text = table2.Rows[0]["InvSaleTotalAmount"].ToString();
                    this.InvSaleDisMaWi.Text = table2.Rows[0]["InvSaleDisMaWi"].ToString();
                    this.InvSaleDisVal.Text = table2.Rows[0]["InvSaleDisVal"].ToString();
                    this.InvSaleDarMiWi.Text = table2.Rows[0]["InvSaleDarMiWi"].ToString();
                    this.InvSaleDarVal.Text = table2.Rows[0]["InvSaleDarVal"].ToString();
                    this.InvSaleTotalNET.Text = table2.Rows[0]["InvSaleTotalNET"].ToString();
                    this.InvSaleTotalProft.Text = !PR.BP ? "مخفي" : table2.Rows[0]["InvSaleTotalProft"].ToString();
                    this.InvSaleMonBas.Text = table2.Rows[0]["InvSaleMonBas"].ToString();
                    this.InvSaleMonPay.Text = table2.Rows[0]["InvSaleMonPay"].ToString();
                    this.InvSaleMonBak.Text = table2.Rows[0]["InvSaleMonBak"].ToString();
                    this.InvSaleMonDem.Text = table2.Rows[0]["InvSaleMonDem"].ToString();
                    this.InvSaleMonRod.Text = table2.Rows[0]["InvSaleMonRod"].ToString();
                    this.InvSaleNote.Text = table2.Rows[0]["InvSaleNote"].ToString();
                    this.UserAddBy.Text = table2.Rows[0]["InvSaleUserAddBy"].ToString();
                    this.InvSaleOtherCuru.Text = table2.Rows[0]["InvSaleOtherCuru"].ToString();
                }
                decimal num = new decimal(Conversion.Val(this.InvSaleTotalAmount.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.InvSaleDisVal.Text.Replace(",", "")));
                decimal num3 = new decimal(Conversion.Val(this.InvSaleDarVal.Text.Replace(",", "")));
                decimal num4 = new decimal(Conversion.Val(this.InvSaleTotalNET.Text.Replace(",", "")));
                decimal num5 = new decimal(Conversion.Val(this.InvSaleTotalProft.Text.Replace(",", "")));
                decimal num6 = new decimal(Conversion.Val(this.InvSaleMonBas.Text.Replace(",", "")));
                decimal num7 = new decimal(Conversion.Val(this.InvSaleMonPay.Text.Replace(",", "")));
                decimal num8 = new decimal(Conversion.Val(this.InvSaleMonBak.Text.Replace(",", "")));
                decimal num9 = new decimal(Conversion.Val(this.InvSaleMonDem.Text.Replace(",", "")));
                decimal num10 = new decimal(Conversion.Val(this.InvSaleMonRod.Text.Replace(",", "")));
                this.InvSaleTotalAmount.Text = num.ToString(PR.YR);
                this.InvSaleDisVal.Text = num2.ToString(PR.YR);
                this.InvSaleDarVal.Text = num3.ToString(PR.YR);
                this.InvSaleTotalNET.Text = num4.ToString(PR.YR);
                this.InvSaleTotalProft.Text = !PR.BP ? "مخفي" : num5.ToString(PR.YR);
                this.InvSaleMonBas.Text = num6.ToString(PR.YR);
                this.InvSaleMonPay.Text = num7.ToString(PR.YR);
                this.InvSaleMonBak.Text = num8.ToString(PR.YR);
                this.InvSaleMonDem.Text = num9.ToString(PR.YR);
                this.InvSaleMonRod.Text = num10.ToString(PR.YR);
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
            base.Dispose();
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

        internal virtual GroupBox GroupBox23
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label UserAddBy
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox22
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label InvSaleOtherCuru
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox21
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label InvSaleNote
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox20
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label InvSaleMonRod
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label InvSaleMonDem
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label InvSaleMonBak
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label InvSaleMonPay
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
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label InvSaleMonBas
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
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

        internal virtual Label InvSaleTotalNET
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Label InvSaleDarVal
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Label InvSaleDisVal
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
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual Label InvSaleDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual Label InvSaleDisMaWi
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Label InvSaleTotalAmount
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual Label InvSaleItems
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
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual Label InvSaleIDMAX
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual Label InvSaleID
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual ComboBox InvSalePayType
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox InvSaleStatus
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ComboBox InvSaleType
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonClose
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

        internal virtual GroupBox GroupBox24
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual Label InvSaleTotalProft
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
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

        internal virtual ComboBox ComboBoxCustomer
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DateTimePicker InvSaleDateTime
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual Timer TimerLoadData
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                Timer r = this.R;
                if (r != null)
                {
                    r.Tick -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.Tick += handler;
                }
            }
        }

        internal virtual Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                Timer p = this.P;
                if (p != null)
                {
                    p.Tick -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.Tick += handler;
                }
            }
        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= 0x200;
                return createParams;
            }
        }
    }
}

