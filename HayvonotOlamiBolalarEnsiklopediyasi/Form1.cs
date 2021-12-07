using HayvonotOlamiBolalarEnsiklopediyasi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvonotOlamiBolalarEnsiklopediyasi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            showAuthor();
            comboBox1.DataSource = new BindingSource(animals, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }
        private void showAuthor()
        {
            frmInfo frmInf = new frmInfo();
            frmInf.ShowDialog();
        }

        private Dictionary<int, string> animals = new Dictionary<int, string>()
        {
            {0, "" },
            {1, "Timsoh" },
            {2, "Kobra iloni" },
            {3, "Sher" },
            {4, "Akulala" },
            {5, "Boʻri" },
            {6, "Burgut" },
            {7, "Ayiq" },
            {8, "Yoʻlbars" },
            {9, "Tulki" },
            {10, "Chayon" },
            {11, "Boyoʻgʻli" },
            {12, "Sirtlon" },
            {13, "Qoplon" },
            {14, "Anakonda" },
            {15, "Meduza" },
            {16, "Yaguar" },
            {17, "Begemot" },
            {18, "Echkemar" }
        };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
           
            if (comboBox1.SelectedIndex != 0)
            {
                title.Text = animals[comboBox1.SelectedIndex];
                content.Text = (String) Resources.ResourceManager.GetString("s" + comboBox1.SelectedIndex);
                pictureBox1.Image = (Bitmap) HayvonotOlamiBolalarEnsiklopediyasi.Properties.Resources.ResourceManager.GetObject("p" + comboBox1.SelectedIndex + "_1");
                pictureBox2.Image = (Image) HayvonotOlamiBolalarEnsiklopediyasi.Properties.Resources.ResourceManager.GetObject("p" + comboBox1.SelectedIndex + "_2");
            }
            else
            {
                //TODO should be cleaned the window
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                content.Text = "";
                title.Text = "";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAuthor();

        }
    }
}
