#pragma checksum "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06aecdc87b2fa421922d7ef082ae374979d0161d"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssigment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
using DNPAssigment1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/view")]
    public partial class View : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p>Select your family:</p>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                    SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "span");
            __builder.AddAttribute(6, "class", "text-muted ml-5");
            __builder.AddMarkupContent(7, "\r\n    Showing ");
            __builder.AddContent(8, 
#nullable restore
#line 11 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
             FilteredFamilies.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " out of ");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                                            Families.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
 if (Families == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 20 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
}
else if (!Families.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.AddMarkupContent(16, "<p>There are no families</p>\r\n");
#nullable restore
#line 24 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<thead>\r\n        <tr>\r\n            <th>Family ID</th>\r\n            <th>Last Name</th>\r\n            <th>Address</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(22, "tbody");
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 36 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
         foreach (var family in FilteredFamilies)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "            ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 39 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                     family.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 40 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                     family.Adults.First().LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 41 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                     family.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                                        () => SetSelectedFamily(family)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-outline-dark btn-sm");
            __builder.AddContent(41, "More info.");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "Policy", "SecurityLevel2");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenElement(48, "td");
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
                                        () => RemoveFamily(family.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(52, "\r\n                        <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n               ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 53 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 56 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\View.razor"
       
    string SearchTerm { get; set; } = "";
    private IList<Family> Families;
    IList<Family> FilteredFamilies => Families.Where(i => i.Adults.First().LastName.ToLower().Contains(SearchTerm.ToLower())).ToList();

    protected async override Task OnInitializedAsync()
    {
        Families = FamilyService.GetFamilies();
    }

    private void SetSelectedFamily(Family family)
    {
        FamilyService.setSelectedFamily(family);
        ModalService.Show<FamilyView>("Security Example");
    }
    
    private void RemoveFamily(int familyId)
    {
        Family familyToRemove = Families.First(f => f.Id == familyId);
        FamilyService.RemoveFamily(familyId);
        Families.Remove(familyToRemove);
        FilteredFamilies.Remove(familyToRemove);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService ModalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
