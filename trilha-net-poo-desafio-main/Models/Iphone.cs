namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string marca, int memoria)
            : base(numero, modelo, marca, memoria)
        {
        }

        // Sobrescreve o método para instalar aplicativos no iPhone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}
