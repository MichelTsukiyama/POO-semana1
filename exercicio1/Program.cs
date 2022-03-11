using System;
using exercicio1.src;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Veiculo();
            carro.setMarca("Hyundai");
            carro.setModelo("HB20");
            carro.setPlaca("ABC-1234");
            carro.setCor("Preto");
            carro.setKm(30000);
            carro.setIsLigado(false);
            carro.setLitrosCombustivel(50);
            carro.setVelocidade(0);
            carro.setPreco(50000);

            System.Console.WriteLine(carro.desligar());
            System.Console.WriteLine(carro.ligar());
            System.Console.WriteLine(carro.frear());
            System.Console.WriteLine(carro.acelerar());
            System.Console.WriteLine(carro.acelerar());
            System.Console.WriteLine(carro.frear());
            System.Console.WriteLine(carro.desligar());
            System.Console.WriteLine(carro.frear());
            System.Console.WriteLine(carro.desligar());
            System.Console.WriteLine(carro.pintar("Branco"));
            System.Console.WriteLine(carro.pintar("Marrom"));
        }
    }
}
