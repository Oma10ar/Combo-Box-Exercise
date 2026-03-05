namespace Combo_Box_Exercise
{
    partial class frmBox
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitlePicture = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(220, 100);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(280, 273);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "change Picture : ";
            // 
            // lblTitlePicture
            // 
            this.lblTitlePicture.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitlePicture.Location = new System.Drawing.Point(207, 9);
            this.lblTitlePicture.Name = "lblTitlePicture";
            this.lblTitlePicture.Size = new System.Drawing.Size(309, 75);
            this.lblTitlePicture.TabIndex = 2;
            this.lblTitlePicture.Text = "Let\'s Start";
            this.lblTitlePicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Book",
            "Girl",
            "Boy",
            "Pen"});
            this.cb1.Location = new System.Drawing.Point(364, 393);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(166, 24);
            this.cb1.TabIndex = 3;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // frmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lblTitlePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb1);
            this.Name = "frmBox";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitlePicture;
        private System.Windows.Forms.ComboBox cb1;
    }
}

