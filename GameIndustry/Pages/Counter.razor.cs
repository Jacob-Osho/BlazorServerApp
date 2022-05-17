using GameIndustry.Models;
using Microsoft.AspNetCore.Components;
using static GameIndustry.Shared.MainLayout;

namespace GameIndustry.Pages

{
    partial class Counter
    {
        [Inject] SingletoneServices Singletone { get; set; }
        [Inject]  TransientServices Transient { get; set; }
        [CascadingParameter(Name = "Style")] public AppStyles Style { get; set; }
        //[CascadingParameter(Name ="Color")] public string Color { get; set; }
        //[CascadingParameter(Name = "Size")] public string Size { get; set; }
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            Singletone.Value = currentCount;
            Transient.Value = currentCount;
        }
    }
}
