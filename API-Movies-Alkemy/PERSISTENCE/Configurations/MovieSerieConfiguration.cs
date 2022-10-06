using ENTITY.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PERSISTENCE.Configurations
{
    public class MovieSerieConfiguration
    {
        public MovieSerieConfiguration(EntityTypeBuilder<MovieSerie> entity)
        {
            entity.HasKey(e => e.IdMovieSerie);
        }
    }
}
