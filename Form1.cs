using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PopinGUI_Form
{
    public partial class Form1 : Form
    {
        Ping pingSender = new Ping();

        public string address;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Получить ip адрес из textBox1
            address = textBox1.Text;

           
                // Пингуем хост
                try
                {

                    PingReply reply;
                    reply = pingSender.Send(address);


                    // Вывод данных в label1
                    if (reply.Status == IPStatus.Success)
                    {
                        label1.Text = "Ping есть!";
                    }
                    else
                    {
                        label1.Text = "Ping нет!";
                    }

                }

                catch (PingException)
                {
                    label1.Text = "Некорректный ip адрес!";

                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
