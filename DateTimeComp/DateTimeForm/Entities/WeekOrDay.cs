using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeForm.Entities
{
    public class WeekOrDay
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public List<Timeline> timeline { get; set; }
    }
}
