using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

/*
 * using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
 * 
 */

namespace Assignment2_Form
{
    public partial class Form1 : Form
    {
        TextRead textRead = new TextRead();
        Thread trd1_Word, trd2_Word, trd3_Word, trd4_Word, trd5_Word, trd_Type, trd_Score;
        List<Label> labelList = new List<Label>();

        bool start = false;
        
        int score;    

        public Form1()
        {
            InitializeComponent();
            lbl_Condition.Visible = false;
            btn_stop.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_score(object sender, EventArgs e)
        {
            
            
        }

        private void lbl_file(object sender, EventArgs e)
        {

        }

        private void lbl_word1(object sender, EventArgs e)
        {
           
        }

        private void lbl_word2(object sender, EventArgs e)
        {
            
        }

        private void lbl_word3(object sender, EventArgs e)
        {
            
        }

        private void lbl_word4(object sender, EventArgs e)
        {
            
        }

        private void lbl_word5(object sender, EventArgs e)
        {

        }

        private void lbl_condition(object sender, EventArgs e)
        {
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            start = false;           
        }

        private void write_Box(object sender, EventArgs e)
        {
            //Starts the thread that handles typing from the user.
            trd_Type =
            new Thread(t =>
            {

                while (start)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        //If the user has been detected as guessing a word the score is increased and the word removed.
                        for (int i = 0; i < textRead.words.Count; i++)
                        {
                            if (write_box.Text == textRead.words[i])
                            {
                                score++;
                                textRead.words.Remove(textRead.words[i]);                                
                            }
                        }
                        for (int l = 0; l < labelList.Count; l++)
                        {
                            //If the user types a word that is currently active its removed from the list.
                            if (write_box.Text == labelList[l].Text)
                            {
                                labelList[l].Text = null;
                                break;
                            }

                            //If a word reaches the end of the console then the 'you lose' lbl becomes visible and the game is counted as being lost.
                            if (labelList[l].Location.Y >= 489 + labelList[l].Size.Height)
                            {
                                lbl_Condition.Visible = true;
                                start = false;                               
                            }
                        }
                       
                    }));
                    Thread.Sleep(100);

                }
                
            })
            { IsBackground = true };
            trd_Type.Start();

        }

        private void btn_open(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //Once a txt.file is chosen the words inside will be added as the active words.
            label2.Text = openFileDialog1.FileName;

            textRead.open();
            word1.Text = textRead.word1;
            labelList.Add(word1);
            word2.Text = textRead.word2;
            labelList.Add(word2);
            word3.Text = textRead.word3;
            labelList.Add(word3);
            word4.Text = textRead.word4;
            labelList.Add(word4);
            word5.Text = textRead.word5;
            labelList.Add(word5);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            start = true;
            lbl_Condition.Visible = false;
            btn_stop.Visible = true;
            
            trd1_Word =
            new Thread(t =>
            {
                while (start) 
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        //The thread handles the function for a user to lose the game.
                        foreach (Label label in labelList)
                        {
                            if (label.Location.Y >= 450 - label.Height)
                            {
                                lbl_Condition.Visible = true;
                                start = false;
                            }
                        }
                        word1.Location = new Point(word1.Location.X, word1.Location.Y + 10);
                    }));
                    Thread.Sleep(1000);
                }              
            })
            { IsBackground = true };
            trd1_Word.Start();

            trd2_Word = 
            new Thread(t =>
            {
                while (start)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        word2.Location = new Point(word2.Location.X, word2.Location.Y + 15);
                    }));
                    Thread.Sleep(1800);
                }
            })
            { IsBackground = true };
            trd2_Word.Start();

            trd3_Word = 
            new Thread(t =>
            {
                while (start)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        word3.Location = new Point(word3.Location.X, word3.Location.Y + 20);
                    }));
                    Thread.Sleep(2500);
                }
            })
            { IsBackground = true };
            trd3_Word.Start();

            trd4_Word = 
            new Thread(t =>
            {
                while (start)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        word4.Location = new Point(word4.Location.X, word4.Location.Y + 5);
                    }));
                    Thread.Sleep(900);
                }
            })
            { IsBackground = true };
            trd4_Word.Start();

            trd5_Word =
            new Thread(t =>
            {
                while (start)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        word5.Location = new Point(word5.Location.X, word5.Location.Y + 10);
                    }));
                    Thread.Sleep(1800);
                }
            })
            { IsBackground = true };
            trd5_Word.Start();

            trd_Score =
            new Thread(t =>
            {
                while (start)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        lblscore.Text = "Score: " + score;
                    }));
                    Thread.Sleep(100);

                }
            })
            { IsBackground = true };
            trd_Score.Start();
        }
    }
    public class TextRead
    {
        public List<string> words = new List<string>();
        StreamReader file = new StreamReader("Words.txt");

        public string word1, word2, word3, word4, word5;
        public void open()
        {
            try
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    words.Add(line);//Adds a word to a spot on the list.                       
                }
                //Each word is activated at its position.
                word1 = words[0];
                word2 = words[1];
                word3 = words[2];
                word4 = words[3];
                word5 = words[4];

                //fileActive = true;
            }
            catch( Exception ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
    }
}
/*
 * 
 * Fixa att orden enbart faller om de har fått värden
 * Random ord ifrån .txt filen
 * stop börjar om positionen
 * fortsätt ge fler ord om man blir klar
 * rensa din gissning om du har rätt o klickar enter
 * 
 */