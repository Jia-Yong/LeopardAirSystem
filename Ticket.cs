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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }
        MemberWithPurchased memberwithpurchased;
        public void receive_info(ArrayList flightlist)
        {
            memberwithpurchased = (MemberWithPurchased)flightlist[flightlist.Count - 1];
        }

        MemberWithoutPurchased memberwithoutpurchased;
        public void receive_info2(ArrayList memberlist)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist[memberlist.Count - 1];
            //MessageBox.Show(memberwithoutpurchased.Name);
        }

        int a = 0;
        public void receive_point(int i)
        {
            a = i;
        }


        private void TicketForm_Load(object sender, EventArgs e)
        {

            lbxTicket.Items.Add("<<< Your ticket >>>");
            lbxTicket.Items.Add("LEOPARD AIR FLIGHT TICKET");

            lbxTicket.Items.Add("\nName: \t\t\t" + memberwithpurchased.Name);
            lbxTicket.Items.Add("Email: \t\t\t" + memberwithpurchased.Email);
            lbxTicket.Items.Add("Flight: \t\t\t" + memberwithpurchased.Flight_purchased);
            lbxTicket.Items.Add("Seat: \t\t\t" + memberwithpurchased.Flight_seat);
            lbxTicket.Items.Add("Total: \t\t\tRM" + memberwithpurchased.Total_purchased);
            lbxTicket.Items.Add("Date purchased: \t\t" + memberwithpurchased.Date_purchased);
            lbxTicket.Items.Add("Time purchased: \t\t" + memberwithpurchased.Time_purchased);
            lbxTicket.Items.Add("Bonus points: \t\t" + memberwithpurchased.Points + " points");

            ArrayList memberlist = new ArrayList();
            ArrayList flightlist = new ArrayList();

            if (File.Exists("Member.txt"))  // member
            {

                try
                {
                    StreamReader reader = new StreamReader("Member.txt");

                    string name, ic, email, gender, id, password, points;

                    name = reader.ReadLine();
                    do
                    {
                        ic = reader.ReadLine();
                        email = reader.ReadLine();
                        gender = reader.ReadLine();
                        id = reader.ReadLine();
                        password = reader.ReadLine();
                        points = reader.ReadLine();

                        memberlist.Add(new MemberWithoutPurchased(name, ic, email, gender, id, password, Convert.ToInt32(points)));

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

            int index = -1;
            for (int i = 0; i < memberlist.Count; i++)
            {
                MemberWithoutPurchased memberwithoutpurchased = (MemberWithoutPurchased)memberlist[i];
                if (memberwithpurchased.Name == memberwithoutpurchased.Name)
                {
                    index = i;
                    break;
                }

            }

            try
            {
                StreamWriter writer = new StreamWriter("Member.txt");

                for (int i = 0; i < memberlist.Count; i++)
                {
                    MemberWithoutPurchased memberwithoutpurchased = (MemberWithoutPurchased)memberlist[i];

                    writer.WriteLine(memberwithoutpurchased.Name);
                    writer.WriteLine(memberwithoutpurchased.Ic);
                    writer.WriteLine(memberwithoutpurchased.Email);
                    writer.WriteLine(memberwithoutpurchased.Gender);
                    writer.WriteLine(memberwithoutpurchased.Id);
                    writer.WriteLine(memberwithoutpurchased.Password);
                    if (i == index)
                        writer.WriteLine(Convert.ToString(Convert.ToInt32(memberwithoutpurchased.Points) +
                                            Convert.ToInt32(memberwithpurchased.Points)));
                    else
                        writer.WriteLine(memberwithoutpurchased.Points);
                    writer.WriteLine(" ");
                }

                writer.Close();

            }

            catch (IOException exc)
            {
                MessageBox.Show("File error:" + exc.Message);
            }
            
            ArrayList allflightlist = new ArrayList();

            if (a == 1)
            {
                if (File.Exists("Location.txt"))
                {

                    try
                    {
                        StreamReader reader = new StreamReader("Location.txt");

                        string name, ic, email, gender, id, password, flight_purchased, seat, total, date, time, points;

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
                            points = reader.ReadLine();

                            allflightlist.Add(new MemberWithPurchased(name, ic, email, gender, id, password, flight_purchased, seat, Convert.ToDouble(total), date, time, Convert.ToInt32(points)));

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

                int a = -1;
                int count = allflightlist.Count;
                for (int i = 0; i < count; i++)
                {
                    MemberWithPurchased allmemberwithpurchased = (MemberWithPurchased)allflightlist[i];
                    if (allmemberwithpurchased.Name == memberwithoutpurchased.Name && allmemberwithpurchased.Flight_purchased == memberwithpurchased.Flight_purchased)
                    {
                        a = i;
                        break;
                    }

                }

                try
                {
                    StreamWriter writer = new StreamWriter("Location.txt");

                    for (int i = 0; i < allflightlist.Count; i++)
                    {
                        MemberWithPurchased allmemberwithpurchased = (MemberWithPurchased)allflightlist[i];

                        writer.WriteLine(allmemberwithpurchased.Name);
                        writer.WriteLine(allmemberwithpurchased.Ic);
                        writer.WriteLine(allmemberwithpurchased.Email);
                        writer.WriteLine(allmemberwithpurchased.Gender);
                        writer.WriteLine(allmemberwithpurchased.Id);
                        writer.WriteLine(allmemberwithpurchased.Password);
                        writer.WriteLine(allmemberwithpurchased.Flight_purchased);

                        if (i == a)
                        {
                            writer.WriteLine(memberwithpurchased.Flight_seat);
                        }

                        else
                        {
                            writer.WriteLine(allmemberwithpurchased.Flight_seat);
                        }

                        writer.WriteLine(allmemberwithpurchased.Total_purchased);
                        writer.WriteLine(allmemberwithpurchased.Date_purchased);
                        writer.WriteLine(allmemberwithpurchased.Time_purchased);
                        writer.WriteLine(memberwithpurchased.Points);
                        writer.WriteLine(" ");
                    }

                    writer.Close();

                }

                catch (IOException exc)
                {
                    MessageBox.Show("File error:" + exc.Message);
                }
            }

            else
            {
                try
                {
                    StreamWriter writer = new StreamWriter("Location.txt", true);

                    writer.WriteLine(memberwithpurchased.Name);
                    writer.WriteLine(memberwithpurchased.Ic);
                    writer.WriteLine(memberwithpurchased.Email);
                    writer.WriteLine(memberwithpurchased.Gender);
                    writer.WriteLine(memberwithpurchased.Id);
                    writer.WriteLine(memberwithpurchased.Password);
                    writer.WriteLine(memberwithpurchased.Flight_purchased);
                    writer.WriteLine(memberwithpurchased.Flight_seat);
                    writer.WriteLine(memberwithpurchased.Total_purchased);
                    writer.WriteLine(memberwithpurchased.Date_purchased);
                    writer.WriteLine(memberwithpurchased.Time_purchased);
                    writer.WriteLine(memberwithpurchased.Points);
                    writer.WriteLine("");

                    writer.Close();


                }

                catch (IOException exc)
                {
                    Console.WriteLine("File error: " + exc.Message);
                }

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            MessageBox.Show("Your seat(s) is booked and Flight ticket is printed successfully.");
            Close();
            
        }
    }
}
