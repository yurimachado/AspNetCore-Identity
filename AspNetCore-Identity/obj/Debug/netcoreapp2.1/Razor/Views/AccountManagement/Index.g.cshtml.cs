#pragma checksum "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fb3a541e880bbd7447ed60e44892040b1b60b20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManagement_Index), @"mvc.1.0.view", @"/Views/AccountManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountManagement/Index.cshtml", typeof(AspNetCore.Views_AccountManagement_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb3a541e880bbd7447ed60e44892040b1b60b20", @"/Views/AccountManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6db62f6bfef32d7a96da3eb83599da05236171", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Identity.Service.Application.Query.User.Dto.AccountDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/prism/prism.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/data-tables/css/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/data-tables/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts/data-tables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating btn-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Create user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
  
    ViewData["Title"] = "Accounts";

#line default
#line hidden
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(139, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(145, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40e28440616a4c0794dc4aa7e8341a87", async() => {
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
                BeginContext(217, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(223, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2302ebafbfb1486f89b3d933fa907261", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                BeginContext(321, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(326, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(346, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(352, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9293c950b0428fa0712b7da7a3060d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(448, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(454, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710614d121cd4053aaa5ad1c7f8ac3ce", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(528, 119, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        layoutMenuItem.SetActiveMenuItem(\"accounts-menu-item\");\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(650, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Breadcrumbs", async() => {
                BeginContext(679, 120, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col s10 m6 l6\">\r\n            <ol class=\"breadcrumbs\">\r\n                <li>");
                EndContext();
                BeginContext(799, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aefabd22a45d4f89aee4001cde90f0e6", async() => {
                    BeginContext(821, 7, true);
                    WriteLiteral("Account");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(832, 101, true);
                WriteLiteral("</li>\r\n                <li class=\"active\">Users</li>\r\n            </ol>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(936, 1777, true);
            WriteLiteral(@"
<div class=""divider""></div>
<div id=""table-datatables"">
    <div class=""row"">
        <div class=""col s12"">
            <table id=""accounts-editable-data-table"" class=""responsive-table display"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Edit</th>
                        <th>ID</th>
                        <th>Username</th>
                        <th>Email</th>
                        <th>Phone number</th>
                        <th class=""center"">Blocked</th>
                        <th class=""center"">Lockout enabled</th>
                        <th class=""center"">Number of attempts</th>
                        <th class=""center"">Two factor enabled</th>
                        <th class=""center"">Email confirmed</th>
                        <th class=""center"">Phone confirmed</th>
                        <th class=""center"">Is an administrator</th>
                    </tr>
                </thead>
                <tfoot>
              ");
            WriteLiteral(@"      <tr>
                        <th>Edit</th>
                        <th>ID</th>
                        <th>Username</th>
                        <th>Email</th>
                        <th>Phone number</th>
                        <th class=""center"">Blocked</th>
                        <th class=""center"">Lockout enabled</th>
                        <th class=""center"">Number of attempts</th>
                        <th class=""center"">Two factor enabled</th>
                        <th class=""center"">Email confirmed</th>
                        <th class=""center"">Phone confirmed</th>
                        <th class=""center"">Is an administrator</th>
                    </tr>
                </tfoot>
                <tbody>
");
            EndContext();
#line 69 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
            BeginContext(2786, 99, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"center\">\r\n                            ");
            EndContext();
            BeginContext(2885, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010d36d1e38b403b8626b75af859ceb3", async() => {
                BeginContext(2965, 103, true);
                WriteLiteral("\r\n                                <i class=\"material-icons\">mode_edit</i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                                                                      WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3072, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(3134, 7, false);
#line 77 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                       Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3141, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3177, 13, false);
#line 78 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                       Write(user.Username);

#line default
#line hidden
            EndContext();
            BeginContext(3190, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3226, 10, false);
#line 79 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                       Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3236, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3272, 16, false);
#line 80 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                       Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3288, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"center\">");
            EndContext();
            BeginContext(3339, 14, false);
#line 81 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                      Write(user.IsBlocked);

#line default
#line hidden
            EndContext();
            BeginContext(3353, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"center\">");
            EndContext();
            BeginContext(3404, 19, false);
#line 82 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                      Write(user.LockoutEnabled);

#line default
#line hidden
            EndContext();
            BeginContext(3423, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"center\">");
            EndContext();
            BeginContext(3474, 22, false);
#line 83 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                      Write(user.AccessFailedCount);

#line default
#line hidden
            EndContext();
            BeginContext(3496, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"center\">");
            EndContext();
            BeginContext(3547, 21, false);
#line 84 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                      Write(user.TwoFactorEnabled);

#line default
#line hidden
            EndContext();
            BeginContext(3568, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"center\">");
            EndContext();
            BeginContext(3619, 19, false);
#line 85 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                      Write(user.EmailConfirmed);

#line default
#line hidden
            EndContext();
            BeginContext(3638, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"center\">");
            EndContext();
            BeginContext(3689, 25, false);
#line 86 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                      Write(user.PhoneNumberConfirmed);

#line default
#line hidden
            EndContext();
            BeginContext(3714, 50, true);
            WriteLiteral("</td>\r\n                        <td class=\"center\">");
            EndContext();
            BeginContext(3765, 12, false);
#line 87 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                                      Write(user.IsAdmin);

#line default
#line hidden
            EndContext();
            BeginContext(3777, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 89 "D:\Dev Folder\Projects\Github\yuricmachado\AspNetCore-Identity\Views\AccountManagement\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3834, 86, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("FloatingButton", async() => {
                BeginContext(3945, 118, true);
                WriteLiteral("\r\n    <!-- Floating Action Button -->\r\n    <div class=\"fixed-action-btn\" style=\"bottom: 50px; right: 19px;\">\r\n        ");
                EndContext();
                BeginContext(4063, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d466b83509de44f48fa000f079feaaa9", async() => {
                    BeginContext(4137, 57, true);
                    WriteLiteral("\r\n            <i class=\"material-icons\">add</i>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4198, 51, true);
                WriteLiteral("\r\n    </div>\r\n    <!-- Floating Action Button -->\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Identity.Service.Application.Query.User.Dto.AccountDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
