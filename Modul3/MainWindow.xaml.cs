using Microsoft.Win32;
using Modul3.DataClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace Modul3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MessageBox.Show("Пожалуйста, откройте файл из ресурсов проекта. Либо проверьте ваш файл на корректность!");
            OpenFileDialog openFile = new OpenFileDialog { Filter = "Json files | *.json" };
            if (openFile.ShowDialog() != true || !File.Exists(openFile.FileName))
            {
                MessageBox.Show("Файл найти не удалось!");
                Application.Current.Shutdown();
                return;
            }
            try
            {
                Student? student = JsonSerializer.Deserialize<Student>(File.ReadAllText(openFile.FileName));
                if (student == null)
                {
                    MessageBox.Show("Файл пустой");
                    Application.Current.Shutdown();
                    return;
                }
                DataContext = student;
            }
            catch
            {
                MessageBox.Show("Файл открыть не удалось! Некорректные данные!");
                Application.Current.Shutdown();
            }
            InitializeComponent();
        }
    }
}
