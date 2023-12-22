namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        private int Memoria;
        protected List<string> AppsInstalados;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            AppsInstalados = new List<string>();
        }
        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            Console.WriteLine();
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            Console.WriteLine();
        }

        public void ListarAppsInstalados()
        {
            Console.WriteLine();
            Console.WriteLine("  --- App's Instalados ---");
            foreach (string app in AppsInstalados)
            {
                Console.WriteLine($"     {app}");
            }
            Console.WriteLine("  ------------------------");
            Console.WriteLine();
        }
        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void DesinstalarAplicativo(string nomeApp);
    }
}