#pragma checksum "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\Shared\Components\Genres\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7abd8ca42cdf2e00d81db41148f9075611f2d867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Genres_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Genres/Default.cshtml")]
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
#line 1 "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\_ViewImports.cshtml"
using MovieApp101.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\_ViewImports.cshtml"
using MovieApp101.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7abd8ca42cdf2e00d81db41148f9075611f2d867", @"/Views/Shared/Components/Genres/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817096512115ca49f36a3b08945a8ab7d20386c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Genres_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    <a href=\"/movies/list/\" class=\"list-group-item list-group-item-action\"><i class=\"bi bi-border-all\"></i>  Tüm Filmler </a>\r\n");
#nullable restore
#line 5 "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\Shared\Components\Genres\Default.cshtml"
     foreach (var genre in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 227, "\"", 261, 2);
            WriteAttributeValue("", 234, "/movies/list/", 234, 13, true);
#nullable restore
#line 7 "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("", 247, genre.GenreId, 247, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 262, "\"", 371, 3);
            WriteAttributeValue("", 270, "list-group-item", 270, 15, true);
            WriteAttributeValue(" ", 285, "list-group-item-action", 286, 23, true);
#nullable restore
#line 7 "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue(" ", 308, ViewBag.SelectedGenre==genre.GenreId.ToString()?"active":"", 309, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\Shared\Components\Genres\Default.cshtml"
                                                                                                                                                       Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 8 "C:\Users\Tolunay\Desktop\MovieApp102\MovieApp101\Views\Shared\Components\Genres\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Genre>> Html { get; private set; }
    }
}
#pragma warning restore 1591