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

namespace Programa_Rectangulo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Clase_Rectangulo rectan;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            rectan = new Clase_Rectangulo { TXT1 = 1, };
            Convert.ToInt32(TXT1.Text);
            Convert.ToInt32(TXT2.Text);
        }
    }
}
