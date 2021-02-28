using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic01
{
    class Calculator<T> where T : struct
    {
        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da + db;
            return result;
        }

        public T Substract(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da - db;
            return result;
        }

        public T Multiply(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da * db;
            return result;
        }

        public T Divide(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da / db;
            return result;
        }
    }

}
