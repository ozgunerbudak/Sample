using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sample.BLPuantaj;
using Sample.Domain.Model;

namespace Sample.Puantaj.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPuantajService _puantajService;
        public IndexModel(ILogger<IndexModel> logger, IPuantajService puantajService)
        {
            _logger = logger;
            _puantajService = puantajService;
        }

        public void OnGet()
        {

        }

        public List<PuantajModel> GetPuantajListesi(int userId)
        {
            var puantajListesi = _puantajService.GetPuantajs();
            return puantajListesi;
        }
    }
}