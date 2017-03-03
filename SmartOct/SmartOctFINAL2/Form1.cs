using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartOctFINAL2
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        string theOutlets="done";
        bool auth = false;
        List<smartSwitch> loads ;
        List<smartSensor> sensors;
        List<string> theRooms;
        public Form1()
        {
            //806, 474
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            loads = new List<smartSwitch>();
            sensors = new List<smartSensor>();
            theRooms = new List<string>();
            System.Windows.Forms.Timer x = new System.Windows.Forms.Timer();
            x.Tick+=x_Tick;
            x.Enabled = true;
            x.Interval = 1000;
        }

        private void x_Tick(object sender, EventArgs e)
        {
            this.Text = theOutlets;
            this.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(301, 420);
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
            
        }
        //void expandScreen()
        //{
        //    System.Windows.Forms.Timer myT = new System.Windows.Forms.Timer();
        //    myT.Interval = 10;
        //    myT.Enabled = true;
        //    myT.Tick += delegate
        //    {
        //        if (this.Size.Height >= 420)
        //        {
        //            myT.Enabled = false;
        //            this.Size = new Size(this.Size.Width, 420);

        //        }
        //        else
        //        {
        //            this.Size = new Size(this.Size.Width+23, this.Size.Height+5);
        //        }
        //    };
        //}

        private void signIn_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            filterRawData(theOutlets);
            //expandScreen();
            this.Size = new Size(600, 420);
            panel1.Visible = false;
            moveLeft(switchsPlace,47);
            moveLeft(sensorsPlace, 377);
            moveLeft(notifications, 607);
            moveLeft(sensorSettings, 607);
            cr.Visible = true;
            location.Visible = true;
            loadROOMS();           
        }
        void moveLeft(Panel box, int x)
        {

            System.Windows.Forms.Timer myT = new System.Windows.Forms.Timer();
            myT.Interval = 1;
            myT.Enabled = true;
            myT.Tick += delegate
            {
                if (box.Location.X <= x)
                {
                    myT.Enabled = false;
                    box.Location = new Point(x, box.Location.Y);
                        box.Location = new Point(x - 44, box.Location.Y);
                }
                else
                {
                    box.Location = new Point(box.Location.X - 20, box.Location.Y);
                }
            };
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            cr.Location = new Point(13, this.Height - 45);
            //this.Text = this.Size.ToString();
            //this.Refresh();//600,420 and 800,500
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            loadROOMS();
            location.Text = "home/";
        }
        void filterRawData(string foo)
        {
            try
            {
            if (foo.Length>4&&foo.Substring(0, 4) == "olts" && foo[foo.Length - 2] == '<')
            {
                theRooms.Clear();
                loads.Clear();
                while (foo != "#")
                {
                    loads.Add(new smartSwitch(getBettwen('_', '-', foo), getBettwen('-', '<', foo), getBettwen('>', '_', foo), this));
                    foo = cutString('<', foo);
                }
                foreach (var aSwitch in loads)
                {
                    if (!theRooms.Contains(aSwitch.roomName))
                    {
                        theRooms.Add(aSwitch.roomName);
                    }
                }
            }
            //*AMP_111-4320~

            else if (foo.Substring(0, 4) == "snsr" && foo[foo.Length - 2] == '<')
            {
                sensors.Clear();
                while (foo != "#")
                {
                    sensors.Add(new smartSensor(getBettwen('_', '-', foo), getBettwen('-', '<', foo), getBettwen('>', '_', foo)));
                    foo = cutString('<', foo);
                }
                loadSENSORS();
               
            }
            else if (foo.Substring(0, 4)=="*AMP" &&foo[foo.Length - 1] == '~')
            {
                //sensors.Add(new smartSensor("PWR","PWR="+getBettwen('-', '~', foo),getBettwen('_', '-', foo)));
                PWR.Text = "PWR=" + getBettwen('-', '~', foo) + "W";
            }
            theOutlets = "done";
            }
            catch
            {
                
            }
        }
        void loadLoads(string room)
        {
            switchsPlace.Controls.Clear();
            materialFlatButton2.Text = "loads";
            switchsPlace.Controls.Add(materialFlatButton2);
            switchsPlace.Controls.Add(materialFlatButton8);
            foreach (var item in loads)
            {
                if (item.roomName==room)
                {
                    item.draw(switchsPlace);
                }
            }
        }
        void loadSENSORS()
        {
            sensorsPlace.Controls.Clear();
            sensorsPlace.Controls.Add(materialFlatButton3);
            sensorsPlace.Controls.Add(materialFlatButton14);
            sensorsPlace.Controls.Add(materialCheckBox1);
            sensorsPlace.Controls.Add(PWR);
            foreach (var item in sensors)
            {
                item.add(sensorsPlace);
                item.theData.Click += materialFlatButton14_Click;
            }
        }

        void loadROOMS()
        {
            switchsPlace.Controls.Clear();
            materialFlatButton2.Text = "rooms";
            switchsPlace.Controls.Add(materialFlatButton2);
            switchsPlace.Controls.Add(materialFlatButton8);
            foreach (var item in theRooms)
            {
                
                int buf = 0;
                foreach (var item2 in loads)
                {
                    if (item2.roomName==item)
                    {
                        buf += 1;
                    }
                }
                if (buf!=0)
                {
                    MaterialFlatButton x = new MaterialFlatButton();
                    x.Text = item;
                    x.Click += x_Click;
                    switchsPlace.Controls.Add(x);
                }

            }
        }

        private void x_Click(object sender, EventArgs e)
        {
            Button z = (Button)sender;
            loadLoads(z.Text);
            location.Text = "home/" + z.Text;
        }
        string getBettwen(char needle1, char needle2, string heyStack)
        {
            int star = 0, end = 0;
            for (int i = 0; i < heyStack.Length; i++)
            {
                if (needle1 == heyStack[i])
                {
                    star = i;
                    break;
                }
            }
            star += 1;
            for (int i = 0; i < heyStack.Length; i++)
            {
                if (needle2 == heyStack[i])
                {
                    end = i;
                    break;
                }
            }
            string buf = "";
            for (int i = star; i < end; i++)
            {
                buf += heyStack[i];
            }
            return buf;
        }    // well i hate c# substring method !
        string cutString(char x, string toCut)
        {
            int buf1 = 0;
            string ret = "";
            for (int i = 0; i < toCut.Length; i++)
            {
                if (x == toCut[i])
                { buf1 = 1 + i; break; }
            }
            for (int i = buf1; i < toCut.Length; i++)
            {
                ret += toCut[i];
            }
            return ret;
        }
        void send(string toSend)
        {
            try
            {
                UdpClient udpServer = new UdpClient();
                udpServer.Connect("192.168.1.255", 1112);
                Byte[] senddata = Encoding.ASCII.GetBytes(toSend);
                udpServer.Send(senddata, senddata.Length);
                udpServer.Close();
            }
            catch (Exception)
            {

            }

        }
        void rec()
        {
            UdpClient udpServer = new UdpClient(8888);
            var remoteEP = new IPEndPoint(IPAddress.Parse("192.168.1.255"), 8888);
            var data = udpServer.Receive(ref remoteEP); // listen on port 11000
            theOutlets = System.Text.Encoding.UTF8.GetString(data);
            udpServer.Close();
            auth = true;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!auth)
            {
                send("*ROOMS~");
                Thread.Sleep(3000);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                rec();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (auth)
            {
                theStatesLabel.Location = new Point(3, theStatesLabel.Location.Y);
                theStatesLabel.ForeColor = Color.Green;
                theStatesLabel.Text = "All done please login!";
                signIn.Enabled = true;
                pictureBox2.Visible = false;
                timer1.Enabled = false;
                sensorTimer.Enabled = true;
            }

        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            sensorSettings.Visible = false;
            notifications.Visible = !notifications.Visible;
            if (!notifications.Visible)
                this.Size = new Size(600, 420);
            else
                this.Size = new Size(800, 500);
        }

        private void switchsPlace_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void materialFlatButton14_Click(object sender, EventArgs e)
        {
            notifications.Visible = false;
            sensorSettings.Visible = !sensorSettings.Visible;
            if (!sensorSettings.Visible)
                this.Size = new Size(600, 420);
            else
                this.Size = new Size(800, 500);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (theOutlets!="done")
            {
                filterRawData(theOutlets);
            }
        }

        private void theLoadId_TextChanged(object sender, EventArgs e)
        {
            roomNameInfo.Text = "";
            loadNameInfo.Text = "";
            foreach (var item in loads)
            {
                if (item.code==theLoadId.Text)
                {
                    roomNameInfo.Text = item.roomName;
                    loadNameInfo.Text = item.name;
                }
            }
        }

        private void saveLoadConfig_Click(object sender, EventArgs e)
        {
            foreach (var item in loads)
            {
                if (item.code==theLoadId.Text)
                {
                    item.roomName = roomNameInfo.Text;
                    if (!theRooms.Contains(roomNameInfo.Text))
                    {
                        theRooms.Add(roomNameInfo.Text);
                    }
                    item.thePressablePart.Text = loadNameInfo.Text;
                }
            }
            if (roomNameInfo.Text!="" && loadNameInfo.Text != "")
            {
                send("*otl>" + theLoadId.Text + "_" + roomNameInfo.Text + "-" + loadNameInfo.Text + "<#~");
            }
            roomNameInfo.Text = "";
            loadNameInfo.Text = "";
            theLoadId.Text = "";
            location.PerformClick();
            materialFlatButton8.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sensorTimer_Tick(object sender, EventArgs e)
        {
            send("*SENSORS~");
        }

    }
}
