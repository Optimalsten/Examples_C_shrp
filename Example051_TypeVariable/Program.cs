using System.Linq;

// int a = 12;
//TODO: Демонстрация работы с .Name будет писать Int32
// Console.WriteLine(a.GetType().Name);

var a = 12;
//TODO: Демонстрация работы без .Name будет писать System.Int32
// Console.WriteLine(a.GetType());

var data = new int[] { 1, 2, 3, 4 }
        .Where(e => e > 0)
        .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType().Name);
Console.WriteLine(data.GetType());
