using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : ComponentBase
    {
        [Inject] private ILogger<$safeitemname$> _logger { get; set; }

        [Parameter] public string Title { get; set; }

        // Basic Lifecycle Functions
        //      There are Async versions of these        
        protected override void OnInitialized()
        {
            base.OnInitialized();   
            Title = "$safeitemname$";
        }
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
    }
}
