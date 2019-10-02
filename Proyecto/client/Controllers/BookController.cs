using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;
using client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebClient.Controllers;
using WebClient.Models;
using Book = BookStore.Models.Book;

namespace client.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Book> libros = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");

                var tokenCtrl = new TokenController();
                var _token = tokenCtrl.Index();

               // var _token = HttpContext.Session.GetString("Token");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
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
            
            }
            return View(libros);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create( Book book)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44357/api/");
                    //HTTP GET
                   // var responseTask = client.GetAsync("Books");
                    string ingestPath = "https://localhost:44357/api/Books";


                    //var content = new StringContent(book.ToString(), Encoding.UTF8, "application/json");

                    var stringBook = await Task.Run(() => JsonConvert.SerializeObject(book));

                    // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                    var httpContent = new StringContent(stringBook, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(ingestPath, httpContent);

                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;
                    //res = JsonConvert.DeserializeObject<DoStuffResult>(outputJson);
                    return RedirectToAction("Index", "BooK");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString()); //"Invalid URI: The Uri string is too long."
                }
            }

            return View();
        }
        public IActionResult Details(int id)
        {
            BookDetails model = new BookDetails();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync(string.Format("books/{0}",id.ToString()));

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Book>();
                    readTask.Wait();

                    model.book = readTask.Result;
                }

                var responseTaskList = client.GetAsync(string.Format("Reviews/book/{0}", id.ToString()));

                responseTaskList.Wait();

                var resultList = responseTaskList.Result;
                if (resultList.IsSuccessStatusCode)
                {
                    var readTaskList = resultList.Content.ReadAsAsync<IList<Review>>();
                    readTaskList.Wait();

                    model.bookReviews = (readTaskList.Result).ToList();
                }
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Book libro = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync(string.Format("books/{0}", id.ToString()));

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Book>();
                    readTask.Wait();

                    libro = readTask.Result;
                }
                //else //web api sent error response 
                //{
                //    //log response status here..

                //    libros = Enumerable.Empty<Libro>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                //}
            }
            return View(libro);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            using (var client = new HttpClient())
            {
                try
                {
                   
                    //HTTP GET
                    // var responseTask = client.GetAsync("Books");
                    //string ingestPath = "https://localhost:44357/api/Books";

                    //var responseTask = client.GetAsync(string.Format("books/{0}", book.Id.ToString()));

                    ////var content = new StringContent(book.ToString(), Encoding.UTF8, "application/json");

                    // var stringBook = await Task.Run(() => JsonConvert.SerializeObject(book));

                    //// Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                    //var httpContent = new StringContent(stringBook, Encoding.UTF8, "application/json");

                    //var response = await client.PutAsync(responseTask.ToString(), httpContent);

                    //Task<string> responseString = response.Content.ReadAsStringAsync();
                    //string outputJson = await responseString;
                    ////res = JsonConvert.DeserializeObject<DoStuffResult>(outputJson);


                    client.BaseAddress = new Uri("https://localhost:44357/");

                    book.Created = DateTime.Today;
                    var uri = string.Format("api/Books/{0}", book.Id.ToString());
                    HttpResponseMessage response = await client.PutAsJsonAsync(uri, book);
                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;

                    return RedirectToAction("Index", "BooK");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString()); //"Invalid URI: The Uri string is too long."
                }
            }

            return View();
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            Book libro = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync(string.Format("books/{0}", id.ToString()));

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Book>();
                    readTask.Wait();

                    libro = readTask.Result;
                }
                //else //web api sent error response 
                //{
                //    //log response status here..

                //    libros = Enumerable.Empty<Libro>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                //}
            }
            return View(libro);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Book book)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44357/");
                    
                    var uri = string.Format("api/Books/{0}", book.Id.ToString());
                    HttpResponseMessage response = await client.DeleteAsync(uri);
                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;

                    return RedirectToAction("Index", "BooK");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString()); //"Invalid URI: The Uri string is too long."
                }
            }

            return View();
        }
   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteReview(int id, int Idlibro)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44357/");

                    var uri = string.Format("api/Reviews/{0}", id.ToString());
                    HttpResponseMessage response = await client.DeleteAsync(uri);
                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;

                    
                    return RedirectToAction("Details", "BooK", new { id = Idlibro });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString()); //"Invalid URI: The Uri string is too long."
                }
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateReview(Review review, int Idlibro)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44357/");
                    review.IdLibro = Idlibro;
                    var uri = "api/Reviews";
                    HttpResponseMessage response = await client.PostAsJsonAsync(uri, review);
                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;


                    return RedirectToAction("Details", "BooK", new { id = Idlibro });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString()); //"Invalid URI: The Uri string is too long."
                }   
            }

            return View();
        }
    }
}
