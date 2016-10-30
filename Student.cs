using System;

namespace CollectionsAndIteration
{
    public class Student
    {
        public Student()
        {
            
        }
        public Student(string name)
        {
            this.FirstName = name;
        }

        public Student(string name, int caffeineLevel)
        {
            this.FirstName = name;
            this.CaffeineLevel = caffeineLevel;
        }

        public int StressLevel {get;set;}
        
        public int CaffeineLevel {get;set;}

        public string FirstName {get;set;}

        public bool FinishedHomework()
        {
            return true;
        }
    }
}