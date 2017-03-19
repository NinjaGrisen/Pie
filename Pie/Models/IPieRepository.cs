using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie GetPieById(int PieId);
    }
}
