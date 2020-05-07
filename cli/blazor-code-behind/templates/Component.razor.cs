using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Blazor.Component.CodeBehind
{
    public partial class BlazorComponent : ComponentBase
    {
        // Example of an Injected Object
    [Inject] private ILogger<BlazorComponent> _logger { get; set; }
    // Example of a Parameter that can be passed into the Component or retrieved from a Query String
    [Parameter] public string Title { get; set; }

    // Basic Lifecycle Functions
    //      There are Async versions of these        
    protected override void OnInitialized()
    {
        base.OnInitialized();
        Title = "BlazorComponent";
    }
    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
    }
    }
}
