namespace FragrantWorld.Windows.UserControlls
{
    partial class OrderUpdateControl
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
            labelDiscount = new Label();
            panel1 = new Panel();
            pictureBox = new PictureBox();
            panel2 = new Panel();
            buttonMinus = new Button();
            buttonPlus = new Button();
            labelAmount = new Label();
            labelTotalPrice = new Label();
            label1 = new Label();
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
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(444, 125);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(88, 15);
            labelDiscount.TabIndex = 0;
            labelDiscount.Text = "Размер скидки";
            labelDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(119, 150);
            panel1.TabIndex = 6;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Properties.Resources.picture;
            pictureBox.Location = new Point(10, 10);
            pictureBox.Margin = new Padding(30);
            pictureBox.Name = "pictureBox";
            pictureBox.Padding = new Padding(10);
            pictureBox.Size = new Size(99, 130);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonMinus);
            panel2.Controls.Add(buttonPlus);
            panel2.Controls.Add(labelAmount);
            panel2.Controls.Add(labelTotalPrice);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(538, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 150);
            panel2.TabIndex = 7;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(118, 81);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 23);
            buttonMinus.TabIndex = 6;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(118, 37);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 23);
            buttonPlus.TabIndex = 5;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(135, 63);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(13, 15);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "0";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(186, 63);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(48, 15);
            labelTotalPrice.TabIndex = 3;
            labelTotalPrice.Text = "Сумма:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Количество:";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelPrice);
            panel3.Controls.Add(labelManufacturer);
            panel3.Controls.Add(labelDescription);
            panel3.Controls.Add(labelDiscount);
            panel3.Controls.Add(labelName);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 150);
            panel3.TabIndex = 8;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(142, 103);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(38, 15);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Цена:";
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.Location = new Point(142, 79);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(95, 15);
            labelManufacturer.TabIndex = 2;
            labelManufacturer.Text = "Производитель:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(142, 55);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(102, 15);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Описание товара";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(142, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(136, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Наименование товара";
            // 
            // OrderUpdateControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "OrderUpdateControl";
            Size = new Size(850, 150);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelDiscount;
        private Panel panel1;
        private PictureBox pictureBox;
        private Panel panel2;
        private Button buttonMinus;
        private Button buttonPlus;
        private Label labelAmount;
        private Label labelTotalPrice;
        private Label label1;
        private Panel panel3;
        private Label labelPrice;
        private Label labelManufacturer;
        private Label labelDescription;
        private Label labelName;
    }
}
