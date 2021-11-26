using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    class CompositionClickerPanel
    {
        Label label;
        int count = 0;
        public StackPanel Panel { get; }

        public CompositionClickerPanel()
        {
            Panel = new StackPanel();
            label = new Label() { Content = "0" };
            var button = new Button() { Content = "Trykk her!" };
            button.Click += ButtonClick;
            Panel.Children.Add(label);
            Panel.Children.Add(button);
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            count++;
            label.Content = count;
        }
    }
}
