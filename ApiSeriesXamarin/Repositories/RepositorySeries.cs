using ApiSeriesXamarin.Data;
using ApiSeriesXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSeriesXamarin.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public List<Serie> GetSeries()
        {
            return this.context.Series.ToList();
        }

        public Serie FindSerie(int id)
        {
            return this.context.Series.FirstOrDefault(x => x.IdSerie == id);
        }

        private int GetMaxIdSerie()
        {
            return this.context.Series.Max(z => z.IdSerie) + 1;
        }
        
        public void AddSerie(string nombre, string imagen, int anyo)
        {
            Serie serie = new Serie();
            serie.IdSerie = this.GetMaxIdSerie();
            serie.NombreSerie = nombre;
            serie.Imagen = imagen;
            serie.Anyo = anyo;
            this.context.Series.Add(serie);
            this.context.SaveChanges();
        }

        public void UpdateSerie
            (int id, string nombre, string imagen, int anyo)
        {
            Serie serie = this.FindSerie(id);
            serie.NombreSerie = nombre;
            serie.Imagen = imagen;
            serie.Anyo = anyo;
            this.context.SaveChanges();
        }

        public void DeleteSerie(int id)
        {
            Serie serie = this.FindSerie(id);
            this.context.Series.Remove(serie);
            this.context.SaveChanges();
        }
    }
}
