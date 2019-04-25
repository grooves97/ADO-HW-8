using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApp.Models
{
    public class Visitor : Entity
    {
        public string Fullname { get; set; }
        public string Document { get; set; }
        public string PurposeOfVisit { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
    }
}
