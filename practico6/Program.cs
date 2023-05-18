// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// // Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);



//----------------- Ejercicio 1 --------------------------

// float Num=0;
// int i ;
// bool Noanda = false;
// string? NumeroString = "";
// string? StringCambiado = "";
// while(!Noanda){
//     Console.WriteLine("Ingrese un numero");
//     NumeroString = Console.ReadLine();
//     Noanda = float.TryParse(NumeroString, out Num);
//     if(!Noanda){
//         Console.WriteLine(NumeroString + "No es un numero valido");
//     }
//     for (i=NumeroString.Length-1;i>=0;i--){
//         StringCambiado += NumeroString[i];
//     }
// }
// Console.WriteLine(StringCambiado + " Es el numero cambiado");
string num1="",num2="";
bool condicion = true;
float resultado=0,Num1=0,Num2=0;
string opcion = "";
while (condicion) { 
    Console.WriteLine("Elija Su operacion");
    Console.WriteLine(" 1 : Suma \n 2: Resta \n 3: Division \n 4: Multiplicación");
    opcion= Console.ReadLine();
    Console.WriteLine("Ingrese el primer operando");
    num1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo operando ");
    num2 = Console.ReadLine();
    condicion = (float.TryParse(num1,out Num1) && float.TryParse(num2,out Num2));
        switch(opcion){
                case "1" : 
                    resultado = Num1 + Num2;
                    break;
                case "2" :
                    resultado = Num1- Num2;
                    break;
                case "3" :
                    resultado = Num1 / Num2;
                    break;
                case "4" : 
                    resultado = Num1 * Num2;
                    break;
                default:
                        condicion= false;
                        Console.WriteLine("No se ha elegido una operación valida");
                        break;
            }
            if(condicion){
                Console.WriteLine(" El resultado de su operacion es "+ resultado);
            } 
        Console.WriteLine("Desea seguir operando");
        opcion= Console.ReadLine();
        if (opcion == "no" || opcion =="No" || opcion == "0"){
            condicion = false;
        }
}
