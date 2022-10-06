using ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PERSISTENCE.Configurations
{
    public class GenreConfiguration
    {
        public GenreConfiguration(EntityTypeBuilder<Genre> entity)
        {
            entity.HasKey(e => e.IdGenre);

            entity.HasIndex(e => e.Name)
                .HasName("name_genre_unique")
                .IsUnique();
            entity.Property(e => e.Name)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .IsUnicode(false);
        }
    }
}
