using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rfid1Base
{
    public partial class CRfid : Form
    {
        public CRfid()
        {
            InitializeComponent();

            this.m_serialPortRfid.Open();
            Control.CheckForIllegalCrossThreadCalls = false;

            private int LectureNumeroCarte()
        {
            // Récupération des 12 octets avec ReadExisting :
            string l_trame = this.m_serialPortRfid.ReadExisting();
            int l_numeroCarte;
            string l_dernierOctets = l_trame.Substring(7, 4);
            l_numeroCarte = Int32.Parse(l_dernierOctets, System.Globalization.NumberStyles.HexNumber);
            return l_numeroCarte;
        }

        private void m_serialPortRfid_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
    }
}
