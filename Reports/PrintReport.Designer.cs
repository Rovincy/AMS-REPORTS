namespace ServerSide.Reports
{
    partial class PrintReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintReport));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.line1 = new DevExpress.XtraReports.UI.XRLine();
            this.label47 = new DevExpress.XtraReports.UI.XRLabel();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Date = new DevExpress.XtraReports.Parameters.Parameter();
            this.startDate = new DevExpress.XtraReports.Parameters.RangeStartParameter();
            this.endDate = new DevExpress.XtraReports.Parameters.RangeEndParameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox1,
            this.pageInfo2,
            this.label1,
            this.line1,
            this.label47,
            this.label8,
            this.label9,
            this.label10});
            this.TopMargin.Name = "TopMargin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageUrl = "https://www.jubailhospital.com/backend/images/insurance_partners/apex.jpg";
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(577.3024F, 0F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeF = new System.Drawing.SizeF(136.6976F, 74.66659F);
            this.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // pageInfo2
            // 
            this.pageInfo2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInfo2.ForeColor = System.Drawing.Color.Black;
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(414.7646F, 74.66664F);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 44.66648F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(402.08F, 30F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "Print Report";
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.LineWidth = 2F;
            this.line1.LocationFloat = new DevExpress.Utils.PointFloat(0.2702925F, 91.66656F);
            this.line1.Name = "line1";
            this.line1.SizeF = new System.Drawing.SizeF(713.7297F, 8.333351F);
            this.line1.StylePriority.UseForeColor = false;
            // 
            // label47
            // 
            this.label47.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?startDate")});
            this.label47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.LocationFloat = new DevExpress.Utils.PointFloat(57.53983F, 74.66653F);
            this.label47.Multiline = true;
            this.label47.Name = "label47";
            this.label47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.label47.SizeF = new System.Drawing.SizeF(79.15187F, 17.00001F);
            this.label47.StylePriority.UseFont = false;
            this.label47.StylePriority.UsePadding = false;
            this.label47.StylePriority.UseTextAlignment = false;
            this.label47.Text = "xrLabel2";
            this.label47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.label47.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 74.66647F);
            this.label8.Multiline = true;
            this.label8.Name = "label8";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label8.SizeF = new System.Drawing.SizeF(57.26957F, 16.99999F);
            this.label8.StylePriority.UseFont = false;
            this.label8.StylePriority.UsePadding = false;
            this.label8.Text = "Period:";
            // 
            // label9
            // 
            this.label9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?endDate")});
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.LocationFloat = new DevExpress.Utils.PointFloat(153.4425F, 74.66664F);
            this.label9.Multiline = true;
            this.label9.Name = "label9";
            this.label9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.label9.SizeF = new System.Drawing.SizeF(83.34378F, 16.99999F);
            this.label9.StylePriority.UseFont = false;
            this.label9.StylePriority.UsePadding = false;
            this.label9.StylePriority.UseTextAlignment = false;
            this.label9.Text = "xrLabel2";
            this.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.label9.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.LocationFloat = new DevExpress.Utils.PointFloat(136.7439F, 74.66653F);
            this.label10.Multiline = true;
            this.label10.Name = "label10";
            this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label10.SizeF = new System.Drawing.SizeF(16.69853F, 16.99999F);
            this.label10.StylePriority.UseFont = false;
            this.label10.StylePriority.UsePadding = false;
            this.label10.StylePriority.UseTextAlignment = false;
            this.label10.Text = " -";
            this.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1});
            this.BottomMargin.HeightF = 18F;
            this.BottomMargin.Name = "BottomMargin";
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
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 17.00001F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COUNT(DISTINCT PR.member_no)]")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(596.4547F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(117.5453F, 17.00001F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel2";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[companyName]")});
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(167.4238F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(429.0309F, 17.00001F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel2";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DATE(PR.print_date)]")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(30.91698F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(136.5069F, 17.00001F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel2.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex]+1")});
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0.2702925F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(30.64668F, 17.00001F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel2";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table5});
            this.GroupHeader1.HeightF = 18F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // table5
            // 
            this.table5.BackColor = System.Drawing.Color.Black;
            this.table5.BorderColor = System.Drawing.Color.White;
            this.table5.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.table5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table5.ForeColor = System.Drawing.Color.White;
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 0F);
            this.table5.Name = "table5";
            this.table5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5});
            this.table5.SizeF = new System.Drawing.SizeF(713.7297F, 18F);
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
            this.xrTableCell5,
            this.tableCell25,
            this.xrTableCell4});
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
            this.tableCell21.Weight = 0.18262282418607426D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Date";
            this.xrTableCell5.Weight = 0.81344140029535117D;
            // 
            // tableCell25
            // 
            this.tableCell25.Multiline = true;
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.Text = "Company";
            this.tableCell25.Weight = 2.5565851312104D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Count";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell4.Weight = 0.70044997510906926D;
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
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel5});
            this.ReportFooter.HeightF = 17.00001F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([COUNT(DISTINCT PR.member_no)])")});
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(596.4547F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(117.5453F, 17.00001F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel6.Summary = xrSummary1;
            this.xrLabel6.Text = "xrLabel2";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(478.9094F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(117.5453F, 17.00001F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Total";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PrintReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(78, 58, 100, 18);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Date});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRLine line1;
        private DevExpress.XtraReports.UI.XRLabel label47;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.Parameters.Parameter Date;
        private DevExpress.XtraReports.Parameters.RangeStartParameter startDate;
        private DevExpress.XtraReports.Parameters.RangeEndParameter endDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    }
}
