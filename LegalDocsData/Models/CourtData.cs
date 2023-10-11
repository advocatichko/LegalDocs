using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalDocsData.Models
{
    public class CourtData
    {
        public int Id { get; set; }
        public string court_name { get; set; }
        public string case_number { get; set; }
        public string case_proc { get; set; }
        public DateTime registration_date { get; set; }
        public string judge { get; set; }
        public string judges { get; set; }
        public string participants { get; set; }
        public DateTime stage_date { get; set; }
        public DateTime date { get; set; }
        public string stage_name { get; set; }
        public string cause_result { get; set; }
        public string cause_dep { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }
}
