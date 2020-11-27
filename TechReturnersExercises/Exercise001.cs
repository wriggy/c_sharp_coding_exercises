using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word)
        {
            // Add your code here!
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
            //throw new NotImplementedException();
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            // Add your code here!
            return firstName.Substring(0, 1).ToUpper() + '.' + lastName.Substring(0, 1).ToUpper();
            //throw new NotImplementedException();
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            // Add your code here!
            double newPrice = Math.Round(originalPrice * (100+vatRate),0)/100;
            return newPrice;
            //throw new NotImplementedException();
        }

        public static String Reverse(String sentence)
        {
            // Add your code here!
            String newSentence = "";
            for (int i=sentence.Length-1; i>=0; i--) {
                newSentence += sentence[i];
            }
            return newSentence;
            //throw new NotImplementedException();
        }

        public static int CountLinuxUsers(List<User> users)
        {
            // Add your code here!
            int count = 0;
            foreach(User usr in users) {
                if (usr.Type == "Linux") {
                    count += 1;
                }
            };
            return count;
            //throw new NotImplementedException();
        }
    }
}
