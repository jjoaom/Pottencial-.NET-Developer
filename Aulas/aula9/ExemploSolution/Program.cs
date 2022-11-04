using Solution.Common.Models;

Pessoa pessoa1 = new Pessoa();




//Menu interativo com while

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//         {
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         }
//         case "2":
//         {
//             Console.WriteLine("Busca de cliente");
//             break;
//         }
//         case "3":
//         {
//             Console.WriteLine("Apagar cliente");
//             break;
//         }
//         case "4":
//         {
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0); serve para encerrar o programa
//             break;
//         }
//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");









// Do While Loop

// do{

// } while(true);


// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número:(0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0); //enquanto o numero for diferente de 0

// Console.WriteLine($"Total da soma dos numeros digitados é: + {soma}");



//While - Enquanto

// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{contador + 1} Execução: {numero} x {contador} = {numero * contador}");
//     contador ++;

//     // if (contador == 5) interrompendo o fluxo
//     // {
//     //     break;
//     // }
// }













//Laço de repetição - For

// int numero = 5;

// Console.WriteLine($"{numero} x 1 = {numero * 1}");

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }