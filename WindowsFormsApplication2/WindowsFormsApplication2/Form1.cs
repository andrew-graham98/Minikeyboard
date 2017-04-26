using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string Str_keystrokes;
        int times_pressed;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Mode_btn_Click(object sender, EventArgs e)
        {
            if (modeStatus_txt.Text == "Multi-Press"){
                modeStatus_txt.Text = "Prediction";}
            else{
                modeStatus_txt.Text = "Multi-Press";
            }
            
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
           times_pressed = times_pressed + 1;
           Wordbuilder_tbx.Text = Convert.ToString(ListBox_8.Items[times_pressed]) ;
            
        }
    }
}
