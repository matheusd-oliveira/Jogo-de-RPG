using static System.Console;

// Criando objetos de cada classe de heroi.

Knight knight = new Knight("Arus", 42, "Knight", 469, 72);
WhiteWizard whiteWizard = new WhiteWizard("Jennica", 23, "White Wizard", 325, 474);
BlackWizard blackWizard = new BlackWizard("Topapa", 32, "Black Wizard", 106, 611);
Ninja ninja = new Ninja("Wedge", 56, "Ninja", 292, 89);


// Apresentando hérois:
WriteLine(knight);
WriteLine("-------------");
WriteLine(whiteWizard);
WriteLine("-------------");
WriteLine(blackWizard);
WriteLine("-------------");
WriteLine(ninja);
WriteLine("-------------");
WriteLine();
// Lutas

WriteLine("Luta 1");
WriteLine(knight.Attack());
Thread.Sleep(1000);
WriteLine(whiteWizard.Defense());
Thread.Sleep(1000);
WriteLine(whiteWizard.Attack());
Thread.Sleep(1000);
WriteLine(whiteWizard.Attack(1));
Thread.Sleep(1000);
WriteLine(whiteWizard.Attack(7));
WriteLine(knight.Defense());
WriteLine();

WriteLine("Luta 2");
WriteLine(ninja.Attack());
Thread.Sleep(1000);
WriteLine(blackWizard.Defense());
Thread.Sleep(1000);
WriteLine(blackWizard.Attack());
Thread.Sleep(1000);
WriteLine(ninja.Defense());







