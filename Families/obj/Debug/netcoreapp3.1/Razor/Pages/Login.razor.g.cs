#pragma checksum "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816acd6e3282b65cc93d296dbbaae5838426e371"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Families;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\_Imports.razor"
using Families.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor"
using Families.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "﻿\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "form");
                __builder2.AddAttribute(5, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 11 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor"
                         PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(6, "\r\n                ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row login-row");
                __builder2.AddMarkupContent(9, "\r\n                    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "input-field col s3");
                __builder2.AddMarkupContent(12, "\r\n                        ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "placeholder", "");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor"
                                                                       username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.AddMarkupContent(19, "<label for=\"username\">Username</label>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "input-field col s3");
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "placeholder", "");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor"
                                                                           password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.AddMarkupContent(30, "<label class=\"bold\" for=\"password\">Password</label>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col s6");
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.AddMarkupContent(35, "<button class=\"btn\" type=\"submit\">\r\n                            Login\r\n                        </button>\r\n                        ");
                __builder2.OpenElement(36, "span");
                __builder2.AddAttribute(37, "class", "helper-text  red-text lighten-1");
                __builder2.AddContent(38, 
#nullable restore
#line 25 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor"
                                                                       errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n    ");
            }
            ));
            __builder.AddAttribute(43, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(44, "\r\n                 ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "s4");
                __builder2.AddMarkupContent(47, "\r\n                     ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "class", "waves-effect waves-light btn");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor"
                                                                            PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(51, "\r\n                         Log out\r\n                     ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                 ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n             ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Login.razor"
       
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
