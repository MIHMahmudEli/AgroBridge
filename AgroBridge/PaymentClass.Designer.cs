namespace AgroBridge
{
    partial class PaymentClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentClass));
            this.pictureBoxForBkash = new System.Windows.Forms.PictureBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.NagadPictureBox = new System.Windows.Forms.PictureBox();
            this.RocketPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForBkash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NagadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocketPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxForBkash
            // 
            this.pictureBoxForBkash.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxForBkash.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxForBkash.Image")));
            this.pictureBoxForBkash.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxForBkash.Name = "pictureBoxForBkash";
            this.pictureBoxForBkash.Size = new System.Drawing.Size(1688, 337);
            this.pictureBoxForBkash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxForBkash.TabIndex = 0;
            this.pictureBoxForBkash.TabStop = false;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTextBox.Location = new System.Drawing.Point(579, 461);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(633, 62);
            this.NumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(227, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUMBER  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(227, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "PIN           :";
            // 
            // PinTextBox
            // 
            this.PinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinTextBox.Location = new System.Drawing.Point(579, 635);
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(633, 62);
            this.PinTextBox.TabIndex = 4;
            this.PinTextBox.UseSystemPasswordChar = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Black;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(579, 880);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(255, 73);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.Black;
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaymentButton.Location = new System.Drawing.Point(957, 880);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(255, 73);
            this.PaymentButton.TabIndex = 7;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // NagadPictureBox
            // 
            this.NagadPictureBox.BackColor = System.Drawing.Color.White;
            this.NagadPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NagadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NagadPictureBox.Image")));
            this.NagadPictureBox.Location = new System.Drawing.Point(0, 337);
            this.NagadPictureBox.Name = "NagadPictureBox";
            this.NagadPictureBox.Size = new System.Drawing.Size(1688, 337);
            this.NagadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NagadPictureBox.TabIndex = 8;
            this.NagadPictureBox.TabStop = false;
            // 
            // RocketPictureBox
            // 
            this.RocketPictureBox.BackColor = System.Drawing.Color.White;
            this.RocketPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RocketPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RocketPictureBox.Image")));
            this.RocketPictureBox.Location = new System.Drawing.Point(0, 674);
            this.RocketPictureBox.Name = "RocketPictureBox";
            this.RocketPictureBox.Size = new System.Drawing.Size(1688, 337);
            this.RocketPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RocketPictureBox.TabIndex = 9;
            this.RocketPictureBox.TabStop = false;
            // 
            // PaymentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(17)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1688, 1314);
            this.Controls.Add(this.RocketPictureBox);
            this.Controls.Add(this.NagadPictureBox);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PinTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.pictureBoxForBkash);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentClass";
            this.Text = "Payment Class";
            this.Load += new System.EventHandler(this.BkashClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForBkash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NagadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocketPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForBkash;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.PictureBox NagadPictureBox;
        private System.Windows.Forms.PictureBox RocketPictureBox;
    }
}