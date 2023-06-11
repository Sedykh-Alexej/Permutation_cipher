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

namespace Laba1
{
    /// <summary>
    /// Логика взаимодействия для LabePage.xaml
    /// </summary>
    public partial class LabePage : Page
    {
        Transposition t;

        public LabePage()
        {
            InitializeComponent();
            t = new Transposition();
        }

        private void Выход(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            t.SetKey(KeyTextBox.Text);

            if (EncryptRadioButton.IsPressed)
                OutputTextBox.Text = t.Encrypt(InputTextBox.Text);
            else
                OutputTextBox.Text = t.Decrypt(InputTextBox.Text);
        }
    }
}
