using System;
using System.Windows;

namespace VerificadorMaioridade
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
                // Obter a idade a partir do TextBox e converter para inteiro
                int idade = Convert.ToInt32(txtIdade.Text);

                // Verificar se é maior ou menor de idade
                if (idade >= 18)
                {
                    MessageBox.Show("Você é maior de idade.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Você é menor de idade.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                // Se a conversão falhar, mostrar uma mensagem de erro
                MessageBox.Show("Por favor, insira um número válido para a idade.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
