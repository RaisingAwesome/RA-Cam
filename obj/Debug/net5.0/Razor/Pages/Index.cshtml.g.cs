#pragma checksum "/home/pi/RA-Cam/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6d2659c1e2830c39aef880e2724f700ad71b46b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ra_cam.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ra_cam.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/pi/RA-Cam/Pages/_ViewImports.cshtml"
using ra_cam;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d2659c1e2830c39aef880e2724f700ad71b46b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a447c20b62a5fe53f6b51bf85867fca163634e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/pi/RA-Cam/Pages/Index.cshtml"
  
    ViewData["Title"] = "RA-Cam";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-11"">
            <div class=""d-flex justify-content-center"">
              <img loading=""lazy"" id=""main_img"" class=""img-fluid"" src=""http://172.221.140.255:8555/stream.mjpg"" style=""max-height:640px;"">
            </div>
            <div class=""toast"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"">
                <div class=""toast-header text-center"">
                    <strong class=""mr-auto alert alert-success text-center"">AI Mode Switched!</strong>
                </div>
            </div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d2659c1e2830c39aef880e2724f700ad71b46b3934", async() => {
                WriteLiteral(@"
            <div class=""d-flex text-center"">              
                  <div class=""custom-control custom-switch mr-4"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customSwitch1"" onchange=""checkbox_function('bai');"">
                    <label class=""custom-control-label"" for=""customSwitch1"">Baby AI</label>
                  </div>
                  <div class=""custom-control custom-switch mr-4"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customSwitch2"" name=""customSwitch2"" onchange=""checkbox_function('hai');"">
                    <label class=""custom-control-label"" for=""customSwitch2"">Human AI</label>
                  </div>
                  <div class=""custom-control custom-switch mr-4"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customSwitch3"" onchange=""checkbox_function('sai');"">
                    <label class=""custom-control-label"" for=""customSwitch3"">Smiles AI</label>
                ");
                WriteLiteral(@"  </div>
                  <div class=""custom-control custom-switch"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""customSwitch4"" onchange=""checkbox_function('nai');"">
                    <label class=""custom-control-label"" for=""customSwitch4"">Nature AI</label>
                  </div>
              
            </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""d-flex justify-content-center"">
              <a id=7 name=7 data-toggle=""tooltip"" title=""The selected camera will apply the AI modes you have selected above.  Click here to view recent photos snapped by the selected AI."" data-placement=""top"" class=""btn btn-info m-2"" href=""Snapshots"">View AI Snapshots</a>
            </div>
        </div>
        <div class=""col-lg-1"">
          <div class=""text-center"">
            <small><b>RA-Cams</b></small></br>            
            <a href=""javascript:gotclicked(10);"" id=10 name=10 title=""RA-Cam""><img loading=""lazy"" src=""http://172.221.140.255:8555/still.jpg"" width=""128"" height=""96""/></a>
            <a href=""javascript:gotclicked(11);"" id=11 name=11 title=""RA-Cam""><img loading=""lazy"" src=""http://172.221.140.255:54/videostream.cgi?user=testor&pwd=testor&resolution=32&rate=0"" width=""128"" height=""96""/></a>
            <a href=""javascript:gotclicked(12);"" id=12 name=12 title=""RA-Cam""><img loading=""lazy"" src=""http://172.221.140.255:8080");
            WriteLiteral(@"/still.jpg"" width=""128"" height=""96""/></a>
            <a href=""javascript:gotclicked(13);"" id=13 name=13 title=""RA-Cam""><img loading=""lazy"" src=""http://172.221.140.255:233/still.jpg"" width=""128"" height=""96""/></a>
            <a href=""javascript:gotclicked(14);"" id=14 name=14 title=""RA-Cam""><img loading=""lazy"" src=""http://172.221.140.255:8091/videostream.cgi?user=tester&pwd=tester&resolution=32&rate=0"" width=""128"" height=""96""/></a>
            <a href=""javascript:gotclicked(15);"" id=15 name=13 title=""RA-Cam""><img loading=""lazy"" src=""http://172.221.140.255:8092/still.jpg"" width=""128"" height=""96""/></a>
            <a href=""javascript:gotclicked(16);"" id=16 name=13 title=""RA-Cam""><img loading=""lazy"" src=""http://172.221.140.255:9090/still.jpg"" width=""128"" height=""96""/></a>
            </br>
            <div data-toggle=""tooltip"" data-placement=""top"" title=""Click here to scan the RA-Cam network for newly connected RA-Cams.  It will only scan for devices on the same net as this web server."" class='text-center'");
            WriteLiteral(@">
                <div data-toggle=""modal"" data-target="".bd-example-modal-sm""><i class=""fa fa-refresh""></i></div>
            </div>
              <div class=""modal fade bd-example-modal-sm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mySmallModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-sm"">                  
                  <div class=""modal-content p-3"">
                  <strong>SCANNING</STRONG>
                    This will take a few minutes.  Scanning for RA-Cams is now being performed in the background.</br></br>
                    Refresh the page later to see if anything new has arrived.
                    <button type=""button"" class=""btn btn-secondary mt-3"" data-dismiss=""modal"">Close</button>
                  </div>
                </div>
              </div>
          </div>
        </div>
        
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
  <script type=""text/javascript"">
      function getAI(the_type,the_site){
        $.ajax({   
             type: ""POST"",
                  url: '?handler=Getter&the_type=' + the_type + '&value='+the_site, // Replace YOUR_CUSTOM_HANDLER with your handler.
                  contentType: ""application/json; charset=utf-8"",

                  beforeSend: function (xhr) {
                    xhr.setRequestHeader(""XSRF-TOKEN"",
                      $('input:hidden[name=""__RequestVerificationToken""]').val());
                  },
                  error: function (jqXhr, textStatus, errorMessage) {
                    alert(errorMessage + "".  "" + textStatus);
                  },                  
                  dataType: ""json""
              }).done(function (data) {
                  //alert(data);
                  if (data.includes(""On"")) {
                    $('#customSwitch2').prop(""checked"", true);
                  } else {
                    $('#customSwitch2').prop(""checked"", fal");
                WriteLiteral(@"se);
                  }
              })
      }
      function gotclicked(cam) 
      {              
        if (cam==10) {
          $(""#main_img"").attr(""src"",""http://172.221.140.255:8555/stream.mjpg"");

        }
        if (cam==11) {
          $(""#main_img"").attr(""src"",""http://172.221.140.255:54/videostream.cgi?user=testor&pwd=testor&resolution=32&rate=0"");
        }
        else if (cam==12) {
          $(""#main_img"").attr(""src"",""http://172.221.140.255:8080/stream.mjpg"");
        }
        else if (cam==13) {
          $(""#main_img"").attr(""src"",""http://172.221.140.255:233/stream.mjpg"");
        }
        else if (cam==14) {
          $(""#main_img"").attr(""src"",""http://172.221.140.255:8091/videostream.cgi?user=tester&pwd=tester&resolution=32&rate=0"");
        }
        else if (cam==15) {
          $(""#main_img"").attr(""src"",""http://172.221.140.255:8092/stream.mjpg"");
        }
        else if (cam==16) {
          $(""#main_img"").attr(""src"",""http://172.221.140.255:9090/stream.mj");
                WriteLiteral(@"pg"");
          getAI(""hai"",""172.221.140.255:9090"");
        }
        $(""[data-toggle='tooltip']"").tooltip('hide');
      }
    </script>
    <script>
      function toastit(){
        $('toast').toast({
          delay: 2000
        })

        $('.toast').toast('show');
      };
    </script>
    <script>
        function checkbox_function(the_type) {            
          var the_value=$(""#main_img"").attr(""src"").replaceAll('http://','');
          the_value=the_value.replaceAll('/stream.mjpg','');
          $.ajax({   
             type: ""POST"",
                  url: '?handler=Setter&the_type='+ the_type + '&value='+the_value, // Replace YOUR_CUSTOM_HANDLER with your handler.
                  contentType: ""application/json; charset=utf-8"",

                  beforeSend: function (xhr) {
                    xhr.setRequestHeader(""XSRF-TOKEN"",
                      $('input:hidden[name=""__RequestVerificationToken""]').val());
                  },
                  error: function");
                WriteLiteral(@" (jqXhr, textStatus, errorMessage) {
                    alert(errorMessage + "".  "" + textStatus);
                  },                  
                  dataType: ""json""
              }).done(function (data) {
                  //alert(data);
                  $('.toast').toast('show');
              })
        };
        $(document).ready(function(){      
          
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
