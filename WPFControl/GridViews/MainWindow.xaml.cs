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

namespace GridViews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MenList.Items.Add(new Person() { Name = "Ali", ID = "123A", Age = 20 });
            MenList.Items.Add(new Person() { Name = "Akram", ID = "456X", Age = 35 });
            MenList.Items.Add(new Person() { Name = "Salam", ID = "333E", Age = 49 });

        }
    }
}
