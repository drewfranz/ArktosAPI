using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArktosAPI.Classes
{
    public class TaskItemQueryParameters : QueryParameters
    {
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsPriority { get; set; }
        public int Size { get; set; }
    }
}
