 //1-amaliy vazifa
 Console.WriteLine("sonni kiriting:");
 Console.Write("birinchi sonni kiriting: ");
 string Firstuservalue = Console.ReadLine();
 Console.Write("tanlang [ +, -, *, /]: ");
 string operation = Console.ReadLine();
 Console.Write("ikkinchi sonni kiriting; ");
 string Seconduservalue = Console.ReadLine();

 Console.WriteLine("hisoblayapmiz....... ");
 decimal firstnumber = Convert.ToDecimal(Firstuservalue);
 decimal secondnumber = Convert.ToDecimal(Seconduservalue);
 Console.WriteLine("javob:");

 switch (operation)
 {
     case "+":
         Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
         break;
     case "-":
         Console.WriteLine($"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}");
         break;
     case "*":
         Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}");
         break;
     case "/":
         Console.WriteLine($"{firstnumber} / {secondnumber} = {firstnumber / secondnumber}");
         break;
     default:
         Console.WriteLine("hato operatsiya");
         break;
 }

 //2-amaliy vazifa
 Console.Write("sonni kiriting:");
int N = int.Parse(Console.ReadLine());  
int son = (N * (N + 1)) / 2;
Console.WriteLine(son); 

//3-amaliy vazifa

Console.Write("sonni kiriting:");
int son = int.Parse(Console.ReadLine());
string[] natija = { "Juft", "Toq" };
Console.WriteLine(natija[son % 2]);