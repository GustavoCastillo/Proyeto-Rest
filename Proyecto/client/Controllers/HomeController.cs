using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using client.Models;
using Microsoft.AspNetCore.Mvc;
using WebClient.Controllers;
using WebClient.Models;
using Book = BookStore.Models.Book;

namespace client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
             //var tokenCtrl = new TokenController();
             //tokenCtrl.Index();
            BookDetails model = new BookDetails();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync("books/lastBook");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Book>>();
                    readTask.Wait();

                    model.BookList = (readTask.Result).ToList();
                }

                var responseTaskList = client.GetAsync("Reviews/popular/");

                responseTaskList.Wait();

                var resultList = responseTaskList.Result;
                if (resultList.IsSuccessStatusCode)
                {
                    var readTaskList = resultList.Content.ReadAsAsync<IList<Popular>>();
                    readTaskList.Wait();

                    model.bookPopular = (readTaskList.Result).ToList();
                }
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
