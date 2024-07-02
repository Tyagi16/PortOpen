using System.Diagnostics;
using System.IO.Ports;

namespace PortOpen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort portLaser=new SerialPort();

        private void Form1_Load(object sender, EventArgs e)
        {
            portLaser.Parity = Parity.None;
            portLaser.StopBits = StopBits.One;
            portLaser.DataBits = 8;
            portLaser.BaudRate = 115200;
            portLaser.PortName = "COM9";
            portLaser.DataReceived += portLaser_DataReceived;
        }
        List<byte> dataReceived = new List<byte>();  
        private void portLaser_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           int b= portLaser.BytesToRead;
            Debug.WriteLine("Bytes to read="+b);
            byte[]arr = new byte[b];
            portLaser.Read(arr, 0, b);
            dataReceived.AddRange(arr); 
            Debug.WriteLine(arr);

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                portLaser.Open();
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText($"{ex.Message}\n");
            }

        }
        string parseData(List<byte> data)
        {
            return ByteToHexString(data);
        }

        private string ByteToHexString(List<byte> data)
        {
            throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            portLaser.Close();
        }
    }
}
