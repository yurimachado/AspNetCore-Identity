#pragma checksum "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Account\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b214ed216076c0eaecf1075bf560fc352beee9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Confirmation), @"mvc.1.0.view", @"/Views/Account/Confirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Confirmation.cshtml", typeof(AspNetCore.Views_Account_Confirmation))]
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
#line 2 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\_ViewImports.cshtml"
using Identity.Service.Models;

#line default
#line hidden
#line 3 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ModelBinding;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b214ed216076c0eaecf1075bf560fc352beee9", @"/Views/Account/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6db62f6bfef32d7a96da3eb83599da05236171", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/layouts/page-center.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("styles", async() => {
                BeginContext(17, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(23, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c158f29021442a7b0baa1337f34a167", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(99, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(124, 170, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(\'#SuccessAlert\').addClass(\'animated fadeInUp\');\r\n        $(\'#ErrorAlert\').addClass(\'animated fadeInUp\');\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(297, 301, true);
            WriteLiteral(@"
<div id=""login-page"" class=""row"">
    <div class=""col s12 z-depth-4 card-panel"">
        <div class=""login-form"">
            <div class=""row"">
                <div class=""input-field col s12 center"">
                    <h4>Email Confirmation</h4>
                </div>
            </div>
");
            EndContext();
#line 20 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Account\Confirmation.cshtml"
             if (!ViewData.ModelState.IsValid)
            {

#line default
#line hidden
            BeginContext(661, 306, true);
            WriteLiteral(@"                <div class=""row"" id=""ErrorAlert"">
                    <div class=""input-field col s12 center"">
                        <div id=""card-alert"" class=""card red lighten-5"">
                            <div class=""card-content red-text"">
                                <div class=""center"">
");
            EndContext();
#line 27 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Account\Confirmation.cshtml"
                                     foreach (var error in ViewData.ModelState.Root.Errors)
                                    {

#line default
#line hidden
            BeginContext(1099, 43, true);
            WriteLiteral("                                        <p>");
            EndContext();
            BeginContext(1143, 18, false);
#line 29 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Account\Confirmation.cshtml"
                                      Write(error.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 30 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Account\Confirmation.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1206, 160, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 36 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Account\Confirmation.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1414, 463, true);
            WriteLiteral(@"                <div class=""row"" id=""SuccessAlert"">
                    <div class=""input-field col s12 center"">
                        <div id=""card-alert"" class=""card cyan lighten-5"">
                            <div class=""card-content"">
                                <p class=""center"">Congratulations!! You are now registered.</p>
                            </div>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 48 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Account\Confirmation.cshtml"
            }

#line default
#line hidden
            BeginContext(1892, 154, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"input-field col s12\">\r\n                    <p class=\"margin sign-up\">\r\n                        ");
            EndContext();
            BeginContext(2046, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60a969e0ed57488f8e428e778c87237b", async() => {
                BeginContext(2068, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2077, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2103, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06e9b65db69e4a2f8a8700d3d073630b", async() => {
                BeginContext(2142, 8, true);
                WriteLiteral("Register");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2154, 110, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
