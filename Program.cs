using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n = new("50795623", 128, "11111", "A3");
n.Ligar();
n.InstalarAplicativo("Whats");
n.ReceberLigacao();


Iphone i = new("78888888", 64, "2222", "sm-1234");
i.Ligar();
i.InstalarAplicativo("Whats");
i.ReceberLigacao();