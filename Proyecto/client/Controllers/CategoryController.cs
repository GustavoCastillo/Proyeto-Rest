using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Category = BookStore.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace client.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Category> category = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Categories");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Category>>();
                    readTask.Wait();

                    category = readTask.Result;
                }

                //else //web api sent error response 
                //{
                //    //log response status here..

                //    libros = Enumerable.Empty<Libro>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                //}
            }
            return View(category);
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
        public async Task<IActionResult> Create(Category category)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44357/api/");
                    //HTTP GET
                    // var responseTask = client.GetAsync("Books");
                    string ingestPath = "https://localhost:44357/api/Categories";

                    category.Created = DateTime.Today;
                    //var content = new StringContent(book.ToString(), Encoding.UTF8, "application/json");

                    var stringcategory = await Task.Run(() => JsonConvert.SerializeObject(category));

                    // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                    var httpContent = new StringContent(stringcategory, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(ingestPath, httpContent);

                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;
                    //res = JsonConvert.DeserializeObject<DoStuffResult>(outputJson);
                    return RedirectToAction("Index", "Category");

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
            Category category = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync(string.Format("Categories/{0}", id.ToString()));

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Category>();
                    readTask.Wait();

                    category = readTask.Result;
                }
                //else //web api sent error response 
                //{
                //    //log response status here..

                //    libros = Enumerable.Empty<Libro>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                //}
            }
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            Category category = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync(string.Format("Categories/{0}", id.ToString()));

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Category>();
                    readTask.Wait();

                    category = readTask.Result;
                }
                //else //web api sent error response 
                //{
                //    //log response status here..

                //    libros = Enumerable.Empty<Libro>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                //}
               
            }
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            using (var client = new HttpClient())
            {
                try
                {

                  client.BaseAddress = new Uri("https://localhost:44357/");

                    var uri = string.Format("api/Categories/{0}", category.Id.ToString());
                    HttpResponseMessage response = await client.PutAsJsonAsync(uri, category);
                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;

                    return RedirectToAction("Index", "Category");

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
            Category category = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                //HTTP GET
                var responseTask = client.GetAsync(string.Format("Categories/{0}", id.ToString()));

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Category>();
                    readTask.Wait();

                    category = readTask.Result;
                }
                //else //web api sent error response 
                //{
                //    //log response status here..

                //    libros = Enumerable.Empty<Libro>();

                //    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                //}
               
            }
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Category category)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44357/");

                    var uri = string.Format("api/Categories/{0}", category.Id.ToString());
                    HttpResponseMessage response = await client.DeleteAsync(uri);
                    Task<string> responseString = response.Content.ReadAsStringAsync();
                    string outputJson = await responseString;

                    return RedirectToAction("Index", "Category");

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