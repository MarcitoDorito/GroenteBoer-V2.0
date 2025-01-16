using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Google.Protobuf.WellKnownTypes;

namespace Groentenboer_2._0_Project
{
    public partial class Form1 : Form
    {
        public decimal optelPrijs;
        private const string ConnectionString = "Server=localhost;Database=groenteboer;user=root;";
        DatabaseHelper dbHelper = new DatabaseHelper(ConnectionString);
        private int totalRowIndex;
        private decimal totalPrice = 0m;
        private int selectedRowIndex = -1;
        private bool productSelected = false;

        public Form1()
        {
            InitializeComponent();
            productNaamTxt.Text = "Product";
            prijsTxt.Text = "Aantal";
            aantalTxt.Text = "Prijs";
            AantalTellerTxt.Enabled = false;
            numbPad.Visible = false;
            DeleteBtn.Visible = false;
        }

        public void ProductSelect(object sender, EventArgs e, DatabaseHelper.GroenteNaam item)
        {
            productSelected = true;
            decimal newPrijs = new decimal(item.prijs) / 100;
            optelPrijs = newPrijs;
            ProductnaamTbx.Text = item.productNaam;
            AantalTellerTxt.Text = "0";
            PrijsTbx.Text = newPrijs.ToString("0.00");
            numpad_visable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DatabaseHelper.GroenteNaam> groentenLijst = dbHelper.GetGroenten();

            foreach (DatabaseHelper.GroenteNaam item in groentenLijst)
            {
                UserControl1 uc = new UserControl1();
                uc.Size = new Size(200, 200); // Set a size for the user control
                productenFlp.Controls.Add(uc);
                uc.Click += new EventHandler((s, e2) => ProductSelect(s, e2, item));
                uc.BackColor = SystemColors.Window;
                decimal newPrijs = new decimal(item.prijs) / 100;
                uc.SetContent(item.productNaam, item.plaatje, newPrijs);

                foreach (Control uc2 in uc.Controls)
                {
                    uc2.Click += new EventHandler((s, e2) => ProductSelect(s, e2, item));
                }
            }
            BonGrid.Columns.Add("Product", "Product");
            BonGrid.Columns.Add("Aantal", "Aantal");
            BonGrid.Columns.Add("Prijs", "Prijs (€)");

            totalRowIndex = BonGrid.Rows.Add("Totaal", "", totalPrice.ToString("0.00"));

            this.Refresh();

            BonGrid.CellClick += BonGrid_CellClick;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(AantalTellerTxt.Text) < 1 || string.IsNullOrEmpty(ProductnaamTbx.Text) || string.IsNullOrEmpty(PrijsTbx.Text))
            {
                MessageBox.Show("Voer een aantal in en selecteer een product!");
            }
            else
            {
                decimal bonPrijs = optelPrijs * decimal.Parse(AantalTellerTxt.Text);
                totalPrice += bonPrijs;

                // Add new row to BonGrid
                BonGrid.Rows.Insert(totalRowIndex, ProductnaamTbx.Text, AantalTellerTxt.Text, bonPrijs.ToString("0.00"));

                // Update the total price row
                BonGrid.Rows[BonGrid.Rows.Count - 1].Cells[2].Value = totalPrice.ToString("0.00");

                // Clear the input fields
                

                AddUserControl(bonPrijs);

                numpad_visable();

                /*bonUserControl.SetContent(ProductnaamTbx.Text, bonPrijs);*/
            }
        }

        private void Numpad(object sender, EventArgs e)
        {
            System.Windows.Forms.Button keyPad = (System.Windows.Forms.Button)sender;
            if (AantalTellerTxt.Text == "0" && !string.IsNullOrEmpty(ProductnaamTbx.Text) && !string.IsNullOrEmpty(PrijsTbx.Text))
            {
                AantalTellerTxt.Clear();
            }
            if (AantalTellerTxt.Text.Length < 3 && !string.IsNullOrEmpty(ProductnaamTbx.Text) && !string.IsNullOrEmpty(PrijsTbx.Text))
            {
                string input = keyPad.Text;
                AantalTellerTxt.Text += input;
            }
            if (keyPad.Text == "Reset")
            {
                AantalTellerTxt.Text = "0";
            }
        }

        private void BonGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteBtn.Visible = true;
            if (e.RowIndex >= 0 && e.RowIndex != totalRowIndex)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void numpad_visable()
        {
            if (productSelected)
            {
                numbPad.Visible = true;
            }
            else
            {
                numbPad.Visible = false;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex != BonGrid.Rows.Count - 1)
            {
                DataGridViewRow row = BonGrid.Rows[selectedRowIndex];
                decimal rowPrice = Convert.ToDecimal(row.Cells[2].Value);
                totalPrice -= rowPrice;

                // Remove the row from the DataGridView
                BonGrid.Rows.RemoveAt(selectedRowIndex);

                // Update the total price row
                BonGrid.Rows[BonGrid.Rows.Count - 1].Cells[2].Value = totalPrice.ToString("0.00");

                DeleteBtn.Visible = false;
                selectedRowIndex = -1;
            }
        }

        private Bitmap GetProductImage(String productName)
        {
            //List<DatabaseHelper.GroenteNaam> groentenLijst = dbHelper.GetGroenten();
            //var product = groentenLijst.FirstOrDefault(g => g.productNaam == productName);
            Bitmap test = (Bitmap) Properties.Resources.ResourceManager.GetObject(productName);
            return test;
        }

        private void AddUserControl(decimal bonPrijs)
        {
            BonUserControl bonUserControl = new BonUserControl();

            Bitmap plaatje = GetProductImage(ProductnaamTbx.Text);

            BonFlowPannel.Controls.Add(bonUserControl);

            bonUserControl.BackColor = SystemColors.Window;

            string bonAantal = AantalTellerTxt.Text;

            bonUserControl.SetContent(bonAantal, plaatje, bonPrijs);

            AantalTellerTxt.Text = "0";
            ProductnaamTbx.Text = "";

            PrijsTbx.Text = "";

            productSelected = false;
        }
    }
}