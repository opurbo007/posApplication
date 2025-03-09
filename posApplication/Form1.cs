using System.Globalization;

namespace posApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public double costOfItem()
        {
            Double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;

        }

        private void addCost()
        {
            Double taxRate, q;
            taxRate = 5;
            if (dataGridView1.Rows.Count > 0)
            {
                tax.Text = costOfItem().ToString("C2", new CultureInfo("en-GB"));
                subTotal.Text = costOfItem().ToString("C2", new CultureInfo("en-GB"));
                q = ((costOfItem() * taxRate) / 100);
                total.Text = (costOfItem() + ((costOfItem() * 5) / 100)).ToString("C2", new CultureInfo("en-GB"));
                barcode.Text = Convert.ToString(q + costOfItem());

            }
        }
        
        //amount to repay
        private void Changes()
        {
            Double taxRate, q, c;
            taxRate = 5;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((costOfItem() * taxRate) / 100) + costOfItem();
                c = Convert.ToDouble(cash.Text);
                change.Text = (c - q).ToString("C2", new CultureInfo("en-GB"));

            }
        }

        Bitmap bitmap;


        //Print document 
        private void printButton(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                dataGridView1.Height = height;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //reset all fields
        private void resetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                barcode.Text = "";
                total.Text = "£0";
                change.Text = "£0";
                subTotal.Text = "£0";
                cash.Text = "";
                tax.Text = "£0";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cboPayment.Text = "select one";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
        //payment method 
        private void Form1_Load(object sender, EventArgs e)
        {
            cboPayment.Items.Add("Cash");
            cboPayment.Items.Add("Credit Card");
            cboPayment.Items.Add("Mobile Money");

        }

     
        //calculator 
        private void numbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (cash.Text == "0")
            {
                cash.Text = "";
                cash.Text = cash.Text + b.Text;
            }
            else if (b.Text == ".")
            {
                if (!cash.Text.Contains("."))
                {
                    cash.Text = cash.Text + b.Text;
                }
            }
            else
            {
                cash.Text = cash.Text + b.Text;

            }

        }

        private void clearNumberBtn(object sender, EventArgs e)
        {
            cash.Text = "0";
        }

        //pay buttonn
        private void payBtn(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cash.Text))
            {
                MessageBox.Show("Please enter the amount to pay");
                return;
            }

            if (string.IsNullOrWhiteSpace(cboPayment.Text))
            {
                MessageBox.Show("Please select the payment method");
                return;
            }

           
            string paymentMethod = cboPayment.Text.Trim().ToLower();

            if (paymentMethod != "cash" && paymentMethod != "card") 
            {
                MessageBox.Show("Only cash can be paid with this");
                return;
            }

            double cashAmount, totalAmount;

            // Remove "£" and trim
            string cashText = cash.Text.Replace("£", "").Trim();
            string totalText = total.Text.Replace("£", "").Trim();

            if (!double.TryParse(cashText, out cashAmount) || !double.TryParse(totalText, out totalAmount))
            {
                MessageBox.Show("Invalid amount entered");
                return;
            }

            if (cashAmount < totalAmount)
            {
                MessageBox.Show("The amount entered is less than the total cost");
            }
            else
            {
                cash.Text = cashAmount.ToString("F2");
                Changes();
            }
        }

        //remove single item
        private void removeBtn(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
            addCost();
            if (cboPayment.Text != "Cash")
            {
                Changes();
            }
            else
            {
                change.Text = "";
                cash.Text = "0";
            }
        }


        //add item to list
        private void AddToCart(string itemTitle, string itemPrice)
        {
            Double costOfItem = Double.Parse(itemPrice.Replace("£", "").Trim());


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == itemTitle)
                {
                    row.Cells[1].Value = (int)row.Cells[1].Value + 1;
                    row.Cells[2].Value = (int)row.Cells[1].Value * costOfItem;
                    addCost();
                    return;
                }
            }


            dataGridView1.Rows.Add(itemTitle, 1, costOfItem);
            addCost();
        }

        //call addToCart for every item
        private void item1AddToCart(object sender, EventArgs e)
        {
            AddToCart(item1Title.Text, item1Price.Text);
        }

        private void item2AddToCart(object sender, EventArgs e)
        {
            AddToCart(item2Title.Text, item2Price.Text);
        }

        private void item3AddToCart(object sender, EventArgs e)
        {
            AddToCart(item3Title.Text, item3Price.Text);
        }

        private void item4AddToCart(object sender, EventArgs e)
        {
            AddToCart(item4Title.Text, item4Price.Text);
        }

        private void item5AddToCart(object sender, EventArgs e)
        {
            AddToCart(item5Title.Text, item5Price.Text);
        }

        private void item6AddToCart(object sender, EventArgs e)
        {
            AddToCart(item6Title.Text, item6Price.Text);
        }

        private void item7AddToCart(object sender, EventArgs e)
        {
            AddToCart(item7Title.Text, item7Price.Text);
        }

        private void item8AddToCart(object sender, EventArgs e)
        {
            AddToCart(item8Title.Text, item8Price.Text);
        }

        private void item9AddToCart(object sender, EventArgs e)
        {
            AddToCart(item9Title.Text, item9Price.Text);
        }

        private void item10AddToCart(object sender, EventArgs e)
        {
            AddToCart(item10Title.Text, item10Price.Text);
        }

        private void item11AddToCart(object sender, EventArgs e)
        {
            AddToCart(item11Title.Text, item11Price.Text);
        }

        private void item12AddToCart(object sender, EventArgs e)
        {
            AddToCart(item12Title.Text, item12Price.Text);
        }

    }
}
