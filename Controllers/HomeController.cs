using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CloudApp.Models;
using System.Net.Http;
using Newtonsoft.Json;
//using CloudApp.APIHandlerManager;
using System.IO;

namespace CloudApp.Controllers
{
	public class HomeController : Controller
	{
		HttpClient httpClient;

		static string BASE_URL = "https://data.cityofnewyork.us/resource/h9gi-nx95.json";
		//static string API_KEY = "MCRTRfBXvHOIfCVVYh74dCnMkdpjTtK6QJ0t2cRH";

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Accept.Clear();
			//httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
			httpClient.DefaultRequestHeaders.Accept.Add(
				new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			string API_PATH = BASE_URL;
			string crashesData = "";

			//List<Crashes> crashes = null;

			httpClient.BaseAddress = new Uri(API_PATH);

			try
			{
				HttpResponseMessage response = httpClient.GetAsync(API_PATH).GetAwaiter().GetResult();

				if (response.IsSuccessStatusCode)
				{
					crashesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
				}

				if (!crashesData.Equals(""))
				{
					// JsonConvert is part of the NewtonSoft.Json Nuget package
					//var settings = new JsonSerializerSettings(); settings.CheckAdditionalContent = false;
					List<Crashes> crashes = JsonConvert.DeserializeObject<List<Crashes>>(crashesData);
					}
				
			}
			catch (Exception e)
			{
				// This is a useful place to insert a breakpoint and observe the error message
				Console.WriteLine(e.Message);
			}

			return View(); 
		}

		public IActionResult AboutUs()
		{
			return View("AboutUS");
		}

		public IActionResult Crashstats()
		{
			return View("Crashstats");
		}

		public IActionResult Visualize()
		{
			return View("Visualize");
		}

		public IActionResult Sample()
		{
			return View("Sample");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

