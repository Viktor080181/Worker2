using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;


namespace Worker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Worker> workers;

        public MainWindow()
        {
            InitializeComponent();
            LoadWorkers();
        }

        private void LoadWorkers()
        {
            workers = new List<Worker>
            {
                new Worker { FullName = "Иванов Иван Иванович", Position = "Менеджер", Salary = 50000, Gender = "Мужской", Age = 30 },
                new Worker { FullName = "Петрова Анна Сергеевна", Position = "Бухгалтер", Salary = 60000, Gender = "Женский", Age = 28 },
                new Worker { FullName = "Сидоров Алексей Викторович", Position = "Разработчик", Salary = 70000, Gender = "Мужской", Age = 25 }
            };

            WorkersDataGrid.ItemsSource = workers;
        }

        private void AddWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            AddWorkerWindow addWorkerWindow = new AddWorkerWindow();
            if (addWorkerWindow.ShowDialog() == true)
            {
                workers.Add(addWorkerWindow.NewWorker);
                WorkersDataGrid.Items.Refresh(); // Обновляем DataGrid
            }
        }
    }
}