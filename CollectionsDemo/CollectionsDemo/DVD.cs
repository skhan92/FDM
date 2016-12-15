using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class DVD : IComparable
    {
        public int id { get; set; }
        public string title { get; set; }

        public DVD(int Id, string Title)
        {
            id = Id;
            title = Title;
        }

        public override bool Equals(object obj)
        {
            DVD otherDVD = obj as DVD;  //This line casts the parameter back to the DVD
            //If the cast was unsuccessful, then the otherDVD 
            if (otherDVD == null)
            {
                return false;
            }

            //If the objects are in the same space in the heap, then they must be the same
            if (this == otherDVD)
            {
                return true;
            }

            //If the titles don't match, then they aren't the same so return false
            if (otherDVD.title != this.title)
            {
                return false;
            }

            //If the ids don't match, then they aren't the same so return false
            if (otherDVD.id != this.id)
            {
                return false;
            }

            //If the method gets all the way down here, then they must be the same so return true
            return true;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            DVD otherDVD = obj as DVD; //casting the parameter

            if (this.id < otherDVD.id)
            {
                return -1;
            }

            else if (this.id > otherDVD.id)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
    }
}