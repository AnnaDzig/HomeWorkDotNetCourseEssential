using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    public class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = new Pupil[4];
            for (int i = 0; i < pupils.Length && i < 4; i++)
            {
                this.pupils[i] = pupils[i];
            }
        }

        public void ShowPupils()
        {
            foreach (var pupil in pupils)
            {
                if (pupil != null)
                {
                    pupil.Study();
                    pupil.Read();
                    pupil.Relax();
                    pupil.Write();
                    Console.WriteLine();
                }
            }
        }
    }
}
