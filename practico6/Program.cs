// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// // Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

float Num=0;
int i ;
bool Noanda = false;
string? NumeroString = "";
string? StringCambiado = "";
while(!Noanda){
    Console.WriteLine("Ingrese un numero");
    NumeroString = Console.ReadLine();
    Noanda = float.TryParse(NumeroString, out Num);
    if(!Noanda){
        Console.WriteLine(NumeroString + "No es un numero valido");
    }
    for (i=NumeroString.Length-1;i>=0;i--){
        StringCambiado += NumeroString[i];
    }
}
Console.WriteLine(StringCambiado + " Es el numero cambiado");