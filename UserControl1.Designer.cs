namespace product_catalog
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            price = new Label();
            quantity = new Label();
            fabricator = new Label();
            name = new Label();
            groupBox4 = new GroupBox();
            specification = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(price);
            groupBox3.Controls.Add(quantity);
            groupBox3.Controls.Add(fabricator);
            groupBox3.Controls.Add(name);
            groupBox3.Location = new Point(174, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(329, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(6, 65);
            price.Name = "price";
            price.Size = new Size(41, 15);
            price.TabIndex = 2;
            price.Text = "Цена: ";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Location = new Point(6, 92);
            quantity.Name = "quantity";
            quantity.Size = new Size(78, 15);
            quantity.TabIndex = 0;
            quantity.Text = "Количество: ";
            // 
            // fabricator
            // 
            fabricator.AutoSize = true;
            fabricator.Location = new Point(6, 39);
            fabricator.Name = "fabricator";
            fabricator.Size = new Size(98, 15);
            fabricator.TabIndex = 1;
            fabricator.Text = "Производитель: ";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(6, 13);
            name.Name = "name";
            name.Size = new Size(65, 15);
            name.TabIndex = 0;
            name.Text = "Название: ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(specification);
            groupBox4.Location = new Point(509, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(238, 125);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // specification
            // 
            specification.AutoSize = true;
            specification.Location = new Point(6, 13);
            specification.Name = "specification";
            specification.Size = new Size(68, 15);
            specification.TabIndex = 3;
            specification.Text = "Описание: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(6, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(162, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UserControl1";
            Size = new Size(750, 150);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label fabricator;
        private Label name;
        private PictureBox pictureBox1;
        private Label price;
        private Label quantity;
        private Label specification;
    }
}
