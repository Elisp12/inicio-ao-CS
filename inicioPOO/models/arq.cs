using System;
namespace inicioPOO.models
{
    public class arq : menu
    {
        private static string opcao()
        {
            //mostra início
            Console.WriteLine("\n\t\t\t----------- CATÁLOGO MTB ------------\n");
            Console.WriteLine($"\n\t\t'OPÇÕES' \n\n [1] Mais Populáres  \t\t [2] Preços acessíveis \t\t [3] Mostrar Catálogo \t\t\t [X] Sair");

            Console.WriteLine();
            string opnando = Console.ReadLine();
            Console.WriteLine();
            return opnando;
        }
        public override void mostrar()
        {
            //Condiçao
            string opnando = opcao();
            while(opnando.ToUpper() != "X")
            {
                switch(opnando)
                {
                    case "1":
                    
                    //MTB's Mais Populáres

                    menu b1 = new menu();
                    b1.nomeMod = "MTB0001";
                    b1.cor = "Preto";
                    b1.vlcd = 21.0f;
                    b1.tm = 17;

                    menu b2 = new menu();
                    b2.nomeMod ="MTB0002";
                    b2.cor ="Cinza";
                    b2.tm = 19;
                    b2.vlcd = 24.0f;

                    menu b3 = new menu();
                    b3.nomeMod ="MTB0004";
                    b3.cor ="Vermelho";
                    
                    //catálogo
                    //bike 1
                    Console.WriteLine("\nMTB's mais Populares!\n");
                    Console.WriteLine($"Nome/Modelo: {b1.nomeMod} \nCor: {b1.cor}, {b2.cor}\nVelocidade: {b1.vlcd} \nTamanho: {b1.tm}, {b2.tm}");
                    //bike 2
                    Console.WriteLine($"\n\nNome/Modelo: {b2.nomeMod} \nCor: {b1.cor}, {b2.cor} \nVelocidade: {b1.vlcd}, {b2.vlcd} \nTamanho: {b2.tm}");
                    // bike 3
                    Console.WriteLine($"\n\nNome/Modelo: {b3.nomeMod} \nCor: {b1.cor}, {b2.cor}, {b3.cor} \nVelocidade: {b1.vlcd}, {b2.vlcd} \nTamanho: {b1.tm}, {b2.tm}");
                    
                    //Condição/ modelo [1]
                    Console.WriteLine("\n'Escolha um Modelo' \n\n[1] 'MTB0001' \t\t [2] 'MTB0002' \t\t [3] 'MTB0004'\n");
                    opnando = Console.ReadLine();
                    Console.WriteLine();
                    if(opnando == "1")
                    {
                        //modelo [1]
                        // cor, tamanho velocidade
                        Console.WriteLine($"\n[Nome/Modelo: {b1.nomeMod}]\n");
                        Console.WriteLine($"\nNome/Modelo: {b1.nomeMod} \nCor: {b1.cor}, {b2.cor}\nVelocidade: {b1.vlcd}, {b2.vlcd} \nTamanho: {b1.tm}, {b2.tm}");
                       
                        //condição
                        Console.WriteLine($"\nEscolha uma 'COR' \n\nCor: \n[1] {b1.cor} \t\t [2] {b2.cor}");
                        
                        opnando = Console.ReadLine(); 
                        // cor e tamanho disponível
                        if (opnando == "1")
                        {
                            Console.WriteLine($"\ntamanhos e velocidades disponíveis \n\nTamanho: {b1.tm}, {b2.tm} \n\nVelocidade: {b1.vlcd}");
                        }
                        else if(opnando == "2")
                        {
                            Console.WriteLine($"\ntamanhos e velocidades disponíveis \n\nTamanho: {b2.tm} \n\nVelocidade: {b1.vlcd}, {b2.vlcd}");
                                                        
                        }
                    }

                    //condição/ Modelo [2]
                    else if (opnando == "2")
                    {
                        //Modelo [2]
                        // cor, tamanho velocidade
                        Console.WriteLine($"\n[Nome/Modelo: {b2.nomeMod}]\n");
                        Console.WriteLine($"\nNome/Modelo: {b2.nomeMod} \nCor: {b1.cor}, {b2.cor}\nVelocidade: {b1.vlcd}, {b2.vlcd} \nTamanho: {b2.tm}");
                       
                        //condição
                        Console.WriteLine($"\nEscolha uma 'COR' \n\nCor: \n[1] {b1.cor} \t\t [2] {b2.cor}");
                        
                        opnando = Console.ReadLine(); 
                        // cor e tamanho disponível
                        if (opnando == "1")
                        {
                            Console.WriteLine($"\ntamanhos e velocidades disponíveis \n\nTamanho: {b1.tm}, {b2.tm} \n\nVelocidade: {b1.vlcd}");
                        }
                        else if(opnando == "2")
                        {
                            Console.WriteLine($"\ntamanhos e velocidades disponíveis \n\nTamanho: {b1.tm}, {b2.tm} \n\nVelocidade: {b1.vlcd}, {b2.vlcd}");                                 
                        }

                    }

                    //Condição/ modelo [3]
                    else if (opnando == "3")
                    {
                        //Modelo [3]
                        // cor, tamanho velocidade
                        Console.WriteLine($"\n[Nome/Modelo: {b3.nomeMod}]\n");
                        Console.WriteLine($"\nNome/Modelo: {b3.nomeMod} \nCor: {b1.cor}, {b2.cor}, {b3.cor} \nVelocidade: {b1.vlcd}, {b2.vlcd} \nTamanho: {b1.tm}, {b2.tm}");
                       
                        //condição
                        Console.WriteLine($"\nEscolha uma 'COR' \n\nCor: \n[1] {b1.cor} \t\t [2] {b2.cor} \t\t [3] {b3.cor}");
                        
                        opnando = Console.ReadLine(); 
                        // cor e tamanho disponível
                        if (opnando == "1")
                        {
                            Console.WriteLine($"\ntamanhos e velocidades disponíveis \n\nTamanho: {b1.tm}, {b2.tm} \n\nVelocidade: {b1.vlcd}");
                        }
                        else if(opnando == "2")
                        {
                            Console.WriteLine($"\ntamanhos e velocidades disponíveis \n\nTamanho: {b2.tm} \n\nVelocidade: {b1.vlcd}, {b2.vlcd}");                                 
                        }
                        else if (opnando == "3")
                        {
                            Console.WriteLine($"\ntamanhos e velocidades disponíveis \n\nTamanho: {b1.tm} \n\nVelocidade: {b1.vlcd}, {b2.vlcd}");
                        }

                    }
                    break;

                    case "2":
                    break;

                    case "3":
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opnando = opcao();
            }
        }
    }
}