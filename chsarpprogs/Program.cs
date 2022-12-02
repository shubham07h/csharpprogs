
int fulltime = 1;
Random randobj = new Random();
int checkpresent = randobj.Next(0, 2);
Console.WriteLine("random number=" + checkpresent);
if (checkpresent == fulltime)
{
    Console.WriteLine("employee is present");
}
else
{
    Console.WriteLine("employee is absent");
}
