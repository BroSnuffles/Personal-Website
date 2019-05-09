#pragma checksum "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c53713079d382fec8d628db99fcf47fa30d11b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Software), @"mvc.1.0.view", @"/Views/Home/Software.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Software.cshtml", typeof(AspNetCore.Views_Home_Software))]
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
#line 1 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\_ViewImports.cshtml"
using Personal_Website_ASPNET.Controllers;

#line default
#line hidden
#line 2 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\_ViewImports.cshtml"
using Personal_Website_ASPNET.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c53713079d382fec8d628db99fcf47fa30d11b5", @"/Views/Home/Software.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ba445a5bf013aa4757eb368b49ea51fbdbd8d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Software : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GithubViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/software.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 384, true);
            WriteLiteral(@"
<div id=""sw"">
    <h2>Software</h2>
    <p>Here is a table of all my Software projects that i have built and made public on my GitHub profile.</p>
    <pre></pre>
    <table id=""SoftwareTbl"">
        <tr>
            <th>Project</th>
            <th>Description</th> 
            <th>Language</th>
            <th>Size (Kb)</th>
            <th>Stars</th>
        </tr>
");
            EndContext();
#line 15 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
         foreach (var item in Model)
        {       

#line default
#line hidden
            BeginContext(477, 40, true);
            WriteLiteral("            <tr>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href= \"", 517, "\"", 572, 1);
            WriteAttributeValue("", 525, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                
                BeginContext(528, 43, false);
#line 18 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
                           Write(Html.DisplayFor(modelItem => item.html_url));

#line default
#line hidden
                EndContext();
                                                                                            
                PopWriter();
            }
            ), 525, 47, false);
            EndWriteAttribute();
            BeginContext(573, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(591, 39, false);
#line 18 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(630, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(662, 46, false);
#line 19 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
               Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
            EndContext();
            BeginContext(708, 28, true);
            WriteLiteral("</td> \r\n                <td>");
            EndContext();
            BeginContext(737, 43, false);
#line 20 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
               Write(Html.DisplayFor(modelItem => item.language));

#line default
#line hidden
            EndContext();
            BeginContext(780, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(808, 39, false);
#line 21 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
               Write(Html.DisplayFor(modelItem => item.size));

#line default
#line hidden
            EndContext();
            BeginContext(847, 28, true);
            WriteLiteral("</td> \r\n                <td>");
            EndContext();
            BeginContext(876, 51, false);
#line 22 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
               Write(Html.DisplayFor(modelItem => item.stargazers_count));

#line default
#line hidden
            EndContext();
            BeginContext(927, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\JasonD\Documents\Projects\Kizmeta\Personal-Website-ASPNET\Views\Home\Software.cshtml"
        }

#line default
#line hidden
            BeginContext(964, 1631, true);
            WriteLiteral(@"    </table>
</div>

<div id=""tech"" style=""margin-top: 5%; "">
    <h2 style=""text-align:center;"">TECHNOLOGY STACK</h2>
    <h5 style=""text-align:center;"">BRIEF OVERVIEW OF THE ARCHITECTURE OF MY WEBSITE</h5>
    <br/>
    <div class=""soft"">
        <div id=""Front"" class=""threediff"">
            <h2>Front-End</h2>
            <h5>HTML5 + CSS3 + Javascript</h5>
            <pre></pre>
            <ul>
                <li>HTML and CSS to design and style the webpages.</li>
                <li>Integrated C# ding into HTML.</li>
                <li>Javascript to dynamically display html elements.</li>
                <li>Using c# to render the body of each view.</li>
            </ul>
        </div>
    <div id=""back"" class=""threediff"">
         <h2>Back-End</h2>
            <h5>ASP.NET Core + MVC</h5>
            <pre></pre>
            <ul>
                <li>C# for controllers to handle page requests.</li>
                <li>C# for ViewModels and Storing Json string values for table.<");
            WriteLiteral(@"/li>
                <li>C# for handling Email Actions.</li>
                <li>Used for business logic, automation, large data and web APIs</li>
                <li>ASP.NET Core MVC is my main focus</li>
            </ul>
        </div>
    <div id=""deploy"" class=""threediff"">
         <h2>Deployment</h2>
            <h5>Docker</h5>
            <pre></pre>
            <ul>
                <li>Docker Container for each MicroService.</li>
                <li>Nginx Controller connects the microservices together.</li>
            </ul>
        </div>
    </div>
    </div>
</div>

    ");
            EndContext();
            BeginContext(2595, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c53713079d382fec8d628db99fcf47fa30d11b510088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(2666, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2672, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c53713079d382fec8d628db99fcf47fa30d11b511355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GithubViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591