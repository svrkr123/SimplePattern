using Contracts.Dtos;
using GlobalClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PresentationLayer.Factory;
using PresentationLayer.Utility;
using System;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class DapperController : Controller
    {
        private readonly IOptions<BaseUrl> _url;

        public DapperController(IOptions<BaseUrl> url)
        {
            _url = url;
            Base_Url.Url = _url.Value.URL;
        }

        public async Task<IActionResult> Index()
        {
            var result = await ApiClientFactory.Instance.GetDapperList().ConfigureAwait(false);
            return View(result);
        }

        [HttpPost]
        public async Task<JsonResult> SaveData(DapperDto dapperDto)
        {
            try
            {
                var response = await ApiClientFactory.Instance.InsertDapper(dapperDto).ConfigureAwait(false);
                if (response.IsSuccess)
                {
                    response.Message = "Data Added Successful";
                }
                return Json(response.Message);
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}
