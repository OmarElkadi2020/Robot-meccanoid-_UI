#pragma checksum "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba619dcbb8dccc6d2d827bee452873dabd9ad4b1"
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
#line 1 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class ReactionCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatCard>(0);
            __builder.AddAttribute(1, "Class", "demo-mat-card");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "mh-100");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "button");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                           AddMeToTrigger

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "class", "btn w-100 leave ");
                __builder2.AddAttribute(10, "type", "button");
                __builder2.AddContent(11, " ");
                __builder2.OpenElement(12, "span");
                __builder2.AddAttribute(13, "class", "w-100 bold-with-shadow");
                __builder2.AddContent(14, " ");
                __builder2.AddContent(15, 
#nullable restore
#line 9 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                                                                                          reaction.ReactionName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatCardContent>(18);
                __builder2.AddAttribute(19, "Class", "ReactionCardBody ");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(22);
                    __builder3.AddAttribute(23, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                         reaction

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                    () => save("has been updated Successfully")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n            \r\n            ");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddAttribute(28, "class", "row");
                        __builder4.AddMarkupContent(29, "\r\n                ");
                        __builder4.OpenElement(30, "div");
                        __builder4.AddAttribute(31, "class", "my-2 col-12");
                        __builder4.AddMarkupContent(32, "\r\n                    ");
                        __Blazor.MeccaUI_THDxIOT.Client.Pages.KnnowladgeDatabase.ReactionCard.TypeInference.CreateMatTextField_0(__builder4, 33, 34, "Reaction Name", 35, "bg-inhert", 36, 
#nullable restore
#line 18 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                        , 37, 
#nullable restore
#line 18 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                                      reaction.ReactionName

#line default
#line hidden
#nullable disable
                        , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reaction.ReactionName = __value, reaction.ReactionName)), 39, () => reaction.ReactionName);
                        __builder4.AddMarkupContent(40, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(41, "\r\n\r\n                ");
                        __builder4.OpenElement(42, "div");
                        __builder4.AddAttribute(43, "class", "my-2 col-12 ");
                        __builder4.AddMarkupContent(44, "\r\n                    ");
                        __Blazor.MeccaUI_THDxIOT.Client.Pages.KnnowladgeDatabase.ReactionCard.TypeInference.CreateMatSelectItem_1(__builder4, 45, 46, "Emotional Condition", 47, 
#nullable restore
#line 22 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                                                                                 EmotionalCondition

#line default
#line hidden
#nullable disable
                        , 48, "bg-inhert", 49, 
#nullable restore
#line 22 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                                                                                                                                 true

#line default
#line hidden
#nullable disable
                        , 50, 
#nullable restore
#line 22 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                                             reaction.EmotionalCondition

#line default
#line hidden
#nullable disable
                        , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reaction.EmotionalCondition = __value, reaction.EmotionalCondition)), 52, () => reaction.EmotionalCondition);
                        __builder4.AddMarkupContent(53, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(54, "\r\n            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(55, "\r\n            ");
                        __builder4.OpenElement(56, "div");
                        __builder4.AddAttribute(57, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-12 d-flex justify-content-between");
                        __builder4.AddMarkupContent(58, "\r\n                ");
                        __builder4.OpenElement(59, "button");
                        __builder4.AddAttribute(60, "class", "btn m-2");
                        __builder4.AddAttribute(61, "name", "Delete");
                        __builder4.AddAttribute(62, "type", "button");
                        __builder4.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                                                               Delete

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "style", "width:100px");
                        __builder4.AddContent(65, "Delete ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(66, "\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
                        __builder4.AddAttribute(68, "href", 
#nullable restore
#line 27 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
                                navlink

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(70, "\r\n                    ");
                            __builder5.AddMarkupContent(71, "<button class=\"btn m-2 btn-full-width\" name=\"Edit\" style=\"width:100px\">Show</button>\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\r\n            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(73, "\r\n            ");
                        __builder4.AddMarkupContent(74, "<div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-12 d-flex justify-content-center\">\r\n                <button class=\"btn m-2\" name=\"save\" type=\"submit\" style=\"width:100px\">save </button>\r\n            </div>\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
 
    [Parameter]
    public Reaction reaction { get; set; }

    [Parameter]
    public long TriggerID { get; set; }

    private string navlink { get; set; }

    [Parameter]
    public EventCallback<Reaction> Call_ReInitialize_From_ReacionCardPanel { get; set; }

    protected override void OnInitialized()
    {
        navlink = $"ReactionBuilder/{reaction.ReactionID}";

    }

    private async Task Delete()
    {


            var ID = reaction.ReactionID;
            var res = await Http.DeleteAsync($"api/Reactions/{ID}");
            if (res.IsSuccessStatusCode)
                Show($"The Reaction \"{reaction.ReactionName}\" has been deleted Successfully", MatToastType.Danger, "Deleted", "delete_sweep");
            await Call_ReInitialize_From_ReacionCardPanel.InvokeAsync(reaction);

       
    }
    async Task save(string TextForToaster)
    {
        if (reaction.ReactionID != 0) //Edit
        {
            var ID = reaction.ReactionID;
            var res = await Http.PutAsJsonAsync($"api/Reactions/{ID}", reaction);
            if (res.IsSuccessStatusCode)
                Toaster.Add($"The Reaction \"{reaction.ReactionName}\""+TextForToaster , MatToastType.Info, "Successed", "thumb_up");
        }
    }
    async Task AddMeToTrigger()
    {
        if (TriggerID != 0)
        {
            var TR =new TriggersReactions(TriggerID, reaction.ReactionID);
            var res = await Http.PostAsJsonAsync($"api/TriggersReactions", TR);
            if (res.IsSuccessStatusCode)
                Toaster.Add($"The Reaction \"{reaction.ReactionName}\"" + " is Added To The Trigger Successfully", MatToastType.Info, "Successed", "thumb_up");
            NavigationManager.NavigateTo("KnowladgeDataBase");
        }
    }
    public void Show(string message, MatToastType type, string title, string icon = "")
    {
        Toaster.Add(message, type, title, icon, config =>
        {
            config.ShowCloseButton = true;
            config.ShowProgressBar = true;
            config.MaximumOpacity = Convert.ToInt32(100);

            config.ShowTransitionDuration = Convert.ToInt32(500);
            config.VisibleStateDuration = Convert.ToInt32(10000);
            config.HideTransitionDuration = Convert.ToInt32(500);

            config.RequireInteraction = false;

        });
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor"
      

string[] EmotionalCondition = new[]
{
            "Happy",
            "Sad",
            "none",
        };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.MeccaUI_THDxIOT.Client.Pages.KnnowladgeDatabase.ReactionCard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "FullWidth", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMatSelectItem_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IReadOnlyList<TValue> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Class", __arg2);
        __builder.AddAttribute(__seq3, "Enhanced", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
