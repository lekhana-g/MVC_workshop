#pragma checksum "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee347d873636f27ce8bc2749e0d104f97a10f5d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminR_getallRoutes), @"mvc.1.0.view", @"/Views/AdminR/getallRoutes.cshtml")]
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
#line 1 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\_ViewImports.cshtml"
using flightreservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\_ViewImports.cshtml"
using flightreservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee347d873636f27ce8bc2749e0d104f97a10f5d0", @"/Views/AdminR/getallRoutes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750545fca4c2829c8a723bb05b4c2a0134ee91f3", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminR_getallRoutes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<flightreservation.Models.RouteDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
  
    Layout="AdminLayout";
    ViewData["Title"] = "getallRoutes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Route Details</h1>\r\n\r\n<hr/>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.Routedesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Routedesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");
#nullable restore
#line 39 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
          Write(Html.ActionLink("Edit", "Edit", new { id=item.Routeid }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                ");
#nullable restore
#line 40 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Routeid }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\l.g.lmb5\Desktop\new\flightreservation\Views\AdminR\getallRoutes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<flightreservation.Models.RouteDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
