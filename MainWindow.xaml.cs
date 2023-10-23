using System;
using System.Windows;

namespace LB_1 {
    public partial class MainWindow {
        private bool _is3Side;

        public MainWindow() {
            InitializeComponent();
        }

        private void Checked(object sender, RoutedEventArgs e) {
            if (a_label != null)
                a_label.Content = "a = ";
            _is3Side = true;
        }

        private void UnChecked(object sender, RoutedEventArgs e) {
            if (a_label != null)
                a_label.Content = "a\u00b0 = ";
            _is3Side = false;
        }

        private void perform_calc_Click(object sender, RoutedEventArgs e) {
            try {
                var a = float.Parse(text_a.Text);
                var b = float.Parse(text_b.Text);
                var c = float.Parse(text_c.Text);

                var triangle = new Triangle(!_is3Side, a, b, c);
                if (s_label != null)
                    s_label.Content = Math.Round(triangle.S(), 2) + " См\u00b2";
                if (p_label != null)
                    p_label.Content = Math.Round(triangle.P(), 2) + " См";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}