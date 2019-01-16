using System.Collections.Generic;

namespace Identity.Service.Models
{
    public class ResultViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}
