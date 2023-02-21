
// esimese symboli asukoht = 0
// viimase symboli asukoht = LENGTH - 1


string hello = "hello, world! herehehe is igor!";

int stringLength = hello.Length;

//string trimmedString = hello.Trim(); // TRIM kustutab tyhikud alguses ja lopus

//Console.WriteLine(stringLength);

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));
Console.WriteLine(hello);





//int wordCounter = 0;

//for(int i = 0;i < hello.Length; i++)   
//{

                                // Console.WriteLine($"{i} symbol in string: {hello[i]}");

//    //if (hello[i] == ' ')
//    //{ 
//    //    wordCounter++; 
//    //}
   
//    if (char.IsWhiteSpace(hello[i]))
//    { 
//    wordCounter++;
//    }
//}

////Console.WriteLine(trimmedString.Length);

//// Console.WriteLine(hello.Length);

//Console.WriteLine($"Word counter in '{hello}': {wordCounter + 1} words."); // voi teeme: int wordCounter = 1; 





