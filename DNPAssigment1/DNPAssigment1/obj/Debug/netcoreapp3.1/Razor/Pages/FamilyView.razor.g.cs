#pragma checksum "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5087f862ff25f1a892915054fdfd530333b0ccde"
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
#line 1 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using DNPAssigment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<div class=\"col-1\">\r\n            Address:\r\n        </div>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-2");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "b");
            __builder.AddContent(8, 
#nullable restore
#line 13 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                selectedFam.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<h2>Adults:</h2>\r\n");
#nullable restore
#line 17 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<p>Loading...</p>\r\n");
#nullable restore
#line 20 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.AddMarkupContent(16, "<p>There are no adults in the family</p>\r\n");
#nullable restore
#line 24 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 42 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 45 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 46 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 47 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 48 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 49 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 50 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 51 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 52 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 53 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 55 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
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
#line 58 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "    ");
            __builder.AddMarkupContent(59, "<h2>Children:</h2>\r\n");
#nullable restore
#line 60 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
 if (selectedFam.Children == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "    ");
            __builder.AddMarkupContent(61, "<p>Loading...</p>\r\n");
#nullable restore
#line 63 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else if (!selectedFam.Children.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "    ");
            __builder.AddMarkupContent(63, "<p>There are no children in the family</p>\r\n");
#nullable restore
#line 67 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "    ");
            __builder.OpenElement(65, "table");
            __builder.AddAttribute(66, "class", "table");
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.AddMarkupContent(68, @"<thead>
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
            __builder.OpenElement(69, "tbody");
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 85 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
         foreach (var child in selectedFam.Children)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "            ");
            __builder.OpenElement(72, "tr");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 88 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 89 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 90 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 91 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "td");
            __builder.AddContent(87, 
#nullable restore
#line 92 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 93 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 94 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.OpenElement(95, "td");
            __builder.AddContent(96, 
#nullable restore
#line 95 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 96 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                     child.Interests.ToArray().ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 98 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 101 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "    ");
            __builder.AddMarkupContent(106, "<h2>Pets:</h2>\r\n");
#nullable restore
#line 103 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
     if (selectedFam.Pets == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "        ");
            __builder.AddMarkupContent(108, "<p>Loading...</p>\r\n");
#nullable restore
#line 106 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
    }
    else if (!selectedFam.Pets.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, "        ");
            __builder.AddMarkupContent(110, "<p>There are no pets in the family</p>\r\n");
#nullable restore
#line 110 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "        ");
            __builder.OpenElement(112, "table");
            __builder.AddAttribute(113, "class", "table");
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.AddMarkupContent(115, "<thead>\r\n            <tr>\r\n                <th>Species</th>\r\n                <th>Name</th>\r\n                <th>Age</th>\r\n            </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(116, "tbody");
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 122 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
             foreach (var pet in selectedFam.Pets)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "                ");
            __builder.OpenElement(119, "tr");
            __builder.AddMarkupContent(120, "\r\n                    ");
            __builder.OpenElement(121, "td");
            __builder.AddContent(122, 
#nullable restore
#line 125 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                         pet.Species

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "td");
            __builder.AddContent(125, 
#nullable restore
#line 126 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                         pet.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "td");
            __builder.AddContent(128, 
#nullable restore
#line 127 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
                         pet.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n");
#nullable restore
#line 129 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(131, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n");
#nullable restore
#line 132 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 134 "D:\OneDrive - ViaUC\Semester_3\DNP1\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Pages\FamilyView.razor"
       
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
