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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        MemberWithoutPurchased memberwithoutpurchased;
        MemberWithPurchased memberwithpurchased;

        public void receive_info(ArrayList memberlist)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist[memberlist.Count - 1];
        }
        private void btnbookflight_Click(object sender, EventArgs e)
        {           
            ArrayList memberlist = new ArrayList();
            memberlist.Add(memberwithoutpurchased);

            FlightForm allflight = new FlightForm();
            allflight.receive_info(memberlist);
            allflight.Show();
        }

        
        private void btnReedem_Click(object sender, EventArgs e)
        {
            ArrayList memberlist = new ArrayList();
            memberlist.Add(memberwithoutpurchased);

            PointsRedeemForm pointsredeem = new PointsRedeemForm();
            pointsredeem.receive_info(memberlist);
            pointsredeem.Show();
        }


        private void btnChangeSeat_Click(object sender, EventArgs e)
        {
            ArrayList memberlist = new ArrayList();
            ArrayList flightlist = new ArrayList();
            bool file = false;
            memberlist.Add(memberwithoutpurchased);

            if (File.Exists("Location.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("Location.txt");

                    string name, ic, email, gender, id, password, flight_purchased, seat, total, date, time, get_points;

                    name = reader.ReadLine();
                    do
                    {
                        ic = reader.ReadLine();
                        email = reader.ReadLine();
                        gender = reader.ReadLine();
                        id = reader.ReadLine();
                        password = reader.ReadLine();
                        flight_purchased = reader.ReadLine();
                        seat = reader.ReadLine();
                        total = reader.ReadLine();
                        date = reader.ReadLine();
                        time = reader.ReadLine();
                        get_points = reader.ReadLine();

                        if (memberwithoutpurchased.Name == name)
                        {
                            flightlist.Add(new MemberWithPurchased(name, ic, email, gender, id, password, flight_purchased, seat, Convert.ToDouble(total), date, time, Convert.ToInt32(get_points)));
                            memberwithpurchased = (MemberWithPurchased)flightlist[flightlist.Count - 1];
                            file = true;
                        }
                        name = reader.ReadLine();

                    } while ((name = reader.ReadLine()) != null);

                    reader.Close();
                }

                catch (IOException exc)
                {
                    MessageBox.Show("File error:" + exc.Message);
                }
                
                if(file == true)
                {
                    ChangeSeatForm changeseat = new ChangeSeatForm();
                    changeseat.receive_info(memberlist);
                    changeseat.Show();
                }

                else
                {
                    MessageBox.Show("You haven't bought any flight ticket yet!");
                }
            }
        }


        private void btnRedeem_Click(object sender, EventArgs e)
        {
            ArrayList memberlist = new ArrayList();
            memberlist.Add(memberwithoutpurchased);

            PointsRedeemForm pointsredeeem = new PointsRedeemForm();
            pointsredeeem.receive_info(memberlist);
            pointsredeeem.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("You have logged out.");
            StartForm start = new StartForm();
            start.Show();
        }

    }
}
