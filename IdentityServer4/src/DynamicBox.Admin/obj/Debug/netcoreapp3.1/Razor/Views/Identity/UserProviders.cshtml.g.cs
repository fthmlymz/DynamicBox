#pragma checksum "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5a969e013e48c14bd2b12a59e41c3b28a3ce1e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Identity_UserProviders), @"mvc.1.0.view", @"/Views/Identity/UserProviders.cshtml")]
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
#line 1 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5a969e013e48c14bd2b12a59e41c3b28a3ce1e0", @"/Views/Identity/UserProviders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3038d5d4c418aa38589fe56bb74874e62685f7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Identity_UserProviders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces.IUserProvidersDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProvidersDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
  
	ViewBag.Title = Localizer["PageTitle"];
	Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\t\r\n\t<div class=\"col-12\">\r\n\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t<ol class=\"breadcrumb\">\r\n\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5a969e013e48c14bd2b12a59e41c3b28a3ce1e05170", async() => {
#nullable restore
#line (15,82)-(15,110) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Localizer["NavigationUsers"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5a969e013e48c14bd2b12a59e41c3b28a3ce1e06787", async() => {
#nullable restore
#line (16,117)-(16,131) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Model.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line (16,102)-(16,114) 13 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n\t\t\t\t<li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line (17,61)-(17,83) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Localizer["PageTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t</ol>\r\n\t\t</nav>\r\n\t</div>\r\n\r\n\t<div class=\"col-md-12\">\r\n\t\t<h3>");
#nullable restore
#line (23,8)-(23,30) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Localizer["PageTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\r\n\t\t<div class=\"row table-responsive\">\r\n\t\t\t<table class=\"table table-striped\">\r\n\t\t\t\t<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>");
#nullable restore
#line (29,11)-(29,42) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Localizer["TableLoginProvider"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line (30,11)-(30,48) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Localizer["TableProviderDisplayName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line (31,11)-(31,40) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Localizer["TableProviderKey"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th></th>\r\n\t\t\t\t</tr>\r\n\t\t\t\t</thead>\r\n\t\t\t\t<tbody>\r\n");
#nullable restore
#line 36 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
                 foreach (var provider in Model.Providers)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line (39,12)-(39,34) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(provider.LoginProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line (40,12)-(40,40) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(provider.ProviderDisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line (41,12)-(41,32) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(provider.ProviderKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5a969e013e48c14bd2b12a59e41c3b28a3ce1e012486", async() => {
#nullable restore
#line (42,146)-(42,176) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
Write(Localizer["TableButtonRemove"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-providerKey", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line (42,71)-(42,91) 13 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
WriteLiteral(provider.ProviderKey);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["providerKey"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-providerKey", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["providerKey"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line (42,108)-(42,120) 13 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 44 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Identity\UserProviders.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces.IUserProvidersDto> Html { get; private set; }
    }
}
#pragma warning restore 1591