using sec4.InterFace;
using sec4.interface_example_2;
using sec4Demo;

namespace sec4
{
    internal class Program
    {
        #region exaple2
        //static void printTenNumberSeries(Iseries series)
        //{
        //    if (series is null)
        //    {
        //        return;
        //    }
        //    for (int i = 1; i < 10; i++)
        //    {
        //        Console.WriteLine(series.Current);
        //        series.GetNext();

        //    }
        //    series.reset();
        //    Console.WriteLine();
        //} 
        #endregion


        static void Main(string[] args)
        {
            #region example 1;
            //Itype refernece;


            //refernece = /*new Itype()*/ INVALIDE


            //refernece = new TypeA();

            //refernece.Myproperty = 10;

            //refernece.Mymethod(); 
            #endregion

            #region example 2
            //typeA seriesbyTwo = new typeA();

            //printTenNumberSeries(seriesbyTwo);

            //TypeB seriesbyThree = new TypeB();
            //printTenNumberSeries(seriesbyThree);

            //type4 seriesbyfour = new type4();
            //printTenNumberSeries(seriesbyfour); 
            #endregion

            #region Shallow copy vs  deep copy
            //int[] Arr01 = [1,2,3];
            //int[] Arr02 = [4, 5, 6];
            //Console.WriteLine($"Arr01.gethasCode()= {Arr01.GetHashCode()} ");
            //Console.WriteLine($"Arr02.gethasCode(){Arr02.GetHashCode()}");
            //Arr02 = Arr01;
            //Arr02 = (int[])Arr01.Clone();
            //Console.WriteLine($"arr.01.gethash()= {Arr01.GetHashCode()}");
            //Console.WriteLine($"arr.01.gethash()= {Arr01.GetHashCode()}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); 
            #endregion
            #region MyRegion String shallow

            //string[] Names01 = ["amr", "mona"];
            //string[] Names02 = ["amhed", "yassmin"];
            //Console.WriteLine($"Names01.GethashCode() {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GethashCode() {Names02.GetHashCode()}");

            //Names02 = (string[]) Names01.Clone();
            //Console.WriteLine($"Names01.gethashcode= {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.gethashcode= {Names02.GetHashCode()}");

            //Names02[0] = new string("Khaled");

            //Console.WriteLine(Names01[0]); 
            #endregion

            #region built in interface
            //Employee employee1 = new Employee() { Id = 10, Name = "ahmed", Salary = 8_000, department = new department() { Code = 100, Tilte = "sales" } };
            //Employee employee2 = new Employee() { Id = 20, Name = "omnia", Salary = 4_000, department = new department() { Code = 200, Tilte = "sales" } };
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //employee2 = (Employee)employee1.Clone();
            //Console.WriteLine("after deep copy ");
            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode()); 
            //employee2 = new Employee(employee1);
            #endregion


        }
    }
}

