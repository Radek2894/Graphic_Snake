namespace Graphic_Snake
{
    partial class Autor_Form
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
            System.Windows.Forms.Label Tworca;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            Tworca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Graphic_Snake.Properties.Resources.Biggie_Cheese;
            this.pictureBox1.Location = new System.Drawing.Point(230, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tworca
            // 
            Tworca.AutoSize = true;
            Tworca.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold);
            Tworca.ForeColor = System.Drawing.Color.Green;
            Tworca.Location = new System.Drawing.Point(359, 471);
            Tworca.Name = "Tworca";
            Tworca.Size = new System.Drawing.Size(145, 45);
            Tworca.TabIndex = 1;
            Tworca.Text = "Twórca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(172, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radosław Filewicz";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Green;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(322, 647);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(231, 50);
            this.back.TabIndex = 8;
            this.back.Text = "Powrót";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Autor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 863);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(Tworca);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Autor_Form";
            this.Text = "Autor_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}