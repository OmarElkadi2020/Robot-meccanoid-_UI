#pragma checksum "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baec75094302942e7f14595c2ed60e1b2052fb0c"
// <auto-generated/>
#pragma warning disable 1591
namespace MeccaUI_THDxIOT.Client.Pages.KnnowladgeDatabase
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using MeccaUI_THDxIOT.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using MeccaUI_THDxIOT.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using MeccaUI_THDxIOT.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\_Imports.razor"
using MeccaUI_THDxIOT.Client.Pages.RobotControlling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reactions")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reactions/{TriggerID:long}")]
    public partial class All_ReactionCards : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddMarkupContent(1, "\r\n    .ReactionCardBody {\r\n        display: ");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
                   IsCardBodyVisable ? "block" : "none" 

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, ";\r\n        background: inherit;\r\n        padding: 3%;\r\n    }\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex justify-content-around");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatTooltip>(8);
            __builder.AddAttribute(9, "Tooltip", "Build a New Reaction");
            __builder.AddAttribute(10, "Wrap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTooltipPosition>(
#nullable restore
#line 16 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
                                                                      MatTooltipPosition.Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<MatBlazor.ForwardRef>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
                __builder2.AddAttribute(15, "class", "btn");
                __builder2.AddAttribute(16, "href", "ReactionBuilder/0");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n            <i class=\"oi oi-plus colored-icon oi-align-center\"></i>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n    ");
            __Blazor.MeccaUI_THDxIOT.Client.Pages.KnnowladgeDatabase.All_ReactionCards.TypeInference.CreateMatSlideToggle_0(__builder, 21, 22, "align-self-center", 23, 
#nullable restore
#line 21 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
                                                             IsCardBodyVisable

#line default
#line hidden
#nullable disable
            , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsCardBodyVisable = __value, IsCardBodyVisable)), 25, () => IsCardBodyVisable);
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "mt-3 row");
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n");
#nullable restore
#line 29 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
     if (Reactions == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.AddMarkupContent(32, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 32 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 34 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
     foreach (var reac in Reactions)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-4 mt-2");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenComponent<MeccaUI_THDxIOT.Client.Pages.KnnowladgeDatabase.ReactionCard>(38);
            __builder.AddAttribute(39, "reaction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MeccaUI_THDxIOT.Shared.Models.Reaction>(
#nullable restore
#line 37 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
                                    reac

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Call_ReInitialize_From_ReacionCardPanel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MeccaUI_THDxIOT.Shared.Models.Reaction>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MeccaUI_THDxIOT.Shared.Models.Reaction>(this, 
#nullable restore
#line 37 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
                                                                                    DeleteThisReaction

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "TriggerID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 37 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
                                                                                                                    TriggerID

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 39 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor"
 
    [Parameter]
    public List<Reaction> Reactions { set; get; }

    [Parameter]
    public long TriggerID { set; get; }

    public int tabIndex;


    private bool IsCardBodyVisable = true;


    protected override async Task OnInitializedAsync()
    {

            Reactions = new List<Reaction>();
            Reactions = await Http.GetFromJsonAsync<List<Reaction>>("api/Reactions");


    }

    public void DeleteThisReaction(Reaction reaction)
    {

        Reactions.Remove(reaction);

    }

    public void 
        
        
        ThisReaction(Reaction reaction)
    {
        Reactions.Add(reaction);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.MeccaUI_THDxIOT.Client.Pages.KnnowladgeDatabase.All_ReactionCards
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSlideToggle_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatSlideToggle<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
