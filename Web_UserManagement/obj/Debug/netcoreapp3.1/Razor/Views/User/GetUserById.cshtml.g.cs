#pragma checksum "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bccaf6b9ed3f38c044b73ae8998a72c55eee111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetUserById), @"mvc.1.0.view", @"/Views/User/GetUserById.cshtml")]
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
#line 1 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\_ViewImports.cshtml"
using MVC_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\_ViewImports.cshtml"
using MVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bccaf6b9ed3f38c044b73ae8998a72c55eee111", @"/Views/User/GetUserById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50cfe5b2535a5ae55c5a8ee0de5bb4c7bef7f708", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetUserById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_UI.Models.UserDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
  
    ViewData["Title"] = "GetUserById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetUserById</h1>\r\n\r\n<div>\r\n    <h4>UserDetails</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.UserPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.UserPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayNameFor(model => model.UserAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
       Write(Html.DisplayFor(model => model.UserAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 76 "C:\Users\Maragani jagadeesh\Contacts\Desktop\CasrStudy@CouponManagement\CouponsManagement\MVC_UI\Views\User\GetUserById.cshtml"
Write(Html.ActionLink("Edit", "UpdateUser", new { id = Model.UserId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bccaf6b9ed3f38c044b73ae8998a72c55eee11111683", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_UI.Models.UserDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
