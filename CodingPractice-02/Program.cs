using System;
///1.명시적 변환
Celsius c = new Celsius(100);
Fahrenheit f = (Fahrenheit)c;
Console.WriteLine(c); 
Console.WriteLine(f);
Console.WriteLine();

///2.실전 예제: Vector3 구조체
Vector3 vector1 = new Vector3(1, 2, 3);
Vector3 vector2 = new Vector3(4, 5, 6);
Console.WriteLine(vector1+vector2);
Console.WriteLine(vector1-vector2);
Console.WriteLine(vector1 * 2);
Console.WriteLine(3 * vector2);
Console.WriteLine(-vector1);
Console.WriteLine(vector1==vector2);
