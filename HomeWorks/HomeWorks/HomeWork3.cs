using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//1․  գրել կոդ, որը կոնսոլում կտպի ժամը, կաշխատի մենակ ամեն ամսվա առաջին օրը
//2․ գրել կոդ, որը կոնսոլում կտպի 1-100 թվերը՝ հակառակ հերթականությամբ
//3․ գրել կոդ, որը կոնսոլում կհարցնի յուզերի անունն ու տարիքը և կտպի այն, իսկ exit գրելու դեպքում դուրս կգա

// 1

//week();
static void week()
{
    DateTime date = DateTime.Now;
    var dayOfMonth = date.Day;
    if (dayOfMonth == 1)
    {
        Console.WriteLine(date.TimeOfDay);
    }
}

// 2

for (int i = 100; i >= 1; i--)
{
    Console.WriteLine(i);
}

// 3

string name, age;
while (true)
{
    Console.WriteLine("Type your name");
    name = Console.ReadLine();
    if (name == "exit") break;
    Console.WriteLine("Type your age");
    age = Console.ReadLine();
    if (age == "exit") break;
    var user = $"Your name is {name}, age {age}";
    Console.WriteLine(user);
    break;
};