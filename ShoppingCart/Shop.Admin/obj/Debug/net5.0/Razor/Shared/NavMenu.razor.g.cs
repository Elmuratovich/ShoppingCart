#pragma checksum "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4f2c8a3523f6d83d7967911cb3a8669f2e67bc03b44bbcb73dcc0a2717e2e8e1"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Admin.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-j48ws9vj9f");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-j48ws9vj9f>Shop.Admin</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-j48ws9vj9f");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-j48ws9vj9f></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-j48ws9vj9f");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-j48ws9vj9f");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-j48ws9vj9f");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("nav-link"));
            __builder.AddAttribute(22, "href", (object)(""));
            __builder.AddAttribute(23, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-j48ws9vj9f></span> Dashboard\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-j48ws9vj9f");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", (object)("nav-link"));
            __builder.AddAttribute(32, "href", (object)("category"));
            __builder.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-j48ws9vj9f></span> Category\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-j48ws9vj9f");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", (object)("nav-link"));
            __builder.AddAttribute(41, "href", (object)("products"));
            __builder.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-j48ws9vj9f></span> Products\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n          ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item px-3");
            __builder.AddAttribute(47, "b-j48ws9vj9f");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", (object)("nav-link"));
            __builder.AddAttribute(50, "href", (object)("stock"));
            __builder.AddAttribute(51, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-j48ws9vj9f></span> Stock\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n          ");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "nav-item px-3");
            __builder.AddAttribute(56, "b-j48ws9vj9f");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "class", (object)("nav-link"));
            __builder.AddAttribute(59, "href", (object)("orders"));
            __builder.AddAttribute(60, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-j48ws9vj9f></span> Orders\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "li");
            __builder.AddAttribute(64, "class", "nav-item px-3");
            __builder.AddAttribute(65, "b-j48ws9vj9f");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(66);
            __builder.AddAttribute(67, "class", (object)("nav-link"));
            __builder.AddAttribute(68, "href", (object)("master"));
            __builder.AddAttribute(69, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-j48ws9vj9f></span> Master\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
