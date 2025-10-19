using DesafioPOO.Models;
using System;

        Nokia nokia = new(numero: "9299129-1613", modelo: "G21", imei: "001970-01-010000-0", memoria: 128);
        
        Console.WriteLine($"Nokia: Número {nokia.Numero}, Modelo {nokia.Modelo}, Memória {nokia.Memoria}GB");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");
        
        Iphone iphone = new(numero: "9299138-2617", modelo: "16e", imei: "002070-01-010000-0", memoria: 256);

        Console.WriteLine($"IPhone: Número {iphone.Numero}, Modelo {iphone.Modelo}, Memória {iphone.Memoria}GB");
        
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
