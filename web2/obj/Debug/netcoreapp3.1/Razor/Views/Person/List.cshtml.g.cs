#pragma checksum "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f94b2cc053981bb6244ab601472848d912fb0d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_List), @"mvc.1.0.view", @"/Views/Person/List.cshtml")]
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
#line 1 "C:\workspace\1670-gch0905\web2\Views\_ViewImports.cshtml"
using web2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\1670-gch0905\web2\Views\_ViewImports.cshtml"
using web2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f94b2cc053981bb6244ab601472848d912fb0d8", @"/Views/Person/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0d3e607999d9f0dbeff71de83083377b731857", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Person_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
  
    ViewData["Title"] = "Person List";
    var title = "Person Detail";
    var total_person = Model.Count;
    var total_age = 0;
    //Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container col-md-8 text-center\">\r\n    <h1 class=\"text text-primary\">");
#nullable restore
#line 12 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
                             Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <table class=""table table-bordered"">
        <tr>
            <th>Person ID</th>
            <th>Person Name</th>
            <th>Person Age</th>
            <th>Person Year of Birth</th>
            <th>Person Address</th>
        </tr>
");
#nullable restore
#line 21 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
         foreach (var person in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
           Write(person.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
           Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 26 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
           Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 27 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
              
              var yob = DateTime.Now.Year - person.Age;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 30 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
           Write(yob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
           Write(person.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 32 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
                  
                    total_age += person.Age;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 36 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
              
                var average_age = total_age / total_person;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <h5>Total Person: ");
#nullable restore
#line 41 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
                 Write(total_person);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n    <h5>Average age: ");
#nullable restore
#line 42 "C:\workspace\1670-gch0905\web2\Views\Person\List.cshtml"
                Write(average_age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
