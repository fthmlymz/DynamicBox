#pragma checksum "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626f935bef93a40d0df11a97dc5e46f46db98834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
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
#line 1 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626f935bef93a40d0df11a97dc5e46f46db98834", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1dd59b0e521c960d8f576b8979b4defdfd3ae0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DynamicBox.STS.Identity.ViewModels.Consent.ScopeViewModel>
    {
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
        private global::DynamicBox.STS.Identity.Helpers.TagHelpers.SwitchTagHelper __DynamicBox_STS_Identity_Helpers_TagHelpers_SwitchTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n\t<div class=\"toggle-button__input\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "626f935bef93a40d0df11a97dc5e46f46db988343182", async() => {
                WriteLiteral("\r\n\t\t\t<input class=\"consent-scopecheck\"\r\n\t\t\t\t   type=\"checkbox\"\r\n\t\t\t\t   name=\"ScopesConsented\"");
                BeginWriteAttribute("id", "\r\n\t\t\t\t   id=\"", 325, "\"", 356, 2);
                WriteAttributeValue("", 338, "scopes_", 338, 7, true);
#nullable restore
#line 11 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 345, Model.Name, 345, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n\t\t\t\t   value=\"", 357, "\"", 384, 1);
#nullable restore
#line 12 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 373, Model.Name, 373, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", "\r\n\t\t\t\t   checked=\"", 385, "\"", 417, 1);
#nullable restore
#line 13 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 403, Model.Checked, 403, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("disabled", "\r\n\t\t\t\t   disabled=\"", 418, "\"", 452, 1);
#nullable restore
#line 14 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 437, Model.Required, 437, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t");
            }
            );
            __DynamicBox_STS_Identity_Helpers_TagHelpers_SwitchTagHelper = CreateTagHelper<global::DynamicBox.STS.Identity.Helpers.TagHelpers.SwitchTagHelper>();
            __tagHelperExecutionContext.Add(__DynamicBox_STS_Identity_Helpers_TagHelpers_SwitchTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"toggle-button__text\">\r\n");
#nullable restore
#line 18 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<input type=\"hidden\"\r\n\t\t\t\t   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n\t\t\t\t   value=\"", 606, "\"", 633, 1);
#nullable restore
#line 22 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 622, Model.Name, 622, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 23 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<strong>");
#nullable restore
#line 24 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 25 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<i class=\"fa fa-exclamation-circle\"></i>\r\n");
#nullable restore
#line 28 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n");
#nullable restore
#line 30 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"toggle-button__text\">\r\n\t\t\t<span><em>");
#nullable restore
#line 33 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
                 Write(Localizer["Required"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></span>\r\n\t\t</div>\r\n");
#nullable restore
#line 35 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"consent-description\">\r\n\t\t\t<label");
            BeginWriteAttribute("for", " for=\"", 983, "\"", 1007, 2);
            WriteAttributeValue("", 989, "scopes_", 989, 7, true);
#nullable restore
#line 39 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 996, Model.Name, 996, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t</div>\r\n");
#nullable restore
#line 41 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.STS.Identity\Views\Shared\_ScopeListItem.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUrlHelper UrlHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DynamicBox.STS.Identity.ViewModels.Consent.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
