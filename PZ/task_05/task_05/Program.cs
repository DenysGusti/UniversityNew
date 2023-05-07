using System.Collections;

namespace task_05;

/*
5.21 Скласти програму для роботи з цілочисельним масивом підстановок.
Для збереження підстановки написати клас з індексатором та властивістю для визначення кількості елементів Count.
В середині класу елементи зберігати у одновимірному масиві.
В класі реалізувати оператор *, який обчислює суперпозицію підстановок і не змінює елементів,
якщо відповідної пари немає та інтерфейси IEnumerable i IEnumerator для роботи з класом як з колекцією.
Прочитати два масиви різної довжини,
знайти суперпозицію їх підстановок та надрукувати отриманий масив, використовуючи оператор foreach.
*/

internal class Permutation: IEnumerable<int>
{
    private readonly int[] _perm;
    public Permutation(int[] perm) => _perm = perm;
    
    public int this[int i] => _perm[i];

    public int Count => _perm.Length;

    public IEnumerator<int> GetEnumerator() => new PermutationEnum(_perm);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public static Permutation operator *(Permutation f, Permutation g)
    {
        var result = new int[f.Count];
        
        for (var i = 0; i < f.Count; ++i)
        {
            result[i] = f[i] < 0 || f[i] >= g.Count ? f[i] : g[f[i]];
        }
        
        return new Permutation(result);
    }

    private class PermutationEnum: IEnumerator<int>
    {
        private readonly int[] _perm;
        
        private int _position = -1;
        
        public PermutationEnum(int[] perm) => _perm = perm;
        
        public bool MoveNext()
        {
            ++_position;
            return _position < _perm.Length;
        }

        public void Reset() => _position = -1;

        public int Current {
            get
            {
                try
                {
                    return _perm[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() {}
    }
}

internal static class Program {
    public static void Main()
    {
        Permutation p = new(new []{0, 3, 4, 5, 1, 2});
        foreach (var i in p * p * p)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        Permutation a = new(new[] {1, -1, 2, -2, 3, -3});
        Permutation b = new(new[] {9, 8, 7, 6});
        foreach (var i in a * b)
        {
            Console.Write($"{i} ");
        }
    }
}