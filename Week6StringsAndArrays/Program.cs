string hello = " we are the champions?";

int stringLenght = hello.Length;


hello = hello.Trim();

char firstLetter = hello[0]; 
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter= hello[0]; 
Console.WriteLine(firstLetter);

Console.WriteLine(hello);





//int wordCounter = 1; 
//for(int i = 0; i < hello.Length; i++)
//{
//    if (hello[i] == ' ')
//    {
//        wordCounter++;
//    }
//}

//Console.Write($"Word count in {hello}: {wordCounter + 1} words.");