#pragma checksum "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b393d138d2f7d4ca725460e29c2086c934938f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b393d138d2f7d4ca725460e29c2086c934938f85", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 121, true);
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1>Welcome to CRUDelicious LOL</h1>\r\n    <h1>Check out some recent dishes:</h1><br>\r\n");
            EndContext();
#line 11 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/Home/Index.cshtml"
     foreach (Dish item in @Model)
    {
       

#line default
#line hidden
            BeginContext(239, 13, true);
            WriteLiteral("       <p> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 252, "\"", 272, 2);
            WriteAttributeValue("", 259, "/", 259, 1, true);
#line 14 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 260, item.DishId, 260, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(273, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(276, 14, false);
#line 14 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/Home/Index.cshtml"
                               Write(item.Dish_Name);

#line default
#line hidden
            EndContext();
            BeginContext(290, 9, true);
            WriteLiteral(" </a> by ");
            EndContext();
            BeginContext(300, 14, false);
#line 14 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/Home/Index.cshtml"
                                                       Write(item.Chef_Name);

#line default
#line hidden
            EndContext();
            BeginContext(314, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 15 "/Users/cnz/Desktop/C#/ASP_MVCII/CRUDelicious/Views/Home/Index.cshtml"
        
    }

#line default
#line hidden
            BeginContext(338, 45, true);
            WriteLiteral("    <a href=\"/new\">Add a Dish</a>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
