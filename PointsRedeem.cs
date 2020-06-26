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
    public partial class PointsRedeemForm : Form
    {
        public PointsRedeemForm()
        {
            InitializeComponent();
        }

        MemberWithoutPurchased memberwithoutpurchased;
        ArrayList memberlist2 = new ArrayList();
        public void receive_info(ArrayList memberlist)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist[memberlist.Count - 1];
        }
 
        private void btnRedeem_Click(object sender, EventArgs e)
        {
            if (memberwithoutpurchased.Points < 400)
            {
                MessageBox.Show("Your bonus points must be 400 or above to redeem a HOT/STANDARD Flight seats ticket");
            }

            else
            {
                if (rbnSABAH.Checked)
                {
                    SabahSeatForm sabah = new SabahSeatForm();
                    sabah.receive_info2(memberlist2);
                    sabah.btnRedeem.Visible = true;
                    sabah.ShowDialog();
                }
                if (rbnSARAWAK.Checked)
                {
                    SarawakSeatForm sarawak = new SarawakSeatForm();
                    sarawak.receive_info2(memberlist2);
                    sarawak.btnRedeem.Visible = true;
                    sarawak.ShowDialog();
                }
                if (rbnKEDAH.Checked)
                {
                    KedahSeatForm kedah = new KedahSeatForm();
                    kedah.receive_info2(memberlist2);
                    kedah.btnRedeem.Visible = true;
                    kedah.ShowDialog();
                }
            }

        }

        private void PointsRedeemForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Member.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("Member.txt");

                    string name, ic, email, gender, id, password;
                    string points;

                    name = reader.ReadLine();
                    do
                    {
                        ic = reader.ReadLine();
                        email = reader.ReadLine();
                        gender = reader.ReadLine();
                        id = reader.ReadLine();
                        password = reader.ReadLine();
                        points = reader.ReadLine();

                        if (id == memberwithoutpurchased.Id)
                        {
                            memberlist2.Add(new MemberWithoutPurchased(name, ic, email, gender, id, password, Convert.ToInt32(points)));

                            memberwithoutpurchased = (MemberWithoutPurchased)memberlist2[memberlist2.Count - 1];

                            lblPoints.Text += " " + Convert.ToString(points);
                        }
                        name = reader.ReadLine();

                    } while ((name = reader.ReadLine()) != null);

                    reader.Close();

                }
                catch (IOException exc)
                {
                    MessageBox.Show("File error:" + exc.Message);
                }
            }

            else
            {
                MessageBox.Show("File does not exists.");
            }
        }
    }
}
