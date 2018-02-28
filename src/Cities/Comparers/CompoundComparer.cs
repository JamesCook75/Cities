using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers { get; set; } = new List<IComparer<City>>();
        private int result = 1;

        public int Compare(City x, City y)
        {
            while (result != 0)
            {
                IComparer<City> comparer1 = Comparers[0];
                
                result = ((x, y).comparer1);
                return result;

            }
            IComparer<City> comparer2 = Comparers[1];
            return string.Compare(x.Name, y.Name);
        }
    }
}
