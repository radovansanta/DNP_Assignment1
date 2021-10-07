#pragma checksum "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e92f7c41b0b5df8249cfd098d3de5926a8d77b3d"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using DNP_Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using DNP_Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
using DNP_Assignment1.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "style", "margin: 10px;width: 45%");
                __builder2.AddAttribute(4, "class", "card");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "card-body");
                __builder2.AddMarkupContent(7, "<h3>Login for more functions</h3>\n                ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "placeholder", "email@email.com");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
                                                                                       username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\n                ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "style", "margin-top: 10px");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "placeholder", "password");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
                                                                                                         password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.AddAttribute(23, "style", "margin-left: 10px;");
                __builder2.OpenElement(24, "div");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "style", "margin-top: 10px;");
                __builder2.AddAttribute(27, "type", "button");
                __builder2.AddAttribute(28, "class", "btn btn-success");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
                                                                                                          PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(30, "LogIn");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "style", "margin-top: 10px;margin-left: 10px;");
                __builder2.AddAttribute(35, "type", "button");
                __builder2.AddAttribute(36, "class", "btn btn-primary");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
                                                                                                                            PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(38, "SignUp");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.OpenElement(41, "p");
                __builder2.AddContent(42, 
#nullable restore
#line 22 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
                        errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(43, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "style", "margin: 10px;width: 45%");
                __builder2.AddAttribute(46, "class", "card");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "card-body");
                __builder2.AddMarkupContent(49, "<h3>Welcome</h3>\n                        ");
                __builder2.AddMarkupContent(50, "<h5>You are now able to discover more functions</h5>\n                        ");
                __builder2.AddMarkupContent(51, "<p>Under the section Add Adult you are able to create a new person. What\'s more you can check charts and see statistics</p>\n                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "row");
                __builder2.AddAttribute(54, "style", "margin-left: 10px;");
                __builder2.OpenElement(55, "div");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "style", "margin-top: 10px;");
                __builder2.AddAttribute(58, "type", "button");
                __builder2.AddAttribute(59, "class", "btn btn-primary");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
                                                                                                                  PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(61, "LogOut");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/LoginComponent.razor"
           
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin() {
        errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        } catch (Exception e) {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
