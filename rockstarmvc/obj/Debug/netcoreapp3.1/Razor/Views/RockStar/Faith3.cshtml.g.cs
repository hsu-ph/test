#pragma checksum "/Users/xupeihan/Documents/CSYE7220/Lecture 2/dotnetlabs/rockstarmvc/Views/RockStar/Faith3.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4fe988a7b5288155c4bbb801735cdf766c2edd8d44e2cb4fd8587b4c4a45cca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RockStar_Faith3), @"mvc.1.0.view", @"/Views/RockStar/Faith3.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/xupeihan/Documents/CSYE7220/Lecture 2/dotnetlabs/rockstarmvc/Views/_ViewImports.cshtml"
using rockstarmvc

#nullable disable
    ;
#nullable restore
#line 2 "/Users/xupeihan/Documents/CSYE7220/Lecture 2/dotnetlabs/rockstarmvc/Views/_ViewImports.cshtml"
using rockstarmvc.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4fe988a7b5288155c4bbb801735cdf766c2edd8d44e2cb4fd8587b4c4a45cca8", @"/Views/RockStar/Faith3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"51922c44f4607751808c22ae9f3565f5d900a635f92c614fc0c8417302f4e075", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RockStar_Faith3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/xupeihan/Documents/CSYE7220/Lecture 2/dotnetlabs/rockstarmvc/Views/RockStar/Faith3.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fe988a7b5288155c4bbb801735cdf766c2edd8d44e2cb4fd8587b4c4a45cca83631", async() => {
                WriteLiteral("\r\n<style>\r\nbody {background-color: green;}\r\nh1   {color: blue;}\r\np    {color: red;}\r\n.myDiv {\r\n  border: 5px outset red;\r\n  background-color: lightblue;\r\n  text-align: center;\r\n}\r\n</style>\r\n");
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
            WriteLiteral("\r\n<script>\r\n    window.onload = function() {\r\n        document.getElementById(\'myDiv2\').innerHTML = \'");
            Write(
#nullable restore
#line 21 "/Users/xupeihan/Documents/CSYE7220/Lecture 2/dotnetlabs/rockstarmvc/Views/RockStar/Faith3.cshtml"
                                                        ViewData["html"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\'\r\n    };\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fe988a7b5288155c4bbb801735cdf766c2edd8d44e2cb4fd8587b4c4a45cca85259", async() => {
                WriteLiteral("\r\n\r\n<div class=\"myDiv\">\r\n<pre>\r\n  ");
                Write(
#nullable restore
#line 28 "/Users/xupeihan/Documents/CSYE7220/Lecture 2/dotnetlabs/rockstarmvc/Views/RockStar/Faith3.cshtml"
   ViewData["html"]

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n</pre>\r\n</div>\r\n\r\n<div id=\"myDiv2\">Placeholder</div>\r\n\r\n");
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
