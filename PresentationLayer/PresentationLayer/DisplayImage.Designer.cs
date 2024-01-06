namespace PresentationLayer
{
    partial class DisplayImage
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.radioButtonUndefined = new System.Windows.Forms.RadioButton();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.labelTitleColor = new System.Windows.Forms.Label();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roadBikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mountainBikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClose = new System.Windows.Forms.Button();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLabel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRadio = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(815, 154);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 40);
            this.buttonAdd.TabIndex = 68;
            this.buttonAdd.Text = "ADD";
            this.toolTipButton.SetToolTip(this.buttonAdd, "Click to Add the Chosen Color of the Bike");
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(661, 152);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(116, 40);
            this.buttonDisplay.TabIndex = 67;
            this.buttonDisplay.Text = "DISPLAY";
            this.toolTipButton.SetToolTip(this.buttonDisplay, "Click to Display the Chosen Color Option ");
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // radioButtonUndefined
            // 
            this.radioButtonUndefined.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUndefined.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonUndefined.Location = new System.Drawing.Point(376, 153);
            this.radioButtonUndefined.Name = "radioButtonUndefined";
            this.radioButtonUndefined.Size = new System.Drawing.Size(162, 39);
            this.radioButtonUndefined.TabIndex = 66;
            this.radioButtonUndefined.TabStop = true;
            this.radioButtonUndefined.Text = "Undefined";
            this.toolTipRadio.SetToolTip(this.radioButtonUndefined, "Undefined Color of the Bike");
            this.radioButtonUndefined.UseVisualStyleBackColor = true;
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDark.ForeColor = System.Drawing.Color.Black;
            this.radioButtonDark.Location = new System.Drawing.Point(272, 153);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(98, 39);
            this.radioButtonDark.TabIndex = 65;
            this.radioButtonDark.TabStop = true;
            this.radioButtonDark.Text = "Dark";
            this.toolTipRadio.SetToolTip(this.radioButtonDark, "The Image of Color Dark of the Bike");
            this.radioButtonDark.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(168, 153);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(98, 39);
            this.radioButtonBlue.TabIndex = 64;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.toolTipRadio.SetToolTip(this.radioButtonBlue, "The Image of Color Blue of the Bike");
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // labelTitleColor
            // 
            this.labelTitleColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelTitleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitleColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleColor.ForeColor = System.Drawing.Color.Red;
            this.labelTitleColor.Location = new System.Drawing.Point(0, 28);
            this.labelTitleColor.Name = "labelTitleColor";
            this.labelTitleColor.Size = new System.Drawing.Size(1155, 81);
            this.labelTitleColor.TabIndex = 63;
            this.labelTitleColor.Text = "Color";
            this.labelTitleColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLabel.SetToolTip(this.labelTitleColor, "The Color of Chosen Bike");
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(52, 153);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(98, 39);
            this.radioButtonRed.TabIndex = 62;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.toolTipRadio.SetToolTip(this.radioButtonRed, "The Image of Color Red of the Bike");
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(12, 201);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(1143, 531);
            this.pictureBoxDisplay.TabIndex = 61;
            this.pictureBoxDisplay.TabStop = false;
            this.toolTipLabel.SetToolTip(this.pictureBoxDisplay, "The Observation of Image of the Bike Color based the Chosen Option");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roadBikeToolStripMenuItem,
            this.mountainBikeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 28);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roadBikeToolStripMenuItem
            // 
            this.roadBikeToolStripMenuItem.Name = "roadBikeToolStripMenuItem";
            this.roadBikeToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.roadBikeToolStripMenuItem.Text = "Road Bike";
            this.roadBikeToolStripMenuItem.ToolTipText = "Click to choose Road Bike";
            this.roadBikeToolStripMenuItem.Click += new System.EventHandler(this.roadBikeToolStripMenuItem_Click);
            // 
            // mountainBikeToolStripMenuItem
            // 
            this.mountainBikeToolStripMenuItem.Name = "mountainBikeToolStripMenuItem";
            this.mountainBikeToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.mountainBikeToolStripMenuItem.Text = "Mountain Bike";
            this.mountainBikeToolStripMenuItem.ToolTipText = "Click to choose Mountain Bike";
            this.mountainBikeToolStripMenuItem.Click += new System.EventHandler(this.mountainBikeToolStripMenuItem_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(972, 152);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(116, 40);
            this.buttonClose.TabIndex = 70;
            this.buttonClose.Text = "CLOSE";
            this.toolTipButton.SetToolTip(this.buttonClose, "Click to Close the Section of Chosing Color");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DisplayImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 734);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.radioButtonUndefined);
            this.Controls.Add(this.radioButtonDark);
            this.Controls.Add(this.radioButtonBlue);
            this.Controls.Add(this.labelTitleColor);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonClose);
            this.Name = "DisplayImage";
            this.Text = "DisplayImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.RadioButton radioButtonUndefined;
        private System.Windows.Forms.RadioButton radioButtonDark;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.Label labelTitleColor;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem roadBikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mountainBikeToolStripMenuItem;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolTip toolTipRadio;
        private System.Windows.Forms.ToolTip toolTipLabel;
        private System.Windows.Forms.ToolTip toolTipButton;
    }
}