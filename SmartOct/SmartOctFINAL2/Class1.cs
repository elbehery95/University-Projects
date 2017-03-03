using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOctFINAL2
{
    class smartSwitch
    {
        public MetroFramework.Controls.MetroButton theMovablePart;
        public MaterialSkin.Controls.MaterialFlatButton thePressablePart;
        Panel z;
        public string name;
        public string code;
        public string roomName;
        bool isMoving;
        public bool isOn;
        Form ff;
        public smartSwitch(string romName, string theName, string theCode, Form z1,bool state = false)
        {
            ff = z1;
            roomName = romName;
            name = theName;
            code = theCode;
            theMovablePart = new MetroFramework.Controls.MetroButton();
            z = new Panel();
            z.Size = new Size(325, 45);
            thePressablePart = new MaterialSkin.Controls.MaterialFlatButton();
            theMovablePart.Theme = MetroThemeStyle.Dark;
            theMovablePart.Text = "OFF";
            theMovablePart.UseCustomBackColor = true;
            theMovablePart.UseCustomForeColor = true;
            theMovablePart.AutoSize = false;
            theMovablePart.Size = new Size(37, 36);
            theMovablePart.FontSize = MetroButtonSize.Medium;
            isOn = state;
            isMoving = false;
            theMovablePart.ForeColor = Color.White;
            theMovablePart.BackColor = Color.FromArgb(210, 46, 46);
            thePressablePart.Text = theName;
            thePressablePart.AutoSize = false;
            thePressablePart.Size = new Size(115, 36);
            thePressablePart.Click += toggle;
            theMovablePart.Click += toggle;
        }
        public void draw(FlowLayoutPanel pan)
        {
            thePressablePart.Location = new Point(70, 6);
            if (isOn == true)
            {
                theMovablePart.Text = "ON";
                theMovablePart.BackColor = Color.FromArgb(67, 160, 71);
                theMovablePart.Location = new Point(thePressablePart.Location.X + (thePressablePart.Size.Width + 7), thePressablePart.Location.Y);
            }
            else
                theMovablePart.Location = new Point(thePressablePart.Location.X - 44, thePressablePart.Location.Y);
            z.Controls.Add(theMovablePart);
            z.Controls.Add(thePressablePart);

            pan.Controls.Add(z);
        }
        public void remove(Form z)
        {
            z.Controls.Remove(thePressablePart);
            z.Controls.Remove(theMovablePart);
        }

        private void toggle(object sender, EventArgs e)
        {

            if (isMoving == false)
            {

                if (isOn == true)
                {
                    isMoving = true;
                    theMovablePart.Enabled = false;
                    int buf1 = theMovablePart.Location.X;
                    System.Windows.Forms.Timer myT = new System.Windows.Forms.Timer();
                    myT.Interval = 1;
                    myT.Enabled = true;
                    myT.Tick += delegate
                    {
                        if (theMovablePart.Location.X < buf1 - (thePressablePart.Size.Width + 44 + 7))
                        {
                            myT.Enabled = false;
                            theMovablePart.Enabled = true;
                            theMovablePart.Location = new Point(buf1 - (thePressablePart.Size.Width + 44 + 7), thePressablePart.Location.Y);
                            theMovablePart.BackColor = Color.FromArgb(210, 46, 46);
                            theMovablePart.Text = "OFF";
                            sendText("*CHA"+code+"0~");
                            isOn = false;
                            isMoving = false;
                        }
                        else
                        {
                            theMovablePart.Location = new Point(theMovablePart.Location.X - 12, thePressablePart.Location.Y);
                        }
                    };
                }
                else
                {
                    isMoving = true;
                    theMovablePart.Enabled = false;
                    int buf1 = theMovablePart.Location.X;
                    System.Windows.Forms.Timer myT = new System.Windows.Forms.Timer();
                    myT.Interval = 1;
                    myT.Enabled = true;
                    myT.Tick += delegate
                    {
                        if (theMovablePart.Location.X > thePressablePart.Size.Width + buf1 + 44 + 7)
                        {
                            myT.Enabled = false;
                            theMovablePart.Enabled = true;
                            theMovablePart.Location = new Point(thePressablePart.Size.Width + buf1 + 44 + 7, thePressablePart.Location.Y);
                            theMovablePart.BackColor = Color.FromArgb(67, 160, 71);
                            theMovablePart.Text = "ON";
                            sendText("*CHA" + code + "1~");
                            isOn = true;
                            isMoving = false;
                        }
                        else
                        {
                            theMovablePart.Location = new Point(theMovablePart.Location.X + 12, thePressablePart.Location.Y);
                        }
                    };
                }
            }
        }
        public void sendText(string toSend)
        {
            try
            {
                UdpClient udpServer = new UdpClient();
                udpServer.Connect("192.168.1.255", 1112);
                Byte[] senddata = Encoding.ASCII.GetBytes(toSend);
                udpServer.Send(senddata, senddata.Length);
                udpServer.Close();
            }
            catch
            {

                MetroFramework.MetroMessageBox.Show(ff, "Error sending the instruction\nMake sure the central unit is connected");
            }
        }
    }
    class smartSensor
    {
        public MaterialSkin.Controls.MaterialFlatButton theData;
        //public MaterialSkin.Controls.MaterialSingleLineTextField theIdPlace;
        string code;
        string  value;
        string roomName; // room name- name-code
        public smartSensor(string theRoom,string name,string cde)
        {
            code = cde;
            roomName = theRoom;
            theData = new MaterialSkin.Controls.MaterialFlatButton();
            theData.Text = name;
            
        }
        public void add( FlowLayoutPanel place)
        {
            place.Controls.Add(theData);
        }
    }
}
