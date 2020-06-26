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
    public partial class ChangeSeatForm : Form
    {
        public ChangeSeatForm()
        {
            InitializeComponent();
        }

        MemberWithoutPurchased memberwithoutpurchased;
        MemberWithPurchased memberwithpurchased;
        ArrayList flightlist = new ArrayList();
        public void receive_info(ArrayList memberlist)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist[memberlist.Count - 1];
            //MessageBox.Show(memberwithoutpurchased.Name);
        }
        private void btnChangeSeat_Click(object sender, EventArgs e)
        {
            if (rbnSABAH.Checked)
            {
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

                            if (memberwithoutpurchased.Name == name && flight_purchased == "KLIA2 - KOTAKINABALU (SABAH)")
                            {
                                flightlist.Add(new MemberWithPurchased(name, ic, email, gender, id, password, flight_purchased, seat, Convert.ToDouble(total), date, time, Convert.ToInt32(get_points)));
                                memberwithpurchased = (MemberWithPurchased)flightlist[flightlist.Count - 1];
                            }
                            name = reader.ReadLine();

                        } while ((name = reader.ReadLine()) != null);

                        reader.Close();

                        if (memberwithpurchased.Flight_purchased == "KLIA2 - KOTAKINABALU (SABAH)")
                        {
                            ArrayList memberlist = new ArrayList();
                            memberlist.Add(memberwithoutpurchased);

                            SabahSeatForm sabah = new SabahSeatForm();
                            sabah.receive_info3(memberlist);
                            sabah.receive_seat_info(flightlist);
                            sabah.btnChangeSeat.Visible = true;
                            sabah.ShowDialog();
                            //break;
                        }

                        else
                        {
                            MessageBox.Show("You didn't bought any ticket of this Flight!");
                        }
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

            if (rbnSARAWAK.Checked)
            {
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

                            if (memberwithoutpurchased.Name == name && flight_purchased == "KLIA2 - KUCHING (SARAWAK)")
                            {
                                flightlist.Add(new MemberWithPurchased(name, ic, email, gender, id, password, flight_purchased, seat, Convert.ToDouble(total), date, time, Convert.ToInt32(get_points)));
                                memberwithpurchased = (MemberWithPurchased)flightlist[flightlist.Count - 1];
                            }
                            name = reader.ReadLine();

                        } while ((name = reader.ReadLine()) != null);

                        reader.Close();

                        if (memberwithpurchased.Flight_purchased == "KLIA2 - KUCHING (SARAWAK)")
                        {
                            ArrayList memberlist = new ArrayList();
                            memberlist.Add(memberwithoutpurchased);

                            SarawakSeatForm sarawak = new SarawakSeatForm();
                            sarawak.receive_info(memberlist);
                            sarawak.receive_seat_info(flightlist);
                            sarawak.btnChangeSeat.Visible = true;
                            sarawak.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("You didn't bought any ticket of this Flights!");
                        }
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

            if (rbnKEDAH.Checked)
            {
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

                            if (memberwithoutpurchased.Name == name && flight_purchased == "KLIA2 - LANGKAWI (KEDAH)")
                            {
                                flightlist.Add(new MemberWithPurchased(name, ic, email, gender, id, password, flight_purchased, seat, Convert.ToDouble(total), date, time, Convert.ToInt32(get_points)));
                                memberwithpurchased = (MemberWithPurchased)flightlist[flightlist.Count - 1];
                            }
                            name = reader.ReadLine();

                        } while ((name = reader.ReadLine()) != null);

                        reader.Close();

                        if (memberwithpurchased.Flight_purchased == "KLIA2 - LANGKAWI (KEDAH)")
                        {
                            ArrayList memberlist = new ArrayList();
                            memberlist.Add(memberwithoutpurchased);

                            KedahSeatForm kedah = new KedahSeatForm();
                            kedah.receive_info(memberlist);
                            kedah.receive_seat_info(flightlist);
                            kedah.btnChangeSeat.Visible = true;
                            kedah.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("You didn't bought any ticket of this Flights!");
                        }
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
}
