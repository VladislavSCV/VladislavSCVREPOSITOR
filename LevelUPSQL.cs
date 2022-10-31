using System;

string name1;
string age1;
string status1;

Console.WriteLine("Name?");
name1 = Console.ReadLine();
Console.WriteLine("Age?");
int age2=Int32.Parse(Console.ReadLine());
Console.WriteLine("Status?");
status1=Console.ReadLine();

static void Status(string name1,int age2, string status1)
{
    Console.WriteLine($"Hello,{name1}.Your age:{age2}.And your status in group:{status1}");
    Console.WriteLine("Well)");

}

Status(name1,age2,status1);


