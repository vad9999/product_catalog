namespace product_catalog
{
    partial class MainForm
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
            Sort = new ComboBox();
            ProductFilt = new ComboBox();
            Search = new TextBox();
            FieldProducts = new FlowLayoutPanel();
            PrevButton = new Button();
            NextButton = new Button();
            AddButon = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // Sort
            // 
            Sort.FormattingEnabled = true;
            Sort.Location = new Point(12, 41);
            Sort.Name = "Sort";
            Sort.Size = new Size(774, 23);
            Sort.TabIndex = 0;
            Sort.SelectedIndexChanged += Sort_SelectedIndexChanged;
            // 
            // ProductFilt
            // 
            ProductFilt.FormattingEnabled = true;
            ProductFilt.Location = new Point(12, 12);
            ProductFilt.Name = "ProductFilt";
            ProductFilt.Size = new Size(774, 23);
            ProductFilt.TabIndex = 1;
            ProductFilt.SelectedIndexChanged += ProductFilt_SelectedIndexChanged;
            // 
            // Search
            // 
            Search.Location = new Point(12, 70);
            Search.Name = "Search";
            Search.Size = new Size(774, 23);
            Search.TabIndex = 2;
            Search.TextChanged += Search_TextChanged;
            // 
            // FieldProducts
            // 
            FieldProducts.AutoScroll = true;
            FieldProducts.Location = new Point(12, 99);
            FieldProducts.Name = "FieldProducts";
            FieldProducts.Size = new Size(774, 545);
            FieldProducts.TabIndex = 3;
            // 
            // PrevButton
            // 
            PrevButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            PrevButton.Location = new Point(12, 650);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new Size(97, 34);
            PrevButton.TabIndex = 4;
            PrevButton.Text = "<";
            PrevButton.UseVisualStyleBackColor = true;
            PrevButton.Click += PrevButton_Click;
            // 
            // NextButton
            // 
            NextButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            NextButton.Location = new Point(689, 649);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(97, 34);
            NextButton.TabIndex = 5;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // AddButon
            // 
            AddButon.Location = new Point(300, 649);
            AddButon.Name = "AddButon";
            AddButon.Size = new Size(97, 34);
            AddButon.TabIndex = 6;
            AddButon.Text = "Добавление";
            AddButon.UseVisualStyleBackColor = true;
            AddButon.Click += AddButon_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(403, 649);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(97, 34);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 697);
            Controls.Add(ExitButton);
            Controls.Add(AddButon);
            Controls.Add(NextButton);
            Controls.Add(PrevButton);
            Controls.Add(FieldProducts);
            Controls.Add(Search);
            Controls.Add(ProductFilt);
            Controls.Add(Sort);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Sort;
        private ComboBox ProductFilt;
        private TextBox Search;
        private FlowLayoutPanel FieldProducts;
        private Button PrevButton;
        private Button NextButton;
        private Button AddButon;
        private Button ExitButton;
    }
}