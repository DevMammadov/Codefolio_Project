#pragma checksum "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec1ed560d036e78276b3482086fc3c62ef24c46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Language_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Language/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Language/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Language_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec1ed560d036e78276b3482086fc3c62ef24c46", @"/Areas/Admin/Views/Language/Index.cshtml")]
    public class Areas_Admin_Views_Language_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainProjectFull.Areas.Admin.ViewModel.LangVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:80px;width:130px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Images/Flags/aze.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:40px;width:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(93, 34, false);
#line 6 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
            EndContext();
            BeginContext(127, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(131, 4827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ec1ed560d036e78276b3482086fc3c62ef24c465245", async() => {
                BeginContext(151, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(160, 34, false);
#line 10 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
                EndContext();
                BeginContext(194, 527, true);
                WriteLiteral(@"



    <div id=""content-wrapper"">

        <div class=""container-fluid"">

            <!-- Breadcrumbs-->
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item"">
                    <a href=""#"">Dashboard</a>
                </li>
                <li class=""breadcrumb-item active"">Overview</li>
            </ol>

            <!-- Icon Cards-->
            <div class=""row"">

                <div class=""col-lg-8 offset-lg-1 pb-4"">

                    <div class=""text-center"">
");
                EndContext();
#line 32 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                         if (Model.Language != null)
                        {

#line default
#line hidden
                BeginContext(802, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(830, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ec1ed560d036e78276b3482086fc3c62ef24c466931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 840, "~/Content/Images/Flags/", 840, 23, true);
#line 34 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
AddHtmlAttributeValue("", 863, Model.Language.Icon, 863, 20, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(941, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 35 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1027, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1055, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ec1ed560d036e78276b3482086fc3c62ef24c469181", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1153, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1182, 57, true);
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <form");
                EndContext();
                BeginWriteAttribute("action", " action=\"", 1239, "\"", 1284, 1);
#line 43 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
WriteAttributeValue("", 1248, Url.Action(Model.Action,"Language"), 1248, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1285, 370, true);
                WriteLiteral(@" enctype=""multipart/form-data"" method=""post"" class=""mt-4"">

                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""basic-addon1""> <i class=""fas fa-globe-asia""></i> </span>
                            </div>
                            ");
                EndContext();
                BeginContext(1656, 125, false);
#line 49 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Language.Name, null, new { @class = "form-control", required = "required", placeholder = "Ölkə adı" }));

#line default
#line hidden
                EndContext();
                BeginContext(1781, 451, true);
                WriteLiteral(@"
                        </div>

                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""basic-addon1""> <i class=""fas fa-image""></i> </span>
                            </div>
                            <input type=""file"" name=""file"" class=""form-control"">
                        </div>

                        ");
                EndContext();
                BeginContext(2233, 34, false);
#line 59 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                   Write(Html.HiddenFor(m => m.Language.id));

#line default
#line hidden
                EndContext();
                BeginContext(2267, 108, true);
                WriteLiteral("\r\n\r\n                        <div class=\"input-group mb-3\">\r\n                            <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2375, "\"", 2396, 1);
#line 62 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
WriteAttributeValue("", 2383, Model.Button, 2383, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2397, 1324, true);
                WriteLiteral(@" class=""btn btn-success"">
                        </div>

                    </form>

                </div>

                <!-- DataTables Example -->
                <div class=""card mb-3 w-100"">
                    <div class=""card-header"">
                        <i class=""fas fa-globe-asia""></i>
                        Dillərin cədvəli
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                <thead>
                                    <tr>
                                        <th>Ölkə</th>
                                        <th>Bayrağı</th>
                                        <th>Redaktə et</th>
                                    </tr>
                                </thead>
                                <tfoot>
                                    <tr>
  ");
                WriteLiteral(@"                                      <th>Ölkə</th>
                                        <th>Bayrağı</th>
                                        <th>Redaktə et</th>
                                    </tr>
                                </tfoot>
                                <tbody>

");
                EndContext();
#line 94 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                                     foreach (var item in Model.Languages)
                                    {

#line default
#line hidden
                BeginContext(3836, 94, true);
                WriteLiteral("                                        <tr>\r\n                                            <td>");
                EndContext();
                BeginContext(3931, 9, false);
#line 97 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3940, 56, true);
                WriteLiteral("</td>\r\n                                            <td> ");
                EndContext();
                BeginContext(3996, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ec1ed560d036e78276b3482086fc3c62ef24c4616045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4006, "~/Content/Images/Flags/", 4006, 23, true);
#line 98 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
AddHtmlAttributeValue("", 4029, item.Icon, 4029, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4096, 58, true);
                WriteLiteral("</td>\r\n                                            <td> <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4154, "\"", 4212, 1);
#line 99 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
WriteAttributeValue("", 4161, Url.Action("Edit","Language",new { id = item.id }), 4161, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4213, 102, true);
                WriteLiteral(" class=\"btn btn-warning w-100\"> Redaktə et </a> </td>\r\n                                        </tr>\r\n");
                EndContext();
#line 101 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
                                    }

#line default
#line hidden
                BeginContext(4354, 597, true);
                WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </div>
            <!-- /.container-fluid -->
            <!-- Sticky Footer -->
            <footer class=""sticky-footer"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright © Your Website 2019</span>
                    </div>
                </div>
            </footer>

        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4958, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4961, 34, false);
#line 124 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Areas\Admin\Views\Language\Index.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
            EndContext();
            BeginContext(4995, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainProjectFull.Areas.Admin.ViewModel.LangVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
