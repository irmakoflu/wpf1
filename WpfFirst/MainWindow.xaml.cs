using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastnumber,result;
        Selectedoperator selectedoperator;
        public MainWindow()
        {
            InitializeComponent();

            acbutton.Click += Acbutton_Click1;
            negativebutton.Click += Negativebutton_Click;
            percantagebutton.Click += Percantagebutton_Click;
            equalbutton.Click += Equalbutton_Click;

        }

        private void Equalbutton_Click(object sender, RoutedEventArgs e)
        {
            double newnumber;
            if (double.TryParse(resultlabel.Content.ToString(), out newnumber)) {
                switch (selectedoperator)
                {
                    case Selectedoperator.multiplication:
                        result = simplemath.multiply(lastnumber, newnumber);
                        break;
                    case Selectedoperator.division:
                        result = simplemath.division(lastnumber, newnumber);
                        break;
                    case Selectedoperator.subtraction:
                        result = simplemath.Subtract(lastnumber, newnumber);
                        break;
                    case Selectedoperator.addition:
                        result = simplemath.Add(lastnumber, newnumber);
                        break;
                }
                resultlabel.Content = result.ToString();
            }

        
        }
     

        private void Percantagebutton_Click(object sender, RoutedEventArgs e)
        {
            double tempnumber;
            if (double.TryParse(resultlabel.Content.ToString(), out tempnumber))
            {
                tempnumber = tempnumber / 100;
                if(lastnumber!=0)
                    tempnumber*=lastnumber;
                resultlabel.Content = tempnumber.ToString();
            }
        }



        private void Acbutton_Click1(object sender, RoutedEventArgs e)
        {
            resultlabel.Content = "0";
            result = 0;
            lastnumber = 0;
          
        }

        private void numberbutton_Click(object sender, RoutedEventArgs e)
        {
          /*  int selectedvalue = 0;
            if (sender == zerobutton)
            {
                selectedvalue = 0;
            }
            if (sender == onebutton)
            {
                selectedvalue = 1;
            }
             if (sender == twobutton)
            {
                selectedvalue = 2;
            }
            if (sender == threebutton)
            {
                selectedvalue = 3;
            }
            if (sender == fourbutton)
            {
                selectedvalue = 4;
            }
             if (sender == fivebutton)
            {
                selectedvalue = 5;
            }
             if (sender == sixbutton)
            {
                selectedvalue = 6;
            }
             if (sender == sevenbutton)
            {
                selectedvalue = 7;
            }
             if (sender == eightbutton)
            {
                selectedvalue = 8;
            }
             if (sender == ninebutton)
            {
                selectedvalue = 9;
            }*/
          int selectedvalue=int.Parse((sender as Button).Content.ToString());

            if (resultlabel.Content.ToString() == "0")
            {
                resultlabel.Content = $"{selectedvalue}";
            }
            else
            {
                resultlabel.Content = $"{resultlabel.Content}{selectedvalue}";
            }
        }

        private void operationbutton_click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(resultlabel.Content.ToString(), out lastnumber))
            {
                resultlabel.Content ="0";
            }
            if (sender == divisionbutton)
            {
                selectedoperator = Selectedoperator.division;
            }
            if (sender == minusbutton)
            {
                selectedoperator=Selectedoperator.subtraction;
            }
            if (sender == multiplicationbutton)
            {
                selectedoperator = Selectedoperator.multiplication;
            }
            if (sender == plusbutton)
            {
                selectedoperator= Selectedoperator.addition;
            }

        }

        private void Negativebutton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultlabel.Content.ToString(), out lastnumber))
            {
                lastnumber = lastnumber * -1;
                resultlabel.Content = lastnumber.ToString();
            }
        }
public enum Selectedoperator
        {
            addition,
            subtraction,
            multiplication,
            division,
        }

        private void pointbutton_Click_1(object sender, RoutedEventArgs e)
        {
            if (resultlabel.Content.ToString().Contains("."))
            {
                //do nothing
            }
            else
            {
                resultlabel.Content = $"{resultlabel.Content}.";
            }
        }

        public class simplemath
        {
            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }
            public static double Subtract(double n1, double n2)
            {
                return n1 - n2;
            }
            public static double division(double n1,double n2)
            {
                if (n2 == 0)
                {
                    MessageBox.Show("division by 0 is not supported","wrong operation",MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                }
                return n1 / n2;
            }
            public static  double multiply(double n1,double n2)
            {
                return n1 * n2;
            }



        }
    }
}