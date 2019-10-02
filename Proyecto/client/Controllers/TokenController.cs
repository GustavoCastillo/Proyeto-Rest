using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebServer.Models;
using Microsoft.AspNetCore.Http;

namespace WebClient.Controllers
{
    public class TokenController : Controller
    {
        //[HttpPost]
        public string Index()
        {
            var _token = "";
            using (var client = new HttpClient())
            {
               
                //HTTP GET
                // var responseTask = client.GetAsync("Books");
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                User user = new User();
                user.UserName = "admin";

              //var content = new StringContent(book.ToString(), Encoding.UTF8, "application/json");

                var stringcategory = JsonConvert.SerializeObject(user, Formatting.None);

                // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                var httpContent = new StringContent(stringcategory, Encoding.UTF8, "application/json");

                var response = client.PostAsync("Auth", httpContent);

                response.Wait();

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<User>();
                    readTask.Wait();

                    _token = readTask.Result.Token.ToString();
                }

            }

            //HttpContext.Current.Session["Token"] = _token;
            //HttpContext.Session.SetString("Token", _token);
            return _token;
        }
    }
}