using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // for (int i = 1; i < 255 ; i ++){
            //   Console.WriteLine(i);
            // }
            // for (int i = 1; i <= 100; i++){
            //     if(i % 3 == 0 && i % 5 == 0){
            //         Console.WriteLine("error");
            //     }
            //     else if(i % 3 == 0 || i % 5 == 0){
            //         Console.WriteLine(i);
            //     }
            // }
            // for (int i = 1; i <=100; i ++){
            //     if( i % 3 ==0 && i % 5 == 0){
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if ( i % 3 == 0 ){
            //         Console.WriteLine("Fizz");
            //     }
            //     else if ( i % 5 == 0 ){
            //         Console.WriteLine("Buzz");
            // }
                // int[] numArray2;
                // numArray2 = new int[] {1,2,3,4,5,6,7,8,9};
                // Console.WriteLine(numArray2[3]);
                // string[] myNames = new string[4] { "Tim", "Martin", "Nikki", "Sara"};
                // Console.WriteLine(myNames[3]);
                // bool[] truther = new bool[4] {true, false, true, false};
                // Console.WriteLine(truther[3]);

            Dictionary<string,dynamic> profile1 = new Dictionary<string,dynamic>();
                profile1.Add("Name", "Cassidy");
                profile1.Add("Language", "Python");
                profile1.Add("Pets", 0);
                profile1.Add("Ice Cream", true);
            Dictionary<string,dynamic> profile2 = new Dictionary<string,dynamic>();
                profile2.Add("Name", "Preeya");
                profile2.Add("Language", "Python");
                profile2.Add("Pets", 0);
                profile2.Add("Ice Cream", true);
            Dictionary<string,dynamic> profile3 = new Dictionary<string,dynamic>();
                profile3.Add("Name", "Cindy");
                profile3.Add("Language", "Python");
                profile3.Add("Pets", 0);
                profile3.Add("Ice Cream", true);
            Dictionary<string,dynamic> profile4 = new Dictionary<string,dynamic>();
                profile4.Add("Name", "Somebody");
                profile4.Add("Language", "Python");
                profile4.Add("Pets", 0);
                profile4.Add("Ice Cream", true);

            List<object> dicts = new List<object>();
                dicts.Add(profile1);
                dicts.Add(profile2);
                dicts.Add(profile3);
                dicts.Add(profile4);
            
            var profiles = new List<Dictionary<string,dynamic>>();
               profiles.Add(profile1);
               profiles.Add(profile2);
               profiles.Add(profile3);
               profiles.Add(profile4);

           for(int i = 0; i < profiles.Count; i++) {
               foreach (var entry in profiles[i]) {
                   Console.WriteLine(entry.Key + " - " + entry.Value);
               }
           }
        }
    }
}