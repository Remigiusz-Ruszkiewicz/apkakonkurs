using System;
using System.Collections.Generic;
using System.IO;
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

namespace apka
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
        public void check()
        {
            var rows = File.ReadAllLines("myfile.csv").Select(l => l.Split(',').ToArray()).ToArray();
            MessageBox.Show(rows[0][0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rows = File.ReadAllLines("myfile.csv").Select(l => l.Split(',').ToArray()).ToArray();
            foreach (var item in rows)
            {
                var i = rows.ToArray().ToString();
                if (input.Text == i[0][0])
                {
                    MessageBox.Show("OK");
                }
            }
           
            check();
        }
    }
}
