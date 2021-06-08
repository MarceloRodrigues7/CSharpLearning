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
    public class CarroController : Controller
    {
        private IConfiguration _configuration;

        public CarroController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: CarroController
        public ActionResult Index()
        {
            var query = "SELECT * FROM Carros";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            var data = connection.Query<Carro>(query);
            return View(data);
        }

        // GET: CarroController/Details/5
        public ActionResult Details(int id)
        {
            var query = "SELECT * FROM Carros WITH(NOLOCK) WHERE Id=@id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            connection.Open();
            var data = connection.Query<Carro>(query, new { id }).FirstOrDefault();
            connection.Close();
            return View(data);
        }

        // GET: CarroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Carro carro)
        {
            var query = "INSERT INTO Carros(Id_Marca,Modelo,Ano,Cor)VALUES(@Id_Marca,@Modelo,@Ano,@Cor)";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            try
            {
                connection.Open();
                connection.Execute(query, new { carro.Id_Marca, carro.Modelo, carro.Ano, carro.Cor });
                connection.Close();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarroController/Edit/5
        public ActionResult Edit(int id)
        {
            var query = "SELECT * FROM Carros WITH(NOLOCK) WHERE Id=@id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            connection.Open();
            var data = connection.Query<Carro>(query, new { id }).FirstOrDefault();
            return View(data);
        }

        // POST: CarroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Carro carro)
        {
            var query = "UPDATE Carros SET Id_Marca=@Id_Marca,Modelo=@Modelo,Ano=@Ano,Cor=@Cor WHERE Id=@Id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            try
            {
                connection.Open();
                connection.Execute(query, new { carro.Id_Marca, carro.Modelo, carro.Ano, carro.Cor, carro.Id });
                connection.Close();
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }

        // GET: CarroController/Delete/5
        public ActionResult Delete(int id)
        {
            var query = "SELECT * FROM Carros WITH(NOLOCK) WHERE Id=@id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            connection.Open();
            var data = connection.Query<Carro>(query, new { id }).FirstOrDefault();
            return View(data);
        }

        // POST: CarroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Carro carro)
        {
            var query = "DELETE Carros WHERE Id=@Id";
            var connection = new SqlConnection(_configuration["ConnectionString"]);
            try
            {
                connection.Open();
                connection.Execute(query, new {carro.Id });
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
