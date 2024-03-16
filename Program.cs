// See https://aka.ms/new-console-template for more information
// Console ~ C# is an older programming language and possibly left over from previous languages
// When you look at programming, you will see the bedrock



// YOU MUST HAVE ;
// Console.WriteLine("You are a noob");
// error on the terminal tells you what it expected


// This is where you're going to write code in

// lesson 1
// lets make variables
// var testVar = "noob";

// pass in the variable
// Console.WriteLine(testVar);



// ------------------------------------------

// keywords are defined in the program (while, for, etc)
// camel casing for c# variables

// lesson 2
// Variables are where you store data

// DATA TYPES

// define as an int, variable name 'a', which is 99
using System.Runtime.InteropServices;

int a = 99 + 2;

// define a str ~ double "quotes"
string b = "abc" + "xyz";

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(a + b);

// define a byte ~ 0 - 255
// used for low level coding ~ performant code
byte c = 255;
Console.WriteLine(c);

// char is unicode
char d = 'a';
Console.WriteLine(d);

// how to store decimals in see sharp
// C# wants to convernt decimals to a double
// double is a large number and very precise
double testDouble = 14.43;
Console.WriteLine(testDouble);

// Float, in algebra, a decimal number alone, not a whole number
// must put an f at the end
float testFloat = 0.18f;
Console.WriteLine(testFloat);

// decimal ~ m at the end
decimal testDecimal = .023123m;
Console.WriteLine(testDecimal);

// plus
int testVariable = 1 + 1;
Console.WriteLine(testVariable);

// subtract
int minusVariable = 1 + 1;
Console.WriteLine(minusVariable);

// multiple
int multiVariable = 5 * 5;
Console.WriteLine(multiVariable);

// divide
int diviVariable = 4 / 2;
Console.WriteLine(diviVariable);

// modulo
int moduVariable = 2 % 2;
Console.WriteLine(moduVariable);
int modu2Variable = 7 % 2;
Console.WriteLine(modu2Variable);

// modulo double
double moduDoubleVariable = 7.0 % 2;
Console.WriteLine(moduDoubleVariable);

// incrementers
// +=
// -=
// *=



int learnVariable = 1;
learnVariable += 1; //makes this dryer and is an incrementer
// syntatic sugar
Console.WriteLine(learnVariable);

// incrementer for just one
// ++ +1
// -- -1

int learnIncrementerPlusVariables = 0;
learnIncrementerPlusVariables--;
Console.WriteLine(learnIncrementerPlusVariables);
