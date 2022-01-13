using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_16_Generic
{
    public class CourseGeneric<T, K>
    {
        public T ID { get; set; }
        public K Name { get; set; }
        public T Credit { get; set; }
    }
}
