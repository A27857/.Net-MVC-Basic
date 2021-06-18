using System;
using System.Collections.Generic;
namespace C__Fundamental__1
{
    public class ClassStudent : Student
    {
        List<Student> Students = new List<Student>();
       // List<string> FullName = new List<string>();
       List<string> Fname = new List<string>();
        List<Student> L1 = new List<Student>();
        List<Student> L2 = new List<Student>();
        List<Student> L3 = new List<Student>();
        Student temp;
        public void ImportClass()
        {
            Console.WriteLine("Enter student number: ");
            int N = int.Parse(Console.ReadLine());
            for(int i=0; i<N; i++)
            {
                Console.WriteLine("Student {0}: ", i+1);
                temp = new Student();
                temp.ImportStudent();
                Students.Add(temp);
            }
        }
        public void CheckMale()
        {       
            List<Student> MaleStudent = new List<Student>();  
            Student temp = Students[0];
            for(int i=0; i<Students.Count; i++)
            {
                if(Students[i].Gender == "Male")
                {
                    temp = Students[i];
                    MaleStudent.Add(temp);
                }
            }
            foreach (var item in MaleStudent)
            {
                item.ExportStudent();
            }

        }
        public void OldestAge()
        {
            List<Student> OldMale = new List<Student>();
            Student oldAge = Students[0];
            for(int i=0; i<Students.Count; i++)
            {
                if(oldAge.Age > Students[i].Age)
                {
                    Students[i] = oldAge;
                    OldMale.Add(Students[i]);
                }
                // for(int j=1; j<Students.Count; j++)
                // {
                //     if(Students[i].Age < Students[j].Age)
                //     {
                //         oldAge = Students[j];
                //     }
                //     else if(Students[i].Age == Students[j].Age)
                //     {
                //         if(Students[i].DateOfBirth.ToUniversalTime() < Students[j].DateOfBirth.ToUniversalTime())
                //         {
                //             oldAge = Students[i];
                //         }
                //     }
                //     else
                //     {
                //         oldAge = Students[i];
                //     }
                // }
                // oldAge.ExportStudent();
                // break;
            }  
            for(int i=0; i<OldMale.Count; i++)
            {
                OldMale[i].ExportStudent();              
            }
            Console.WriteLine("First Student OldestMale is: ");
            OldMale[0].ExportStudent();
            // foreach (var item in OldMale)
            // {
            //     item.ExportStudent();
            // }
            
        }
        public void ShowName()
        {
            foreach(var st in Students)
            {
                //Fname.Add(st.FullName);
                Fname.Add(st.LastName + " " + st.FirstName);
            }
            foreach(var temp in Fname)
            {
                Console.WriteLine(temp);
            }
        }
        public void Student2K()
        {
            foreach (var st in Students)
            {
                switch (st.DateOfBirth.Year)
                {
                    case 2000:
                        L1.Add(st);
                        break;
                    default:
                        if (st.DateOfBirth.Year > 2000)
                        {
                            L2.Add(st);
                        }
                        if (st.DateOfBirth.Year < 2000)
                        {
                            L3.Add(st);
                        }
                        break;
                }
            }
            Console.WriteLine("List of member who has birth year is 2000: ");
            foreach (var item in L1)
            {
                item.ExportStudent();
            }
            Console.WriteLine("List of member who has birth year greater than 2000: ");
            foreach (var item2 in L2)
            {
                item2.ExportStudent();
            }
            Console.WriteLine("List of member who has birth year less than 2000: ");
            foreach (var item3 in L3)
            {
                item3.ExportStudent();
            }
        }
        public void FirtBornHN()
        {   
            while(true)
            {
                String Address = "ha noi";
                for (int i = 0; i < Students.Count ; i++)
                {
                    if(Students[i].BirthPlace.Equals(Address) == true)
                    {
                    Console.WriteLine("The first person who was born in HN: ");
                    Students[i].ExportStudent();
                    break;
                    }
                }
            }
        }
    }
}