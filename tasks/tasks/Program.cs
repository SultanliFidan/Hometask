


//int[] array1 = { 1, 2, 7,3, 9, 5,12 };
//int[] array2 = { 2, 5, 7, 6, 9,};

//bool isExist = false;
//for (int i = 0; i < array1.Length; i++)
//{
//    for (int j = 0; j < array2.Length; j++)
//    {
//        if (array1[i] != array2[j])
//        {
//            isExist = false;
//        }
//        else if (array1[i] == array2[j])
//        {
//            isExist = true;
//            break;
//        }

//    }
//    if (isExist == false)
//    {
//        Console.WriteLine(array1[i]);
//    }


//}








//Verilmiş integer array-in tək indexdə duran elementləri ilə cüt indexdə duran elementləri müqayisə edin

int[] array = { 1, 4, 6, 18, 56, 78, 92 };

int sumTek = 0;
int sumCut = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        sumCut += array[i];
    }

    else
    {
        sumTek += array[i];
    }


}

if (sumCut > sumTek)

{
    Console.WriteLine("Cut indeksde duran ededlerin cemi daha boyukdur");
}

else if (sumCut < sumTek)
{
    Console.WriteLine("Tek indeksde duran ededlerin cemi daha boyukdur");
}

else
{
    Console.WriteLine("Tək və cüt indekslərdəki elementlərin cəmi bərabərdir.");
}