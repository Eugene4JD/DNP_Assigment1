#pragma checksum "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add31d68413a9bdd5f33991e5a56d42c83655ccc"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssigment1.Shared
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
#line 1 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
using DNPAssigment1.Models;

#line default
#line hidden
#nullable disable
    public partial class ChildForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add child</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<label>Fist name: </label>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "class", "input-group-text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                                     Child.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Child.FirstName = __value, Child.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<label>Last name: </label>\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "input-group-text");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                                         Child.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Child.LastName = __value, Child.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<label>Age: </label>\r\n        ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "class", "input-group-text");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                                     Child.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Child.Age = __value, Child.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.AddMarkupContent(36, "<label>ID: </label>\r\n        ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "class", "input-group-text");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                                     Child.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Child.Id = __value, Child.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.AddMarkupContent(46, "<label>Choose eye color: </label>\r\n        ");
            __Blazor.DNPAssigment1.Shared.ChildForm.TypeInference.CreateInputSelect_0(__builder, 47, 48, 
#nullable restore
#line 22 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                  Child.EyeColor

#line default
#line hidden
#nullable disable
            , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Child.EyeColor = __value, Child.EyeColor)), 50, () => Child.EyeColor, 51, (__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 23 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
             foreach (var color in Enum.GetValues(typeof(EyeColor))
                )
            { 

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, "                ");
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value", 
#nullable restore
#line 26 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                color

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(56, 
#nullable restore
#line 26 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                        color

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n");
#nullable restore
#line 27 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(58, "        ");
            }
            );
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.AddMarkupContent(64, "<label>Choose hair color: </label>\r\n            ");
            __Blazor.DNPAssigment1.Shared.ChildForm.TypeInference.CreateInputSelect_1(__builder, 65, 66, 
#nullable restore
#line 32 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                      Child.HairColor

#line default
#line hidden
#nullable disable
            , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Child.HairColor = __value, Child.HairColor)), 68, () => Child.HairColor, 69, (__builder2) => {
                __builder2.AddMarkupContent(70, "\r\n");
#nullable restore
#line 33 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                 foreach (var color in Enum.GetValues(typeof(HairColor)))
                { 

#line default
#line hidden
#nullable disable
                __builder2.AddContent(71, "                    ");
                __builder2.OpenElement(72, "option");
                __builder2.AddAttribute(73, "value", 
#nullable restore
#line 35 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                    color

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(74, 
#nullable restore
#line 35 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                            color

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n");
#nullable restore
#line 36 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(76, "            ");
            }
            );
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group");
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.AddMarkupContent(82, "<label>Weigh: </label>\r\n            ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "class", "input-group-text");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                                         Child.Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Child.Weight = __value, Child.Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "class", "btn btn-primary");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
                                              saveChild

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(92, "Save pet");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Jenia\Documents\GitHub\DNP_Assigment1\DNPAssigment1\DNPAssigment1\Shared\ChildForm.razor"
      
    Child Child = new Child();


    private void saveChild()
    {
        
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DNPAssigment1.Shared.ChildForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
