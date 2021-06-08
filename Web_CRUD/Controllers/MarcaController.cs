using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MarcaController : Controller
    {
        private IConfiguration _configuration;
        public MarcaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: MarcaController
        public ActionResult Index()
        {
            var query = "SELECT * FROM Marcas";
            var connection = new SqlConnection(_configuration["ConnectionString"]);

            connection.Open();
            var data = connection.Query<Marca>(query);
            connection.Close();
            return View(data);
        }

        // GET: MarcaController/Details/5
        public ActionResult Details(int id)
        {
            var query = "SELECT * FROM Marcas WITH(NOLOCK) WHERE Id=@id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);

            connection.Open();
            var data = connection.Query<Marca>(query, new { id }).FirstOrDefault();
            connection.Close();
            return View(data);
        }

        // GET: MarcaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarcaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Marca marca)
        {
            var query = "INSERT INTO Marcas(Nome)VALUES(@Nome)";
            var connection = new SqlConnection(_configuration["ConnectionString"]);           
            try
            {
                connection.Open();
                var data = connection.Execute(query, new { marca.Nome });
                connection.Close();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarcaController/Edit/5
        public ActionResult Edit(int id)
        {
            var query = "SELECT * FROM Marcas WITH(NOLOCK) WHERE Id=@id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);

            connection.Open();
            var data = connection.Query<Marca>(query, new { id }).FirstOrDefault();
            connection.Close();
            return View(data);
        }

        // POST: MarcaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Marca marca)
        {
            var query = "UPDATE Marcas SET Nome=@Nome WHERE Id=@Id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            try
            {
                connection.Open();
                var data = connection.Execute(query, new { marca.Nome, id });
                connection.Close();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarcaController/Delete/5
        public ActionResult Delete(int id)
        {
            var query = "SELECT * FROM Marcas WITH(NOLOCK) WHERE Id=@id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);

            connection.Open();
            var data = connection.Query<Marca>(query, new { id }).FirstOrDefault();
            connection.Close();
            return View(data);
        }

        // POST: MarcaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Marca marca)
        {
            var query = "DELETE Marcas WHERE Id=@Id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            try
            {
                connection.Open();
                connection.Execute(query, new { marca.Id });
                connection.Close();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
