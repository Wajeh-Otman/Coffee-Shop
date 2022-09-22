using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (comboCoffeeName.SelectedItem.ToString() == "Latte")
            {
                if (comboType.SelectedItem.ToString() == "Frapp") 
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 9).ToString();
                }

                else if (comboType.SelectedItem.ToString() == "Ice")
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 7).ToString();
                }

                else //comboType.SelectedItem.ToString() == "Hot"
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 5).ToString();
                }

            }

            else if(comboCoffeeName.SelectedItem.ToString() == "Chappuccino")
            {
                if (comboType.SelectedItem.ToString() == "Frapp")
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 10).ToString();
                }

                else if (comboType.SelectedItem.ToString() == "Ice")
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 8).ToString();
                }

                else //comboType.SelectedItem.ToString() == "Hot"
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 6).ToString();
                }
            }

            else
            {
                if (comboType.SelectedItem.ToString() == "Frapp")
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 8).ToString();
                }

                else if (comboType.SelectedItem.ToString() == "Ice")
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 6).ToString();
                }

                else //comboType.SelectedItem.ToString() == "Hot"
                {
                    txtPayment.Text = (float.Parse(comboQuantity.Text) * 4).ToString();
                }
            }

            dataGridView1.Rows.Add(txtID.Text, comboCoffeeName.Text, comboType.Text,
                comboQuantity.Text, txtPayment.Text);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else 
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            comboCoffeeName.Text = "";
            comboType.Text = "";
            comboQuantity.Text = "";
            txtPayment.Clear();
        }
    }
}
