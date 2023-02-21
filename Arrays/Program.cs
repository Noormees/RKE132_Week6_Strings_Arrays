

// string[] fruit = { "apples", "bananas", "oranges" };    // EI TOHI olla nt. 1, true

string[] fruit = new string[3];     // 3 - kogus andmeid massivis (pikkus) - fruit[0], fruit[1], fruit[2]
fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");



int fruitArrayLength = fruit.Length;
Console.WriteLine($"There are {fruitArrayLength} in your array");


for (int i = 0; i < fruitArrayLength; i++)
{
    //Console.WriteLine(fruit[i]);

    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}


foreach (string element in fruit)       // kasutatakse kuvamiseks voi andmebaasi salvestamiseks
{
    Console.WriteLine(element);
}





