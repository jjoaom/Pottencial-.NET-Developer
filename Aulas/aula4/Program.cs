





string a = "15-";

 int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
 Console.WriteLine("Conversão realizada com sucesso");


//c# usa os mesmos padroes de matematica para calcular
//parenteses tem prioridade


 //double a = 4 / (2 + 2);

//Console.WriteLine(a);








//Cast implicito - Conversao de diferentes tipos de forma automatica

// int a = 5;
// double b = a;

// int c = 10;
// long d = c;

// // não é possível realizar a conversão ao contrario, 
// //ou seja de long para int

// Console.WriteLine(b);
// Console.WriteLine(d);








// // Conversao para String

// string a = Convert.ToString(5);

// Console.WriteLine(a);

// // Outro metodo

// int inteiro = 10;
// string b = inteiro.ToString();

// Console.WriteLine(b);




// int a = Convert.ToInt32(null);

// Console.WriteLine(a);

// int b = int.Parse(null); - nao aceita nulo

// Console.WriteLine(b);




// // Casting - Cast - Convert
// // cast serve para converter variaveis

// int a = Convert.ToInt32("5");

// Console.WriteLine(a);

// //Casting - Cast - Parse

// int b = int.Parse("10");

// Console.WriteLine(b);