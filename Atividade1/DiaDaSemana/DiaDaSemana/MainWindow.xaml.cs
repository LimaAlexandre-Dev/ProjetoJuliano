using System;
using System.Windows;

namespace VerificarDiaDaSemana
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Enum para representar os dias da semana
        public enum DiaSemana
        {
            Domingo = 0,
            Segunda = 1,
            Terça = 2,
            Quarta = 3,
            Quinta = 4,
            Sexta = 5,
            Sábado = 6
        }

        // Evento de clique do botão
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Verificar se uma data foi selecionada
            if (datePicker.SelectedDate.HasValue)
            {
                // Obter o dia da semana da data selecionada
                DayOfWeek diaDaSemana = datePicker.SelectedDate.Value.DayOfWeek;

                // Converter o valor do dia da semana para o enum
                DiaSemana diaEnum = (DiaSemana)diaDaSemana;

                // Exibir o resultado no MessageBox
                MessageBox.Show($"O dia da semana selecionado é: {diaEnum}", "Dia da Semana", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
