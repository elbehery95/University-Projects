using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Data;

namespace arduino
{
    public class communicator
    {
        public string port = "";
        static SerialPort currentPort;
        public Boolean connect(int baud, string recognizeText, byte paramone, byte paramtwo, byte paramthree)
        {
            try
            {

                byte[] buffer = new byte[3];
                buffer[0] = Convert.ToByte(paramone);
                buffer[1] = Convert.ToByte(paramtwo);
                buffer[2] = Convert.ToByte(paramthree);

                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                string[] ports = SerialPort.GetPortNames();
                foreach (string newport in ports)
                {
                    currentPort = new SerialPort(newport, baud);
                    currentPort.Open();
                    currentPort.Write(buffer, 0, 3);
                    Thread.Sleep(200);
                    int count = currentPort.BytesToRead;
                    string returnMessage = "";
                    while (count > 0)
                    {
                        intReturnASCII = currentPort.ReadByte();
                        returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                        count--;
                    }

                    currentPort.Close();
                    port = newport;
                    if (returnMessage.Contains(recognizeText))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


        public string message(byte paramone, byte paramtwo, byte paramthree)
        {
            try
            {
                byte[] buffer = new byte[3];
                buffer[0] = Convert.ToByte(paramone);
                buffer[1] = Convert.ToByte(paramtwo);
                buffer[2] = Convert.ToByte(paramthree);
                currentPort.Open();
                currentPort.Write(buffer, 0, 3);
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                Thread.Sleep(200);
                int count = currentPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }
                currentPort.Close();
                return returnMessage;
            }
            catch 
            {
                return "Error";
            }

        }


    }
}
