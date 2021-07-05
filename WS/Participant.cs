using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class Participant
    {
        public int idParticipant { get; set; }
        public string pseudo { get; set; }

        public Participant(string pseudo)
        {
            this.pseudo = pseudo;
        }

        public Participant()
        {

        }
    }
}