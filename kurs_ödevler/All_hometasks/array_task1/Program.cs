//1)Eleman sayısını kullanıcının belirlediği bir dizi oluşturarak içine kullanıcının eleman girmesini sağlayan
Console.WriteLine("welcome! please enter how many element do you want to add: ");
int element_num = Convert.ToInt32(Console.ReadLine());

string[] names = new string[element_num];
for (int i = 0; i < element_num; i++)
{
    Console.WriteLine("please enter a name: ");
    names[i] = Convert.ToString(Console.ReadLine());
}
Console.WriteLine("**********");
foreach (string name in names)
{
    Console.WriteLine(name);
}



//2)Çoklu boyut dizi kullanarak oluşturulan 3*3 boyutunda iki matrisin toplamı
int[,] matris_toplam = new int[3, 3] { { 1,2,3 }, { 4,5,6 },{ 7,8,9 } };
int a = matris_toplam[0,0]+matris_toplam[1,0]+ matris_toplam[2,0];
int b = matris_toplam[0, 1] + matris_toplam[1, 1] + matris_toplam[2, 1];
int c = matris_toplam[0, 2] + matris_toplam[1, 2] + matris_toplam[2, 2];
Console.WriteLine("first coloumn : "+a);
Console.WriteLine("second coloumn : " + b);
Console.WriteLine("third coloumn : " + c);