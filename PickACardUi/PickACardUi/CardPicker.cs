using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUi
{
    public class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCard (int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1,5);
            if (value == 1) return "Бубна";
            if (value == 2) return "Чирва";
            if (value == 3) return "Трефа";
            return "Піка";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Туз";
            if (value == 11) return "Валет";
            if (value == 12) return "Дама";
            if (value == 13) return "Король";
            return value.ToString();
        }
    }
}
