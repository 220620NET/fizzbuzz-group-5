//3 ---> fizz
//5 ---> buzz
//3 and 5 ---> fizzbuzz

Console.WriteLine("What is the number you'd like me to interate to?");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++) {
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}