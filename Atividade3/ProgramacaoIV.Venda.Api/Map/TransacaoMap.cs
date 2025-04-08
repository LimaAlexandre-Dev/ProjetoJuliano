using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgramacaoIV.Venda.Api.Entidades;
using ProgramacaoIV.Venda.Api.Map;

public sealed class TransacaoMap : AbstractEntidadeMap<Transacao>
{
    public override void Configure(EntityTypeBuilder<Transacao> builder)
    {
        base.Configure(builder);

        builder.ToTable("TRANSACAO");

        builder
            .HasOne(x => x.Cliente)
            .WithMany()
            .HasForeignKey("ID_CLIENTE")
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        builder
            .HasOne(x => x.Vendedor)
            .WithMany()
            .HasForeignKey("ID_VENDEDOR")
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        builder.HasMany(x => x.Itens)
            .WithOne()
            .HasForeignKey("ID_TRANSACAO")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Ignore(x => x.Total);
    }
}
