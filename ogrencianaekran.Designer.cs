
namespace _6SigmaileSınavSistemi_MehmetKaanALTUN_
{
    partial class ogrencianaekran
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
            this.button4 = new System.Windows.Forms.Button();
            this.label216 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelhocanum = new System.Windows.Forms.Label();
            this.labelhocaadi = new System.Windows.Forms.Label();
            this.button_kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(12, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(333, 39);
            this.button4.TabIndex = 38;
            this.button4.Text = "Sınava Gir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label216
            // 
            this.label216.AutoSize = true;
            this.label216.BackColor = System.Drawing.Color.Transparent;
            this.label216.Cursor = System.Windows.Forms.Cursors.Default;
            this.label216.Font = new System.Drawing.Font("Algerian", 40F, System.Drawing.FontStyle.Italic);
            this.label216.Location = new System.Drawing.Point(2, 18);
            this.label216.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(569, 60);
            this.label216.TabIndex = 41;
            this.label216.Text = "CIGULI SINAV SISTEMI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(564, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "Öğretmen Kodunuz :";
            // 
            // labelhocanum
            // 
            this.labelhocanum.AutoSize = true;
            this.labelhocanum.BackColor = System.Drawing.Color.Transparent;
            this.labelhocanum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelhocanum.Location = new System.Drawing.Point(708, 53);
            this.labelhocanum.Name = "labelhocanum";
            this.labelhocanum.Size = new System.Drawing.Size(94, 14);
            this.labelhocanum.TabIndex = 44;
            this.labelhocanum.Text = "labelhocanum";
            // 
            // labelhocaadi
            // 
            this.labelhocaadi.AutoSize = true;
            this.labelhocaadi.BackColor = System.Drawing.Color.Transparent;
            this.labelhocaadi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelhocaadi.Location = new System.Drawing.Point(650, 18);
            this.labelhocaadi.Name = "labelhocaadi";
            this.labelhocaadi.Size = new System.Drawing.Size(86, 14);
            this.labelhocaadi.TabIndex = 43;
            this.labelhocaadi.Text = "labelhocaadi";
            // 
            // button_kayit
            // 
            this.button_kayit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_kayit.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayit.Location = new System.Drawing.Point(567, 9);
            this.button_kayit.Name = "button_kayit";
            this.button_kayit.Size = new System.Drawing.Size(83, 31);
            this.button_kayit.TabIndex = 46;
            this.button_kayit.Text = "Çıkış Yap";
            this.button_kayit.UseVisualStyleBackColor = false;
            this.button_kayit.Click += new System.EventHandler(this.button_kayit_Click);
            // 
            // ogrencianaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_kayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelhocanum);
            this.Controls.Add(this.labelhocaadi);
            this.Controls.Add(this.label216);
            this.Controls.Add(this.button4);
            this.Name = "ogrencianaekran";
            this.Text = "ogrencianaekran";
            this.Load += new System.EventHandler(this.ogrencianaekran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelhocanum;
        private System.Windows.Forms.Label labelhocaadi;
        private System.Windows.Forms.Button button_kayit;
    }
}