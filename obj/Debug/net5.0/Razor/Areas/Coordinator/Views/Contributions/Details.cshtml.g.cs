#pragma checksum "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbb11537a6accce1a4072d03a40291340914fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Coordinator_Views_Contributions_Details), @"mvc.1.0.view", @"/Areas/Coordinator/Views/Contributions/Details.cshtml")]
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
#line 1 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\_ViewImports.cshtml"
using TCS2010PPTG4.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\_ViewImports.cshtml"
using TCS2010PPTG4.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\_ViewImports.cshtml"
using TCS2010PPTG4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cbb11537a6accce1a4072d03a40291340914fc0", @"/Areas/Coordinator/Views/Contributions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2672e1e86f0c44dd13c4bd4ae30aa4ccc06432eb", @"/Areas/Coordinator/_ViewImports.cshtml")]
    public class Areas_Coordinator_Views_Contributions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCS2010PPTG4.Models.Contribution>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "contributionStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Mark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Coordinator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Topics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var comments = (List<Comment>)ViewData["Comments"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc07543", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <style>
        .overflow {
            overflow: scroll;
            width: 1000px;
            height: 300px;
            background: white;
        }

        body {
            background: linear-gradient(0.25turn, #ebf8e1, #4fd18e, #ebf8e1);
        }

        table {
            border-collapse: collapse;
        }

        th, td {
            text-align: left;
            padding: 8px;
        }

        th {
            background-color: #4CAF50;
            color: white;
        }

        select {
            padding: 5px;
        }

        * {
            margin: 5px;
        }

        .button:hover {
            background-color: #3e8e41
        }

        .button:active {
            background-color: #3e8e41;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

        textarea {
            width: 800px;
");
                WriteLiteral("            height: 50px;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc09629", async() => {
                WriteLiteral("\r\n\r\n    <h1> Detail Contributions </h1>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc010010", async() => {
                    WriteLiteral("\r\n                <table class=\"table table-dark table-hover\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th> ");
#nullable restore
#line 73 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                            Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th>  ");
#nullable restore
#line 76 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                             Write(Html.DisplayNameFor(model => model.Contributor));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th>");
#nullable restore
#line 79 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</th>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>");
#nullable restore
#line 87 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td>");
#nullable restore
#line 90 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Contributor.Email));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td>");
#nullable restore
#line 93 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Topic.Title));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                    </tbody>\r\n                </table>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc014410", async() => {
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"contributionId\"");
                    BeginWriteAttribute("value", " value=\"", 2805, "\"", 2822, 1);
#nullable restore
#line 103 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
WriteAttributeValue("", 2813, Model.Id, 2813, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc015152", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 104 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 104 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<ContributionStatus>();

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
        <button style=""padding: 5px 10px; font-size: 20px; text-align: center; cursor: pointer; outline: none; color: #fff;
         background-color: #4CAF50; border: none; border-radius: 15px; box-shadow: 0 5px #999; margin-bottom: 20px;"" type=""submit"">
            Mark
        </button>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 111 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
     foreach (var file in Model.Files)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 3341, "\"", 3357, 1);
#nullable restore
#line 114 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
WriteAttributeValue("", 3348, file.URL, 3348, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("download", " download=\"", 3358, "\"", 3378, 1);
#nullable restore
#line 114 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
WriteAttributeValue("", 3369, file.URL, 3369, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
#nullable restore
#line 115 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
           Write(System.IO.Path.GetFileName(file.URL));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 118 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"overflow\">\r\n");
#nullable restore
#line 120 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
         if (comments != null)
        {
            foreach (var comment in comments)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 125 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
               Write(comment.User.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 125 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                                    Write(comment.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(") : ");
#nullable restore
#line 125 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                                                     Write(comment.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 127 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc022147", async() => {
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"contributionId\"");
                    BeginWriteAttribute("value", " value=\"", 3856, "\"", 3873, 1);
#nullable restore
#line 131 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
WriteAttributeValue("", 3864, Model.Id, 3864, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
        <textarea name=""commentContent""></textarea>
        <p></p>
        <button style=""padding: 5px 10px; font-size: 20px; text-align: center; cursor: pointer; outline: none; color: #fff;
          background-color: #4CAF50; border: none; border-radius: 15px; box-shadow: 0 5px #999;"" type=""submit"">
            Comment
        </button>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <p></p>\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc024511", async() => {
                    WriteLiteral("Save");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cbb11537a6accce1a4072d03a40291340914fc027360", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-topicId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\Admin\Downloads\FrontEnd\TCS2010PPTG4\Areas\Coordinator\Views\Contributions\Details.cshtml"
                                                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["topicId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-topicId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["topicId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCS2010PPTG4.Models.Contribution> Html { get; private set; }
    }
}
#pragma warning restore 1591
