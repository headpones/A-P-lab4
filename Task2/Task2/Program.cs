class Program
{
    static void Main()
    {
        // Введення довжини масиву
        Console.Write("Введіть довжину масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Random random = new Random();

        // Заповнення масиву випадковими числами в діапазоні [-10; 20]
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-10, 21); // Random.Next(min, max+1)
        }

        // Виведення вихідного масиву
        Console.WriteLine("\nВихідний масив:");
        Console.WriteLine(string.Join(" ", array));

        // Обчислення суми тільки двоцифрових елементів
        int sum = 0;
        foreach (int element in array)
        {
            if (Math.Abs(element) >= 10 && Math.Abs(element) <= 99)
            {
                sum += element;
            }
        }

        // Виведення результату
        Console.WriteLine($"\nСума двоцифрових елементів масиву: {sum}");
    }
}