#pragma checksum "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71dd642bc904f6129c19023d92ba19ad299edd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Portfolio), @"mvc.1.0.view", @"/Views/Shared/_Portfolio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Portfolio.cshtml", typeof(AspNetCore.Views_Shared__Portfolio))]
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
#line 1 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\_ViewImports.cshtml"
using MainProjectFull;

#line default
#line hidden
#line 2 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\_ViewImports.cshtml"
using MainProjectFull.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71dd642bc904f6129c19023d92ba19ad299edd6", @"/Views/Shared/_Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ea5109a68739a776e573f33ef734ff6fb8cc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainProjectFull.ViewModel.PortVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Images/Users/profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Profile/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Profile/port.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Profile/imgbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 49, true);
            WriteLiteral("\r\n<style>\r\n    .main-back {\r\n        background: ");
            EndContext();
            BeginContext(135, 34, false);
#line 6 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
               Write(Model.CoverClass.Profile.BackColor);

#line default
#line hidden
            EndContext();
            BeginContext(169, 102, true);
            WriteLiteral(";\r\n        color: #fff;\r\n    }\r\n\r\n    .main-back-color:hover,\r\n    .main-back-color {\r\n        color: ");
            EndContext();
            BeginContext(272, 34, false);
#line 12 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
          Write(Model.CoverClass.Profile.BackColor);

#line default
#line hidden
            EndContext();
            BeginContext(306, 57, true);
            WriteLiteral(" !important;\r\n    }\r\n\r\n    .main-color {\r\n        color: ");
            EndContext();
            BeginContext(364, 34, false);
#line 16 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
          Write(Model.CoverClass.Profile.TextColor);

#line default
#line hidden
            EndContext();
            BeginContext(398, 149, true);
            WriteLiteral(";\r\n    }\r\n\r\n    .end-date a,\r\n    .start-date a {\r\n        color: #fff;\r\n    }\r\n</style>\r\n\r\n\r\n<section class=\"container port\">\r\n\r\n    <div data-url=\"");
            EndContext();
            BeginContext(548, 25, false);
#line 28 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
              Write(Url.Action("Save","Port"));

#line default
#line hidden
            EndContext();
            BeginContext(573, 35, true);
            WriteLiteral("\" class=\"save-portfolio\"></div>\r\n\r\n");
            EndContext();
#line 30 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
     if (SignInManager.IsSignedIn(User) && User.Identity.Name == Model.CoverClass.User.Email)
    {

#line default
#line hidden
            BeginContext(710, 190, true);
            WriteLiteral("        <div class=\"main-section-header\">\r\n            <h6 class=\"mb-4\">Portfolio</h6>\r\n            <a href=\"#\" class=\"hover-underline add-form ml-4 main-color\"> yüklə </a>\r\n        </div>\r\n");
            EndContext();
            BeginContext(902, 2267, true);
            WriteLiteral(@"        <div class=""add-port dropdown"">

            <button class=""butt butt-blue butt-big add-images"">Şəkilləri seçin</button>
            <input type=""file"" multiple accept="".jpg,.png"" class=""hidden-input port-images"">

            <div class=""selected-photos""></div>

            <small class=""pname-error text-danger"">Proektin adını yazın (max. 60 hərf)</small>
            <div class=""input-group mb-3 mt-4"">
                <input type=""text"" class=""form-control pname"" placeholder=""proektin adı"">
            </div>

            <textarea cols=""30"" placeholder=""Proekt haqqında"" rows=""4"" class=""form-control pabout""></textarea>

            <div class=""input-group mb-3 port-type"">
                <label for=""web""> Veb dizayn </label>
                <input type=""radio"" id=""veb"" name=""ptype"" value=""web"" />

                <label for=""design"" class=""ml-4""> Qrafik dizayn </label>
                <input type=""radio"" id=""qrafik"" name=""ptype"" value=""design"" />
                <small class=""ptyp");
            WriteLiteral(@"e-error text-danger ml-4"">Portfolionun tipi mütləqdir</small>

            </div>


            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1""><i class=""fab fa-github-square""></i></span>
                </div>
                <input type=""text"" class=""form-control pgithub"" placeholder=""Github link"">
            </div>

            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1""><i class=""fab fa-linkedin-in""></i></span>
                </div>
                <input type=""text"" class=""form-control pbehance"" placeholder=""Behance link"">
            </div>

            <div class=""input-group mb-3"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"" id=""basic-addon1""><i class=""fab fa-internet-explorer""></i></span>
                </div>
    ");
            WriteLiteral("            <input type=\"text\" class=\"form-control pwebsite\" placeholder=\"Website link\">\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"butt butt-gray send-port mb-4\">Əlavə et</button>\r\n        </div>\r\n");
            EndContext();
#line 85 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
    }

#line default
#line hidden
            BeginContext(3176, 43, true);
            WriteLiteral("\r\n        <div class=\"port-list\" data-src=\"");
            EndContext();
            BeginContext(3220, 43, false);
#line 87 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
                                    Write(Url.Content("~/Content/Images/PortImages/"));

#line default
#line hidden
            EndContext();
            BeginContext(3263, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 88 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
             foreach (var item in Model.Portfolio)
            {
                PortfolioImages img = null;
                if (Model.PortfolioImages.Count > 0)
                {
                    img = Model.PortfolioImages.FirstOrDefault(p => p.PortfolioId == item.id);
                }
                if (img != null)
                {

#line default
#line hidden
            BeginContext(3620, 42, true);
            WriteLiteral("                    <div class=\"portfolio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3662, "\"", 3675, 1);
#line 97 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
WriteAttributeValue("", 3667, item.id, 3667, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3676, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(3703, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d71dd642bc904f6129c19023d92ba19ad299edd612025", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3713, "~/Content/Images/PortImages/", 3713, 28, true);
#line 98 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
AddHtmlAttributeValue("", 3741, img.Name, 3741, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3759, 31, true);
            WriteLiteral("\r\n                        <h5> ");
            EndContext();
            BeginContext(3791, 9, false);
#line 99 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
                        Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3800, 36, true);
            WriteLiteral(" </h5>\r\n                    </div>\r\n");
            EndContext();
#line 101 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3896, 42, true);
            WriteLiteral("                    <div class=\"portfolio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3938, "\"", 3951, 1);
#line 104 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
WriteAttributeValue("", 3943, item.id, 3943, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3952, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(3979, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d71dd642bc904f6129c19023d92ba19ad299edd614920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4032, 31, true);
            WriteLiteral("\r\n                        <h5> ");
            EndContext();
            BeginContext(4064, 9, false);
#line 106 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
                        Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4073, 36, true);
            WriteLiteral(" </h5>\r\n                    </div>\r\n");
            EndContext();
#line 108 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Portfolio.cshtml"
                }

            }

#line default
#line hidden
            BeginContext(4145, 38, true);
            WriteLiteral("        </div>\r\n\r\n\r\n</section>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(4183, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71dd642bc904f6129c19023d92ba19ad299edd616926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4227, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4229, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71dd642bc904f6129c19023d92ba19ad299edd618106", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4273, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4275, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71dd642bc904f6129c19023d92ba19ad299edd619286", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Users> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainProjectFull.ViewModel.PortVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
