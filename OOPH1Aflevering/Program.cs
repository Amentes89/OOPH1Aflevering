//Projekt, 1

global using OOPH1Aflevering.Codes1;

#region QuizTest
//MotorKøretøj motorKøretøj = new MotorKøretøj();
//MotorKøretøj motorKøretøj = new Bil();
//MotorKøretøj motorKøretøj = new Audi();
//Audi audi = new Audi();
//Audi audi = new Bil();
//Audi audi = new MotorKøretøj()

//Console.Write("Angiv hestekræfter: ");
//int power = Convert.ToInt32(Console.ReadLine());

//Console.Write("Angiv mærke: ");
//string brand = Console.ReadLine();

//Console.Write("Angiv model: ");
//string model = Console.ReadLine();

//Bil bilen = new Bil { Mærke = brand, Model = model, HesteKræfter = power };

//Console.Clear();
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("----------------------------------------------------------");
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($"Bilen er en {bilen.Mærke} {bilen.Model} med {bilen.HesteKræfter} hestekrafter.");
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("----------------------------------------------------------");
//Console.WriteLine();

//Console.ReadLine();
#endregion
#region Quiz
//Del 1.
//Spørgsmål 1:
//1 og 4 kan istantieres uden fejl.

//Spørgsmål 2:
//Ja, med yderligere kode.

//Spørgsmål 3:
//Nej.

//Del 2.
//Spørgsmål 1:
//List < Bil > bil = new()
//{
//    new Bil { Mærke = "Toyota", Model = "Aygo", HesteKræfter = 60 },
//    new Bil { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
//    new Bil { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }
//};

//Spørgsmål 2:
//Bil b1 = bil.FirstOrDefault(a => a.HesteKræfter == 90);
//Bil b2 = bil.FirstOrDefault(a => a.HesteKræfter == 175);

//Console.WriteLine($"{b1.Mærke} {b1.Model}");
//Console.WriteLine($"{b2.Mærke} {b2.Model}");

// eller where LINQ

//List<Bil> biler = bil.Where(a => a.Hestekræfter > 60).ToList();
//foreach (Bil line in bil)
//{
//    if (line.Hestekræfter > 60)
//    {
//        Console.WriteLine(line.Mærke);
//    }
//}

//Spørgsmål 3:
//Bil b = Biler.FirstOrDefault(a => a.Mærke == "Audi");
//Console.WriteLine($"{b.Mærke}{b.Model}{b.HesteKræfter}");

//Del 3.
//Spørgsmål 1:
//?? = Biler.Where(...);

//Spørgsmål 2:
//?? = Biler.FirstOrDefault(...);
//?? = Biler.First(...)

//Spørgsmål 3:
//?? = Biler.Where(...);

//Spørgsmål 4:
//?? = Biler.First(...);

//Del 4.
//Spørgsmål 1:
//Abstrakt

//Del 5.
//Spørgsmål 1:
//Vi kan se at SetSyn har to metoder, deraf er den overloadet.
#endregion

