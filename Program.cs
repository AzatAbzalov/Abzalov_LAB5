//Задание 1
//Console.WriteLine("Введите имена: ");
//string names = Console.ReadLine();
//string[] namelist = names.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine("Имена в алфавитном порядке до имени Маша:");
//for (int i = 0; i < namelist.Length & namelist[i] != "Маша";  i++)
//    Console.WriteLine(namelist[i]);

//Задание 2

//string RemoveSpaces(string str)
//{
//    int i = str.Length - 1;
//    while (i >= 0 & str[i] == ' ')
//    {
//        i--;
//    }
//    return str.Substring(0, i + 1);
//}
//    Console.Write("Введите строку: ");
//    string input = Console.ReadLine();

//    string output = "";
//    string[] words = input.Split(' ');
//    foreach (string word in words)
//    {
//        if (word.Length == 4)
//        {
//            output += "love_is ";
//        }
//        else
//        {
//            output += word + " ";
//        }
//    }
//Console.WriteLine(RemoveSpaces(output));

////Задание 3
// string InsertChar(string s, char c, int n)
//{
//    string output = "";
//    for (int i = 0; i < str.Length; i++)
//    {
//        output += str[i];
//        if ((i + 1) % n == 0 && i != s.Length - 1)
//        {
//            output += c;
//        }
//    }
//    return output;
//  }   
//Console.Write("Введите текст: ");
//string input = Console.ReadLine();
//Console.Write("Введите n: ");
//int n = Convert.ToInt32(Console.ReadLine());
//string output = InsertChar(input, '*', n);
//Console.WriteLine(output);

//Задание 4
//Console.WriteLine("Введите строку: ");
//string S = Console.ReadLine();
//char[] sep = { ' ', ',', ';', ':', '.', '!', '?' };
//string[] SLIST = S.Split(sep, StringSplitOptions.RemoveEmptyEntries);
//int min_i = 0;
//int max_i = 0;
//for (int i = 1; i < SLIST.Length; i++)
//{
//    if (SLIST[i].Length > SLIST[max_i].Length)
//        max_i= i;
//    if (SLIST[i].Length < SLIST[min_i].Length)
//        min_i= i;
//}
//string result = string.Join(", ", Enumerable.Repeat(SLIST[min_i],SLIST[min_i].Length));
//result += ", ";
//result += string.Join(", ", Enumerable.Repeat(SLIST[max_i], SLIST[max_i].Length));
//Console.WriteLine(result);

//Задание 5
//Console.WriteLine("Введите строку: ");
//string S = Console.ReadLine();
//char[] sep = { ' ', ',', ';', ':', '.', '!', '?' };
//string[] SLIST = S.Split(sep, StringSplitOptions.RemoveEmptyEntries);
//SLIST = SLIST.Distinct().ToArray();  //возврат различающихся эл-ов послед-ти
//Console.WriteLine(string.Join(" ", SLIST));

//Задание 6
//using System.Text;
//using static System.Net.Mime.MediaTypeNames;

//StringBuilder SB = new();
//Console.WriteLine("Введите строки: ");
//while (true)
//{
//    string s = Console.ReadLine();
//    if (s == "")
//        break;
//    string[] strings = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//    for (int i = 0; i < strings.Length; i++)
//    {
//        if (i % 3 == 0) SB.Append(strings[i]);
//        else if (i % 3 == 1)
//        {
//            for (int n = strings[i].Length - 1; n >= 0; n--)
//            SB.Append(strings[i][n]);
//        }
//        if (i % 3 != 2 & i != strings.Length - 1) SB.Append(" ");
//    }
//    SB.Append(". ");
//}
//Console.WriteLine(SB);
//Задание 7

using System.Text;

string S = "Киев Нью-Йорк Амстердам Вена Мельбурн";
string[] SLIST = S.Split(' ');
StringBuilder res = new(SLIST[0]);
char lastL = char.ToLower(SLIST[0][SLIST[0].Length - 1]);
for (int i = 1; i < SLIST.Length; i++)
{
    for (int j = 1; j < SLIST.Length;j++)
    {
        string current = SLIST[j];
        char firstL = char.ToLower(current[0]);
        if(lastL == firstL)
        {
            res.Append(" ");
            res.Append(current);
            lastL = char.ToLower(current[current.Length - 1]);

        }
    }
}
Console.WriteLine(res);