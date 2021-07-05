
namespace Chat
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnParticiper = new System.Windows.Forms.Button();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChangePseudo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParticiper
            // 
            this.btnParticiper.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnParticiper.Font = new System.Drawing.Font("Palatino Linotype", 16.2F);
            this.btnParticiper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnParticiper.Location = new System.Drawing.Point(299, 303);
            this.btnParticiper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParticiper.Name = "btnParticiper";
            this.btnParticiper.Size = new System.Drawing.Size(135, 37);
            this.btnParticiper.TabIndex = 13;
            this.btnParticiper.Text = "Participer";
            this.btnParticiper.UseVisualStyleBackColor = false;
            this.btnParticiper.Click += new System.EventHandler(this.btnParticiper_Click);
            // 
            // txtPseudo
            // 
            this.txtPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPseudo.Font = new System.Drawing.Font("Palatino Linotype", 16.2F);
            this.txtPseudo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPseudo.Location = new System.Drawing.Point(52, 220);
            this.txtPseudo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(260, 37);
            this.txtPseudo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ajouter votre Pseudo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Chat.Properties.Resources.addframe;
            this.pictureBox2.Location = new System.Drawing.Point(32, 73);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 279);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(117, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chat Room";
            // 
            // lblChangePseudo
            // 
            this.lblChangePseudo.AutoSize = true;
            this.lblChangePseudo.Font = new System.Drawing.Font("Palatino Linotype", 16.2F);
            this.lblChangePseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblChangePseudo.Location = new System.Drawing.Point(52, 303);
            this.lblChangePseudo.Name = "lblChangePseudo";
            this.lblChangePseudo.Size = new System.Drawing.Size(0, 29);
            this.lblChangePseudo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(468, 362);
            this.Controls.Add(this.lblChangePseudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnParticiper);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Chat Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnParticiper;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChangePseudo;
    }
}

