static bool PrimeNumber(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }

            for (int a = 2; a <= num / 2; a++)
            {
                if (num % a == 0)
                {
                    return false;
                }
            }
            return true;
        }