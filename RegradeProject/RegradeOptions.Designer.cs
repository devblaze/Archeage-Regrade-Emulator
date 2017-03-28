namespace RegradeProject
{
    partial class RegradeOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegradeOptions));
            this.bSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbItemtype = new System.Windows.Forms.ComboBox();
            this.tbWSPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbASPrice = new System.Windows.Forms.TextBox();
            this.tbAcSPrice = new System.Windows.Forms.TextBox();
            this.tbRWSPrice = new System.Windows.Forms.TextBox();
            this.tbRASPrice = new System.Windows.Forms.TextBox();
            this.tbRAcSPrice = new System.Windows.Forms.TextBox();
            this.tbSRCPrice = new System.Windows.Forms.TextBox();
            this.tbRCPrice = new System.Windows.Forms.TextBox();
            this.tbSYCPrice = new System.Windows.Forms.TextBox();
            this.tbYCPrice = new System.Windows.Forms.TextBox();
            this.tbBCPrice = new System.Windows.Forms.TextBox();
            this.tbGCPrice = new System.Windows.Forms.TextBox();
            this.tbWCPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = global::RegradeProject.Properties.Resources.button;
            this.bSave.FlatAppearance.BorderSize = 0;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Location = new System.Drawing.Point(249, 252);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(82, 33);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            this.bSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bSave_MouseDown);
            this.bSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bSave_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Type:";
            // 
            // cbItemtype
            // 
            this.cbItemtype.FormattingEnabled = true;
            this.cbItemtype.Items.AddRange(new object[] {
            "1H Weapon",
            "2H Weapon",
            "Bow",
            "Shield",
            "Head",
            "Chest",
            "Waist",
            "Wrist",
            "Hands",
            "Legs",
            "Feet",
            "Ear",
            "Neck",
            "Finger"});
            this.cbItemtype.Location = new System.Drawing.Point(101, 9);
            this.cbItemtype.Name = "cbItemtype";
            this.cbItemtype.Size = new System.Drawing.Size(121, 21);
            this.cbItemtype.TabIndex = 2;
            // 
            // tbWSPrice
            // 
            this.tbWSPrice.Location = new System.Drawing.Point(159, 65);
            this.tbWSPrice.Name = "tbWSPrice";
            this.tbWSPrice.Size = new System.Drawing.Size(121, 20);
            this.tbWSPrice.TabIndex = 1;
            this.tbWSPrice.Text = "0";
            this.tbWSPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWSPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weapon Scroll:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Armor Scroll:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Accessory Scroll:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "R.Accessory Scroll:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "R.Armor Scroll:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "R.Weapon Scroll:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(155, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "AH Prices";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "AH Prices";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(300, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "S.Red Charm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(300, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Red Charm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(300, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "S.Yellow Charm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(300, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Yellow Charm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(300, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Blue Charm:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(300, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Green Charm:";
            // 
            // tbASPrice
            // 
            this.tbASPrice.Location = new System.Drawing.Point(159, 91);
            this.tbASPrice.Name = "tbASPrice";
            this.tbASPrice.Size = new System.Drawing.Size(121, 20);
            this.tbASPrice.TabIndex = 2;
            this.tbASPrice.Text = "0";
            this.tbASPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbASPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbAcSPrice
            // 
            this.tbAcSPrice.Location = new System.Drawing.Point(159, 117);
            this.tbAcSPrice.Name = "tbAcSPrice";
            this.tbAcSPrice.Size = new System.Drawing.Size(121, 20);
            this.tbAcSPrice.TabIndex = 3;
            this.tbAcSPrice.Text = "0";
            this.tbAcSPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAcSPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbRWSPrice
            // 
            this.tbRWSPrice.Location = new System.Drawing.Point(159, 145);
            this.tbRWSPrice.Name = "tbRWSPrice";
            this.tbRWSPrice.Size = new System.Drawing.Size(121, 20);
            this.tbRWSPrice.TabIndex = 4;
            this.tbRWSPrice.Text = "0";
            this.tbRWSPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRWSPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbRASPrice
            // 
            this.tbRASPrice.Location = new System.Drawing.Point(159, 171);
            this.tbRASPrice.Name = "tbRASPrice";
            this.tbRASPrice.Size = new System.Drawing.Size(121, 20);
            this.tbRASPrice.TabIndex = 5;
            this.tbRASPrice.Text = "0";
            this.tbRASPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRASPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbRAcSPrice
            // 
            this.tbRAcSPrice.Location = new System.Drawing.Point(159, 195);
            this.tbRAcSPrice.Name = "tbRAcSPrice";
            this.tbRAcSPrice.Size = new System.Drawing.Size(121, 20);
            this.tbRAcSPrice.TabIndex = 6;
            this.tbRAcSPrice.Text = "0";
            this.tbRAcSPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRAcSPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbSRCPrice
            // 
            this.tbSRCPrice.Location = new System.Drawing.Point(422, 197);
            this.tbSRCPrice.Name = "tbSRCPrice";
            this.tbSRCPrice.Size = new System.Drawing.Size(121, 20);
            this.tbSRCPrice.TabIndex = 12;
            this.tbSRCPrice.Text = "0";
            this.tbSRCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSRCPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbRCPrice
            // 
            this.tbRCPrice.Location = new System.Drawing.Point(422, 173);
            this.tbRCPrice.Name = "tbRCPrice";
            this.tbRCPrice.Size = new System.Drawing.Size(121, 20);
            this.tbRCPrice.TabIndex = 11;
            this.tbRCPrice.Text = "0";
            this.tbRCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRCPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbSYCPrice
            // 
            this.tbSYCPrice.Location = new System.Drawing.Point(422, 147);
            this.tbSYCPrice.Name = "tbSYCPrice";
            this.tbSYCPrice.Size = new System.Drawing.Size(121, 20);
            this.tbSYCPrice.TabIndex = 10;
            this.tbSYCPrice.Text = "0";
            this.tbSYCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSYCPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbYCPrice
            // 
            this.tbYCPrice.Location = new System.Drawing.Point(422, 119);
            this.tbYCPrice.Name = "tbYCPrice";
            this.tbYCPrice.Size = new System.Drawing.Size(121, 20);
            this.tbYCPrice.TabIndex = 9;
            this.tbYCPrice.Text = "0";
            this.tbYCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbYCPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbBCPrice
            // 
            this.tbBCPrice.Location = new System.Drawing.Point(422, 93);
            this.tbBCPrice.Name = "tbBCPrice";
            this.tbBCPrice.Size = new System.Drawing.Size(121, 20);
            this.tbBCPrice.TabIndex = 8;
            this.tbBCPrice.Text = "0";
            this.tbBCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBCPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbGCPrice
            // 
            this.tbGCPrice.Location = new System.Drawing.Point(422, 67);
            this.tbGCPrice.Name = "tbGCPrice";
            this.tbGCPrice.Size = new System.Drawing.Size(121, 20);
            this.tbGCPrice.TabIndex = 7;
            this.tbGCPrice.Text = "0";
            this.tbGCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGCPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbWCPrice
            // 
            this.tbWCPrice.Location = new System.Drawing.Point(422, 223);
            this.tbWCPrice.Name = "tbWCPrice";
            this.tbWCPrice.Size = new System.Drawing.Size(121, 20);
            this.tbWCPrice.TabIndex = 13;
            this.tbWCPrice.Text = "0";
            this.tbWCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWCPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(300, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 20);
            this.label16.TabIndex = 58;
            this.label16.Text = "White Charm:";
            // 
            // RegradeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(562, 297);
            this.Controls.Add(this.tbWCPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbSRCPrice);
            this.Controls.Add(this.tbRCPrice);
            this.Controls.Add(this.tbSYCPrice);
            this.Controls.Add(this.tbYCPrice);
            this.Controls.Add(this.tbBCPrice);
            this.Controls.Add(this.tbGCPrice);
            this.Controls.Add(this.tbRAcSPrice);
            this.Controls.Add(this.tbRASPrice);
            this.Controls.Add(this.tbRWSPrice);
            this.Controls.Add(this.tbAcSPrice);
            this.Controls.Add(this.tbASPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWSPrice);
            this.Controls.Add(this.cbItemtype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegradeOptions";
            this.Text = "Regrade Options";
            this.Load += new System.EventHandler(this.RegradeOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWSPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbASPrice;
        private System.Windows.Forms.TextBox tbAcSPrice;
        private System.Windows.Forms.TextBox tbRWSPrice;
        private System.Windows.Forms.TextBox tbRASPrice;
        private System.Windows.Forms.TextBox tbRAcSPrice;
        private System.Windows.Forms.TextBox tbSRCPrice;
        private System.Windows.Forms.TextBox tbRCPrice;
        private System.Windows.Forms.TextBox tbSYCPrice;
        private System.Windows.Forms.TextBox tbYCPrice;
        private System.Windows.Forms.TextBox tbBCPrice;
        private System.Windows.Forms.TextBox tbGCPrice;
        public System.Windows.Forms.ComboBox cbItemtype;
        private System.Windows.Forms.TextBox tbWCPrice;
        private System.Windows.Forms.Label label16;
    }
}