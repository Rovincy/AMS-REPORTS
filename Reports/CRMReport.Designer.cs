namespace ServerSide.Reports
{
    partial class CRMReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRMReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.line1 = new DevExpress.XtraReports.UI.XRLine();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Date = new DevExpress.XtraReports.Parameters.Parameter();
            this.startDate = new DevExpress.XtraReports.Parameters.RangeStartParameter();
            this.endDate = new DevExpress.XtraReports.Parameters.RangeEndParameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.line1,
            this.pageInfo2,
            this.pictureBox1,
            this.label1});
            this.TopMargin.HeightF = 111.2607F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1});
            this.BottomMargin.HeightF = 18F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.LineWidth = 2F;
            this.line1.LocationFloat = new DevExpress.Utils.PointFloat(0.2702925F, 102.9273F);
            this.line1.Name = "line1";
            this.line1.SizeF = new System.Drawing.SizeF(1070.517F, 8.333344F);
            this.line1.StylePriority.UseForeColor = false;
            // 
            // pageInfo2
            // 
            this.pageInfo2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInfo2.ForeColor = System.Drawing.Color.Black;
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(771.5519F, 84.26067F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo2.SizeF = new System.Drawing.SizeF(299.2354F, 16.99999F);
            this.pageInfo2.StylePriority.UseFont = false;
            this.pageInfo2.StylePriority.UseForeColor = false;
            this.pageInfo2.StylePriority.UseTextAlignment = false;
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.pageInfo2.TextFormatString = "{0:dddd, MMMM d, yyyy hh:mm tt}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageUrl = "https://www.jubailhospital.com/backend/images/insurance_partners/apex.jpg";
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(934.09F, 0F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeF = new System.Drawing.SizeF(136.6976F, 80.20834F);
            this.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 57.59394F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(213.8855F, 30F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "CRM Report";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo1.SizeF = new System.Drawing.SizeF(100F, 17.8985F);
            this.pageInfo1.StylePriority.UseTextAlignment = false;
            this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Afs_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            queryParameter1.Name = "startDate";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?startDate", typeof(System.DateTime));
            queryParameter2.Name = "endDate";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?endDate", typeof(System.DateTime));
            customSqlQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Date
            // 
            this.Date.Description = "Date";
            this.Date.Name = "Date";
            this.Date.Type = typeof(System.DateTime);
            this.Date.ValueSourceSettings = new DevExpress.XtraReports.Parameters.RangeParametersSettings(this.startDate, this.endDate);
            // 
            // startDate
            // 
            this.startDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Today()")});
            this.startDate.Name = "startDate";
            this.startDate.ValueInfo = "2024-05-02";
            // 
            // endDate
            // 
            this.endDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Now()")});
            this.endDate.Name = "endDate";
            this.endDate.ValueInfo = "2024-05-02";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table5});
            this.PageHeader.HeightF = 18F;
            this.PageHeader.Name = "PageHeader";
            // 
            // table5
            // 
            this.table5.BackColor = System.Drawing.Color.Black;
            this.table5.BorderColor = System.Drawing.Color.White;
            this.table5.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.table5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table5.ForeColor = System.Drawing.Color.White;
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table5.Name = "table5";
            this.table5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5});
            this.table5.SizeF = new System.Drawing.SizeF(1073F, 18F);
            this.table5.StylePriority.UseBackColor = false;
            this.table5.StylePriority.UseBorderColor = false;
            this.table5.StylePriority.UseBorders = false;
            this.table5.StylePriority.UseFont = false;
            this.table5.StylePriority.UseForeColor = false;
            this.table5.StylePriority.UsePadding = false;
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell21,
            this.tableCell25,
            this.xrTableCell2,
            this.xrTableCell6,
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell3,
            this.xrTableCell7,
            this.xrTableCell5});
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 11.5D;
            // 
            // tableCell21
            // 
            this.tableCell21.Multiline = true;
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.StylePriority.UseTextAlignment = false;
            this.tableCell21.Text = "#";
            this.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell21.Weight = 0.24903603232047355D;
            // 
            // tableCell25
            // 
            this.tableCell25.Multiline = true;
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.Text = "Caller Type";
            this.tableCell25.Weight = 0.49236236345330531D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Provider";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell2.Weight = 1.7962950766145298D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Phone Number";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell1.Weight = 1.0509605434979976D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Call Details";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell3.Weight = 1.5282571863065795D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[callerType]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(28.37701F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(56.10341F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex]+1")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(28.37702F, 23F);
            this.xrLabel2.Text = "xrLabel1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[facility_name]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(84.48042F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(174.9704F, 23F);
            this.xrLabel3.Text = "xrLabel1";
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Type";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell4.Weight = 1.2097040263263448D;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[firstname]")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(255.8303F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(72.91669F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[othernames]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(326.4552F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(77.08334F, 23F);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[surname]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(403.5384F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(57.60565F, 23F);
            this.xrLabel6.Text = "xrLabel5";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[callType]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(461.1441F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(123.6788F, 23F);
            this.xrLabel7.Text = "xrLabel5";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[callDetails]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(692.2719F, 0F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(156.2473F, 23F);
            this.xrLabel8.Text = "xrLabel5";
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Date";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell5.Weight = 1.0978256854132913D;
            // 
            // xrLabel9
            // 
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[timestamp]")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(960.7596F, 0F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(110.028F, 23F);
            this.xrLabel9.Text = "xrLabel5";
            this.xrLabel9.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "Member";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell6.Weight = 1.9727648585292961D;
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PhoneNumber]")});
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(584.8229F, 0F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(107.449F, 23F);
            this.xrLabel10.Text = "xrLabel5";
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Officer";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell7.Weight = 1.0978256854132913D;
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Officer]")});
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(848.519F, 0F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(110.028F, 23F);
            this.xrLabel11.Text = "xrLabel5";
            this.xrLabel11.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // CRMReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(12, 15, 111, 18);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Date});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLine line1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter Date;
        private DevExpress.XtraReports.Parameters.RangeStartParameter startDate;
        private DevExpress.XtraReports.Parameters.RangeEndParameter endDate;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
    }
}
