using System;
using System.Windows;

namespace ConversorTemperatura
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
                // Obter o valor em Celsius a partir do TextBox
                double celsius = Convert.ToDouble(txtCelsius.Text);

                // Converter para Fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;

                // Exibir o resultado em um MessageBox
                MessageBox.Show($"Temperatura em Fahrenheit: {fahrenheit} °F", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                // Se a conversão falhar, mostrar uma mensagem de erro
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
