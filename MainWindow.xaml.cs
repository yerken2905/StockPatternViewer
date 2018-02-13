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
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockPatternViewer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _pathToHistory;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSendHistory_Click(object sender, RoutedEventArgs e)
        {
            CommonLibrary openDialog = new CommonLibrary();
            _pathToHistory = openDialog.FileName;
        }

        private void BtnSlowStart_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnRew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFastStart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
