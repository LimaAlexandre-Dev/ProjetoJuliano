namespace ProgramacaoIV.Venda.Api.Entidades;

public sealed class Transacao : AbstractEntity
{
    public Cliente Cliente { get; private set; }
    public Vendedor Vendedor { get; private set; } // NOVO
    public ICollection<ItemTransacao> Itens { get; private set; } = new List<ItemTransacao>();
    public decimal Total => Itens.Sum(x => x.Total);

    /// <summary>
    /// To EF Core
    /// </summary>
    private Transacao() : base() { }

    public Transacao(Cliente cliente, Vendedor vendedor)
    {
        Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        Vendedor = vendedor ?? throw new ArgumentNullException(nameof(vendedor));
    }

    // Mantido por compatibilidade, se quiser pode remover
    public Transacao(Cliente cliente)
    {
        Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        Vendedor = null!; // EF ignora, mas você pode validar se quiser forçar via controller
    }

    public void AdicionarItem(ItemTransacao item)
    {
        Itens.Add(item);
        AtualizarDataAtualizacao();
    }

    public void RemoverItem(ItemTransacao item)
    {
        ArgumentNullException.ThrowIfNull(item, nameof(item));
        Itens.Remove(item);
        AtualizarDataAtualizacao();
    }
}
