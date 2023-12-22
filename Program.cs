using DesafioPOO.Models;


//Testando se pode ser instanciada
// Smartphone smart1 = new Smartphone(); // Erro por ser abstrato - OK

Console.WriteLine("Nokia MD12 -------------------------------------------------------");
Console.WriteLine();
Nokia nokiaMD12 = new Nokia("98754-4893", "MD12", " 564392-58-430065-7", 128);
nokiaMD12.Ligar();
nokiaMD12.InstalarAplicativo("WhatsApp");
nokiaMD12.ListarAppsInstalados();
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine();


Console.WriteLine("Nokia MD14 -------------------------------------------------------");
Console.WriteLine();
Nokia nokiaMD14 = new Nokia("987544893", "MD14", " 240652-98-198000-7", 256);
nokiaMD14.ReceberLigacao();
nokiaMD14.InstalarAplicativo("Instagram");
nokiaMD14.ListarAppsInstalados();
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine();


Console.WriteLine("Iphone 12 Pro ----------------------------------------------------");
Console.WriteLine();
Iphone iphone12Pro = new Iphone("98754-4893", "12Pro", " 195165-28-980015-1", 128);
iphone12Pro.ReceberLigacao();
iphone12Pro.InstalarAplicativo("Telegram");
iphone12Pro.InstalarAplicativo("Facebook");
iphone12Pro.InstalarAplicativo("SnapChat");
iphone12Pro.InstalarAplicativo("Instagram");
iphone12Pro.InstalarAplicativo("WhatsApp");
iphone12Pro.ListarAppsInstalados();
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine();