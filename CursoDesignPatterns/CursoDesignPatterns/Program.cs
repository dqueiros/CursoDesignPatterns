// See https://aka.ms/new-console-template for more information
using CursoDesignPatterns.PatternsComportamental.Observer;


Console.WriteLine("\nCurso Design Patterns\n");

SendMail sendMail = new SendMail();
sendMail.EnviarEmail();
