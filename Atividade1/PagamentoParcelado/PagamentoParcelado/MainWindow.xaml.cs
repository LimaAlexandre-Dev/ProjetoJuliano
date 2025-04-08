using System;
using System.Windows;
using System.Windows.Controls;

namespace SimuladorPagamentoParcelado
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
                // Obter o valor total da compra
                decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);

                // Obter o número de parcelas selecionado
                int parcelas = int.Parse(((ComboBoxItem)cboParcelas.SelectedItem).Content.ToString());

                // Calcular o valor de cada parcela
                decimal valorParcela = valorTotal / parcelas;

                // Exibir o valor da parcela no MessageBox
                MessageBox.Show($"Valor de cada parcela: R$ {valorParcela:F2}", "Simulação de Pagamento", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um valor válido para o valor total.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor, selecione a quantidade de parcelas.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
