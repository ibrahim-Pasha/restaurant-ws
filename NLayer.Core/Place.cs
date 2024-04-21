using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core;

public class Place:BaseEntity
{
    public string Name { get; set; }
    public int TableId { get; set; }
    public ICollection<Table> Tables { get; set; }
}
