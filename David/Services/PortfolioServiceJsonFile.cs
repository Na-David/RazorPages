﻿using David.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace David.Services
{
	public class PortfolioServiceJsonFile
	{
		private readonly IWebHostEnvironment _webHostEnvironment;

		public PortfolioServiceJsonFile(IWebHostEnvironment webHostEnvironment)
		{
			this._webHostEnvironment = webHostEnvironment;
		}

		private string JsonFileName
		{
			get
			{
				//return _webHostEnvironment.WebRootPath + "\\Portfolios" + "\\portfolios.json";
				return Path.Combine(_webHostEnvironment.WebRootPath, "Portfolios", "portfolios.json");
			}
		}
		public IEnumerable<Portfolio> GetPortfolios()
		{
			//var jsonFileName = @"C:\Users\hna20\Desktop\ASP.NET\WebApp_Razor\David\wwwroot\Portfolios\portfolios.json";

			using (var jsonFileReader = File.OpenText(JsonFileName))
			{
				var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
				var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);
				return portfolios;
			}
		}
	}
}
