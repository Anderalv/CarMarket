#pragma checksum "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ca762f41cf56762c0eab49f37934ca0608fc7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_SortYear), @"mvc.1.0.view", @"/Views/Cars/SortYear.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ca762f41cf56762c0eab49f37934ca0608fc7c", @"/Views/Cars/SortYear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ed47727414f5172b0049c454e265e6fcf00736", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_SortYear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarMarketWithLogin.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Все автомобили:</h1>\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ca762f41cf56762c0eab49f37934ca0608fc7c3743", async() => {
                WriteLiteral("\n    <select name=\"mark-navigator\" onchange=\"top.location.href = this.options[this.selectedIndex].value;\">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ca762f41cf56762c0eab49f37934ca0608fc7c4116", async() => {
                    WriteLiteral("Все марки");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 9 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
         foreach (var item in Model.GroupBy(x => x.Brand))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ca762f41cf56762c0eab49f37934ca0608fc7c5939", async() => {
#nullable restore
#line 11 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
                                                        Write(item.Key);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("/ChoseCar/ChosenMark/{");
#nullable restore
#line 11 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
                                     WriteLiteral(item.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("}");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 12 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ca762f41cf56762c0eab49f37934ca0608fc7c9133", async() => {
                WriteLiteral("\n    <select name=\"mark-navigator\" onchange=\"top.location.href = this.options[this.selectedIndex].value;\">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ca762f41cf56762c0eab49f37934ca0608fc7c9506", async() => {
                    WriteLiteral("По году");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                WriteLiteral("/Cars/SortYear/{");
#nullable restore
#line 18 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
                                    WriteLiteral(ViewBag.EngineType);

#line default
#line hidden
#nullable disable
                WriteLiteral("}");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ca762f41cf56762c0eab49f37934ca0608fc7c11623", async() => {
                    WriteLiteral("по цене");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("/Cars/SortPrice/{");
#nullable restore
#line 19 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
                            WriteLiteral(ViewBag.EngineType);

#line default
#line hidden
#nullable disable
                WriteLiteral("}");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50ca762f41cf56762c0eab49f37934ca0608fc7c13414", async() => {
                    WriteLiteral("по умолчанию");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("/Cars/List/{");
#nullable restore
#line 20 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
                       WriteLiteral(ViewBag.EngineType);

#line default
#line hidden
#nullable disable
                WriteLiteral("}");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </select>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n<div class=\"row mt-5 mb-2\">\n");
#nullable restore
#line 26 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
      
        foreach (var car in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\n                <a class=\"btn-block\"");
            BeginWriteAttribute("href", " href=\"", 960, "\"", 998, 3);
            WriteAttributeValue("", 967, "/CarInfo/InfoAbout/{", 967, 20, true);
#nullable restore
#line 30 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
WriteAttributeValue("", 987, car.Model, 987, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 997, "}", 997, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"ramka\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1069, "\"", 1147, 1);
#nullable restore
#line 32 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
WriteAttributeValue("", 1075, car.Imgs.OrderBy(x => x.Url).FirstOrDefault(x => x.CarId == car.Id).Url, 1075, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\n                             alt=\"", 1148, "\"", 1193, 1);
#nullable restore
#line 33 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
WriteAttributeValue("", 1183, car.Brand, 1183, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\"/>\n                    </div>\n                </a>\n                <h2>");
#nullable restore
#line 36 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
               Write(car.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                <p>");
#nullable restore
#line 37 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
              Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p>Рекомендованная цена: ");
#nullable restore
#line 38 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
                                    Write(car.RecommendPrice.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\n                <p><a class=\"btn-block\"");
            BeginWriteAttribute("href", " href=\"", 1456, "\"", 1494, 3);
            WriteAttributeValue("", 1463, "/CarInfo/InfoAbout/{", 1463, 20, true);
#nullable restore
#line 39 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
WriteAttributeValue("", 1483, car.Model, 1483, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1493, "}", 1493, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Подробнее</a> <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1536, "\"", 1558, 3);
            WriteAttributeValue("", 1543, "/test/{", 1543, 7, true);
#nullable restore
#line 39 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
WriteAttributeValue("", 1550, car.Id, 1550, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1557, "}", 1557, 1, true);
            EndWriteAttribute();
            WriteLiteral(">В закладки</a></p>\n            </div>\n");
#nullable restore
#line 41 "/Users/andreylastovski/Desktop/reProject/CarMarketWithLogin/CarMarketWithLogin/Views/Cars/SortYear.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarMarketWithLogin.Models.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
