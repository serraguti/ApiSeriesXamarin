using ApiSeriesXamarin.Models;
using ApiSeriesXamarin.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSeriesXamarin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private RepositorySeries repo;

        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Serie>> GetSeries()
        {
            return this.repo.GetSeries();
        }

        [HttpGet("{id}")]
        public ActionResult<Serie> GetSerie(int id)
        {
            return this.repo.FindSerie(id);
        }

        [HttpPost]
        public void InsertarSerie(Serie serie)
        {
            this.repo.AddSerie(serie.NombreSerie, serie.Imagen, serie.Anyo);
        }

        [HttpPut]
        public void UpdateSerie(Serie serie)
        {
            this.repo.UpdateSerie(serie.IdSerie,
                serie.NombreSerie, serie.Imagen, serie.Anyo);
        }

        [HttpDelete("{id}")]
        public void DeleteSerie(int id)
        {
            this.repo.DeleteSerie(id);
        }
    }
}
