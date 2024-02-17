using FragrantWorld.Context;
namespace FragrantWorld.Windows
{
    public partial class AuthForm : Form
    {
        public int enterCounter = 0;
        public AuthForm()
        {
            InitializeComponent();
            this.Height -= this.groupBoxCapthca.Height;

        }

        private void buttonRefreshCaptcha_Click(object sender, EventArgs e)
        {
            captcha.RefreshValue();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            enterCounter++;
            if (enterCounter == 2)
            {
                buttonEnter.Enabled = false;

                this.Height += this.groupBoxCapthca.Height;
            }

            using (var db = new FragrantWorldContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text);
                if (user != null)
                {
                    if (user.Password == textBoxPassword.Text)
                    {
                        var productForm = new ProductForm(user);
                        productForm.Show(this);
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка авторизации!");
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует!", "Ошибка авторизации!");
                }
            }
        }

        private void buttonGuestEnter_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm();
            productForm.Show(this);
            Hide();
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxCaptcha_TextChanged(object sender, EventArgs e)
        {
            buttonEnter.Enabled = false;
            if (int.TryParse(textBoxCaptcha.Text, out var answer))
            {
                if (captcha.ValidateValue(answer))
                {
                    buttonEnter.Enabled = true;
                }
            }
        }
    }
}
