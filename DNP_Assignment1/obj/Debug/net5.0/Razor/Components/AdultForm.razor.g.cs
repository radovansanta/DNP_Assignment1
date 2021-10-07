#pragma checksum "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d185b99243fd6b22bda71d41d6d0c88ccd8583"
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
#line 1 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
using DNP_Assignment1.Persistence;

#line default
#line hidden
#nullable disable
    public partial class AdultForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div style=\"width: 800px\" class=\"card-header\">\n        Add an adult\n    </div>\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                          _adult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"idInput\">ID</label>\n                ");
                __Blazor.DNP_Assignment1.Components.AdultForm.TypeInference.CreateInputNumber_0(__builder2, 12, 13, "form-control", 14, "idInput", 15, 
#nullable restore
#line 14 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                            _adult.Id

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Id = __value, _adult.Id)), 17, () => _adult.Id);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"firstNameInput\">First Name</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "placeholder", "Enter first name");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "id", "firstNameInput");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                                                _adult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.FirstName = __value, _adult.FirstName))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label for=\"lastNameInput\">Last Name</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "placeholder", "Enter last name");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "id", "lastNameInput");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                                              _adult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.LastName = __value, _adult.LastName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"hairColorInput\">Hair Color</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "placeholder", "Enter color of hair");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "id", "hairColorInput");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                                                   _adult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.HairColor = __value, _adult.HairColor))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "<label for=\"eyeColorInput\">Eye Color</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "placeholder", "Enter color of eye");
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "id", "eyeColorInput");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                                                 _adult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.EyeColor = __value, _adult.EyeColor))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "<label for=\"ageInput\">Age</label>\n                ");
                __Blazor.DNP_Assignment1.Components.AdultForm.TypeInference.CreateInputNumber_1(__builder2, 66, 67, "form-control", 68, "ageInput", 69, 
#nullable restore
#line 29 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                             _adult.Age

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Age = __value, _adult.Age)), 71, () => _adult.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "<label for=\"weightInput\">Weight</label>\n                ");
                __Blazor.DNP_Assignment1.Components.AdultForm.TypeInference.CreateInputNumber_2(__builder2, 76, 77, "form-control", 78, "weightInput", 79, 
#nullable restore
#line 32 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                _adult.Weight

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Weight = __value, _adult.Weight)), 81, () => _adult.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\n            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.AddMarkupContent(85, "<label for=\"heightInput\">Height</label>\n                ");
                __Blazor.DNP_Assignment1.Components.AdultForm.TypeInference.CreateInputNumber_3(__builder2, 86, 87, "form-control", 88, "heightInput", 89, 
#nullable restore
#line 35 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                _adult.Height

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Height = __value, _adult.Height)), 91, () => _adult.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group");
                __builder2.AddMarkupContent(95, "<label for=\"sexInput\">Sex</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(96);
                __builder2.AddAttribute(97, "placeholder", "Enter your sex");
                __builder2.AddAttribute(98, "class", "form-control");
                __builder2.AddAttribute(99, "id", "sexInput");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                                        _adult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Sex = __value, _adult.Sex))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n            ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group");
                __builder2.AddMarkupContent(106, "<label for=\"salaryInput\">Salary</label>\n                ");
                __Blazor.DNP_Assignment1.Components.AdultForm.TypeInference.CreateInputNumber_4(__builder2, 107, 108, "form-control", 109, "salaryInput", 110, 
#nullable restore
#line 41 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                _adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
                , 111, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.JobTitle.Salary = __value, _adult.JobTitle.Salary)), 112, () => _adult.JobTitle.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\n            ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group");
                __builder2.AddMarkupContent(116, "<label for=\"jobTitleInput\">Job Title</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(117);
                __builder2.AddAttribute(118, "placeholder", "Enter title of your job");
                __builder2.AddAttribute(119, "class", "form-control");
                __builder2.AddAttribute(120, "id", "jobTitleInput");
                __builder2.AddAttribute(121, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                                                                                                                      _adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.JobTitle.JobTitle = __value, _adult.JobTitle.JobTitle))));
                __builder2.AddAttribute(123, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.JobTitle.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\n            ");
                __builder2.AddMarkupContent(125, "<div><button type=\"submit\" class=\"btn btn-primary\">Add Adult</button></div>\n            ");
                __builder2.OpenElement(126, "p");
                __builder2.AddContent(127, 
#nullable restore
#line 48 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
                error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
  
    if (id!=null)
    {
        string[] searchOption = {"id",id};
        _adult = _fileContext.SearchAdult(searchOption)[0];
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultForm.razor"
       

    [Parameter]
    public string id { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    string error = "";

    private Adult _adult = new()
    {
        Id = 0,
        Age = 0,
        Height = 0,
        Sex = null,
        Weight = 0,
        EyeColor = null,
        FirstName = null,
        HairColor = null,
        LastName = null, JobTitle = new Job()
        {
            JobTitle = null,
            Salary = 0
        }
    };

    private void HandleValidSubmit()
    {
        if (_adult.Id==0 ||
            _adult.FirstName==null ||
            _adult.LastName==null ||
            _adult.HairColor==null ||
            _adult.EyeColor==null ||
            _adult.Age ==0 ||
            _adult.Weight ==0 ||
            _adult.Height==0 ||
            _adult.Sex==null ||
            _adult.JobTitle.Salary==0 ||
            _adult.JobTitle.JobTitle==null)
        {
            error = "Missing inputs";
        }
        else
        {
            _fileContext.AddAdult(_adult);
            NavigationManager.NavigateTo("add_people", forceLoad: false);
        }
        
        
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext _fileContext { get; set; }
    }
}
namespace __Blazor.DNP_Assignment1.Components.AdultForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
