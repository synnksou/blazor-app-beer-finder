// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace testblazor.Pages
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
#nullable restore
#line 3 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Pages/FormBeer.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Pages/FormBeer.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/form-beer")]
    public partial class FormBeer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/antoine/Documents/Cours/NetCore/projet/testblazor/Pages/FormBeer.razor"
       

    bool success;
    string[] errors = { };
    private bool autoClose;
    private bool readOnly;
    public string NameFieldValue;
    public string TaglineFieldValue;

    public string type;


    private Beer beer;

    MudTextField<string> pwField1;
    MudForm form;

    MudDatePicker _picker;
    DateTime? date = DateTime.Today;
    private string errorMessage;

    public async void postBeer()
    {
        beer = new Beer(NameFieldValue, TaglineFieldValue, "ipa", "descrpition", DateTime.Now, 8, "test");
        using var response = await Http.PostAsJsonAsync("https://localhost:5002/api/beer", beer);
        if (!response.IsSuccessStatusCode)
        {
            errorMessage = response.ReasonPhrase;
            Console.WriteLine($"There was an error! {errorMessage}");
            return;
        }
        else
        {
            errorMessage = "C DANS LA BDD WSHHHHH";
        }
        var toto = await response.Content.ReadFromJsonAsync<Beer>();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
