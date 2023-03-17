#pragma checksum "C:\Users\OmarElkadi\source\repos\MeccaUI_THDxIOT\Client\Pages\KnnowladgeDatabase\All_ReactionCards.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baec75094302942e7f14595c2ed60e1b2052fb0c"
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
#pragma warning restore 1591
