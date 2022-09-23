Console.Write("Введите фразу");
string[] arr = Console.ReadLine().Split(' ');
string[] arr2 = new string [arr.Length-1];
int c = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 3)
    {
        arr2[c]=arr[i];
        c++;
    } 
}
for (int j = 0; j < c; j++)
{
    Console.WriteLine(arr2[j] + "");
}


// string phrase = "The quick brown fox jumps over the lazy dog.";
// string[] words = phrase.Split(' ');