#pragma checksum "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f435ad187bf6e6ed916fca2bdd942385b741d3e"
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
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\Login.razor"
                 logInModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "col-6");
            __builder.AddAttribute(4, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\Login.razor"
                                                      LogInUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "id", "email");
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "placeholder", "Email");
                __builder2.AddAttribute(13, "required", true);
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\Login.razor"
                                                                                                logInModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => logInModel.Email = __value, logInModel.Email))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => logInModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "type", "password");
                __builder2.AddAttribute(22, "id", "password");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", "Password");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\Login.razor"
                                                                                                          logInModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => logInModel.Password = __value, logInModel.Password))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => logInModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.AddMarkupContent(30, "<div class=\"form-group\"><button class=\"btn btn-secondary\" type=\"submit\">Login</button></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Samuel\OneDrive\Skrivbord\ErrandApiWIthSessionStorage\ErrandSimpleAuth\BlazorApp\Pages\Login.razor"
       
    private LogInModel logInModel { get; set; }    

    private async Task LogInUser()
    {
        var response = await Http.PostAsJsonAsync<LogInModel>("https://localhost:44308/api/ServiceWorkers/login", logInModel);
        await sessionStorage.SetItemAsync<string>("auth", await response.Content.ReadAsStringAsync());
        NavManager.NavigateTo("/");
    }

    protected override void OnInitialized()
    {
        logInModel = new LogInModel();
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
