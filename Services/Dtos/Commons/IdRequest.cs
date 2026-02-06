using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos.Commons
{
    public class IdRequest<T>
    {
        public T Id { get; set; }
    }
}
