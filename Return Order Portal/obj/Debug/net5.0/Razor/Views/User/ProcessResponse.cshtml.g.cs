#pragma checksum "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4afa4fc4a10efe466585c3b972a2dc75e08ae29c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ProcessResponse), @"mvc.1.0.view", @"/Views/User/ProcessResponse.cshtml")]
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
#line 1 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\_ViewImports.cshtml"
using Return_Order_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\_ViewImports.cshtml"
using Return_Order_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afa4fc4a10efe466585c3b972a2dc75e08ae29c", @"/Views/User/ProcessResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28219d04afb92109702e05c54c5a31345b8d3058", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ProcessResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Return_Order_Portal.Models.ProcessResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
   ViewData["Title"] = "ProcessResponse"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afa4fc4a10efe466585c3b972a2dc75e08ae29c4340", async() => {
                WriteLiteral("\n    <link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css\" rel=\"stylesheet\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afa4fc4a10efe466585c3b972a2dc75e08ae29c5414", async() => {
                WriteLiteral("\n    <h1>Please confirm your order!</h1>\n    <table>\n        <tr>\n            <td>");
#nullable restore
#line 15 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Label("Request Id"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 17 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Display("RequestId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 20 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Label("Processing Charge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 22 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Display("ProcessingCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 25 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Label("PackagingAndDeliveryCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 27 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Display("PackagingAndDeliveryCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 30 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Label("DateOfDelivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 32 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ProcessResponse.cshtml"
           Write(Html.Display("DateOfDelivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n\n    </table>\n\n    <div class=\"btn btn-outline-success\"> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4afa4fc4a10efe466585c3b972a2dc75e08ae29c8262", async() => {
                    WriteLiteral("Confirm");
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
                WriteLiteral("</div>\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Return_Order_Portal.Models.ProcessResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
