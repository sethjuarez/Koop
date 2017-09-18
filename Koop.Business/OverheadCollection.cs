using System;
using System.Collections;
using System.Linq;

namespace Koop.Business
{
    [Serializable]
    public class OverheadCollection : CollectionBase
    {
        public Overhead this[int index]
        {
            get
            {
                return (Overhead)this.List[index];
            }

            set
            {
                this.List[index] = value;
            }
        }

        public OverheadCollection()
        {
        }

        public void Add(Overhead overhead)
        {
            this.List.Add(overhead);
        }

        public OverheadCollection Clone()
        {
            OverheadCollection oCollection = new OverheadCollection();
            IEnumerator enumerator = base.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    oCollection.Add((Overhead)enumerator.Current);
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }

            return oCollection;
        }

        public void SortByRate()
        {
            InnerList.Sort(new OverheadRateComparer());
        }

        public decimal GetPercentByRate(decimal range)
        {
            // The body of the current method contains operators that aren't supported in the current version.
            // This limitation will be addressed in the nearest update.
            // TODO: NEED TO IMPLEMENT!
            return 0;
        }
    }
}
