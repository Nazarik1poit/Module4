using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task1;
using Task1.Modules;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string currentFigure = "triangle";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RectangleButton_Click(object sender, RoutedEventArgs e)
        {
            currentFigure = "rectangle";
            TextBox1_3.Visibility = Visibility.Hidden;
            TextBlock1_3.Visibility = Visibility.Hidden;
            TextBlock1_2.Visibility = Visibility.Visible;
            TextBox1_2.Visibility = Visibility.Visible;
            TextBlock1_1.Visibility = Visibility.Visible;
            TextBox1_1.Visibility = Visibility.Visible;
            TextBlock1_1.Text = "Высота";
            TextBlock1_2.Text = "Ширина";

            TextBox2_1.Visibility = Visibility.Visible;
            TextBlock2_1.Visibility = Visibility.Visible;
            TextBlock2_1.Text = "Высота";
            TextBlock2_2.Text = "Ширина";
        }

        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            currentFigure = "triangle";
            TextBox1_3.Visibility = Visibility.Visible;
            TextBlock1_3.Visibility = Visibility.Visible;
            TextBlock1_2.Visibility = Visibility.Visible;
            TextBox1_2.Visibility = Visibility.Visible;
            TextBlock1_1.Visibility = Visibility.Visible;
            TextBox1_1.Visibility = Visibility.Visible;
            TextBlock1_1.Text = "1-я сторона";
            TextBlock1_2.Text = "2-я сторона";

            TextBox2_1.Visibility = Visibility.Visible;
            TextBlock2_1.Visibility = Visibility.Visible;
            TextBlock2_1.Text = "Высота";
            TextBlock2_2.Text = "Основание";
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            currentFigure = "circle";
            TextBox1_3.Visibility = Visibility.Hidden;
            TextBlock1_3.Visibility = Visibility.Hidden;
            TextBlock1_2.Visibility = Visibility.Visible;
            TextBox1_2.Visibility = Visibility.Visible;
            TextBlock1_1.Visibility = Visibility.Hidden;
            TextBox1_1.Visibility = Visibility.Hidden;
            TextBlock1_2.Text = "Радиус:";

            TextBox2_1.Visibility = Visibility.Hidden;
            TextBlock2_1.Visibility = Visibility.Hidden;
            TextBlock2_1.Text = "";
            TextBlock2_2.Text = "Радиус:";
        }

        private void PerimeterButton_Click(object sender, RoutedEventArgs e)
        {
            double side1 = 0, side2 = 0, side3 = 0;
            bool validInput = true;

            if (currentFigure == "triangle" || currentFigure == "rectangle")
            {
                validInput = double.TryParse(TextBox1_1.Text, out side1) && side1 > 0;
                if (!validInput)
                {
                    MessageBox.Show("Некорректное значение для первой стороны/высоты.");
                    return;
                }
            }

            validInput = double.TryParse(TextBox1_2.Text, out side2) && side2 > 0;
            if (!validInput)
            {
                MessageBox.Show("Некорректное значение для второй стороны/ширины/радиуса.");
                return;
            }

            if (currentFigure == "triangle")
            {
                validInput = double.TryParse(TextBox1_3.Text, out side3) && side3 > 0;
                if (!validInput)
                {
                    MessageBox.Show("Некорректное значение для третьей стороны.");
                    return;
                }
            }

            switch (currentFigure)
            {
                case "triangle":
                    IFigure triangle = new Triangle(0, 0, side1, side2, side3);
                    MessageBox.Show("Периметр треугольника: " + triangle.CalculatePerimeter());
                    break;

                case "rectangle":
                    IFigure rectangle = new Modules.Rectangle(side1, side2);
                    MessageBox.Show("Периметр прямоугольника: " + rectangle.CalculatePerimeter());
                    break;

                case "circle":
                    IFigure circle = new Circle(side2);
                    MessageBox.Show("Периметр круга: " + circle.CalculatePerimeter());
                    break;
            }
        }

        private void AreaButton_Click(object sender, RoutedEventArgs e)
        {
            double input1 = 0, input2 = 0;
            bool validInput = true;
            if (currentFigure == "triangle" ||  currentFigure == "rectangle")
            {
                validInput = double.TryParse(TextBox2_1.Text, out input1) && input1 > 0;
                if (!validInput)
                {
                    MessageBox.Show("Некорректное значение для Высоты");
                    return;
                }
            }
            validInput = double.TryParse(TextBox2_2.Text, out input2) && input1 > 0;
            if (!validInput)
            {
                MessageBox.Show("Некорректное значение для основания/радиуса/ширины");
                return;
            }
            
            
            switch (currentFigure)
            {
                case "triangle":
                    IFigure triangle = new Triangle(input1, input2, 0, 0, 0);
                    MessageBox.Show("Площадь треугольника: " + triangle.CalculateArea());
                    break;

                case "rectangle":
                    IFigure rectangle = new Modules.Rectangle(input1, input2);
                    MessageBox.Show("Площадь прямоугольника: " + rectangle.CalculateArea());
                    break;

                case "circle":
                    IFigure circle = new Circle(input2);
                    MessageBox.Show("Площадь круга: " + circle.CalculateArea());
                    break;
            }
        }
    }
}
