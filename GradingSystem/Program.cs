using Unity;

namespace GradingSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {


            var students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Hello teacher Mohamed amin .. [ O_O ] :");
                Console.Write("Please enter student's name or `done`  if y'hve finished :   "); var student_name = Console.ReadLine();
                Console.WriteLine();
                if (student_name.ToLower() == "done")
                {
                    break;
                }
                Student S = new Student() { Fname = student_name };
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter the degrees in order : "); int degree = int.Parse(Console.ReadLine()!);
                    S.Grades.Add(degree);

                }

                students.Add(S);
            }

            // Logic of avg  , passed , viewing

             var unityContainer = new UnityContainer();
             unityContainer.RegisterType<IGradingSystem, GradingSystem>();
             IGradingSystem info = unityContainer.Resolve<IGradingSystem>();


            info.ViewGradingInfo(students , (x)=>((double)x.Sum() / x.Count) // avg   
            ,(x)=> x >= 30 ,  // if passed or not 

            (x, y, z)=> {// viewing
                Console.WriteLine($"The student `{x.Fname} has got average : `{y}`. The status passed is : `{z}` ");
            
            } ) ;




        }
    }
}
