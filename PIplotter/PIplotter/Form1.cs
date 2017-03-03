using arduino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
namespace PIplotter
{
    public partial class Form1 : Form
    {
        communicator comport = new communicator();
        string x;
        double xAxis = 0;
        double yAxis = 0;
        LineItem myCurve;
        bool plot;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //size0 348, 170
            //size1 439, 207
            this.Size = new Size(386, 170);
            
            foreach (var myPort in System.IO.Ports.SerialPort.GetPortNames())
            {
                avaCOMports.Items.Add(myPort);
            }
            avaCOMports.SelectedIndex = 0;

            serialPort1.DataReceived += serialPort1_DataReceived;


            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "A graph represents the voltage time relation of the input signal";
            myPane.XAxis.Title.Text = "Time(Sec)";
            myPane.YAxis.Title.Text = "Voltage(Volts)";
            PointPairList list = new PointPairList() ;
            myCurve = myPane.AddCurve("Voltage Time curve", list, Color.Red, SymbolType.Circle);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                    if (serialPort1.BytesToRead > 0)
                    {
                        try
                        {
                            x = serialPort1.ReadLine();
                            x = x.Replace("\r", "");
                            this.BeginInvoke(new ShowResults(ShowData), x);
                        }
                        catch (Exception)
                        {

                            MetroFramework.MetroMessageBox.Show(this, "This is error 01\nLooks like the software cant recieve the data!", "PI student activity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

            


        }
        private delegate void ShowResults(string x);
        private void ShowData(string x)
        {
            try
            {
                double z = Convert.ToDouble(x);

                //yAxis = Math.Round(z / 100.0, 5);
                yAxis = Math.Round((z*5)/1024, 5);
            }
            catch
            {

            }
        }



        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            avaCOMports.Items.Clear();
            foreach (var myPort in System.IO.Ports.SerialPort.GetPortNames())
            {
                avaCOMports.Items.Add(myPort);
            }
            avaCOMports.SelectedIndex = 0;
        }

        private void stepOneButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(439, 207);
            Timer myT = new Timer();
            myT.Interval = 1;
            myT.Enabled = true;
            myT.Tick += delegate { animateLeft(sndView,myT); };
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = avaCOMports.SelectedItem.ToString();
                    serialPort1.Open();
                }
            }
            catch
            {

                MetroFramework.MetroMessageBox.Show(this, "ERROR:01\ni cant connect to the arduino!", "PI student activity", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void mesVoltage_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            plot = false;
            Timer myT = new Timer();
            myT.Interval = 1;
            myT.Enabled = true;
            myT.Tick += delegate {animateLeft(measureVoltsBox, myT);};
 

        }

        private void plotVoltage_Click(object sender, EventArgs e)
        {
            plot = true;
            plotView.Location = new Point(12, 12);
            plotView.Size = new Size(966-10, 415-12);
            this.Size = new Size(996, 460);
            zedGraphControl1.Size = new Size(950 - 20, 400 - 60);
           
            
        }



        private void back1_Click(object sender, EventArgs e)
        {
            //serialPort1.Close();
            timer1.Enabled = false;
            Timer myT = new Timer();
            myT.Interval = 1;
            myT.Enabled = true;
            myT.Tick += delegate { animateRight(measureVoltsBox, myT); };

        }
        public void animateLeft(GroupBox box,Timer myT)
        {
            
            if (box.Location.X <= 12)
            {
                myT.Enabled = false;
            }
            else
            {
                box.Location = new Point(box.Location.X - 12, 12);
            }

        }
        public void animateRight(GroupBox box, Timer myT)
        {
            if (box.Location.X >= 512)
            {
                myT.Enabled = false;
            }
            else
            {
                box.Location = new Point(box.Location.X + 12, 12);
            }
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Size=new Size(386, 170);
            Timer myT = new Timer();
            myT.Interval = 1;
            myT.Enabled = true;
            myT.Tick += delegate { animateRight(sndView, myT); };
            try
            {
                serialPort1.Close();
            }
            catch
            {
                //Do nth
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (plot == true)
            {
                xAxis += 0.1;
                myCurve.AddPoint(xAxis, yAxis);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
            }
            else
                VoltageMeterLabel.Text = yAxis.ToString();
                

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //serialPort1.Close();
            plotView.Location = new Point(12, 191);
            plotView.Size = new Size(476, 78);
            this.Size = new Size(439, 207);
        }




        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



    }
}
