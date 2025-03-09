namespace posApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button11 = new Button();
            button10 = new Button();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button9 = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            button16 = new Button();
            resetbtn = new Button();
            print = new Button();
            pay = new Button();
            panel5 = new Panel();
            cboPayment = new ComboBox();
            changeTitle = new Label();
            cashTitle = new Label();
            change = new Label();
            cash = new Label();
            paymentMethod = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            total = new Label();
            tax = new Label();
            subTotal = new Label();
            label1 = new Label();
            panel3 = new Panel();
            item10Title = new Label();
            item1Title = new Label();
            item8Price = new Label();
            item12Price = new Label();
            item4Price = new Label();
            item7Price = new Label();
            item11Price = new Label();
            item3Price = new Label();
            item6Price = new Label();
            item10Price = new Label();
            item2Price = new Label();
            item5Price = new Label();
            item9Price = new Label();
            item1Price = new Label();
            item8Title = new Label();
            item12Title = new Label();
            item4Title = new Label();
            item7Title = new Label();
            item11Title = new Label();
            item3Title = new Label();
            item6Title = new Label();
            item2Title = new Label();
            item5Title = new Label();
            item9Title = new Label();
            item8 = new Button();
            item12 = new Button();
            item4 = new Button();
            item7 = new Button();
            item11 = new Button();
            item3 = new Button();
            item6 = new Button();
            item10 = new Button();
            item1 = new Button();
            item2 = new Button();
            item5 = new Button();
            item9 = new Button();
            barcode = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 523);
            panel1.TabIndex = 0;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Info;
            button8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(192, 0, 0);
            button8.Location = new Point(219, 389);
            button8.Name = "button8";
            button8.Padding = new Padding(5);
            button8.Size = new Size(83, 85);
            button8.TabIndex = 0;
            button8.Text = "C";
            button8.UseVisualStyleBackColor = false;
            button8.Click += clearNumberBtn;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Info;
            button7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(117, 389);
            button7.Name = "button7";
            button7.Padding = new Padding(5);
            button7.Size = new Size(83, 85);
            button7.TabIndex = 0;
            button7.Text = "0";
            button7.UseVisualStyleBackColor = false;
            button7.Click += numbersOnly;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Info;
            button11.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(219, 277);
            button11.Name = "button11";
            button11.Padding = new Padding(5);
            button11.Size = new Size(83, 85);
            button11.TabIndex = 0;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = false;
            button11.Click += numbersOnly;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Info;
            button10.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(117, 277);
            button10.Name = "button10";
            button10.Padding = new Padding(5);
            button10.Size = new Size(83, 85);
            button10.TabIndex = 0;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = false;
            button10.Click += numbersOnly;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(219, 172);
            button5.Name = "button5";
            button5.Padding = new Padding(5);
            button5.Size = new Size(83, 85);
            button5.TabIndex = 0;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = false;
            button5.Click += numbersOnly;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(117, 172);
            button4.Name = "button4";
            button4.Padding = new Padding(5);
            button4.Size = new Size(83, 85);
            button4.TabIndex = 0;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = false;
            button4.Click += numbersOnly;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Info;
            button6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(19, 389);
            button6.Name = "button6";
            button6.Padding = new Padding(5);
            button6.Size = new Size(83, 85);
            button6.TabIndex = 0;
            button6.Text = ".";
            button6.UseVisualStyleBackColor = false;
            button6.Click += numbersOnly;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Info;
            button9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(19, 277);
            button9.Name = "button9";
            button9.Padding = new Padding(5);
            button9.Size = new Size(83, 85);
            button9.TabIndex = 0;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = false;
            button9.Click += numbersOnly;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(219, 61);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(83, 85);
            button2.TabIndex = 0;
            button2.Text = "9";
            button2.UseVisualStyleBackColor = false;
            button2.Click += numbersOnly;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(19, 172);
            button3.Name = "button3";
            button3.Padding = new Padding(5);
            button3.Size = new Size(83, 85);
            button3.TabIndex = 0;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += numbersOnly;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(117, 61);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(83, 85);
            button1.TabIndex = 0;
            button1.Text = "8";
            button1.UseVisualStyleBackColor = false;
            button1.Click += numbersOnly;
            // 
            // button
            // 
            button.BackColor = SystemColors.Info;
            button.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.Location = new Point(19, 61);
            button.Name = "button";
            button.Padding = new Padding(5);
            button.Size = new Size(83, 85);
            button.TabIndex = 0;
            button.Text = "7";
            button.UseVisualStyleBackColor = false;
            button.Click += numbersOnly;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(12, 557);
            panel2.Name = "panel2";
            panel2.Size = new Size(1516, 229);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Info;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(button16);
            panel6.Controls.Add(resetbtn);
            panel6.Controls.Add(print);
            panel6.Controls.Add(pay);
            panel6.Location = new Point(1084, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(407, 195);
            panel6.TabIndex = 0;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.HighlightText;
            button16.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(210, 109);
            button16.Name = "button16";
            button16.Padding = new Padding(5);
            button16.Size = new Size(179, 68);
            button16.TabIndex = 0;
            button16.Text = "Remove Item";
            button16.UseVisualStyleBackColor = false;
            button16.Click += removeBtn;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = SystemColors.HighlightText;
            resetbtn.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetbtn.Location = new Point(210, 15);
            resetbtn.Name = "resetbtn";
            resetbtn.Padding = new Padding(5);
            resetbtn.Size = new Size(179, 67);
            resetbtn.TabIndex = 0;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // print
            // 
            print.AccessibleName = "print";
            print.BackColor = SystemColors.HighlightText;
            print.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            print.Location = new Point(16, 110);
            print.Name = "print";
            print.Padding = new Padding(5);
            print.Size = new Size(175, 66);
            print.TabIndex = 0;
            print.Text = "Print";
            print.UseVisualStyleBackColor = false;
            print.Click += printButton;
            // 
            // pay
            // 
            pay.BackColor = Color.White;
            pay.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pay.Location = new Point(16, 15);
            pay.Name = "pay";
            pay.Padding = new Padding(5);
            pay.Size = new Size(175, 67);
            pay.TabIndex = 0;
            pay.Text = "Pay";
            pay.UseVisualStyleBackColor = false;
            pay.Click += payBtn;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Info;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(cboPayment);
            panel5.Controls.Add(changeTitle);
            panel5.Controls.Add(cashTitle);
            panel5.Controls.Add(change);
            panel5.Controls.Add(cash);
            panel5.Controls.Add(paymentMethod);
            panel5.Location = new Point(522, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(544, 195);
            panel5.TabIndex = 0;
            // 
            // cboPayment
            // 
            cboPayment.BackColor = SystemColors.HighlightText;
            cboPayment.Cursor = Cursors.PanSouth;
            cboPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboPayment.FormattingEnabled = true;
            cboPayment.Location = new Point(281, 29);
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(243, 29);
            cboPayment.TabIndex = 1;
            cboPayment.Text = "select one";
            // 
            // changeTitle
            // 
            changeTitle.AutoSize = true;
            changeTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeTitle.Location = new Point(13, 140);
            changeTitle.Name = "changeTitle";
            changeTitle.Size = new Size(110, 37);
            changeTitle.TabIndex = 0;
            changeTitle.Text = "Change";
            // 
            // cashTitle
            // 
            cashTitle.AutoSize = true;
            cashTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashTitle.Location = new Point(13, 78);
            cashTitle.Name = "cashTitle";
            cashTitle.Size = new Size(76, 37);
            cashTitle.TabIndex = 0;
            cashTitle.Text = "Cash";
            // 
            // change
            // 
            change.BackColor = SystemColors.HighlightText;
            change.BorderStyle = BorderStyle.Fixed3D;
            change.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change.Location = new Point(281, 141);
            change.Name = "change";
            change.Size = new Size(243, 37);
            change.TabIndex = 0;
            change.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cash
            // 
            cash.BackColor = SystemColors.HighlightText;
            cash.BorderStyle = BorderStyle.Fixed3D;
            cash.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cash.Location = new Point(281, 79);
            cash.Name = "cash";
            cash.Size = new Size(243, 37);
            cash.TabIndex = 0;
            cash.TextAlign = ContentAlignment.MiddleRight;
            // 
            // paymentMethod
            // 
            paymentMethod.AutoSize = true;
            paymentMethod.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentMethod.Location = new Point(13, 15);
            paymentMethod.Name = "paymentMethod";
            paymentMethod.Size = new Size(228, 37);
            paymentMethod.TabIndex = 0;
            paymentMethod.Text = "Payment Method";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Info;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(total);
            panel4.Controls.Add(tax);
            panel4.Controls.Add(subTotal);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(16, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(489, 195);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 140);
            label3.Name = "label3";
            label3.Size = new Size(76, 37);
            label3.TabIndex = 0;
            label3.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 78);
            label2.Name = "label2";
            label2.Size = new Size(57, 37);
            label2.TabIndex = 0;
            label2.Text = "Tax";
            // 
            // total
            // 
            total.BackColor = SystemColors.HighlightText;
            total.BorderStyle = BorderStyle.Fixed3D;
            total.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(198, 141);
            total.Name = "total";
            total.Size = new Size(268, 37);
            total.TabIndex = 0;
            total.Text = "£0";
            total.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tax
            // 
            tax.BackColor = SystemColors.HighlightText;
            tax.BorderStyle = BorderStyle.Fixed3D;
            tax.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tax.Location = new Point(198, 79);
            tax.Name = "tax";
            tax.Size = new Size(268, 37);
            tax.TabIndex = 0;
            tax.Text = "£0";
            tax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subTotal
            // 
            subTotal.BackColor = SystemColors.HighlightText;
            subTotal.BorderStyle = BorderStyle.Fixed3D;
            subTotal.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotal.Location = new Point(198, 15);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(268, 37);
            subTotal.TabIndex = 0;
            subTotal.Text = "£0";
            subTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "Sub-Total";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(item10Title);
            panel3.Controls.Add(item1Title);
            panel3.Controls.Add(item8Price);
            panel3.Controls.Add(item12Price);
            panel3.Controls.Add(item4Price);
            panel3.Controls.Add(item7Price);
            panel3.Controls.Add(item11Price);
            panel3.Controls.Add(item3Price);
            panel3.Controls.Add(item6Price);
            panel3.Controls.Add(item10Price);
            panel3.Controls.Add(item2Price);
            panel3.Controls.Add(item5Price);
            panel3.Controls.Add(item9Price);
            panel3.Controls.Add(item1Price);
            panel3.Controls.Add(item8Title);
            panel3.Controls.Add(item12Title);
            panel3.Controls.Add(item4Title);
            panel3.Controls.Add(item7Title);
            panel3.Controls.Add(item11Title);
            panel3.Controls.Add(item3Title);
            panel3.Controls.Add(item6Title);
            panel3.Controls.Add(item2Title);
            panel3.Controls.Add(item5Title);
            panel3.Controls.Add(item9Title);
            panel3.Controls.Add(item8);
            panel3.Controls.Add(item12);
            panel3.Controls.Add(item4);
            panel3.Controls.Add(item7);
            panel3.Controls.Add(item11);
            panel3.Controls.Add(item3);
            panel3.Controls.Add(item6);
            panel3.Controls.Add(item10);
            panel3.Controls.Add(item1);
            panel3.Controls.Add(item2);
            panel3.Controls.Add(item5);
            panel3.Controls.Add(item9);
            panel3.Location = new Point(819, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(709, 523);
            panel3.TabIndex = 0;
            // 
            // item10Title
            // 
            item10Title.BackColor = SystemColors.Info;
            item10Title.FlatStyle = FlatStyle.Popup;
            item10Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item10Title.ForeColor = Color.Black;
            item10Title.Location = new Point(235, 471);
            item10Title.Name = "item10Title";
            item10Title.Size = new Size(107, 31);
            item10Title.TabIndex = 1;
            item10Title.Text = "chicken Skewers";
            item10Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item1Title
            // 
            item1Title.BackColor = SystemColors.Info;
            item1Title.FlatStyle = FlatStyle.Popup;
            item1Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item1Title.ForeColor = Color.Black;
            item1Title.Location = new Point(77, 143);
            item1Title.Name = "item1Title";
            item1Title.Size = new Size(94, 31);
            item1Title.TabIndex = 1;
            item1Title.Text = "Chesse Pasta";
            item1Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item8Price
            // 
            item8Price.BackColor = SystemColors.Info;
            item8Price.FlatStyle = FlatStyle.Popup;
            item8Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item8Price.ForeColor = Color.Red;
            item8Price.Location = new Point(651, 289);
            item8Price.Name = "item8Price";
            item8Price.Size = new Size(33, 21);
            item8Price.TabIndex = 1;
            item8Price.Text = "£14";
            item8Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item12Price
            // 
            item12Price.BackColor = SystemColors.Info;
            item12Price.FlatStyle = FlatStyle.Popup;
            item12Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item12Price.ForeColor = Color.Red;
            item12Price.Location = new Point(651, 453);
            item12Price.Name = "item12Price";
            item12Price.Size = new Size(33, 21);
            item12Price.TabIndex = 1;
            item12Price.Text = "£14";
            item12Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item4Price
            // 
            item4Price.BackColor = SystemColors.Info;
            item4Price.FlatStyle = FlatStyle.Popup;
            item4Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item4Price.ForeColor = Color.Red;
            item4Price.Location = new Point(651, 125);
            item4Price.Name = "item4Price";
            item4Price.Size = new Size(33, 21);
            item4Price.TabIndex = 1;
            item4Price.Text = "£25";
            item4Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item7Price
            // 
            item7Price.BackColor = SystemColors.Info;
            item7Price.FlatStyle = FlatStyle.Popup;
            item7Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item7Price.ForeColor = Color.Red;
            item7Price.Location = new Point(480, 289);
            item7Price.Name = "item7Price";
            item7Price.Size = new Size(33, 21);
            item7Price.TabIndex = 1;
            item7Price.Text = "£5";
            item7Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item11Price
            // 
            item11Price.BackColor = SystemColors.Info;
            item11Price.FlatStyle = FlatStyle.Popup;
            item11Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item11Price.ForeColor = Color.Red;
            item11Price.Location = new Point(480, 453);
            item11Price.Name = "item11Price";
            item11Price.Size = new Size(33, 21);
            item11Price.TabIndex = 1;
            item11Price.Text = "£18";
            item11Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item3Price
            // 
            item3Price.BackColor = SystemColors.Info;
            item3Price.FlatStyle = FlatStyle.Popup;
            item3Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item3Price.ForeColor = Color.Red;
            item3Price.Location = new Point(480, 125);
            item3Price.Name = "item3Price";
            item3Price.Size = new Size(33, 21);
            item3Price.TabIndex = 1;
            item3Price.Text = "£8";
            item3Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item6Price
            // 
            item6Price.BackColor = SystemColors.Info;
            item6Price.FlatStyle = FlatStyle.Popup;
            item6Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item6Price.ForeColor = Color.Red;
            item6Price.Location = new Point(309, 289);
            item6Price.Name = "item6Price";
            item6Price.Size = new Size(33, 21);
            item6Price.TabIndex = 1;
            item6Price.Text = "£10";
            item6Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item10Price
            // 
            item10Price.BackColor = SystemColors.Info;
            item10Price.FlatStyle = FlatStyle.Popup;
            item10Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item10Price.ForeColor = Color.Red;
            item10Price.Location = new Point(309, 453);
            item10Price.Name = "item10Price";
            item10Price.Size = new Size(33, 21);
            item10Price.TabIndex = 1;
            item10Price.Text = "£12";
            item10Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item2Price
            // 
            item2Price.BackColor = SystemColors.Info;
            item2Price.FlatStyle = FlatStyle.Popup;
            item2Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item2Price.ForeColor = Color.Red;
            item2Price.Location = new Point(309, 125);
            item2Price.Name = "item2Price";
            item2Price.Size = new Size(33, 21);
            item2Price.TabIndex = 1;
            item2Price.Text = "£7";
            item2Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item5Price
            // 
            item5Price.BackColor = SystemColors.Info;
            item5Price.FlatStyle = FlatStyle.Popup;
            item5Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item5Price.ForeColor = Color.Red;
            item5Price.Location = new Point(138, 289);
            item5Price.Name = "item5Price";
            item5Price.Size = new Size(33, 21);
            item5Price.TabIndex = 1;
            item5Price.Text = "£28";
            item5Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item9Price
            // 
            item9Price.BackColor = SystemColors.Info;
            item9Price.FlatStyle = FlatStyle.Popup;
            item9Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item9Price.ForeColor = Color.Red;
            item9Price.Location = new Point(138, 453);
            item9Price.Name = "item9Price";
            item9Price.Size = new Size(33, 21);
            item9Price.TabIndex = 1;
            item9Price.Text = "£5";
            item9Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item1Price
            // 
            item1Price.BackColor = SystemColors.Info;
            item1Price.FlatStyle = FlatStyle.Popup;
            item1Price.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item1Price.ForeColor = Color.Red;
            item1Price.Location = new Point(138, 125);
            item1Price.Name = "item1Price";
            item1Price.Size = new Size(33, 21);
            item1Price.TabIndex = 1;
            item1Price.Text = "£10";
            item1Price.TextAlign = ContentAlignment.TopCenter;
            // 
            // item8Title
            // 
            item8Title.BackColor = SystemColors.Info;
            item8Title.FlatStyle = FlatStyle.Popup;
            item8Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item8Title.ForeColor = Color.Black;
            item8Title.Location = new Point(586, 307);
            item8Title.Name = "item8Title";
            item8Title.Size = new Size(98, 31);
            item8Title.TabIndex = 1;
            item8Title.Text = "Butter Chicken";
            item8Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item12Title
            // 
            item12Title.BackColor = SystemColors.Info;
            item12Title.FlatStyle = FlatStyle.Popup;
            item12Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item12Title.ForeColor = Color.Black;
            item12Title.Location = new Point(590, 471);
            item12Title.Name = "item12Title";
            item12Title.Size = new Size(94, 31);
            item12Title.TabIndex = 1;
            item12Title.Text = "Sirloin Steak";
            item12Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item4Title
            // 
            item4Title.BackColor = SystemColors.Info;
            item4Title.FlatStyle = FlatStyle.Popup;
            item4Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item4Title.ForeColor = Color.Black;
            item4Title.Location = new Point(590, 143);
            item4Title.Name = "item4Title";
            item4Title.Size = new Size(94, 31);
            item4Title.TabIndex = 1;
            item4Title.Text = "Poke bowl";
            item4Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item7Title
            // 
            item7Title.BackColor = SystemColors.Info;
            item7Title.FlatStyle = FlatStyle.Popup;
            item7Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item7Title.ForeColor = Color.Black;
            item7Title.Location = new Point(409, 307);
            item7Title.Name = "item7Title";
            item7Title.Size = new Size(104, 31);
            item7Title.TabIndex = 1;
            item7Title.Text = "Chickpea Salad";
            item7Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item11Title
            // 
            item11Title.BackColor = SystemColors.Info;
            item11Title.FlatStyle = FlatStyle.Popup;
            item11Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item11Title.ForeColor = Color.Black;
            item11Title.Location = new Point(419, 471);
            item11Title.Name = "item11Title";
            item11Title.Size = new Size(94, 31);
            item11Title.TabIndex = 1;
            item11Title.Text = "Pork Steak";
            item11Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item3Title
            // 
            item3Title.BackColor = SystemColors.Info;
            item3Title.FlatStyle = FlatStyle.Popup;
            item3Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item3Title.ForeColor = Color.Black;
            item3Title.Location = new Point(419, 143);
            item3Title.Name = "item3Title";
            item3Title.Size = new Size(94, 31);
            item3Title.TabIndex = 1;
            item3Title.Text = "Egg Salad";
            item3Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item6Title
            // 
            item6Title.BackColor = SystemColors.Info;
            item6Title.FlatStyle = FlatStyle.Popup;
            item6Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item6Title.ForeColor = Color.Black;
            item6Title.Location = new Point(248, 307);
            item6Title.Name = "item6Title";
            item6Title.Size = new Size(94, 31);
            item6Title.TabIndex = 1;
            item6Title.Text = "Fish Bowl";
            item6Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item2Title
            // 
            item2Title.BackColor = SystemColors.Info;
            item2Title.FlatStyle = FlatStyle.Popup;
            item2Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item2Title.ForeColor = Color.Black;
            item2Title.Location = new Point(248, 143);
            item2Title.Name = "item2Title";
            item2Title.Size = new Size(94, 31);
            item2Title.TabIndex = 1;
            item2Title.Text = "Egg Planet";
            item2Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item5Title
            // 
            item5Title.BackColor = SystemColors.Info;
            item5Title.FlatStyle = FlatStyle.Popup;
            item5Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item5Title.ForeColor = Color.Black;
            item5Title.Location = new Point(77, 307);
            item5Title.Name = "item5Title";
            item5Title.Size = new Size(94, 31);
            item5Title.TabIndex = 1;
            item5Title.Text = "Fish Platter";
            item5Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item9Title
            // 
            item9Title.BackColor = SystemColors.Info;
            item9Title.FlatStyle = FlatStyle.Popup;
            item9Title.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            item9Title.ForeColor = Color.Black;
            item9Title.Location = new Point(77, 471);
            item9Title.Name = "item9Title";
            item9Title.Size = new Size(94, 31);
            item9Title.TabIndex = 1;
            item9Title.Text = "Egg Sandwich";
            item9Title.TextAlign = ContentAlignment.MiddleCenter;
            item9Title.Click += item9AddToCart;
            // 
            // item8
            // 
            item8.BackColor = SystemColors.Info;
            item8.BackgroundImageLayout = ImageLayout.Center;
            item8.Cursor = Cursors.HSplit;
            item8.Image = (Image)resources.GetObject("item8.Image");
            item8.Location = new Point(528, 180);
            item8.Name = "item8";
            item8.Padding = new Padding(5);
            item8.Size = new Size(156, 158);
            item8.TabIndex = 0;
            item8.UseVisualStyleBackColor = false;
            item8.Click += item8AddToCart;
            // 
            // item12
            // 
            item12.BackColor = SystemColors.Info;
            item12.BackgroundImageLayout = ImageLayout.Center;
            item12.Cursor = Cursors.HSplit;
            item12.Image = (Image)resources.GetObject("item12.Image");
            item12.Location = new Point(528, 344);
            item12.Name = "item12";
            item12.Padding = new Padding(5);
            item12.Size = new Size(156, 158);
            item12.TabIndex = 0;
            item12.UseVisualStyleBackColor = false;
            item12.Click += item12AddToCart;
            // 
            // item4
            // 
            item4.BackColor = SystemColors.Info;
            item4.BackgroundImageLayout = ImageLayout.Center;
            item4.Cursor = Cursors.HSplit;
            item4.Image = (Image)resources.GetObject("item4.Image");
            item4.Location = new Point(528, 16);
            item4.Name = "item4";
            item4.Padding = new Padding(5);
            item4.Size = new Size(156, 158);
            item4.TabIndex = 0;
            item4.UseVisualStyleBackColor = false;
            item4.Click += item4AddToCart;
            // 
            // item7
            // 
            item7.BackColor = SystemColors.Info;
            item7.BackgroundImageLayout = ImageLayout.Center;
            item7.Cursor = Cursors.HSplit;
            item7.Image = (Image)resources.GetObject("item7.Image");
            item7.Location = new Point(357, 180);
            item7.Name = "item7";
            item7.Padding = new Padding(5);
            item7.Size = new Size(156, 158);
            item7.TabIndex = 0;
            item7.UseVisualStyleBackColor = false;
            item7.Click += item7AddToCart;
            // 
            // item11
            // 
            item11.BackColor = SystemColors.Info;
            item11.BackgroundImageLayout = ImageLayout.Center;
            item11.Cursor = Cursors.HSplit;
            item11.Image = (Image)resources.GetObject("item11.Image");
            item11.Location = new Point(357, 344);
            item11.Name = "item11";
            item11.Padding = new Padding(5);
            item11.Size = new Size(156, 158);
            item11.TabIndex = 0;
            item11.UseVisualStyleBackColor = false;
            item11.Click += item11AddToCart;
            // 
            // item3
            // 
            item3.BackColor = SystemColors.Info;
            item3.BackgroundImageLayout = ImageLayout.Center;
            item3.Cursor = Cursors.HSplit;
            item3.Image = (Image)resources.GetObject("item3.Image");
            item3.Location = new Point(357, 16);
            item3.Name = "item3";
            item3.Padding = new Padding(5);
            item3.Size = new Size(156, 158);
            item3.TabIndex = 0;
            item3.UseVisualStyleBackColor = false;
            item3.Click += item3AddToCart;
            // 
            // item6
            // 
            item6.BackColor = SystemColors.Info;
            item6.BackgroundImageLayout = ImageLayout.Center;
            item6.Cursor = Cursors.HSplit;
            item6.Image = (Image)resources.GetObject("item6.Image");
            item6.Location = new Point(186, 180);
            item6.Name = "item6";
            item6.Padding = new Padding(5);
            item6.Size = new Size(156, 158);
            item6.TabIndex = 0;
            item6.UseVisualStyleBackColor = false;
            item6.Click += item6AddToCart;
            // 
            // item10
            // 
            item10.BackColor = SystemColors.Info;
            item10.BackgroundImageLayout = ImageLayout.Center;
            item10.Cursor = Cursors.HSplit;
            item10.Image = (Image)resources.GetObject("item10.Image");
            item10.Location = new Point(186, 344);
            item10.Name = "item10";
            item10.Padding = new Padding(5);
            item10.Size = new Size(156, 158);
            item10.TabIndex = 0;
            item10.UseVisualStyleBackColor = false;
            item10.Click += item10AddToCart;
            // 
            // item1
            // 
            item1.BackColor = SystemColors.Info;
            item1.BackgroundImageLayout = ImageLayout.Center;
            item1.Cursor = Cursors.HSplit;
            item1.Image = (Image)resources.GetObject("item1.Image");
            item1.Location = new Point(15, 16);
            item1.Name = "item1";
            item1.Padding = new Padding(5);
            item1.Size = new Size(156, 158);
            item1.TabIndex = 0;
            item1.UseVisualStyleBackColor = false;
            item1.Click += item1AddToCart;
            // 
            // item2
            // 
            item2.BackColor = SystemColors.Info;
            item2.BackgroundImageLayout = ImageLayout.Center;
            item2.Cursor = Cursors.HSplit;
            item2.Image = (Image)resources.GetObject("item2.Image");
            item2.Location = new Point(186, 16);
            item2.Name = "item2";
            item2.Padding = new Padding(5);
            item2.Size = new Size(156, 158);
            item2.TabIndex = 0;
            item2.UseVisualStyleBackColor = false;
            item2.Click += item2AddToCart;
            // 
            // item5
            // 
            item5.BackColor = SystemColors.Info;
            item5.BackgroundImageLayout = ImageLayout.Center;
            item5.Cursor = Cursors.HSplit;
            item5.Image = (Image)resources.GetObject("item5.Image");
            item5.Location = new Point(15, 180);
            item5.Name = "item5";
            item5.Padding = new Padding(5);
            item5.Size = new Size(156, 158);
            item5.TabIndex = 0;
            item5.UseVisualStyleBackColor = false;
            item5.Click += item5AddToCart;
            // 
            // item9
            // 
            item9.BackColor = SystemColors.Info;
            item9.BackgroundImageLayout = ImageLayout.Center;
            item9.Cursor = Cursors.HSplit;
            item9.Image = (Image)resources.GetObject("item9.Image");
            item9.Location = new Point(15, 344);
            item9.Name = "item9";
            item9.Padding = new Padding(5);
            item9.Size = new Size(156, 158);
            item9.TabIndex = 0;
            item9.UseVisualStyleBackColor = false;
            item9.Click += item9AddToCart;
            // 
            // barcode
            // 
            barcode.AllowDrop = true;
            barcode.AutoEllipsis = true;
            barcode.BackColor = SystemColors.HighlightText;
            barcode.BorderStyle = BorderStyle.Fixed3D;
            barcode.Font = new Font("C39HrP36DlTt", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcode.Location = new Point(351, 480);
            barcode.Name = "barcode";
            barcode.Size = new Size(443, 55);
            barcode.TabIndex = 1;
            barcode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // bindingSource1
            // 
          
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.Location = new Point(351, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 452);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 130F;
            dataGridViewTextBoxColumn1.HeaderText = "Item";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 130F;
            dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 140F;
            dataGridViewTextBoxColumn3.HeaderText = "Total Amount";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 140;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1562, 806);
            Controls.Add(dataGridView1);
            Controls.Add(barcode);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label barcode;
        private Button button;
        private Panel panel4;
        private Label label1;
        private Panel panel6;
        private Panel panel5;
        private Label changeTitle;
        private Label cashTitle;
        private Label paymentMethod;
        private Label label3;
        private Label label2;
        private Label subTotal;
        private Label item1Title;
        private Label item1Price;
        private Button button8;
        private Button button7;
        private Button button11;
        private Button button10;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button9;
        private Button button3;
        private Button button1;
        private Label item8Price;
        private Label item12Price;
        private Label item4Price;
        private Label item7Price;
        private Label item11Price;
        private Label item3Price;
        private Label item6Price;
        private Label item10Price;
        private Label item2Price;
        private Label item5Price;
        private Label item9Price;
        private Label item8Title;
        private Label item12Title;
        private Label item4Title;
        private Label item7Title;
        private Label item11Title;
        private Label item3Title;
        private Label item6Title;
        private Label item10Title;
        private Label item2Title;
        private Label item5Title;
        private Label item9Title;
        private Button item8;
        private Button item12;
        private Button item4;
        private Button item7;
        private Button item11;
        private Button item3;
        private Button item6;
        private Button item10;
        private Button item2;
        private Button item5;
        private Button item9;
        private Label cash;
        private Label total;
        private Label tax;
        private Label change;
        private Button button2;
        private Button button16;
        private Button resetbtn;
        private Button print;
        private Button pay;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private ComboBox cboPayment;
        private BindingSource bindingSource1;
        private Button item1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
