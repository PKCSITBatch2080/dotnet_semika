//LINQ- Language Integrated Query
using System.Linq;

class LINQLearner
{
    void Learn()
    {
        int[] numbers = [3, 4, 5, 67, 12, 34, 56, 78, 89, 98, 123]; 
        List<string> names = ["Seema", "Rita", "Sapana", "Smriti", "Anjana"];
        
        var s1 = new Student("bishnu", 12, new DateTime(1998, 12, 12));
        var s2 = new Student("ram", 12, new DateTime(2005, 12, 15));
        var s3 = new Student("seema", 12, new DateTime(1994, 2, 11));
        var s4 = new Student("laxman", 12, new DateTime(2003, 9, 16));

        List<Student> students = [s1, s2, s3, s4]

         //get odd numbers from numbers
         var oddNUmbers = numbers.Where(numbers => numbers % 2 ==1);   //Lamda expression or arrow function

         //Get square of all items in numbers
         var squares = numbers.Select(x=> x * x);
         
         //Get squares of even numbers only
         //Method Syntax
         var evenSquares = numbers.Where(x => x % 2 == 0).Select(y => y * y);
          
         //Query syntax
         evenSquares = from x in numbers
                        where x % 2 ==0
                        select x * x;  

         //get all names initials
         var initials = nameof.Select(nameof => name[0]); 

         //order names in ascending order     
         var namesOrdered = names.OrderBy(x => x);

         //find students
         var bStudents = students.Where(students => students.name.ToLower().StartsWith('b'));

         //group students by birth month
         var dobGroups = students.GroupBy(students => students.Dob.Month);

         //get youngest student
         var youngest = students.OrderByDescending(x=> x.Dob).First(); 
         youngest = students.MaxBy(x => x.Dob)

        //  youngest = studemts.FirstOrderDefault(x => Datetime.Now - x.Dob);
         
   }
}