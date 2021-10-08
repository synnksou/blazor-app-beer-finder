#pragma checksum "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/AcessControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30c0c6125aa07f80eaf5de43b9399558e2cff110"
// <auto-generated/>
#pragma warning disable 1591
namespace testblazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using testblazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using testblazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/AcessControl.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/AcessControl.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class AcessControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "style", "color: white;");
                __builder2.OpenComponent<MudBlazor.MudButton>(4);
                __builder2.AddAttribute(5, "style", "color: white;");
                __builder2.AddAttribute(6, "Edge", "Edge.End");
                __builder2.AddAttribute(7, "Link", "/login");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(9, "Se connecter");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.OpenComponent<MudBlazor.MudButton>(11);
                __builder2.AddAttribute(12, "style", "color: white;");
                __builder2.AddAttribute(13, "Edge", "Edge.End");
                __builder2.AddAttribute(14, "Link", "/signin");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "S\'inscrire");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(17, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "style", "color: white;");
                __builder2.OpenComponent<MudBlazor.MudButton>(20);
                __builder2.AddAttribute(21, "style", "color: white;");
                __builder2.AddAttribute(22, "Edge", "Edge.End");
                __builder2.AddAttribute(23, "Link", "/login");
                __builder2.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/AcessControl.razor"
                                                                                     BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(26, "Deco");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/AcessControl.razor"
       
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
