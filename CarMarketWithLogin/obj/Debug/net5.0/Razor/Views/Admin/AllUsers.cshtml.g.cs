#pragma checksum "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6440d65765138b9bcabbb7a250740c4bcdea2521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AllUsers), @"mvc.1.0.view", @"/Views/Admin/AllUsers.cshtml")]
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
#line 1 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/_ViewImports.cshtml"
using CarMarketWithLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/_ViewImports.cshtml"
using CarMarketWithLogin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6440d65765138b9bcabbb7a250740c4bcdea2521", @"/Views/Admin/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ed47727414f5172b0049c454e265e6fcf00736", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<p><h1>Все пользоваели:</h1></p>\n    \n");
#nullable restore
#line 7 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml"
 foreach (var item in Model)
 { 

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"py-2 border-bottom border-top\">\n         <h3>Имя пользователя: ");
#nullable restore
#line 10 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml"
                          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n         <h4>Количество комментариев: ");
#nullable restore
#line 11 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml"
                                 Write(item.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n         <p><a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 368, "\"", 403, 3);
            WriteAttributeValue("", 375, "/Admin/DeleteUser/{", 375, 19, true);
#nullable restore
#line 12 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml"
WriteAttributeValue("", 394, item.Id, 394, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 402, "}", 402, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Удалить</a></p> \n         <p><a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 460, "\"", 507, 3);
            WriteAttributeValue("", 467, "/Admin/DeleteUserWithComments/{", 467, 31, true);
#nullable restore
#line 13 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml"
WriteAttributeValue("", 498, item.Id, 498, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 506, "}", 506, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Удалить с комментариями</a></p>\n     </div>       \n");
#nullable restore
#line 15 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Admin/AllUsers.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
