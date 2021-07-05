using Chat.UC;
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
    public partial class Salon : Form
    {
        serv.sws_chatSoapClient srvChat = new serv.sws_chatSoapClient();
        public string pseudo { get; set; }

        public int inc;

        public List<serv.participant> participants { get; set; }
        public List<serv.Message> messages { get; set; }

        public Salon()
        {
            InitializeComponent();
            timer1.Start();
        }

        public Salon(string ps, serv.participant[] parts, serv.Message[] msg)
        {
            InitializeComponent();

            pseudo = ps;
            participants = parts.ToList();
            messages = msg.ToList();
            Text = "Vous avez le pseudo " + pseudo;

            afficher(pseudo);
            timer1.Start();
        }

        public void afficher(string ps)
        {
            flowParticipant.Controls.Clear();
            foreach (var p in participants)
            {
                if (p.pseudo != ps)
                {
                    ucParticipant uc = new ucParticipant();
                    uc.pseudo = p.pseudo;
                    flowParticipant.Controls.Add(uc);
                }

            }
            flowMessage.Controls.Clear();
            foreach (var p in messages)
            {
                ucMessage uc = new ucMessage();
                uc.pseudo = srvChat.getParticipantById((int)p.idparticipant) + " : ";
                uc.message = p.contenu;
                flowMessage.Controls.Add(uc);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            int id = srvChat.getParticipantByPseudo(pseudo);
            srvChat.DeleteParticipants(pseudo, id);

            Form1 form = new Form1();
            form.Visible = true;

            this.Hide();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string message = messageTxt.Text;

            int id = srvChat.getParticipantByPseudo(pseudo);

            srvChat.InsertMessage(message, id);

            reload_again();
        }

        public void afficherMessage()
        {
            serv.Message[] messages = srvChat.Messages().ToArray();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            inc++;
            if (inc % 10 == 0)
            {
                reload_again();
            }

        }
        public serv.participant[] GetPr()
        {
            serv.participant[] participants = srvChat.Participants().ToArray();
            return participants;
        }
        public serv.Message[] GetMes()
        {
            serv.Message[] messages = srvChat.Messages().ToArray();
            return messages;
        }

        public void reload_again()
        {
            List<serv.participant> prts = GetPr().ToList();
            List<serv.Message> msgs = GetMes().ToList();

            flowParticipant.Controls.Clear();
            foreach (var p in prts)
            {
                if (p.pseudo != pseudo)
                {
                    ucParticipant uc = new ucParticipant();
                    uc.pseudo = p.pseudo;
                    flowParticipant.Controls.Add(uc);
                }

            }
            flowMessage.Controls.Clear();
            foreach (var p in msgs)
            {
                ucMessage uc = new ucMessage();
                uc.pseudo = srvChat.getParticipantById((int)p.idparticipant) + " : ";
                uc.message = p.contenu;
                flowMessage.Controls.Add(uc);
            }
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            inc++;
            if (inc % 20 == 0)
            {
                reload_again();
            }
        }
    }
}
