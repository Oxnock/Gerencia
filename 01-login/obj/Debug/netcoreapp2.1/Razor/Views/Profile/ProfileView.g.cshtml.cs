#pragma checksum "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9d834c53802b363b81e1af1514561d264ccee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_ProfileView), @"mvc.1.0.view", @"/Views/Profile/ProfileView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/ProfileView.cshtml", typeof(AspNetCore.Views_Profile_ProfileView))]
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
#line 1 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\_ViewImports.cshtml"
using SampleMvcApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9d834c53802b363b81e1af1514561d264ccee5", @"/Views/Profile/ProfileView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e3215a5f67ad76e6da6f8e7dee53382bd3c076", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_ProfileView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SampleMvcApp.Models.ProfileModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
  
    ViewData["Title"] = "ProfileView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 35, true);
            WriteLiteral("\r\n<h2>ProfileView</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(185, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75cc41535461430eae1a71b70592be04", async() => {
                BeginContext(208, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(315, 48, false);
#line 17 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(363, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(419, 40, false);
#line 20 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(459, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(515, 49, false);
#line 23 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstLastName));

#line default
#line hidden
            EndContext();
            BeginContext(564, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(620, 50, false);
#line 26 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayNameFor(model => model.SecondLastName));

#line default
#line hidden
            EndContext();
            BeginContext(670, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(726, 47, false);
#line 29 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(773, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(829, 44, false);
#line 32 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayNameFor(model => model.PersonID));

#line default
#line hidden
            EndContext();
            BeginContext(873, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(929, 42, false);
#line 35 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayNameFor(model => model.IDType));

#line default
#line hidden
            EndContext();
            BeginContext(971, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1089, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1138, 47, false);
#line 44 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1241, 39, false);
#line 47 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1336, 48, false);
#line 50 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1440, 49, false);
#line 53 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayFor(modelItem => item.SecondLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1545, 46, false);
#line 56 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1647, 43, false);
#line 59 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayFor(modelItem => item.PersonID));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1746, 41, false);
#line 62 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDType));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1843, 65, false);
#line 65 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1929, 71, false);
#line 66 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2021, 69, false);
#line 67 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2090, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\pc\Documents\GitHub\Gerencia\01-login\Views\Profile\ProfileView.cshtml"
}

#line default
#line hidden
            BeginContext(2129, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SampleMvcApp.Models.ProfileModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
