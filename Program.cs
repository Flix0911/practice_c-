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
// using System.Runtime.InteropServices;

// int a = 99 + 2;

// define a str ~ double "quotes"
// string b = "abc" + "xyz";

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(a + b);

// define a byte ~ 0 - 255
// used for low level coding ~ performant code
// byte c = 255;
// Console.WriteLine(c);

// char is unicode
// char d = 'a';
// Console.WriteLine(d);

// how to store decimals in see sharp
// C# wants to convernt decimals to a double
// double is a large number and very precise
// double testDouble = 14.43;
// Console.WriteLine(testDouble);

// Float, in algebra, a decimal number alone, not a whole number
// must put an f at the end
// float testFloat = 0.18f;
// Console.WriteLine(testFloat);

// decimal ~ m at the end
// decimal testDecimal = .023123m;
// Console.WriteLine(testDecimal);

// plus
// int testVariable = 1 + 1;
// Console.WriteLine(testVariable);

// subtract
// int minusVariable = 1 + 1;
// Console.WriteLine(minusVariable);

// multiple
// int multiVariable = 5 * 5;
// Console.WriteLine(multiVariable);

// divide
// int diviVariable = 4 / 2;
// Console.WriteLine(diviVariable);

// modulo
// int moduVariable = 2 % 2;
// Console.WriteLine(moduVariable);
// int modu2Variable = 7 % 2;
// Console.WriteLine(modu2Variable);

// modulo double
// double moduDoubleVariable = 7.0 % 2;
// Console.WriteLine(moduDoubleVariable);

// incrementers
// +=
// -=
// *=



// int learnVariable = 1;
// learnVariable += 1; //makes this dryer and is an incrementer
// syntatic sugar
// Console.WriteLine(learnVariable);

// incrementer for just one
// ++ +1
// -- -1

// int learnIncrementerPlusVariables = 0;
// learnIncrementerPlusVariables--;
// Console.WriteLine(learnIncrementerPlusVariables);



// ------------------------------------------

// Lesson 3

// Typecasting 

// below is a int
// int bigNum = 21474;

// long num = bigNum;

// Console.Write(num);

// 2 types of type casting

// implicity & explicit

// This can't happen because we said i is an int, and i = a string
// compiler implicity knows
// int i;
// i = "hello";

//implicit 
// int num2 = 656563465;
// long bigNum2 = num2;

// explicit
// double x = 1235.8;
// int a;
// Cast double to int
// cast is (int)x; ~ EXPLICITY CONVERSION
// a = x; ~ will tell you that you are missing a cast
// if program is covered in cast, maybe look at what you're doing
// a = (int)x;
// Console.WriteLine(a);

// Casting can be dangerous ~ could go wrong at runtime
// Effects of that casting could trickle down to other parts of the program *****
// This can be a cascading effect

// important conversion
// How do we convert a string to an int

// string value = "54534534"; //will give us success
// string value = "hsdljahskldjahs"; //will give failure

// int result = 0;

// TryParse, can throw into if/else, before it passess it to other parts of the program
// if it works "out' will assign it to the result
// If it doesn't work, it'll just failure
// if(int.TryParse(value, out result))
// {
//     Console.WriteLine("Success: " + result);
// }
// else 
// {
//     Console.WriteLine("Failure");
// }



// ------------------------------------------



// Lesson 4

// How does the stack and the heap work

// Stack is for the value type and a Heap is for reference types

// (object reference warning ~ could be a hint)
// Computer is storing data on what type it is, and storing on the stack vs the heap. ~ Lets learn what's the difference

// int, named testValue, that is 4 ~ pretty low level
using PracticeTutorial;

int testValue = 4;
// very low level
byte lowLevelValue = 3;
// Boolean value
bool boolValue = false; //stored on the stack ~ small value

// string ~ value type
string stringValue = "string";

Console.WriteLine(stringValue);

// control + . to bring it in
// This is a big object ~ it's labeled and you can get it when you want to
MyNewClass stackHeap = new MyNewClass();

stackHeap.AddFive(1);

// Stack hgas to be accessed exactly as it sounds ~ small sources of data {stack is for value types}
// Heap, has no structure/order, you can pull from it ~ large sources of data {can store large objects or references of data}
// ****BEGINNERS SAKE****