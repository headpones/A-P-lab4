class Program
{
    static void Main()
    {
        int n = 10; // довжина масиву
        int[] array = new int[n];
        Random random = new Random();

        // Заповнення масиву випадковими числами в діапазоні [-10; 10]
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-10, 11); // Random.Next(min, max+1)
        }

        // Виведення вихідного масиву
        Console.WriteLine("Вихідний масив:");
        Console.WriteLine(string.Join(" ", array));

        // Обчислення суми елементів, значення яких є меншим за значення першого елемента
        int firstElement = array[0];
        int sum = 0;

        foreach (int element in array)
        {
            if (element < firstElement)
            {
                sum += element;
            }
        }

        // Виведення результату
        Console.WriteLine($"\nСума елементів, менших за перший елемент ({firstElement}): {sum}");
    }
}