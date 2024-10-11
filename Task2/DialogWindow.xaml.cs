using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public string name = "";
        public double price = 0;
        public int stock = 0;
        public string productType;
        public DialogWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = NameBox.Text;
            bool isValid = double.TryParse(CostBox.Text, out price) && int.TryParse(StockBox.Text, out stock);  
            if (!isValid)
            {
                MessageBox.Show("Неверный ввод");
                DialogResult = false;
                return;
            }
            productType = ComboBox.SelectedItem.ToString();
            DialogResult = true;
        }
    }
}
