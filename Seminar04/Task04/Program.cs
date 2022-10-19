//Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом

int[] items = new int[10];

void GetRandom(int[] input)
{
    int[] arg = input;
    for (int i = 0; i < arg.Length; i++)
    {
        Random tmp = new Random();

        arg[i] = tmp.Next(0, 11);
        Console.WriteLine(arg[i]);
    }
    int firstMax = 0, secondMax = 0;

    /*if (arg[0] > arg[1])
    {
        secondMax = arg[1];
        firstMax = arg[0];
    }
    else
    {
        secondMax = arg[0];
        firstMax = arg[1];
    }*/

    for (int i = 0; i < arg.Length; i++)
    {
        // use >= n not just > as max and second_max can hav same value. Ex:{1,2,3,3}   
        if (arg[i] > firstMax)
        {
            secondMax = firstMax;
            firstMax = arg[i];
        }
        else if (arg[i] > secondMax)
        {
            if(arg[i] >= firstMax) continue; 
            secondMax = arg[i];
        }
    }

    Console.WriteLine("1ый максимум: " + firstMax);
    Console.WriteLine("2ой максимум: " + secondMax);

}

GetRandom(items);
