namespace FragrantWorld.Windows.Forms
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            panelControls = new Panel();
            panelUser = new Panel();
            labelFullName = new Label();
            labelEnterAs = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            buttonMakeOrder = new Button();
            comboBoxPickUpPoint = new ComboBox();
            labelPickUpPoint = new Label();
            panelControls.SuspendLayout();
            panelUser.SuspendLayout();
            SuspendLayout();
            // 
            // panelControls
            // 
            panelControls.Controls.Add(labelPickUpPoint);
            panelControls.Controls.Add(comboBoxPickUpPoint);
            panelControls.Controls.Add(buttonMakeOrder);
            panelControls.Controls.Add(panelUser);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(800, 62);
            panelControls.TabIndex = 2;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(labelFullName);
            panelUser.Controls.Add(labelEnterAs);
            panelUser.Dock = DockStyle.Left;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(326, 62);
            panelUser.TabIndex = 0;
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
            // flowLayoutPanel
            // 
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 62);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(800, 388);
            flowLayoutPanel.TabIndex = 3;
            // 
            // buttonMakeOrder
            // 
            buttonMakeOrder.Dock = DockStyle.Right;
            buttonMakeOrder.Location = new Point(644, 0);
            buttonMakeOrder.Name = "buttonMakeOrder";
            buttonMakeOrder.Size = new Size(156, 62);
            buttonMakeOrder.TabIndex = 1;
            buttonMakeOrder.Text = "Оформить заказ";
            buttonMakeOrder.UseVisualStyleBackColor = true;
            // 
            // comboBoxPickUpPoint
            // 
            comboBoxPickUpPoint.FormattingEnabled = true;
            comboBoxPickUpPoint.Location = new Point(425, 21);
            comboBoxPickUpPoint.Name = "comboBoxPickUpPoint";
            comboBoxPickUpPoint.Size = new Size(213, 23);
            comboBoxPickUpPoint.TabIndex = 2;
            // 
            // labelPickUpPoint
            // 
            labelPickUpPoint.AutoSize = true;
            labelPickUpPoint.Location = new Point(332, 24);
            labelPickUpPoint.Name = "labelPickUpPoint";
            labelPickUpPoint.Size = new Size(87, 15);
            labelPickUpPoint.TabIndex = 3;
            labelPickUpPoint.Text = "Пункт выдачи:";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panelControls);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartForm";
            Text = "Корзина";
            FormClosing += CartForm_FormClosing;
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControls;
        private Panel panelUser;
        private Label labelFullName;
        private Label labelEnterAs;
        private FlowLayoutPanel flowLayoutPanel;
        private Label labelPickUpPoint;
        private ComboBox comboBoxPickUpPoint;
        private Button buttonMakeOrder;
    }
}