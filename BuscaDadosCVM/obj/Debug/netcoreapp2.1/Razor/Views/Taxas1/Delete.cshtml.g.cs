#pragma checksum "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018df369e4586a72606943cbfab1288c3e606d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Taxas1_Delete), @"mvc.1.0.view", @"/Views/Taxas1/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Taxas1/Delete.cshtml", typeof(AspNetCore.Views_Taxas1_Delete))]
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
#line 1 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\_ViewImports.cshtml"
using BuscaDadosCVM;

#line default
#line hidden
#line 2 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\_ViewImports.cshtml"
using BuscaDadosCVM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018df369e4586a72606943cbfab1288c3e606d3b", @"/Views/Taxas1/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11b89e0e9ed4d551ded87d4c19f73658b3e42b21", @"/Views/_ViewImports.cshtml")]
    public class Views_Taxas1_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuscaDadosCVM.Models.Taxa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Taxa</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(244, 52, false);
#line 15 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AnoMesDivulgacao));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(340, 48, false);
#line 18 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AnoMesDivulgacao));

#line default
#line hidden
            EndContext();
            BeginContext(388, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(432, 50, false);
#line 21 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataImportacao));

#line default
#line hidden
            EndContext();
            BeginContext(482, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(526, 46, false);
#line 24 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataImportacao));

#line default
#line hidden
            EndContext();
            BeginContext(572, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(616, 46, false);
#line 27 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CNPJ_FUNDO));

#line default
#line hidden
            EndContext();
            BeginContext(662, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(706, 42, false);
#line 30 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CNPJ_FUNDO));

#line default
#line hidden
            EndContext();
            BeginContext(748, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(792, 45, false);
#line 33 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DT_COMPTC));

#line default
#line hidden
            EndContext();
            BeginContext(837, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(881, 41, false);
#line 36 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DT_COMPTC));

#line default
#line hidden
            EndContext();
            BeginContext(922, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(966, 44, false);
#line 39 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VL_TOTAL));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1054, 40, false);
#line 42 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VL_TOTAL));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1138, 44, false);
#line 45 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VL_QUOTA));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1226, 40, false);
#line 48 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VL_QUOTA));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1310, 49, false);
#line 51 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VL_PATRIM_LIQ));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1403, 45, false);
#line 54 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VL_PATRIM_LIQ));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1492, 45, false);
#line 57 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CAPTC_DIA));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1581, 41, false);
#line 60 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CAPTC_DIA));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1666, 44, false);
#line 63 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RESG_DIA));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1754, 40, false);
#line 66 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RESG_DIA));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1838, 44, false);
#line 69 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NR_COTST));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1926, 40, false);
#line 72 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NR_COTST));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2004, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eca5adcc26ff4c529f112da1abbe8fd4", async() => {
                BeginContext(2030, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2040, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71007c642e924d0e8548cd0c1fb45911", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\Camila\Documents\COISAS RAFAEL\Workspace-codigos\BuscaDadosCVM\BuscaDadosCVM\Views\Taxas1\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2076, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2160, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bb924858cf34082aa8a6e34350774e9", async() => {
                    BeginContext(2182, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2198, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(2211, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuscaDadosCVM.Models.Taxa> Html { get; private set; }
    }
}
#pragma warning restore 1591
