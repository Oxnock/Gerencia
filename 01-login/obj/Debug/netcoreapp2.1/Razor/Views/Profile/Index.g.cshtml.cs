#pragma checksum "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2de7346bf54f465b104d3e47b70a1ece98556c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Index.cshtml", typeof(AspNetCore.Views_Profile_Index))]
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
#line 1 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\_ViewImports.cshtml"
using SampleMvcApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2de7346bf54f465b104d3e47b70a1ece98556c6", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e3215a5f67ad76e6da6f8e7dee53382bd3c076", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SampleMvcApp.Models.ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(286, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(376, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
            BeginContext(417, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2001, 18, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2055, 130, true);
            WriteLiteral("\r\n<div>\r\n        <h4>UserProfileModel</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2186, 48, false);
#line 81 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2290, 46, false);
#line 84 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayFor(  model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2336, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2392, 40, false);
#line 87 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2432, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2488, 36, false);
#line 90 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2524, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2580, 49, false);
#line 93 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstLastName));

#line default
#line hidden
            EndContext();
            BeginContext(2629, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2685, 45, false);
#line 96 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayFor(model => model.FirstLastName));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2786, 50, false);
#line 99 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SecondLastName));

#line default
#line hidden
            EndContext();
            BeginContext(2836, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2892, 46, false);
#line 102 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayFor(model => model.SecondLastName));

#line default
#line hidden
            EndContext();
            BeginContext(2938, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2994, 47, false);
#line 105 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3041, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3097, 43, false);
#line 108 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3140, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3196, 44, false);
#line 111 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PersonID));

#line default
#line hidden
            EndContext();
            BeginContext(3240, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3296, 40, false);
#line 114 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayFor(model => model.PersonID));

#line default
#line hidden
            EndContext();
            BeginContext(3336, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3392, 42, false);
#line 117 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDType));

#line default
#line hidden
            EndContext();
            BeginContext(3434, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3490, 38, false);
#line 120 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
           Write(Html.DisplayFor(model => model.IDType));

#line default
#line hidden
            EndContext();
            BeginContext(3528, 59, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3588, 68, false);
#line 125 "C:\Users\pc\Desktop\Gerencia de Macho1\Gerencia\01-login\Views\Profile\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3656, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3664, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3775fb41c8f3419686906eca6bf5e75a", async() => {
                BeginContext(3686, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(3702, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SampleMvcApp.Models.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591