using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using HHPS_DCZM_Interface.Helpers;
using HHPS_DCZM_Interface.Models;
using Newtonsoft.Json;
using System.IO;

namespace HHPS_DCZM_Interface
{
    public partial class Form_Settings : Form
    {

        private static SerialPort port;
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> serialPorts = SerialPort.GetPortNames().ToList();
                Combo_PortList.DataSource = serialPorts;
                Combo_TOF_PERIOD.SelectedIndex = 2;
                Combo_TxDuration.SelectedIndex = 1;
                Combo_LPIR_PERIOD.SelectedIndex = 0;
                Combo_BeaconDuration.SelectedIndex = 0;
                DevicePower_Box.Checked = true;
                CleanLED_BOX.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SendCommandData (string command, byte d1, byte d2, byte d3)
        {
            byte[] tx_buff = new byte[6];
            var commandchar = command.ToCharArray();
            tx_buff[0] = Convert.ToByte(commandchar[0]);
            tx_buff[1] = Convert.ToByte(commandchar[1]);
            tx_buff[2] = Convert.ToByte(commandchar[2]);
            tx_buff[3] = d1;
            tx_buff[4] = d2;
            tx_buff[5] = d3;
            port.Write(tx_buff, 0, 6);
        }

        private byte[] GetCommandData(string command)
        {
            try
            {
                byte[] rx_buff = new byte[6];
                var commandchar = command.ToCharArray();
                rx_buff = ReadPortBytes(6);

                if ((rx_buff[0] == commandchar[0]) & (rx_buff[1] == commandchar[1]) & (rx_buff[2] == commandchar[2]))
                    return new byte[3] { rx_buff[3], rx_buff[4], rx_buff[5]};
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void Btn_All_Disable()
        {

            Btn_Download_Memory.Enabled = false;
            Btn_Erase_Memory.Enabled = false;
            Connect_Device.Enabled = false;
            Btn_Disconnect.Enabled = false;
            Btn_Connect.Enabled = false;

        }

        private void Btn_All_Enable()
        {

                Btn_Download_Memory.Enabled = true;
                Btn_Erase_Memory.Enabled = true;
                Connect_Device.Enabled = true;
                Btn_Disconnect.Enabled = true;
                Btn_Connect.Enabled = false;
            }
        private void Btn_Erase_Memory_Click(object sender, EventArgs e)                 // this function sets 15 high risk zones, by sending the 32 bytes packet of data.
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Download_Memory_Click(object sender, EventArgs e)              ///////////// to DOWNLOAD Recorded Events //////////////////
        {            
            MemoryContent memoryContent = new MemoryContent();            
            int _seconds = (int)numeric_SampleTime.Value%60;
            int _minutes = (int)numeric_SampleTime.Value / 60;
            TimeSpan _sampleDuration = new TimeSpan(0,_minutes,_seconds);
            byte[] commandByte = new byte[3];
            byte[] dataByte = new byte[5];
            byte RecordsStartYear = 0;
            var path = $"C:\\URESP\\US_{DateTime.Now.Date.ToString("yyMMdd")}_{DateTime.Now.TimeOfDay.ToString("hhmmss")}.csv";
            var csv = new StringBuilder();
            var newLine = "";
            try
            {

                Btn_All_Disable();
                Btn_Download_Memory.BackColor = System.Drawing.Color.Green;        // Set the button color Green, meaning that the button is pressed

                if (true)
                {
                    newLine = string.Format("{0},{1},{2}\r\n", "Time", "Ultrasound", "Pressure");
                    csv.Append(newLine);
                   
                    var year = (int)(RecordsStartYear);
                    var month = 0;
                    var day = 0;
                    var hour = 0;
                    string event_info = "";
                    DateTime _endTime = new DateTime();
                    _endTime = DateTime.Now + _sampleDuration;
                    while (_endTime > DateTime.Now)
                        {
                            dataByte = ReadPortBytes(5);
                            string ultrasound = dataByte[0].ToString();
                            string pressure = (dataByte[2]).ToString();
                            //var event_time = DateTime.Parse(event_time_string);
                            newLine = string.Format("{0},{1},{2},\r\n", DateTime.Now.ToString("hh:mm:ss.fff"), ultrasound, pressure);
                            csv.Append(newLine);                            
                        }

                        File.WriteAllText(path, csv.ToString());
                        //var data = JsonConvert.SerializeObject(memoryContent, Formatting.Indented);
                        //path = $"C:\\HHPS\\DCData\\DC_{dev_id}_{DateTime.Now.Date.ToString("yyMMdd")}_{DateTime.Now.TimeOfDay.ToString("hhmmss")}.json";
                        //System.IO.File.WriteAllText(path, data);
                // Replace the button color with the original one
                    
                    Btn_All_Enable();
                }
                    else
                    {
                        var msg = $"No data to download";
                        MessageBox.Show(msg);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearBuffer();
        }        

        private byte[] ReadPortBytes(int numberOfBytes)
        {
            byte[] bytes = new byte[numberOfBytes];

            try
            {
                for (int i = 0; i < numberOfBytes; i++)
                    bytes[i] = Convert.ToByte(port.ReadByte());
                return bytes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                port.Close();

                Btn_Download_Memory.Enabled = false;
                Btn_Erase_Memory.Enabled = false;
                Connect_Device.Enabled = false;
                Btn_Disconnect.Enabled = false;
                Btn_Connect.Enabled = true;
                throw;
            }


        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string port_name = Combo_PortList.Text;
                //combo_serialList = serialPorts[0];
                port = new SerialPort(port_name, 115200, Parity.Even, 8, StopBits.One);
                port.WriteTimeout = 1000;
                port.ReadTimeout = 2000;
                port.Open();

                Connect_Device.Enabled = true;
                Btn_All_Enable();

                //MessageBox.Show("Port Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void ClearBuffer()
        {
            port.DiscardOutBuffer();
            port.DiscardInBuffer();
        }

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (port != null && port.IsOpen)
                {
                    port.Close();

                    //MessageBox.Show("Port Disconnected");
                }
                else
                {
                    MessageBox.Show("Port is already disconnected");
                }

                Btn_All_Disable();
                Btn_Connect.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Disconnect port failed: {ex.Message}");
            }
        }


        private void Btn_ConnectDevice_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




    }
}
