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
using JapanesePractice.Shared;

namespace JapanesePractice.Pages.Kanji
{
    /// <summary>
    /// Interaction logic for KanjiPractice.xaml
    /// </summary>
    public partial class KanjiPractice : Page
    {
        public KanjiPractice()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (modeSelect.SelectedIndex == Constant.MODE.KANJI_OR_WORD)
            {
                practiceArea.Navigate(new KanjiMode());
            }
            else if (modeSelect.SelectedIndex == Constant.MODE.MEAN)
            {
                practiceArea.Navigate(new MeanMode());
            }
        }

        private void BackToMainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu());
        }
    }
}
