using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AoBTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] aob_result;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            txt_result.Clear(); 
            string aob1 = txt_aob1.Text;
            string aob2 = txt_aob2.Text;

            string[] aob1_split = aob1.Split(' ');
            string[] aob2_split = aob2.Split(' ');
            try
            {
                for (int i = 0; i < aob1_split.Length; i++)
                {
                    if (aob1_split[i] == aob2_split[i])
                    {
                        txt_result.Text += aob1_split[i] + " ";
                    }
                    else
                    {
                        txt_result.Text += "?? ";

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
