using System.Windows;
using System.Windows.Controls;

namespace CalculadoraStyledGenerado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock tb;
            Viewbox vb;
            Button btt;
            for (int i = 0; i < 9; i++)
            {
                tb = new TextBlock()
                {
                    Style = (Style)this.Resources["StyleTB"],
                    Text = "" + (i + 1)
                };
                vb = new Viewbox();
                vb.Child = tb;
                btt = new Button()
                {
                    Style = (Style)this.Resources["StyleButt"],
                    Content = vb
                };
                this.contenedor.Children.Add(btt);
            }
            tb = new TextBlock()
            {
                Style = (Style)this.Resources["StyleTB"],
                Text = "0"
            };
            vb = new Viewbox();
            vb.Child = tb;
            btt = new Button()
            {
                Style = (Style)this.Resources["StyleButtCero"],
                Content = vb
            };
            this.General.Children.Add(btt);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
            => VistaTexto.Text += ((TextBlock)(((Viewbox)(((Button)sender).Content)).Child)).Text;
    }
}
