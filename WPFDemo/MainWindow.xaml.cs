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



namespace WPFDemo
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello");
            Person person1 = new Person("Steve", 40, 23.5m);
            Person person2 = new Person("Andy", 23, 42.565m);
            Person.CycleThroughPersonsInList();

        }

        private void submitButton_DragOver(object sender, DragEventArgs e)
        {
            MessageBox.Show("I have been dragged over");
        }
    }
}
