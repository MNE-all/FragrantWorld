namespace FragrantWorld.Windows
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            flowLayoutPanel = new FlowLayoutPanel();
            panelControls = new Panel();
            labelResultCount = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxNameFind = new TextBox();
            comboBoxDisountFilter = new ComboBox();
            label1 = new Label();
            panelUser = new Panel();
            buttonOrders = new Button();
            buttonCart = new Button();
            labelSignIn = new Label();
            labelFullName = new Label();
            labelEnterAs = new Label();
            panel1 = new Panel();
            panelControls.SuspendLayout();
            panelUser.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(834, 719);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.Resize += flowLayoutPanel_Resize;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(labelResultCount);
            panelControls.Controls.Add(label3);
            panelControls.Controls.Add(label2);
            panelControls.Controls.Add(textBoxNameFind);
            panelControls.Controls.Add(comboBoxDisountFilter);
            panelControls.Controls.Add(label1);
            panelControls.Controls.Add(panelUser);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(834, 62);
            panelControls.TabIndex = 1;
            // 
            // labelResultCount
            // 
            labelResultCount.AutoSize = true;
            labelResultCount.Location = new Point(408, 27);
            labelResultCount.Name = "labelResultCount";
            labelResultCount.Size = new Size(43, 15);
            labelResultCount.TabIndex = 6;
            labelResultCount.Text = "0 из 50";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 6);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Кол-во результатов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 4;
            label2.Text = "Поиск по наименованию:";
            // 
            // textBoxNameFind
            // 
            textBoxNameFind.Location = new Point(12, 24);
            textBoxNameFind.Name = "textBoxNameFind";
            textBoxNameFind.Size = new Size(196, 23);
            textBoxNameFind.TabIndex = 3;
            textBoxNameFind.TextChanged += textBoxNameFind_TextChanged;
            // 
            // comboBoxDisountFilter
            // 
            comboBoxDisountFilter.FormattingEnabled = true;
            comboBoxDisountFilter.Location = new Point(226, 24);
            comboBoxDisountFilter.Name = "comboBoxDisountFilter";
            comboBoxDisountFilter.Size = new Size(121, 23);
            comboBoxDisountFilter.TabIndex = 2;
            comboBoxDisountFilter.SelectedIndexChanged += comboBoxDisountFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 6);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Размер скидки:";
            // 
            // panelUser
            // 
            panelUser.Controls.Add(buttonOrders);
            panelUser.Controls.Add(buttonCart);
            panelUser.Controls.Add(labelSignIn);
            panelUser.Controls.Add(labelFullName);
            panelUser.Controls.Add(labelEnterAs);
            panelUser.Dock = DockStyle.Right;
            panelUser.Location = new Point(494, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(340, 62);
            panelUser.TabIndex = 0;
            // 
            // buttonOrders
            // 
            buttonOrders.Location = new Point(172, 12);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(75, 23);
            buttonOrders.TabIndex = 4;
            buttonOrders.Text = "Заказы";
            buttonOrders.UseVisualStyleBackColor = true;
            buttonOrders.Visible = false;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // buttonCart
            // 
            buttonCart.Location = new Point(253, 34);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(75, 23);
            buttonCart.TabIndex = 3;
            buttonCart.Text = "Корзина";
            buttonCart.UseVisualStyleBackColor = true;
            buttonCart.Visible = false;
            buttonCart.Click += buttonCart_Click;
            // 
            // labelSignIn
            // 
            labelSignIn.AutoSize = true;
            labelSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSignIn.ForeColor = SystemColors.HotTrack;
            labelSignIn.Location = new Point(269, 13);
            labelSignIn.Name = "labelSignIn";
            labelSignIn.Size = new Size(43, 15);
            labelSignIn.TabIndex = 2;
            labelSignIn.Text = "Войти";
            labelSignIn.Click += labelSignIn_Click;
            labelSignIn.MouseEnter += labelSignIn_MouseEnter;
            labelSignIn.MouseLeave += labelSignIn_MouseLeave;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(5, 42);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(139, 15);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Фамилия Имя Отчество";
            // 
            // labelEnterAs
            // 
            labelEnterAs.AutoSize = true;
            labelEnterAs.Location = new Point(5, 16);
            labelEnterAs.Name = "labelEnterAs";
            labelEnterAs.Size = new Size(88, 15);
            labelEnterAs.TabIndex = 0;
            labelEnterAs.Text = "Вы вошли как:";
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 719);
            panel1.TabIndex = 2;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 781);
            Controls.Add(panel1);
            Controls.Add(panelControls);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(850, 820);
            Name = "ProductForm";
            Text = "Список товаров";
            WindowState = FormWindowState.Maximized;
            FormClosing += ProductForm_FormClosing;
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Panel panelControls;
        private Panel panel1;
        private Panel panelUser;
        private Label labelSignIn;
        private Label labelFullName;
        private Label labelEnterAs;
        private ComboBox comboBoxDisountFilter;
        private Label label1;
        private Button buttonCart;
        private Label label2;
        private TextBox textBoxNameFind;
        private Label labelResultCount;
        private Label label3;
        private Button buttonOrders;
    }
}