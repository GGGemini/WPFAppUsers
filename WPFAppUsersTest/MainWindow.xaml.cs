using System.Windows;
using System.Windows.Controls;
using WPFAppUsersTest.Content;

namespace WPFAppUsersTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersContent _usersContent = new UsersContent();

        public MainWindow()
        {
            InitializeComponent();

            TableUsers.RowGroups.Add(_usersContent.GetAllUsers());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LabelFormHeader.Content = "Добавление нового сотрудника";

            FormUsers.Visibility = Visibility.Visible;

            foreach (ComboBoxItem comboBoxItem in _usersContent.GetComboBoxItemsSubdivisions())
            {
                ComboBoxSubdivisions.Items.Add(comboBoxItem);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FormUsers.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (FormUsers.DataContext == null)
            {

            }
        }
    }
}
