namespace Rabota_3_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Chat chat = new Chat();
        private User user;

        private void Chat_RecieveMessage(object? sender, GetMessageEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                if( e.User == user.Login)
                    textBoxMain.Text = textBoxMain.Text + new string(' ', 27) + DateTime.Now.ToString() + 
                    "\r\n" + "��: " + e.Message + "\r\n\r\n";
                else
                    textBoxMain.Text = textBoxMain.Text + new string(' ', 27) + DateTime.Now.ToString() + 
                    "\r\n" + e.User + ": " + e.Message + "\r\n\r\n";
            }));
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "")
            {
                user = new User(textBoxLogin.Text);
                chat.RecieveMessages();
                chat.GetMessage += Chat_RecieveMessage;

                labelNotification.Visible = false;
                textBoxLogin.Visible = false;
                panelUnderlineLogin.Visible = false;
                buttonConnect.Visible = false;

                labelWelcome.Visible = true;
                labelWelcome.Text = "����� ����������, " + user.Login + "! �� � ����!";
                textBoxMain.Visible = true;
                textBoxMessage.Visible = true;
                panelUnderline.Visible = true;
                buttonSend.Visible = true;

                chat.SendMessage(user.Login + " � ����!", "�������������");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textBoxMessage.Text != "")
            {
                chat.SendMessage(textBoxMessage.Text, user.Login);
                textBoxMessage.Clear();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(user != null)
                chat.SendMessage(user.Login + " ����� �� ����!", "�������������");
            chat.CloseConnection();
        }
    }
}