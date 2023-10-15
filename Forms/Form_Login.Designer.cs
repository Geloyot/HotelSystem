namespace HotelReservationSystem
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.LinkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Checkbox_ShowPass = new System.Windows.Forms.CheckBox();
            this.Label_Loading = new System.Windows.Forms.Label();
            this.ProgressBar_Loading = new System.Windows.Forms.ProgressBar();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.ErrorProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.LightGreen;
            this.Panel_DateTime.Controls.Add(this.label4);
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(16, 23);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(128, 119);
            this.Panel_DateTime.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 56);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date and \r\nTime";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Calendar
            // 
            this.Label_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Calendar.AutoSize = true;
            this.Label_Calendar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calendar.Location = new System.Drawing.Point(6, 64);
            this.Label_Calendar.Name = "Label_Calendar";
            this.Label_Calendar.Size = new System.Drawing.Size(60, 25);
            this.Label_Calendar.TabIndex = 14;
            this.Label_Calendar.Text = "Date:";
            // 
            // Label_Clock
            // 
            this.Label_Clock.AutoSize = true;
            this.Label_Clock.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Clock.Location = new System.Drawing.Point(6, 89);
            this.Label_Clock.Name = "Label_Clock";
            this.Label_Clock.Size = new System.Drawing.Size(61, 25);
            this.Label_Clock.TabIndex = 13;
            this.Label_Clock.Text = "Time:";
            // 
            // LinkLabel_Register
            // 
            this.LinkLabel_Register.AutoSize = true;
            this.LinkLabel_Register.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Register.Location = new System.Drawing.Point(367, 353);
            this.LinkLabel_Register.Name = "LinkLabel_Register";
            this.LinkLabel_Register.Size = new System.Drawing.Size(84, 25);
            this.LinkLabel_Register.TabIndex = 22;
            this.LinkLabel_Register.TabStop = true;
            this.LinkLabel_Register.Text = "Sign Up";
            this.LinkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Register_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Don\'t have an account yet?";
            // 
            // Checkbox_ShowPass
            // 
            this.Checkbox_ShowPass.AutoSize = true;
            this.Checkbox_ShowPass.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_ShowPass.Location = new System.Drawing.Point(196, 277);
            this.Checkbox_ShowPass.Name = "Checkbox_ShowPass";
            this.Checkbox_ShowPass.Size = new System.Drawing.Size(161, 29);
            this.Checkbox_ShowPass.TabIndex = 20;
            this.Checkbox_ShowPass.Text = "Show Password";
            this.Checkbox_ShowPass.UseVisualStyleBackColor = true;
            this.Checkbox_ShowPass.CheckedChanged += new System.EventHandler(this.Checkbox_ShowPass_CheckedChanged);
            // 
            // Label_Loading
            // 
            this.Label_Loading.AutoSize = true;
            this.Label_Loading.BackColor = System.Drawing.Color.Transparent;
            this.Label_Loading.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Loading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Loading.Location = new System.Drawing.Point(255, 378);
            this.Label_Loading.Name = "Label_Loading";
            this.Label_Loading.Size = new System.Drawing.Size(0, 25);
            this.Label_Loading.TabIndex = 19;
            this.Label_Loading.Visible = false;
            // 
            // ProgressBar_Loading
            // 
            this.ProgressBar_Loading.ForeColor = System.Drawing.Color.LimeGreen;
            this.ProgressBar_Loading.Location = new System.Drawing.Point(1, 406);
            this.ProgressBar_Loading.Maximum = 200;
            this.ProgressBar_Loading.Name = "ProgressBar_Loading";
            this.ProgressBar_Loading.Size = new System.Drawing.Size(552, 39);
            this.ProgressBar_Loading.TabIndex = 18;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(195, 312);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(166, 34);
            this.Btn_Login.TabIndex = 17;
            this.Btn_Login.Text = "LOG IN";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(158, 22);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(240, 120);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 16;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(131, 238);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(291, 33);
            this.Txt_Password.TabIndex = 14;
            this.Txt_Password.UseSystemPasswordChar = true;
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.Location = new System.Drawing.Point(131, 174);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(291, 33);
            this.Txt_Username.TabIndex = 12;
            this.Txt_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Username_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // Timer_Loading
            // 
            this.Timer_Loading.Interval = 1;
            this.Timer_Loading.Tick += new System.EventHandler(this.Timer_Loading_Tick);
            // 
            // ErrorProviderInput
            // 
            this.ErrorProviderInput.ContainerControl = this;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.Pic_HotelKannoteki);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Panel_DateTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_Login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_Username);
            this.panel1.Controls.Add(this.ProgressBar_Loading);
            this.panel1.Controls.Add(this.LinkLabel_Register);
            this.panel1.Controls.Add(this.Label_Loading);
            this.panel1.Controls.Add(this.Checkbox_ShowPass);
            this.panel1.Controls.Add(this.Txt_Password);
            this.panel1.Location = new System.Drawing.Point(28, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 445);
            this.panel1.TabIndex = 24;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(613, 481);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.ProgressBar ProgressBar_Loading;
        private System.Windows.Forms.Label Label_Loading;
        private System.Windows.Forms.Timer Timer_Loading;
        private System.Windows.Forms.ErrorProvider ErrorProviderInput;
        private System.Windows.Forms.CheckBox Checkbox_ShowPass;
        private System.Windows.Forms.LinkLabel LinkLabel_Register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Panel panel1;
    }
}