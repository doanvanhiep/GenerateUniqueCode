using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace GetMACAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = FingerPrint.Value().ToString();
            textBox2.Text = System.Environment.MachineName;
            //return;
            //string a = "";
            //foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            //{
            //    // Only consider Ethernet network interfaces
            //    if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
            //        nic.OperationalStatus == OperationalStatus.Up)
            //    {
            //        textBox1.Text= nic.GetPhysicalAddress().ToString();
            //        return;
            //    }
            //}

        }
    }
}
