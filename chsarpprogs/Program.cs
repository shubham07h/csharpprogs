if (line1.startPoint == line2.startPoint && line1.endPoint == line2.endPoint)
{
    Console.WriteLine("Line1 is equal to Line2");
}

//Greater
if (line1.startPoint > line2.startPoint && line1.endPoint > line2.endPoint)
{
    Console.WriteLine("Line1 is greater than Line2");
}

//Less
if (line1.startPoint < line2.startPoint && line1.endPoint < line2.endPoint)
{
    Console.WriteLine("Line1 is less than Line2");
}