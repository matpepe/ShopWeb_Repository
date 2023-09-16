namespace ModelWeb.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string? CreatedDatetime { get; set; } = DateTime.Now.ToShortDateString();

    }
}