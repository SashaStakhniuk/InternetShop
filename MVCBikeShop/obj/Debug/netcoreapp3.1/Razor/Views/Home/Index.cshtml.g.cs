#pragma checksum "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23941e831b837c85ccfd7119e902845fa0cee07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23941e831b837c85ccfd7119e902845fa0cee07", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCBikeShop.Models.Bike>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div id=\"message\">\r\n    <h1 class=\"d-flex justify-content-center\">");
#nullable restore
#line 6 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                                         Write(ViewBag.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
</div>

<script>
    setTimeout(function () {
        document.getElementById('message').style.display = 'none';
    }, 5000);
</script>

<div class=""container"">
    <div class=""row row-cols-xl-4 row-cols-md-3 row-cols-sm-2 row-cols-1 m-5"">
");
#nullable restore
#line 17 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
         foreach (var bike in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col mb-3 wow fadeInDown"" data-wow-duration=""1000ms"" data-wow-delay=""0.3s"">
                <div style=""display:flex; flex-direction:column; text-align:center; border:1px solid lightgray;border-radius:5px;"">
                    <div>");
#nullable restore
#line 21 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                    Write(bike.BikeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 746, "\"", 767, 1);
#nullable restore
#line 22 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 752, bike.PhotoPath, 752, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div><h6>");
#nullable restore
#line 23 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                        Write(bike.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" UAH</h6></div>\r\n                    <div class=\"d-flex flex-row justify-content-around p-2\">\r\n");
#nullable restore
#line 25 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                         using (Html.BeginForm("AddToCart", "Cart"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" name=\"BikeId\"");
            BeginWriteAttribute("value", " value=\"", 1067, "\"", 1087, 1);
#nullable restore
#line 27 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1075, bike.BikeId, 1075, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 28 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                       Write(Html.Hidden("returnUrl", Context.Request.Path.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button type=""submit"" class=""btn btn-outline-secondary"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-cart4"" viewBox=""0 0 16 16"">
                                    <path d=""M0 2.5A.5.5 0 0 1 .5 2H2a.5.5 0 0 1 .485.379L2.89 4H14.5a.5.5 0 0 1 .485.621l-1.5 6A.5.5 0 0 1 13 11H4a.5.5 0 0 1-.485-.379L1.61 3H.5a.5.5 0 0 1-.5-.5zM3.14 5l.5 2H5V5H3.14zM6 5v2h2V5H6zm3 0v2h2V5H9zm3 0v2h1.36l.5-2H12zm1.11 3H12v2h.61l.5-2zM11 8H9v2h2V8zM8 8H6v2h2V8zM5 8H3.89l.5 2H5V8zm0 5a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0zm9-1a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0z"" />
                                </svg>
                                Add To Cart
                            </button>
");
#nullable restore
#line 36 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23941e831b837c85ccfd7119e902845fa0cee077585", async() => {
                WriteLiteral("Buy");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2180, "~/Home/Buy/", 2180, 11, true);
#nullable restore
#line 37 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2191, bike.BikeId, 2191, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div style=\"text-align:center;\">Page: ");
#nullable restore
#line 44 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                                 Write(ViewBag.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<nav>\r\n    <ul class=\"pagination justify-content-center\">\r\n        <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23941e831b837c85ccfd7119e902845fa0cee079919", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2527, "~/Home/index/", 2527, 13, true);
#nullable restore
#line 48 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2540, ViewBag.CurrentPage-1, 2540, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 49 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
         for (int i = 0; i < ViewBag.PagesCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23941e831b837c85ccfd7119e902845fa0cee0711854", async() => {
#nullable restore
#line 51 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
                                                                              Write(i + 1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2712, "~/Home/index/", 2712, 13, true);
#nullable restore
#line 51 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2725, i+1, 2725, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 52 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23941e831b837c85ccfd7119e902845fa0cee0713928", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2820, "~/Home/index/", 2820, 13, true);
#nullable restore
#line 53 "E:\Sasha\InternetShop-master\InternetShop-master\MVCBikeShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2833, ViewBag.CurrentPage+1, 2833, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
    </ul>
</nav>
<div style=""height:10px;""></div>

<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""social-icons wow fadeInDown"" data-wow-duration=""1000ms"" data-wow-delay=""0.3s"">
                    <ul>
                        <li class=""facebook""><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li class=""twitter""><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li class=""google-plus""><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                        <li class=""instagram""><a href=""#""><i class=""fa fa-instagram""></i></a></li>
                        <li class=""youtube""><a href=""https://www.youtube.com/?hl=uk&gl=UA""><i class=""fa fa-youtube""></i></a></li>
                        <li class=""dribbble""><a href=""#""><i class=""fa fa-dribbble""></i></a></li>
                    </ul>
                </div>
                <div class=""site-info wow fadeI");
            WriteLiteral("nUp\" data-wow-duration=\"1000ms\" data-wow-delay=\"0.3s\">\r\n                    <p>All copyrights reserved&copy; 2021 - Designed & Developed by Olexandr Stakhniuk <a rel=\"nofollow\"");
            BeginWriteAttribute("href", " href=\"", 4067, "\"", 4074, 0);
            EndWriteAttribute();
            WriteLiteral("></a></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCBikeShop.Models.Bike>> Html { get; private set; }
    }
}
#pragma warning restore 1591