namespace FragrantWorld.Windows
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            label1 = new Label();
            captcha = new Captcha();
            buttonEnter = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonRegister = new Button();
            groupBoxAuth = new GroupBox();
            panel1 = new Panel();
            buttonGuestEnter = new Button();
            buttonRefreshCaptcha = new Button();
            label3 = new Label();
            textBoxCaptcha = new TextBox();
            groupBoxCapthca = new GroupBox();
            flowLayoutPanel = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            groupBoxAuth.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxCapthca.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 33);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Логин:";
            // 
            // captcha
            // 
            captcha.Location = new Point(16, 63);
            captcha.Name = "captcha";
            captcha.Size = new Size(314, 85);
            captcha.TabIndex = 2;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(239, 15);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(99, 23);
            buttonEnter.TabIndex = 3;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(90, 30);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(193, 23);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(90, 59);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(193, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 62);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Пароль:";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(12, 15);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(91, 23);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Регистрация";
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // groupBoxAuth
            // 
            groupBoxAuth.Controls.Add(label1);
            groupBoxAuth.Controls.Add(textBoxPassword);
            groupBoxAuth.Controls.Add(label2);
            groupBoxAuth.Controls.Add(textBoxLogin);
            groupBoxAuth.Location = new Point(8, 8);
            groupBoxAuth.Name = "groupBoxAuth";
            groupBoxAuth.Size = new Size(349, 106);
            groupBoxAuth.TabIndex = 8;
            groupBoxAuth.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonGuestEnter);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 68);
            panel1.TabIndex = 9;
            // 
            // buttonGuestEnter
            // 
            buttonGuestEnter.Location = new Point(239, 24);
            buttonGuestEnter.Name = "buttonGuestEnter";
            buttonGuestEnter.Size = new Size(113, 23);
            buttonGuestEnter.TabIndex = 0;
            buttonGuestEnter.Text = "Войти как гость";
            buttonGuestEnter.UseVisualStyleBackColor = true;
            buttonGuestEnter.Click += buttonGuestEnter_Click;
            // 
            // buttonRefreshCaptcha
            // 
            buttonRefreshCaptcha.Location = new Point(208, 22);
            buttonRefreshCaptcha.Name = "buttonRefreshCaptcha";
            buttonRefreshCaptcha.Size = new Size(122, 25);
            buttonRefreshCaptcha.TabIndex = 10;
            buttonRefreshCaptcha.Text = "Ни хрена не видно";
            buttonRefreshCaptcha.UseVisualStyleBackColor = true;
            buttonRefreshCaptcha.Click += buttonRefreshCaptcha_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 27);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 11;
            label3.Text = "Код с изображения:";
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.Location = new Point(138, 22);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(64, 23);
            textBoxCaptcha.TabIndex = 12;
            textBoxCaptcha.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxCapthca
            // 
            groupBoxCapthca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBoxCapthca.Controls.Add(captcha);
            groupBoxCapthca.Controls.Add(textBoxCaptcha);
            groupBoxCapthca.Controls.Add(buttonRefreshCaptcha);
            groupBoxCapthca.Controls.Add(label3);
            groupBoxCapthca.Location = new Point(8, 120);
            groupBoxCapthca.Name = "groupBoxCapthca";
            groupBoxCapthca.Size = new Size(349, 154);
            groupBoxCapthca.TabIndex = 13;
            groupBoxCapthca.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(groupBoxAuth);
            flowLayoutPanel.Controls.Add(groupBoxCapthca);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 68);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(5);
            flowLayoutPanel.Size = new Size(364, 299);
            flowLayoutPanel.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonEnter);
            groupBox2.Controls.Add(buttonRegister);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 367);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 44);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 411);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosed += AuthForm_FormClosed;
            groupBoxAuth.ResumeLayout(false);
            groupBoxAuth.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxCapthca.ResumeLayout(false);
            groupBoxCapthca.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Captcha captcha;
        private Button buttonEnter;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonRegister;
        private GroupBox groupBoxAuth;
        private Panel panel1;
        private Button buttonRefreshCaptcha;
        private Label label3;
        private TextBox textBoxCaptcha;
        private GroupBox groupBoxCapthca;
        private FlowLayoutPanel flowLayoutPanel;
        private GroupBox groupBox2;
        private Button buttonGuestEnter;
    }
}