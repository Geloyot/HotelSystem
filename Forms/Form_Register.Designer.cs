namespace HotelReservationSystem
{
    partial class Form_Register
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
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.ErrorProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_PasswordConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.CbBox_Role = new System.Windows.Forms.ComboBox();
            this.LinkLabel_Login = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_DateTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // ErrorProviderInput
            // 
            this.ErrorProviderInput.ContainerControl = this;
            // 
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(151, 10);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(240, 120);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 16;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Select Role:";
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.Location = new System.Drawing.Point(190, 451);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(166, 34);
            this.Btn_Register.TabIndex = 17;
            this.Btn_Register.Text = "Create Account";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.LightGreen;
            this.Panel_DateTime.Controls.Add(this.label4);
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(9, 11);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Already had an account?";
            // 
            // Txt_PasswordConfirm
            // 
            this.Txt_PasswordConfirm.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PasswordConfirm.Location = new System.Drawing.Point(121, 295);
            this.Txt_PasswordConfirm.Name = "Txt_PasswordConfirm";
            this.Txt_PasswordConfirm.Size = new System.Drawing.Size(291, 33);
            this.Txt_PasswordConfirm.TabIndex = 25;
            this.Txt_PasswordConfirm.UseSystemPasswordChar = true;
            this.Txt_PasswordConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PasswordConfirm_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.Location = new System.Drawing.Point(121, 171);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(291, 33);
            this.Txt_Username.TabIndex = 12;
            this.Txt_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Username_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Confirm Password:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(121, 235);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(291, 33);
            this.Txt_Password.TabIndex = 14;
            this.Txt_Password.UseSystemPasswordChar = true;
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // CbBox_Role
            // 
            this.CbBox_Role.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBox_Role.Location = new System.Drawing.Point(121, 394);
            this.CbBox_Role.Name = "CbBox_Role";
            this.CbBox_Role.Size = new System.Drawing.Size(291, 33);
            this.CbBox_Role.TabIndex = 0;
            this.CbBox_Role.SelectedIndexChanged += new System.EventHandler(this.CbBox_Role_SelectedIndexChanged);
            // 
            // LinkLabel_Login
            // 
            this.LinkLabel_Login.AutoSize = true;
            this.LinkLabel_Login.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Login.Location = new System.Drawing.Point(350, 513);
            this.LinkLabel_Login.Name = "LinkLabel_Login";
            this.LinkLabel_Login.Size = new System.Drawing.Size(77, 25);
            this.LinkLabel_Login.TabIndex = 22;
            this.LinkLabel_Login.TabStop = true;
            this.LinkLabel_Login.Text = "Sign In";
            this.LinkLabel_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Login_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.Pic_HotelKannoteki);
            this.panel1.Controls.Add(this.Txt_Username);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Btn_Register);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_Password);
            this.panel1.Controls.Add(this.Panel_DateTime);
            this.panel1.Controls.Add(this.Txt_PasswordConfirm);
            this.panel1.Controls.Add(this.LinkLabel_Login);
            this.panel1.Controls.Add(this.CbBox_Role);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 555);
            this.panel1.TabIndex = 27;
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(543, 581);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Account";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.LinkLabel LinkLabel_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_PasswordConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.ErrorProvider ErrorProviderInput;
        private System.Windows.Forms.ComboBox CbBox_Role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}