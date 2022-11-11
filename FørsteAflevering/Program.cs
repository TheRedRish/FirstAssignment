using FirstAssignment.Models;
using FirstAssignment.Codes;

object? carModel = null;

do
{
    carModel = InitiateIntro();
} while (carModel == null);

CheckIfCarShouldGetInspection checkIfCarShouldGetInspection = new((CarModels)carModel);

CheckIfCarShouldBeRecalled shouldBeRecalled = new((CarModels)carModel);

Console.ReadKey();

object? InitiateIntro()
{
    DateCheck checkDate = new();
    Console.Clear();

    Console.WriteLine("Indtast bilens mærke: ");
    string carMake = Console.ReadLine();

    Console.WriteLine("Indtast bilens model: ");
    string carModel = Console.ReadLine();

    // date in format dd-mm-yyyy
    Console.WriteLine("Brug datoformatet: dd-mm-yyyy");
    Console.WriteLine("Indtast bilens årgang: ");
    string carYearAsString = Console.ReadLine();
    if(!checkDate.IsStringInDateFormat(carYearAsString))
    {
        DisplayFailureMessage();
        return null;
    }
    DateOnly carYear = DateOnly.Parse(carYearAsString);

    // date in format dd-mm-yyyy
    Console.WriteLine("Indtast bilens registreringsdato: ");
    string carRegistrationYearAsString = Console.ReadLine();
    if (!checkDate.IsStringInDateFormat(carRegistrationYearAsString))
    {
        DisplayFailureMessage();
        return null;
    }
    DateOnly carRegitrationYear = DateOnly.Parse(carRegistrationYearAsString);

    // date in format dd-mm-yyyy
    Console.WriteLine("Tip: Hvis bilen ikke er blevet synet indtast samme dato som registreringsdatoen");
    Console.WriteLine("Indtast bilens sidste syns dato: ");
    string carLastInspectionAsString = Console.ReadLine();
    if (!checkDate.IsStringInDateFormat(carLastInspectionAsString))
    {
        DisplayFailureMessage();
        return null;
    }
    DateOnly carLastInspection = DateOnly.Parse(carLastInspectionAsString);

    CarModels CarModels = new()
    {
        CarMake = carMake,
        CarModel = carModel,
        CarYear = carYear,
        CarRegistrationYear = carRegitrationYear,
        CarLastInspection = carLastInspection
    };

    return CarModels;
}

void DisplayFailureMessage()
{
    Console.WriteLine("Dato indtastet et forkert format eller dato.");
    Console.Write("Prøv igen med formattet dd-mm-yyyy");

    for (int i = 0; i < 4; i++)
    {
        Thread.Sleep(1000);
        Console.Write(".");
    }
}