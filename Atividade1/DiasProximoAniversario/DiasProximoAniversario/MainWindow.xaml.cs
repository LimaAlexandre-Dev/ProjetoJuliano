using System;
using System.Windows;

namespace DiasAtéAniversario
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Verifica se o usuário selecionou uma data
            if (dpNascimento.SelectedDate.HasValue)
            {
                DateTime dataNascimento = dpNascimento.SelectedDate.Value;
                DateTime hoje = DateTime.Today;

                // Define o próximo aniversário com base no dia e mês da data de nascimento
                DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

                // Se o aniversário já passou este ano, calcula para o próximo ano
                if (proximoAniversario < hoje)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }

                // Calcula a diferença de dias
                int diasFaltando = (proximoAniversario - hoje).Days;

                // Exibe o resultado em um MessageBox
                MessageBox.Show($"Faltam {diasFaltando} dias para o seu próximo aniversário!", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Se não foi selecionada uma data, mostra um erro
                MessageBox.Show("Por favor, selecione sua data de nascimento.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
