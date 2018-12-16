using System;
using System.Windows;
using System.Windows.Input;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Worklist worklist = new Worklist();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = worklist;
        }

        private void EditMenu_Click(object sender, RoutedEventArgs e)
        {
            if (lvToDo.SelectedItem != null)
            {
                EditPopUp editPopUp = new EditPopUp(lvToDo.SelectedItem as ToDoItem);
                editPopUp.Owner = this;
                editPopUp.ShowDialog();
            }
        }

        private void MarkAsDone(object sender, RoutedEventArgs e)
        {
            if (lvToDo.SelectedItem != null)
            {
                MessageBoxResult done = MessageBox.Show("Do you want to mark this task as done?", "Mark as Done", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (done == MessageBoxResult.Yes)
                {
                    (lvToDo.SelectedItem as ToDoItem).DoneDateTime = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss.ms");
                }
                lvToDo.Items.Refresh();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvToDo.SelectedItem != null)
            {
                MessageBoxResult del = MessageBox.Show("Do you want to delete selected task?", "Delete Task", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (del == MessageBoxResult.Yes)
                {
                    worklist.DeleteItem(lvToDo.SelectedItem as ToDoItem);
                }
                lvToDo.Items.Refresh();
            }
        }

        private void lvToDo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MarkAsDone(sender, e);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!txtItemDesc.Text.Trim().Equals(string.Empty))
            {
                worklist.Additem(txtItemDesc.Text.Trim());
            }
            txtItemDesc.Text = "";
            lvToDo.Items.Refresh();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            worklist.Save();
        }
    }
}
