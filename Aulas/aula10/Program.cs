//Lista

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

// Console.WriteLine("Percorrendo a lista com FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição número {contador} - {listaString[contador]}");
// }


//  Console.WriteLine("Percorrendo a lista com FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição número {contadorForeach} - {item}")
// }
















//Array


//Exemplos

//int[] array = new int [4]; -> array de 4 slots
//int[] array = new int[]{ 42, 76, 24, 83};
//string[] nomes = {"Jan", "Fev"}'

//Indice
//int elemento = array[0]; = 42 

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com FOR");

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição número {contador} - {arrayInteiros[contador]}");
// }


// Console.WriteLine("Percorrendo o Array com FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição número{contadorForeach} - {valor}");
//     contadorForeach++;
// }