int sum = 0;

//for loop sum
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"i = {i}; Current total = {sum}");
    sum = sum + i; //sum += i;
}

Console.WriteLine($"Final total = {sum}");



