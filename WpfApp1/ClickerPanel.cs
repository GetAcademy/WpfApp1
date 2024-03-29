﻿using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    class ClickerPanel : StackPanel
    {
        Label label;
        int count = 0;

        public ClickerPanel()
        {
            Orientation = Orientation.Horizontal;
            label = new Label() { Content = "0" };
            var button = new Button() { Content = "Trykk her!" };
            button.Click += ButtonClick;
            Children.Add(label);
            Children.Add(button);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            count++;
            label.Content = count;
        }
    }
}
