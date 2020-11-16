using System;
 
namespace MyApp
{
    class Employee
    {
       
        public int experience;
        public int level;
        public string lname;
        public string fname;
        public int bonus; 

        public void getBonusPercent()
        {
            Console.WriteLine($"Имя: {fname} Фамилия: {lname}  Стаж: {experience} Уровень: {level} Бонус: {bonus}");
        }
    }
    class Program
{
    static void Main(string[] args)
    {
         Employee Test = new Employee();
         Test.fname = "Peter";
         Test.lname = "Pan";
         Test.experience = 8;
         Test.level = 2;
       {
         for (int level = 1; level <= 5; ++level)
         {if (Test.experience < 1)
           {
                Test.bonus = 0;
           }
           else if ( Test.experience < 5)
           {
                Test.bonus = 5;
           }
           else if ( Test.experience >= 5 &&  Test.level < 3)
           {
                Test.bonus = 10;
           }
            else if ( Test.experience > 5 && (( Test.level >= 3) && ( Test.level <=  4)))
            {
                 Test.bonus = 15;
            }
            else if (( Test.experience > 5) && ( Test.level == 5))
            {
                Test.bonus = 20;
            }

         }
       }
              
        Test.getBonusPercent();  
        Console.ReadKey();
    }
}
}