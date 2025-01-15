using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groentenboer_1._0_Project
{
    public partial class BonUserControl : UserControl
    {
        public BonUserControl()
        {
            InitializeComponent();
        }

        public void SetContent(string Aantal, /*Bitmap BonPlaatje,*/ decimal prijs)
        {
            AantalTxt.Text = Aantal;
/*            BonImages.Image = BonPlaatje;*/
            label2.Text = "€" + prijs.ToString("0.00");
        }
    }
}
