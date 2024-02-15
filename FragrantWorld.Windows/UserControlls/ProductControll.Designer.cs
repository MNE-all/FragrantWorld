namespace FragrantWorld.Windows
{
    partial class ProductControll
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
            panel1 = new Panel();
            pictureBox = new PictureBox();
            panel2 = new Panel();
            labelDiscount = new Label();
            panel3 = new Panel();
            labelPrice = new Label();
            labelManufacturer = new Label();
            labelDescription = new Label();
            labelName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(119, 149);
            panel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Properties.Resources.picture;
            pictureBox.Location = new Point(10, 10);
            pictureBox.Margin = new Padding(30);
            pictureBox.Name = "pictureBox";
            pictureBox.Padding = new Padding(10);
            pictureBox.Size = new Size(99, 129);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelDiscount);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(358, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 149);
            panel2.TabIndex = 1;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(3, 66);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(88, 15);
            labelDiscount.TabIndex = 0;
            labelDiscount.Text = "Размер скидки";
            labelDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelPrice);
            panel3.Controls.Add(labelManufacturer);
            panel3.Controls.Add(labelDescription);
            panel3.Controls.Add(labelName);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(119, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 149);
            panel3.TabIndex = 2;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(22, 103);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(38, 15);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Цена:";
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.Location = new Point(22, 78);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(95, 15);
            labelManufacturer.TabIndex = 2;
            labelManufacturer.Text = "Производитель:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(22, 54);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(102, 15);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Описание товара";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(22, 29);
            labelName.Name = "labelName";
            labelName.Size = new Size(136, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Наименование товара";
            // 
            // ProductControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductControll";
            Size = new Size(452, 149);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox;
        private Panel panel2;
        private Label labelDiscount;
        private Panel panel3;
        private Label labelPrice;
        private Label labelManufacturer;
        private Label labelDescription;
        private Label labelName;
    }
}
