using System;
using System.Windows.Forms;
using MetroFramework;

namespace TeeShirtShop
{

    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        int total = 0, subtotal = 0;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void declanbtn_Click(object sender, EventArgs e)
        {
            ShirtNamelbl.Text = "DECLAN MCKEENA";
            ProductDtlPanel.Focus();
        }

        private void fkabtn_Click(object sender, EventArgs e)
        {
            ShirtNamelbl.Text = "FKA TWIGS";
            ProductDtlPanel.Focus();
        }

        private void lanabtn_Click(object sender, EventArgs e)
        {
            ShirtNamelbl.Text = "LANA DEL REY";
            ProductDtlPanel.Focus();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            orderedGrid.Rows.Clear();
            orderedGrid.Refresh();
            SizeOptions.SelectedIndex = -1;
            ShirtNamelbl.Text = String.Empty;
            txbxQTY.Text = String.Empty;
            totallabel.Text = "$0";
            SizeOptions.Refresh();
        }

        private void bjorkbtn_Click(object sender, EventArgs e)
        {
            ShirtNamelbl.Text = "BJORK";
            ProductDtlPanel.Focus();
        }

        private void addcartbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ShirtNamelbl.Text) == false && SizeOptions.SelectedIndex != -1 && string.IsNullOrWhiteSpace(txbxQTY.Text) == false)
            {


                string shirtsize = SizeOptions.SelectedItem.ToString();
                if (shirtsize == "SMALL" || shirtsize == "MEDIUM" || shirtsize == "LARGE" || shirtsize == "EXTRA LARGE")
                {
                    subtotal = 16 * Convert.ToInt32(txbxQTY.Text);
                    MetroMessageBox.Show(this, "Shirt Name: " + ShirtNamelbl.Text + "\nSize: " + shirtsize.ToString() + "\nQuantity: " + txbxQTY.Text + "\nUnit Price: $16\nTotal Price: $" + 16 * Convert.ToInt32(txbxQTY.Text), "You Ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    orderedGrid.Rows.Add(ShirtNamelbl.Text, shirtsize.ToString(),txbxQTY.Text,
                        "$"+Convert.ToString(subtotal));
                    total += subtotal;
                
                }
                else
                {
                    subtotal = 20 * Convert.ToInt32(txbxQTY.Text);
                    MetroMessageBox.Show(this, "Shirt Name: " + ShirtNamelbl.Text + "\nSize: " + shirtsize.ToString() + "\nQuantity: " + txbxQTY.Text + "\nUnit Price: $20\nTotal Price: $" + 20 * Convert.ToInt32(txbxQTY.Text), "You Ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    orderedGrid.Rows.Add(ShirtNamelbl.Text, shirtsize.ToString(), txbxQTY.Text, "$"+Convert.ToString(subtotal));
                    total += subtotal;

                }


            }
            else { MetroMessageBox.Show(this, "Please fill out missing fields", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void getTotalbtn_Click(object sender, EventArgs e)
        {
            totallabel.Text = "$"+total.ToString();
        }

        private void txbxQTY_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ( char.IsLetter(e.KeyChar)||char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
         
        private void buybtn_Click(object sender, EventArgs ew)
        {
            if (string.IsNullOrWhiteSpace(ShirtNamelbl.Text) == false && SizeOptions.SelectedIndex != -1 && string.IsNullOrWhiteSpace(txbxQTY.Text) == false)
            {


                string shirtsize = SizeOptions.SelectedItem.ToString();
                if (shirtsize == "SMALL" || shirtsize == "MEDIUM" || shirtsize == "LARGE" || shirtsize == "EXTRA LARGE")
                {
                    MetroMessageBox.Show(this, "Shirt Name: " + ShirtNamelbl.Text + "\nSize: " + shirtsize.ToString() + "\nQuantity: "+txbxQTY.Text+"\nUnit Price: $16\nTotal Price: $" + 16 * Convert.ToInt32(txbxQTY.Text), "You Purchased", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MetroMessageBox.Show(this, "Shirt Name: " + ShirtNamelbl.Text + "\nSize: " + shirtsize.ToString() + "\nQuantity: " + txbxQTY.Text + "\nUnit Price: $20\nTotal Price: $" + 20 * Convert.ToInt32(txbxQTY.Text), "You Purchased", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


            }
            else { MetroMessageBox.Show(this, "Please fill out missing fields", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
    }
}
