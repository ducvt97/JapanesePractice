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

namespace JapanesePractice.Pages.Vocabulary
{
    /// <summary>
    /// Interaction logic for MeanMode.xaml
    /// </summary>
    public partial class MeanMode : Page
    {
        public MeanMode()
        {
            InitializeComponent();
        }

        private void ShowMoreButton_Click(object sender, RoutedEventArgs e)
        {
            moreDetailsArea.Visibility = Visibility.Visible;
            showMoreButton.Visibility = Visibility.Hidden;
        }

        private void NextWordButton_Click(object sender, RoutedEventArgs e)
        {
            moreDetailsArea.Visibility = Visibility.Hidden;
            showMoreButton.Visibility = Visibility.Visible;
        }
    }
}
