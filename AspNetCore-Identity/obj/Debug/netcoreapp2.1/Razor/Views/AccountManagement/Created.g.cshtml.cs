#pragma checksum "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138f68ffdfb86b59b045a34530bd2c309798fc14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManagement_Created), @"mvc.1.0.view", @"/Views/AccountManagement/Created.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountManagement/Created.cshtml", typeof(AspNetCore.Views_AccountManagement_Created))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138f68ffdfb86b59b045a34530bd2c309798fc14", @"/Views/AccountManagement/Created.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6db62f6bfef32d7a96da3eb83599da05236171", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManagement_Created : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Identity.Service.Application.Commands.User.CreateUserCommand>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts/form-elements.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
  
    ViewData["Title"] = "Created Account";

#line default
#line hidden
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(142, 119, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        layoutMenuItem.SetActiveMenuItem(\"accounts-menu-item\");\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(264, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("form_elements_scripts", async() => {
                BeginContext(300, 60, true);
                WriteLiteral("\r\n    <!--form-elements.js - Page Specific JS codes-->\r\n    ");
                EndContext();
                BeginContext(360, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03945f51a6564e6282ffa8157b51fa92", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(436, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(441, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Breadcrumbs", async() => {
                BeginContext(470, 120, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col s10 m6 l6\">\r\n            <ol class=\"breadcrumbs\">\r\n                <li>");
                EndContext();
                BeginContext(590, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f14da2f354424036bc76d1e2af78d1a7", async() => {
                    BeginContext(612, 7, true);
                    WriteLiteral("Account");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(623, 27, true);
                WriteLiteral("</li>\r\n                <li>");
                EndContext();
                BeginContext(650, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59f850c0a9c7429993cc8a0bdde19a2d", async() => {
                    BeginContext(672, 5, true);
                    WriteLiteral("Users");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(681, 103, true);
                WriteLiteral("</li>\r\n                <li class=\"active\">Created</li>\r\n            </ol>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(787, 422, true);
            WriteLiteral(@"<div class=""divider""></div>
<div class=""row"">
    <div class=""col s12"">
        <div class=""card-panel"">
            <h4 class=""header2"">Information Created</h4>
            <div class=""row"">
                <div class=""col s12"" asp-action=""Edit"" method=""post"">
                    <div class=""row"">
                        <div class=""input-field col s12 l4"">
                            <span><b>Username</b> : ");
            EndContext();
            BeginContext(1210, 14, false);
#line 40 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                               Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 152, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Email</b> : ");
            EndContext();
            BeginContext(1377, 11, false);
#line 43 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 159, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Phone number</b> : ");
            EndContext();
            BeginContext(1548, 17, false);
#line 46 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 229, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Account blocked</b> : ");
            EndContext();
            BeginContext(1796, 30, false);
#line 51 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                                       Write(Model.IsBlocked ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(1827, 162, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Email confirmed</b> : ");
            EndContext();
            BeginContext(1991, 35, false);
#line 54 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                                       Write(Model.EmailConfirmed ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(2027, 169, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Phone number confirmed</b> : ");
            EndContext();
            BeginContext(2198, 41, false);
#line 57 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                                              Write(Model.PhoneNumberConfirmed ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(2240, 247, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Two factor authentication enabled</b> : ");
            EndContext();
            BeginContext(2489, 37, false);
#line 62 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                                                         Write(Model.TwoFactorEnabled ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(2527, 162, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Lockout enabled</b> : ");
            EndContext();
            BeginContext(2691, 35, false);
#line 65 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                                       Write(Model.LockoutEnabled ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(2727, 163, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Is administrator</b> : ");
            EndContext();
            BeginContext(2892, 28, false);
#line 68 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Created.cshtml"
                                                        Write(Model.IsAdmin ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(2921, 147, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Identity.Service.Application.Commands.User.CreateUserCommand> Html { get; private set; }
    }
}
#pragma warning restore 1591
