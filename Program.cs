using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone1 = new Iphone("987654321", "13 PRO MAX", "12345asdfg", 512);
Nokia nokia1 = new Nokia("123456789","N90","987654lkjhg",64);

Console.WriteLine("Smartphone IPHONE");
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone NOKIA");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Messenge");
