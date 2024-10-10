

int ageNum = 0;
bool success = false;

{
while (success == false)
Console.WriteLine("Hur gammal är du");
String age = Console.ReadLine();

success = int.TryParse(age, out ageNum);
}
if(success == false)
{
    Console.WriteLine("du måste skriva en siffra");

}


if (ageNum < 18)
{
    Console.WriteLine("du är för ung");
}

else {
    Console.WriteLine("wow du är vuxen");
}

Console.ReadLine();