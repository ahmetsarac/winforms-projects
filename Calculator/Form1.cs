using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string firstNum = string.Empty, secondNum = string.Empty;
        bool enterValue = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnNum_Click(object sender, EventArgs e)
        {
            if (editBox.Text == "0" || enterValue)
            {
                editBox.Text = string.Empty;
            }
            enterValue = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!editBox.Text.Contains("."))
                {
                    editBox.Text += btn.Text;
                }
            }
            else
            {
                editBox.Text += btn.Text;
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                btnEqual.PerformClick();
            }
            else
            {
                result = Double.Parse(editBox.Text, CultureInfo.InvariantCulture);
            }

            Button btn = (Button)sender;
            operation = btn.Text;
            enterValue = true;
            if (editBox.Text != "0")
            {
                label.Text = firstNum = $"{result} {operation}";
                editBox.Text = string.Empty;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = editBox.Text;
            label.Text = $"{label.Text} {editBox.Text} = ";
            if (editBox.Text != string.Empty)
            {
                if (editBox.Text == "0")
                {
                    label.Text = string.Empty;
                }
                switch (operation)
                {
                    case "+":
                        editBox.Text = (result + Double.Parse(secondNum)).ToString();
                        break;
                    case "-":
                        editBox.Text = (result - Double.Parse(secondNum)).ToString();
                        break;
                    case "×":
                        editBox.Text = (result * Double.Parse(secondNum)).ToString();
                        break;
                    case "÷":
                        if(secondNum == "0")
                        {
                            MessageBox.Show("Can't divide zero");
                            break;
                        }
                        editBox.Text = (result / Double.Parse(secondNum)).ToString();
                        break;
                    case "%":
                        editBox.Text = (result % Double.Parse(secondNum)).ToString();
                        break;
                    default:
                        label.Text = $"{editBox.Text} = ";
                        break;
                }
                result = Double.Parse(editBox.Text);
                operation = string.Empty;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (editBox.Text.Length > 0)
            {
                editBox.Text = editBox.Text.Remove(editBox.Text.Length - 1, 1);
            }
            if (editBox.Text == string.Empty)
            {
                editBox.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            editBox.Text = "0";
            label.Text = string.Empty;
            result = 0;
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            editBox.Text = Convert.ToString(-1 * Convert.ToDouble(editBox.Text));
        }


    }
}