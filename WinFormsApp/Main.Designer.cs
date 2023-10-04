namespace WinFormsApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            hopeTabPage = new ReaLTaiizor.Controls.HopeTabPage();
            tabPageOrders = new TabPage();
            dataGridViewOrders = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelOrdersSearch = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxOrdersSearch = new ReaLTaiizor.Controls.DungeonTextBox();
            tabPageCategories = new TabPage();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            buttonCreateCategory = new ReaLTaiizor.Controls.Button();
            txtBoxCategoryName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelCategoryName = new ReaLTaiizor.Controls.DungeonLabel();
            dataGridViewCategories = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelSearchCategories = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxSearchCategories = new ReaLTaiizor.Controls.DungeonTextBox();
            tabPageProducts = new TabPage();
            buttonCreateProduct = new ReaLTaiizor.Controls.Button();
            dataGridViewProducts = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelProductsSearch = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxProductsSearch = new ReaLTaiizor.Controls.DungeonTextBox();
            tabPageSuppliers = new TabPage();
            tabPageBillingTransactions = new TabPage();
            tabPageInvoices = new TabPage();
            tabPageReports = new TabPage();
            tabPageClients = new TabPage();
            hopeTabPage.SuspendLayout();
            tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // hopeTabPage
            // 
            hopeTabPage.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTabPage.Controls.Add(tabPageOrders);
            hopeTabPage.Controls.Add(tabPageCategories);
            hopeTabPage.Controls.Add(tabPageProducts);
            hopeTabPage.Controls.Add(tabPageSuppliers);
            hopeTabPage.Controls.Add(tabPageBillingTransactions);
            hopeTabPage.Controls.Add(tabPageInvoices);
            hopeTabPage.Controls.Add(tabPageReports);
            hopeTabPage.Controls.Add(tabPageClients);
            hopeTabPage.Dock = DockStyle.Fill;
            hopeTabPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeTabPage.ForeColorA = Color.WhiteSmoke;
            hopeTabPage.ForeColorB = Color.Silver;
            hopeTabPage.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            hopeTabPage.ItemSize = new Size(120, 40);
            hopeTabPage.Location = new Point(0, 0);
            hopeTabPage.Name = "hopeTabPage";
            hopeTabPage.SelectedIndex = 0;
            hopeTabPage.Size = new Size(995, 575);
            hopeTabPage.SizeMode = TabSizeMode.Fixed;
            hopeTabPage.TabIndex = 0;
            hopeTabPage.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPageOrders
            // 
            tabPageOrders.Controls.Add(dataGridViewOrders);
            tabPageOrders.Controls.Add(labelOrdersSearch);
            tabPageOrders.Controls.Add(txtBoxOrdersSearch);
            tabPageOrders.Location = new Point(0, 40);
            tabPageOrders.Name = "tabPageOrders";
            tabPageOrders.Padding = new Padding(3);
            tabPageOrders.Size = new Size(995, 535);
            tabPageOrders.TabIndex = 0;
            tabPageOrders.Text = "Pedidos";
            tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewOrders.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewOrders.BorderStyle = BorderStyle.None;
            dataGridViewOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOrders.EnableHeadersVisualStyles = false;
            dataGridViewOrders.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewOrders.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewOrders.Location = new Point(6, 57);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOrders.RowTemplate.Height = 25;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(983, 472);
            dataGridViewOrders.TabIndex = 2;
            // 
            // labelOrdersSearch
            // 
            labelOrdersSearch.AutoSize = true;
            labelOrdersSearch.BackColor = Color.Transparent;
            labelOrdersSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrdersSearch.ForeColor = Color.FromArgb(76, 76, 77);
            labelOrdersSearch.Location = new Point(150, 23);
            labelOrdersSearch.Name = "labelOrdersSearch";
            labelOrdersSearch.Size = new Size(72, 25);
            labelOrdersSearch.TabIndex = 1;
            labelOrdersSearch.Text = "Buscar:";
            // 
            // txtBoxOrdersSearch
            // 
            txtBoxOrdersSearch.BackColor = Color.Transparent;
            txtBoxOrdersSearch.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxOrdersSearch.EdgeColor = Color.White;
            txtBoxOrdersSearch.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxOrdersSearch.ForeColor = Color.DimGray;
            txtBoxOrdersSearch.Location = new Point(228, 23);
            txtBoxOrdersSearch.MaxLength = 32767;
            txtBoxOrdersSearch.Multiline = false;
            txtBoxOrdersSearch.Name = "txtBoxOrdersSearch";
            txtBoxOrdersSearch.ReadOnly = false;
            txtBoxOrdersSearch.Size = new Size(589, 28);
            txtBoxOrdersSearch.TabIndex = 0;
            txtBoxOrdersSearch.TextAlignment = HorizontalAlignment.Left;
            txtBoxOrdersSearch.UseSystemPasswordChar = false;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(metroDivider1);
            tabPageCategories.Controls.Add(buttonCreateCategory);
            tabPageCategories.Controls.Add(txtBoxCategoryName);
            tabPageCategories.Controls.Add(labelCategoryName);
            tabPageCategories.Controls.Add(dataGridViewCategories);
            tabPageCategories.Controls.Add(labelSearchCategories);
            tabPageCategories.Controls.Add(txtBoxSearchCategories);
            tabPageCategories.Location = new Point(0, 40);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(995, 535);
            tabPageCategories.TabIndex = 1;
            tabPageCategories.Text = "Rubros";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // metroDivider1
            // 
            metroDivider1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(0, 476);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(995, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 9;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // buttonCreateCategory
            // 
            buttonCreateCategory.BackColor = Color.Transparent;
            buttonCreateCategory.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateCategory.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateCategory.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateCategory.Image = null;
            buttonCreateCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateCategory.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateCategory.Location = new Point(815, 495);
            buttonCreateCategory.Name = "buttonCreateCategory";
            buttonCreateCategory.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateCategory.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateCategory.Size = new Size(120, 28);
            buttonCreateCategory.TabIndex = 7;
            buttonCreateCategory.Text = "Agregar Rubro";
            buttonCreateCategory.TextAlignment = StringAlignment.Center;
            buttonCreateCategory.Click += buttonCreateCategory_Click;
            // 
            // txtBoxCategoryName
            // 
            txtBoxCategoryName.BackColor = Color.Transparent;
            txtBoxCategoryName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxCategoryName.EdgeColor = Color.White;
            txtBoxCategoryName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCategoryName.ForeColor = Color.DimGray;
            txtBoxCategoryName.Location = new Point(232, 495);
            txtBoxCategoryName.MaxLength = 32767;
            txtBoxCategoryName.Multiline = false;
            txtBoxCategoryName.Name = "txtBoxCategoryName";
            txtBoxCategoryName.ReadOnly = false;
            txtBoxCategoryName.Size = new Size(577, 28);
            txtBoxCategoryName.TabIndex = 5;
            txtBoxCategoryName.TextAlignment = HorizontalAlignment.Left;
            txtBoxCategoryName.UseSystemPasswordChar = false;
            // 
            // labelCategoryName
            // 
            labelCategoryName.AutoSize = true;
            labelCategoryName.BackColor = Color.Transparent;
            labelCategoryName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryName.ForeColor = Color.FromArgb(76, 76, 77);
            labelCategoryName.Location = new Point(58, 495);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(177, 25);
            labelCategoryName.TabIndex = 4;
            labelCategoryName.Text = "Nombre del Rubro: ";
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToResizeRows = false;
            dataGridViewCategories.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewCategories.BorderStyle = BorderStyle.None;
            dataGridViewCategories.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCategories.EnableHeadersVisualStyles = false;
            dataGridViewCategories.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCategories.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewCategories.Location = new Point(6, 63);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCategories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCategories.RowTemplate.Height = 25;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(983, 407);
            dataGridViewCategories.TabIndex = 3;
            // 
            // labelSearchCategories
            // 
            labelSearchCategories.AutoSize = true;
            labelSearchCategories.BackColor = Color.Transparent;
            labelSearchCategories.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchCategories.ForeColor = Color.FromArgb(76, 76, 77);
            labelSearchCategories.Location = new Point(163, 20);
            labelSearchCategories.Name = "labelSearchCategories";
            labelSearchCategories.Size = new Size(72, 25);
            labelSearchCategories.TabIndex = 2;
            labelSearchCategories.Text = "Buscar:";
            // 
            // txtBoxSearchCategories
            // 
            txtBoxSearchCategories.BackColor = Color.Transparent;
            txtBoxSearchCategories.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxSearchCategories.EdgeColor = Color.White;
            txtBoxSearchCategories.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSearchCategories.ForeColor = Color.DimGray;
            txtBoxSearchCategories.Location = new Point(241, 17);
            txtBoxSearchCategories.MaxLength = 32767;
            txtBoxSearchCategories.Multiline = false;
            txtBoxSearchCategories.Name = "txtBoxSearchCategories";
            txtBoxSearchCategories.ReadOnly = false;
            txtBoxSearchCategories.Size = new Size(589, 28);
            txtBoxSearchCategories.TabIndex = 1;
            txtBoxSearchCategories.TextAlignment = HorizontalAlignment.Left;
            txtBoxSearchCategories.UseSystemPasswordChar = false;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(buttonCreateProduct);
            tabPageProducts.Controls.Add(dataGridViewProducts);
            tabPageProducts.Controls.Add(labelProductsSearch);
            tabPageProducts.Controls.Add(txtBoxProductsSearch);
            tabPageProducts.Location = new Point(0, 40);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Size = new Size(995, 535);
            tabPageProducts.TabIndex = 2;
            tabPageProducts.Text = "Productos";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // buttonCreateProduct
            // 
            buttonCreateProduct.BackColor = Color.Transparent;
            buttonCreateProduct.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateProduct.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateProduct.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateProduct.Image = null;
            buttonCreateProduct.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateProduct.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateProduct.Location = new Point(12, 488);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateProduct.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateProduct.Size = new Size(151, 35);
            buttonCreateProduct.TabIndex = 9;
            buttonCreateProduct.Text = "Agregar Producto";
            buttonCreateProduct.TextAlignment = StringAlignment.Center;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewProducts.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewProducts.Location = new Point(9, 52);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(974, 430);
            dataGridViewProducts.TabIndex = 4;
            // 
            // labelProductsSearch
            // 
            labelProductsSearch.AutoSize = true;
            labelProductsSearch.BackColor = Color.Transparent;
            labelProductsSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductsSearch.ForeColor = Color.FromArgb(76, 76, 77);
            labelProductsSearch.Location = new Point(181, 14);
            labelProductsSearch.Name = "labelProductsSearch";
            labelProductsSearch.Size = new Size(72, 25);
            labelProductsSearch.TabIndex = 3;
            labelProductsSearch.Text = "Buscar:";
            // 
            // txtBoxProductsSearch
            // 
            txtBoxProductsSearch.BackColor = Color.Transparent;
            txtBoxProductsSearch.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxProductsSearch.EdgeColor = Color.White;
            txtBoxProductsSearch.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductsSearch.ForeColor = Color.DimGray;
            txtBoxProductsSearch.Location = new Point(259, 14);
            txtBoxProductsSearch.MaxLength = 32767;
            txtBoxProductsSearch.Multiline = false;
            txtBoxProductsSearch.Name = "txtBoxProductsSearch";
            txtBoxProductsSearch.ReadOnly = false;
            txtBoxProductsSearch.Size = new Size(589, 28);
            txtBoxProductsSearch.TabIndex = 2;
            txtBoxProductsSearch.TextAlignment = HorizontalAlignment.Left;
            txtBoxProductsSearch.UseSystemPasswordChar = false;
            // 
            // tabPageSuppliers
            // 
            tabPageSuppliers.Location = new Point(0, 40);
            tabPageSuppliers.Name = "tabPageSuppliers";
            tabPageSuppliers.Size = new Size(995, 535);
            tabPageSuppliers.TabIndex = 3;
            tabPageSuppliers.Text = "Proveedores";
            tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabPageBillingTransactions
            // 
            tabPageBillingTransactions.Location = new Point(0, 40);
            tabPageBillingTransactions.Name = "tabPageBillingTransactions";
            tabPageBillingTransactions.Size = new Size(995, 535);
            tabPageBillingTransactions.TabIndex = 4;
            tabPageBillingTransactions.Text = "Cobranzas";
            tabPageBillingTransactions.UseVisualStyleBackColor = true;
            // 
            // tabPageInvoices
            // 
            tabPageInvoices.Location = new Point(0, 40);
            tabPageInvoices.Name = "tabPageInvoices";
            tabPageInvoices.Size = new Size(995, 535);
            tabPageInvoices.TabIndex = 5;
            tabPageInvoices.Text = "Facturas";
            tabPageInvoices.UseVisualStyleBackColor = true;
            // 
            // tabPageReports
            // 
            tabPageReports.Location = new Point(0, 40);
            tabPageReports.Name = "tabPageReports";
            tabPageReports.Size = new Size(995, 535);
            tabPageReports.TabIndex = 6;
            tabPageReports.Text = "Informes";
            tabPageReports.UseVisualStyleBackColor = true;
            // 
            // tabPageClients
            // 
            tabPageClients.Location = new Point(0, 40);
            tabPageClients.Name = "tabPageClients";
            tabPageClients.Size = new Size(995, 535);
            tabPageClients.TabIndex = 7;
            tabPageClients.Text = "Clientes";
            tabPageClients.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 575);
            Controls.Add(hopeTabPage);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            hopeTabPage.ResumeLayout(false);
            tabPageOrders.ResumeLayout(false);
            tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPageCategories.ResumeLayout(false);
            tabPageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            tabPageProducts.ResumeLayout(false);
            tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage;
        private TabPage tabPageOrders;
        private TabPage tabPageCategories;
        private TabPage tabPageProducts;
        private TabPage tabPageSuppliers;
        private TabPage tabPageBillingTransactions;
        private TabPage tabPageInvoices;
        private TabPage tabPageReports;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewOrders;
        private ReaLTaiizor.Controls.DungeonLabel labelOrdersSearch;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxOrdersSearch;
        private ReaLTaiizor.Controls.DungeonLabel labelSearchCategories;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxSearchCategories;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewCategories;
        private ReaLTaiizor.Controls.Button buttonCreateCategory;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxCategoryName;
        private ReaLTaiizor.Controls.DungeonLabel labelCategoryName;
        private ReaLTaiizor.Controls.Button buttonCreateProduct;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewProducts;
        private ReaLTaiizor.Controls.DungeonLabel labelProductsSearch;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxProductsSearch;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private TabPage tabPageClients;
    }
}