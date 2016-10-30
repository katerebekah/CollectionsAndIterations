using System;
using System.Collections.Generic;

namespace CollectionsAndIteration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Uses contructor that takes string name
            Student ryan = new Student("Ryan");

            //Uses constructor that takes string name and int caffeine level
            Student paul = new Student("Paul", 1);

            //Uses empty contructor
            Student anon = new Student();

            //Even if you don't set a property in the constructor, you can still add it later
            anon.FirstName = "Anon";


            //Lists always have a type - and that type can't change
            //This list contains Student objects
            List<Student> myStudents = new List<Student>();

            //Adding items to a list is really easy
            myStudents.Add(ryan);
            myStudents.Add(paul);
            myStudents.Add(anon);
            
            //Lists can be enumerated over
            //this foreach loop is going over each person in the mrStudents list
            //I could use a regular for (var i = 0; i < myStudents.length; i++) loop instead
            foreach (var student in myStudents)
            {
                Console.WriteLine(student.FirstName);
            }

            //I didn't implement a constructor for Classroom
            //so I can just () 
            Classroom katesClass = new Classroom();

            //I can set the properties of type class just like I can a property of type string 
            katesClass.Students = myStudents;

            //.Count is a property on List that returns how many items are in a list
            Console.WriteLine("Kate has " + myStudents.Count + "in her classroom.");

            //.Contains is a method on List that will tell you if something exists inside the List
            Console.WriteLine(myStudents.Contains(anon).ToString()); //<--I used ToString() to change a bool true/false to a string "true"/"false"

            //[] means it's an array
            //the type comes first in an array - like string[] or int[]
            //items in an array can be changed but the length of an array cannot
            //to create a new array, you have to let the compiler know how many objects are in the array
            //This tells the compiler by setting the items manually
            int[] studentIds = new int[]{1, 4, 6};
            
            //You can also just tell it how many without specifying what the are by using this format
            int[] studentIdentifications = new int[3];
            //the 3 tells the compiler how many spaces are in the array
            //but doesn't give them values, so if you were to look at what's inside studentIdentifications, the 3 spaces are null
            
            
            
            //This will throw an exception because you can't change the number of items in an array 
            //studentIds[3] = 5;

            //this is an array of lists of strings
            //you can't add any more lists to the array once it's instantiated
            List<string>[] sillyArray = new List<string>[]
            {
                new List<string>()
            };

            //You can still add items to a List, even if it is an array
            sillyArray[0].Add("Bob");
            

            //Dictionaries are a collection of key, value pairs
            //The keys and values can be any type
            //But, like everything else, you have to specify the type of the key and the value
            Dictionary<string, bool> myRollBook = new Dictionary<string, bool>();

            //Like Lists, you can use a .Add() method that adds the key and value to the dictionary
            myRollBook.Add("Bob", false);

            //You retrieve the value out of a dictionary by the key
            Console.WriteLine("Bob's homework is completed is a " + myRollBook["Bob"].ToString() + " statement.");

            myRollBook.Add("Susan", false);
            
            //You can't add more than one item with the same key to a dictionary
            //It will throw an exception and crash your program
            //myRollBook.Add("Bob", true);

            //You can a key's value
            myRollBook["Bob"] = true;

            //Most of the collections we use can't use a .ToString() method
            //A ToString() method here prints out the type, not each of the keys
            Console.WriteLine(myRollBook.Keys.ToString());

            //myRollBook.keys is a collection of keys you can loop over
            foreach ( var key in myRollBook.Keys)
            {
                //you can print out the key
                Console.WriteLine(key);
                //and you can fetch the value from the dictionary of that key
                Console.WriteLine(myRollBook[key].ToString());
            }


            Console.ReadKey();
        }
    }
}
