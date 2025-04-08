using System;
using System.Windows;

namespace SomaDeDoisNumeros
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obter os valores dos TextBox e converter para inteiros
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);

                // Calcular a soma
                int soma = numero1 + numero2;

                // Exibir o resultado em um MessageBox
                MessageBox.Show($"A soma é: {soma}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                // Se a conversão falhar, mostrar um erro
                MessageBox.Show("Por favor, insira números válidos.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
