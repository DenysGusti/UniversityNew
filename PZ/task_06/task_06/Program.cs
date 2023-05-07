namespace task_06;

/*
6.28 Прочитати текстову стрічку довжиною не більше ніж 253 символи.
Перевірити правильність входження у текст квадратних та фігурних дужок (ситуації } { або [{]} - є помилковими).
*/

internal static class Program {
    private static bool CheckBracketsCorrectness(string s)
    {
        Stack<char> brackets = new();
        foreach (var c in s)
        {
            switch (c)
            {
                case '[' or '{':
                    brackets.Push(c);
                    break;
                case ']' or '}':
                    if (brackets.Count == 0 || brackets.Pop() != (c == ']' ? '[' : '{'))
                        return false;
                    break;
            }
        }
        return brackets.Count == 0;
    }
    
    public static void Main()
    {
        var s = Console.ReadLine()!;
        Console.WriteLine($"Brackets are correct: {CheckBracketsCorrectness(s.Length > 253 ? s[..253] : s)}");
    }
}