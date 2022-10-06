using ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PERSISTENCE.Configurations
{
    public class CharacerConfiguration
    {
        public CharacerConfiguration(EntityTypeBuilder<Character> entity)
        {
            entity.HasKey(e => e.IdCharacter);

            entity.HasIndex(e=> e.Name)
                .HasName("name_character_unique")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .IsUnicode(false);
            entity.Property(e => e.Age)
                .IsUnicode(false);
            entity.Property(e => e.History)
                .IsUnicode(false);
            entity.Property(e => e.Weight)
                .IsUnicode(false);
        }
    }
}
