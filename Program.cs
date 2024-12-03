using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Add name, course number, and CRN as a multi-line comment at the beginning of the code.
/* Isabella Tomaesk
 * Course Number: 1050
 * CRN: 86411
 * */
namespace CompetencyLabSix
{
    class Program 
   {
      public static void Main (string[] args) 
      {
            //7. Create an object called student1.
            Student student1 = new Student();

            //8. Output the value of the name property (student1.name) inside of a Console.WriteLine().
            Console.WriteLine(student1.name);

            //9. Output the return value from student1.getMajor().
            Console.WriteLine(student1.getMajor());

            //10. Output the return value from student1.getCourse().
            Console.WriteLine(student1.getCourse());

            //11. Call printName() to output name again.
            student1.printName();
      }  
    } 
    
    //2. Create a class named Student.
    class Student
    {
       //3. Add a property called name. Assign your name to the name property.
       public string name = "Isabella Tomasek";  
       private string major = "Computer Science"; 
       private string course = "IT 1050 - Programming Logic";

        //4. Add a method called getMajor(). Have it return the major you are currently pursuing at Tri-C.
        public string getMajor()   
        {
         return major;
        }

        //5. Add a method called getCourse(). Have it return our course number and course title as listed on the syllabus.
        public string getCourse()
        { 
         return course; 
        }

        //6. Add a method called printName. It should not return any values. In the body of the method, add the following line: Console.WriteLine(this.name);
        public void printName()      
        {
         Console.WriteLine(this.name);
        }
    } 
}
