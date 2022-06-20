using David.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace David.Services
{
	public class PortfolioServiceJsonFile
	{
		public IEnumerable<Portfolio> GetPortfolios()
		{
			var jsonFileName = @"C:\Users\hna20\Desktop\ASP.NET\WebApp_Razor\David\wwwroot\Portfolios\portfolios.json";

			using (var jsonFileReader = File.OpenText(jsonFileName))
			{
				var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
				var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);
				return portfolios;
			}
		}
	}
}
