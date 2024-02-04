using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IAuditableEntity
    {
        bool IsDeleted { get; set; }
        DateTime Created { get; set; }
        long Author { get; set; }
        DateTime? Modified { get; set; }
        long Editor { get; set; }
    }
}
