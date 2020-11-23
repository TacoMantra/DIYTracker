using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYTracker.Models
{
    interface IProjectItem
    {
        int Id { get; set; }

        IItem Item { get; set; }

        Project Project { get; set; }
    }
}
