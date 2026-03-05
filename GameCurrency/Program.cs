using System;

Gamecurrency wallet1 = new Gamecurrency(3,50);
Gamecurrency wallet2 = new Gamecurrency(1,80);
Console.WriteLine($"지갑1: {wallet1}");
Console.WriteLine($"지갑2: {wallet2}");

Gamecurrency sum = wallet1 + wallet2;
Console.WriteLine($"합계: {sum}");

Gamecurrency diff = wallet2 - wallet1;
Console.WriteLine($"차액: {diff}");

Console.WriteLine($"지갑1 == 지갑2: {wallet1 == wallet2}");
Console.WriteLine($"지갑1 != 지갑2: {wallet1 != wallet2}");
Console.WriteLine($"지갑1 > 지갑2: {wallet1 > wallet2}");
Console.WriteLine($"지갑1 < 지갑2: {wallet1 < wallet2}");

Gamecurrency wallet3 = new Gamecurrency(0, 250);
Console.WriteLine($"250S 정규화: {wallet3}");
Console.WriteLine($"지갑1 총 Silver: {wallet1.GetTotalSilver()}");