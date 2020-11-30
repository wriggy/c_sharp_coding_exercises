using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            return firstName.Substring(0, 1).ToUpper() + '.' + lastName.Substring(0, 1).ToUpper();
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            double newPrice = Math.Round(originalPrice * (100+vatRate),0)/100;
            return newPrice;
        }

        public static String Reverse(String sentence)
        {
            String newSentence = "";
            for (int i=sentence.Length-1; i>=0; i--) {
                newSentence += sentence[i];
            }
            return newSentence;
        }

        public static int CountLinuxUsers(List<User> users)
        {
            int count = 0;
            foreach(User usr in users) {
                if (usr.Type == "Linux") {
                    count += 1;
                }
            };
            return count;
        }
    }
}
