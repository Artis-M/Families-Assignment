#pragma checksum "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea8de190f3ae84d20947a165ba389b4a74fd2368"
// <auto-generated/>
#pragma warning disable 1591
namespace Families.Pages
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
#line 2 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
using Families.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, @"<div class=""row"">
            <div class=""col 5s"">
                <h2 class=""teal-text lighten-1"">Family Manager</h2>
                <p>Here you can add and manmage families, with each family memeber containing relevant information + a profile picture.</p>
            </div>
            <div class=""col 5s"">
            </div>
        </div>
    ");
            }
            ));
            __builder.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<h4 class=\"teal-text lighten-1\">Recently Added Adult</h4>\r\n                ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col s6");
                __builder2.AddMarkupContent(12, "\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "card teal lighten-1");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "card-content white-text");
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "span");
                __builder2.AddAttribute(20, "class", "card-title");
                __builder2.AddMarkupContent(21, "\r\n                                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "row");
                __builder2.AddMarkupContent(24, "\r\n                                    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col s8");
                __builder2.AddMarkupContent(27, "\r\n                                        ");
                __builder2.OpenElement(28, "strong");
                __builder2.AddContent(29, 
#nullable restore
#line 25 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                                 LastAdult.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(30, " ");
                __builder2.AddContent(31, 
#nullable restore
#line 25 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                                                      LastAdult.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                                    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col s4");
                __builder2.AddMarkupContent(36, "\r\n                                        ");
                __builder2.OpenElement(37, "img");
                __builder2.AddAttribute(38, "style", "height: 100px;");
                __builder2.AddAttribute(39, "class", "circle responsive- right");
                __builder2.AddAttribute(40, "src", 
#nullable restore
#line 28 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                                                                                           LastAdult.PhotoLink

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                        \r\n                \r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenElement(45, "table");
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.AddMarkupContent(47, @"<thead>
                                <tr>
                                    <th>Job</th>
                                    <th>Eye Colour</th>
                                    <th>Hair Colour</th>
                                    <th>Age</th>
                                    <th>Weight (kg)</th>
                                    <th>Height (cm)</th>
                                    <th>Gender</th>
                                </tr>
                                </thead>
                                ");
                __builder2.OpenElement(48, "tbody");
                __builder2.AddMarkupContent(49, "\r\n                                ");
                __builder2.OpenElement(50, "tr");
                __builder2.AddMarkupContent(51, "\r\n                                    ");
                __builder2.OpenElement(52, "td");
                __builder2.AddContent(53, 
#nullable restore
#line 48 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                         LastAdult.JobTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                    ");
                __builder2.OpenElement(55, "td");
                __builder2.AddContent(56, 
#nullable restore
#line 49 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                         LastAdult.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                    ");
                __builder2.OpenElement(58, "td");
                __builder2.AddContent(59, 
#nullable restore
#line 50 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                         LastAdult.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                                    ");
                __builder2.OpenElement(61, "td");
                __builder2.AddContent(62, 
#nullable restore
#line 51 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                         LastAdult.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                                    ");
                __builder2.OpenElement(64, "td");
                __builder2.AddContent(65, 
#nullable restore
#line 52 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                         LastAdult.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                                    ");
                __builder2.OpenElement(67, "td");
                __builder2.AddContent(68, 
#nullable restore
#line 53 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                         LastAdult.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                                    ");
                __builder2.OpenElement(70, "td");
                __builder2.AddContent(71, 
#nullable restore
#line 54 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
                                         LastAdult.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, " \r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\Index.razor"
      
    
    private Adult LastAdult;
    protected override void OnInitialized()
    {
        LastAdult = FamilyService.getAdults().Last();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
