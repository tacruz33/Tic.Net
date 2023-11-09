// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region 

int tipoInteiro;
double tipoDouble;
string tipoString;
long tipoLong;

tipoInteiro = int.MaxValue;
tipoLong = long.MaxValue;

tipoDouble = tipoInteiro = tipoLong;

tipoString = "100A";

tipoInteiro = int.Parse(tipoString);

Console.WriteLine("O máximo inteiro é : " + tipoInteiro);
Console.WriteLine("O máximo long é : " + tipoLong);

#endregion