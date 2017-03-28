namespace RegradeProject
{
    partial class EnchantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnchantForm));
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.pbGrade = new System.Windows.Forms.PictureBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbGradec = new System.Windows.Forms.Label();
            this.lbGrade1 = new System.Windows.Forms.Label();
            this.lbGrade2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItem
            // 
            this.pbItem.BackColor = System.Drawing.Color.Transparent;
            this.pbItem.Location = new System.Drawing.Point(94, 138);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(50, 50);
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // pbGrade
            // 
            this.pbGrade.BackColor = System.Drawing.Color.Transparent;
            this.pbGrade.Location = new System.Drawing.Point(160, 137);
            this.pbGrade.Name = "pbGrade";
            this.pbGrade.Size = new System.Drawing.Size(50, 50);
            this.pbGrade.TabIndex = 1;
            this.pbGrade.TabStop = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbStatus.Location = new System.Drawing.Point(102, 31);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(132, 37);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Success!";
            // 
            // lbGradec
            // 
            this.lbGradec.AutoSize = true;
            this.lbGradec.BackColor = System.Drawing.Color.Transparent;
            this.lbGradec.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGradec.Location = new System.Drawing.Point(105, 201);
            this.lbGradec.Name = "lbGradec";
            this.lbGradec.Size = new System.Drawing.Size(39, 19);
            this.lbGradec.TabIndex = 3;
            this.lbGradec.Text = "Test";
            // 
            // lbGrade1
            // 
            this.lbGrade1.AutoSize = true;
            this.lbGrade1.BackColor = System.Drawing.Color.Transparent;
            this.lbGrade1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade1.Location = new System.Drawing.Point(125, 87);
            this.lbGrade1.Name = "lbGrade1";
            this.lbGrade1.Size = new System.Drawing.Size(39, 19);
            this.lbGrade1.TabIndex = 4;
            this.lbGrade1.Text = "Test";
            // 
            // lbGrade2
            // 
            this.lbGrade2.AutoSize = true;
            this.lbGrade2.BackColor = System.Drawing.Color.Transparent;
            this.lbGrade2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade2.Location = new System.Drawing.Point(189, 87);
            this.lbGrade2.Name = "lbGrade2";
            this.lbGrade2.Size = new System.Drawing.Size(39, 19);
            this.lbGrade2.TabIndex = 5;
            this.lbGrade2.Text = "Test";
            // 
            // EnchantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(368, 289);
            this.Controls.Add(this.lbGrade2);
            this.Controls.Add(this.lbGrade1);
            this.Controls.Add(this.lbGradec);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.pbGrade);
            this.Controls.Add(this.pbItem);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnchantForm";
            this.Text = "Enchant Info";
            this.Deactivate += new System.EventHandler(this.EnchantForm_Deactivate);
            this.Load += new System.EventHandler(this.EnchantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.PictureBox pbGrade;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbGradec;
        private System.Windows.Forms.Label lbGrade1;
        private System.Windows.Forms.Label lbGrade2;
    }
}