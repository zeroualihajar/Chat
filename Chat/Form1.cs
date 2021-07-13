using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        serv.sws_chatSoapClient srvChat = new serv.sws_chatSoapClient();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnParticiper_Click(object sender, EventArgs e)
        {
            bool etat = srvChat.Participer(txtPseudo.Text);
            serv.participant[] participants = srvChat.Participants().ToArray();
            serv.Message[] messages = srvChat.Messages().ToArray();

            if (etat)
            {
                lblChangePseudo.Visible = false;
                Salon salon = new Salon(txtPseudo.Text, participants, messages);
                salon.Visible = true;

                this.Hide();
            }
            else
            {
                lblChangePseudo.Text = "Ce pseudo existe deja! \n essayer de le changer";
                lblChangePseudo.Visible = true;
            }
        }
    }
}
