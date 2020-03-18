using System;
using System.Windows.Forms;

namespace CoffeeShop.view.menuControl
{
    

    public partial class Payment : Form
    {
        public class PaymentMadeEventArgs : EventArgs
        {
            private bool _paymentSuccess;

            public bool PaymentSuccess
            {
                get => _paymentSuccess;
                set { _paymentSuccess = value; }
            }
        }

        public delegate void PaymentMadeEvent(object sender, PaymentMadeEventArgs e);
       
        public event PaymentMadeEvent PaymentMade;

        private decimal paymentAmount;
        public decimal PaymentAmount
        {
            get => paymentAmount;
            set
            {
                paymentAmount = value;
                txtAmountToPay.Text = $@"{paymentAmount}";
            }
        }


        public Payment()
        {
            InitializeComponent();
        }

        private void PaymentHasBeenMade(object sender, EventArgs e)
        {
            decimal total = 0;
            try
            {

                total = decimal.Parse(txtAmountToPay.Text) - decimal.Parse(txtPaymentAmount.Text);
            }
            catch
            {
                MessageBox.Show($@"An error has occured, please enter a valid amount");
                return;
            }
            if (total > 0)
            {
                txtAmountToPay.Text = total.ToString();
            }
            else
            {
                MessageBox.Show($@"Please give {total:C}");
                PaymentMade(this, new PaymentMadeEventArgs() { PaymentSuccess = false });
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
