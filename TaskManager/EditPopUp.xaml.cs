using System.Windows;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for EditPopUp.xaml
    /// </summary>
    public partial class EditPopUp : Window
    {
        private string tempdesc;

        public EditPopUp(ToDoItem item)
        {
            InitializeComponent();
            DataContext = item;
            tempdesc = item.Description;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool result = DialogResult ?? false;
            if (!result)
                (DataContext as ToDoItem).Description = tempdesc;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
