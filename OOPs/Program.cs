using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs
{

    public class Program
    {
        static void Main(string[] args)
        {   
            
            #region ReadOnly Variable Implementation
            A a = new A();
            Console.WriteLine(a.variable);
            Console.ReadLine();
            return;
            #endregion

            #region HashTable and Dictionary
            // Dictionay VS HashTable
            // 1 Hastable will handle null value
            // 2 Both are storing key value pair

            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("Name", "hemal");
            //dic.Add("Add", "Maninagar");

            //Hashtable hash = new Hashtable();
            //hash.Add("Name", "Hemal");
            //hash.Add("Add", "Maninagar");


            //string str1 = Convert.ToString(hash["A1"]);
            //str1 = hash["Add"].ToString();

            //string str = dic.Where(c => c.Key == "Add").FirstOrDefault().Value;
            //str = Convert.ToString(dic["A1"]); 
            #endregion

            #region Sealed Class
            //SealedClass s = new SealedClass();
            //s.SealedClassMethod();
            #endregion

            #region Static Class
            //StaticClass.StaticClassMethod();
            #endregion

            #region Exception Handling
            //try
            //{
            //    int i = 0;
            //    int j = 1 / i;
            //    //divideby 0 error
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Divide By Zero");
            //}
            //catch
            //{
            //    Console.WriteLine("Default Catch");
            //}
            #endregion

            MethodOverRidingBase Base = new MethodOverRidingBase();
            Base.Calculate(); // MethodOverRidingBase

            MethodOverRidingChild Child = new MethodOverRidingChild();
            Child.Calculate(); // MethodOverRidingChild

            //MethodOverRidingChild BaseChild = new MethodOverRidingBase();
            //BaseChild.Calculate(); //MethodOverRidingBase

            MethodOverRidingBase ChildBase = new MethodOverRidingChild();
            ChildBase.Calculate(); //MethodOverRidingBase


            //B b = new B();
            //b.Clear();

            //C c = new C();
            //c.Print();

            //D d = new D();
            //d.Print();

            //A d1 = new D();
            //d1.Print();

            //ImplemtInterface I = new ImplemtInterface();
            //I.GetData();

            Console.Read();

        }
    }

    public class A
    {
        
        #region ReadOnly Variable set value in constructor
        
        public readonly int variable = 10;
        public A()
            : this(true)
        {
            variable = 20;
        }
        public A(bool isTrue)
        {
            variable = 30;
        }
        #endregion


        #region Example of Value type and Ref Type
        public void SetData()
        {
            int i = 0;
            int j = 1;

            // this is value type
            CalculateValueType(i, j);
            Console.WriteLine(i.ToString());

            // this is ref type
            CalculateRefType(ref i, j);
            Console.WriteLine(i.ToString());

            // When passing object, it will be always a referance type
            MethodOverRidingChild a = new MethodOverRidingChild();
            a.TestValueTypeRefType = 10;
            CalculateObjectType(a);
            Console.WriteLine(a.TestValueTypeRefType.ToString());


        }

        public void CalculateRefType(ref int i, int j)
        {
            i = 10;
            j = 15;
        }
        public void CalculateValueType(int i, int j)
        {
            i = 10;
            j = 15;
        }

        public void CalculateObjectType(MethodOverRidingChild a)
        {
            a.TestValueTypeRefType = 15;
        }

        #endregion

        public int Calculate(float i, int j) { return 0; }

        public virtual void Print()
        {
            Console.WriteLine("Print Base");
        }

        private void Clear()
        {
            Console.WriteLine("Clear");
        }
    }
    public class B : A
    {
        public void Clear()
        {
            Console.WriteLine("Clear");
        }

      

    }
    public class C : A
    {

    }
    public class D : A
    {
        public override void Print()
        {
            Console.WriteLine("Print Child");
        }
    }


    // Differance between Interface Vs Abstract Class
    // 1 Interface has only implemetation where as Abstract Class has Abstract as well as defined methods
    // 2 Interface has to be implemented where as Abstract Class has to be inherited
    // 3 All the methods of interface has to be implemented where as the method which is declared as abstract method has to be override
    // 4 We can not create object of Abstract Class, it should be used as Base Class    


    #region Interface Example

    interface int1
    {
        int MyProperty { get; set; }
        void GetData();
    }
    interface int2
    {
        void GetData();
    }
    public class ImplemtInterface : int1, int2
    {

        #region Implicit Implemetation of InterFace

        public void GetData()
        {
            Console.WriteLine("Implicite Implementaion");
        }

        #endregion

        //#region Explicit Implementation of Interface

        //void int1.GetData()
        //{
        //    Console.WriteLine("Explicit Implementation int1.GetData()");
        //}

        //void int2.GetData()
        //{
        //      Console.WriteLine("Explicit Implementation int2.GetData()");
        //}

        //#endregion



        public int MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
    #endregion


    #region PolyMorphism
    public class MethodOverRidingBase
    {
        public virtual void Calculate()
        {
            Console.WriteLine("MethodOverRidingBase");
        }

    }

    public class MethodOverRidingChild : MethodOverRidingBase
    {

        public int TestValueTypeRefType { get; set; }
        public override void Calculate()
        {
            Console.WriteLine("MethodOverRidingChild");
        }
        //public void GetData(int x, int y) { }

        #region Method Overloading
        
        //public int GetData(int x, int y) { return 0; }

        //public int GetData(int x, int y, int z = 0) { return 0; }

        //public int GetData(int x, ref int y) { return 0; } 
        #endregion

    }

    #endregion

    #region Constructor


    /// <summary>
    /// 1 When we are creating a parameterised constructor and inheriting that class, then we must have default constructor in Base class
    /// </summary>
    public class ConstructorBase
    {
        public ConstructorBase() { }
        public ConstructorBase(int i) { }
    }
    public class ConstructorChild : ConstructorBase
    {
        public ConstructorChild()
        {
        }
    }


    /// <summary>  Sealed VS Static Class
    ///  Differance Between Sealed VS Static Class
    ///  1 Both can not be inherited
    ///  2 Static class contains only static methods where as Sealed can contains both
    ///  3 Method of static class can be called by Class name where as method of sealed class can be called by creating object
    /// </summary>

    public sealed class SealedClass
    {
        public void SealedClassMethod()
        {
            Console.WriteLine("SealedClassMethod Called");
            Console.ReadLine();
        }
        public static void StaticSealedClassMethod()
        {
            Console.WriteLine("SealedClassMethod Called");
            Console.ReadLine();
        }
    }
    public static class StaticClass
    {
        public static void StaticClassMethod()
        {
            Console.WriteLine("StaticClassMethod Called");
            Console.ReadLine();
        }
    }


    /// <summary>  Abstract VS Simple Class
    ///  Differance Between Abstract class and Simple Class
    ///  1 All methods are in Simple class are defined methods, where as Abstract class can have virtual methods
    ///  2 All Abstract methods must be override in derived class
    ///  3 Instance of an abstract class can not be created
    /// </summary>

    public abstract class AbstractClass
    {
        public void GetData()
        {

        }
        public abstract void SetData();
    }

    public class ImplementingAbstractClass : AbstractClass
    {
        public override void SetData()
        {
        }
    }

    /// Read Only, Static and Constant
    /// 1 Constant value is set at compile time i.e while creating constant variable.
    /// 2 Readonly variable's value can be set at declaration as well as in Non Static Constructor. We can not create readonly property.
    /// 3 Static valus can be set at declaration as well as in Static Constructor.

    #endregion
}
