

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string SenderEmail { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string SenderName { get; set; } = null!;

    }
}
