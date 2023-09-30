namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - OK
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando do Iphone...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Ligando do Iphone...");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" - OK
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no modelo Iphone");
        }
    }
}