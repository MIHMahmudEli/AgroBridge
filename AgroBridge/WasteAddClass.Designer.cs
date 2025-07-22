namespace AgroBridge
{
    partial class WasteAddClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WasteAddClass));
            this.addButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goodsNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityTextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelForOperationalButton0 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelForOperationalButton1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddGoodsButton = new System.Windows.Forms.Button();
            this.goToAddWasteClass = new System.Windows.Forms.Button();
            this.addEqipmentButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelForOperationalButton2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanelForOperationalButton0.SuspendLayout();
            this.flowLayoutPanelForOperationalButton1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(939, 1000);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(492, 161);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.Red;
            this.BrowseButton.Location = new System.Drawing.Point(1891, 770);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(275, 100);
            this.BrowseButton.TabIndex = 20;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1883, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 46);
            this.label5.TabIndex = 19;
            this.label5.Text = "Waste Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1767, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 46);
            this.label4.TabIndex = 17;
            this.label4.Text = "Waste Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Crop Residues",
            "Animal Wate",
            "Processing Waste",
            "Forestey Waste",
            "Food Waste"});
            this.categoryComboBox.Location = new System.Drawing.Point(885, 589);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(651, 54);
            this.categoryComboBox.TabIndex = 16;
            this.categoryComboBox.Text = "Crop Residues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1394, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 82);
            this.label3.TabIndex = 15;
            this.label3.Text = "Waste Details";
            // 
            // goodsPriceTextBox
            // 
            this.goodsPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goodsPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsPriceTextBox.Location = new System.Drawing.Point(885, 432);
            this.goodsPriceTextBox.Name = "goodsPriceTextBox";
            this.goodsPriceTextBox.Size = new System.Drawing.Size(651, 55);
            this.goodsPriceTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(877, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Waste Price";
            // 
            // goodsNameTextBox
            // 
            this.goodsNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goodsNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameTextBox.Location = new System.Drawing.Point(885, 288);
            this.goodsNameTextBox.Name = "goodsNameTextBox";
            this.goodsNameTextBox.Size = new System.Drawing.Size(651, 55);
            this.goodsNameTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(877, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Waste Name";
            // 
            // quantityTextBox1
            // 
            this.quantityTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox1.Location = new System.Drawing.Point(885, 746);
            this.quantityTextBox1.Name = "quantityTextBox1";
            this.quantityTextBox1.Size = new System.Drawing.Size(651, 55);
            this.quantityTextBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(877, 688);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 46);
            this.label6.TabIndex = 22;
            this.label6.Text = "Waste Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(877, 818);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 46);
            this.label7.TabIndex = 30;
            this.label7.Text = "Units";
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Items.AddRange(new object[] {
            "Kg",
            "Liter",
            "Dozen",
            "Gram"});
            this.UnitComboBox.Location = new System.Drawing.Point(885, 876);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(651, 63);
            this.UnitComboBox.TabIndex = 29;
            this.UnitComboBox.Text = "Kg";
            // 
            // flowLayoutPanelForOperationalButton0
            // 
            this.flowLayoutPanelForOperationalButton0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(183)))), ((int)(((byte)(135)))));
            this.flowLayoutPanelForOperationalButton0.Controls.Add(this.flowLayoutPanelForOperationalButton1);
            this.flowLayoutPanelForOperationalButton0.Controls.Add(this.flowLayoutPanelForOperationalButton2);
            this.flowLayoutPanelForOperationalButton0.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelForOperationalButton0.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelForOperationalButton0.Name = "flowLayoutPanelForOperationalButton0";
            this.flowLayoutPanelForOperationalButton0.Size = new System.Drawing.Size(545, 1289);
            this.flowLayoutPanelForOperationalButton0.TabIndex = 31;
            // 
            // flowLayoutPanelForOperationalButton1
            // 
            this.flowLayoutPanelForOperationalButton1.AutoScroll = true;
            this.flowLayoutPanelForOperationalButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(183)))), ((int)(((byte)(135)))));
            this.flowLayoutPanelForOperationalButton1.Controls.Add(this.AddGoodsButton);
            this.flowLayoutPanelForOperationalButton1.Controls.Add(this.goToAddWasteClass);
            this.flowLayoutPanelForOperationalButton1.Controls.Add(this.addEqipmentButton);
            this.flowLayoutPanelForOperationalButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelForOperationalButton1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelForOperationalButton1.Name = "flowLayoutPanelForOperationalButton1";
            this.flowLayoutPanelForOperationalButton1.Size = new System.Drawing.Size(545, 958);
            this.flowLayoutPanelForOperationalButton1.TabIndex = 2;
            // 
            // AddGoodsButton
            // 
            this.AddGoodsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGoodsButton.FlatAppearance.BorderSize = 0;
            this.AddGoodsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGoodsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGoodsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddGoodsButton.Image = ((System.Drawing.Image)(resources.GetObject("AddGoodsButton.Image")));
            this.AddGoodsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddGoodsButton.Location = new System.Drawing.Point(3, 3);
            this.AddGoodsButton.Name = "AddGoodsButton";
            this.AddGoodsButton.Size = new System.Drawing.Size(539, 161);
            this.AddGoodsButton.TabIndex = 30;
            this.AddGoodsButton.Text = "  ADD Goods";
            this.AddGoodsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddGoodsButton.UseVisualStyleBackColor = true;
            this.AddGoodsButton.Click += new System.EventHandler(this.AddGoodsButton_Click);
            // 
            // goToAddWasteClass
            // 
            this.goToAddWasteClass.FlatAppearance.BorderSize = 0;
            this.goToAddWasteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToAddWasteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToAddWasteClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goToAddWasteClass.Image = ((System.Drawing.Image)(resources.GetObject("goToAddWasteClass.Image")));
            this.goToAddWasteClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToAddWasteClass.Location = new System.Drawing.Point(3, 170);
            this.goToAddWasteClass.Name = "goToAddWasteClass";
            this.goToAddWasteClass.Size = new System.Drawing.Size(539, 161);
            this.goToAddWasteClass.TabIndex = 11;
            this.goToAddWasteClass.Text = "  ADD Waste";
            this.goToAddWasteClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToAddWasteClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToAddWasteClass.UseVisualStyleBackColor = true;
            // 
            // addEqipmentButton
            // 
            this.addEqipmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEqipmentButton.FlatAppearance.BorderSize = 0;
            this.addEqipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEqipmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEqipmentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEqipmentButton.Image = ((System.Drawing.Image)(resources.GetObject("addEqipmentButton.Image")));
            this.addEqipmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEqipmentButton.Location = new System.Drawing.Point(3, 337);
            this.addEqipmentButton.Name = "addEqipmentButton";
            this.addEqipmentButton.Size = new System.Drawing.Size(539, 161);
            this.addEqipmentButton.TabIndex = 26;
            this.addEqipmentButton.Text = "  ADD Equipment";
            this.addEqipmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addEqipmentButton.UseVisualStyleBackColor = true;
            this.addEqipmentButton.Click += new System.EventHandler(this.addEqipmentButton_Click);
            // 
            // flowLayoutPanelForOperationalButton2
            // 
            this.flowLayoutPanelForOperationalButton2.AutoScroll = true;
            this.flowLayoutPanelForOperationalButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelForOperationalButton2.Location = new System.Drawing.Point(0, 964);
            this.flowLayoutPanelForOperationalButton2.Name = "flowLayoutPanelForOperationalButton2";
            this.flowLayoutPanelForOperationalButton2.Size = new System.Drawing.Size(545, 325);
            this.flowLayoutPanelForOperationalButton2.TabIndex = 20;
            // 
            // WasteAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(2644, 1289);
            this.Controls.Add(this.flowLayoutPanelForOperationalButton0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.quantityTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goodsPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodsNameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WasteAddClass";
            this.Text = "WasteAddClass";
            this.Load += new System.EventHandler(this.WasteAddClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanelForOperationalButton0.ResumeLayout(false);
            this.flowLayoutPanelForOperationalButton1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goodsPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goodsNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.Panel flowLayoutPanelForOperationalButton0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelForOperationalButton1;
        private System.Windows.Forms.Button AddGoodsButton;
        private System.Windows.Forms.Button goToAddWasteClass;
        private System.Windows.Forms.Button addEqipmentButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelForOperationalButton2;
    }
}