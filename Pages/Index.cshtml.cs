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
    {   public string racams=""; bool checker=false;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async void OnGet()
        {   //CheckForLiveCam("http://172.221.140.255:8555/still.jpg");
            checker=true;
            if (checker) racams="<a href='javascript: $(\"#main_img\").attr(\"src\",\"http://172.221.140.255:8555/stream.mjpg\");getAI(\"172.221.140.255:8555\");' id=10 name=10 title=\"RA-Cam\"><img loading=\"lazy\" src=\"/Images/cam.png\" width=\"128\" height=\"96\" alt=\"RA-Cam Not Found\" onload='this.src=\"http://172.221.140.255:8555/still.jpg\";' onerror='this.onerror=null; this.src=\"/Images/notfound.png\"'/></a>";
            racams+="<a href='javascript:  $(\"#main_img\").attr(\"src\",\"http://172.221.140.255:54/videostream.cgi?user=testor&pwd=testor&resolution=32&rate=0\");' id=11 name=11 title=\"RA-Cam\"><img loading=\"lazy\" src=\"http://172.221.140.255:54/videostream.cgi?user=testor&pwd=testor&resolution=32&rate=0\" alt=\"RA-Cam Not Found\" width=\"128\" height=\"96\" onerror='this.onerror=null; this.src=\"/Images/notfound.png\"'/></a>";
            racams+="<a href='javascript: $(\"#main_img\").attr(\"src\",\"http://172.221.140.255:8080/stream.mjpg\");getAI(\"172.221.140.255:8080\");' id=12 name=12 title=\"RA-Cam\"><img loading=\"lazy\" src=\"/Images/cam.png\" width=\"128\" height=\"96\" alt=\"RA-Cam Not Found\"  onload='this.src=\"http://172.221.140.255:8080/still.jpg\";' onerror='this.onerror=null; $(\"#12\").hide();'/></a>";
            racams+="<a href='javascript: $(\"#main_img\").attr(\"src\",\"http://172.221.140.255:233/stream.mjpg\");getAI(\"172.221.140.255:233\");' id=16 name=13 title=\"RA-Cam\"><img loading=\"lazy\" src=\"/Images/cam.png\" width=\"128\" height=\"96\" alt=\"RA-Cam Not Found\"  onload='this.src=\"http://172.221.140.255:9090/still.jpg\";' onerror='this.onerror=null; $(\"#13\").hide();'/></a>";
            racams+="<a href='javascript: $(\"#main_img\").attr(\"src\",\"http://172.221.140.255:8091/videostream.cgi?user=tester&pwd=tester&resolution=32&rate=0\");' id=14 name=14 title=\"RA-Cam\"><img loading=\"lazy\" src=\"http://172.221.140.255:8091/videostream.cgi?user=tester&pwd=tester&resolution=32&rate=0\" alt=\"RA-Cam Not Found\" width=\"128\" height=\"96\" onerror='this.onerror=null; this.src=\"/Images/notfound.png\"'/></a>";
            racams+="<a href='javascript: $(\"#main_img\").attr(\"src\",\"http://172.221.140.255:8092/stream.mjpg\");getAI(\"172.221.140.255:8092\");' id=15 name=13 title=\"RA-Cam\"><img loading=\"lazy\" src=\"http://172.221.140.255:8092/still.jpg\" width=\"128\" height=\"96\" alt=\"RA-Cam Not Found\" onerror='this.onerror=null; this.src=\"/Images/notfound.png\"'/></a>";
            racams+="<a href='javascript: $(\"#main_img\").attr(\"src\",\"http://172.221.140.255:9090/stream.mjpg\");getAI(\"172.221.140.255:9090\");' id=16 name=16 title=\"RA-Cam\"><img loading=\"lazy\" src=\"/Images/cam.png\" width=\"128\" height=\"96\" alt=\"RA-Cam Not Found\"  onload='this.src=\"http://172.221.140.255:9090/still.jpg\";' onerror='this.onerror=null; $(\"#16\").hide();'/></a>";
        }
        public async void CheckForLiveCam(string the_cam)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), the_cam))
                {
                    try {
                        var response = await httpClient.SendAsync(request);
                        checker=true;
                    }
                    catch (Exception e){
                        checker=false;
                    }                     
                }
            }
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
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://" + Request.Query["the_url"] +"/"+ Request.Query["the_type"]))
                    {
                        try {
                            var response = await httpClient.SendAsync(request);
                            var contents = await response.Content.ReadAsStringAsync();
                            the_msg=contents.ToString();
                        }
                        catch (Exception e){
                            the_msg="http://" + Request.Query["the_url"] +"/"+ Request.Query["the_type"];
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
                     using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://" + Request.Query["the_url"] +"/set"+ Request.Query["the_type"]))
                    
                    {
                        try {
                            var response = await httpClient.SendAsync(request);
                            var contents = await response.Content.ReadAsStringAsync();
                            the_msg=contents.ToString();
                        }
                        catch (Exception e){
                            the_msg="http://" + Request.Query["the_url"] +"/set"+ Request.Query["the_type"];
                        }                     
                    }
                }
            return new JsonResult(the_msg);
        }
    }
}
