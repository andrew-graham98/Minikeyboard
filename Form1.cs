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
        ListBox globalList = new ListBox();
        

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
            string s = Wordbuilder_tbx.Text;
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
                button_pressed = 8;
                if (timer_on == true)
                {


                    if (times_pressed < 7)
                    {
                        if (s.Length > 1)
                        {
                            timer.Start();
                            s = s.Substring(0, s.Length - 1);
                            Wordbuilder_tbx.Text = s;


                            Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_8.Items[times_pressed]));
                            times_pressed = times_pressed + 1;

                        }
                        else
                        {
                            timer.Start();
                            Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_8.Items[times_pressed]));
                            letter = Convert.ToString(ListBox_8.Items[times_pressed]);
                            times_pressed = times_pressed + 1;
                        }
                        
                        
                    }
                    else
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;
                        times_pressed = 0;
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_8.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_8.Items[times_pressed]);
                        times_pressed = times_pressed + 1;

                    }
                    
                }
            }

        private void Button_9_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 9;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_9.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_9.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_9.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_9.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_9.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }
        }

        public void timer_Tick(object sender, EventArgs e) {
            label3.Text = letter;
            Wordbuilder_tbx.AppendText(letter);
            label2.Text = "interval end";
            letter = "";
            timer.Stop();
            timer_on = false;

        }

        private void Button18_Click(object sender, EventArgs e)
        {
           Wordpad.AppendText(Wordbuilder_tbx.Text) ;
           Wordpad.AppendText(" ");
           Wordbuilder_tbx.Text = "";
           times_pressed = 0;
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            Wordpad.AppendText(Environment.NewLine);
        }

        private void cOnfiureToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.ShowDialog();
            if (saveFile1.FileName != "") {
                System.IO.FileStream fs = (System.IO.FileStream)saveFile1.OpenFile();
            }
            File.WriteAllText(saveFile1.FileName, Wordpad.Text);
        }
        private void saveFile1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 8;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_7.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_7.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_7.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_7.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_7.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }  
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 9;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_4.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_4.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_4.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_4.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_4.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 9;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_5.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_5.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_5.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_5.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_5.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 9;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_6.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_6.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_6.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_6.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_6.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 9;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_1.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_1.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_1.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_1.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_1.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 9;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_2.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_2.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_2.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_2.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_2.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = 2000;
                timer_on = true;
                label2.Text = "interval start";
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
            button_pressed = 9;
            if (timer_on == true)
            {


                if (times_pressed < 7)
                {
                    if (s.Length > 1)
                    {
                        timer.Start();
                        s = s.Substring(0, s.Length - 1);
                        Wordbuilder_tbx.Text = s;


                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_3.Items[times_pressed]));
                        times_pressed = times_pressed + 1;

                    }
                    else
                    {
                        timer.Start();
                        Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_3.Items[times_pressed]));
                        letter = Convert.ToString(ListBox_3.Items[times_pressed]);
                        times_pressed = times_pressed + 1;
                    }


                }
                else
                {
                    timer.Start();
                    s = s.Substring(0, s.Length - 1);
                    Wordbuilder_tbx.Text = s;
                    times_pressed = 0;
                    Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_3.Items[times_pressed]));
                    letter = Convert.ToString(ListBox_3.Items[times_pressed]);
                    times_pressed = times_pressed + 1;

                }

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wordpad.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.ShowDialog();
            if (openFile1.FileName != "") { 
                Wordpad.Text = File.ReadAllText(openFile1.FileName); 
            }
            
        }

        }
    }
