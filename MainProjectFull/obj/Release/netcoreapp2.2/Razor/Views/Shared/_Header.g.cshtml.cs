#pragma checksum "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71afcc841a25cd9199ed2b936c54c13005cfec81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71afcc841a25cd9199ed2b936c54c13005cfec81", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ea5109a68739a776e573f33ef734ff6fb8cc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Images/Users/profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-back-color"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 21, true);
            WriteLiteral("\r\n<header data-user=\"");
            EndContext();
            BeginContext(66, 18, false);
#line 3 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
              Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(84, 174, true);
            WriteLiteral("\">\r\n    <div class=\"header-top\"></div>\r\n    <nav class=\"header-nav\">\r\n        <div class=\"container d-flex justify-content-between\">\r\n            <!-- Logo --->\r\n            ");
            EndContext();
            BeginContext(258, 9064, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71afcc841a25cd9199ed2b936c54c13005cfec817311", async() => {
                BeginContext(302, 9016, true);
                WriteLiteral(@"
                <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                     viewBox=""0 0 204.5 59.9"" style=""enable-background:new 0 0 204.5 59.9;"" xml:space=""preserve"">
                <style type=""text/css"">
                    .st0 {
                        fill: #1585C7;
                    }

                    .st1 {
                        fill: #EC8029;
                    }

                    .st2 {
                        fill: #863B92;
                    }

                    .st3 {
                        fill: #00A456;
                    }

                    .st4 {
                        fill: #E94026;
                    }

                    .st5 {
                        fill: #FFCA06;
                    }

                    .st6 {
                        fill: #FFFFFF;
                    }
</style>
                <g>
                <g>
                <path ");
                WriteLiteral(@"id=""XMLID_6_"" class=""st0"" d=""M44.1,15.6H5.2c-0.9,0-1.7-0.8-1.7-1.7v-2.1c0-0.9,0.8-1.7,1.7-1.7h34.3h4.6
                               c0.9,0,1.7,0.8,1.7,1.7v2.1C45.8,14.8,45.1,15.6,44.1,15.6z"" />







                <path id=""XMLID_5_"" class=""st1"" d=""M70.9,15.6H53.2c-0.9,0-1.7-0.8-1.7-1.7v-2.1c0-0.9,0.8-1.7,1.7-1.7h8.6h9.1
                               c0.9,0,1.7,0.8,1.7,1.7v2.1C72.6,14.8,71.8,15.6,70.9,15.6z"" />







                <path id=""XMLID_4_"" class=""st2"" d=""M33.3,26.7H15.6c-0.9,0-1.7-0.8-1.7-1.7v-2.1c0-0.9,0.8-1.7,1.7-1.7h12h5.8
                               c0.9,0,1.7,0.8,1.7,1.7V25C35,26,34.2,26.7,33.3,26.7z"" />







                <path id=""XMLID_3_"" class=""st3"" d=""M70.9,26.7H42.3c-0.9,0-1.7-0.8-1.7-1.7v-2.1c0-0.9,0.8-1.7,1.7-1.7h11.4H71
                               c0.9,0,1.7,0.8,1.7,1.7V25C72.6,26,71.8,26.7,70.9,26.7z"" />







                <path id=""XMLID_2_"" class=""st4"" d=""M70.9,37.9H25.6c-0.9,0-1.7-0.8-1.7-1.7v-2.1c0-0.9,0.8-1.7,1.7-1.7h25");
                WriteLiteral(@".9H71
                               c0.9,0,1.7,0.8,1.7,1.7v2.1C72.6,37.1,71.8,37.9,70.9,37.9z"" />







                <path id=""XMLID_1_"" class=""st5"" d=""M70.9,49H36.3c-0.9,0-1.7-0.8-1.7-1.7v-2.2c0-0.9,0.8-1.7,1.7-1.7h16.1h18.4
                               c0.9,0,1.7,0.8,1.7,1.7v2.1C72.6,48.2,71.8,49,70.9,49z"" />







                       </g>
                <g>
                <path class=""st6"" d=""M91.4,10.6c1.3,0.7,2.4,1.6,3.2,3L90.9,15c-0.8-1.1-1.9-1.7-3.4-1.7c-1.2,0-2.2,0.5-3.1,1.4s-1.3,2.2-1.3,3.8
                               s0.4,2.8,1.3,3.7s1.9,1.4,3.1,1.4c1.5,0,2.7-0.6,3.4-1.7l3.8,1.4c-0.8,1.3-1.9,2.3-3.2,3s-2.7,1-4,1c-0.9,0-1.9-0.2-2.9-0.5
                               c-1-0.4-1.9-0.9-2.8-1.6c-0.9-0.7-1.6-1.6-2.2-2.8s-0.8-2.5-0.8-3.9s0.3-2.7,0.8-3.9s1.3-2.1,2.2-2.8c0.9-0.7,1.8-1.2,2.8-1.6
                               c1-0.4,1.9-0.5,2.9-0.5C88.8,9.6,90.1,9.9,91.4,10.6z"" />







                <path class=""st6"" d=""M106.6,10.1c1,0.4,1.9,0.9,2.8,1.6c0.9,0.");
                WriteLiteral(@"7,1.6,1.6,2.2,2.8s0.8,2.5,0.8,3.9c0,1.1-0.2,2.2-0.6,3.2
                               s-0.9,1.8-1.5,2.5s-1.3,1.2-2.1,1.7c-0.8,0.5-1.5,0.8-2.3,1s-1.5,0.3-2.3,0.3s-1.5-0.1-2.3-0.3s-1.6-0.6-2.3-1
                               c-0.8-0.5-1.5-1-2.1-1.7s-1.1-1.5-1.5-2.5s-0.6-2.1-0.6-3.2c0-1.4,0.3-2.7,0.8-3.9c0.6-1.2,1.3-2.1,2.2-2.8
                               c0.9-0.7,1.8-1.2,2.8-1.6s1.9-0.6,2.9-0.6S105.6,9.8,106.6,10.1z M100.6,14.6c-0.9,0.9-1.4,2.2-1.4,3.8s0.5,2.8,1.4,3.8
                               c0.9,0.9,1.9,1.4,3.1,1.4s2.2-0.5,3.1-1.4s1.4-2.2,1.4-3.8s-0.5-2.9-1.4-3.8c-0.9-0.9-1.9-1.4-3.1-1.4S101.5,13.7,100.6,14.6z"" />







                <path class=""st6"" d=""M130.9,3.8v23.1h-4.2v-2.5c-0.1,0.6-0.6,1.2-1.6,1.8c-0.9,0.6-2,0.9-3.2,0.9c-1.3,0-2.5-0.3-3.7-0.9
                               c-1.2-0.6-2.2-1.6-3.1-3s-1.3-3-1.3-4.9c0-1.4,0.2-2.7,0.7-3.8s1.1-2.1,1.9-2.8s1.6-1.2,2.6-1.6s1.9-0.6,2.8-0.6
                               c1.3,0,2.3,0.3,3.2,0.8s1.4,1.1,1.5,1.7V9.7l0,0V3.8H130.9z M125.6,");
                WriteLiteral(@"22.2c0.8-0.9,1.3-2.2,1.3-3.9c0-1.8-0.4-3.1-1.2-3.9
                               c-0.8-0.8-1.8-1.3-3.1-1.3c-1.2,0-2.2,0.5-3.1,1.4s-1.4,2.2-1.4,3.7c0,1.6,0.5,2.8,1.4,3.8c0.9,0.9,1.9,1.4,3.1,1.4
                               C123.7,23.5,124.7,23.1,125.6,22.2z"" />







                <path class=""st6"" d=""M144,10.1c1,0.4,1.9,0.9,2.7,1.6c0.8,0.7,1.5,1.6,2.1,2.8c0.5,1.2,0.8,2.5,0.8,3.9c0,0.6,0,1.1-0.1,1.6h-12.7
                               c0.2,1.1,0.8,2,1.6,2.6c0.9,0.6,1.8,1,2.7,1c1.5,0,2.6-0.4,3.4-1.3l3.5,1.8c-1.8,2.1-4.1,3.1-6.9,3.1c-0.7,0-1.5-0.1-2.3-0.3
                               s-1.6-0.6-2.3-1c-0.8-0.5-1.5-1-2.1-1.7s-1.1-1.5-1.5-2.5s-0.6-2.1-0.6-3.2c0-1.9,0.5-3.5,1.4-4.9s2-2.4,3.3-3s2.6-0.9,3.9-0.9
                               C142,9.6,143,9.8,144,10.1z M138.4,14.2c-0.8,0.6-1.3,1.5-1.6,2.6h8.5c-0.2-1.1-0.8-2-1.6-2.6s-1.7-0.9-2.7-0.9
                               C140.1,13.2,139.2,13.5,138.4,14.2z"" />







                <path class=""st6"" d=""M91.1,33.1c0.9,0.4,1.8,0.9,2.");
                WriteLiteral(@"6,1.6s1.4,1.6,1.9,2.8s0.7,2.4,0.7,3.8c0,1.9-0.4,3.5-1.3,4.9s-1.9,2.4-3.1,3
                               s-2.4,0.9-3.7,0.9c-1.2,0-2.3-0.3-3.2-0.9c-0.9-0.6-1.4-1.2-1.6-1.8v8.8h-4.1V32.8h4.2v2.3c0.1-0.6,0.6-1.2,1.5-1.7s2-0.8,3.2-0.8
                               C89.2,32.6,90.2,32.8,91.1,33.1z M90.8,45.1c0.9-0.9,1.4-2.2,1.4-3.8s-0.5-2.8-1.4-3.7s-1.9-1.4-3.1-1.4s-2.2,0.4-3.1,1.3
                               c-0.8,0.8-1.2,2.1-1.2,3.9c0,1.7,0.4,3,1.3,3.9c0.8,0.9,1.8,1.3,3,1.3C88.8,46.5,89.9,46.1,90.8,45.1z"" />







                <path class=""st6"" d=""M109.2,33.1c1,0.4,1.9,0.9,2.8,1.6c0.9,0.7,1.6,1.6,2.2,2.8s0.8,2.5,0.8,3.9c0,1.1-0.2,2.2-0.6,3.2
                               s-0.9,1.8-1.5,2.5s-1.3,1.2-2.1,1.7c-0.8,0.5-1.5,0.8-2.3,1s-1.5,0.3-2.3,0.3s-1.5-0.1-2.3-0.3s-1.6-0.6-2.3-1
                               c-0.8-0.5-1.5-1-2.1-1.7s-1.1-1.5-1.5-2.5s-0.6-2.1-0.6-3.2c0-1.4,0.3-2.7,0.8-3.9c0.6-1.2,1.3-2.1,2.2-2.8
                               c0.9-0.7,1.8-1.2,2.8-1.6s1.9-0.6,2.9-0.6S108.2,32.8");
                WriteLiteral(@",109.2,33.1z M103.2,37.6c-0.9,0.9-1.4,2.2-1.4,3.8s0.5,2.8,1.4,3.8
                               c0.9,0.9,1.9,1.4,3.1,1.4s2.2-0.5,3.1-1.4s1.4-2.2,1.4-3.8s-0.5-2.9-1.4-3.8c-0.9-0.9-1.9-1.4-3.1-1.4S104.1,36.7,103.2,37.6z"" />







                <path class=""st6"" d=""M128.2,32.7v3.9c-0.4,0-0.9-0.1-1.6-0.1c-1.5,0-2.8,0.5-3.8,1.5s-1.6,2.4-1.8,4.1v7.7h-4.2V32.6h4.2V38
                               c0.2-1.7,0.8-3,1.7-4.1s2.3-1.6,4-1.6C127.3,32.6,127.8,32.6,128.2,32.7z"" />







                <path class=""st6"" d=""M135.2,36.2v8.6c0,1.1,0.5,1.6,1.4,1.6c0.8,0,1.5-0.1,2.2-0.4v3.5c-0.8,0.4-1.9,0.6-3.3,0.6s-2.6-0.4-3.4-1.1
                               c-0.8-0.7-1.2-2.1-1.2-4.1v-8.7h-1.8v-3.4h1.8v-3h4.2v3h3.6v3.4L135.2,36.2L135.2,36.2z"" />







                <path class=""st6"" d=""M148.7,30c0.8,0,1.7,0.2,2.6,0.5l1.4-2.9c-1.3-0.7-2.7-1-4-1c-1.4,1.3-3.1,2-5.1,2.2
                               c-0.1,0.1-0.2,0.3-0.3,0.5c-0.4,0.8-0.6,1.8-0.6,2.9v0.6h-2.1v3.6h2.1v13.5h4.2V36.4h4.1v-3.6h-4.1v");
                WriteLiteral(@"-0.5
                               C146.9,30.8,147.5,30,148.7,30z"" />







                <path class=""st6"" d=""M163.2,33.1c1,0.4,1.9,0.9,2.8,1.6c0.9,0.7,1.6,1.6,2.2,2.8c0.6,1.2,0.8,2.5,0.8,3.9c0,1.1-0.2,2.2-0.6,3.2
                               s-0.9,1.8-1.5,2.5s-1.3,1.2-2.1,1.7s-1.5,0.8-2.3,1s-1.5,0.3-2.3,0.3s-1.5-0.1-2.3-0.3s-1.6-0.6-2.3-1c-0.8-0.5-1.5-1-2.1-1.7
                               s-1.1-1.5-1.5-2.5s-0.6-2.1-0.6-3.2c0-1.4,0.3-2.7,0.8-3.9c0.6-1.2,1.3-2.1,2.2-2.8s1.8-1.2,2.8-1.6s1.9-0.6,2.9-0.6
                               S162.2,32.8,163.2,33.1z M157.2,37.6c-0.9,0.9-1.4,2.2-1.4,3.8s0.5,2.8,1.4,3.8c0.9,0.9,1.9,1.4,3.1,1.4s2.2-0.5,3.1-1.4
                               c0.9-0.9,1.4-2.2,1.4-3.8s-0.5-2.9-1.4-3.8c-0.9-0.9-1.9-1.4-3.1-1.4S158.1,36.7,157.2,37.6z"" />







                <path class=""st6"" d=""M174.9,49.9h-4.3V26.8h4.3V49.9z"" />







                <path class=""st6"" d=""M181.6,30.6h-4.3v-3.8h4.3V30.6z M181.6,49.9h-4.3V32.7h4.3V49.9z"" />






");
                WriteLiteral(@"
                <path class=""st6"" d=""M195.2,33.1c1,0.4,1.9,0.9,2.8,1.6c0.9,0.7,1.6,1.6,2.2,2.8c0.6,1.2,0.8,2.5,0.8,3.9c0,1.1-0.2,2.2-0.6,3.2
                               s-0.9,1.8-1.5,2.5s-1.3,1.2-2.1,1.7s-1.5,0.8-2.3,1s-1.5,0.3-2.3,0.3s-1.5-0.1-2.3-0.3s-1.6-0.6-2.3-1c-0.8-0.5-1.5-1-2.1-1.7
                               s-1.1-1.5-1.5-2.5s-0.6-2.1-0.6-3.2c0-1.4,0.3-2.7,0.8-3.9c0.6-1.2,1.3-2.1,2.2-2.8s1.8-1.2,2.8-1.6s1.9-0.6,2.9-0.6
                               S194.2,32.8,195.2,33.1z M189.3,37.6c-0.9,0.9-1.4,2.2-1.4,3.8s0.5,2.8,1.4,3.8c0.9,0.9,1.9,1.4,3.1,1.4s2.2-0.5,3.1-1.4
                               c0.9-0.9,1.4-2.2,1.4-3.8s-0.5-2.9-1.4-3.8c-0.9-0.9-1.9-1.4-3.1-1.4S190.2,36.7,189.3,37.6z"" />







                       </g>
                   </g>
                   </svg>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9322, 80, true);
            WriteLiteral("\r\n            <!-- / Logo --->\r\n            <nav class=\"profile-menu\" data-src=\"");
            EndContext();
            BeginContext(9403, 32, false);
#line 241 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                                           Write(Url.Content("~/Content/Images/"));

#line default
#line hidden
            EndContext();
            BeginContext(9435, 6, true);
            WriteLiteral("\">\r\n\r\n");
            EndContext();
#line 243 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                 if (!SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
            BeginContext(9515, 130, true);
            WriteLiteral("                    <!-- menu drop down -->\r\n                    <div class=\"notificon loginRegister\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9645, "\"", 9683, 1);
#line 247 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 9652, Url.Action("Index","Register"), 9652, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9684, 42, true);
            WriteLiteral("> Giriş </a>\r\n                    </div>\r\n");
            EndContext();
#line 249 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(9786, 39, true);
            WriteLiteral("                    <!-- messages -->\r\n");
            EndContext();
            BeginContext(9827, 520, true);
            WriteLiteral(@"                    <div class=""notificon message ml-4"">
                        <a href=""#"">
                            <i class=""fas fa-envelope""></i>
                            <span class=""badge badge-danger badge-count"">  </span>
                        </a>
                        <div class=""spliter""></div>
                    </div>
                    <ul class=""ul-menu-vertical message-list"">
                        <li>
                            <a href=""#"">
                                ");
            EndContext();
            BeginContext(10347, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71afcc841a25cd9199ed2b936c54c13005cfec8120682", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10400, 301, true);
            WriteLiteral(@"
                                <div class=""spinner-grow"" role=""status"">
                                    <span class=""sr-only d-inline w-auto"">Loading...</span>
                                </div>
                            </a>
                        </li>
                    </ul>
");
            EndContext();
            BeginContext(10703, 109, true);
            WriteLiteral("                    <!-- notifications -->\r\n                    <div class=\"notificon notify ml-3\" data-url=\"");
            EndContext();
            BeginContext(10813, 31, false);
#line 273 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                                                            Write(Url.Action("ReadNotify","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(10844, 358, true);
            WriteLiteral(@""">
                        <a href=""#"">
                            <i class=""fas fa-bell""></i>
                            <span class=""badge badge-danger"">0</span>
                        </a>
                        <div class=""spliter""></div>
                    </div>
                    <ul class=""ul-menu-vertical notification-list"" data-url=""");
            EndContext();
            BeginContext(11203, 37, false);
#line 280 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                                                                        Write(Url.Action("GetNotifications","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(11240, 108, true);
            WriteLiteral("\">\r\n                        <li>\r\n                            <a href=\"#\">\r\n                                ");
            EndContext();
            BeginContext(11348, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71afcc841a25cd9199ed2b936c54c13005cfec8123792", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11401, 301, true);
            WriteLiteral(@"
                                <div class=""spinner-grow"" role=""status"">
                                    <span class=""sr-only d-inline w-auto"">Loading...</span>
                                </div>
                            </a>
                        </li>
                    </ul>
");
            EndContext();
            BeginContext(11704, 309, true);
            WriteLiteral(@"                    <!-- menu opener -->
                    <div class=""notificon menu ml-3"">
                        <a href=""#"">
                            <i class=""fas fa-caret-down""></i>
                        </a>
                        <div class=""spliter""></div>
                    </div>
");
            EndContext();
            BeginContext(12015, 121, true);
            WriteLiteral("                    <ul class=\"ul-menu-vertical menu-list\">\r\n                        <li class=\"profile-link\" data-url =\"");
            EndContext();
            BeginContext(12137, 33, false);
#line 300 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                                                       Write(Url.Action("SendUser","Register"));

#line default
#line hidden
            EndContext();
            BeginContext(12170, 32, true);
            WriteLiteral("\">\r\n                            ");
            EndContext();
            BeginContext(12202, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71afcc841a25cd9199ed2b936c54c13005cfec8126451", async() => {
                BeginContext(12273, 56, true);
                WriteLiteral("\r\n                                <img src=\"\" data-src=\"");
                EndContext();
                BeginContext(12330, 38, false);
#line 302 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                                                 Write(Url.Content("~/Content/Images/Users/"));

#line default
#line hidden
                EndContext();
                BeginContext(12368, 117, true);
                WriteLiteral("\" />\r\n                                <span class=\"u-name pt-2 main-back-color\"></span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12489, 91, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            EndContext();
            BeginContext(12580, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71afcc841a25cd9199ed2b936c54c13005cfec8128819", async() => {
                BeginContext(12652, 159, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-sign-out-alt\"></i>\r\n                                <span>Tənzimləmələr</span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12815, 91, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            EndContext();
            BeginContext(12906, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71afcc841a25cd9199ed2b936c54c13005cfec8130742", async() => {
                BeginContext(12979, 145, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-wrench\"></i>\r\n                                <span>Çıxış</span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13128, 60, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n");
            EndContext();
#line 319 "C:\Users\santa\OneDrive\Desktop\MainProjectFull\MainProjectFull\Views\Shared\_Header.cshtml"
                }

#line default
#line hidden
            BeginContext(13207, 93, true);
            WriteLiteral("\r\n            </nav>\r\n        </div>\r\n    </nav>\r\n    <div class=\"clearfix\"></div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
