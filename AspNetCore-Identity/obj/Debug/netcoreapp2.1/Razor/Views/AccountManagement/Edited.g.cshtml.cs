#pragma checksum "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "087250b63ffc40513b3350e1fe7caf3dd1e613d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManagement_Edited), @"mvc.1.0.view", @"/Views/AccountManagement/Edited.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountManagement/Edited.cshtml", typeof(AspNetCore.Views_AccountManagement_Edited))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087250b63ffc40513b3350e1fe7caf3dd1e613d9", @"/Views/AccountManagement/Edited.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6db62f6bfef32d7a96da3eb83599da05236171", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManagement_Edited : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Identity.Service.Application.Commands.User.EditUserCommand>
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
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
  
    ViewData["Title"] = "Account edited";

#line default
#line hidden
            BeginContext(119, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(139, 107, true);
                WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    layoutMenuItem.SetActiveMenuItem(\"accounts-menu-item\");\r\n</script>\r\n");
                EndContext();
            }
            );
            BeginContext(249, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("form_elements_scripts", async() => {
                BeginContext(285, 52, true);
                WriteLiteral("\r\n<!--form-elements.js - Page Specific JS codes-->\r\n");
                EndContext();
                BeginContext(337, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da8f8a8b065d47cc85b48e9e0fc6dc78", async() => {
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
                BeginContext(413, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(418, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Breadcrumbs", async() => {
                BeginContext(447, 104, true);
                WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col s10 m6 l6\">\r\n        <ol class=\"breadcrumbs\">\r\n            <li>");
                EndContext();
                BeginContext(551, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a155bc9302224692b81167916d0f9765", async() => {
                    BeginContext(573, 7, true);
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
                BeginContext(584, 23, true);
                WriteLiteral("</li>\r\n            <li>");
                EndContext();
                BeginContext(607, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95b16a7b2e44afa91c6482c76e6ed03", async() => {
                    BeginContext(629, 5, true);
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
                BeginContext(638, 86, true);
                WriteLiteral("</li>\r\n            <li class=\"active\">Edited</li>\r\n        </ol>\r\n    </div>\r\n</div>\r\n");
                EndContext();
            }
            );
            BeginContext(727, 421, true);
            WriteLiteral(@"<div class=""divider""></div>
<div class=""row"">
    <div class=""col s12"">
        <div class=""card-panel"">
            <h4 class=""header2"">Information Edited</h4>
            <div class=""row"">
                <div class=""col s12"" asp-action=""Edit"" method=""post"">
                    <div class=""row"">
                        <div class=""input-field col s12 l4"">
                            <span><b>Username</b> : ");
            EndContext();
            BeginContext(1149, 14, false);
#line 40 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                               Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 152, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Email</b> : ");
            EndContext();
            BeginContext(1316, 11, false);
#line 43 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1327, 159, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Phone number</b> : ");
            EndContext();
            BeginContext(1487, 17, false);
#line 46 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 227, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Block account</b> : ");
            EndContext();
            BeginContext(1732, 15, false);
#line 51 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                                    Write(Model.IsBlocked);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 162, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Email confirmed</b> : ");
            EndContext();
            BeginContext(1910, 20, false);
#line 54 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                                      Write(Model.EmailConfirmed);

#line default
#line hidden
            EndContext();
            BeginContext(1930, 169, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Phone number confirmed</b> : ");
            EndContext();
            BeginContext(2100, 26, false);
#line 57 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                                             Write(Model.PhoneNumberConfirmed);

#line default
#line hidden
            EndContext();
            BeginContext(2126, 246, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Enable two factor authentication</b> : ");
            EndContext();
            BeginContext(2373, 22, false);
#line 62 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                                                       Write(Model.TwoFactorEnabled);

#line default
#line hidden
            EndContext();
            BeginContext(2395, 162, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Enabled lockout</b> : ");
            EndContext();
            BeginContext(2558, 20, false);
#line 65 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                                      Write(Model.LockoutEnabled);

#line default
#line hidden
            EndContext();
            BeginContext(2578, 163, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Is administrator</b> : ");
            EndContext();
            BeginContext(2742, 13, false);
#line 68 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Edited.cshtml"
                                                       Write(Model.IsAdmin);

#line default
#line hidden
            EndContext();
            BeginContext(2755, 147, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Identity.Service.Application.Commands.User.EditUserCommand> Html { get; private set; }
    }
}
#pragma warning restore 1591
