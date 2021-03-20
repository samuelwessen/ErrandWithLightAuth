// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using SharedLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using SharedLibrary.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/errands")]
    public partial class Errands : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "c:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\Errands.razor"
       
    private CreateErrandModel createErrand;
    private IEnumerable<ErrandModel> errands;

    public ServiceWorker serviceWorker { get; set; } = new ServiceWorker();
    public string ServiceWorkerId { get; set; }
    public IEnumerable<ServiceWorker> serviceWorkers { get; set; } = new List<ServiceWorker>();


    private async Task CreateErrandAsync()
    {
        await Http.PostAsJsonAsync<CreateErrandModel>("https://localhost:44308/api/Errands/create", createErrand);
        createErrand = new CreateErrandModel();
        await GetAllErrandsAsync();
    }


    public async Task GetAllErrandsAsync()
    {
        errands = await Http.GetFromJsonAsync<IEnumerable<ErrandModel>>("https://localhost:44308/api/Errands");
    }


    protected override async Task OnInitializedAsync()
    {
        createErrand = new CreateErrandModel();
        serviceWorkers = new List<ServiceWorker>();
        serviceWorkers = await Http.GetFromJsonAsync<IEnumerable<ServiceWorker>>("https://localhost:44308/api/ServiceWorkers");
        errands = new List<ErrandModel>();
        await GetAllErrandsAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
