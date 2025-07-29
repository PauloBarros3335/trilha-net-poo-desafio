using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "1234-5678", modelo: "Tijolão 3310", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine($"Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");

Console.WriteLine("\n---");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone(numero: "9876-5432", modelo: "iPhone 15 Pro Max", imei: "222222222", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine($"Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");




Console.WriteLine("=== Testes com Smartphones ===");
Console.WriteLine("\n----------------------------------");

// Teste 1: Nokia Básico
Console.WriteLine("--- Nokia Básico (3310) ---");
Nokia nokiaBasico = new Nokia(numero: "1234-5678", modelo: "Nokia 3310", imei: "111111111", memoria: 64);
Console.WriteLine($"Número: {nokiaBasico.Numero}");
Console.WriteLine($"Modelo: {nokiaBasico.Modelo}");
Console.WriteLine($"IMEI: {nokiaBasico.IMEI}");
Console.WriteLine($"Memória: {nokiaBasico.Memoria}GB");
nokiaBasico.Ligar();
nokiaBasico.ReceberLigacao();
nokiaBasico.InstalarAplicativo("Snake");
Console.WriteLine("----------------------------------");

// Teste 2: iPhone Avançado
Console.WriteLine("\n--- iPhone Top de Linha (15 Pro Max) ---");
Iphone iphoneTop = new Iphone(numero: "9876-5432", modelo: "iPhone 15 Pro Max", imei: "222222222", memoria: 256);
Console.WriteLine($"Número: {iphoneTop.Numero}");
Console.WriteLine($"Modelo: {iphoneTop.Modelo}");
Console.WriteLine($"IMEI: {iphoneTop.IMEI}");
Console.WriteLine($"Memória: {iphoneTop.Memoria}GB");
iphoneTop.Ligar();
iphoneTop.ReceberLigacao();
iphoneTop.InstalarAplicativo("Instagram");
iphoneTop.InstalarAplicativo("TikTok"); // Instalando outro app
Console.WriteLine("----------------------------------");

// Teste 3: Outro Nokia com mais memória
Console.WriteLine("\n--- Nokia Moderno (G400) ---");
Nokia nokiaModerno = new Nokia(numero: "5555-4444", modelo: "Nokia G400", imei: "333333333", memoria: 128);
Console.WriteLine($"Número: {nokiaModerno.Numero}");
Console.WriteLine($"Modelo: {nokiaModerno.Modelo}");
Console.WriteLine($"IMEI: {nokiaModerno.IMEI}");
Console.WriteLine($"Memória: {nokiaModerno.Memoria}GB");
nokiaModerno.Ligar();
nokiaModerno.InstalarAplicativo("Maps");
Console.WriteLine("----------------------------------");

// Teste 4: Outro iPhone com número diferente
Console.WriteLine("\n--- iPhone Antigo (X) ---");
Iphone iphoneAntigo = new Iphone(numero: "1122-3344", modelo: "iPhone X", imei: "444444444", memoria: 64);
Console.WriteLine($"Número: {iphoneAntigo.Numero}");
Console.WriteLine($"Modelo: {iphoneAntigo.Modelo}");
Console.WriteLine($"IMEI: {iphoneAntigo.IMEI}");
Console.WriteLine($"Memória: {iphoneAntigo.Memoria}GB");
iphoneAntigo.ReceberLigacao();
iphoneAntigo.InstalarAplicativo("Facebook");
Console.WriteLine("----------------------------------");

Console.WriteLine("\n=== Fim dos Testes ===");