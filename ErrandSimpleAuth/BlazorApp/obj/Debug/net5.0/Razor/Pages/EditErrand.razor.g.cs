#pragma checksum "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb89958b33ddf913230b02a996b91750efc1bec"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using SharedLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using SharedLibrary.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editerrand/{Id:int}")]
    public partial class EditErrand : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorApp.Shared.Auth>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"col\"><h3>Edit</h3></div>\r\n\r\n    \r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                      model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "col-xl-6");
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                                                              UppdateErrand

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        \r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddAttribute(14, "required");
                __builder2.AddMarkupContent(15, "\r\n            Description: ");
                __builder2.OpenElement(16, "textarea");
                __builder2.AddAttribute(17, "id", "description");
                __builder2.AddAttribute(18, "rows", "4");
                __builder2.AddAttribute(19, "cols", "50");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "required");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                                                                              model.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Description = __value, model.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n            Customer name: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "customername");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "required", true);
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                                                                     model.CustomerName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.CustomerName = __value, model.CustomerName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.CustomerName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\r\n            Status: ");
                __builder2.OpenElement(39, "select");
                __builder2.AddAttribute(40, "class", "form-control selectpicker");
                __builder2.AddAttribute(41, "required");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                                                                     model.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Status = __value, model.Status));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(44, "option");
                __builder2.AddAttribute(45, "selected");
                __builder2.AddAttribute(46, "disabled");
                __builder2.AddAttribute(47, "value", "-1");
                __builder2.AddContent(48, "--Status--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenElement(50, "option");
                __builder2.AddAttribute(51, "value", "Pending");
                __builder2.AddContent(52, " Pending");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value", "Active");
                __builder2.AddContent(56, " Active");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.OpenElement(58, "option");
                __builder2.AddAttribute(59, "value", "Completed");
                __builder2.AddContent(60, " Completed");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "\r\n            Service worker: ");
                __Blazor.BlazorApp.Pages.EditErrand.TypeInference.CreateInputSelect_0(__builder2, 65, 66, "serviceworker", 67, "form-control selectpicker", 68, true, 69, 
#nullable restore
#line 30 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                                                                         model.ServiceWorkerId

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ServiceWorkerId = __value, model.ServiceWorkerId)), 71, () => model.ServiceWorkerId, 72, (__builder3) => {
                    __builder3.AddMarkupContent(73, "<option selected disabled value=\"-1\">--Serviceworker--</option>");
#nullable restore
#line 32 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                 foreach (var serviceWorker in serviceWorkers)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 34 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                                    serviceWorker.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, 
#nullable restore
#line 34 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                                                       serviceWorker.DisplayName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 35 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.AddMarkupContent(78, "<button type=\"submit\" class=\"btn btn-success w-25\">Update</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\EditErrand.razor"
        
    [Parameter]
    public int? Id { get; set; }
    public Errand errand = new Errand();
    public IEnumerable<ServiceWorker> serviceWorkers { get; set; } = new List<ServiceWorker>();
    public EditErrandModel model = new EditErrandModel();

    protected override async Task OnInitializedAsync()
    {
        if (Id == null)
        {
            NavManager.NavigateTo("Errands");
        }
        var response = await Http.GetAsync($"https://localhost:44308/api/Errands/{Id}");

        if (response.IsSuccessStatusCode)
        {
            var responseText = await response.Content.ReadAsStringAsync();
            Errand errand = JsonConvert.DeserializeObject<Errand>(responseText);

            serviceWorkers = new List<ServiceWorker>();
            serviceWorkers = await Http.GetFromJsonAsync<IEnumerable<ServiceWorker>>("https://localhost:44308/api/ServiceWorkers");

            model.Id = errand.Id;
            model.Description = errand.Description;                    
            model.Status = errand.Status;
            model.CustomerName = errand.CustomerName;                    
            model.Changed = DateTime.Now;
        }
        else
        {
            NavManager.NavigateTo("Errands");
        }
    }

    private async Task UppdateErrand()
    {
        await Http.PutAsJsonAsync($"https://localhost:44308/api/Errands/{Id}", model);
        NavManager.NavigateTo("Errands");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.EditErrand
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "required", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
