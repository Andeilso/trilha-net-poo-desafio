namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}...");
            AppsInstalados.Add(nomeApp);
            Console.WriteLine($"{nomeApp} - Instalado com sucesso!!!");
            Console.WriteLine();
        }

        public override void DesinstalarAplicativo(string nomeApp){
            Console.WriteLine($"Desinstalando {nomeApp}...");
            AppsInstalados.Remove(nomeApp);
            Console.WriteLine($"{nomeApp} - Desinstalado com sucesso!!!");
            Console.WriteLine();
        }
    }
}