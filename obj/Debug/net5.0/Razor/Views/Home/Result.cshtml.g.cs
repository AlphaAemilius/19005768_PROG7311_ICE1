#pragma checksum "C:\Users\powde\OneDrive\Workbench\Programming 3A\Projects\MemeSynthesis\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a80efeb9f0b01ee945ba4bc74f11174d052b8219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\powde\OneDrive\Workbench\Programming 3A\Projects\MemeSynthesis\Views\_ViewImports.cshtml"
using MemeSynthesis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\powde\OneDrive\Workbench\Programming 3A\Projects\MemeSynthesis\Views\Home\Result.cshtml"
using MemeSynthesis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a80efeb9f0b01ee945ba4bc74f11174d052b8219", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05036a2fa02a35cde73493f9d9ccf670f282857", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\powde\OneDrive\Workbench\Programming 3A\Projects\MemeSynthesis\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Memes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n <img");
            BeginWriteAttribute("src", " src=\"", 81, "\"", 99, 1);
#nullable restore
#line 8 "C:\Users\powde\OneDrive\Workbench\Programming 3A\Projects\MemeSynthesis\Views\Home\Result.cshtml"
WriteAttributeValue("", 87, ViewBag.url, 87, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:250px;height:250px\">\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591