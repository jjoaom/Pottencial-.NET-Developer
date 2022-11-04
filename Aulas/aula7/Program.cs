//OPERADORES LOGICOS

//Operador OR (ou) Pipe ||

// bool ehMaiorDeIdade = true;
// bool possuiAutoriracaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutoriracaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada.");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada.");
// }

// Operador And (e) &&


// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media > 7)
// {
//     Console.WriteLine("Aprovado.");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }


// Operador NOT ! (negação)


bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Não vou pedalar.");
}