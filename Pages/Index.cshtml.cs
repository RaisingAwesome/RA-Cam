using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace ra_cam.Pages
{
    public class IndexModel : PageModel
    {   public string racams="";

        private readonly ILogger<IndexModel> _logger;
        
        private IWebHostEnvironment _environment;

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public void OnGet()
        {   
            GetPriorKnownCams();
        }

        private void GetPriorKnownCams()
        {
            string line;  
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path.Combine(_environment.ContentRootPath, "", "racam_list.txt"));  
            
            while((line = file.ReadLine()) != null)  
            {  
                if (line.Contains("racam")) {
                    racams+=MakeRACamThumbnail(line.Replace("racam",""));
                } else if(line.Contains("ipcam") {
                    racams+=MakeIPCamThumbnail(line.Replace("ipcam",""));
                }                
            }
            file.Close();
        }

        private string MakeRACamThumbnail(string the_URL)
        {
            string the_ID=the_URL.Replace(".","").Replace(":","").Replace("/","");
            string the_str="<a href='javascript: $(\"#main_img\").attr(\"src\",\"http://" + the_URL + "/stream.mjpg\");getAI(\""+ the_URL + "\");' id=" + the_ID + " title=\"RA-Cam: " + the_URL + "\"><img loading=\"lazy\" src=\"/Images/cam.png\" width=\"128\" height=\"96\" alt=\"RA-Cam Not Found\" onload='this.src=\"http://" + the_URL + "/still.jpg\";' onerror='this.onerror=null; $(\"#" + the_ID + "\").hide();'/></a>\n";
            return the_str;
        }
        private string MakeIPCamThumbnail(string the_URL)
        {
            string the_ID=the_URL.Replace(".","").Replace(":","").Replace("/","");
            string the_str="<a href='javascript:  $(\"#main_img\").attr(\"src\",\"http://" + the_URL + "/videostream.cgi?user=testor&pwd=testor&resolution=32&rate=0\");' id=" + the_ID + " title=\"RA-Cam\"><img loading=\"lazy\" src=\"http://" + the_URL + "/videostream.cgi?user=testor&pwd=testor&resolution=32&rate=0\" alt=\"RA-Cam Not Found\" width=\"128\" height=\"96\" onerror='this.onerror=null; $(\"#" + the_ID + "\").hide();'/></a>";

            return the_str;
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
                            the_msg=e.ToString() + " - http://" + Request.Query["the_url"] +"/"+ Request.Query["the_type"];
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
                            the_msg=e.ToString() + " - http://" + Request.Query["the_url"] +"/set"+ Request.Query["the_type"];
                        }                     
                    }
                }
            return new JsonResult(the_msg);
        }
    }
}
