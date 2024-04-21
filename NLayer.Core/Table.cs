using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core;

public class Table:BaseEntity
{
    public int TableNumber { get; set; }
    public Place Place { get; set; }
}
