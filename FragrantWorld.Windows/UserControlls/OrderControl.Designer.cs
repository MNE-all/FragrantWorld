namespace FragrantWorld.Windows.UserControlls
{
    partial class OrderControl
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
            labelOrderNumber = new Label();
            label1 = new Label();
            panel2 = new Panel();
            labelTotalSum = new Label();
            label2 = new Label();
            panel3 = new Panel();
            listBoxProducts = new ListBox();
            listBoxAmount = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelOrderNumber);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 150);
            panel1.TabIndex = 0;
            // 
            // labelOrderNumber
            // 
            labelOrderNumber.AutoSize = true;
            labelOrderNumber.Location = new Point(91, 79);
            labelOrderNumber.Name = "labelOrderNumber";
            labelOrderNumber.Size = new Size(13, 15);
            labelOrderNumber.TabIndex = 1;
            labelOrderNumber.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер заказа:";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTotalSum);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(650, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 150);
            panel2.TabIndex = 1;
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Location = new Point(69, 79);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(72, 15);
            labelTotalSum.TabIndex = 1;
            labelTotalSum.Text = "9000.00 руб.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 47);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Сумма:";
            // 
            // panel3
            // 
            panel3.Controls.Add(listBoxProducts);
            panel3.Controls.Add(listBoxAmount);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 150);
            panel3.TabIndex = 2;
            // 
            // listBoxProducts
            // 
            listBoxProducts.Dock = DockStyle.Fill;
            listBoxProducts.Enabled = false;
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(0, 0);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(330, 150);
            listBoxProducts.TabIndex = 2;
            // 
            // listBoxAmount
            // 
            listBoxAmount.Dock = DockStyle.Right;
            listBoxAmount.Enabled = false;
            listBoxAmount.FormattingEnabled = true;
            listBoxAmount.ItemHeight = 15;
            listBoxAmount.Location = new Point(330, 0);
            listBoxAmount.Name = "listBoxAmount";
            listBoxAmount.Size = new Size(120, 150);
            listBoxAmount.TabIndex = 1;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderControl";
            Size = new Size(850, 150);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelOrderNumber;
        private Label label1;
        private Panel panel2;
        private Label labelTotalSum;
        private Label label2;
        private Panel panel3;
        private ListBox listBoxProducts;
        private ListBox listBoxAmount;
    }
}
