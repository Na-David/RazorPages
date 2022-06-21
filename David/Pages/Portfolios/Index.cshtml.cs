using David.Models;
using David.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace David.Pages.Portfolios
{
	public class IndexModel : PageModel
	{
        private readonly PortfolioServiceJsonFile _service;

        public IndexModel(PortfolioServiceJsonFile service)
        {
            this._service = service;
        }

        public IEnumerable<Portfolio> Portfolios { get; private set; }

        public void OnGet()
		{
            Portfolios = _service.GetPortfolios();
		}
	}
}
