namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string marca, int memoria)
            : base(numero, modelo, marca, memoria)
        {
        }

        // Sobrescreve o método para instalar aplicativos no Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}

