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
    public partial class ucParticipant : UserControl
    {
        public string pseudo { get; set; }
        public ucParticipant()
        {
            InitializeComponent();
        }

        private void ucParticipant_Load(object sender, EventArgs e)
        {
            lblParticiapnt.Text = pseudo;
        }
    }
}
