namespace Graphic_Snake
{
    partial class Gra_Form
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
            this.playingField = new System.Windows.Forms.PictureBox();
            this.wynikGracza = new System.Windows.Forms.Label();
            this.najlepszyWynik = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playingField)).BeginInit();
            this.SuspendLayout();
            // 
            // playingField
            // 
            this.playingField.BackColor = System.Drawing.Color.Black;
            this.playingField.Location = new System.Drawing.Point(12, 12);
            this.playingField.Name = "playingField";
            this.playingField.Size = new System.Drawing.Size(649, 793);
            this.playingField.TabIndex = 0;
            this.playingField.TabStop = false;
            this.playingField.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // wynikGracza
            // 
            this.wynikGracza.AutoSize = true;
            this.wynikGracza.BackColor = System.Drawing.Color.Gray;
            this.wynikGracza.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.wynikGracza.ForeColor = System.Drawing.Color.Green;
            this.wynikGracza.Location = new System.Drawing.Point(711, 186);
            this.wynikGracza.Name = "wynikGracza";
            this.wynikGracza.Size = new System.Drawing.Size(86, 25);
            this.wynikGracza.TabIndex = 1;
            this.wynikGracza.Text = "Score: 0";
            // 
            // najlepszyWynik
            // 
            this.najlepszyWynik.AutoSize = true;
            this.najlepszyWynik.BackColor = System.Drawing.Color.Gray;
            this.najlepszyWynik.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.najlepszyWynik.ForeColor = System.Drawing.Color.Green;
            this.najlepszyWynik.Location = new System.Drawing.Point(711, 253);
            this.najlepszyWynik.Name = "najlepszyWynik";
            this.najlepszyWynik.Size = new System.Drawing.Size(119, 25);
            this.najlepszyWynik.TabIndex = 2;
            this.najlepszyWynik.Text = "High Score: ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Gra_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(879, 863);
            this.Controls.Add(this.najlepszyWynik);
            this.Controls.Add(this.wynikGracza);
            this.Controls.Add(this.playingField);
            this.Name = "Gra_Form";
            this.Text = "Gra_Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.playingField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playingField;
        private System.Windows.Forms.Label wynikGracza;
        private System.Windows.Forms.Label najlepszyWynik;
        private System.Windows.Forms.Timer timer;
    }
}

