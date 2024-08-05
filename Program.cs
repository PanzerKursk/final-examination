//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arraySimbol = new string[4] {"Hello", "2", "world", ":-)"};
string[] arraySimbol2 = new string[arraySimbol.Length];

int count = 0;

for (int i = 0; i < arraySimbol.Length; i++)
{
	if(arraySimbol[i].Length <= 3)
        {
        	arraySimbol2[count] = arraySimbol[i];
        	count++;
        }

}
Console.Write("[");

for (int i = 0; i < arraySimbol2.Length; i++)
{
	Console.Write(arraySimbol2[i]);
}  
Console.Write("]");