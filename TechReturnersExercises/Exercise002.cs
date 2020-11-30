using System;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person)
        {
            if (person.City == "Manchester")
            {
                return true;
            }
            return false;
        }

        public static bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person.Age >= ageLimit)
            {
                return true;
            }
            return false;
        }
    }
}
