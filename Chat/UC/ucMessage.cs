using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.UC
{
    public partial class ucMessage : UserControl
    {
        public string pseudo { get; set; }
        public string message { get; set; }
        public ucMessage()
        {
            InitializeComponent();

        }

        private void ucMessage_Load(object sender, EventArgs e)
        {
            lblParticipant.Text = pseudo;
            lblMessage.Text = message;
        }
    }
}
