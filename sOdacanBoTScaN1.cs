using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Media;
using System.Drawing;
using System.Net.NetworkInformation;

//This is the source code of the epic software you used.
//First started worked on this on 15/11/2021
//Created by Weilderman.
//By the way, if this crashed your computer that's a bit of YOU problem, so sucks to be you.
namespace soda_can_robots_can1
{
    public partial class sOdacanBoTScaN1 : Form
    {
        private int num;
        public void setNum(int num) { this.num = num; }
        public int getNum() { return num; }
        public void rate(int guess, int num)
        {
            if (guess < num) label2.Text = "lol too low";
            else
            if (guess > num) label2.Text = "lol too high";
            else
            {
                label2.Text = "*** Correct, here is your soda. ***";
                SoundPlayer notifier =
new SoundPlayer(Properties.Resources._3_1tada1);
                notifier.Play();
            }

        }
        public sOdacanBoTScaN1()
        {
            InitializeComponent();
            Random rnd = new Random();
            setNum(rnd.Next(1, 21));
            if (File.Exists(@"C:\Users\mayez\Documents\superdupertest.txt"))
            {
                File.Delete(@"C:\Users\mayez\Documents\superdupertest.txt");
            }
            File.AppendAllText("C:\\Users\\mayez\\Desktop\\sodatest.txt", "sodacanbots\n");
            File.AppendAllText("C:\\Users\\mayez\\Documents\\sodadasodasoda.txt", "you know these robots, and you know what they are capable of and CAN do.\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer notifier =
 new SoundPlayer(Properties.Resources.pootis_sound_effect_4958197742021773312);
            notifier.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer notifier =
 new SoundPlayer(Properties.Resources.soda_can_sound1);
            notifier.Play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form().Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer notifier =
                    new SoundPlayer(Properties.Resources.affirmative);
            notifier.Play();
            string text = "DATE TIME PLACE COORDINATES? L+RATIO+MADCUZBAD+FAT+NERD+FAT+GENSHIN IMPACT PLAYER+STUPID";
            MessageBox.Show(text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (true)
            {
              Process.Start("mspaint");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Ribbons.scr");
            Process.Start("explorer");
            SoundPlayer notifier =
           new SoundPlayer(Properties.Resources.Windows_Exclamation);
            notifier.Play();
            MessageBox.Show("you are required to drink soda and eat all the doughnuts. do you wish to proceed?", "do you like soda?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Process.Start("explorer");
                new SoundPlayer(Properties.Resources._3_1tada1);
                notifier.Play();
            }
            if (DialogResult == DialogResult.No) Process.Start("Ribbons.scr");
        }

        private void button6_Click(object sender, EventArgs e)
        {
           SoundPlayer notifier =
new SoundPlayer(Properties.Resources.epicsong1);
            notifier.Play();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer notifier =
new SoundPlayer(Properties.Resources._3_1tada1);
            notifier.Play();
            Process.Start("SnippingTool");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoundPlayer notifier =
new SoundPlayer(Properties.Resources.arabfunny3);
            notifier.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 32; i++)
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://www.microsoft.com/en-gb/");
            }
            System.Diagnostics.Process.Start("explorer.exe", "https://www.windows93.net/");
            System.Diagnostics.Process.Start("explorer.exe", "https://engineer.tf/");
            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
            for (int i = 0; i < 15; i++)
            {
                Process.Start("mspaint");
                Process.Start("notepad");
            }
            Process.Start("cmd");
            string exepath = "C:\\Windows\\py.exe";
            if(File.Exists(exepath));
            {
                Process.Start(exepath);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Statements will be inserted here.
            //It is too bad he was not given a voicebox.
            //Drink some more soda.
            //Keep on drinking the soda.
            //....
            string path = "C:\\Users\\mayez\\Desktop\\sodatest.txt";
            string poem = "\r\n\tThis robot finds out he has recently been assembled.";
            poem += "\r\n\tAs he arrives at the end of the assembly line, he awaits deployment.";
            poem += "\r\n\tOld conciousness, almost never could see the light of day again.";
            poem += "\r\n\tWe would not let his soul into the promised land above just yet- there is work yet to be done.";
            poem += "\r\n\t\"Uhh sir? I think that droid with the body type A has a damaged voicebox.\"";
            poem += "\r\n\t\"Get back to your proggraming work and keep drinking your soda. That is not for you or me to care about. Understand?\"";
            poem += "\r\n\t\"Yes sir...\"";
            if (File.Exists(path))
            {
                Console.WriteLine("File Already Exists: " + path);
                Console.WriteLine("If you believed that the file did not exist, you are a bumbling imbecile.");
            }
            else
            { 
              //Nothing to see here. So keep drinking your can of soda.
            }
            Console.Read();
            try
            {
                File.WriteAllText(path, poem);
                Console.WriteLine("File Written: " + path);
            }
            catch (Exception error)
            {
              Console.WriteLine(error.Message);
            }
            System.IO.DirectoryInfo di = new DirectoryInfo("C:\\Users\\mayez\\Desktop\\supersodadirectory");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt16(textBox1.Text);
            rate(guess, getNum());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(textBox2.Text, 1000);
            SoundPlayer notifier =
new SoundPlayer(Properties.Resources._3_1tada1);
            notifier.Play();
            MessageBox.Show(reply.Status.ToString());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SoundPlayer notifier =
new SoundPlayer(Properties.Resources.scream11);
            notifier.Play();
        }
    }
}