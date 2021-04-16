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
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://stiick.xyz//register");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generator.Start();

        }
        private void generator_Tick(object sender, EventArgs e)
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
            lines = 0;
            StreamReader sr_password = new StreamReader("data\\password.txt");

            while (sr_password.ReadLine() != null)
            {
                lines++;
            }
            maxline = lines;


            sline = rnd.Next(1, maxline);

            StreamReader sr_password2 = new StreamReader("data\\password.txt");

            i = 0;

            while (i < sline)
            {
                i++;
                email = sr_password2.ReadLine();
            }
            webBrowser1.Document.GetElementById("password").SetAttribute("value", password);


        }

    }
}
