using System;

namespace inicioPOO.models
{
    public class menu 
    {
        private string nome;
        private string modelo;
        private string marca;

        public menu(string nome, string modelo, string marca)
        {
            this.nome = nome;
            this.modelo = modelo;
            this.marca =  marca;
        }
        public void mostrar()
        {
            Console.WriteLine($"Nome: {nome} \nModelo: {modelo} \nMarca: {marca}\n\n");
        }
    }
}