#pragma checksum "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fbc5f69e541d2dfe0a917e5884d1d9ed79161bd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\AddAdult.razor"
using Families.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\AddAdult.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\mundu\OneDrive\DNP\Assignment 1\Code\Families\Families\Pages\AddAdult.razor"
       
    Adult NewAdult = new Adult
    {
        HairColor = "Blond",
        EyeColor = "Black",
        Sex = "Male",
        PhotoLink = ""
    };
    String response;
    private void AddNewAdult()
    {
        if (NewAdult.PhotoLink.Equals(""))
        {
            NewAdult.PhotoLink = "/images/profile.svg";
        }
        FamilyService.addAdult(NewAdult);
        response = "Adult added.";
        NewAdult = new Adult
        {
            HairColor = "Blond",
            EyeColor = "Black",
            Sex = "Male",
            PhotoLink = ""
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
