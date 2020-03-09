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
    /// Interaction logic for VocabularyMenu.xaml
    /// </summary>
    public partial class VocabularyMenu : Page
    {
        public VocabularyMenu()
        {
            InitializeComponent();
        }

        private void StartPractice_Click(object sender, RoutedEventArgs e)
        {
            VocabularyPractice vocabularyPracticePage = new VocabularyPractice();
            this.NavigationService.Navigate(vocabularyPracticePage);
        }

        private void AddNewWord_Click(object sender, RoutedEventArgs e)
        {
            AddNewWord addNewWordPage = new AddNewWord();
            this.NavigationService.Navigate(addNewWordPage);
        }
    }
}
