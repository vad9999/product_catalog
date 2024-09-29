namespace product_catalog
{
    partial class AddForm
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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            SpecificationBox = new TextBox();
            SpecificationLabel = new Label();
            groupBox3 = new GroupBox();
            QuantityBox = new TextBox();
            PriceBox = new TextBox();
            FabricatorBox = new TextBox();
            NameBox = new TextBox();
            QuantityLabel = new Label();
            PriceLabel = new Label();
            FabricatorLabel = new Label();
            NameLabel = new Label();
            AddImgButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            AddButton = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(SpecificationBox);
            groupBox4.Controls.Add(SpecificationLabel);
            groupBox4.Location = new Point(370, 11);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(400, 159);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // SpecificationBox
            // 
            SpecificationBox.Location = new Point(77, 16);
            SpecificationBox.Name = "SpecificationBox";
            SpecificationBox.Size = new Size(317, 23);
            SpecificationBox.TabIndex = 8;
            // 
            // SpecificationLabel
            // 
            SpecificationLabel.AutoSize = true;
            SpecificationLabel.Location = new Point(6, 19);
            SpecificationLabel.Name = "SpecificationLabel";
            SpecificationLabel.Size = new Size(65, 15);
            SpecificationLabel.TabIndex = 4;
            SpecificationLabel.Text = "Описание:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(QuantityBox);
            groupBox3.Controls.Add(PriceBox);
            groupBox3.Controls.Add(FabricatorBox);
            groupBox3.Controls.Add(NameBox);
            groupBox3.Controls.Add(QuantityLabel);
            groupBox3.Controls.Add(PriceLabel);
            groupBox3.Controls.Add(FabricatorLabel);
            groupBox3.Controls.Add(NameLabel);
            groupBox3.Location = new Point(6, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(358, 159);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(87, 125);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(265, 23);
            QuantityBox.TabIndex = 7;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(50, 88);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(302, 23);
            PriceBox.TabIndex = 6;
            // 
            // FabricatorBox
            // 
            FabricatorBox.Location = new Point(107, 52);
            FabricatorBox.Name = "FabricatorBox";
            FabricatorBox.Size = new Size(245, 23);
            FabricatorBox.TabIndex = 5;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(74, 16);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(278, 23);
            NameBox.TabIndex = 4;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(6, 128);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(75, 15);
            QuantityLabel.TabIndex = 3;
            QuantityLabel.Text = "Количество:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(6, 91);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(38, 15);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "Цена:";
            // 
            // FabricatorLabel
            // 
            FabricatorLabel.AutoSize = true;
            FabricatorLabel.Location = new Point(6, 55);
            FabricatorLabel.Name = "FabricatorLabel";
            FabricatorLabel.Size = new Size(95, 15);
            FabricatorLabel.TabIndex = 1;
            FabricatorLabel.Text = "Производитель:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 19);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(62, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Название:";
            // 
            // AddImgButton
            // 
            AddImgButton.Location = new Point(12, 194);
            AddImgButton.Name = "AddImgButton";
            AddImgButton.Size = new Size(157, 55);
            AddImgButton.TabIndex = 0;
            AddImgButton.Text = "Добавить фотографию";
            AddImgButton.UseVisualStyleBackColor = true;
            AddImgButton.Click += AddImgButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(635, 194);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(147, 55);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 260);
            Controls.Add(AddImgButton);
            Controls.Add(AddButton);
            Controls.Add(groupBox1);
            Name = "AddForm";
            Text = "AddForm";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label NameLabel;
        private OpenFileDialog openFileDialog1;
        private Label SpecificationLabel;
        private Label QuantityLabel;
        private Label PriceLabel;
        private Label FabricatorLabel;
        private TextBox SpecificationBox;
        private TextBox QuantityBox;
        private TextBox PriceBox;
        private TextBox FabricatorBox;
        private TextBox NameBox;
        private Button AddButton;
        private Button AddImgButton;
    }
}