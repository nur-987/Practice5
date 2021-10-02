using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics at method level
            int a = 3;
            int b = 4;
            swap<int>(ref a, ref b);

            float c = 1.3f;
            float d = 2.1f;
            swap<float>(ref c, ref d);

            string str1 = "aaa";
            string str2 = "sss";
            swap<string>(ref str1, ref str2);
            //same method used many times
            #endregion

            #region generics at class lvl
            //what we normally do
            //Device myDevice = new Device();
            //when in generics class need to define the type

            Device<int> intObj = new Device<int>();
            Device<string> stringObj = new Device<string>();

            intObj.name = 1;
            intObj.category = 1;
            intObj.isAvail = true;

            stringObj.name = "sony";
            stringObj.category = "mobile";
            stringObj.isAvail = false;
            #endregion

            #region Class generics with generic Array
            SampleClass<float> floatClass = new SampleClass<float>();
            floatClass.Add(8.1f);
            floatClass.Add(9.2f);

            #endregion

            #region "where"
            NewDevice<int> intObj2 = new NewDevice<int>();
            NewDevice<string> stringObj2 = new NewDevice<string>();

            intObj.name = 1;
            intObj.category = 1;

            //string not allowed becuase class is of type struct
            stringObj.name = "sony";
            stringObj.category = "mobile";

            Device2<Parent> parentObj = new Device2<Parent>();

            #endregion

        }

        public static void swapOri(ref int a, ref int b) //No generics
        {
            //limited to only int types
            int temp = a;
            a = b;
            b = temp;

        }

        public static void swap<T>(ref T a, ref T b)  //Method level
        {
            T temp = a;
            a = b;
            b = temp;

            //T means that we dnt know what method yet.
            //Just create the structure for it.
            //this structure can recive all types.
        }

        public class Device<T> //Class level
        {
            public T name { get; set; } //both name and category willl be defined at creation
            public T category { get; set; }
            public bool isAvail { get; set; } //not generic
        }

        public class SampleClass<T>  //Class level with Array
        {
            T[] arrObj = new T[5];
            int count = 0;

            //class type T
            //Array type T
            //method calls T as well

            public void Add(T item)
            {
                if(count + 1 < 5)
                {
                    arrObj[count] = item;
                }
                count++;
            }

            public T this[int index] //indexer for the Sample class
            {
                get { return arrObj[index]; }
                set { arrObj[index] = value; }
            }
            
        }

        #region "where"
        public class NewDevice<T> where T: struct  
            //says that T can only be strct
            //restrict what T can be
        {
            public T name { get; set; }
            public T category { get; set; }

        }

        class Device2<T> where T : Parent
        {
            //Parent and any of its child
        }
        class Device3<T> where T : Child
        {
            //Parent and any of its child
        }
        class Parent
        {
            //available for Device2
        }
        class Child:Parent
        {
            //available for Device2
            //available for Device3
        }
        #endregion
    }
}
