using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MemeSynthesis.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MemeSynthesis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
 
        public async Task<IActionResult> Memes() // this will return all the memes
        {
            HttpClient hCli = new HttpClient();
            hCli.DefaultRequestHeaders.Accept.Clear();
            hCli.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue("application/json"));

            var theMemes = await hCli.GetStringAsync("https://api.imgflip.com/get_memes");  //gets the json string async
            Root derezzedObj = JsonSerializer.Deserialize<Root>(theMemes);                  //deserializes to root class

            return View(derezzedObj.data.memes);
        }


        public IActionResult Generate(string id, string url){ // gets id and url from the user
            ViewBag.id = id;
            ViewBag.url = url;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Generate(string caption1,string caption2, string id)
        { //sends request to generate the meme with user captions
            HttpClient hc = new HttpClient();

            HttpRequestMessage hrm = new HttpRequestMessage();
            hrm.Method = HttpMethod.Post;

            hrm.RequestUri = new Uri("https://api.imgflip.com/caption_image?template_id=" + id 
                + "&username=19005768&password=WhyEven0101&text0=" + caption1 
                + "&text1=" + caption2);
            HttpResponseMessage RMessage = await hc.SendAsync(hrm);            
            string result  = RMessage.Content.ReadAsStringAsync().Result;
            GeneratedRoot g = JsonSerializer.Deserialize<GeneratedRoot>(result);  
                        
            return RedirectToAction("Result",new { url=g.data.url});
            
            // if you had to send an object across as JSON
            //Uri uri = new Uri("https://api.imgflip.com/caption_image");
            //RequestModel rm = new RequestModel("[your username]","[your password]",caption1, caption2);
            //string jsonContent = JsonSerializer.Serialize(rm);
            //byte[] buffer = System.Text.Encoding.UTF8.GetBytes(jsonContent);
            //ByteArrayContent b = new ByteArrayContent(buffer);
            //b.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //HttpResponseMessage resp = await client.postAsync(uri,b);
        }
     
        public IActionResult Result(string url ){
            ViewBag.url = url;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
