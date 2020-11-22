using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYTracker.Models
{
    interface IProjectItem
    {
        string Id { get; set; }

        Project Project { get; set; }
    }
}
