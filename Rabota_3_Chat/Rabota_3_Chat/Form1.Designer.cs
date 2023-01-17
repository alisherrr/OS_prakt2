namespace Rabota_3_Chat
{
    partial class Form1
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
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.panelUnderline = new System.Windows.Forms.Panel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelNotification = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panelUnderlineLogin = new System.Windows.Forms.Panel();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMain.ForeColor = System.Drawing.Color.White;
            this.textBoxMain.Location = new System.Drawing.Point(12, 57);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.Size = new System.Drawing.Size(804, 880);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.Visible = false;
            // 
            // panelUnderline
            // 
            this.panelUnderline.BackColor = System.Drawing.Color.White;
            this.panelUnderline.Location = new System.Drawing.Point(12, 1031);
            this.panelUnderline.Name = "panelUnderline";
            this.panelUnderline.Size = new System.Drawing.Size(571, 1);
            this.panelUnderline.TabIndex = 2;
            this.panelUnderline.Visible = false;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.ForeColor = System.Drawing.Color.White;
            this.textBoxMessage.Location = new System.Drawing.Point(12, 943);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(571, 89);
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.Visible = false;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(589, 943);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(227, 89);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Отправить сообщение";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Visible = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(12, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(458, 45);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Добро пожаловать, Алишер!";
            this.labelWelcome.Visible = false;
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.BackColor = System.Drawing.Color.Transparent;
            this.labelNotification.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNotification.ForeColor = System.Drawing.Color.White;
            this.labelNotification.Location = new System.Drawing.Point(213, 329);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(408, 60);
            this.labelNotification.TabIndex = 6;
            this.labelNotification.Text = "Введите ваш логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxLogin.Location = new System.Drawing.Point(213, 422);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(408, 55);
            this.textBoxLogin.TabIndex = 7;
            // 
            // panelUnderlineLogin
            // 
            this.panelUnderlineLogin.BackColor = System.Drawing.Color.White;
            this.panelUnderlineLogin.Location = new System.Drawing.Point(213, 473);
            this.panelUnderlineLogin.Name = "panelUnderlineLogin";
            this.panelUnderlineLogin.Size = new System.Drawing.Size(408, 1);
            this.panelUnderlineLogin.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(283, 500);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(270, 60);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = global::Rabota_2_Chat.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(828, 1044);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.panelUnderlineLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelNotification);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panelUnderline);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(850, 1100);
            this.MinimumSize = new System.Drawing.Size(850, 1100);
            this.Name = "Form1";
            this.Text = "Cool Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxMain;
        private Panel panelUnderline;
        private TextBox textBoxMessage;
        private Button buttonSend;
        private Label labelWelcome;
        private Label labelNotification;
        private TextBox textBoxLogin;
        private Panel panelUnderlineLogin;
        private Button buttonConnect;
    }
}