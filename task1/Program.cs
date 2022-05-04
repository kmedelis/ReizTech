// patikrint kad valandos tarp 0 (iskaitant) ir 24 (neiskaitant)
// patikrint kad minutes tarp 0 ir 60

Console.WriteLine("Input hours:");
int hours = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minutes:");
var minutes = Convert.ToInt32(Console.ReadLine());

if (hours >= 12)
{
    hours-= 12;
}

var minuteArrowAngle = minutes * 6;
var hourArrowAngle = hours * 30 + (0.5*minutes);

var distanceBetween = hourArrowAngle > minuteArrowAngle ? hourArrowAngle - minuteArrowAngle : minuteArrowAngle - hourArrowAngle;

Console.WriteLine($"The difference between hour and minutes hands is: {distanceBetween}");