using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Reflection_Webserver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExecuteAction_ClickA(object sender, RoutedEventArgs e)
        {
            btnExecuteAction_Click(txtA.Text);
        }

        private void btnExecuteAction_ClickB(object sender, RoutedEventArgs e)
        {
            btnExecuteAction_Click(txtB.Text);
        }

        private void btnExecuteAction_ClickC(object sender, RoutedEventArgs e)
        {
            btnExecuteAction_Click(txtC.Text);
        }

        private void btnExecuteAction_Click(string url)
        {
            string[] response = url.Split('/');
            Console.WriteLine(response[0]);
            Assembly assembly = Assembly.Load("ReflectionLib");
            Type type = assembly.GetType($"ReflectionLib.{response[0]}Controller");
            object instance = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod($"{response[1]}");
            var par = methodInfo.GetParameters();

            //foreach (var item in par)
            //{
            //    Console.WriteLine(item);
            //}
            object result = methodInfo.Invoke(instance, null);
            
            MessageBox.Show(result.ToString());
        }
    }
}
