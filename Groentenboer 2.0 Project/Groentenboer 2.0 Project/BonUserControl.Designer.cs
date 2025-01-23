namespace Groentenboer_2._0_Project
{
    partial class BonUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AantalTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AantalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BonImages = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BonImages)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AantalTxt
            // 
            this.AantalTxt.AutoSize = true;
            this.AantalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalTxt.Location = new System.Drawing.Point(220, 52);
            this.AantalTxt.Name = "AantalTxt";
            this.AantalTxt.Size = new System.Drawing.Size(64, 25);
            this.AantalTxt.TabIndex = 0;
            this.AantalTxt.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // AantalLabel
            // 
            this.AantalLabel.AutoSize = true;
            this.AantalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalLabel.Location = new System.Drawing.Point(220, 23);
            this.AantalLabel.Name = "AantalLabel";
            this.AantalLabel.Size = new System.Drawing.Size(74, 25);
            this.AantalLabel.TabIndex = 2;
            this.AantalLabel.Text = "Aantal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prijs";
            // 
            // BonImages
            // 
            this.BonImages.Location = new System.Drawing.Point(39, 3);
            this.BonImages.Name = "BonImages";
            this.BonImages.Size = new System.Drawing.Size(112, 105);
            this.BonImages.TabIndex = 4;
            this.BonImages.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "€";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(345, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 36);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // BonUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BonImages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AantalLabel);
            this.Controls.Add(this.AantalTxt);
            this.Name = "BonUserControl";
            this.Size = new System.Drawing.Size(492, 143);
            ((System.ComponentModel.ISupportInitialize)(this.BonImages)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AantalTxt;
        private System.Windows.Forms.Label AantalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BonImages;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
