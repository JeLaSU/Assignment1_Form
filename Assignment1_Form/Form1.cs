using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment1_Form
{
    // TODO: Add variables and fill in code

    //private Thread trd; 

    /// <summary>
    /// The GUI for playing music and starting two graphical threads
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor. 
        /// </summary>
        MusicPlayer player = new MusicPlayer();

        public Form1()
        {
            InitializeComponent();
            //Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            //trd.IsBackground = true;
            //trd.Start();
        }

        /// <summary>
        /// Let the user choose his favorite music, either .waw or .mp3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// Display music file in GUI and tell player what to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = openFileDialog1.FileName;
            player.open(openFileDialog1.FileName);
        }

        /// <summary>
        /// Start the music maestro!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.play();
        }

        /// <summary>
        /// Stop playing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMp3Stop_Click(object sender, EventArgs e)
        {
            player.stop();
        }

        /// <summary>
        /// Creates a new triangle instance, and a new thread.
        /// Starts that thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Aborts the current triangle thread
        /// Also saves the current position of the triangle, for new starts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotStop_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// If threads are running or waitng at form close, stop threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        /// <summary>
        /// Creates a new DisplayName and a new thread
        /// Start the thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            
            //När man klickar "Start display" på klockan så startas en timer som redigerar 
            System.Timers.Timer timer = new System.Timers.Timer();
            
            //ta bort timer etc o ersätt ist med aktivera en thread som direkt gör thread.sleep(1000)
            //och sedan får invoke förändringen i texten via timer_elapsed

            //varje gång ett interval på 1000 millisekunder har förflutit så kallas metoden "Timer_Elapsed"
            timer.Interval = 1000;                      
            timer.Elapsed += Timer_Elapsed; 
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate()
            { //texten i label "lblClock" ändras till nuvarande datum
                lblClock.Text = DateTime.Now.ToString("T");
            }));
        }

        /// <summary>
        /// Aborts the display thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        /// <summary>
        /// If to draw something in game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblNOW_Click(object sender, EventArgs e)
        {

        }

        private void panThread_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //private void ThreadTask()
        //{
        //    int stp;
        //    int newval;

        //    Random rnd = new Random();

        //    while (true)
        //    {
        //        //Invoke(new MethodInvoker(delegate ()
        //        //{
        //        //lblClock.Text = DateTime.Now.ToString("T");
        //        //}

        //        //timer.Elapsed += Timer_Elapsed;

        //        Thread.Sleep(1000);
        //    }
        //}
    }
}
