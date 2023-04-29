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
    public class TT : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage2")]
        private TabPage A;
        [CompilerGenerated, AccessedThroughProperty("UserIsInvSaleEdit"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("UserIsInvSaleList"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox R;
        [AccessedThroughProperty("UserIsRemmember"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox P;
        [AccessedThroughProperty("UserIsPurchApplStore"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsPurchList")]
        private CheckBox I;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsBarCodeMaker")]
        private CheckBox D;
        [CompilerGenerated, AccessedThroughProperty("UserIsWarehousList"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsExpensesAdd"), CompilerGenerated]
        private CheckBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsCustomerPayAdd"), CompilerGenerated]
        private CheckBox T;
        [CompilerGenerated, AccessedThroughProperty("UserIsCustomerAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox X;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsCustomerList")]
        private CheckBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsSuplierPayAdd")]
        private CheckBox E;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsSuplierAdd")]
        private CheckBox K;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsSuplierList")]
        private CheckBox U;
        [AccessedThroughProperty("UserIsRemmemberAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox L;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsExpensesList"), CompilerGenerated]
        private CheckBox N;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3"), CompilerGenerated]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonOk")]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3")]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PictureBox1")]
        private PictureBox A;
        [AccessedThroughProperty("TxTUserPass"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("Label10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("Label8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("TxTUserName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTUserLog")]
        private TextBox P;
        [AccessedThroughProperty("TabPage5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage Q;
        [AccessedThroughProperty("TabPage6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage I;
        [AccessedThroughProperty("TabPage7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage D;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage F;
        [AccessedThroughProperty("UserIsViewGeneralProft"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox V;
        [AccessedThroughProperty("TabPage9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage H;
        [AccessedThroughProperty("UserIsCashMe"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox Y;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsCashList"), CompilerGenerated]
        private CheckBox O;
        [AccessedThroughProperty("TabPage10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage T;
        [CompilerGenerated, AccessedThroughProperty("UserIsWarehousAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox B;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsPurchAdd")]
        private CheckBox S;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsCustomerEditDelet")]
        private CheckBox Z;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsSuplierEditDelet")]
        private CheckBox M;
        [AccessedThroughProperty("UserIsInvSaleDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox C;
        [AccessedThroughProperty("UserIsChangeCenter"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox J;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsReturnSale"), CompilerGenerated]
        private CheckBox W;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsReturnPurch")]
        private CheckBox AR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage4")]
        private TabPage X;
        [CompilerGenerated, AccessedThroughProperty("UserIsSaleWindowEditPrice"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox PR;
        [CompilerGenerated, AccessedThroughProperty("UserIsSaleWindowEditDis"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox QR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsSaleWindowSaleOut")]
        private CheckBox IR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsSaleWindowCanceItem")]
        private CheckBox DR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsViewQQViewQu")]
        private CheckBox FR;
        [CompilerGenerated, AccessedThroughProperty("UserIsViewQQViewCo"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox HR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserIsSaleWindow")]
        private CheckBox TR;
        [CompilerGenerated, AccessedThroughProperty("UserIsCashEnable"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox XR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox R;
        [AccessedThroughProperty("UserGReport"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox GR;
        [AccessedThroughProperty("UserIsChangeDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox ER;
        [AccessedThroughProperty("UserIsSaleWindowEditQuntity"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox KR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsSaleWindowSalePeind")]
        private CheckBox UR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsRestMAX")]
        private CheckBox LR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserIsSaleWindowSaleZero")]
        private CheckBox NR;
        [AccessedThroughProperty("UserIsSaleWindowEditDar"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox VR;
        private SqlConnection A;
        private A.M A;
        public static int A;

        public TT()
        {
            base.Load += new EventHandler(this.R);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new A.M();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TabPage2 = new TabPage();
            this.UserIsSaleWindowSalePeind = new CheckBox();
            this.UserIsRestMAX = new CheckBox();
            this.UserIsReturnSale = new CheckBox();
            this.UserIsInvSaleDelete = new CheckBox();
            this.UserIsViewGeneralProft = new CheckBox();
            this.UserIsInvSaleEdit = new CheckBox();
            this.UserIsInvSaleList = new CheckBox();
            this.UserIsRemmember = new CheckBox();
            this.UserIsPurchApplStore = new CheckBox();
            this.UserIsPurchList = new CheckBox();
            this.TabPage1 = new TabPage();
            this.UserIsChangeDate = new CheckBox();
            this.UserGReport = new CheckBox();
            this.UserIsChangeCenter = new CheckBox();
            this.UserIsBarCodeMaker = new CheckBox();
            this.UserIsWarehousList = new CheckBox();
            this.UserIsExpensesAdd = new CheckBox();
            this.UserIsCustomerPayAdd = new CheckBox();
            this.UserIsCustomerAdd = new CheckBox();
            this.UserIsCustomerList = new CheckBox();
            this.UserIsSuplierPayAdd = new CheckBox();
            this.UserIsSuplierAdd = new CheckBox();
            this.UserIsSuplierList = new CheckBox();
            this.UserIsRemmemberAdd = new CheckBox();
            this.UserIsExpensesList = new CheckBox();
            this.TabPage3 = new TabPage();
            this.UserIsReturnPurch = new CheckBox();
            this.UserIsPurchAdd = new CheckBox();
            this.TxTTitle = new Label();
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.GroupBox3 = new GroupBox();
            this.GroupBox1 = new GroupBox();
            this.TxTUserName = new TextBox();
            this.PictureBox1 = new PictureBox();
            this.TxTUserPass = new TextBox();
            this.Label10 = new Label();
            this.Label8 = new Label();
            this.TxTUserLog = new TextBox();
            this.TabPage5 = new TabPage();
            this.TabPage6 = new TabPage();
            this.UserIsCustomerEditDelet = new CheckBox();
            this.TabPage7 = new TabPage();
            this.UserIsSuplierEditDelet = new CheckBox();
            this.TabControl1 = new TabControl();
            this.TabPage4 = new TabPage();
            this.UserIsSaleWindowEditDar = new CheckBox();
            this.UserIsSaleWindowSaleZero = new CheckBox();
            this.UserIsSaleWindowEditQuntity = new CheckBox();
            this.UserIsSaleWindowEditPrice = new CheckBox();
            this.UserIsSaleWindowEditDis = new CheckBox();
            this.UserIsSaleWindowSaleOut = new CheckBox();
            this.UserIsSaleWindowCanceItem = new CheckBox();
            this.UserIsViewQQViewQu = new CheckBox();
            this.UserIsViewQQViewCo = new CheckBox();
            this.UserIsSaleWindow = new CheckBox();
            this.TabPage8 = new TabPage();
            this.TabPage9 = new TabPage();
            this.UserIsCashEnable = new CheckBox();
            this.UserIsCashMe = new CheckBox();
            this.UserIsCashList = new CheckBox();
            this.TabPage10 = new TabPage();
            this.UserIsWarehousAdd = new CheckBox();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage8.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.TabPage10.SuspendLayout();
            base.SuspendLayout();
            this.TabPage2.Controls.Add(this.UserIsSaleWindowSalePeind);
            this.TabPage2.Controls.Add(this.UserIsRestMAX);
            this.TabPage2.Controls.Add(this.UserIsReturnSale);
            this.TabPage2.Controls.Add(this.UserIsInvSaleDelete);
            this.TabPage2.Controls.Add(this.UserIsViewGeneralProft);
            this.TabPage2.Controls.Add(this.UserIsInvSaleEdit);
            this.TabPage2.Controls.Add(this.UserIsInvSaleList);
            this.TabPage2.Location = new Point(4, 0x2e);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(650, 0x11a);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "فواتير المبيعات";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowSalePeind.AutoSize = true;
            this.UserIsSaleWindowSalePeind.Checked = true;
            this.UserIsSaleWindowSalePeind.CheckState = CheckState.Checked;
            this.UserIsSaleWindowSalePeind.Location = new Point(0x1a3, 0xaf);
            this.UserIsSaleWindowSalePeind.Name = "UserIsSaleWindowSalePeind";
            this.UserIsSaleWindowSalePeind.Size = new Size(0xb6, 20);
            this.UserIsSaleWindowSalePeind.TabIndex = 5;
            this.UserIsSaleWindowSalePeind.Text = "السماح له في تعليق الفواتير";
            this.UserIsSaleWindowSalePeind.UseVisualStyleBackColor = true;
            this.UserIsRestMAX.AutoSize = true;
            this.UserIsRestMAX.Checked = true;
            this.UserIsRestMAX.CheckState = CheckState.Checked;
            this.UserIsRestMAX.Location = new Point(0x151, 0x95);
            this.UserIsRestMAX.Name = "UserIsRestMAX";
            this.UserIsRestMAX.Size = new Size(0x108, 20);
            this.UserIsRestMAX.TabIndex = 4;
            this.UserIsRestMAX.Text = "السماح له في إعادة ترقيم وتسلسل الفواتير";
            this.UserIsRestMAX.UseVisualStyleBackColor = true;
            this.UserIsReturnSale.AutoSize = true;
            this.UserIsReturnSale.Checked = true;
            this.UserIsReturnSale.CheckState = CheckState.Checked;
            this.UserIsReturnSale.Location = new Point(0x180, 0x7b);
            this.UserIsReturnSale.Name = "UserIsReturnSale";
            this.UserIsReturnSale.Size = new Size(0xd9, 20);
            this.UserIsReturnSale.TabIndex = 3;
            this.UserIsReturnSale.Text = "السماح له في اضافة مرتجع مبيعات";
            this.UserIsReturnSale.UseVisualStyleBackColor = true;
            this.UserIsInvSaleDelete.AutoSize = true;
            this.UserIsInvSaleDelete.Checked = true;
            this.UserIsInvSaleDelete.CheckState = CheckState.Checked;
            this.UserIsInvSaleDelete.Location = new Point(0x1a8, 0x61);
            this.UserIsInvSaleDelete.Name = "UserIsInvSaleDelete";
            this.UserIsInvSaleDelete.Size = new Size(0xb1, 20);
            this.UserIsInvSaleDelete.TabIndex = 3;
            this.UserIsInvSaleDelete.Text = "السماح له في حذف الفواتير";
            this.UserIsInvSaleDelete.UseVisualStyleBackColor = true;
            this.UserIsViewGeneralProft.AutoSize = true;
            this.UserIsViewGeneralProft.Checked = true;
            this.UserIsViewGeneralProft.CheckState = CheckState.Checked;
            this.UserIsViewGeneralProft.Location = new Point(0xf6, 0x2d);
            this.UserIsViewGeneralProft.Name = "UserIsViewGeneralProft";
            this.UserIsViewGeneralProft.Size = new Size(0x163, 20);
            this.UserIsViewGeneralProft.TabIndex = 2;
            this.UserIsViewGeneralProft.Text = "عرض الربح في قائمة فواتير المبيعات سجل البيع والتقرير العام";
            this.UserIsViewGeneralProft.UseVisualStyleBackColor = true;
            this.UserIsInvSaleEdit.AutoSize = true;
            this.UserIsInvSaleEdit.Checked = true;
            this.UserIsInvSaleEdit.CheckState = CheckState.Checked;
            this.UserIsInvSaleEdit.Location = new Point(0x1a5, 0x47);
            this.UserIsInvSaleEdit.Name = "UserIsInvSaleEdit";
            this.UserIsInvSaleEdit.Size = new Size(180, 20);
            this.UserIsInvSaleEdit.TabIndex = 1;
            this.UserIsInvSaleEdit.Text = "السماح له في تعديل الفواتير";
            this.UserIsInvSaleEdit.UseVisualStyleBackColor = true;
            this.UserIsInvSaleList.AutoSize = true;
            this.UserIsInvSaleList.Checked = true;
            this.UserIsInvSaleList.CheckState = CheckState.Checked;
            this.UserIsInvSaleList.Location = new Point(0x11c, 0x13);
            this.UserIsInvSaleList.Name = "UserIsInvSaleList";
            this.UserIsInvSaleList.Size = new Size(0x13d, 20);
            this.UserIsInvSaleList.TabIndex = 0;
            this.UserIsInvSaleList.Text = "السماح له بإدارة قائمة فواتير المبيعات/مرتجع المبيعات";
            this.UserIsInvSaleList.UseVisualStyleBackColor = true;
            this.UserIsRemmember.AutoSize = true;
            this.UserIsRemmember.Checked = true;
            this.UserIsRemmember.CheckState = CheckState.Checked;
            this.UserIsRemmember.Location = new Point(0x15d, 0x2b);
            this.UserIsRemmember.Name = "UserIsRemmember";
            this.UserIsRemmember.Size = new Size(0x10a, 20);
            this.UserIsRemmember.TabIndex = 0;
            this.UserIsRemmember.Text = "السماح له بإدارة قائمة التنبيهات والملاحظات";
            this.UserIsRemmember.UseVisualStyleBackColor = true;
            this.UserIsPurchApplStore.Checked = true;
            this.UserIsPurchApplStore.CheckState = CheckState.Checked;
            this.UserIsPurchApplStore.Location = new Point(14, 0x66);
            this.UserIsPurchApplStore.Name = "UserIsPurchApplStore";
            this.UserIsPurchApplStore.Size = new Size(0x25b, 0x30);
            this.UserIsPurchApplStore.TabIndex = 3;
            this.UserIsPurchApplStore.Text = "عند اضافة مادة في فاتورة المشتريات، قم بإضافتها في المستودع (في حال وجود المادة في المستودع مسبقاً، سيتم تحديث البيانات عليها، وفي حال عدم وجودها سيتم تعليقها لإعتمادها لاحقاً.)";
            this.UserIsPurchApplStore.UseVisualStyleBackColor = true;
            this.UserIsPurchList.AutoSize = true;
            this.UserIsPurchList.Checked = true;
            this.UserIsPurchList.CheckState = CheckState.Checked;
            this.UserIsPurchList.Location = new Point(0x114, 0x18);
            this.UserIsPurchList.Name = "UserIsPurchList";
            this.UserIsPurchList.Size = new Size(0x155, 20);
            this.UserIsPurchList.TabIndex = 2;
            this.UserIsPurchList.Text = "السماح له بإدارة قائمة فواتير المشتريات/مرتجع المشتريات";
            this.UserIsPurchList.UseVisualStyleBackColor = true;
            this.TabPage1.Controls.Add(this.UserIsChangeDate);
            this.TabPage1.Controls.Add(this.UserGReport);
            this.TabPage1.Controls.Add(this.UserIsChangeCenter);
            this.TabPage1.Controls.Add(this.UserIsBarCodeMaker);
            this.TabPage1.Location = new Point(4, 0x2e);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(650, 0x11a);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "صلاحيات عامة";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.UserIsChangeDate.AutoSize = true;
            this.UserIsChangeDate.Checked = true;
            this.UserIsChangeDate.CheckState = CheckState.Checked;
            this.UserIsChangeDate.Location = new Point(0x1b7, 0x73);
            this.UserIsChangeDate.Name = "UserIsChangeDate";
            this.UserIsChangeDate.Size = new Size(0xb1, 20);
            this.UserIsChangeDate.TabIndex = 9;
            this.UserIsChangeDate.Text = "السماح له في تعديل التاريخ";
            this.UserIsChangeDate.UseVisualStyleBackColor = true;
            this.UserGReport.AutoSize = true;
            this.UserGReport.Checked = true;
            this.UserGReport.CheckState = CheckState.Checked;
            this.UserGReport.Location = new Point(0x19d, 0x59);
            this.UserGReport.Name = "UserGReport";
            this.UserGReport.Size = new Size(0xcb, 20);
            this.UserGReport.TabIndex = 8;
            this.UserGReport.Text = "السماح له في عرض التقرير العام";
            this.UserGReport.UseVisualStyleBackColor = true;
            this.UserIsChangeCenter.AutoSize = true;
            this.UserIsChangeCenter.Location = new Point(0x11f, 0x25);
            this.UserIsChangeCenter.Name = "UserIsChangeCenter";
            this.UserIsChangeCenter.Size = new Size(0x149, 20);
            this.UserIsChangeCenter.TabIndex = 7;
            this.UserIsChangeCenter.Text = "السماح له في التبديل والتنقل بين المستودعات والفروع ";
            this.UserIsChangeCenter.UseVisualStyleBackColor = true;
            this.UserIsBarCodeMaker.AutoSize = true;
            this.UserIsBarCodeMaker.Checked = true;
            this.UserIsBarCodeMaker.CheckState = CheckState.Checked;
            this.UserIsBarCodeMaker.Location = new Point(0x198, 0x3f);
            this.UserIsBarCodeMaker.Name = "UserIsBarCodeMaker";
            this.UserIsBarCodeMaker.Size = new Size(0xd0, 20);
            this.UserIsBarCodeMaker.TabIndex = 1;
            this.UserIsBarCodeMaker.Text = "السماح له بصناعة ملصقات باركود";
            this.UserIsBarCodeMaker.UseVisualStyleBackColor = true;
            this.UserIsWarehousList.AutoSize = true;
            this.UserIsWarehousList.Checked = true;
            this.UserIsWarehousList.CheckState = CheckState.Checked;
            this.UserIsWarehousList.Location = new Point(0x1b9, 0x1a);
            this.UserIsWarehousList.Name = "UserIsWarehousList";
            this.UserIsWarehousList.Size = new Size(0xad, 20);
            this.UserIsWarehousList.TabIndex = 0;
            this.UserIsWarehousList.Text = "السماح له بإدارة المستودع";
            this.UserIsWarehousList.UseVisualStyleBackColor = true;
            this.UserIsExpensesAdd.AutoSize = true;
            this.UserIsExpensesAdd.Checked = true;
            this.UserIsExpensesAdd.CheckState = CheckState.Checked;
            this.UserIsExpensesAdd.Location = new Point(0x1c3, 0x39);
            this.UserIsExpensesAdd.Name = "UserIsExpensesAdd";
            this.UserIsExpensesAdd.Size = new Size(0xa3, 20);
            this.UserIsExpensesAdd.TabIndex = 1;
            this.UserIsExpensesAdd.Text = "السماح له بإضافة مصروف";
            this.UserIsExpensesAdd.UseVisualStyleBackColor = true;
            this.UserIsCustomerPayAdd.AutoSize = true;
            this.UserIsCustomerPayAdd.Checked = true;
            this.UserIsCustomerPayAdd.CheckState = CheckState.Checked;
            this.UserIsCustomerPayAdd.Location = new Point(0x1a9, 0x4c);
            this.UserIsCustomerPayAdd.Name = "UserIsCustomerPayAdd";
            this.UserIsCustomerPayAdd.Size = new Size(0xbd, 20);
            this.UserIsCustomerPayAdd.TabIndex = 2;
            this.UserIsCustomerPayAdd.Text = "السماح له بإضاف دفعة للعميل";
            this.UserIsCustomerPayAdd.UseVisualStyleBackColor = true;
            this.UserIsCustomerAdd.AutoSize = true;
            this.UserIsCustomerAdd.Checked = true;
            this.UserIsCustomerAdd.CheckState = CheckState.Checked;
            this.UserIsCustomerAdd.Location = new Point(0x1cb, 50);
            this.UserIsCustomerAdd.Name = "UserIsCustomerAdd";
            this.UserIsCustomerAdd.Size = new Size(0x9b, 20);
            this.UserIsCustomerAdd.TabIndex = 1;
            this.UserIsCustomerAdd.Text = "السماح له بإضافة عميل";
            this.UserIsCustomerAdd.UseVisualStyleBackColor = true;
            this.UserIsCustomerList.AutoSize = true;
            this.UserIsCustomerList.Checked = true;
            this.UserIsCustomerList.CheckState = CheckState.Checked;
            this.UserIsCustomerList.Location = new Point(0x1ac, 0x18);
            this.UserIsCustomerList.Name = "UserIsCustomerList";
            this.UserIsCustomerList.Size = new Size(0xba, 20);
            this.UserIsCustomerList.TabIndex = 0;
            this.UserIsCustomerList.Text = "السماح له بإدارة قائمة العملاء";
            this.UserIsCustomerList.UseVisualStyleBackColor = true;
            this.UserIsSuplierPayAdd.AutoSize = true;
            this.UserIsSuplierPayAdd.Checked = true;
            this.UserIsSuplierPayAdd.CheckState = CheckState.Checked;
            this.UserIsSuplierPayAdd.Location = new Point(0x1ab, 0x49);
            this.UserIsSuplierPayAdd.Name = "UserIsSuplierPayAdd";
            this.UserIsSuplierPayAdd.Size = new Size(0xbb, 20);
            this.UserIsSuplierPayAdd.TabIndex = 5;
            this.UserIsSuplierPayAdd.Text = "السماح له بإضافة دفعة للمورد";
            this.UserIsSuplierPayAdd.UseVisualStyleBackColor = true;
            this.UserIsSuplierAdd.AutoSize = true;
            this.UserIsSuplierAdd.Checked = true;
            this.UserIsSuplierAdd.CheckState = CheckState.Checked;
            this.UserIsSuplierAdd.Location = new Point(0x1d1, 0x2f);
            this.UserIsSuplierAdd.Name = "UserIsSuplierAdd";
            this.UserIsSuplierAdd.Size = new Size(0x95, 20);
            this.UserIsSuplierAdd.TabIndex = 4;
            this.UserIsSuplierAdd.Text = "السماح له بإضافة مورد";
            this.UserIsSuplierAdd.UseVisualStyleBackColor = true;
            this.UserIsSuplierList.AutoSize = true;
            this.UserIsSuplierList.Checked = true;
            this.UserIsSuplierList.CheckState = CheckState.Checked;
            this.UserIsSuplierList.Location = new Point(0x1a1, 0x15);
            this.UserIsSuplierList.Name = "UserIsSuplierList";
            this.UserIsSuplierList.Size = new Size(0xc5, 20);
            this.UserIsSuplierList.TabIndex = 3;
            this.UserIsSuplierList.Text = "السماح له بإدارة قائمة الموردين";
            this.UserIsSuplierList.UseVisualStyleBackColor = true;
            this.UserIsRemmemberAdd.AutoSize = true;
            this.UserIsRemmemberAdd.Checked = true;
            this.UserIsRemmemberAdd.CheckState = CheckState.Checked;
            this.UserIsRemmemberAdd.Location = new Point(0x196, 0x45);
            this.UserIsRemmemberAdd.Name = "UserIsRemmemberAdd";
            this.UserIsRemmemberAdd.Size = new Size(0xd0, 20);
            this.UserIsRemmemberAdd.TabIndex = 1;
            this.UserIsRemmemberAdd.Text = "السماح له بإضافة تنبيه او ملاحظة";
            this.UserIsRemmemberAdd.UseVisualStyleBackColor = true;
            this.UserIsExpensesList.AutoSize = true;
            this.UserIsExpensesList.Checked = true;
            this.UserIsExpensesList.CheckState = CheckState.Checked;
            this.UserIsExpensesList.Location = new Point(0x198, 0x1f);
            this.UserIsExpensesList.Name = "UserIsExpensesList";
            this.UserIsExpensesList.Size = new Size(0xce, 20);
            this.UserIsExpensesList.TabIndex = 0;
            this.UserIsExpensesList.Text = "السماح له بإدارة قائمة المصروفات";
            this.UserIsExpensesList.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.UserIsReturnPurch);
            this.TabPage3.Controls.Add(this.UserIsPurchAdd);
            this.TabPage3.Controls.Add(this.UserIsPurchApplStore);
            this.TabPage3.Controls.Add(this.UserIsPurchList);
            this.TabPage3.Location = new Point(4, 0x2e);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(650, 0x11a);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "فواتير المشتريات";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.UserIsReturnPurch.AutoSize = true;
            this.UserIsReturnPurch.Checked = true;
            this.UserIsReturnPurch.CheckState = CheckState.Checked;
            this.UserIsReturnPurch.Location = new Point(0x184, 0x4c);
            this.UserIsReturnPurch.Name = "UserIsReturnPurch";
            this.UserIsReturnPurch.Size = new Size(0xe5, 20);
            this.UserIsReturnPurch.TabIndex = 2;
            this.UserIsReturnPurch.Text = "السماح له في اضافة مرتجع مشتريات";
            this.UserIsReturnPurch.UseVisualStyleBackColor = true;
            this.UserIsPurchAdd.AutoSize = true;
            this.UserIsPurchAdd.Checked = true;
            this.UserIsPurchAdd.CheckState = CheckState.Checked;
            this.UserIsPurchAdd.Location = new Point(0x18b, 50);
            this.UserIsPurchAdd.Name = "UserIsPurchAdd";
            this.UserIsPurchAdd.Size = new Size(0xde, 20);
            this.UserIsPurchAdd.TabIndex = 4;
            this.UserIsPurchAdd.Text = "السماح له في إضافة / تعديل الفواتير";
            this.UserIsPurchAdd.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x292, 0x2f);
            this.TxTTitle.TabIndex = 40;
            this.TxTTitle.Text = "اضافة تعديل موظفين";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(8, 0x20e);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x149, 0x2c);
            this.ButtonOk.TabIndex = 0x27;
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
            this.ButtonClose.Location = new Point(0x1b2, 0x20e);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xd0, 0x2c);
            this.ButtonClose.TabIndex = 0x26;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.GroupBox1);
            this.GroupBox3.Controls.Add(this.PictureBox1);
            this.GroupBox3.Controls.Add(this.TxTUserPass);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.TxTUserLog);
            this.GroupBox3.Dock = DockStyle.Top;
            this.GroupBox3.Location = new Point(0, 0x2f);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x292, 0x83);
            this.GroupBox3.TabIndex = 0x24;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "بيانات الدخول";
            this.GroupBox1.Controls.Add(this.TxTUserName);
            this.GroupBox1.Location = new Point(6, 0x16);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xf4, 100);
            this.GroupBox1.TabIndex = 0x2a;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اسم الموظف:";
            this.TxTUserName.BackColor = SystemColors.Info;
            this.TxTUserName.Location = new Point(6, 40);
            this.TxTUserName.MaxLength = 50;
            this.TxTUserName.Name = "TxTUserName";
            this.TxTUserName.Size = new Size(0xe8, 0x17);
            this.TxTUserName.TabIndex = 0x25;
            this.TxTUserName.TextAlign = HorizontalAlignment.Center;
            this.PictureBox1.Image = A.F.ImLogin;
            this.PictureBox1.Location = new Point(0x246, 0x35);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x20, 0x20);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 0x26;
            this.PictureBox1.TabStop = false;
            this.TxTUserPass.BackColor = Color.FromArgb(0xff, 0xe0, 0xc0);
            this.TxTUserPass.BorderStyle = BorderStyle.FixedSingle;
            this.TxTUserPass.Location = new Point(0x112, 0x4a);
            this.TxTUserPass.MaxLength = 50;
            this.TxTUserPass.Name = "TxTUserPass";
            this.TxTUserPass.RightToLeft = RightToLeft.No;
            this.TxTUserPass.Size = new Size(0xce, 0x17);
            this.TxTUserPass.TabIndex = 1;
            this.TxTUserPass.TextAlign = HorizontalAlignment.Center;
            this.Label10.AutoSize = true;
            this.Label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label10.Location = new Point(0x1ef, 0x4d);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x45, 0x10);
            this.Label10.TabIndex = 0x22;
            this.Label10.Text = "كلمة السر:";
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.Location = new Point(0x1ef, 0x2c);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x47, 0x10);
            this.Label8.TabIndex = 0x20;
            this.Label8.Text = "رمز الدخول:";
            this.TxTUserLog.BackColor = Color.FromArgb(0xff, 0xe0, 0xc0);
            this.TxTUserLog.BorderStyle = BorderStyle.FixedSingle;
            this.TxTUserLog.Location = new Point(0x112, 0x29);
            this.TxTUserLog.MaxLength = 50;
            this.TxTUserLog.Name = "TxTUserLog";
            this.TxTUserLog.RightToLeft = RightToLeft.No;
            this.TxTUserLog.Size = new Size(0xce, 0x17);
            this.TxTUserLog.TabIndex = 0;
            this.TxTUserLog.TextAlign = HorizontalAlignment.Center;
            this.TabPage5.Controls.Add(this.UserIsExpensesAdd);
            this.TabPage5.Controls.Add(this.UserIsExpensesList);
            this.TabPage5.Location = new Point(4, 0x2e);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new Size(650, 0x11a);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "المصروفات";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.TabPage6.Controls.Add(this.UserIsCustomerEditDelet);
            this.TabPage6.Controls.Add(this.UserIsCustomerPayAdd);
            this.TabPage6.Controls.Add(this.UserIsCustomerAdd);
            this.TabPage6.Controls.Add(this.UserIsCustomerList);
            this.TabPage6.Location = new Point(4, 0x2e);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new Size(650, 0x11a);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "العملاء";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.UserIsCustomerEditDelet.AutoSize = true;
            this.UserIsCustomerEditDelet.Checked = true;
            this.UserIsCustomerEditDelet.CheckState = CheckState.Checked;
            this.UserIsCustomerEditDelet.Location = new Point(400, 0x66);
            this.UserIsCustomerEditDelet.Name = "UserIsCustomerEditDelet";
            this.UserIsCustomerEditDelet.Size = new Size(0xd6, 20);
            this.UserIsCustomerEditDelet.TabIndex = 7;
            this.UserIsCustomerEditDelet.Text = "السماح له في حذف وتعديل العملاء";
            this.UserIsCustomerEditDelet.UseVisualStyleBackColor = true;
            this.TabPage7.Controls.Add(this.UserIsSuplierEditDelet);
            this.TabPage7.Controls.Add(this.UserIsSuplierPayAdd);
            this.TabPage7.Controls.Add(this.UserIsSuplierAdd);
            this.TabPage7.Controls.Add(this.UserIsSuplierList);
            this.TabPage7.Location = new Point(4, 0x2e);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Size = new Size(650, 0x11a);
            this.TabPage7.TabIndex = 6;
            this.TabPage7.Text = "الموردين";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.UserIsSuplierEditDelet.AutoSize = true;
            this.UserIsSuplierEditDelet.Checked = true;
            this.UserIsSuplierEditDelet.CheckState = CheckState.Checked;
            this.UserIsSuplierEditDelet.Location = new Point(0x193, 0x63);
            this.UserIsSuplierEditDelet.Name = "UserIsSuplierEditDelet";
            this.UserIsSuplierEditDelet.Size = new Size(0xd3, 20);
            this.UserIsSuplierEditDelet.TabIndex = 6;
            this.UserIsSuplierEditDelet.Text = "السماح له في حذف وتعديل المورد";
            this.UserIsSuplierEditDelet.UseVisualStyleBackColor = true;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Controls.Add(this.TabPage8);
            this.TabControl1.Controls.Add(this.TabPage9);
            this.TabControl1.Controls.Add(this.TabPage10);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0xb2);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x292, 0x14c);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x2b;
            this.TabPage4.Controls.Add(this.UserIsSaleWindowEditDar);
            this.TabPage4.Controls.Add(this.UserIsSaleWindowSaleZero);
            this.TabPage4.Controls.Add(this.UserIsSaleWindowEditQuntity);
            this.TabPage4.Controls.Add(this.UserIsSaleWindowEditPrice);
            this.TabPage4.Controls.Add(this.UserIsSaleWindowEditDis);
            this.TabPage4.Controls.Add(this.UserIsSaleWindowSaleOut);
            this.TabPage4.Controls.Add(this.UserIsSaleWindowCanceItem);
            this.TabPage4.Controls.Add(this.UserIsViewQQViewQu);
            this.TabPage4.Controls.Add(this.UserIsViewQQViewCo);
            this.TabPage4.Controls.Add(this.UserIsSaleWindow);
            this.TabPage4.Location = new Point(4, 0x2e);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new Padding(3);
            this.TabPage4.Size = new Size(650, 0x11a);
            this.TabPage4.TabIndex = 10;
            this.TabPage4.Text = "شاشة البيع والاستعلام";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowEditDar.AutoSize = true;
            this.UserIsSaleWindowEditDar.Location = new Point(0x133, 0xc7);
            this.UserIsSaleWindowEditDar.Name = "UserIsSaleWindowEditDar";
            this.UserIsSaleWindowEditDar.Size = new Size(0x133, 20);
            this.UserIsSaleWindowEditDar.TabIndex = 0x16;
            this.UserIsSaleWindowEditDar.Text = "السماح له في اضافة/تعديل الضريبة في شاشة البيع";
            this.UserIsSaleWindowEditDar.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowSaleZero.AutoSize = true;
            this.UserIsSaleWindowSaleZero.Checked = true;
            this.UserIsSaleWindowSaleZero.CheckState = CheckState.Checked;
            this.UserIsSaleWindowSaleZero.Location = new Point(0x181, 0xfb);
            this.UserIsSaleWindowSaleZero.Name = "UserIsSaleWindowSaleZero";
            this.UserIsSaleWindowSaleZero.Size = new Size(0xe5, 20);
            this.UserIsSaleWindowSaleZero.TabIndex = 0x15;
            this.UserIsSaleWindowSaleZero.Text = "عند تعديل الكمية المباعة اقبل الرقم 0";
            this.UserIsSaleWindowSaleZero.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowEditQuntity.AutoSize = true;
            this.UserIsSaleWindowEditQuntity.Checked = true;
            this.UserIsSaleWindowEditQuntity.CheckState = CheckState.Checked;
            this.UserIsSaleWindowEditQuntity.Location = new Point(0x159, 0xe1);
            this.UserIsSaleWindowEditQuntity.Name = "UserIsSaleWindowEditQuntity";
            this.UserIsSaleWindowEditQuntity.Size = new Size(0x10d, 20);
            this.UserIsSaleWindowEditQuntity.TabIndex = 20;
            this.UserIsSaleWindowEditQuntity.Text = "السماح له في تعديل الكمية في شاشة البيع";
            this.UserIsSaleWindowEditQuntity.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowEditPrice.AutoSize = true;
            this.UserIsSaleWindowEditPrice.Checked = true;
            this.UserIsSaleWindowEditPrice.CheckState = CheckState.Checked;
            this.UserIsSaleWindowEditPrice.Location = new Point(0x15b, 0x93);
            this.UserIsSaleWindowEditPrice.Name = "UserIsSaleWindowEditPrice";
            this.UserIsSaleWindowEditPrice.Size = new Size(0x10b, 20);
            this.UserIsSaleWindowEditPrice.TabIndex = 0x13;
            this.UserIsSaleWindowEditPrice.Text = "السماح له في تعديل السعر في شاشة البيع";
            this.UserIsSaleWindowEditPrice.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowEditDis.AutoSize = true;
            this.UserIsSaleWindowEditDis.Checked = true;
            this.UserIsSaleWindowEditDis.CheckState = CheckState.Checked;
            this.UserIsSaleWindowEditDis.Location = new Point(0x13d, 0xad);
            this.UserIsSaleWindowEditDis.Name = "UserIsSaleWindowEditDis";
            this.UserIsSaleWindowEditDis.Size = new Size(0x129, 20);
            this.UserIsSaleWindowEditDis.TabIndex = 0x12;
            this.UserIsSaleWindowEditDis.Text = "السماح له في اضافة/تعديل خصم في شاشة البيع";
            this.UserIsSaleWindowEditDis.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowSaleOut.AutoSize = true;
            this.UserIsSaleWindowSaleOut.Checked = true;
            this.UserIsSaleWindowSaleOut.CheckState = CheckState.Checked;
            this.UserIsSaleWindowSaleOut.Location = new Point(0xf3, 0x79);
            this.UserIsSaleWindowSaleOut.Name = "UserIsSaleWindowSaleOut";
            this.UserIsSaleWindowSaleOut.Size = new Size(0x173, 20);
            this.UserIsSaleWindowSaleOut.TabIndex = 0x11;
            this.UserIsSaleWindowSaleOut.Text = "السماح له في بيع مادة/خدمة جديدة غير موجودة في المستودع";
            this.UserIsSaleWindowSaleOut.UseVisualStyleBackColor = true;
            this.UserIsSaleWindowCanceItem.AutoSize = true;
            this.UserIsSaleWindowCanceItem.Checked = true;
            this.UserIsSaleWindowCanceItem.CheckState = CheckState.Checked;
            this.UserIsSaleWindowCanceItem.Location = new Point(0x139, 0x2e);
            this.UserIsSaleWindowCanceItem.Name = "UserIsSaleWindowCanceItem";
            this.UserIsSaleWindowCanceItem.Size = new Size(0x12d, 20);
            this.UserIsSaleWindowCanceItem.TabIndex = 0x10;
            this.UserIsSaleWindowCanceItem.Text = "السماح له في إلغاء المادة المباعة في شاشة البيع";
            this.UserIsSaleWindowCanceItem.UseVisualStyleBackColor = true;
            this.UserIsViewQQViewQu.AutoSize = true;
            this.UserIsViewQQViewQu.Checked = true;
            this.UserIsViewQQViewQu.CheckState = CheckState.Checked;
            this.UserIsViewQQViewQu.Location = new Point(0x164, 0x5f);
            this.UserIsViewQQViewQu.Name = "UserIsViewQQViewQu";
            this.UserIsViewQQViewQu.Size = new Size(0x102, 20);
            this.UserIsViewQQViewQu.TabIndex = 14;
            this.UserIsViewQQViewQu.Text = "عرض الكمية المتوفرة في شاشة الاستعلام";
            this.UserIsViewQQViewQu.UseVisualStyleBackColor = true;
            this.UserIsViewQQViewCo.AutoSize = true;
            this.UserIsViewQQViewCo.Checked = true;
            this.UserIsViewQQViewCo.CheckState = CheckState.Checked;
            this.UserIsViewQQViewCo.Location = new Point(370, 0x45);
            this.UserIsViewQQViewCo.Name = "UserIsViewQQViewCo";
            this.UserIsViewQQViewCo.Size = new Size(0xf4, 20);
            this.UserIsViewQQViewCo.TabIndex = 13;
            this.UserIsViewQQViewCo.Text = "عرض سعر التكلفة في شاشة الاستعلام";
            this.UserIsViewQQViewCo.UseVisualStyleBackColor = true;
            this.UserIsSaleWindow.AutoSize = true;
            this.UserIsSaleWindow.Checked = true;
            this.UserIsSaleWindow.CheckState = CheckState.Checked;
            this.UserIsSaleWindow.Location = new Point(0x18b, 20);
            this.UserIsSaleWindow.Name = "UserIsSaleWindow";
            this.UserIsSaleWindow.Size = new Size(0xdb, 20);
            this.UserIsSaleWindow.TabIndex = 12;
            this.UserIsSaleWindow.Text = "السماح له بالبيع وشاشة الاستعلام";
            this.UserIsSaleWindow.UseVisualStyleBackColor = true;
            this.TabPage8.Controls.Add(this.UserIsRemmemberAdd);
            this.TabPage8.Controls.Add(this.UserIsRemmember);
            this.TabPage8.Location = new Point(4, 0x2e);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Size = new Size(650, 0x11a);
            this.TabPage8.TabIndex = 7;
            this.TabPage8.Text = "الملاحظات والتنبيه";
            this.TabPage8.UseVisualStyleBackColor = true;
            this.TabPage9.Controls.Add(this.UserIsCashEnable);
            this.TabPage9.Controls.Add(this.UserIsCashMe);
            this.TabPage9.Controls.Add(this.UserIsCashList);
            this.TabPage9.Location = new Point(4, 0x2e);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Size = new Size(650, 0x11a);
            this.TabPage9.TabIndex = 8;
            this.TabPage9.Text = "صندوق الكاش";
            this.TabPage9.UseVisualStyleBackColor = true;
            this.UserIsCashEnable.AutoSize = true;
            this.UserIsCashEnable.Checked = true;
            this.UserIsCashEnable.CheckState = CheckState.Checked;
            this.UserIsCashEnable.Location = new Point(0xf6, 0x65);
            this.UserIsCashEnable.Name = "UserIsCashEnable";
            this.UserIsCashEnable.Size = new Size(0x16a, 20);
            this.UserIsCashEnable.TabIndex = 9;
            this.UserIsCashEnable.Text = "السماح له في التحكم في رصد/عدم رصد الحركات على الكاش";
            this.UserIsCashEnable.UseVisualStyleBackColor = true;
            this.UserIsCashMe.AutoSize = true;
            this.UserIsCashMe.Checked = true;
            this.UserIsCashMe.CheckState = CheckState.Checked;
            this.UserIsCashMe.Location = new Point(0x15c, 0x41);
            this.UserIsCashMe.Name = "UserIsCashMe";
            this.UserIsCashMe.Size = new Size(260, 20);
            this.UserIsCashMe.TabIndex = 8;
            this.UserIsCashMe.Text = "السماح له في معرفة قيمة الكاش الخاص به";
            this.UserIsCashMe.UseVisualStyleBackColor = true;
            this.UserIsCashList.Location = new Point(8, 0x16);
            this.UserIsCashList.Name = "UserIsCashList";
            this.UserIsCashList.Size = new Size(600, 0x25);
            this.UserIsCashList.TabIndex = 7;
            this.UserIsCashList.Text = "السماح له في إدارة صناديق الكاش والإطلاع عليها لجميع الموظفين، واضافة خزية على الموظفين";
            this.UserIsCashList.UseVisualStyleBackColor = true;
            this.TabPage10.Controls.Add(this.UserIsWarehousAdd);
            this.TabPage10.Controls.Add(this.UserIsWarehousList);
            this.TabPage10.Location = new Point(4, 0x2e);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Padding = new Padding(3);
            this.TabPage10.Size = new Size(650, 0x11a);
            this.TabPage10.TabIndex = 9;
            this.TabPage10.Text = "المستودع";
            this.TabPage10.UseVisualStyleBackColor = true;
            this.UserIsWarehousAdd.AutoSize = true;
            this.UserIsWarehousAdd.Checked = true;
            this.UserIsWarehousAdd.CheckState = CheckState.Checked;
            this.UserIsWarehousAdd.Location = new Point(0x14e, 0x34);
            this.UserIsWarehousAdd.Name = "UserIsWarehousAdd";
            this.UserIsWarehousAdd.Size = new Size(280, 20);
            this.UserIsWarehousAdd.TabIndex = 1;
            this.UserIsWarehousAdd.Text = "السماح له في اضافة/تعديل مادة في المستودع";
            this.UserIsWarehousAdd.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x292, 0x247);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "UserAddEdite";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة تعديل موظفين";
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage8.ResumeLayout(false);
            this.TabPage8.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.TabPage9.PerformLayout();
            this.TabPage10.ResumeLayout(false);
            this.TabPage10.PerformLayout();
            base.ResumeLayout(false);
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
                Interaction.MsgBox(A.PR.I.ToString(), MsgBoxStyle.Exclamation, null);
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

        private void P(object A, EventArgs R)
        {
            if (((this.TxTUserLog.Text == null) | (this.TxTUserName.Text == null)) | (this.TxTUserPass.Text == null))
            {
                Interaction.MsgBox(A.PR.F.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    string cmdText = "";
                    cmdText = (TT.A <= 0) ? "INSERT INTO [TaNNUsers] ([CenterFrontID], [UserName], [UserLog], [UserPass], [UserIsAdmin], [UserIsWarehousList], [UserIsWarehousAdd], [UserIsBarCodeMaker], [UserIsSaleWindow], [UserIsSaleWindowCanceItem], [UserIsSaleWindowEditPrice], [UserIsSaleWindowEditQuntity], [UserIsSaleWindowEditDis], [UserIsSaleWindowEditDar], [UserIsSaleWindowSaleOut], [UserIsInvSaleList], [UserIsInvSaleEdit], [UserIsInvSaleDelete], [UserIsPurchList], [UserIsPurchAdd], [UserIsPurchApplStore], [UserIsCustomerList], [UserIsCustomerAdd], [UserIsCustomerPayAdd], [UserIsCustomerEditDelet], [UserIsSuplierList], [UserIsSuplierAdd], [UserIsSuplierPayAdd], [UserIsSuplierEditDelet], [UserIsExpensesList], [UserIsExpensesAdd], [UserIsRemmember], [UserIsRemmemberAdd], [UserIsReturnSale], [UserIsReturnPurch], [UserIsViewGeneralProft], [UserIsViewQQViewCo], [UserIsViewQQViewQu], [UserIsCashList], [UserIsCashMe], [UserIsCashEnable], [UserIsChangeDate], [UserGReport], [UserIsChangeCenter], [UserIsRestMAX], [UserIsSaleWindowSaleZero], [UserIsSaleWindowSalePeind]) VALUES (@CenterFrontID, @UserName, @UserLog, @UserPass, @UserIsAdmin, @UserIsWarehousList, @UserIsWarehousAdd, @UserIsBarCodeMaker, @UserIsSaleWindow, @UserIsSaleWindowCanceItem, @UserIsSaleWindowEditPrice, @UserIsSaleWindowEditQuntity, @UserIsSaleWindowEditDis, @UserIsSaleWindowEditDar, @UserIsSaleWindowSaleOut, @UserIsInvSaleList, @UserIsInvSaleEdit, @UserIsInvSaleDelete, @UserIsPurchList, @UserIsPurchAdd, @UserIsPurchApplStore, @UserIsCustomerList, @UserIsCustomerAdd, @UserIsCustomerPayAdd, @UserIsCustomerEditDelet, @UserIsSuplierList, @UserIsSuplierAdd, @UserIsSuplierPayAdd, @UserIsSuplierEditDelet, @UserIsExpensesList, @UserIsExpensesAdd, @UserIsRemmember, @UserIsRemmemberAdd, @UserIsReturnSale, @UserIsReturnPurch, @UserIsViewGeneralProft, @UserIsViewQQViewCo, @UserIsViewQQViewQu, @UserIsCashList, @UserIsCashMe, @UserIsCashEnable, @UserIsChangeDate, @UserGReport, @UserIsChangeCenter, @UserIsRestMAX, @UserIsSaleWindowSaleZero, @UserIsSaleWindowSalePeind)" : "UPDATE [TaNNUsers] SET [CenterFrontID] = @CenterFrontID, [UserName] = @UserName, [UserLog] = @UserLog, [UserPass] = @UserPass, [UserIsAdmin] = @UserIsAdmin, [UserIsWarehousList] = @UserIsWarehousList, [UserIsWarehousAdd] = @UserIsWarehousAdd, [UserIsBarCodeMaker] = @UserIsBarCodeMaker, [UserIsSaleWindow] = @UserIsSaleWindow, [UserIsSaleWindowCanceItem] = @UserIsSaleWindowCanceItem, [UserIsSaleWindowEditPrice] = @UserIsSaleWindowEditPrice, [UserIsSaleWindowEditQuntity] =@UserIsSaleWindowEditQuntity, [UserIsSaleWindowEditDis] = @UserIsSaleWindowEditDis, [UserIsSaleWindowEditDar] = @UserIsSaleWindowEditDar, [UserIsSaleWindowSaleOut] = @UserIsSaleWindowSaleOut, [UserIsInvSaleList] = @UserIsInvSaleList, [UserIsInvSaleEdit] = @UserIsInvSaleEdit, [UserIsInvSaleDelete] = @UserIsInvSaleDelete, [UserIsPurchList] = @UserIsPurchList, [UserIsPurchAdd] = @UserIsPurchAdd, [UserIsPurchApplStore] = @UserIsPurchApplStore, [UserIsCustomerList] = @UserIsCustomerList, [UserIsCustomerAdd] = @UserIsCustomerAdd, [UserIsCustomerPayAdd] = @UserIsCustomerPayAdd, [UserIsCustomerEditDelet] = @UserIsCustomerEditDelet, [UserIsSuplierList] = @UserIsSuplierList, [UserIsSuplierAdd] = @UserIsSuplierAdd, [UserIsSuplierPayAdd] = @UserIsSuplierPayAdd, [UserIsSuplierEditDelet] = @UserIsSuplierEditDelet, [UserIsExpensesList] = @UserIsExpensesList, [UserIsExpensesAdd] = @UserIsExpensesAdd, [UserIsRemmember] = @UserIsRemmember, [UserIsRemmemberAdd] = @UserIsRemmemberAdd, [UserIsReturnSale] = @UserIsReturnSale, [UserIsReturnPurch] = @UserIsReturnPurch, [UserIsViewGeneralProft] = @UserIsViewGeneralProft, [UserIsViewQQViewCo] = @UserIsViewQQViewCo, [UserIsViewQQViewQu] = @UserIsViewQQViewQu, [UserIsCashList] = @UserIsCashList, [UserIsCashMe] = @UserIsCashMe, [UserIsCashEnable] = @UserIsCashEnable, [UserIsChangeDate] = @UserIsChangeDate, [UserGReport] = @UserGReport, [UserIsChangeCenter] = @UserIsChangeCenter, [UserIsRestMAX] = @UserIsRestMAX, [UserIsSaleWindowSaleZero] = @UserIsSaleWindowSaleZero, [UserIsSaleWindowSalePeind] = @UserIsSaleWindowSalePeind WHERE [UserID] = @UserID";
                    SqlCommand command = new SqlCommand(cmdText, this.A);
                    command.Parameters.AddWithValue("UserID", TT.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    command.Parameters.AddWithValue("UserName", this.TxTUserName.Text.Trim());
                    command.Parameters.AddWithValue("UserLog", this.TxTUserLog.Text.Trim());
                    command.Parameters.AddWithValue("UserPass", this.A.A(this.TxTUserPass.Text.Trim()));
                    command.Parameters.AddWithValue("UserIsAdmin", false);
                    command.Parameters.AddWithValue("UserIsWarehousList", this.UserIsWarehousList.Checked);
                    command.Parameters.AddWithValue("UserIsWarehousAdd", this.UserIsWarehousAdd.Checked);
                    command.Parameters.AddWithValue("UserIsBarCodeMaker", this.UserIsBarCodeMaker.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindow", this.UserIsSaleWindow.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowCanceItem", this.UserIsSaleWindowCanceItem.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowEditPrice", this.UserIsSaleWindowEditPrice.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowEditQuntity", this.UserIsSaleWindowEditQuntity.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowEditDis", this.UserIsSaleWindowEditDis.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowEditDar", this.UserIsSaleWindowEditDar.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowSaleOut", this.UserIsSaleWindowSaleOut.Checked);
                    command.Parameters.AddWithValue("UserIsInvSaleList", this.UserIsInvSaleList.Checked);
                    command.Parameters.AddWithValue("UserIsInvSaleEdit", this.UserIsInvSaleEdit.Checked);
                    command.Parameters.AddWithValue("UserIsInvSaleDelete", this.UserIsInvSaleDelete.Checked);
                    command.Parameters.AddWithValue("UserIsPurchList", this.UserIsPurchList.Checked);
                    command.Parameters.AddWithValue("UserIsPurchAdd", this.UserIsPurchAdd.Checked);
                    command.Parameters.AddWithValue("UserIsPurchApplStore", this.UserIsPurchApplStore.Checked);
                    command.Parameters.AddWithValue("UserIsCustomerList", this.UserIsCustomerList.Checked);
                    command.Parameters.AddWithValue("UserIsCustomerAdd", this.UserIsCustomerAdd.Checked);
                    command.Parameters.AddWithValue("UserIsCustomerPayAdd", this.UserIsCustomerPayAdd.Checked);
                    command.Parameters.AddWithValue("UserIsCustomerEditDelet", this.UserIsCustomerEditDelet.Checked);
                    command.Parameters.AddWithValue("UserIsSuplierList", this.UserIsSuplierList.Checked);
                    command.Parameters.AddWithValue("UserIsSuplierAdd", this.UserIsSuplierAdd.Checked);
                    command.Parameters.AddWithValue("UserIsSuplierPayAdd", this.UserIsSuplierPayAdd.Checked);
                    command.Parameters.AddWithValue("UserIsSuplierEditDelet", this.UserIsSuplierEditDelet.Checked);
                    command.Parameters.AddWithValue("UserIsExpensesList", this.UserIsExpensesList.Checked);
                    command.Parameters.AddWithValue("UserIsExpensesAdd", this.UserIsExpensesAdd.Checked);
                    command.Parameters.AddWithValue("UserIsRemmember", this.UserIsRemmember.Checked);
                    command.Parameters.AddWithValue("UserIsRemmemberAdd", this.UserIsRemmemberAdd.Checked);
                    command.Parameters.AddWithValue("UserIsReturnSale", this.UserIsReturnSale.Checked);
                    command.Parameters.AddWithValue("UserIsReturnPurch", this.UserIsReturnPurch.Checked);
                    command.Parameters.AddWithValue("UserIsViewGeneralProft", this.UserIsViewGeneralProft.Checked);
                    command.Parameters.AddWithValue("UserIsViewQQViewCo", this.UserIsViewQQViewCo.Checked);
                    command.Parameters.AddWithValue("UserIsViewQQViewQu", this.UserIsViewQQViewQu.Checked);
                    command.Parameters.AddWithValue("UserIsCashList", this.UserIsCashList.Checked);
                    command.Parameters.AddWithValue("UserIsCashMe", this.UserIsCashMe.Checked);
                    command.Parameters.AddWithValue("UserIsCashEnable", this.UserIsCashEnable.Checked);
                    command.Parameters.AddWithValue("UserGReport", this.UserGReport.Checked);
                    command.Parameters.AddWithValue("UserIsChangeCenter", this.UserIsChangeCenter.Checked);
                    command.Parameters.AddWithValue("UserIsChangeDate", this.UserIsChangeDate.Checked);
                    command.Parameters.AddWithValue("UserIsRestMAX", this.UserIsRestMAX.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowSaleZero", this.UserIsSaleWindowSaleZero.Checked);
                    command.Parameters.AddWithValue("UserIsSaleWindowSalePeind", this.UserIsSaleWindowSalePeind.Checked);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.R();
                    base.Dispose();
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

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890asdfghjklzxcvbnmqwertyuiop".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.I.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox UserIsInvSaleEdit
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox UserIsInvSaleList
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox UserIsRemmember
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox UserIsPurchApplStore
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual CheckBox UserIsPurchList
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox UserIsBarCodeMaker
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual CheckBox UserIsWarehousList
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual CheckBox UserIsExpensesAdd
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual CheckBox UserIsCustomerPayAdd
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual CheckBox UserIsCustomerAdd
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual CheckBox UserIsCustomerList
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual CheckBox UserIsSuplierPayAdd
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual CheckBox UserIsSuplierAdd
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual CheckBox UserIsSuplierList
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual CheckBox UserIsRemmemberAdd
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual CheckBox UserIsExpensesList
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
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
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TextBox TxTUserName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTUserLog
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox p = this.P;
                if (p != null)
                {
                    p.KeyPress -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.KeyPress += handler;
                }
            }
        }

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabPage TabPage6
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TabPage TabPage7
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual TabPage TabPage8
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual CheckBox UserIsViewGeneralProft
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual TabPage TabPage9
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual CheckBox UserIsCashMe
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual CheckBox UserIsCashList
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual TabPage TabPage10
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual CheckBox UserIsWarehousAdd
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual CheckBox UserIsPurchAdd
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual CheckBox UserIsCustomerEditDelet
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual CheckBox UserIsSuplierEditDelet
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual CheckBox UserIsInvSaleDelete
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual CheckBox UserIsChangeCenter
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual CheckBox UserIsReturnSale
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual CheckBox UserIsReturnPurch
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual CheckBox UserIsSaleWindowEditPrice
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual CheckBox UserIsSaleWindowEditDis
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual CheckBox UserIsSaleWindowSaleOut
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual CheckBox UserIsSaleWindowCanceItem
        {
            [CompilerGenerated]
            get => 
                this.DR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.DR = value);
        }

        internal virtual CheckBox UserIsViewQQViewQu
        {
            [CompilerGenerated]
            get => 
                this.FR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.FR = value);
        }

        internal virtual CheckBox UserIsViewQQViewCo
        {
            [CompilerGenerated]
            get => 
                this.HR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.HR = value);
        }

        internal virtual CheckBox UserIsSaleWindow
        {
            [CompilerGenerated]
            get => 
                this.TR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.TR = value);
        }

        internal virtual CheckBox UserIsCashEnable
        {
            [CompilerGenerated]
            get => 
                this.XR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.XR = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox UserGReport
        {
            [CompilerGenerated]
            get => 
                this.GR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.GR = value);
        }

        internal virtual CheckBox UserIsChangeDate
        {
            [CompilerGenerated]
            get => 
                this.ER;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.ER = value);
        }

        internal virtual CheckBox UserIsSaleWindowEditQuntity
        {
            [CompilerGenerated]
            get => 
                this.KR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.KR = value);
        }

        internal virtual CheckBox UserIsSaleWindowSalePeind
        {
            [CompilerGenerated]
            get => 
                this.UR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.UR = value);
        }

        internal virtual CheckBox UserIsRestMAX
        {
            [CompilerGenerated]
            get => 
                this.LR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.LR = value);
        }

        internal virtual CheckBox UserIsSaleWindowSaleZero
        {
            [CompilerGenerated]
            get => 
                this.NR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.NR = value);
        }

        internal virtual CheckBox UserIsSaleWindowEditDar
        {
            [CompilerGenerated]
            get => 
                this.VR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.VR = value);
        }
    }
}

