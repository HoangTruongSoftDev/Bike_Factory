namespace PresentationLayer
{
    partial class Register
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
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxReenterPasswordRegister = new System.Windows.Forms.TextBox();
            this.labelReenterPasswordRegister = new System.Windows.Forms.Label();
            this.textBoxPasswordRegister = new System.Windows.Forms.TextBox();
            this.textBoxUserNameRegister = new System.Windows.Forms.TextBox();
            this.labelPasswordRegister = new System.Windows.Forms.Label();
            this.labelUserNameRegister = new System.Windows.Forms.Label();
            this.labelRegisterApp = new System.Windows.Forms.Label();
            this.labelTitleRegister = new System.Windows.Forms.Label();
            this.toolTipLabel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.AutoSize = true;
            this.buttonBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToLogin.Location = new System.Drawing.Point(443, 403);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(177, 54);
            this.buttonBackToLogin.TabIndex = 23;
            this.buttonBackToLogin.Text = "Back to Login";
            this.toolTipButton.SetToolTip(this.buttonBackToLogin, "Click to Get Back to Login Form\r\n");
            this.buttonBackToLogin.UseVisualStyleBackColor = false;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(228, 403);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(150, 54);
            this.buttonRegister.TabIndex = 22;
            this.buttonRegister.Text = "REGISTER";
            this.toolTipButton.SetToolTip(this.buttonRegister, "Click to Create a New User Account");
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxReenterPasswordRegister
            // 
            this.textBoxReenterPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReenterPasswordRegister.Location = new System.Drawing.Point(432, 310);
            this.textBoxReenterPasswordRegister.Multiline = true;
            this.textBoxReenterPasswordRegister.Name = "textBoxReenterPasswordRegister";
            this.textBoxReenterPasswordRegister.PasswordChar = '*';
            this.textBoxReenterPasswordRegister.Size = new System.Drawing.Size(233, 42);
            this.textBoxReenterPasswordRegister.TabIndex = 21;
            this.textBoxReenterPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipTextBox.SetToolTip(this.textBoxReenterPasswordRegister, "Confirm the Password of User Account");
            // 
            // labelReenterPasswordRegister
            // 
            this.labelReenterPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelReenterPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelReenterPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReenterPasswordRegister.ForeColor = System.Drawing.Color.Black;
            this.labelReenterPasswordRegister.Location = new System.Drawing.Point(138, 310);
            this.labelReenterPasswordRegister.Name = "labelReenterPasswordRegister";
            this.labelReenterPasswordRegister.Size = new System.Drawing.Size(240, 42);
            this.labelReenterPasswordRegister.TabIndex = 20;
            this.labelReenterPasswordRegister.Text = "Re-enter Password";
            this.labelReenterPasswordRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelReenterPasswordRegister, "Confirm the Password of User Account\r\n");
            // 
            // textBoxPasswordRegister
            // 
            this.textBoxPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordRegister.Location = new System.Drawing.Point(432, 222);
            this.textBoxPasswordRegister.Multiline = true;
            this.textBoxPasswordRegister.Name = "textBoxPasswordRegister";
            this.textBoxPasswordRegister.PasswordChar = '*';
            this.textBoxPasswordRegister.Size = new System.Drawing.Size(233, 42);
            this.textBoxPasswordRegister.TabIndex = 19;
            this.textBoxPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipTextBox.SetToolTip(this.textBoxPasswordRegister, "Insert a new Password of User Account");
            // 
            // textBoxUserNameRegister
            // 
            this.textBoxUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameRegister.Location = new System.Drawing.Point(432, 145);
            this.textBoxUserNameRegister.Multiline = true;
            this.textBoxUserNameRegister.Name = "textBoxUserNameRegister";
            this.textBoxUserNameRegister.Size = new System.Drawing.Size(233, 42);
            this.textBoxUserNameRegister.TabIndex = 18;
            this.textBoxUserNameRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipTextBox.SetToolTip(this.textBoxUserNameRegister, "Insert a new User Name of User Account");
            // 
            // labelPasswordRegister
            // 
            this.labelPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordRegister.ForeColor = System.Drawing.Color.Black;
            this.labelPasswordRegister.Location = new System.Drawing.Point(138, 222);
            this.labelPasswordRegister.Name = "labelPasswordRegister";
            this.labelPasswordRegister.Size = new System.Drawing.Size(152, 46);
            this.labelPasswordRegister.TabIndex = 17;
            this.labelPasswordRegister.Text = "Password";
            this.labelPasswordRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelPasswordRegister, "Create a new Password Name of User Account");
            // 
            // labelUserNameRegister
            // 
            this.labelUserNameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelUserNameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameRegister.ForeColor = System.Drawing.Color.Black;
            this.labelUserNameRegister.Location = new System.Drawing.Point(138, 145);
            this.labelUserNameRegister.Name = "labelUserNameRegister";
            this.labelUserNameRegister.Size = new System.Drawing.Size(152, 42);
            this.labelUserNameRegister.TabIndex = 16;
            this.labelUserNameRegister.Text = "User Name";
            this.labelUserNameRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelUserNameRegister, "Create a new User Name of User Account");
            // 
            // labelRegisterApp
            // 
            this.labelRegisterApp.BackColor = System.Drawing.SystemColors.Control;
            this.labelRegisterApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterApp.ForeColor = System.Drawing.Color.Blue;
            this.labelRegisterApp.Location = new System.Drawing.Point(279, 69);
            this.labelRegisterApp.Name = "labelRegisterApp";
            this.labelRegisterApp.Size = new System.Drawing.Size(229, 52);
            this.labelRegisterApp.TabIndex = 15;
            this.labelRegisterApp.Text = "Register";
            this.labelRegisterApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelRegisterApp, "Register Form of Bike Factory Management");
            // 
            // labelTitleRegister
            // 
            this.labelTitleRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelTitleRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitleRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleRegister.ForeColor = System.Drawing.Color.Red;
            this.labelTitleRegister.Location = new System.Drawing.Point(-2, -2);
            this.labelTitleRegister.Name = "labelTitleRegister";
            this.labelTitleRegister.Size = new System.Drawing.Size(804, 59);
            this.labelTitleRegister.TabIndex = 14;
            this.labelTitleRegister.Text = "Bike Factory Management";
            this.labelTitleRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.buttonBackToLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxReenterPasswordRegister);
            this.Controls.Add(this.labelReenterPasswordRegister);
            this.Controls.Add(this.textBoxPasswordRegister);
            this.Controls.Add(this.textBoxUserNameRegister);
            this.Controls.Add(this.labelPasswordRegister);
            this.Controls.Add(this.labelUserNameRegister);
            this.Controls.Add(this.labelRegisterApp);
            this.Controls.Add(this.labelTitleRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxReenterPasswordRegister;
        private System.Windows.Forms.Label labelReenterPasswordRegister;
        private System.Windows.Forms.TextBox textBoxPasswordRegister;
        private System.Windows.Forms.TextBox textBoxUserNameRegister;
        private System.Windows.Forms.Label labelPasswordRegister;
        private System.Windows.Forms.Label labelUserNameRegister;
        private System.Windows.Forms.Label labelRegisterApp;
        private System.Windows.Forms.Label labelTitleRegister;
        private System.Windows.Forms.ToolTip toolTipLabel;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.ToolTip toolTipTextBox;
    }
}