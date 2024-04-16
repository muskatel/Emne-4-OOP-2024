// See https://aka.ms/new-console-template for more information

using ClassLibraryInsideExisting;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

NumberCruncher nc = new NumberCruncher(3242, 7);
Console.WriteLine(nc.Output());
