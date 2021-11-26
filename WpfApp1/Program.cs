using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var panel = new StackPanel();
            var label = new Label() { Content = "0" };
            var button = new Button() { Content = "Trykk her!" };
            panel.Children.Add(label);
            panel.Children.Add(button);
            window.Content = panel;
            app.Run(window);
        }
    }
}
