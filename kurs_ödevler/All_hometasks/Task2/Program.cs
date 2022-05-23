//Hometask 1 
int[] oneToTen = new int[10];
for (int i = 0; i < oneToTen.Length; i++)
{
    Console.WriteLine("enter the {0}. number", i + 1);
    int added = Convert.ToInt32(Console.ReadLine());
    oneToTen[i] = added;
}
Console.WriteLine("----------------------------------------------------");
foreach (int elem in oneToTen)
{
    Console.WriteLine(!(elem % 2 == 0) ? "{0} is odd number" : "{0} is even number", elem);
}

//Hometask 2
class Car
{
    public int carId { get; set; }
    public string carName { get; set; }
    public string carModel { get; set; }
    public int carYear { get; set; }
    public bool isCarDamaged { get; set; }

    static void Main(string[] args)
    {
        Car car1 = new Car
        {
            carId =735894, carName ="BMV", carModel = "5 series", carYear = 2018 , isCarDamaged = false
        };
        Console.WriteLine("arabanın seri numarası: "+car1.carId);
        Console.WriteLine("arabanın markası: "+car1.carName);
        Console.WriteLine("arabanın modeli: "+car1.carModel);
        Console.WriteLine("arabanın üretildiği yıl: "+car1.carYear);
        Console.WriteLine("araba hasarlı mı: "+car1.isCarDamaged);

        Console.WriteLine("\n----------------------------------------------------------\n");
        Car car2 = new Car
        {
            carId = 194567, carName = "Mercedes", carModel = "C series", carYear = 2015, isCarDamaged = true
        };

        Console.WriteLine("arabanın seri numarası: " + car2.carId);
        Console.WriteLine("arabanın markası: " + car2.carName);
        Console.WriteLine("arabanın modeli: " + car2.carModel);
        Console.WriteLine("arabanın üretildiği yıl: " + car2.carYear);
        Console.WriteLine("araba hasarlı mı: " + car2.isCarDamaged);

    }
}