namespace ProgramacaoIV.Venda.Api.Entidades;

public sealed class Vendedor : AbstractEntity
{
	public string Nome { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// To EF Core
	/// </summary>
	private Vendedor() : base() { }

	public Vendedor(string nome, string email)
	{
		Nome = nome.ToUpper() ?? throw new ArgumentNullException(nameof(nome));
		Email = email ?? throw new ArgumentNullException(nameof(email));
	}
}
