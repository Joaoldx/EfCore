#pragma checksum "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a884873a35bbc049386fb8aaf9680107e48401"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
#line 1 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a884873a35bbc049386fb8aaf9680107e48401", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DomainModel.Entity.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Categorias";

#line default
#line hidden
            BeginContext(97, 329, true);
            WriteLiteral(@"
<h2>Todas as Categorias</h2>

<a  href=""/Category/Save"" class=""btn"">Nova Categoria</a>

<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Nome</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 20 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\Category\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(491, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(546, 9, false);
#line 23 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\Category\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(555, 67, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 622, "\"", 652, 2);
            WriteAttributeValue("", 629, "/Category/Edit/", 629, 15, true);
#line 25 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\Category\Index.cshtml"
WriteAttributeValue("", 644, item.Id, 644, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(653, 117, true);
            WriteLiteral(" class=\"btn\">Editar</a>\r\n                        </td>\r\n                         <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 770, "\"", 802, 2);
            WriteAttributeValue("", 777, "/Category/Delete/", 777, 17, true);
#line 28 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\Category\Index.cshtml"
WriteAttributeValue("", 794, item.Id, 794, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(803, 84, true);
            WriteLiteral(" class=\"btn\">Deletar</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 31 "P:\NovosProjetos\CSharp\EfCore4\WebApp\Views\Category\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(906, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DomainModel.Entity.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
