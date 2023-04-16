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

namespace TestDataGridWpf
{
    /// <summary>
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        private MainWindow mainWindow;

        public SignInWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }
    }
}
