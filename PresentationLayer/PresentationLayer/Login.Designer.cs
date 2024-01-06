namespace PresentationLayer
{
    partial class Login
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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.textBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.labelUserNameLogin = new System.Windows.Forms.Label();
            this.labelTitleLogin = new System.Windows.Forms.Label();
            this.labelLoginApp = new System.Windows.Forms.Label();
            this.toolTipLabel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.AutoSize = true;
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(427, 363);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(125, 39);
            this.buttonSignUp.TabIndex = 14;
            this.buttonSignUp.Text = "SIGN UP";
            this.toolTipButton.SetToolTip(this.buttonSignUp, "Click to Sign Up an new User Account\r\n");
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(233, 363);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(99, 39);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "LOGIN";
            this.toolTipButton.SetToolTip(this.buttonLogin, "Click to Login in Bike Factory Management Application\r\n");
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(459, 254);
            this.textBoxPasswordLogin.Multiline = true;
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.PasswordChar = '*';
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(233, 42);
            this.textBoxPasswordLogin.TabIndex = 12;
            this.toolTipTextBox.SetToolTip(this.textBoxPasswordLogin, "Insert the Password of Exsiting Account");
            // 
            // textBoxUserNameLogin
            // 
            this.textBoxUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameLogin.Location = new System.Drawing.Point(459, 144);
            this.textBoxUserNameLogin.Multiline = true;
            this.textBoxUserNameLogin.Name = "textBoxUserNameLogin";
            this.textBoxUserNameLogin.Size = new System.Drawing.Size(233, 42);
            this.textBoxUserNameLogin.TabIndex = 11;
            this.toolTipTextBox.SetToolTip(this.textBoxUserNameLogin, "Insert the User Name of Exsiting Account");
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLogin.ForeColor = System.Drawing.Color.Black;
            this.labelPasswordLogin.Location = new System.Drawing.Point(165, 254);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(152, 46);
            this.labelPasswordLogin.TabIndex = 10;
            this.labelPasswordLogin.Text = "Password";
            this.labelPasswordLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelPasswordLogin, "Password of User Account");
            // 
            // labelUserNameLogin
            // 
            this.labelUserNameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelUserNameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameLogin.ForeColor = System.Drawing.Color.Black;
            this.labelUserNameLogin.Location = new System.Drawing.Point(165, 144);
            this.labelUserNameLogin.Name = "labelUserNameLogin";
            this.labelUserNameLogin.Size = new System.Drawing.Size(152, 42);
            this.labelUserNameLogin.TabIndex = 9;
            this.labelUserNameLogin.Text = "User Name";
            this.labelUserNameLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelUserNameLogin, "User Name of User Account");
            // 
            // labelTitleLogin
            // 
            this.labelTitleLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelTitleLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitleLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleLogin.ForeColor = System.Drawing.Color.Red;
            this.labelTitleLogin.Location = new System.Drawing.Point(-1, -1);
            this.labelTitleLogin.Name = "labelTitleLogin";
            this.labelTitleLogin.Size = new System.Drawing.Size(804, 52);
            this.labelTitleLogin.TabIndex = 8;
            this.labelTitleLogin.Text = "Bike Factory Management";
            this.labelTitleLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoginApp
            // 
            this.labelLoginApp.BackColor = System.Drawing.SystemColors.Control;
            this.labelLoginApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginApp.ForeColor = System.Drawing.Color.Blue;
            this.labelLoginApp.Location = new System.Drawing.Point(263, 64);
            this.labelLoginApp.Name = "labelLoginApp";
            this.labelLoginApp.Size = new System.Drawing.Size(229, 52);
            this.labelLoginApp.TabIndex = 16;
            this.labelLoginApp.Text = "Login";
            this.labelLoginApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelLoginApp, "Login Form of Bike Factory Management");
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoginApp);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUserNameLogin);
            this.Controls.Add(this.labelPasswordLogin);
            this.Controls.Add(this.labelUserNameLogin);
            this.Controls.Add(this.labelTitleLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUserNameLogin;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Label labelUserNameLogin;
        private System.Windows.Forms.Label labelTitleLogin;
        private System.Windows.Forms.Label labelLoginApp;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.ToolTip toolTipTextBox;
        private System.Windows.Forms.ToolTip toolTipLabel;
    }
}