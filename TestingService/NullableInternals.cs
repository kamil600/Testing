using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingService
{
    public abstract class Abstract : NullableInternals
    {

        public abstract override void AssignNI();

    }

    public class TestFormat : IFormatProvider
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(TestFormat))
                return this;
            else
                throw new Exception("Bad type.");
        }
    }

    delegate int MyDelegate(string s);

    public class NullableInternals
    {
        string s = null;
        int? i = null;
        NullableInternals ni = new();
        MyDelegate d;

        public static implicit operator NullableInternals(string str)
        {
            return new NullableInternals() { s = str };
        }

        public virtual void AssignNI()
        {
            ni = ni?.i?.ToString(new TestFormat());
            AssignS(k: 9, s: "lol");
            d = m => m.Length;
        }

        void AssignS(string s = "", int k = 0)
        {
            this.s = s;
            i = k;
        }

        
    }
}
