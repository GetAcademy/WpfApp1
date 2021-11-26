using System;
using System.Collections;
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

            var clickerPanel1 = new ClickerPanel();
            var clickerPanel2 = new ClickerPanel();
            var clickerPanel3 = new ClickerPanel();
            var clickerPanel4 = new ClickerPanel();
            var clickerPanel5 = new ClickerPanel();

            var stackPanel = new StackPanel();
            stackPanel.Children.Add(clickerPanel1.Panel);
            stackPanel.Children.Add(clickerPanel2.Panel);
            stackPanel.Children.Add(clickerPanel3.Panel);
            stackPanel.Children.Add(clickerPanel4.Panel);
            stackPanel.Children.Add(clickerPanel5.Panel);

            window.Content = stackPanel;


            app.Run(window);
        }


        /*
class Program
    {
        static Label label;
        static int count = 0;


        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var panel = new StackPanel();
            label = new Label() { Content = "0" };
            var button = new Button() { Content = "Trykk her!" };
            button.Click += ButtonClick;
            panel.Children.Add(label);
            panel.Children.Add(button);
            window.Content = panel;
            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            count++;
            label.Content = count;
        }
    }         
         */
    }
}
