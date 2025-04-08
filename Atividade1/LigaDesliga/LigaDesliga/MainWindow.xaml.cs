using System;
using System.Windows;

namespace LigaDesliga
{
    public partial class MainWindow : Window
    {
        // Variável para armazenar o estado
        private bool isOn = false; // Estado inicial (Desligado)

        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento de clique do botão
        private void btnToggle_Click(object sender, RoutedEventArgs e)
        {
            // Alternar o estado entre Ligado e Desligado
            if (isOn)
            {
                // Se estiver ligado, desligue
                isOn = false;
                btnToggle.Content = "Desligado";
                MessageBox.Show("O estado agora é: Desligado", "Estado Atual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Se estiver desligado, ligue
                isOn = true;
                btnToggle.Content = "Ligado";
                MessageBox.Show("O estado agora é: Ligado", "Estado Atual", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
