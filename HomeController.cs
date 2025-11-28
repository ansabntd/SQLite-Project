using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
using RestSharp;
using SQLProject.Models;
using SQLProject.Services;
using System.Diagnostics;
namespace SQLProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDBContext _db;
        private readonly CreateSqlDb _sql;
        public HomeController(MyDBContext db, CreateSqlDb sql)
        {
            _db = db;
            _sql = sql;
        }

        public IActionResult Index()
        {
            var success = _sql.CreateSqliteDb();
            if (success)
            {
                var client = new RestClient("https://api.petpooja.com/V1/orders/get_sales_data");

                var request = new RestRequest("", Method.Get);

                request.AddQueryParameter("app_key", "srd2neaq1xg7bzc6uyk5jmwv98o4tpfh");
                request.AddQueryParameter("app_secret", "fd08934c5224af4c975015e599d60a74bf857b4a");
                request.AddQueryParameter("access_token", "0442e1ee9899bc3806f1a40be490af4ec5c6602a");
                request.AddQueryParameter("restID", "51wok2zxnsad");
                request.AddQueryParameter("from_date", "2025-01-20 00:00:00");
                request.AddQueryParameter("to_date", "2025-01-20 23:59:59");
                var response = client.Execute(request);
                if(response != null)
                {
                    var data = JsonConvert.DeserializeObject<SalesResponse>(response.Content);

                    if (data?.Records != null)
                    {
                        foreach (var rec in data.Records)
                        {
                            _db.sales_data.Add(rec);
                        }
                        _db.SaveChanges();
                    }
                }


            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
