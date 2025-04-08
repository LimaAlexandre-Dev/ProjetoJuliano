using System;
using System.Windows;

namespace SimuladorSorteio
{
    public partial class MainWindow : Window
    {
        // Instancia o gerador de números aleatórios
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento do clique do botão para realizar o sorteio
        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            // Gera um número aleatório entre 1 e 6
            int numeroSorteado = random.Next(1, 7); // O método Next(min, max) gera números entre min e max-1

            // Verifica o resultado e exibe a mensagem apropriada
            if (numeroSorteado == 6)
            {
                MessageBox.Show("Você ganhou!", "Resultado do Sorteio", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Tente novamente!", "Resultado do Sorteio", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
