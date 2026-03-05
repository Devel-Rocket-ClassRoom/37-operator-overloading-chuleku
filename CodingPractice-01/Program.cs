using System;
using System.Diagnostics.CodeAnalysis;

///1.단항연산자
Counter counter = new Counter(5);
Console.WriteLine(-counter);
counter++;
Console.WriteLine(counter);
Console.WriteLine();
///2.이항 연산자
Fraction F1 = new Fraction(1,2);
Fraction F2 = new Fraction(1,3);
Console.WriteLine(F1 + F2);
Console.WriteLine(F1 * F2);
Console.WriteLine();


///3. 비교 연산자
Money m1 = new Money(1000, "KRW");
Money m2 = new Money(2000, "KRW");
Console.WriteLine(m1==m2);
Console.WriteLine(m1<m2);
Console.WriteLine();

///4. 복합 대입 연산자
Vector2 v = new Vector2(1,2);
v += new Vector2(3, 4);
Console.WriteLine(v);
Console.WriteLine();

///5.암시적 변환
Celsius temp = 36.5;
double velue = temp;
Console.WriteLine(velue);
Console.WriteLine();