
namespace Chat
{
    partial class Salon
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
            this.flowMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.flowParticipant = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblpa = new System.Windows.Forms.Label();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowMessage
            // 
            this.flowMessage.AutoScroll = true;
            this.flowMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowMessage.Location = new System.Drawing.Point(17, 42);
            this.flowMessage.Margin = new System.Windows.Forms.Padding(2);
            this.flowMessage.Name = "flowMessage";
            this.flowMessage.Size = new System.Drawing.Size(403, 314);
            this.flowMessage.TabIndex = 0;
            // 
            // flowParticipant
            // 
            this.flowParticipant.AutoScroll = true;
            this.flowParticipant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowParticipant.Location = new System.Drawing.Point(434, 38);
            this.flowParticipant.Margin = new System.Windows.Forms.Padding(2);
            this.flowParticipant.Name = "flowParticipant";
            this.flowParticipant.Size = new System.Drawing.Size(167, 314);
            this.flowParticipant.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitter.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(513, 406);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(88, 29);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblpa
            // 
            this.lblpa.AutoSize = true;
            this.lblpa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblpa.Location = new System.Drawing.Point(470, 13);
            this.lblpa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpa.Name = "lblpa";
            this.lblpa.Size = new System.Drawing.Size(100, 23);
            this.lblpa.TabIndex = 3;
            this.lblpa.Text = "Participant";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEnvoyer.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnEnvoyer.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyer.Location = new System.Drawing.Point(513, 373);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(88, 29);
            this.btnEnvoyer.TabIndex = 4;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTxt.Location = new System.Drawing.Point(17, 373);
            this.messageTxt.Margin = new System.Windows.Forms.Padding(2);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(488, 62);
            this.messageTxt.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Disccussion";
            // 
            // Salon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(620, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.lblpa);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.flowParticipant);
            this.Controls.Add(this.flowMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Salon";
            this.Text = "Salon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowMessage;
        private System.Windows.Forms.FlowLayoutPanel flowParticipant;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblpa;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}