#pragma checksum "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Profile\Edited.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9996c1c953e445bf34d61bc1cbd9dd22f01ed15f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Edited), @"mvc.1.0.view", @"/Views/Profile/Edited.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Edited.cshtml", typeof(AspNetCore.Views_Profile_Edited))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9996c1c953e445bf34d61bc1cbd9dd22f01ed15f", @"/Views/Profile/Edited.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6db62f6bfef32d7a96da3eb83599da05236171", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Edited : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Identity.Service.Application.Commands.User.EditUserProfileCommand>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts/form-elements.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Profile\Edited.cshtml"
  
    ViewData["Title"] = "Profile Updated";

#line default
#line hidden
            BeginContext(127, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("form_elements_scripts", async() => {
                BeginContext(161, 60, true);
                WriteLiteral("\r\n    <!--form-elements.js - Page Specific JS codes-->\r\n    ");
                EndContext();
                BeginContext(221, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3acad07438e4f6da2148ec7077d441b", async() => {
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
                BeginContext(297, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Breadcrumbs", async() => {
                BeginContext(331, 120, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col s10 m6 l6\">\r\n            <ol class=\"breadcrumbs\">\r\n                <li>");
                EndContext();
                BeginContext(451, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dddb31c21db402fba51d368efeb5037", async() => {
                    BeginContext(472, 7, true);
                    WriteLiteral("Profile");
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
                BeginContext(483, 102, true);
                WriteLiteral("</li>\r\n                <li class=\"active\">Edited</li>\r\n            </ol>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(588, 418, true);
            WriteLiteral(@"<div class=""divider""></div>
<div class=""row"">
    <div class=""col s12"">
        <div class=""card-panel"">
            <h4 class=""header2"">Profile Updated</h4>
            <div class=""row"">
                <div class=""col s12"" asp-action=""Edit"" method=""post"">
                    <div class=""row"">
                        <div class=""input-field col s12 l4"">
                            <span><b>Username</b> : ");
            EndContext();
            BeginContext(1007, 14, false);
#line 32 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Profile\Edited.cshtml"
                                               Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1021, 152, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Email</b> : ");
            EndContext();
            BeginContext(1174, 11, false);
#line 35 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Profile\Edited.cshtml"
                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1185, 159, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"input-field col s12 l4\">\r\n                            <span><b>Phone number</b> : ");
            EndContext();
            BeginContext(1345, 17, false);
#line 38 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\Profile\Edited.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 147, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Identity.Service.Application.Commands.User.EditUserProfileCommand> Html { get; private set; }
    }
}
#pragma warning restore 1591
