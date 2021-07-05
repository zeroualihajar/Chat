
namespace Chat.UC
{
    partial class ucMessage
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
            this.lblParticipant = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipant.Location = new System.Drawing.Point(11, 34);
            this.lblParticipant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(49, 19);
            this.lblParticipant.TabIndex = 0;
            this.lblParticipant.Text = "label1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMessage.Location = new System.Drawing.Point(90, 34);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(45, 19);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "label2";
            // 
            // ucMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblParticipant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucMessage";
            this.Size = new System.Drawing.Size(399, 78);
            this.Load += new System.EventHandler(this.ucMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.Label lblMessage;
    }
}
