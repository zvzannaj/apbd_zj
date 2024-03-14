static double GetAverage(int[] numbers)
{
    double result = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result / numbers.Length;
}

static int GetMax(int[] tab)
{
    if (tab.Length >= 1)
    {

        int max = tab[0];
        if (tab.Length >= 1)
            max = tab[0];
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] > max)
                max = tab[i];
        }

        return max;
    }

    return -1; 
}


