using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace Koop.Business
{
    [Serializable]
    [XmlRoot(ElementName = "Overhead", DataType = "string", IsNullable = true)]
    public class Overhead
    {
        private decimal _range;
        private decimal _percent;

        [DisplayName("1. Range"), ReadOnly(false), Category("Overhead Settings"), Description("Contracted range")]
        public decimal Range
        {
            get
            {
                return this._range;
            }

            set
            {
                this._range = value;
            }
        }

        [Description("Overhead percent"), ReadOnly(false), Category("Overhead Settings"), DisplayName("2. Overhead")]
        public decimal Percent
        {
            get
            {
                return this._percent;
            }

            set
            {
                this._percent = value;
            }
        }

        public Overhead()
        {
            this._range = new decimal(0);
            this._percent = new decimal(0);
        }

        public Overhead(decimal range, decimal percent)
        {
            this._range = range;
            this._percent = percent;
        }
    }
}
