#pragma checksum "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306999f69b071a05d2157d1507a859b467e5375a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log_ErrorsLog), @"mvc.1.0.view", @"/Views/Log/ErrorsLog.cshtml")]
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
#line 1 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Shared.Dtos.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
using DynamicBox.Admin.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306999f69b071a05d2157d1507a859b467e5375a", @"/Views/Log/ErrorsLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3038d5d4c418aa38589fe56bb74874e62685f7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Log_ErrorsLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Log.LogsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("error-log-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Log", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteLogs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
  
    ViewBag.Title = Localizer["PageTitle"];
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line (12,6)-(12,28) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["PageTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"col-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "306999f69b071a05d2157d1507a859b467e5375a6868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 15 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "306999f69b071a05d2157d1507a859b467e5375a8513", async() => {
                WriteLiteral("\r\n    <div class=\"d-flex flex-row mt-3 justify-content-end mb-3\">\r\n        <div class=\"p-2\">\r\n            <a href=\"#\" class=\"btn btn-danger error-log-delete-button\">\r\n                ");
#nullable restore
#line (22,18)-(22,43) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["DeleteButton"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </a>\r\n        </div>\r\n        <div class=\"p-1\">\r\n            <!--Date Picker-->\r\n            <div class=\"datepicker input-group date\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "306999f69b071a05d2157d1507a859b467e5375a9424", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 28 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeleteOlderThan);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""input-group-append"">
                    <span class=""input-group-text""><i class=""fa fa-calendar""></i></span>
                </div>
            </div>
        </div>
    </div>
    
    <!-- Modal -->
    <div class=""modal fade"" id=""deleteLogsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""deleteLogsModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""deletePersistedGrantsModalLabel"">");
#nullable restore
#line (41,83)-(41,113) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["DeleteDialogTitle"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    ");
#nullable restore
#line (45,22)-(45,54) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["DeleteDialogMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"submit\" class=\"btn btn-danger\">");
#nullable restore
#line (48,67)-(48,95) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["DeleteDialogYes"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    <button type=\"button\" class=\"btn btn-outline-primary\" data-dismiss=\"modal\">");
#nullable restore
#line (49,97)-(49,124) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["DeleteDialogNo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        ");
#nullable restore
#line (58,10)-(58,107) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(await Html.PartialAsync("Common/Search", new Search { Action = "ErrorsLog", Controller = "Log" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-12"">
        <div class=""table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th></th>
                        <th>");
#nullable restore
#line (69,30)-(69,53) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["TableLevel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line (70,30)-(70,54) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["TableLogged"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line (71,30)-(71,55) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["TableMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 75 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
                     foreach (var log in Model.Logs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a href=\"#\" data-error-id=\"");
#nullable restore
#line (78,61)-(78,67) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(log.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-primary btn-error-detail\">");
#nullable restore
#line (78,111)-(78,139) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["TableShowDetail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                            <td>");
#nullable restore
#line (79,34)-(79,43) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(log.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <span class=\"local-datetime\"");
            BeginWriteAttribute("title", " title=\"", 3320, "\"", 3342, 1);
#nullable restore
#line (81,69)-(81,83) 30 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
WriteAttributeValue("", 3328, log.TimeStamp, 3328, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-utc=\"");
#nullable restore
#line (81,96)-(81,125) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(log.TimeStamp.GetEpochTicks());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"tooltip\" data-placement=\"top\">\r\n                                    ");
#nullable restore
#line (82,38)-(82,51) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(log.TimeStamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"oi oi-clock\"");
            BeginWriteAttribute("title", " title=\"", 3581, "\"", 3603, 1);
#nullable restore
#line (84,66)-(84,80) 30 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
WriteAttributeValue("", 3589, log.TimeStamp, 3589, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"top\"></span>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line (86,34)-(86,45) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(log.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr class=\"row-error-detail d-none\" data-error-id=\"");
#nullable restore
#line (88,77)-(88,83) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(log.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <td colspan=\"4\" data-error-json=\"");
#nullable restore
#line (89,63)-(89,75) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(log.LogEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></td>\r\n                        </tr>\r\n");
#nullable restore
#line 91 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        ");
#nullable restore
#line (100,10)-(100,189) 6 "C:\Users\malfx001\Desktop\Workshop\DynamicBox\IdentityServer4\src\DynamicBox.Admin\Views\Log\ErrorsLog.cshtml"
Write(await Html.PartialAsync("Common/Pager", new Pager { Action = "ErrorsLog", PageSize = Model.PageSize, TotalCount = Model.TotalCount, EnableSearch = true, Search = ViewBag.Search }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Log.LogsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
