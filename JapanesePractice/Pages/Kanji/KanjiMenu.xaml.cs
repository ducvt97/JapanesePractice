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

namespace JapanesePractice.Pages.Kanji
{
    /// <summary>
    /// Interaction logic for KanjiMenu.xaml
    /// </summary>
    public partial class KanjiMenu : Page
    {
        public KanjiMenu()
        {
            InitializeComponent();
        }

        private void StartPractice_Click(object sender, RoutedEventArgs e)
        {
            KanjiPractice kanjiPracticePage = new KanjiPractice();
            this.NavigationService.Navigate(kanjiPracticePage);
        }

        private void AddNewKanji_Click(object sender, RoutedEventArgs e)
        {
            AddNewKanji addNewKanjiPage = new AddNewKanji();
            this.NavigationService.Navigate(addNewKanjiPage);
        }
    }
}
