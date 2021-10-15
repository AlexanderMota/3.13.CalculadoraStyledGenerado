using System;
using System.Collections.Generic;
using System.Linq;
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
            for(int i = 0; i < 9; i++)
            {
                this.contenedor.Children.Add(new Button
                {
                    Style = (Style)this.Resources["StyleButt"],
                    Tag = new Viewbox
                    {
                        Tag = new TextBlock
                        {
                            Style = (Style)this.Resources["StyleTB"],
                            Text = "" + (i + 1)
                        }
                    }
                });
            }
            this.General.Children.Add(new Button
            {
                Style = (Style)this.Resources["StyleButtCero"],
                Tag = new Viewbox
                {
                    Tag = new TextBlock
                    {
                        Style = (Style)this.Resources["StyleTB"],
                        Text = "0"
                    }
                }
            });
        }
        private void Button_Click(object sender, RoutedEventArgs e)
            => VistaTexto.Text += ((TextBlock)((Viewbox)(sender as Button).Tag).Tag).Text;
    }
}
