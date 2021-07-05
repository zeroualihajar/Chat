
namespace Chat.UC
{
    partial class ucParticipant
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblParticiapnt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParticiapnt
            // 
            this.lblParticiapnt.AutoSize = true;
            this.lblParticiapnt.Font = new System.Drawing.Font("Palatino Linotype", 16.2F);
            this.lblParticiapnt.Location = new System.Drawing.Point(61, 14);
            this.lblParticiapnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticiapnt.Name = "lblParticiapnt";
            this.lblParticiapnt.Size = new System.Drawing.Size(70, 29);
            this.lblParticiapnt.TabIndex = 0;
            this.lblParticiapnt.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chat.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ucParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblParticiapnt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucParticipant";
            this.Size = new System.Drawing.Size(146, 61);
            this.Load += new System.EventHandler(this.ucParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParticiapnt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
