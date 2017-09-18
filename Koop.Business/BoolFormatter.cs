using System;

namespace Koop.Business
{
    public class BoolFormatter : IFormatProvider, ICustomFormatter
    {
        private string _trueDisplay;
        private string _falseDisplay;

        public BoolFormatter(string trueDisplay, string falseDisplay)
        {
            this._trueDisplay = string.Empty;
            this._falseDisplay = string.Empty;
            this._trueDisplay = trueDisplay;
            this._falseDisplay = falseDisplay;
        }

        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string outString = string.Empty;
            bool flag = arg.GetType() != typeof(bool);
            if (flag)
            {
                outString = "Undef";
            }
            else
            {
                flag = !(bool)arg;
                outString = flag ? this._falseDisplay : this._trueDisplay;
            }

            return outString;
        }
    }
}
