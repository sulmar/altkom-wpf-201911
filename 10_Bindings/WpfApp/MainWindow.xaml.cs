using Altkom.Shop.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Customer Customer { get; set; }

        public MainWindow()
        {
            InitializeComponent();

           this.DataContext = this;

            this.Customer = new Customer
            {
                FirstName = "Marcin",
                LastName = "Sulecki"
            };

            // bad practice
           // this.HelloButton.Content = customer.FirstName;




        }
    }
}
