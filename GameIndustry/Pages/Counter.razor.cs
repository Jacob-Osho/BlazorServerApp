using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages

{
    partial class Counter
    {
        [Inject] SingletoneServices Singletone { get; set; }
        [Inject]  TransientServices Transient { get; set; }
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            Singletone.Value = currentCount;
            Transient.Value = currentCount;
        }
    }
}
