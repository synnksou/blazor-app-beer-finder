#pragma checksum "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f6d0528518f83e127fc2735262641c98061b82"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(4);
                __builder2.AddAttribute(5, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                        $"background-color:{Colors.Red.Accent2};"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                                                                               1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(8);
                    __builder3.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 5 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                       (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(14);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "color: white;");
                    __builder3.AddAttribute(18, "b-903ddl0lal");
                    __builder3.OpenComponent<MudBlazor.MudButton>(19);
                    __builder3.AddAttribute(20, "style", "color: white;");
                    __builder3.AddAttribute(21, "Edge", "Edge.End");
                    __builder3.AddAttribute(22, "Link", "/login");
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(24, "Se connecter");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(26);
                    __builder3.AddAttribute(27, "style", "color: white;");
                    __builder3.AddAttribute(28, "Edge", "Edge.End");
                    __builder3.AddAttribute(29, "Link", "/signin");
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, "S\'inscrire");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(33);
                    __builder3.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                              Icons.Material.Filled.MoreVert

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                                                                     Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 12 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                                                                                          Edge.End

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(38);
                __builder2.AddAttribute(39, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                                                   2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
                           _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(43);
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudDivider>(45);
                        __builder4.AddAttribute(46, "Class", "my-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\r\n            <img src=\"assets/logo.png\" asp-append-version=\"true\" width=\"100px\" style=\"margin: auto;\" b-903ddl0lal>");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavMenu>(49);
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(51);
                        __builder4.AddAttribute(52, "Href", "/home");
                        __builder4.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(54, "Accueil");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(55, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(56);
                        __builder4.AddAttribute(57, "Href", "/beer");
                        __builder4.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(59, "Les bieres ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(61);
                        __builder4.AddAttribute(62, "Href", "/fetchdata");
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(64, "Recherche");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(66);
                        __builder4.AddAttribute(67, "Href", "/form-beer");
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(69, "Crée ta biere ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(71);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/NavMenu.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
