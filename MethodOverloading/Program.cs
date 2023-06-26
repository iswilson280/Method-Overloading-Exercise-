namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
           var answer = MethodOverloading.Add(2,4);
            Console.WriteLine(answer);
            var answer1= MethodOverloading.Add(3.4m, 4.3m);
            Console.WriteLine(answer1);

            var answer2= MethodOverloading.Add(7, 3, true);
            Console.WriteLine(answer2);


        }
        
    }
}
