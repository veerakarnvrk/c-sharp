Console.InputEncoding = System.Text.Encoding.UTF8;       //รับ input ภาษาไทย
Console.OutputEncoding = System.Text.Encoding.UTF8;      //ส่ง output ภาษาไทย

Console.WriteLine("Enter your name:");      //แสดงข้อความ "Enter your name"
string name = Console.ReadLine()!;           //ตัวแปรเก็บค่าที่รับมาจากคีย์บอร์ดเป็น string เพราะถามชื่อต้องพิมพ์ชื่อ ชื่อนับเป็นข้อความ(string)

Console.WriteLine("Enter your age:");      //คำสั้งแสดงข้อความ "Enter your age"
if (int.TryParse(Console.ReadLine(), out int age))   //if นอกสุด ถ้าคำสั่งในวงเล็บนี้ทำงานแต่ user ไม่กรอกตัวเลขมาให้ไปทำงาน else ล่างสุด
                                                     //ส่วนใน if คือรอรับค่า string แล้วแปลงเป็น int เก็บค่าเป็นตัวแปร age (กรอกเลขแต่คอมมองว่าเลขคือข้อความ string)
{    
    if (age >= 18)                             //ถ้าอายุ >= 18
    {
        Console.WriteLine($"Welcome, {name}");        //แสดงข้อความ "Welcome, ชื่อ"
        Console.WriteLine("You are Adult");           //แสดงข้อความ "You are Adult"
    }

    else                                              //ถ้าไม่ใช่
    {
        Console.WriteLine($"Sorry you cannot enter, {name}");       //แสดงข้อความ "Sorry you cannot enter, ชื่อ"
        Console.WriteLine("Because You are Minor");                 //แสดงข้อความ "Because You are Minor"
    }
}
else       //else นอกสุด จะทำงานก็ต่อเมื่อ if นอกสุดเป็น false (คือ user กรอกข้อมูลที่ไม่ใช่ตัวเลขเข้ามา)
{
    Console.Write("Please fill only your age");     //แสดงข้อความ "Please fill only your age"
}