#pragma checksum "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989f1136754e6b073be6749362f7af5e31eaaf0e"
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
#line 4 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
using DNPAssigment1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/familyView")]
    public partial class FamilyView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"col-1\">\r\n        Address:\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "b");
            __builder.AddContent(8, 
#nullable restore
#line 13 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
            selectedFam.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.AddMarkupContent(12, "<h2>Adults:</h2>\r\n");
#nullable restore
#line 17 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<p>Loading...</p>\r\n");
#nullable restore
#line 20 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.AddMarkupContent(16, "<p>There are no adults in the family</p>\r\n");
#nullable restore
#line 24 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
            __builder.AddMarkupContent(21, @"<thead>
        <tr>
            <th>F. Name</th>
            <th>L. Name</th>
            <th>ID</th>
            <th>Hair Color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Job</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(22, "tbody");
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 42 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
         foreach (var adult in selectedFam.Adults)
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
#line 45 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 46 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 47 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 48 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 49 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 50 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 51 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 52 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 53 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     adult.Job

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 55 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 58 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "<h2>Children:</h2>\r\n");
#nullable restore
#line 60 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Children == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "    ");
            __builder.AddMarkupContent(60, "<p>Loading...</p>\r\n");
#nullable restore
#line 63 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Children.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "    ");
            __builder.AddMarkupContent(62, "<p>There are no children in the family</p>\r\n");
#nullable restore
#line 67 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "    ");
            __builder.OpenElement(64, "table");
            __builder.AddAttribute(65, "class", "table");
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.AddMarkupContent(67, @"<thead>
        <tr>
            <th>F. Name</th>
            <th>L. Name</th>
            <th>ID</th>
            <th>Hair Color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Interests</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(68, "tbody");
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 85 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
         foreach (var child in selectedFam.Children)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "            ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 88 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 89 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 90 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 91 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "td");
            __builder.AddContent(86, 
#nullable restore
#line 92 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 93 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "td");
            __builder.AddContent(92, 
#nullable restore
#line 94 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "td");
            __builder.AddContent(95, 
#nullable restore
#line 95 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 96 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     string.Join(" ", child.Interests.ToArray())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 98 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 101 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(104, "<h2>Pets:</h2>\r\n");
#nullable restore
#line 103 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Pets == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "    ");
            __builder.AddMarkupContent(106, "<p>Loading...</p>\r\n");
#nullable restore
#line 106 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Pets.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "    ");
            __builder.AddMarkupContent(108, "<p>There are no pets in the family</p>\r\n");
#nullable restore
#line 110 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "    ");
            __builder.OpenElement(110, "table");
            __builder.AddAttribute(111, "class", "table");
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.AddMarkupContent(113, "<thead>\r\n        <tr>\r\n            <th>Species</th>\r\n            <th>Name</th>\r\n            <th>Age</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(114, "tbody");
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 122 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
         foreach (var pet in selectedFam.Pets)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "            ");
            __builder.OpenElement(117, "tr");
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.OpenElement(119, "td");
            __builder.AddContent(120, 
#nullable restore
#line 125 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     pet.Species

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                ");
            __builder.OpenElement(122, "td");
            __builder.AddContent(123, 
#nullable restore
#line 126 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     pet.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                ");
            __builder.OpenElement(125, "td");
            __builder.AddContent(126, 
#nullable restore
#line 127 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     pet.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 129 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 132 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 134 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
       
    Family selectedFam { get; set; }

    protected async override Task OnInitializedAsync()
    {
        selectedFam = FamilyService.getSelectedFamily();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
