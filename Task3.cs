using System;

namespace Grammar
{
    public static class Grammar
    {
        public static string GetComputerDeclension(int count)
        {
            int lastDigit = count % 10;
            int lastTwoDigits = count % 100;

            if (lastDigit == 1 && lastTwoDigits != 11)
                return count + " компьютер";
            else if (lastDigit >= 2 && lastDigit <= 4 && (lastTwoDigits < 10 || lastTwoDigits >= 20))
                return count + " компьютера";
            else
                return count + " компьютеров";
        }
    }
}
