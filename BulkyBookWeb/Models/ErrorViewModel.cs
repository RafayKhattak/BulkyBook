// Namespace for the ErrorViewModel
namespace BulkyBookWeb.Models
{
    // Class representing the ErrorViewModel
    public class ErrorViewModel
    {
        // Property for storing the request ID, marked as nullable
        public string? RequestId { get; set; }

        // Property indicating whether to show the request ID
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
