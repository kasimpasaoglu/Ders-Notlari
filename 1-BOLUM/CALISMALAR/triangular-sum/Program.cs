using System.Collections;

Console.WriteLine("Kac Adet Sayi Girilecek ?");
int numberCount;
while ((!int.TryParse(Console.ReadLine().Trim(), out numberCount) || numberCount <= 0))
{
    Console.WriteLine("Gecerli Bir Sayi Giriniz");
}

ArrayList nums = new(numberCount);

for (int i = 0; i < nums.Capacity; i++)
{
    Console.WriteLine($"{i + 1}. Sayiyi Girin");

    int number;
    while (!int.TryParse(Console.ReadLine().Trim(), out number))
    {
        Console.WriteLine("Gecerli Bir Sayi Giriniz");
    }
    nums.Add(number);
}
int step = 0;
while (nums.Count > 1)
{
    Console.Write(new string(' ', step)); // new string() ile, ilk parametre char, ikinci parametre kac defa yazilacagi

    foreach (int num in nums) // o an hangi satirda islem yapiyorsak onu yazdirma
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();

    ArrayList newNums = new ArrayList();

    for (int j = 0; j < nums.Count - 1; j++) // islemi yapacak dongu
    {
        int sum = ((int)nums[j] + (int)nums[j + 1]) % 10;
        newNums.Add(sum);
    }

    nums = newNums; // eski diziyi yeni diziyle degistir
    step++; // bir sonraki satir icin girintiyi arttir
}
Console.Write(new string(' ', step)); // son satir icin girinti
Console.WriteLine(nums[0]); // son satir


/*
1 2 3 4 5 
 3 5 7 9
  8 2 6
   0 8
    8
*/