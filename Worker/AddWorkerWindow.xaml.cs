using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Worker
{
    public partial class AddWorkerWindow : Window
    {
        public Worker NewWorker { get; private set; }

        public AddWorkerWindow()
        {
            
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            NewWorker = new Worker
            {
                FullName = FullNameTextBox.Text,
                Position = PositionTextBox.Text,
                Salary = decimal.TryParse(SalaryTextBox.Text, out var salary) ? salary : 0,
                Gender = GenderTextBox.Text,
                Age = int.TryParse(AgeTextBox.Text, out var age) ? age : 0
            };
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
