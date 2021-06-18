    using System;

    namespace C__Fundamental__1
    {
        public class Student
        {
            public string FirstName, LastName, Gender, BirthPlace, PhoneNumber;
            public string FullName;
        public DateTime DateOfBirth;
            public int Age;
            public bool IsGradudate;

            public string fullName
            {
                get 
                {
                string v = LastName + FirstName;
                return v;
                }
                set
                {
                    FullName = value;
                }
            }
            public void ImportStudent()
            {
                Console.Write("FirstName is: \n");
                FirstName = Console.ReadLine();

                Console.Write("LastName is: \n");
                LastName = Console.ReadLine();

                Console.Write("Gender is: \n");
                Gender = Console.ReadLine();

                Console.Write("BirthPlace is: \n");
                BirthPlace = Console.ReadLine();
                
                Console.Write("PhoneNumber is: \n");
                PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter the form: Year, Month, Day");
                Console.Write("DateOfBirth is: \n");
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Age is: \n");
                Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("IsGradudate is: \n");
                IsGradudate = Convert.ToBoolean(Console.ReadLine());
            }

            public void ExportStudent()
            {
                Console.WriteLine("FirstName: {0} || LastName: {1} || Gender: {2} || BirthPlace: || {3} PhoneNumber: {4} || DateOfBirth: {5} || Age: {6} || IsGradudate: {7}", FirstName, LastName, Gender, BirthPlace, PhoneNumber, DateOfBirth, Age, IsGradudate);
            }

        }
    }