using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string username, email, password;
        public int lines, maxline = 0, sline;

        

        public int pwlength = 12;
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://stiick.xyz//register");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generator.Start();

        }
        private void generator_Tick_1(object sender, EventArgs e)
        {
            lines = 0;

            StreamReader sr_username = new StreamReader("data\\username.txt");

            while (sr_username.ReadLine() != null)
            {
                lines++;
            }

            lines--;
            maxline = lines;

            Random rnd = new Random();
            sline = rnd.Next(1, maxline);

            StreamReader sr_username2 = new StreamReader("data\\username.txt");

            int i = 0;

            while (i < sline)
            {
                i++;
                username = sr_username2.ReadLine();
            }

            webBrowser1.Document.GetElementById("username").SetAttribute("value", username);

            lines = 0;
            StreamReader sr_email = new StreamReader("data\\email.txt");

            while (sr_email.ReadLine() != null)
            {
                lines++;
            }
            lines--;
            maxline = lines;


            sline = rnd.Next(1, maxline);

            StreamReader sr_email2 = new StreamReader("data\\email.txt");

            i = 0;

            while (i < sline)
            {
                i++;
                email = sr_email2.ReadLine();
            }

            webBrowser1.Document.GetElementById("email").SetAttribute("value", email);
            


            int number = 0;
            string password = "abcdefghijklmnopqrstuvwxyz12345679", newpw = "";
            char letter;

            while (i < pwlength)
            {
                number = rnd.Next(1, password.Length - 1);
                letter = password[number];
                newpw = newpw + letter;
                i++;
            }

            webBrowser1.Document.GetElementById("password").SetAttribute("value", password);
        }

    }
}
