using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace ExibirDescricaoEnum
{
    public enum TipoUsuario
    {
        [Description("Administrador do sistema")]
        Administrador,

        [Description("Usuário comum")]
        UsuarioComum,

        [Description("Visitante sem acesso a funcionalidades")]
        Visitante
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Preencher o ComboBox com os valores do enum
            cboTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Obter o item selecionado no ComboBox
            TipoUsuario tipoSelecionado = (TipoUsuario)cboTipoUsuario.SelectedItem;

            // Obter a descrição do tipo selecionado
            string descricao = GetEnumDescription(tipoSelecionado);

            // Exibir a descrição no MessageBox
            MessageBox.Show(descricao, "Descrição do Tipo de Usuário", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Função para obter a descrição do enum usando o DescriptionAttribute
        private string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
