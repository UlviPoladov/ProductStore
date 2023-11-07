using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Product product;

        public Product products
        {
            get { return product; }
            set { product = value; OnPropertyChanged(); }
        }

        

        public ObservableCollection<Product> productss;

        public ObservableCollection<Product> Products
        {
            get { return productss; }
            set { productss = value; OnPropertyChanged(); }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;


            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Id=1,
                     Image=null,
                      Name="Fanta",
                       Price=2
                },
                new Product
                {
                    Id=2,
                     Image=null,
                      Name="Coke",
                       Price=2
                },
                new Product
                {
                    Id=3,
                     Image = null, 
                    Name = "Pepsi", 
                    Price = 2
                }
            };

            myListBox.SelectedIndex = 0;
        }
        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;


        private Product selectedproduct;


        public Product Selectedproduct
        {
            get { return selectedproduct; }
            set { selectedproduct = value; OnPropertyChanged(); }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Window1 newWindow = new Window1(this);
            newWindow.Show();


        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var window = new InfoWindow();
            window.infopruct = Selectedproduct;
            window.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            var window = new InfoWindow();
            window.infopruct = Selectedproduct;
            window.ShowDialog();
        }
    }
}
