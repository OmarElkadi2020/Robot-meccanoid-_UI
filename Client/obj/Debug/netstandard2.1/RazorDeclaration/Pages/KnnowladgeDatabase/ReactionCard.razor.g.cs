#pragma checksum "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\ReactionCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba619dcbb8dccc6d2d827bee452873dabd9ad4b1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591