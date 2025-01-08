using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_2_3_4
{
    internal class Block
    {
        public int Side1 { get;}
        public int Side2 { get;}
        public int Side3 { get;}
        public int Side4 { get;}


        public Block(int side1, int side2, int side3, int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }

        public override bool Equals(object obj)
        {
           if (obj is Block otherBlock) 
            { return Side1 == otherBlock.Side1 && 
                    Side2 == otherBlock.Side2 && 
                    Side3 == otherBlock.Side3 && 
                    Side4 == otherBlock.Side4; }
           return false;
        }

        public override int GetHashCode()
        {
            return (Side1, Side2, Side3, Side4).GetHashCode();
            }

        public override string ToString()
        {
            return $"Block: Side1={Side1}, Side2={Side2}, Side3={Side3}, Side4={Side4}";
        }
    }


}
