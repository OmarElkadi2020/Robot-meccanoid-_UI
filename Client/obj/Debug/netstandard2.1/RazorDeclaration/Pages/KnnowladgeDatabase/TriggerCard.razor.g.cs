#pragma checksum "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\TriggerCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51f06662583ecd55f79268dcb0c86d843e7afb72"
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
#line 1 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\TriggerCard.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class TriggerCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\TriggerCard.razor"
      


    private string validation_massage = "One Of The Trigger Types must be filled";

    public int tabIndex { set; get; } = 0;

    public bool EnableReactionRemoving { set; get; } = false;

    [Parameter]
    public Trigger trigger { set; get; }

    private string navlink { set; get; }

    public List<Reaction> ThisTriggerReactions { set; get; }

    [Parameter]
    public EventCallback<Trigger> DeleteThisTrigger { get; set; }


    string[] TriggerSenses = new[]
    {
        "Head Swapping",
        "Shoulder Swapping",
        "Hand Shaking",
        null,
    };

    protected override void OnInitialized()
    {
        navlink = $"Reactions/{trigger.TriggerID}";

            ThisTriggerReactions = new List<Reaction>();
            ThisTriggerReactions =  trigger.TriggersReactions.Select(tr => tr.Reaction).ToList();
        
       
    }

    private async Task Save()
    {

        if (!string.IsNullOrEmpty(trigger.SenseTrigger) && string.IsNullOrEmpty(trigger.AudioTextTrigger))
        {
            trigger.TriggerType = "Sensory";
        }
        else if (!string.IsNullOrEmpty(trigger.AudioTextTrigger) && string.IsNullOrEmpty(trigger.SenseTrigger))
        {
            trigger.TriggerType = "Auditory";
        }
        else if (!(string.IsNullOrEmpty(trigger.AudioTextTrigger) || string.IsNullOrEmpty(trigger.SenseTrigger)))
        {
            trigger.TriggerType = "Mixed";
        }
        else
        {
            trigger.TriggerType = null;
        }


            if (trigger.TriggerID != 0) //Edit
            {
                var ID = trigger.TriggerID;
                var res = await Http.PutAsJsonAsync($"api/Triggers/{ID}", trigger);
                if (res.IsSuccessStatusCode) Show($"The Trigger \"{trigger.TriggerName}\" has been updated Sucssfully", MatToastType.Info,"Successed" , "edit");
            }

    }

    private async Task Delete()
    {


            var ID = trigger.TriggerID;
            var res= await Http.DeleteAsync($"api/Triggers/{ID}");
            await DeleteThisTrigger.InvokeAsync(trigger);

            if (res.IsSuccessStatusCode)
                Show($"The Trigger \"{trigger.TriggerName}\" has been deleted Successfully", MatToastType.Danger, "Deleted", "delete_sweep");

        
    }

    private async Task DeattachReaction(long ReactionID)
    {
        if (EnableReactionRemoving) {
            var res = await Http.DeleteAsync($"api/TriggersReactions/Trigger/{trigger.TriggerID}/Reaction/{ReactionID}");

            if (res.IsSuccessStatusCode)
                Show("The Reaction is deattached", MatToastType.Link, "delete", "add_circle_outline");
            trigger.TriggersReactions.RemoveAll(R => R.ReactionID == ReactionID);
            OnInitialized();
        }
        else
        {
            Show("Enable Deleting from The Toggle silder then double Click to delete", MatToastType.Info, "Wrong Input!", "error_outline");

        }
    }

    public void Show(string message, MatToastType type,string title, string icon = "")
    {
        Toaster.Add( message , type, title, icon, config =>
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591