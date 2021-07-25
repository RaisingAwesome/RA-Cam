using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
namespace ra_cam.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPostMine()
        {
            // request buffer in jobject
            return new JsonResult("hello");
        }
        public async Task<IActionResult> OnPostGetter()
        {
            // request buffer in jobject
            string the_msg="nothing";
            using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://" + Request.Query["value"] +"/"+ Request.Query["the_type"]))
                    {
                        try {
                            var response = await httpClient.SendAsync(request);
                            var contents = await response.Content.ReadAsStringAsync();
                            the_msg=contents.ToString();
                        }
                        catch (Exception e){
                            the_msg="http://" + Request.Query["value"] +"/"+ Request.Query["the_type"];
                        }                     
                    }
                }
            return new JsonResult(the_msg);
        }
        public async Task<IActionResult> OnPostSetter()
        {
            // request buffer in jobject
            string the_msg="nothing";
            using (var httpClient = new HttpClient())
                {
                     using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://" + Request.Query["value"] +"/set"+ Request.Query["the_type"]))
                    
                    {
                        try {
                            var response = await httpClient.SendAsync(request);
                            var contents = await response.Content.ReadAsStringAsync();
                            the_msg=contents.ToString();
                        }
                        catch (Exception e){
                            the_msg="http://" + Request.Query["value"] +"/set"+ Request.Query["the_type"];
                        }                     
                    }
                }
            return new JsonResult(the_msg);
        }
    }
}
