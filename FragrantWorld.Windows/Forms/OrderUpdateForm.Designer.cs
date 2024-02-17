namespace FragrantWorld.Windows.Forms
{
    partial class OrderUpdateForm
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
            flowLayoutPanel = new FlowLayoutPanel();
            panelControls = new Panel();
            labelPickUpPoint = new Label();
            comboBoxPickUpPoint = new ComboBox();
            panelUser = new Panel();
            labelFullName = new Label();
            labelEnterAs = new Label();
            statusStrip = new StatusStrip();
            toolStripStatusLabelTotalSum = new ToolStripStatusLabel();
            panelControls.SuspendLayout();
            panelUser.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 62);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(800, 366);
            flowLayoutPanel.TabIndex = 6;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(labelPickUpPoint);
            panelControls.Controls.Add(comboBoxPickUpPoint);
            panelControls.Controls.Add(panelUser);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(800, 62);
            panelControls.TabIndex = 5;
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
            // comboBoxPickUpPoint
            // 
            comboBoxPickUpPoint.FormattingEnabled = true;
            comboBoxPickUpPoint.Location = new Point(425, 21);
            comboBoxPickUpPoint.Name = "comboBoxPickUpPoint";
            comboBoxPickUpPoint.Size = new Size(213, 23);
            comboBoxPickUpPoint.TabIndex = 2;
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
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTotalSum });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 7;
            statusStrip.Text = "Строка состояния";
            // 
            // toolStripStatusLabelTotalSum
            // 
            toolStripStatusLabelTotalSum.Name = "toolStripStatusLabelTotalSum";
            toolStripStatusLabelTotalSum.Size = new Size(78, 17);
            toolStripStatusLabelTotalSum.Text = "Итого: 0 руб.";
            // 
            // OrderUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panelControls);
            Controls.Add(statusStrip);
            Name = "OrderUpdateForm";
            Text = "OrderUpdateForm";
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Panel panelControls;
        private Label labelPickUpPoint;
        private ComboBox comboBoxPickUpPoint;
        private Panel panelUser;
        private Label labelFullName;
        private Label labelEnterAs;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelTotalSum;
    }
}