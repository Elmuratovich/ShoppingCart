#pragma checksum "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Pages\Master.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58bb9d092b48b43954e61a4fd214111154204d23a8326573884d25ee2b4b6e3e"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Admin.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/master")]
    public partial class Master : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Master</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Angular\Blazor Projects\ShoppingCart\ShoppingCart\Shop.Admin\Pages\Master.razor"
       
    [CascadingParameter]
    public EventCallback notify { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await notify.InvokeAsync();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
