namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} em seu Iphone...");
            AppsInstalados.Add(nomeApp);
            Console.WriteLine($"{nomeApp} - Instalado com sucesso!");
            Console.WriteLine();
        }

        public override void DesinstalarAplicativo(string nomeApp){
            Console.WriteLine($"Desinstalando {nomeApp} de seu Iphone...");
            AppsInstalados.Remove(nomeApp);
            Console.WriteLine($"{nomeApp} - Desinstalado com sucesso!");
            Console.WriteLine();
        }
    }
}