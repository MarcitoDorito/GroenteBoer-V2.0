using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groentenboer_2._0_Project
{
    public partial class BonUserControl : UserControl
    {
        MainForm mf;
        public BonUserControl()
        {
            InitializeComponent();
            BonImages.SizeMode = PictureBoxSizeMode.StretchImage;

            Button removeBtn = new Button();
            removeBtn.Text = "Verwijder";
            removeBtn.Size = new Size(70, 30);
            removeBtn.Location = new Point(200, 60);
            removeBtn.Click += RemoveBtn_Click;
            this.Controls.Add(removeBtn);
        }

        public void SetContent(string Aantal, Bitmap BonPlaatje,decimal prijs, MainForm mf)
        {
            AantalTxt.Text = Aantal;
            BonImages.Image = BonPlaatje;
            label2.Text = /*"€" + */prijs.ToString("0.00");
            this.mf = mf;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            mf.RemoveBon(this);
        }
    }
}
