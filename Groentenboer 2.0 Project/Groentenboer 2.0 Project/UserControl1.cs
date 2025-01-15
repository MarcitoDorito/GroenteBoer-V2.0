using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Groentenboer_1._0_Project
{
    public partial class UserControl1 : UserControl
    {
        public Bitmap plaatje { get; private set; }

        public string naam;
        public UserControl1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SetContent(string groenten, Bitmap plaatjePath, decimal prijs)
        {
            label1.Text = groenten;
            naam = groenten;
            pictureBox1.Image = plaatjePath;
            label2.Text = "€" + prijs.ToString("0.00") + " per kilo";

            plaatje = plaatjePath;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
