#pragma checksum "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\Home\ViewAppointments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4328001dfbcd389d7a5f40f038deeafbb4754e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewAppointments), @"mvc.1.0.view", @"/Views/Home/ViewAppointments.cshtml")]
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
#line 1 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\_ViewImports.cshtml"
using IS413Project1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\_ViewImports.cshtml"
using IS413Project1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4328001dfbcd389d7a5f40f038deeafbb4754e", @"/Views/Home/ViewAppointments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58404cd88900245199e3e64bd4623cb88f8e7af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewAppointments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IS413Project1.AppointmentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Appointment Time</th>
            <th>Group Name</th>
            <th>Group Size</th>
            <th>Email</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\Home\ViewAppointments.cshtml"
         foreach (var x in Model.Appointment)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-left\">");
#nullable restore
#line 23 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\Home\ViewAppointments.cshtml"
                                 Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 24 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\Home\ViewAppointments.cshtml"
                                   Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 25 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\Home\ViewAppointments.cshtml"
                                   Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 26 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\Home\ViewAppointments.cshtml"
                                   Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\brand\source\repos\413proj1\IS413Project1\IS413Project1\Views\Home\ViewAppointments.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IS413Project1.AppointmentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
