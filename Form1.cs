using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    { 
        string Str_keystrokes;
        int times_pressed = 0;
        string letter;
        int button_pressed;
        Timer timer = new Timer();
        bool timer_on = false; 
        

        public Form1()
        {
            InitializeComponent();




            
        }
        public void append_text() { 
        
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
            timer.Interval = 2000;
            timer.Start();
            timer_on = true;
            label2.Text = "interval start";
            timer.Tick += new EventHandler(timer_Tick);
            button_pressed = 8;
            if(timer_on == true){
            
            
                if (times_pressed < 7)
                {
                    Wordbuilder_tbx.Text = Convert.ToString(ListBox_8.Items[times_pressed]);
                    letter = Convert.ToString(ListBox_8.Items[times_pressed]);
                    times_pressed = times_pressed + 1;
                }
                else {
                    times_pressed = 0;
                    Wordbuilder_tbx.Text = Convert.ToString(ListBox_8.Items[times_pressed]);
                    letter = Convert.ToString(ListBox_8.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }
            
            }
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (times_pressed < 7)
            {
                Wordbuilder_tbx.Text = Convert.ToString(ListBox_9.Items[times_pressed]);
                letter = Convert.ToString(ListBox_8.Items[times_pressed]);
                times_pressed = times_pressed + 1;
            }
            else {
                times_pressed = 0;
                Wordbuilder_tbx.Text = Convert.ToString(ListBox_9.Items[times_pressed]);
                letter = Convert.ToString(ListBox_8.Items[times_pressed]);
                times_pressed = times_pressed + 1;

            }
           
        }

        public void timer_Tick(object sender, EventArgs e) {
            Wordbuilder_tbx.AppendText(letter);
            label2.Text = "interval end";
            timer_on = false;
            timer.Stop();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
           Wordpad.AppendText(Wordbuilder_tbx.Text) ;
           Wordpad.AppendText(" ");
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            Wordpad.AppendText(Environment.NewLine);
        }


        }
    }
