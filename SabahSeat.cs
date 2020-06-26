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
    public partial class SabahSeatForm : Form
    {
        PictureBox[,] picBox = new PictureBox[30, 6];
        bool[,] seat_status = new bool[30, 6];

        private Bitmap available_icon = LEOPARDAIR.Properties.Resources.AVAILABLE;
        private Bitmap your_seat_icon = LEOPARDAIR.Properties.Resources.YOUR_SEAT;
        private Bitmap sold_icon = LEOPARDAIR.Properties.Resources.SOLD;
        private Bitmap hot_icon = LEOPARDAIR.Properties.Resources.HOT;

        public SabahSeatForm()
        {
            InitializeComponent();


            pictureBox181.Image = available_icon;
            pictureBox181.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox182.Image = your_seat_icon;
            pictureBox182.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox183.Image = sold_icon;
            pictureBox183.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox184.Image = hot_icon;
            pictureBox184.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox185.Image = hot_icon;
            pictureBox185.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int r = 0; r < 30; r++)
            {
                for (int c = 0; c < 6; c++)
                    seat_status[r, c] = false;
            }

            try
            {
                StreamReader reader = new StreamReader("Location.txt");

                string name, ic, email, gender, id, password, flight_purchased, seat_booked, total, time_purchased, date_purchased, get_point;

                name = reader.ReadLine();
                do
                {
                    int i = 0;

                    ic = reader.ReadLine();
                    email = reader.ReadLine();
                    gender = reader.ReadLine();
                    id = reader.ReadLine();
                    password = reader.ReadLine();
                    flight_purchased = reader.ReadLine();
                    seat_booked = reader.ReadLine();
                    total = reader.ReadLine();
                    date_purchased = reader.ReadLine();
                    time_purchased = reader.ReadLine();
                    get_point = reader.ReadLine();

                    if (flight_purchased == "KLIA2 - KOTAKINABALU (SABAH)")
                    {
                        while (i < seat_booked.Length || i + 1 < seat_booked.Length)
                        {
                            int a = (Convert.ToInt32(seat_booked.Substring(i , 1)) - 1 );
                            int b = (Convert.ToChar(seat_booked.Substring(i + 1, 1)) - 65);
                            seat_status[a, b] = true;
                            i += 3;
                        }
                    }

                    name = reader.ReadLine();

                } while ((name = reader.ReadLine()) != null);

                reader.Close();
            }
            catch (IOException exc)
            {
                MessageBox.Show("File error:" + exc.Message);
            }

            picBox[0, 0] = pictureBox1;
            picBox[0, 1] = pictureBox2;
            picBox[0, 2] = pictureBox3;
            picBox[0, 3] = pictureBox4;
            picBox[0, 4] = pictureBox5;
            picBox[0, 5] = pictureBox6;
            picBox[1, 0] = pictureBox7;
            picBox[1, 1] = pictureBox8;
            picBox[1, 2] = pictureBox9;
            picBox[1, 3] = pictureBox10;
            picBox[1, 4] = pictureBox11;
            picBox[1, 5] = pictureBox12;
            picBox[2, 0] = pictureBox13;
            picBox[2, 1] = pictureBox14;
            picBox[2, 2] = pictureBox15;
            picBox[2, 3] = pictureBox16;
            picBox[2, 4] = pictureBox17;
            picBox[2, 5] = pictureBox18;
            picBox[3, 0] = pictureBox19;
            picBox[3, 1] = pictureBox20;
            picBox[3, 2] = pictureBox21;
            picBox[3, 3] = pictureBox22;
            picBox[3, 4] = pictureBox23;
            picBox[3, 5] = pictureBox24;
            picBox[4, 0] = pictureBox25;
            picBox[4, 1] = pictureBox26;
            picBox[4, 2] = pictureBox27;
            picBox[4, 3] = pictureBox28;
            picBox[4, 4] = pictureBox29;
            picBox[4, 5] = pictureBox30;
            picBox[5, 0] = pictureBox31;
            picBox[5, 1] = pictureBox32;
            picBox[5, 2] = pictureBox33;
            picBox[5, 3] = pictureBox34;
            picBox[5, 4] = pictureBox35;
            picBox[5, 5] = pictureBox36;
            picBox[6, 0] = pictureBox37;
            picBox[6, 1] = pictureBox38;
            picBox[6, 2] = pictureBox39;
            picBox[6, 3] = pictureBox40;
            picBox[6, 4] = pictureBox41;
            picBox[6, 5] = pictureBox42;
            picBox[7, 0] = pictureBox43;
            picBox[7, 1] = pictureBox44;
            picBox[7, 2] = pictureBox45;
            picBox[7, 3] = pictureBox46;
            picBox[7, 4] = pictureBox47;
            picBox[7, 5] = pictureBox48;
            picBox[8, 0] = pictureBox49;
            picBox[8, 1] = pictureBox50;
            picBox[8, 2] = pictureBox51;
            picBox[8, 3] = pictureBox52;
            picBox[8, 4] = pictureBox53;
            picBox[8, 5] = pictureBox54;
            picBox[9, 0] = pictureBox55;
            picBox[9, 1] = pictureBox56;
            picBox[9, 2] = pictureBox57;
            picBox[9, 3] = pictureBox58;
            picBox[9, 4] = pictureBox59;
            picBox[9, 5] = pictureBox60;
            picBox[10, 0] = pictureBox61;
            picBox[10, 1] = pictureBox62;
            picBox[10, 2] = pictureBox63;
            picBox[10, 3] = pictureBox64;
            picBox[10, 4] = pictureBox65;
            picBox[10, 5] = pictureBox66;
            picBox[11, 0] = pictureBox67;
            picBox[11, 1] = pictureBox68;
            picBox[11, 2] = pictureBox69;
            picBox[11, 3] = pictureBox70;
            picBox[11, 4] = pictureBox71;
            picBox[11, 5] = pictureBox72;
            picBox[12, 0] = pictureBox73;
            picBox[12, 1] = pictureBox74;
            picBox[12, 2] = pictureBox75;
            picBox[12, 3] = pictureBox76;
            picBox[12, 4] = pictureBox77;
            picBox[12, 5] = pictureBox78;
            picBox[13, 0] = pictureBox79;
            picBox[13, 1] = pictureBox80;
            picBox[13, 2] = pictureBox81;
            picBox[13, 3] = pictureBox82;
            picBox[13, 4] = pictureBox83;
            picBox[13, 5] = pictureBox84;
            picBox[14, 0] = pictureBox85;
            picBox[14, 1] = pictureBox86;
            picBox[14, 2] = pictureBox87;
            picBox[14, 3] = pictureBox88;
            picBox[14, 4] = pictureBox89;
            picBox[14, 5] = pictureBox90;
            picBox[15, 0] = pictureBox91;
            picBox[15, 1] = pictureBox92;
            picBox[15, 2] = pictureBox93;
            picBox[15, 3] = pictureBox94;
            picBox[15, 4] = pictureBox95;
            picBox[15, 5] = pictureBox96;
            picBox[16, 0] = pictureBox97;
            picBox[16, 1] = pictureBox98;
            picBox[16, 2] = pictureBox99;
            picBox[16, 3] = pictureBox100;
            picBox[16, 4] = pictureBox101;
            picBox[16, 5] = pictureBox102;
            picBox[17, 0] = pictureBox103;
            picBox[17, 1] = pictureBox104;
            picBox[17, 2] = pictureBox105;
            picBox[17, 3] = pictureBox106;
            picBox[17, 4] = pictureBox107;
            picBox[17, 5] = pictureBox108;
            picBox[18, 0] = pictureBox109;
            picBox[18, 1] = pictureBox110;
            picBox[18, 2] = pictureBox111;
            picBox[18, 3] = pictureBox112;
            picBox[18, 4] = pictureBox113;
            picBox[18, 5] = pictureBox114;
            picBox[19, 0] = pictureBox115;
            picBox[19, 1] = pictureBox116;
            picBox[19, 2] = pictureBox117;
            picBox[19, 3] = pictureBox118;
            picBox[19, 4] = pictureBox119;
            picBox[19, 5] = pictureBox120;
            picBox[20, 0] = pictureBox121;
            picBox[20, 1] = pictureBox122;
            picBox[20, 2] = pictureBox123;
            picBox[20, 3] = pictureBox124;
            picBox[20, 4] = pictureBox125;
            picBox[20, 5] = pictureBox126;
            picBox[21, 0] = pictureBox127;
            picBox[21, 1] = pictureBox128;
            picBox[21, 2] = pictureBox129;
            picBox[21, 3] = pictureBox130;
            picBox[21, 4] = pictureBox131;
            picBox[21, 5] = pictureBox132;
            picBox[22, 0] = pictureBox133;
            picBox[22, 1] = pictureBox134;
            picBox[22, 2] = pictureBox135;
            picBox[22, 3] = pictureBox136;
            picBox[22, 4] = pictureBox137;
            picBox[22, 5] = pictureBox138;
            picBox[23, 0] = pictureBox139;
            picBox[23, 1] = pictureBox140;
            picBox[23, 2] = pictureBox141;
            picBox[23, 3] = pictureBox142;
            picBox[23, 4] = pictureBox143;
            picBox[23, 5] = pictureBox144;
            picBox[24, 0] = pictureBox145;
            picBox[24, 1] = pictureBox146;
            picBox[24, 2] = pictureBox147;
            picBox[24, 3] = pictureBox148;
            picBox[24, 4] = pictureBox149;
            picBox[24, 5] = pictureBox150;
            picBox[25, 0] = pictureBox151;
            picBox[25, 1] = pictureBox152;
            picBox[25, 2] = pictureBox153;
            picBox[25, 3] = pictureBox154;
            picBox[25, 4] = pictureBox155;
            picBox[25, 5] = pictureBox156;
            picBox[26, 0] = pictureBox157;
            picBox[26, 1] = pictureBox158;
            picBox[26, 2] = pictureBox159;
            picBox[26, 3] = pictureBox160;
            picBox[26, 4] = pictureBox161;
            picBox[26, 5] = pictureBox162;
            picBox[27, 0] = pictureBox163;
            picBox[27, 1] = pictureBox164;
            picBox[27, 2] = pictureBox165;
            picBox[27, 3] = pictureBox166;
            picBox[27, 4] = pictureBox167;
            picBox[27, 5] = pictureBox168;
            picBox[28, 0] = pictureBox169;
            picBox[28, 1] = pictureBox170;
            picBox[28, 2] = pictureBox171;
            picBox[28, 3] = pictureBox172;
            picBox[28, 4] = pictureBox173;
            picBox[28, 5] = pictureBox174;
            picBox[29, 0] = pictureBox175;
            picBox[29, 1] = pictureBox176;
            picBox[29, 2] = pictureBox177;
            picBox[29, 3] = pictureBox178;
            picBox[29, 4] = pictureBox179;
            picBox[29, 5] = pictureBox180;


            for (int r = 0; r < 30; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    ShowImage(picBox[r, c]);
                    if (seat_status[r, c] == true)
                        picBox[r, c].Image = sold_icon;
                }
            }
            for (int r = 0; r < 30; r++)
            {
                for (int c = 0; c < 6; c++)
                    picBox[r, c].Click += new System.EventHandler(PictureBox_Click);
            }
        }

        MemberWithoutPurchased memberwithoutpurchased;
        public void receive_info(ArrayList memberlist)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist[memberlist.Count - 1];
        }

        private void SabahSeatForm_Load(object sender, EventArgs e)
        {
            /*
            int size = 0;
            while (size < this.seat_purchased.Length || size + 1 < this.seat_purchased.Length)
            {
                int a = (Convert.ToChar(this.seat_purchased.Substring(size, 1)) - 65);
                int b = (Convert.ToInt32(this.seat_purchased.Substring(size + 1, 1)) - 1);
                seat_status[a, b] = false;

                change_seat = true;
                size += 3;
                
            }
            */
        }
        public void ShowImage(PictureBox picBox)
        {
            picBox.Image = available_icon;
            picBox.Refresh(); //Work without the exception
            picBox.Visible = true;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;

            if (picBox.Image == available_icon)
                picBox.Image = your_seat_icon;

            else if (picBox.Image == your_seat_icon)
                picBox.Image = available_icon;

            else if (picBox.Image == sold_icon)
                MessageBox.Show("The seat is booked.");
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string seat = null;
            int num_of_ticket = 0;
            string seat_code1 = "";

            for (int r = 0; r < 30; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    while (picBox[r, c].Image == your_seat_icon)
                    {
                        seat_status[r, c] = true;
                        picBox[r, c].Image = sold_icon;
                        if (r >= 12)        // skip 13A and 13F as 13th row
                            seat_code1 = Convert.ToString(r + 2);
                        else
                            seat_code1 = Convert.ToString(r + 1);
                        string seat_code2 = (Convert.ToChar(c + 65)).ToString();
                        seat += (seat_code1 + seat_code2) + " ";
                        num_of_ticket++;
                    }
                }
            }

            memberwithoutpurchased.Points += num_of_ticket * 150;

            ArrayList flightlist = new ArrayList();

            flightlist.Add(new MemberWithPurchased(memberwithoutpurchased.Name, memberwithoutpurchased.Ic,
                                                    memberwithoutpurchased.Email, memberwithoutpurchased.Gender,
                                                    memberwithoutpurchased.Id, memberwithoutpurchased.Password,
                                                    "KLIA2 - KOTAKINABALU (SABAH)", seat,
                                                    (299 * num_of_ticket), DateTime.Now.ToShortDateString(),
                                                    DateTime.Now.ToString("hh:mm:ss tt"), memberwithoutpurchased.Points));
            TicketForm ticket = new TicketForm();
            ticket.receive_info(flightlist);
            ticket.Show();

        }
        public void receive_info2(ArrayList memberlist2)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist2[memberlist2.Count - 1];
        }

        private void btnRedeem_Click(object sender, EventArgs e)
        {
            //ArrayList flightList = new ArrayList();
            string seat = null;
            int num_of_ticket = 0, numOfTicketAvailable = 0;
            string seat_code1 = "";

            numOfTicketAvailable = memberwithoutpurchased.Points / 400;
            int count = 0;

            for (int r = 0; r < 30; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    if (picBox[r, c].Image == your_seat_icon)
                    {
                        count++;
                    }
                }
            }
            if (numOfTicketAvailable >= count)
            {
                for (int r = 0; r < 30; r++)
                {
                    for (int c = 0; c < 6; c++)
                    {
                        while (picBox[r, c].Image == your_seat_icon)
                        {
                            seat_status[r, c] = true;
                            picBox[r, c].Image = sold_icon;
                            if (r >= 12)        // skip 13A and 13F as 13th row
                                seat_code1 = Convert.ToString(r + 2);
                            else
                                seat_code1 = Convert.ToString(r + 1);
                            string seat_code2 = (Convert.ToChar(c + 65)).ToString();
                            seat += (seat_code1 + seat_code2) + " ";
                            num_of_ticket++;

                            memberwithoutpurchased.Points -= num_of_ticket * 400;
                           
                        }
                    }
                }

                ArrayList flightlist = new ArrayList();
                flightlist.Add(new MemberWithPurchased(memberwithoutpurchased.Name, memberwithoutpurchased.Ic,
                                        memberwithoutpurchased.Email, memberwithoutpurchased.Gender,
                                        memberwithoutpurchased.Id, memberwithoutpurchased.Password,
                                        "KLIA2 - KOTAKINABALU (SABAH)", seat,
                                        0, DateTime.Now.ToShortDateString(),
                                        DateTime.Now.ToString("hh:mm:ss tt"), memberwithoutpurchased.Points));
                TicketForm ticket = new TicketForm();
                ticket.receive_info(flightlist);
                ticket.Show();
            }
            else
            {
                MessageBox.Show("You are not enough bonus points!");
            }
        }
        public void receive_info3(ArrayList memberlist3)
        {
            memberwithoutpurchased = (MemberWithoutPurchased)memberlist3[memberlist3.Count - 1];
        }

        MemberWithPurchased memberwithpurchased;
        public void receive_seat_info(ArrayList flightlist)
        {
            memberwithpurchased = (MemberWithPurchased)flightlist[flightlist.Count - 1];
        }

        private void btnChangeSeat_Click(object sender, EventArgs e)
        {
            //ArrayList FlightList = new ArrayList();
            string seat = null;
            int num_of_ticket = 0;
            string seat_code1 = "";

            for (int r = 0; r < 30; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    while (picBox[r, c].Image == your_seat_icon)
                    {
                        seat_status[r, c] = true;
                        picBox[r, c].Image = sold_icon;
                        if (r >= 12)        // skip 13A and 13F as 13th row
                            seat_code1 = Convert.ToString(r + 2);
                        else
                            seat_code1 = Convert.ToString(r + 1);
                        string seat_code2 = (Convert.ToChar(c + 65)).ToString();
                        seat += (seat_code1 + seat_code2) + " ";
                        num_of_ticket++;
                    }
                }
            }

            memberwithoutpurchased.Points = 0;

            ArrayList flightlist = new ArrayList();
            ArrayList memberlist = new ArrayList();
            memberlist.Add(memberwithoutpurchased);

            flightlist.Add(new MemberWithPurchased(memberwithoutpurchased.Name, memberwithoutpurchased.Ic,
                                    memberwithoutpurchased.Email, memberwithoutpurchased.Gender,
                                    memberwithoutpurchased.Id, memberwithoutpurchased.Password,
                                    "KLIA2 - KOTAKINABALU (SABAH)", seat,
                                    (20 * num_of_ticket), DateTime.Now.ToString("hh:mm:ss tt"),
                                    DateTime.Now.ToShortDateString(), memberwithoutpurchased.Points));
            int i = 1;
            TicketForm ticket = new TicketForm();
            ticket.receive_info(flightlist);
            ticket.receive_info2(memberlist);
            ticket.receive_point(i);
            ticket.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}