using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Assignment1_Form
{
    // TODO: Add variables and fill in code

    /// <summary>
    /// The GUI for playing music and starting two graphical threads
    /// </summary>

    

    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor. 
        /// </summary>
     
        //[DllImport("winmm.dll")]
        //private static extern long mciSendString(string Command, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        MusicPlayer player = new MusicPlayer();

        bool clockStop;

        public Form1()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Let the user choose his favorite music, either .waw or .mp3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            //Thread trd = new Thread(t =>
            //{
            openFileDialog1.ShowDialog();

            /*
             * 
             * Skapa tråd, dela upp i olika if-satser som gås igenom beroende på variablar som förändras vid play/open/stop
             * 
             */

            
            
            //});
            //trd.Start();
        }

        /// <summary>
        /// Display music file in GUI and tell player what to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) //, string file
        {
            label1.Text = openFileDialog1.FileName;

            //string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            //mciSendString(command, null, 0, 0); 

            //openingFile = true;

            player.open(openFileDialog1.FileName);
        }

        /// <summary>
        /// Start the music maestro!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //string command = "play MyMp3";
            //mciSendString(command, null, 0, 0); 
            player.play();

            //playingMusic = true;
        }

        /// <summary>
        /// Stop playing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMp3Stop_Click(object sender, EventArgs e)
        {
            //string command = "stop MyMp3";
            //mciSendString(command, null, 0, 0); 
            player.stop();

            //playingMusic = false;
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
            //clock.start();
            clockStop = false;

            //Ny tråd skapas
            Thread clkTrd = new Thread(t =>
            {
                //Programmet kollar om 'stop' knappen har klickats medans klockan går.
                while (clockStop == false)
                {
                        Invoke(new MethodInvoker(delegate ()
                        { //texten i label "lblClock" ändras till nuvarande klockslag varje gång tråden är aktiv(en gång i sekunden).
                        lblClock.Text = DateTime.Now.ToString("T");
                        }));
                        Thread.Sleep(1000);
                }               
            })
            { IsBackground = true };
                clkTrd.Start();
        }

        /// <summary>
        /// Aborts the display thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayStop_Click(object sender, EventArgs e)
        {
            clockStop = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
