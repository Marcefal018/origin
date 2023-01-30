// Первый вид метода( Не принимают никаких аргументов, и ничего не возвращают)

void Method1()
{
    Console.WriteLine("Автор ....");
}
//Method1();

// Второй вид метода ( Принимает какие-то аргументы, но ничего не возвращает)

void Method2(string massage)
{
    Console.WriteLine(massage);
}
//Method2("Текст сообщения");

void Method21( string massage, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(massage);
        i ++;
    }
}
//Method21(massage :"Текст", count : 4);


// Третий вид метода(Могут что-то возвращать , но не принимают никаких аргументов(служат для того , чтобы генерировать какие-то случайные данные)

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


// Четвертый вид метода (Принимают какие то аргументы  и возвращают)

/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);*/

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)//Пример программы 4го вида через for.
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);


// Пример цикла в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    System.Console.WriteLine();
}