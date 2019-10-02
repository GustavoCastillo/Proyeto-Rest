using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
namespace WebClient.Controllers
{
    public class LibroController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Book> libros = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync("books");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Book>>();
                    readTask.Wait();

                    libros = readTask.Result;
                }
                //else //web api sent error response 
                //{
                //    //log response status here..

                //    libros = Enumerable.Empty<Libro>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                //}
            }
            return View(libros);

        }
    }
}