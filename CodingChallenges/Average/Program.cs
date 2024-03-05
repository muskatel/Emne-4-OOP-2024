
List<int> nums = new List<int>(){2,2,4,8,23,42,15,15,15,16,16,17,17};
List<int> nums2 = new List<int>(){1,2,3,3,4,5,4,3,2,1};
Average(nums);
Median(nums2);
Mode(nums2);
Max(nums);

int i= 0;

void Average(List<int> numbers)
{
    float sum = numbers.Sum();
    Console.WriteLine($"Average: {sum/(numbers.Count)}");
}

void Median(List<int> numbers)
{
    int middle = (numbers.Count / 2) - 1;
    float medain = numbers[middle];
    if (numbers.Count % 2 == 0)
    {
        medain += numbers[middle + 1];
        medain /= 2;
    }
    
    Console.WriteLine($"Median: {medain}");
}

void Mode(List<int> numbers)
{
    Dictionary<int, int> mode_calc = new Dictionary<int, int>();
    foreach (int number in numbers)
    {
        if (mode_calc.ContainsKey(number))
        {
            mode_calc[number] += 1;
        }
        else
        {
            mode_calc.Add(number, 1);
        }
    }


    int maxKey = mode_calc.First().Key;
    int maxValue = mode_calc.First().Value;
    
    foreach (KeyValuePair<int,int> pair in mode_calc)
    {
        if (pair.Value > maxValue)
        {
            maxKey = pair.Key;
            maxValue = pair.Value;
        }
    }
    
    Console.WriteLine($"Mode: {maxKey}");
}

void Max(List<int> numbers)
{
    /*
    numbers.Sort();
    Console.WriteLine($"{ numbers[^1]}");
    */

    int currentMax = numbers.First();
    for (int j = 0; j < numbers.Count; j++)
    {
        if (numbers[j] > currentMax)
        {
            currentMax = numbers[j];
        }
    }

    Console.WriteLine($"Max: {currentMax}");
    

}

