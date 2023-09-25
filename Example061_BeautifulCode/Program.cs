// чушь - как нельзя
const double пи = 3.1415
int k__BackingField;
void set_MyProperty(int value)
{
    k__BackingField = value;
}
int get MyProperty()
{
    return k__BackingField;
}
int MyProperty { get; set; }


// следующий бред!!!
void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    System.Console.WriteLine(text);
}
// что такое 629 и 360
// 629 - пусть ширина экрана 1280px, тогда 1280 / 2 = 640
// в тексте 22 символа, чтобы отцентрировать, нужно отступить 11
// 1280/2-11 = 629
// пусть высота экрана 720px - 720/2 = 360
DrawText("Intensive C# Demo text", 629, 360);

// Патерные и антипатерные принципы 
// Антипатерные (магические числа: 629, 360)

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

DrawText(caption, screenHeightPosition, screenWidthPosition);

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
    );    

// следующий бред!!!
string label = "";                      // 111
string adress = string.Empty;           // 222

// Пример 1
double a = 1, b = -26, c = 120;
var d = b * b - 4 * a * c;
double x1 = (-b + Math.Sqrt(d)) / (2 * a);
double x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

// Пример 2
a = 2, b = 1, c = -3;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

// Пример 3
a = 1, b = 1, c = -6;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

// Как надо - Метод
public Roots Solve(double a, double b, double c)
{
    var d = b * b - 4 * a * c;
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    return new Roots { X1 = x1, Y2 = y2 };
}
// ПРИНЦИП РАЗРАБОТКИ - DRY
// Don't repeat yourself, DRY - это принцип разработки ПО,
// нацеленный на снижение повторения информации различного рода

// В случайных точках консоли вывести случайные числа
Random r = new Random();
Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
        );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
}

// ПРИНЦИП РАЗРАБОТКИ - YAGNI ("Your aren't gonna need it");
// с англ. - "Вам это не понадобится") - процесс и принцип проектирования ПО,
// при котором в качестве основной цели и/или ценности декларируется отказ
// от избыточной функциональности, - т.е. отказ добавления фукциональности,
// в которой нет непосредственной необходимости

// KISS (акроним для «Keep it simple, stupid»)
// Принцип, запрещающий использование более сложных средств, чем необходимо.
// Принцип декларирует простоту системы в качестве основной цели и/или ценности.



string text = "(1,2) (2,3) (4,5) (6,7)";
