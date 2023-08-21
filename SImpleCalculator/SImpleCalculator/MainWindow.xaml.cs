using System.Windows;

namespace SImpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string  num = "";
        private int     num1 = 0;
        private int     num2 = 0;
        private bool    isPlus;
        private bool    isMinus;
        private bool    isMultiply;
        private bool    isDivide;
        private void inputSeven(object sender, RoutedEventArgs e)
        {
            num += "7";
            tbNumber.Text = num;
            lblText.Content += num;

        }

        private void inputFour(object sender, RoutedEventArgs e)
        {
            num += "4";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void inputOne(object sender, RoutedEventArgs e)
        {
            num += "1";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void inputZero(object sender, RoutedEventArgs e)
        {
            num += "0";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void inputTwo(object sender, RoutedEventArgs e)
        {
            num += "2";
            tbNumber.Text = num;
            lblText.Content = num;
        }

        private void inputFive(object sender, RoutedEventArgs e)
        {
            num += "5";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void inputEight(object sender, RoutedEventArgs e)
        {
            num += "8";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void InputNine(object sender, RoutedEventArgs e)
        {
            num += "9";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void inputSix(object sender, RoutedEventArgs e)
        {
            num += "6";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void inputThree(object sender, RoutedEventArgs e)
        {
            num += "3";
            tbNumber.Text = num;
            lblText.Content += num;
        }

        private void inputDivide(object sender, RoutedEventArgs e)
        {
            if (isDivide||isPlus||isMinus||isMultiply)
            {
                calculateResult();
                lblText.Content = num;
            }
            lblText.Content += "/";
            int.TryParse(num, out num1);
            num = "";
            tbNumber.Text = num;
            isDivide = true;
        }

        private void inputMultiply(object sender, RoutedEventArgs e)
        {
            if (isDivide || isPlus || isMinus || isMultiply)
            {
                calculateResult();
                lblText.Content = num;
            }
            lblText.Content += "*";
            int.TryParse(num, out num1);
            num = "";
            tbNumber.Text = num;
            isMultiply = true;

        }

        private void imputSubtract(object sender, RoutedEventArgs e)
        {
            if (isDivide || isPlus || isMinus || isMultiply)
            {
                calculateResult();
                lblText.Content = num;
            }
            lblText.Content += "-";
            int.TryParse(num, out num1);
            num = "";
            tbNumber.Text = num;
            isMinus = true;
        }

        private void inputAddition(object sender, RoutedEventArgs e)
        {
            if (isDivide || isPlus || isMinus || isMultiply)
            {
                calculateResult();
                lblText.Content = num;
            }
            lblText.Content += "+";
            int.TryParse(num, out num1);

            num = "";
            tbNumber.Text = num;
            isPlus = true;
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            num = "";
            tbNumber.Text = num;
            lblText.Content = num;
            num1 = 0;
            num2 = 0;
            isPlus = false;
            isMinus = false;
            isDivide = false;
            isMultiply = false;


        }

        private void showResult(object sender, RoutedEventArgs e)
        {

            calculateResult();
            num1 = 0;
            num2 = 0;
            num = tbNumber.Text;
            lblText.Content = num;

        }
        private void calculateResult()
        {
            int.TryParse(num, out num2);

            int result = 0;
            if (isPlus)
            {
                result = num1 + num2;
                isPlus = false;
            }
            else if (isMinus)
            {
                result = num1 - num2;
                isMinus = false;
            }
            else if (isMultiply)
            {
                result = num1 * num2;
                isMultiply = false;
            }
            else if (isDivide)
            {
                result = num1 / num2;
                isDivide = false;
            }
            tbNumber.Text = result.ToString();
            num = tbNumber.Text;

        }
    }
}
