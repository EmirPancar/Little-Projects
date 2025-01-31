using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Zar1.Text="";
            Zar2.Text="";
            a.Text="";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.Text="";
            Random z = new Random();
            int z1=z.Next(1, 7);
            Zar1.Text=z1.ToString();

            int z2=z.Next(1, 7);
            Zar2.Text=z2.ToString();

            if(z1==z2)
            {
                switch (z1)
                {
                    case 1: a.Text="Hep Yek"; break;
                    case 2: a.Text="Dü bara"; break;
                    case 3: a.Text="Düş se"; break;
                    case 4: a.Text="Dört Cehar"; break;
                    case 5: a.Text="Dübeş"; break;
                    case 6: a.Text="Düşeş"; break;

                }
            }


            switch (z1)
                {
                    case 1: p1.Image=Image.FromFile("1.png"); break;
                    case 2: p1.Image=Image.FromFile("2.png"); break;
                    case 3: p1.Image=Image.FromFile("3.png"); break;
                    case 4: p1.Image=Image.FromFile("4.png"); break;
                    case 5: p1.Image=Image.FromFile("5.png"); break;
                    case 6: p1.Image=Image.FromFile("6.png"); break;


                }

            switch (z2)
            {
                case 1: p2.Image=Image.FromFile("1.png"); break;
                case 2: p2.Image=Image.FromFile("2.png"); break;
                case 3: p2.Image=Image.FromFile("3.png"); break;
                case 4: p2.Image=Image.FromFile("4.png"); break;
                case 5: p2.Image=Image.FromFile("5.png"); break;
                case 6: p2.Image=Image.FromFile("6.png"); break;


            }           

        }
    }
}
