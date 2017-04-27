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
    {  //declares varibles to be used by the code
        string Str_keystrokes;
        int times_pressed = 0;
        string letter;
        int button_pressed;

        //timer varibles
        Timer timer = new Timer();
        bool timer_on = false;

        ListBox globalList = new ListBox();
        //varible of the saving function
        SaveFileDialog saveFile1 = new SaveFileDialog();
        int user_interval = 1000;
        

        public Form1()
        {
            InitializeComponent();




            
        }
        public void append_text() { 
        
        }

        private void Mode_btn_Click(object sender, EventArgs e)
        {
            //changes the mode
            if (modeStatus_txt.Text == "Multi-Press"){
                modeStatus_txt.Text = "Prediction";}
            else{
                modeStatus_txt.Text = "Multi-Press";
            }
            
        }
        // code is the same for every button so only commented once.
        private void Button_8_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            if (timer_on == false)
            {
                //if the timer has not started start the timer
                timer.Interval = user_interval;
                timer_on = true;
                label2.Text = "interval start";
                //when the timer runs out handle this event
                timer.Tick += new EventHandler(timer_Tick);
                ;
            }
                button_pressed = 8;
                
                if (timer_on == true)
                {
                    //will do this when the timer set up

                    if (times_pressed < 7)
                    {
                        if (s.Length > 1)
                        {
                            //starts timer then removes last letter from wordbuilder
                            timer.Start();
                            s = s.Substring(0, s.Length - 1);
                            Wordbuilder_tbx.Text = s;

                            //puts the last letter to one selected, moves the index up one
                            Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_8.Items[times_pressed]));
                            times_pressed = times_pressed + 1;

                        }
                        else
                        {
                            //same code but for if there is no charatures in the wordbuilder, will not remove a letter 
                            timer.Start();
                            Wordbuilder_tbx.AppendText(Convert.ToString(ListBox_8.Items[times_pressed]));
                            letter = Convert.ToString(ListBox_8.Items[times_pressed]);
                            times_pressed = times_pressed + 1;
                        }
                        
                        
                    }
                    else
                    {
                        //same code but resets the times_pressed to 0
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
        //the code for the charature buttons is all the same, see first button for comments on code
        private void Button_9_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            timer.Stop();
            if (timer_on == false)
            {
                timer.Interval = user_interval;
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
            //this will run when the timer has run out
            label3.Text = letter;

            //adds the chosen letter to the wordbuilder
            Wordbuilder_tbx.AppendText(letter);
            label2.Text = "interval end";
            letter = "";
            //stops the timer
            timer.Stop();
            timer_on = false;

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            //will send the text to the wordpad and then clear the wordbuilder
           Wordpad.AppendText(Wordbuilder_tbx.Text) ;
           Wordpad.AppendText(" ");
           Wordbuilder_tbx.Text = "";
           times_pressed = 0;
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            //adds a newline in the wordpad
            Wordpad.AppendText(Environment.NewLine);
        }

        private void cOnfiureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checks that there is a valid filename
            
            if (saveFile1.FileName != ""){
                //writes the text in the wordpad
            File.WriteAllText(saveFile1.FileName, Wordpad.Text);
            }
            else
            {
                //if no filename ask the user to choose were to save files
                saveFile1.ShowDialog();
                if (saveFile1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFile1.OpenFile();
                }
                File.WriteAllText(saveFile1.FileName, Wordpad.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //same as previous code were it askes the users to choose were to save
            saveFile1.ShowDialog();
            if (saveFile1.FileName != "") {
                System.IO.FileStream fs = (System.IO.FileStream)saveFile1.OpenFile();
            }
            File.WriteAllText(saveFile1.FileName, Wordpad.Text);
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            string s = Wordbuilder_tbx.Text;
            if (timer_on == false)
            {
                timer.Interval = user_interval;
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
                timer.Interval = user_interval;
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
                timer.Interval = user_interval;
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
                timer.Interval = user_interval;
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
                timer.Interval = user_interval;
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
                timer.Interval = user_interval;
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
                timer.Interval = user_interval;
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
            //clears the wordpad
            Wordpad.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes the application
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

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uses the MyDialogs input box to  get the uses input for interval
            user_interval = Convert.ToInt32(MyDialogs.My_Dialogs.InputBox("please enter an interval"));
        }

        }
    }
