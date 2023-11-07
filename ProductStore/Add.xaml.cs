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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private MainWindow viewModel;

        public Window1(MainWindow viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel != null)
            {
                Product newpro = new Product
                {
                    Image = null,
                    Name = txt2.Text,
                    Price = int.Parse(txt3.Text)
                };

                viewModel.Products.Add(newpro);

                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
            }
        }
    }
}
