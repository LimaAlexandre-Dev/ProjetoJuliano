using System;
using System.Windows;

namespace ContadorDeCliques
{
    public partial class MainWindow : Window
    {
        // Variável para armazenar o contador
        private int contador = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento acionado quando o botão é clicado
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Incrementar o contador
            contador++;

            // Exibir o valor atual do contador em um MessageBox
            MessageBox.Show($"Você clicou {contador} vezes!", "Contador de Cliques", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
