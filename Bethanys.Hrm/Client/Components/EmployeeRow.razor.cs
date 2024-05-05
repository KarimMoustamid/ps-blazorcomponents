namespace Bethanys.Hrm.Client.Components
{
    using Hrm.Shared;
    using Microsoft.AspNetCore.Components;

    public partial class EmployeeRow
    {
        [Parameter] public EmployeeModel Employee { get; set; }

        private bool showBenefits { get; set; }
    }
}