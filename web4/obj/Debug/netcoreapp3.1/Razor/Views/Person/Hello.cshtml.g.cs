#pragma checksum "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ca2ab64df4f93a8e6ec714e269b34a6e0638929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Hello), @"mvc.1.0.view", @"/Views/Person/Hello.cshtml")]
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
#line 1 "C:\workspace\1670-gch0905\web4\Views\_ViewImports.cshtml"
using web4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\1670-gch0905\web4\Views\_ViewImports.cshtml"
using web4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ca2ab64df4f93a8e6ec714e269b34a6e0638929", @"/Views/Person/Hello.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96711db60cf0259b5d6df80dd7ebfe36bf465174", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Person_Hello : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web4.Models.Person>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
  
    int birthyear = Model.BirthYear;
    int currentyear = DateTime.Now.Year;
    int age = currentyear - birthyear;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Xin chào ");
#nullable restore
#line 9 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Năm nay bạn ");
#nullable restore
#line 10 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
           Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tuổi</h1>\r\n<h1>Giới tính: ");
#nullable restore
#line 11 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
          Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Học vấn: ");
#nullable restore
#line 12 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
        Write(Model.Education);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 13 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
 if (@Model.IsMarried == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Bạn đã kết hôn</h1>\n");
#nullable restore
#line 16 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Bạn vẫn độc thân</h1>\r\n");
#nullable restore
#line 18 "C:\workspace\1670-gch0905\web4\Views\Person\Hello.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web4.Models.Person> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
