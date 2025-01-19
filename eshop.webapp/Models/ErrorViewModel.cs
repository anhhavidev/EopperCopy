namespace eshop.webapp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public int id { get; set; }
        // lấy từ git về trường name nhé
        public string name {get ;set;}
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
