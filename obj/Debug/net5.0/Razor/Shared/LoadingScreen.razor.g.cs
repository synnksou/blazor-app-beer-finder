#pragma checksum "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/LoadingScreen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc254b6b03a443897c76cf57f2eb388767b4a9ec"
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
#line 12 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    public partial class LoadingScreen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/LoadingScreen.razor"
 if (isLoaded)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 3 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/LoadingScreen.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 3 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/LoadingScreen.razor"
                 
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, @"<div class=""bodybox""><div class=""boxes""><div class=""box""><div></div>
            <div></div>
            <div></div>
            <div></div></div>
        <div class=""box""><div></div>
            <div></div>
            <div></div>
            <div></div></div>
        <div class=""box""><div></div>
            <div></div>
            <div></div>
            <div></div></div>
        <div class=""box""><div></div>
            <div></div>
            <div></div>
            <div></div></div></div></div>");
#nullable restore
#line 35 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/LoadingScreen.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Shared/LoadingScreen.razor"
       
    bool isLoaded;

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(1500);
        isLoaded = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
