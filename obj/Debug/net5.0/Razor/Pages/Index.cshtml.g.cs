#pragma checksum "/home/sjmill01/RA-Cam/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37bfa755fd04bae34adc8b4c8c5cb97ca627df63"
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
#line 1 "/home/sjmill01/RA-Cam/Pages/_ViewImports.cshtml"
using ra_cam;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37bfa755fd04bae34adc8b4c8c5cb97ca627df63", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a447c20b62a5fe53f6b51bf85867fca163634e4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-0 m-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/home/sjmill01/RA-Cam/Pages/Index.cshtml"
  
    ViewData["Title"] = "RA-Cam";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>  
.rotate180 {  
    -webkit-transform:rotate(180deg);  
    -moz-transform: rotate(180deg);  
    -ms-transform: rotate(180deg);  
    -o-transform: rotate(180deg);  
    transform: rotate(180deg);  
}  
</style>  
<div class=""container-fluid mt-5"">
    <div class=""row"">
        <div class=""col-lg-11"">
            <div class=""d-flex justify-content-center"">
              <img loading=""lazy"" id=""main_img"" class=""img-fluid"" src=""http://172.221.140.255:8555/stream.mjpg""");
            BeginWriteAttribute("style", " style=\"", 561, "\"", 597, 3);
            WriteAttributeValue("", 569, "max-width:", 569, 10, true);
#nullable restore
#line 19 "/home/sjmill01/RA-Cam/Pages/Index.cshtml"
WriteAttributeValue("", 579, Model.maxwidth, 579, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 596, ";", 596, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37bfa755fd04bae34adc8b4c8c5cb97ca627df634684", async() => {
                WriteLiteral(@"
            <div class=""d-flex justify-content-center"">              
                  <div class=""custom-control custom-switch mr-4"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""switch_bai"" name=""switch_bai"" onchange=""checkbox_function('bai');"">
                    <label class=""custom-control-label"" for=""switch_bai"">Baby AI</label>
                  </div>
                  <div class=""custom-control custom-switch mr-4"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""switch_hai"" name=""switch_hai"" onchange=""checkbox_function('hai');"">
                    <label class=""custom-control-label"" for=""switch_hai"">Human AI</label>
                  </div>
                  <div class=""custom-control custom-switch mr-4"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""switch_sai"" name=""switch_sai"" onchange=""checkbox_function('sai');"">
                    <label class=""custom-control-label"" for=""switch_sai"">Smiles AI");
                WriteLiteral(@"</label>
                  </div>
                  <div class=""custom-control custom-switch"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""switch_nai"" name=""switch_nai"" onchange=""checkbox_function('nai');"">
                    <label class=""custom-control-label"" for=""switch_nai"">Nature AI</label>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            ");
#nullable restore
#line 49 "/home/sjmill01/RA-Cam/Pages/Index.cshtml"
       Write(Html.Raw(Model.racams));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </br>
            <div data-toggle=""tooltip"" data-placement=""top"" title=""Click here to scan the RA-Cam network for newly connected RA-Cams.  It will only scan for devices on the same net as this web server."" class='text-center'>
                <div data-toggle=""modal"" data-target="".bd-example-modal-sm""><i class=""fa fa-refresh""></i></div>
            </div>
              <div class=""modal fade bd-example-modal-sm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mySmallModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-sm"">                  
                  <div class=""modal-content p-3"">
                  <strong>SCANNING</STRONG>
                    This will take a few minutes.  Scanning for RA-Cams is now being performed in the background.</br></br>
                    Refresh the page later to see if anything new has arrived.
                    <button type=""button"" class=""btn btn-secondary mt-3"" data-dismiss=""modal"">Close</button>
                  </d");
            WriteLiteral(@"iv>
                </div>
              </div>
             <div class=""modal fade bd-example2-modal-sm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mySmallModalLabel2"" aria-hidden=""true"">
                <div class=""modal-dialog modal-sm"">                  
                  <div class=""modal-content p-3"">
                  <strong>Working...</STRONG>
                    Connecting to the camera and getting its current AI modes.
                  </div>
                </div>
              </div>
              <div class=""modal fade bd-setAI-modal-sm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""mySmallModalLabel2"" aria-hidden=""true"">
                <div class=""modal-dialog modal-sm"">                  
                  <div class=""modal-content p-3"">
                  <strong>Working...</STRONG>
                    Connecting to the camera and setting the AI mode.
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
      function getAI(the_url){
        getAIType(""bai"", the_url);
        getAIType(""hai"", the_url);
        getAIType(""sai"", the_url);
        getAIType(""nai"", the_url);
      }
      function getAIType(the_type,the_url){         
        $('.bd-example2-modal-sm').modal('show');
        $.ajax({   
             type: ""POST"",
                  url: '?handler=Getter&the_type=' + the_type + '&the_url='+the_url, // Replace YOUR_CUSTOM_HANDLER with your handler.
                       contentType: ""application/json; charset=utf-8"",
                  beforeSend: function (xhr) {
                    xhr.setRequestHeader(""XSRF-TOKEN"",
                      $('input:hidden[name=""__RequestVerificationToken""]').val());
                  },
                  error: function (jqXhr, textStatus, errorMessage) {
                    alert(errorMessage + "".  "" + textStatus);
                    $('.bd-example2-modal-sm').modal('hide');
                  },             ");
                WriteLiteral(@"     
                  dataType: ""json""
              }).done(function (data) {
                  //alert(data);
                  if (data.includes(""On"")) {
                    $('#switch_'+ the_type).prop(""checked"", true);
                  } else {
                    $('#switch_'+ the_type).prop(""checked"", false);
                  }
                  $('.bd-example2-modal-sm').modal('hide');
              });        
      }
    </script>
    <script>
        function checkbox_function(the_type) {            
          var the_url=$(""#main_img"").attr(""src"").replaceAll('http://','');
          the_url=the_url.replaceAll('/stream.mjpg','');
          $('.bd-setAI-modal-sm').modal('show');
          $.ajax({   
             type: ""POST"",
                  url: '?handler=Setter&the_type='+ the_type + '&the_url='+the_url, // Replace YOUR_CUSTOM_HANDLER with your handler.
                  contentType: ""application/json; charset=utf-8"",

                  beforeSend: function (xhr) {
 ");
                WriteLiteral(@"                   xhr.setRequestHeader(""XSRF-TOKEN"",
                      $('input:hidden[name=""__RequestVerificationToken""]').val());
                  },
                  error: function (jqXhr, textStatus, errorMessage) {
                    alert(errorMessage + "".  "" + textStatus);
                  
                  },                  
                  dataType: ""json""
              }).done(function (data) {
                  //alert(data);
                  $('.bd-setAI-modal-sm').modal('hide');
              });
              
        }
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
