#pragma checksum "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c005a569b1e1d208535bea7dc857211598e5f326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_jobdetail_Details), @"mvc.1.0.view", @"/Views/jobdetail/Details.cshtml")]
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
#line 1 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\_ViewImports.cshtml"
using applynowcrudmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\_ViewImports.cshtml"
using applynowcrudmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c005a569b1e1d208535bea7dc857211598e5f326", @"/Views/jobdetail/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d1a3e6d0b3a0459d48b25b58d5d159c9b5862b", @"/Views/_ViewImports.cshtml")]
    public class Views_jobdetail_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<applynowcrud.Models.JobDetailmvc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/detail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/images/building-on-crescent-4303ld.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c005a569b1e1d208535bea7dc857211598e5f3265143", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.1/css/all.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <script src='https://kit.fontawesome.com/a076d05399.js' crossorigin='anonymous'></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c005a569b1e1d208535bea7dc857211598e5f3266165", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c005a569b1e1d208535bea7dc857211598e5f3268047", async() => {
                WriteLiteral(@"
    <main class=""jdbgcolor"">

        <div class=""jdbgimg border"">
            <div class=""d-flex align-items-center "">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-12"">
                            <div class=""hero-cap text-center"">
                                <h2 class=""jdtext"">");
#nullable restore
#line 26 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Companyname));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class=""container"">
                <div class=""row justify-content-between"">
                    <!-- Left Content -->
                    <div class=""col-xl-8 col-lg-9"">
                        <!-- job single -->
                        <div class=""jdbgcolor1"">
                            <div class=""jdflex jdmargin jdbox"">
                                <div>
                                    <a href=""#"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c005a569b1e1d208535bea7dc857211598e5f3269669", async() => {
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
                WriteLiteral("\r\n                                    </a>\r\n                                </div>\r\n                                <div>\r\n                                    <div class=\"jdjobname\">\r\n                                        <b><h4 class=\"jdtext\">");
#nullable restore
#line 48 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                         Write(Html.DisplayFor(model => model.JobCategory));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4></b>\r\n                                    </div>\r\n                                    <ul class=\"jdflex\">\r\n                                        <li class=\"jdpadding\"><span class=\"fas fa-hotel\"></span>");
#nullable restore
#line 51 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                                                           Write(Html.DisplayFor(model => model.Companyname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                        <li class=\"jdpadding\"><i class=\"fas fa-map-marker-alt\"></i>");
#nullable restore
#line 52 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                                                              Write(Html.DisplayFor(model => model.JobLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                        <li class=\"jdpadding\">$");
#nullable restore
#line 53 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    </ul>\r\n");
                WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <!-- job single End -->

                        <div class=""jdbox jdbgcolor1 jdboxdes"">
                            <div class=""jdmargin"">
                                <!-- Small Section Tittle -->
                                <div class=""small-section-tittle"">
                                    <h4 class=""jdtext""><b>Job Description</b></h4>
                                </div>
                                <p>");
#nullable restore
#line 67 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                              Write(Html.DisplayFor(model => model.JobDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                            <div class=""jdmargin"">
                                <!-- Small Section Tittle -->
                                <div class=""small-section-tittle"">
                                    <h4 class=""jdtext""><b>Required Knowledge, Skills, and Abilities</b></h4>
                                </div>
                                <ul>
                                    <li>");
#nullable restore
#line 75 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Requiredskills));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                                    <li>System Software Development</li>
                                    <li>Mobile Applicationin iOS/Android/Tizen or other platform</li>
                                    <li>Research and code , libraries, APIs and frameworks</li>
                                    <li>Strong knowledge on software development life cycle</li>
                                    <li>Strong problem solving and debugging skills</li>
                                </ul>
                            </div>
                            <div class=""jdmargin"">
                                <!-- Small Section Tittle -->
                                <div class=""small-section-tittle"">
                                    <h4 class=""jdtext""><b>Education + Experience</b></h4>
                                </div>
                                <ul>
                                    <li>");
#nullable restore
#line 89 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Experience));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                                    <li>3 or more years of professional design experience</li>
                                    <li>Direct response email experience</li>
                                    <li>Ecommerce website design experience</li>
                                    <li>Familiarity with mobile and web apps preferred</li>
                                    <li>Experience using Invision a plus</li>
                                </ul>
                            </div>
                        </div>

                    </div>
                    <!-- Right Content -->
                    <div class=""col-xl-4 col-lg-4 "">
                        <div class=""jdmargin jdpadding jdbgcolor1 jdbox"">
                            <!-- Small Section Tittle -->
                            <div>
                                <h4 class=""jdtext""><b>Job Overview</b></h4>
                            </div>
                            <div>
                                <div");
                WriteLiteral(" class=\"jdflex jdjoboverview\"><label class=\"jdspace1\">End date : </label><span class=\"jdspace\">");
#nullable restore
#line 108 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                                                                                              Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                <div class=\"jdflex jdjoboverview\"><label class=\"jdspace1\">Location : </label><span class=\"jdspace\">");
#nullable restore
#line 109 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                                                                                              Write(Html.DisplayFor(model => model.JobLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                <div class=\"jdflex jdjoboverview\"><label class=\"jdspace1\">Vacancy : </label><span class=\"jdspace\">");
#nullable restore
#line 110 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                                                                                             Write(Html.DisplayFor(model => model.NoOfVacancies));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                <div class=\"jdflex jdjoboverview\"><label class=\"jdspace1\">Job nature : </label><span class=\"jdspace\">");
#nullable restore
#line 111 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                                                                                                Write(Html.DisplayFor(model => model.JobType));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                <div class=\"jdflex jdjoboverview\"><label class=\"jdspace1\">Salary :  </label><span class=\"jdspace\">$");
#nullable restore
#line 112 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                                                                                              Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
                WriteLiteral(" yearly</span></div>\r\n                                \r\n");
                WriteLiteral("                            </div>\r\n                            <div class=\"text-center\">\r\n                                ");
#nullable restore
#line 117 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                           Write(Html.ActionLink("Apply Now", "Create","applynow", new { id = Model.JobDetailsId }, new { @class = "jdbtn jdbtn1 text-decoration-none" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n");
                WriteLiteral(@"                            </div>
                        </div>
                        <!-- Small Section Tittle -->Create
                        <div class=""jdbgcolor1 jdbox jdjobdes"">
                            <div class=""jdjobdes"">
                                <h4 class=""jdtext""><b>Company Information</b></h4>
                            </div>
                            <span class=""thead-dark"">Colorlib</span>
                            <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                            <ul>
                                <li>Name: <span>");
#nullable restore
#line 130 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.Companyname));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></li>\r\n                                <li>Web : <span> ");
#nullable restore
#line 131 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Companyname));

#line default
#line hidden
#nullable disable
                WriteLiteral("ltd.com</span></li>\r\n                                <li>Email: <span>");
#nullable restore
#line 132 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                <li>Phone Number: <span>");
#nullable restore
#line 133 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.PhNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                <li>Location: <span>");
#nullable restore
#line 134 "C:\Users\Merit\Desktop\jobdetails\applynowcrud\applynowcrudmvc\Views\jobdetail\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.CompanyAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- job post company End -->

    </main>
    <script>
        $(document).ready(function () {
            var id = ""10"";
            $('#a_tag_id').attr('href', 'https://localhost:44303/applynow/Create&jobid=' + id);
        });
    </script>
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<applynowcrud.Models.JobDetailmvc> Html { get; private set; }
    }
}
#pragma warning restore 1591