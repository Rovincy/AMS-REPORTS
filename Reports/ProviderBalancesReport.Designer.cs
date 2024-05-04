namespace ServerSide.Reports
{
    partial class ProviderBalancesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderBalancesReport));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.line1 = new DevExpress.XtraReports.UI.XRLine();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Provider = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Afs_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select provider_id,facility_name from provider_api";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MAX(latestTime)]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(539.8201F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(166.1798F, 23F);
            this.xrLabel7.Text = "xrLabel3";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel7.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MAX(latestAmount)]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(418.7791F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(121.041F, 23F);
            this.xrLabel6.Text = "xrLabel3";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel6.TextFormatString = "{0:N2}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[grandTotalBalance]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(277.599F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(141.1801F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel3.TextFormatString = "{0:N2}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[facility_name]")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(36.80556F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(240.7934F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex]+1")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(36.80556F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox1,
            this.label1,
            this.pageInfo2,
            this.line1});
            this.TopMargin.HeightF = 111.2607F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageUrl = "https://www.jubailhospital.com/backend/images/insurance_partners/apex.jpg";
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(569.3024F, 0F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeF = new System.Drawing.SizeF(136.6976F, 80.20834F);
            this.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 57.59394F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(249.9966F, 30F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "Provider Balance";
            // 
            // pageInfo2
            // 
            this.pageInfo2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInfo2.ForeColor = System.Drawing.Color.Black;
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(392.7644F, 85.92731F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo2.SizeF = new System.Drawing.SizeF(313.2356F, 17F);
            this.pageInfo2.StylePriority.UseFont = false;
            this.pageInfo2.StylePriority.UseForeColor = false;
            this.pageInfo2.StylePriority.UseTextAlignment = false;
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.pageInfo2.TextFormatString = "{0:dddd, MMMM d, yyyy hh:mm tt}";
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.LineWidth = 2F;
            this.line1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 102.9273F);
            this.line1.Name = "line1";
            this.line1.SizeF = new System.Drawing.SizeF(705.9999F, 8.333344F);
            this.line1.StylePriority.UseForeColor = false;
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
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo1.SizeF = new System.Drawing.SizeF(100F, 17.8985F);
            this.pageInfo1.StylePriority.UseTextAlignment = false;
            this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Provider
            // 
            this.Provider.Description = "Provider";
            this.Provider.MultiValue = true;
            this.Provider.Name = "Provider";
            this.Provider.SelectAllValues = true;
            dynamicListLookUpSettings1.DataMember = "Query";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "facility_name";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings1.ValueMember = "provider_id";
            this.Provider.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Afs_Connection";
            this.sqlDataSource2.ConnectionOptions.CloseConnection = false;
            this.sqlDataSource2.ConnectionOptions.CommandTimeout = 86400;
            this.sqlDataSource2.ConnectionOptions.DbCommandTimeout = 86400;
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "Query";
            queryParameter1.Name = "provider";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("JOIN(?Provider)", typeof(string));
            customSqlQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
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
            this.table5.SizeF = new System.Drawing.SizeF(706.0001F, 18F);
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
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
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
            // tableCell25
            // 
            this.tableCell25.Multiline = true;
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.StylePriority.UseTextAlignment = false;
            this.tableCell25.Text = "Provider";
            this.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell25.Weight = 2.8062718159104465D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Balance";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell1.Weight = 1.5200779117975187D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Last Amount Paid";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.Weight = 1.3032435461111846D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Last Payment";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell3.Weight = 1.7892516524538271D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4});
            this.ReportFooter.HeightF = 23F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(196.8768F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(98.94427F, 23F);
            this.xrLabel5.Text = "Total:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([grandTotalBalance])")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(295.821F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(122.958F, 23F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel4.Summary = xrSummary1;
            this.xrLabel4.Text = "xrLabel3";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel4.TextFormatString = "{0:N2}";
            // 
            // ProviderBalancesReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource2;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margins = new System.Drawing.Printing.Margins(77, 67, 111, 18);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Provider});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter Provider;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRLine line1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    }
}
