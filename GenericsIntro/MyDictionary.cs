using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T0, T1>
    {
        T0[] myKeys;
        T1[] myValues;

        public MyDictionary()
        {
            myKeys = new T0[0];
            myValues = new T1[0];
        }

        public void Add(T0 key, T1 value)
        {
            T0[] tempMyKeys = myKeys;
            myKeys = new T0[myKeys.Length + 1];

            T1[] tempMyValues = myValues;           
            myValues = new T1[myValues.Length+1];

            for (int i = 0; i < tempMyKeys.Length; i++)
            {
                myKeys[i] = tempMyKeys[i];
                myValues[i] = tempMyValues[i];
            }

            myKeys[myKeys.Length - 1] = key;
            myValues[myValues.Length - 1] = value;
        }
    }
}
