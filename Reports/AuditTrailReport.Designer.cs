namespace ServerSide.Reports
{
    partial class AuditTrailReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditTrailReport));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.label47 = new DevExpress.XtraReports.UI.XRLabel();
            this.line1 = new DevExpress.XtraReports.UI.XRLine();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Date = new DevExpress.XtraReports.Parameters.Parameter();
            this.startDate = new DevExpress.XtraReports.Parameters.RangeStartParameter();
            this.endDate = new DevExpress.XtraReports.Parameters.RangeEndParameter();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Users = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label10,
            this.label9,
            this.label8,
            this.label47,
            this.line1,
            this.label1,
            this.pageInfo2,
            this.pictureBox1});
            this.TopMargin.Name = "TopMargin";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.LocationFloat = new DevExpress.Utils.PointFloat(136.4736F, 74.66653F);
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
            // label9
            // 
            this.label9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?endDate")});
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.LocationFloat = new DevExpress.Utils.PointFloat(153.1722F, 74.66664F);
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
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.LocationFloat = new DevExpress.Utils.PointFloat(1.060963E-05F, 74.66647F);
            this.label8.Multiline = true;
            this.label8.Name = "label8";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.label8.SizeF = new System.Drawing.SizeF(57.26957F, 16.99999F);
            this.label8.StylePriority.UseFont = false;
            this.label8.StylePriority.UsePadding = false;
            this.label8.Text = "Period:";
            // 
            // label47
            // 
            this.label47.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?startDate")});
            this.label47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.LocationFloat = new DevExpress.Utils.PointFloat(57.26954F, 74.66653F);
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
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.LineWidth = 2F;
            this.line1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 91.66656F);
            this.line1.Name = "line1";
            this.line1.SizeF = new System.Drawing.SizeF(744.9999F, 8.333351F);
            this.line1.StylePriority.UseForeColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(1.060963E-05F, 44.66648F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(402.08F, 30F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "Audit Trail Report";
            // 
            // pageInfo2
            // 
            this.pageInfo2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInfo2.ForeColor = System.Drawing.Color.Black;
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(445.7646F, 74.66647F);
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
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(608.3024F, 0F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeF = new System.Drawing.SizeF(136.6976F, 74.66659F);
            this.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.pageInfo1});
            this.BottomMargin.HeightF = 27.89852F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 17.8985F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(927F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo1.SizeF = new System.Drawing.SizeF(100F, 27.89852F);
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
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex]+1")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(30.64667F, 23F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[action]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(345.7603F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(399.2396F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[officer]")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(167.4238F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(178.3364F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[timestamp]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(30.91698F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(136.5069F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "FrankiesHotel_Connection";
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
            customSqlQuery1.Sql = "select A.id,U.Username,A.description,A.timestamp from \r\n[FrankiesHotel].[dbo].[Au" +
    "ditTrail] A,\r\n[FrankiesHotel_UserDB].[dbo].[User] U\r\nwhere A.userId=U.Id and tim" +
    "estamp between @startDate and @endDate";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(0.2703031F, 0F);
            this.table5.Name = "table5";
            this.table5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5});
            this.table5.SizeF = new System.Drawing.SizeF(744.7296F, 18F);
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
            this.tableCell25.Text = "User";
            this.tableCell25.Weight = 1.0627024980500037D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Action";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell4.Weight = 2.3790605581226449D;
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
            this.startDate.ValueInfo = "2024-05-03";
            // 
            // endDate
            // 
            this.endDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Now()")});
            this.endDate.Name = "endDate";
            this.endDate.ValueInfo = "2024-05-03";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Afs_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "Query";
            queryParameter3.Name = "startDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?startDate", typeof(System.DateTime));
            queryParameter4.Name = "endDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?endDate", typeof(System.DateTime));
            queryParameter5.Name = "user";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("JOIN(?Users)", typeof(string));
            customSqlQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter3,
            queryParameter4,
            queryParameter5});
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // Users
            // 
            this.Users.Description = "Users";
            this.Users.MultiValue = true;
            this.Users.Name = "Users";
            this.Users.SelectAllValues = true;
            this.Users.Type = typeof(int);
            dynamicListLookUpSettings1.DataMember = "Query";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource3;
            dynamicListLookUpSettings1.DisplayMember = "name";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = "name";
            dynamicListLookUpSettings1.ValueMember = "id";
            this.Users.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "Afs_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "select id,CONCAT(firstname,\' \',lastname)as name from afs_userdb.user";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource3.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTMiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iaWQiIFR5cGU9IkludDMyIiAvPjxGaWVsZCBOYW1lPSJuYW1lIiBUeXBlPSJTdHJpbmciIC8+PC9Wa" +
    "WV3PjwvRGF0YVNldD4=";
            // 
            // AuditTrailReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2,
            this.sqlDataSource3});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource2;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(59, 46, 100, 28);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Date,
            this.Users});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.XtraReports.UI.XRLabel label47;
        private DevExpress.XtraReports.UI.XRLine line1;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.Parameters.Parameter Date;
        private DevExpress.XtraReports.Parameters.RangeStartParameter startDate;
        private DevExpress.XtraReports.Parameters.RangeEndParameter endDate;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.Parameters.Parameter Users;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
    }
}
