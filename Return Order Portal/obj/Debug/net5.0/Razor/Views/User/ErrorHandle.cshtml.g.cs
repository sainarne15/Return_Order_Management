#pragma checksum "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ErrorHandle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e4a2b7e9a8858d81a85b14b370e0157d112bf63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ErrorHandle), @"mvc.1.0.view", @"/Views/User/ErrorHandle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e4a2b7e9a8858d81a85b14b370e0157d112bf63", @"/Views/User/ErrorHandle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28219d04afb92109702e05c54c5a31345b8d3058", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ErrorHandle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>An Error Occured while Processing your Request</h3>\n\n\n<hr />\n<h3>Exception Details:</h3>\n<div class=\"alert alert-danger\">\n    <h5>Exception Path</h5>\n    <hr/>\n    <p>");
#nullable restore
#line 9 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ErrorHandle.cshtml"
  Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n\n<div class=\"alert alert-danger\">\n    <h5>Exception Message</h5>\n    <hr />\n    <p>");
#nullable restore
#line 15 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ErrorHandle.cshtml"
  Write(ViewBag.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n\n<div class=\"alert alert-danger\">\n    <h5>Exception Stack Trace</h5>\n    <hr />\n    <p>");
#nullable restore
#line 21 "F:\VsFilesSai\Return-order-Management\Return Order Portal\Views\User\ErrorHandle.cshtml"
  Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
