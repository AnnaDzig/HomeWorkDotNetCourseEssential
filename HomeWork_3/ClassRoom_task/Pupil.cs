using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil studies.");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil reads.");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil writes.");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil relaxes.");
        }
    }


}
