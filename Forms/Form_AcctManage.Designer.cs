namespace HotelReservationSystem
{
    partial class Form_AcctManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AcctManage));
            this.Panel_AcctManage = new System.Windows.Forms.Panel();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Panel_DateTime = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Calendar = new System.Windows.Forms.Label();
            this.Label_Clock = new System.Windows.Forms.Label();
            this.Checkbox_ShowPass = new System.Windows.Forms.CheckBox();
            this.Pic_HotelKannoteki = new System.Windows.Forms.PictureBox();
            this.Panel_AcctOptions = new System.Windows.Forms.Panel();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_AcctManage = new System.Windows.Forms.DataGridView();
            this.ErrorProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Panel_AcctManage.SuspendLayout();
            this.Panel_DateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).BeginInit();
            this.Panel_AcctOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AcctManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_AcctManage
            // 
            this.Panel_AcctManage.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Panel_AcctManage.Controls.Add(this.Btn_LogOut);
            this.Panel_AcctManage.Controls.Add(this.Panel_DateTime);
            this.Panel_AcctManage.Controls.Add(this.Pic_HotelKannoteki);
            this.Panel_AcctManage.Controls.Add(this.Panel_AcctOptions);
            this.Panel_AcctManage.Controls.Add(this.Dgv_AcctManage);
            this.Panel_AcctManage.Location = new System.Drawing.Point(47, 16);
            this.Panel_AcctManage.Name = "Panel_AcctManage";
            this.Panel_AcctManage.Size = new System.Drawing.Size(918, 692);
            this.Panel_AcctManage.TabIndex = 0;
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.Location = new System.Drawing.Point(738, 12);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(166, 34);
            this.Btn_LogOut.TabIndex = 5;
            this.Btn_LogOut.Text = "LOG OUT";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // Panel_DateTime
            // 
            this.Panel_DateTime.BackColor = System.Drawing.Color.LightGreen;
            this.Panel_DateTime.Controls.Add(this.label3);
            this.Panel_DateTime.Controls.Add(this.Label_Calendar);
            this.Panel_DateTime.Controls.Add(this.Label_Clock);
            this.Panel_DateTime.Location = new System.Drawing.Point(15, 4);
            this.Panel_DateTime.Name = "Panel_DateTime";
            this.Panel_DateTime.Size = new System.Drawing.Size(128, 119);
            this.Panel_DateTime.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 56);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date and \r\nTime";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // Checkbox_ShowPass
            // 
            this.Checkbox_ShowPass.AutoSize = true;
            this.Checkbox_ShowPass.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_ShowPass.Location = new System.Drawing.Point(352, 74);
            this.Checkbox_ShowPass.Name = "Checkbox_ShowPass";
            this.Checkbox_ShowPass.Size = new System.Drawing.Size(161, 29);
            this.Checkbox_ShowPass.TabIndex = 12;
            this.Checkbox_ShowPass.Text = "Show Password";
            this.Checkbox_ShowPass.UseVisualStyleBackColor = true;
            this.Checkbox_ShowPass.CheckedChanged += new System.EventHandler(this.Checkbox_ShowPass_CheckedChanged);
            // 
            // Pic_HotelKannoteki
            // 
            this.Pic_HotelKannoteki.Image = global::HotelReservationSystem.Properties.Resources.hoteldbsyslogo;
            this.Pic_HotelKannoteki.Location = new System.Drawing.Point(338, 4);
            this.Pic_HotelKannoteki.Name = "Pic_HotelKannoteki";
            this.Pic_HotelKannoteki.Size = new System.Drawing.Size(240, 120);
            this.Pic_HotelKannoteki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_HotelKannoteki.TabIndex = 11;
            this.Pic_HotelKannoteki.TabStop = false;
            // 
            // Panel_AcctOptions
            // 
            this.Panel_AcctOptions.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Panel_AcctOptions.Controls.Add(this.Btn_Register);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Update);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Login);
            this.Panel_AcctOptions.Controls.Add(this.Checkbox_ShowPass);
            this.Panel_AcctOptions.Controls.Add(this.Btn_Delete);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Username);
            this.Panel_AcctOptions.Controls.Add(this.label1);
            this.Panel_AcctOptions.Controls.Add(this.label2);
            this.Panel_AcctOptions.Controls.Add(this.Txt_Password);
            this.Panel_AcctOptions.Location = new System.Drawing.Point(15, 154);
            this.Panel_AcctOptions.Name = "Panel_AcctOptions";
            this.Panel_AcctOptions.Size = new System.Drawing.Size(889, 175);
            this.Panel_AcctOptions.TabIndex = 9;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.Location = new System.Drawing.Point(8, 138);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(166, 34);
            this.Btn_Register.TabIndex = 1;
            this.Btn_Register.Text = "Register Account";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(180, 138);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(166, 34);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Update Account";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(352, 138);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(166, 34);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete Account";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(720, 138);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(166, 34);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "LOG IN TEST";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(352, 35);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(291, 33);
            this.Txt_Password.TabIndex = 8;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.Location = new System.Drawing.Point(27, 35);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(291, 33);
            this.Txt_Username.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // Dgv_AcctManage
            // 
            this.Dgv_AcctManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_AcctManage.Location = new System.Drawing.Point(15, 335);
            this.Dgv_AcctManage.Name = "Dgv_AcctManage";
            this.Dgv_AcctManage.Size = new System.Drawing.Size(889, 344);
            this.Dgv_AcctManage.TabIndex = 0;
            this.Dgv_AcctManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_AcctManage_CellClick);
            // 
            // ErrorProviderInput
            // 
            this.ErrorProviderInput.ContainerControl = this;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Form_AcctManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationSystem.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Panel_AcctManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AcctManage";
            this.Text = "Account Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AcctManage_FormClosed);
            this.Load += new System.EventHandler(this.Form_AcctManage_Load);
            this.Panel_AcctManage.ResumeLayout(false);
            this.Panel_DateTime.ResumeLayout(false);
            this.Panel_DateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_HotelKannoteki)).EndInit();
            this.Panel_AcctOptions.ResumeLayout(false);
            this.Panel_AcctOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_AcctManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_AcctManage;
        private System.Windows.Forms.DataGridView Dgv_AcctManage;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_AcctOptions;
        private System.Windows.Forms.PictureBox Pic_HotelKannoteki;
        private System.Windows.Forms.ErrorProvider ErrorProviderInput;
        private System.Windows.Forms.CheckBox Checkbox_ShowPass;
        private System.Windows.Forms.Label Label_Clock;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Label Label_Calendar;
        private System.Windows.Forms.Panel Panel_DateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_LogOut;
    }
}

