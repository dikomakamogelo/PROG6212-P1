namespace CMCS.Web.Models
{
    public class ClaimSummary   // replaces ClaimViewModel
    {
        public string Month { get; set; } = "";
        public string Status { get; set; } = "";
        public double TotalHours { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class ClaimEntry     // replaces ClaimEntryVm
    {
        public DateOnly WorkDate { get; set; }
        public string Module { get; set; } = "";
        public string TaskType { get; set; } = "";
        public double Hours { get; set; }
        public string? Notes { get; set; }
    }
}