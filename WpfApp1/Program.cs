using System;
using System.Collections;
using System.Collections.Generic;
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

            //var clickerPanel1 = new ClickerPanel();
            //var clickerPanel2 = new ClickerPanel();
            //var clickerPanel3 = new ClickerPanel();
            //var clickerPanel4 = new ClickerPanel();
            //var clickerPanel5 = new ClickerPanel();

            var stackPanel = new StackPanel();
            //stackPanel.Children.Add(clickerPanel1);
            //stackPanel.Children.Add(clickerPanel2);
            //stackPanel.Children.Add(clickerPanel3);
            //stackPanel.Children.Add(clickerPanel4);
            //stackPanel.Children.Add(clickerPanel5);

            for (var i = 0; i < 10; i++)
            {
                stackPanel.Children.Add(
                    new ClickerPanel());
            }
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
