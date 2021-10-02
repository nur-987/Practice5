using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInterfaceExample
{
    public interface IMyGenericInterface<T>
    {
        void doSomething(T a, T b);
        
        //T is the return type
        T anotherAction(T a, T b);

        T add(T i, T j);
    }

    //method 1: Close stance
    //Define the type in the class here
    //type is hard coded
    public class MyGenericClass1 : IMyGenericInterface<int>
    {
        public int add(int i, int j)
        {
            return (i + j);
        }

        public int anotherAction(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void doSomething(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    //method 2: Open stance
    //Type not defined in the class
    //only defined later in the object creation
    public class MyGenericClass2<T> : IMyGenericInterface<T>
    {
        public T add(T i, T j)
        {
            throw new NotImplementedException();
            //return(a+b) doesnt work
            //because at this point, T is not defined yet

        }

        public T anotherAction(T a, T b)
        {
            throw new NotImplementedException();
        }

        public void doSomething(T a, T b)
        {
            throw new NotImplementedException();
        }
    }

    class Program2
    {
        public void createGenericType()
        {
            MyGenericClass1 myGenericClass1 = new MyGenericClass1();
            myGenericClass1.doSomething(2, 5);
            myGenericClass1.add(2, 3);

            MyGenericClass2<string> myGenericClassString = new MyGenericClass2<string>();
            myGenericClassString.doSomething("sss", "qqq");
            
            

            MyGenericClass2<int> myGenericClassInt = new MyGenericClass2<int>();
            myGenericClassInt.doSomething(7, 3);
            myGenericClassInt.add(9, 3);

        }
    }
}
