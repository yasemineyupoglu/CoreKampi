#pragma checksum "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c33686ac997f7a7d162952f79de16d0cc701b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRol_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRol/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c33686ac997f7a7d162952f79de16d0cc701b7", @"/Areas/Admin/Views/AdminRol/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRol_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppRole>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c33686ac997f7a7d162952f79de16d0cc701b73667", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content animated fadeInRight"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Roller</h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fa fa-chevron-up""></i>
                            </a>
                            <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                                <i class=""fa fa-wrench""></i>
                            </a>
                            <ul class=""dropdown-menu dropdown-user"">
                                <li>
                                    <a href=""#"" class=""dropdown-item"">Config option 1</a>
                                </li>
                                <li>
                                    <a href=""#"" class=""dropdown-item"">Config option 2</a>
             ");
                WriteLiteral(@"                   </li>
                            </ul>
                            <a class=""close-link"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">

                        <table class=""table table-hover"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Başlık</th>
                                    <th>Sil</th>
                                    <th>Düzenle</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 49 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <th>");
#nullable restore
#line 52 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2261, "\"", 2303, 2);
                WriteAttributeValue("", 2268, "/Admin/AdminRol/DeleteRole/", 2268, 27, true);
#nullable restore
#line 54 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
WriteAttributeValue("", 2295, item.Id, 2295, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2396, "\"", 2438, 2);
                WriteAttributeValue("", 2403, "/Admin/AdminRol/UpdateRole/", 2403, 27, true);
#nullable restore
#line 55 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
WriteAttributeValue("", 2430, item.Id, 2430, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\HP\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRol\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                        <a href=""/Admin/AdminRol/AddRole/"" class=""btn btn-outline-primary"">Yeni Rol Ekle</a>
                        <a href=""/Admin/AdminRol/UserRoleList/"" class=""btn btn-outline-info"">Kullanıcı Rol Listesi</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
