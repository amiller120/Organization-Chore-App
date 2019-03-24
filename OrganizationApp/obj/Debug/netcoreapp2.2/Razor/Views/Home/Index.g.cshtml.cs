#pragma checksum "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "514936adae9e90b9f1422105cb8ccbce72dc8283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\_ViewImports.cshtml"
using OrganizationApp;

#line default
#line hidden
#line 2 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\_ViewImports.cshtml"
using OrganizationApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"514936adae9e90b9f1422105cb8ccbce72dc8283", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd2bdaec714352834c555b1ef0633e3dbdc2a6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ChoreItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(76, 310, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-6"">
        <table id=""choreTable"">
            <thead>
                <tr>
                    <td>Name</td>
                    <td>Assignee</td>
                    <td>Is Complete?</td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 18 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                 foreach (var chore in Model)
                {

#line default
#line hidden
            BeginContext(452, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(499, 10, false);
#line 21 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                   Write(chore.Name);

#line default
#line hidden
            EndContext();
            BeginContext(509, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 22 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                     if (chore.AssignedTo != null)
                    {

#line default
#line hidden
            BeginContext(591, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(620, 21, false);
#line 24 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                       Write(chore.AssignedTo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(641, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 25 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(720, 69, true);
            WriteLiteral("                        <td>No one has been assigned this task</td>\r\n");
            EndContext();
#line 29 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(812, 26, true);
            WriteLiteral("\r\n                    <td>");
            EndContext();
            BeginContext(839, 16, false);
#line 31 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                   Write(chore.IsComplete);

#line default
#line hidden
            EndContext();
            BeginContext(855, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(904, 90, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(995, 39, false);
#line 39 "C:\Users\abomb\Desktop\Cleaning App\Organization-Chore-App\OrganizationApp\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("AddChore"));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1074, 128, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#choreTable\").DataTable();\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ChoreItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
