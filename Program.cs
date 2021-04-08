using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
        int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
        //continue escrevendo a solucao

        string[] dadosInicio = Console.ReadLine().Split();
        diaInicio = Convert.ToInt32(dadosInicio[1]);

        string[] dadosMomentoInicio = Console.ReadLine().Split(" : ");
        horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
        minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
        segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);

        string[] dadosTermino = Console.ReadLine().Split();
        diaTermino = Convert.ToInt32(dadosTermino[1]);
        string[] dadosMomentoTermino = Console.ReadLine().Split(" : ");
        horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
        minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
        segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);

        int transformaSegundosInicio = segundoMomentoInicio + minutoMomentoInicio * (60) + horaMomentoInicio * (60 * 60) + diaInicio * (60 * 60 * 24);
        int transformaSegundosTermino = segundoMomentoTerminio + minutoMomentoTermino * (60) + horaMomentoTermino * (60 * 60) + diaTermino * (60 * 60 * 24);

        int somaTotalSegundos = (transformaSegundosTermino - transformaSegundosInicio);
        int D = somaTotalSegundos / (60 * 60 * 24);
        somaTotalSegundos = somaTotalSegundos % (60 * 60 * 24);
        int H = somaTotalSegundos / (60 * 60);
        somaTotalSegundos = somaTotalSegundos % (60 * 60);
        int M = somaTotalSegundos / (60);
        somaTotalSegundos = somaTotalSegundos % (60);
        int S = somaTotalSegundos;

        Console.WriteLine("{0} dia(s)", D);
        Console.WriteLine("{0} hora(s)", H);
        Console.WriteLine("{0} minuto(s)", M);
        Console.WriteLine("{0} segundo(s)", S);


    }

}