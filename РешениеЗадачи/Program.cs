/* Написать программу, которая из имеющего массива строк сформирует массив из строк, длина которых меньше либо равно 3 симвалам.
Первоначальный массив можно ввести с клавиатуры либо задать с начала выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"]  ->   ["2", ":-)""]
["1234", "1567", "-2", "computer sience"]   ->  ["-2"]
["Russia", "Denmark", "Kazan"]   ->  []
*/

string[] CreateArray(int N)
{
    string[] Array = new string[N];
    Console.WriteLine($"Введите элементы массива строк в количестве {N}:");
    for (int i = 0; i < N; i++)
    {
        Array[i] = Console.ReadLine();
    }
    return Array;
}

void SecondArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] array2 = new string[count];
    Console.WriteLine("Элементы длиной меньше либо равно 3: ");
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            Console.Write(array2[count] + " ");
            count++;
        }
    }
}
