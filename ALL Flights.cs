using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEOPARDAIR_SYSTEM
{
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
            this.label20.BackColor = System.Drawing.Color.Transparent;
        }

        MemberWithoutPurchased memberwithoutpurchased;
        public void receive_info(ArrayList memberlist)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist[memberlist.Count - 1];
        }

        private void btnSabah_Click(object sender, EventArgs e)
        {
            ArrayList memberlist = new ArrayList();
            memberlist.Add(memberwithoutpurchased);

            SabahSeatForm sabah = new SabahSeatForm();

            sabah.receive_info(memberlist);
            sabah.btnConfirm.Visible = true;
            sabah.ShowDialog();
        }

        private void btnSarawak_Click(object sender, EventArgs e)
        {
            ArrayList memberlist = new ArrayList();
            memberlist.Add(memberwithoutpurchased);

            SarawakSeatForm Sarawak = new SarawakSeatForm();
    
            Sarawak.receive_info(memberlist);
            Sarawak.btnConfirm.Visible = true;
            Sarawak.ShowDialog();
        }

        private void btnKedah_Click(object sender, EventArgs e)
        {
            ArrayList memberlist = new ArrayList();
            memberlist.Add(memberwithoutpurchased);

            KedahSeatForm Kedah = new KedahSeatForm();
            Kedah.btnConfirm.Visible = (true);
            Kedah.receive_info(memberlist);
            Kedah.ShowDialog();
        }

    }
}
