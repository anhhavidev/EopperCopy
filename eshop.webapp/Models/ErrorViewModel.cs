namespace eshop.webapp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public int id;
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
