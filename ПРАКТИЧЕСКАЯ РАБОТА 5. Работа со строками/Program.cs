//1 ПУНКТУАЦИЯ
Console.WriteLine("Введите строку и мы посчитаем сколько в знаков пунктуации");
string str = Console.ReadLine();
string pattern = ".,;:!?";
int i = 0;
foreach (char item in str)
{
    if (pattern.Contains(item))
    {
        i++;
    }
}
Console.WriteLine(i);

//2 УДАЛИТЬ ПОВТОРЫ
string str = Console.ReadLine();
string result = String.Empty;
for (int i = 0; i < str.Length; i++)
{
    if (!result.Contains(str[i]))
    {
        result = result + str[i];
    }
}
Console.WriteLine(result);

//3 ВСЕ РАЗЛИЧНЫЕ ЦИФРЫ
string str = Console.ReadLine();
string result = String.Empty;
foreach (char item in str)
{
    if (Char.IsDigit(item))
    {
        if (!result.Contains(item))
        {
            result = result + item;
        }
    }
}
if (result == String.Empty)
{
    result = "NO";
}
Console.WriteLine(result);

//4 ПОВТОРЯЮЩИЕСЯ ЦИФРЫ
string str = Console.ReadLine();
string numberStr = String.Empty;
string result = String.Empty;
foreach (char item in str)
{
    if (!result.Contains(item))
    {
        result = result + item;
    }
}
foreach (char item in result)
{
    int count = 0;
    foreach (char symbol in str)
    {
        if (item == symbol)
        {
            count++;
        }
    }
    if (count > 1 && Char.IsDigit(item))
    {
        numberStr = numberStr + item;
    }
}
Console.WriteLine(numberStr);

//5 ПРАВИЛЬНОЕ ИМЯ ПЕРЕМЕННОЙ
string str = Console.ReadLine();
string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890_";
str = str.ToLower();
if (Char.IsDigit(str.First()))
{
    Console.WriteLine("NO");
    return;
}
foreach (char c in str)
{
    // Если символ не содержится в pattern, выводим "NO" 
    if (pattern.IndexOf(c) == -1)
    {
        Console.WriteLine("NO");
        return;
    }
}
Console.WriteLine("YES");

//6 СКОЛЬКО РАЗЛИЧНЫХ СИМВОЛОВ
string str = Console.ReadLine();
int uniqueCount = 0;
string uniqueCharacters = "";

foreach (char c in str)
{
    if (uniqueCharacters.IndexOf(c) == -1)
    {
        uniqueCharacters += c;
        uniqueCount++;
    }
}

Console.WriteLine(uniqueCount);

//7 ЦИФРЫ, КОТОРЫХ НЕТ
string str = Console.ReadLine();
string result = String.Empty;
string pattern = "0123456789";

foreach (char item in str)
{
    if (char.IsDigit(item))
    {
        pattern = pattern.Replace(item.ToString(), "");
    }
}

if (pattern.Length == 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine(pattern);
}

//8 БУКВЫ, КОТОРЫХ НЕТ
static void Main(string[] args)
{
    Console.WriteLine("Введите первую строку:");
    string str1 = Console.ReadLine();
    Console.WriteLine("Введите вторую строку:");
    string str2 = Console.ReadLine();

    string result = FindMissingLatinLetters(str1, str2);

    Console.WriteLine("Отсутствующие латинские буквы: ");
    if (result == "")
    {
        Console.WriteLine("0");
    }
    else
    {
        Console.WriteLine(result);
    }
}

static string FindMissingLatinLetters(string str1, string str2)
{
    str1 = str1.ToUpper();
    str2 = str2.ToUpper();
    string missingLetters = "";

    for (char letter = 'A'; letter <= 'Z'; letter++)
    {
        if (!str1.Contains(letter) && !str2.Contains(letter))
        {
            missingLetters += letter;
        }
    }

    return missingLetters;
}


//9 ОБЩИЕ СИМВОЛЫ
Console.WriteLine("Введите первую строку:");
string str1 = Console.ReadLine().ToLower();

Console.WriteLine("Введите вторую строку:");
string str2 = Console.ReadLine().ToLower();

Console.WriteLine("Символы, встречающиеся в обеих строках:");

foreach (char ch in str1)
{
    if (str2.Contains(ch))
    {
        int index1 = str1.IndexOf(ch) + 1;
        int index2 = str2.IndexOf(ch) + 1;
        Console.WriteLine($"{ch} встречается в строке 1 на позиции {index1} и в строке 2 на позиции {index2}");
    }
}

if (str1 == "" || str2 == "")
{
    Console.WriteLine("NO");
}

//10 ПРАВИЛЬНОЕ ВОСЬМЕРИЧНОЕ ЧИСЛО
Console.WriteLine("Введите строку для проверки:");
string str = Console.ReadLine();

bool isValidOctalNumber = true;

if (string.IsNullOrWhiteSpace(str))
{
    isValidOctalNumber = false;
}
else
{
    foreach (char digit in str)
    {
        if (digit < '0' || digit > '7')
        {
            isValidOctalNumber = false;
            break;
        }
    }
}

if (isValidOctalNumber)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

//11 ПРАВИЛЬНОЕ ШЕСТНАДЦАТЕРИЧНОЕ ЧИСЛО
Console.WriteLine("Введите строку для проверки:");
string str = Console.ReadLine();

bool isValidHexadecimalNumber = true;

if (string.IsNullOrWhiteSpace(str))
{
    isValidHexadecimalNumber = false;
}
else
{
    // Удалите возможные префиксы "0x" или "0X"
    if (str.StartsWith("0x") || str.StartsWith("0X"))
    {
        str = str.Substring(2);
    }

    foreach (char digit in str)
    {
        if (!IsHexadecimalDigit(digit))
        {
            isValidHexadecimalNumber = false;
            break;
        }
    }
}

if (isValidHexadecimalNumber)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


// Функция для проверки, является ли символ шестнадцатеричной цифрой (0-9, A-F, a-f)
static bool IsHexadecimalDigit(char digit)
{
    return (digit >= '0' && digit <= '9') ||
           (digit >= 'A' && digit <= 'F') ||
           (digit >= 'a' && digit <= 'f');
}