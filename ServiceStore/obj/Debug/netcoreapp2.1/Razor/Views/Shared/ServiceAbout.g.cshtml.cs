#pragma checksum "C:\Users\Администратор\Desktop\Projects\ServiceStore\ServiceStore\Views\Shared\ServiceAbout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3467e352c2091fd4978a6af64d755e38f31fb2c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ServiceAbout), @"mvc.1.0.view", @"/Views/Shared/ServiceAbout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ServiceAbout.cshtml", typeof(AspNetCore.Views_Shared_ServiceAbout))]
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
#line 1 "C:\Users\Администратор\Desktop\Projects\ServiceStore\ServiceStore\Views\_ViewImports.cshtml"
using ServiceStore;

#line default
#line hidden
#line 2 "C:\Users\Администратор\Desktop\Projects\ServiceStore\ServiceStore\Views\_ViewImports.cshtml"
using ServiceStore.Models;

#line default
#line hidden
#line 4 "C:\Users\Администратор\Desktop\Projects\ServiceStore\ServiceStore\Views\_ViewImports.cshtml"
using ServiceStore.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Администратор\Desktop\Projects\ServiceStore\ServiceStore\Views\_ViewImports.cshtml"
using ServiceStore.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3467e352c2091fd4978a6af64d755e38f31fb2c3", @"/Views/Shared/ServiceAbout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ea2c26992f20aa68c67267c6af7cf325829459", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ServiceAbout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 19, true);
            WriteLiteral("<h1>Услуги</h1>\r\n\r\n");
            EndContext();
            BeginContext(36, 53, false);
#line 4 "C:\Users\Администратор\Desktop\Projects\ServiceStore\ServiceStore\Views\Shared\ServiceAbout.cshtml"
Write(await Html.PartialAsync("ServiceAbout.cshtml", Model));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
