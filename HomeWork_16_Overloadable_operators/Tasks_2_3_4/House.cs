using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_2_3_4
{
    internal class House
    {
        public string Address { get; set; }
        public  Owner OwnerInfo { get; set; }

        public House(string address, Owner owner) 
        {
        Address = address;
            OwnerInfo = owner;
        }

        public House Clone() 
        {
        return (House)this.MemberwiseClone();
        }

        public House DeepClone()
        {
            return new House(Address, OwnerInfo.Clone());
        }

        public override string ToString()
        {
                return $"House Address: {Address}, Owner: {OwnerInfo}";
            }
        }
 class Owner
    {
        public string Name { get; set; }

        public Owner(string name)
        {
            Name = name;
        }

        public Owner Clone()
        {
            return new Owner(Name); 
        }

        public override string ToString()
        {
            return Name;
        }
    }


}

