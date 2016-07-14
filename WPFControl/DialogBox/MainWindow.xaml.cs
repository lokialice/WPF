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

namespace DialogBox
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

        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            string msgText = "Click any button";
            string txt = "My Life";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgText, txt, button);
            
            switch (result)
            {
                case MessageBoxResult.Yes:
                        textBox1.Text = "Yes";
                    break;
                case MessageBoxResult.No:
                        textBox1.Text = "No";
                    break;
                case MessageBoxResult.Cancel:
                        textBox1.Text = "Cancel";
                    break;
            }            
        }
    }
}
