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

// --------------------------- Ejercicio 2-----------------------------


// string num1="",num2="";
// bool condicion = true;
// float resultado=0,Num1=0,Num2=0;
// string opcion = "";
// while (condicion) { 
//     Console.WriteLine("Elija Su operacion");
//     Console.WriteLine(" 1 : Suma \n 2: Resta \n 3: Division \n 4: Multiplicación");
//     opcion= Console.ReadLine();
//     Console.WriteLine("Ingrese el primer operando");
//     num1 = Console.ReadLine();
//     Console.WriteLine("Ingrese el segundo operando ");
//     num2 = Console.ReadLine();
//     condicion = (float.TryParse(num1,out Num1) && float.TryParse(num2,out Num2));
//         switch(opcion){
//                 case "1" : 
//                     resultado = Num1 + Num2;
//                     break;
//                 case "2" :
//                     resultado = Num1- Num2;
//                     break;
//                 case "3" :
//                     resultado = Num1 / Num2;
//                     break;
//                 case "4" : 
//                     resultado = Num1 * Num2;
//                     break;
//                 default:
//                         condicion= false;
//                         Console.WriteLine("No se ha elegido una operación valida");
//                         break;
//             }
//             if(condicion){
//                 Console.WriteLine(" El resultado de su operacion es "+ resultado);
//             } 
//         Console.WriteLine("Desea seguir operando");
//         opcion= Console.ReadLine();
//         if (opcion == "no" || opcion =="No" || opcion == "0"){
//             condicion = false;
//         }
// }

// -------------------Ejercicio 3 -----------------------

// float Numero =0,float1,float2,aux;
// string Entrada="";
// bool condicion = true;

// while(condicion){
//     Console.WriteLine("Ingrese su numero");
//     Entrada=Console.ReadLine();
//     condicion = float.TryParse(Entrada, out Numero);
//     if (condicion){ 
//         Console.WriteLine("Valor Absoluto :"+ Math.Abs(Numero));
//         Console.WriteLine("Cuadrado :"+ (Numero*Numero));
//         Console.WriteLine("Raiz "+ Math.Sqrt(Numero));
//         Console.WriteLine("Seno : " + Math.Sin(Numero));
//         Console.WriteLine("Coseno : "+ Math.Cos(Numero));
//         Console.WriteLine("Parte entera " + Math.Truncate(Numero));
//     }
//     else{
//     Console.WriteLine("Numero no valido");
//     }
//    Console.WriteLine("Ingrese el primer Numero");
//     string? Num1 =Console.ReadLine();
//     condicion = float.TryParse(Num1,out float1);
//     if (condicion){
//         string? Num2 = Console.ReadLine();
//         Console.WriteLine("Ingrese el Segundo Numero");
//         condicion = float.TryParse(Num2, out float2);
//         if (condicion) {
//             if (float1 < float2){
//                 aux = float1;
//                 float1 = float2;
//                 float2 = aux;
//             }
//             Console.WriteLine("El numero Maximo es "+ float1);
//             Console.WriteLine("El minimo de los numeros es " + float2);
//             } else{
//         Console.WriteLine("Numero no valido");
//         }
//     } else{
//     Console.WriteLine("Numero no valido");
//     }

    
// }



// -------------------Ejercicio 4 --------------------
// String? linea="",linea2="";
// Console.WriteLine("Ingrese su string");
// linea=Console.ReadLine();
// int longitud = linea.Length;
// Console.WriteLine("La longitud de el string es " + longitud);
// Console.WriteLine("Ingrese la segunda Linea");
// linea2=Console.ReadLine();
// string? Concatenadas = string.Concat(linea,linea2);
// Console.WriteLine("Las lineas concatenadas es "+ Concatenadas);
// string? Subcadena = Concatenadas.Substring(longitud);
// Console.WriteLine("La subcadena es"+ Subcadena);
// foreach(char letra in Concatenadas){
//     Console.WriteLine(letra);
// }
// Boolean contiene = Concatenadas.Contains(linea);
// if (contiene){
//     Console.WriteLine("Si se encuentra dentro de la cadena");
// } else {
//     Console.WriteLine("No la contiene a la linea solicitada");
// }
// string? mayusculas = Concatenadas.ToUpper();
// string? minusculas = Concatenadas.ToLower();
// Console.WriteLine("Cadena en mayúsculas: " + mayusculas);
// Console.WriteLine("Cadena en minúsculas: " + minusculas);


// ---------------------------- Ejercicio 5-----------------//
using System.Text.RegularExpressions;
string? mail = "mailejemplo@gmail.com";
string? patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; // Usando el @ podemos escribir los signos sin problema, adémas los corchetes indican cual es la sintaxis valida dentro de la expresion usada
bool Valido = Regex.IsMatch(mail,patron);
if(Valido){
    Console.WriteLine("Es un mail Valido");
}else{
    Console.WriteLine("No es un mail valido");
}

string? sitio = "http://sitioEjemplo.com";
string? patron2 = @"^(http|https)://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,}(?:/[^/\s]*)?$"; // Aca podemos indicarle que el comienzo debe ser co http o https y que debe tener una parte final que termine con . algo, al igual que con el mail
bool Valido2 = Regex.IsMatch(sitio,patron2);
if(Valido2){
    Console.WriteLine("Es un sitio Valido");
}else{
    Console.WriteLine("No es un sitio valido");
}