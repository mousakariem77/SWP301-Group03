#pragma checksum "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Course), @"mvc.1.0.view", @"/Views/Admin/Course.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Group03_Project\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a7", @"/Views/Admin/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9414e8f56e2cc2d04e73044b10dc6e2cfbadc9fd54b07a1fac15f562fe514924", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<WebLibrary.Models.Course>, List<WebLibrary.Models.Category>, 
    List<WebLibrary.Models.Instruct>, List<WebLibrary.Models.Instructor>>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-search d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/course/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a78404", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a79542", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
  
    String iconClass = "";
    if(ViewBag.IconClass == "bxs-down-arrow")
    {
        iconClass = "bxs-up-arrow";
    }else{
        iconClass = "bxs-down-arrow";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card bg-theme p-0 mt-2 mb-5\" >\r\n    <div class=\"container no-footer mt-5 mb-3 p-0\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-6\">\r\n                <div class=\"container-fluid\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a711298", async() => {
                WriteLiteral("\r\n                        <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 885, "\"", 908, 1);
#nullable restore
#line 26 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 893, ViewBag.search, 893, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""search"" name=""search"" placeholder=""Search"">
                        <button class=""btn btn-primary btn-outline-primary ml-2"" type=""submit"">
                            <i class='bx bx-search-alt-2'></i>
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-12 col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a713522", async() => {
                WriteLiteral("Add new");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    
    <div class=""container p-0 mt-3"">
        <table class=""datatables-basic table mb-5"">
            <thead>
                <tr>
                    <th width=""10""><input type=""checkbox"" id=""all"" class=""checkbox-item""></th>
                    <th width=""250"" class=""text-theme"">Course Name</th>
                    <th width=""170"" class=""text-theme"">Category</th>
                    <th width=""120"" class=""text-theme"">Instructor</th>
                    <th width=""90"" class=""text-theme"">Price</th>
                    <th width=""50"" class=""text-theme"">Status</th>
                    <th width=""70"" class=""text-theme"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 53 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                 foreach (var course in Model.Item1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=\"", 2195, "\"", 2203, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td class=\"  dt-checkboxes-cell\">\r\n                            <input type=\"checkbox\">\r\n                        </td>\r\n                        <td class=\"text-theme\">");
#nullable restore
#line 58 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                          Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                         foreach(var category in Model.Item2){
                            if(category.CategoryId == course.CategoryId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"text-theme\">");
#nullable restore
#line 61 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                  Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 62 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                         foreach(var instructor in Model.Item4){
                            foreach(var instruct in Model.Item3){
                                if(course.CourseId == instruct.CourseId && instructor.InstructorId == instruct.InstructorId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"text-theme\">");
#nullable restore
#line 67 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                      Write(instructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 67 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                                            Write(instructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 68 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-theme\">");
#nullable restore
#line 71 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                          Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <span class=\"badge bg-label-success text-theme\">");
#nullable restore
#line 73 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                                       Write(course.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td class=\"text-theme\">\r\n                            <div class=\"action-icon d-flex text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a719442", async() => {
                WriteLiteral("\r\n                                    <i class=\'bx bxs-edit\'></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                                                    WriteLiteral(course.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4318acdf452289e97639ef75a22becb757a748d553f83023260ccab1cb307a721946", async() => {
                WriteLiteral("\r\n                                    <i class=\'bx bxs-trash-alt\'></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                                                WriteLiteral(course.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 86 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"7\">\r\n                            <div class=\"mt-3 text-theme\">\r\n                                 Showing 1 to ");
#nullable restore
#line 90 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                         Write(ViewBag.PageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 90 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                              Write(ViewBag.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" entries\r\n                            </div>\r\n                            <ul class=\"pagination ml-5 justify-content-end\" style=\"margin-top: -10px;\">\r\n");
#nullable restore
#line 93 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                 if (ViewBag.CurrentPage > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4674, "\"", 4726, 2);
            WriteAttributeValue("", 4681, "/course/index?page=", 4681, 19, true);
#nullable restore
#line 96 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 4700, ViewBag.CurrentPage - 1, 4700, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n                                    </li>\r\n");
#nullable restore
#line 98 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                 for(int i = 1; i <= ViewBag.TotalPages; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item \">\r\n                                        <a");
            BeginWriteAttribute("class", " class=\"", 5037, "\"", 5113, 2);
            WriteAttributeValue("", 5045, "page-link", 5045, 9, true);
#nullable restore
#line 102 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue(" ", 5054, ViewBag.CurrentPage == i ? "bg-primary text-white" : "", 5055, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 5114, "\"", 5142, 2);
            WriteAttributeValue("", 5121, "/course/index?page=", 5121, 19, true);
#nullable restore
#line 102 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 5140, i, 5140, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 102 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                                                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 104 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                 if (ViewBag.CurrentPage < ViewBag.TotalPages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5465, "\"", 5517, 2);
            WriteAttributeValue("", 5472, "/course/index?page=", 5472, 19, true);
#nullable restore
#line 108 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
WriteAttributeValue("", 5491, ViewBag.CurrentPage + 1, 5491, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n                                    </li>\r\n");
#nullable restore
#line 110 "D:\Group03_Project\Project_Group3\Views\Admin\Course.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </td>\r\n                    </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<WebLibrary.Models.Course>, List<WebLibrary.Models.Category>, 
    List<WebLibrary.Models.Instruct>, List<WebLibrary.Models.Instructor>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
