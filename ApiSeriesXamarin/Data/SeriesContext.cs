﻿using ApiSeriesXamarin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSeriesXamarin.Data
{
    public class SeriesContext: DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options)
            :base(options) { }

        public DbSet<Serie> Series { get; set; }
    }
}
