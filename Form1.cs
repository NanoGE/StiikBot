    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace WindowsFormsApp3
    {
        public partial class Form1 : Form
        {
          
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                webBrowser1.Navigate("https://stiick.xyz//register");
                
        }

            private void button1_Click(object sender, EventArgs e)
            {
            webBrowser1.Document.GetElementById("username").SetAttribute("value", "sneak");
            webBrowser1.Document.GetElementById("email").SetAttribute("value", "hcoy4@wimsg.com");
            webBrowser1.Document.GetElementById("password").SetAttribute("value", "lol123");
            webBrowser1.Document.GetElementById("confirm_password").SetAttribute("value", "lol123");
            webBrowser1.Document.GetElementById("gender").SetAttribute("value", "male");
            

        }
            
        }

    }
