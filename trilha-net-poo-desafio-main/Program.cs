using DesafioPOO.Models;

// Testando as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias das classes
        Smartphone nokia = new Nokia("123456789", "Nokia 1100", "Nokia", 32);
        Smartphone iphone = new Iphone("987654321", "iPhone 13", "Apple", 128);

        // Testando os métodos
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
