using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Concrete
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        public string? ShortName { get; set; }
        public string? LongName { get; set; }
    }
}
