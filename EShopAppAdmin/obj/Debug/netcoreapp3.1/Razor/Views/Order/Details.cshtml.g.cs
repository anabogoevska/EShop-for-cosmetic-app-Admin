#pragma checksum "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e9108bb32214e1a1a75357e312ccaa48d84c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\_ViewImports.cshtml"
using EShopAppAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\_ViewImports.cshtml"
using EShopAppAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e9108bb32214e1a1a75357e312ccaa48d84c01", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28f803fb4e8d70fcca7bc82b73b69efb5d9cab12", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShopAppAdmin.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <p>\r\n        <a class=\"btn btn-warning\">");
#nullable restore
#line 13 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                              Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                                                  Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                                                                        Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </p>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
     for (int i = 0; i < Model.ProductInOrders.Count(); i++)
    {
        var item = Model.ProductInOrders.ElementAt(i);

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card\" style=\"width: 20rem; height: 35rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 693, "\"", 725, 1);
#nullable restore
#line 27 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
WriteAttributeValue("", 699, item.Product.ProductImage, 699, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 50%;\" alt=\"Image for product!\">\r\n\r\n                    <div class=\"card-body\">\r\n                        <h3 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                                          Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                                        Write(item.Product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                        <h6>Price: $");
#nullable restore
#line 34 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                               Write(item.Product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6>Quantity: ");
#nullable restore
#line 35 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                                 Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6>Total: $");
#nullable restore
#line 36 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
                                Write(item.Product.ProductPrice * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"


            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 46 "C:\Users\USER\source\repos\EShopAppAdmin\EShopAppAdmin\Views\Order\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShopAppAdmin.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591