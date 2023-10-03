namespace WinFormsApp
{
    partial class CreateProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxName = new ReaLTaiizor.Controls.DungeonTextBox();
            txtBoxDescription = new ReaLTaiizor.Controls.DungeonRichTextBox();
            labelName = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelDescription = new ReaLTaiizor.Controls.DungeonLabel();
            labelQuantity = new ReaLTaiizor.Controls.DungeonLabel();
            labelPrice = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPrice = new ReaLTaiizor.Controls.DungeonTextBox();
            txtBoxQuantity = new ReaLTaiizor.Controls.DungeonTextBox();
            comboBoxCategories = new ReaLTaiizor.Controls.DungeonComboBox();
            labelCategory = new ReaLTaiizor.Controls.DungeonLabel();
            buttonCreateProduct = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.Transparent;
            txtBoxName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxName.EdgeColor = Color.White;
            txtBoxName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.ForeColor = Color.DimGray;
            txtBoxName.Location = new Point(143, 78);
            txtBoxName.MaxLength = 32767;
            txtBoxName.Multiline = false;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.ReadOnly = false;
            txtBoxName.Size = new Size(296, 28);
            txtBoxName.TabIndex = 0;
            txtBoxName.TextAlignment = HorizontalAlignment.Left;
            txtBoxName.UseSystemPasswordChar = false;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.AutoWordSelection = false;
            txtBoxDescription.BackColor = Color.Transparent;
            txtBoxDescription.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDescription.EdgeColor = Color.White;
            txtBoxDescription.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.ForeColor = Color.FromArgb(76, 76, 76);
            txtBoxDescription.Location = new Point(143, 117);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.ReadOnly = false;
            txtBoxDescription.Size = new Size(296, 60);
            txtBoxDescription.TabIndex = 1;
            txtBoxDescription.TextBackColor = Color.White;
            txtBoxDescription.WordWrap = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.FromArgb(76, 76, 77);
            labelName.Location = new Point(55, 78);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Nombre:";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(143, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(220, 32);
            dungeonHeaderLabel1.TabIndex = 3;
            dungeonHeaderLabel1.Text = "Agregar Producto";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.BackColor = Color.Transparent;
            labelDescription.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.ForeColor = Color.FromArgb(76, 76, 77);
            labelDescription.Location = new Point(29, 117);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(108, 25);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Descripción:";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.BackColor = Color.Transparent;
            labelQuantity.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantity.ForeColor = Color.FromArgb(76, 76, 77);
            labelQuantity.Location = new Point(50, 244);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(87, 25);
            labelQuantity.TabIndex = 5;
            labelQuantity.Text = "Cantidad:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.ForeColor = Color.FromArgb(76, 76, 77);
            labelPrice.Location = new Point(73, 199);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(64, 25);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Precio:";
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.BackColor = Color.Transparent;
            txtBoxPrice.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPrice.EdgeColor = Color.White;
            txtBoxPrice.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPrice.ForeColor = Color.DimGray;
            txtBoxPrice.Location = new Point(143, 199);
            txtBoxPrice.MaxLength = 32767;
            txtBoxPrice.Multiline = false;
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.ReadOnly = false;
            txtBoxPrice.Size = new Size(296, 28);
            txtBoxPrice.TabIndex = 7;
            txtBoxPrice.TextAlignment = HorizontalAlignment.Left;
            txtBoxPrice.UseSystemPasswordChar = false;
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.BackColor = Color.Transparent;
            txtBoxQuantity.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxQuantity.EdgeColor = Color.White;
            txtBoxQuantity.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxQuantity.ForeColor = Color.DimGray;
            txtBoxQuantity.Location = new Point(143, 244);
            txtBoxQuantity.MaxLength = 32767;
            txtBoxQuantity.Multiline = false;
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.ReadOnly = false;
            txtBoxQuantity.Size = new Size(296, 28);
            txtBoxQuantity.TabIndex = 8;
            txtBoxQuantity.TextAlignment = HorizontalAlignment.Left;
            txtBoxQuantity.UseSystemPasswordChar = false;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.BackColor = Color.FromArgb(246, 246, 246);
            comboBoxCategories.ColorA = Color.FromArgb(246, 132, 85);
            comboBoxCategories.ColorB = Color.FromArgb(231, 108, 57);
            comboBoxCategories.ColorC = Color.FromArgb(242, 241, 240);
            comboBoxCategories.ColorD = Color.FromArgb(253, 252, 252);
            comboBoxCategories.ColorE = Color.FromArgb(239, 237, 236);
            comboBoxCategories.ColorF = Color.FromArgb(180, 180, 180);
            comboBoxCategories.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxCategories.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxCategories.ColorI = Color.FromArgb(250, 249, 249);
            comboBoxCategories.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxCategories.DropDownHeight = 100;
            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategories.ForeColor = Color.FromArgb(76, 76, 97);
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.HoverSelectionColor = Color.Empty;
            comboBoxCategories.IntegralHeight = false;
            comboBoxCategories.ItemHeight = 20;
            comboBoxCategories.Location = new Point(143, 288);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(296, 26);
            comboBoxCategories.StartIndex = 0;
            comboBoxCategories.TabIndex = 9;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.Transparent;
            labelCategory.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategory.ForeColor = Color.FromArgb(76, 76, 77);
            labelCategory.Location = new Point(72, 289);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(65, 25);
            labelCategory.TabIndex = 10;
            labelCategory.Text = "Rubro:";
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
            buttonCreateProduct.Location = new Point(234, 347);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateProduct.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateProduct.Size = new Size(120, 40);
            buttonCreateProduct.TabIndex = 11;
            buttonCreateProduct.Text = "Agregar";
            buttonCreateProduct.TextAlignment = StringAlignment.Center;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreateProduct);
            Controls.Add(labelCategory);
            Controls.Add(comboBoxCategories);
            Controls.Add(txtBoxQuantity);
            Controls.Add(txtBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelQuantity);
            Controls.Add(labelDescription);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelName);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtBoxName);
            Name = "CreateProduct";
            Text = "CreateProduct";
            Load += CreateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox txtBoxName;
        private ReaLTaiizor.Controls.DungeonRichTextBox txtBoxDescription;
        private ReaLTaiizor.Controls.DungeonLabel labelName;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelDescription;
        private ReaLTaiizor.Controls.DungeonLabel labelQuantity;
        private ReaLTaiizor.Controls.DungeonLabel labelPrice;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPrice;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxQuantity;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxCategories;
        private ReaLTaiizor.Controls.DungeonLabel labelCategory;
        private ReaLTaiizor.Controls.Button buttonCreateProduct;
    }
}