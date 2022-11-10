using FirstAssignment.Models;
using FirstAssignment.Codes;

Intro initiateIntro = new();
initiateIntro.InitiateIntro();

CheckIfCarShouldGetInspection shouldGetInspection = new();

if (shouldGetInspection.ShouldCarGetInspection())
{
    Console.WriteLine("Bilen skal til syn");
}
else
{
    Console.WriteLine("Bilen skal ikke synes");
}

CheckIfCarShouldBeRecalled shouldBeRecalled = new();
shouldBeRecalled.ShouldCarBeRecalled();
if (shouldBeRecalled.shouldBeRecalled)
{
    Console.WriteLine(shouldBeRecalled.recallReason);
}