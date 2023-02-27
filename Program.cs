int a = 2;
int b = 4;
int c = 6;

Console.WriteLine("a = 2 // b = 4 // c = 6 ");

Console.WriteLine ($"\na^3-3a^2b+3ab^2-b^3 = {Math.Pow( a , 3 ) - 3 * ( Math.Pow( a , 2 * b)) + 3 * a * (Math.Pow( b , 2) ) - (Math.Pow( b , 3))}");

Console.WriteLine($"\na^3+3a^2b+3ab^2-b^3 = {Math.Pow(a, 3) + 3 * (Math.Pow(a, 2 * b)) + 3 * a * (Math.Pow(b, 2)) - (Math.Pow(b, 3))}");

Console.WriteLine($"\n(a+b)*(a^2-ab+b^2) = { (a + b ) * (Math.Pow( a , 2 ) - a * b + (Math.Pow(b , 2)))}");

Console.WriteLine($"\n(a-b)*(a^2+ab+b^2) = {(a - b) * (Math.Pow(a, 2) + a * b + (Math.Pow(b, 2)))}");

Console.WriteLine($"\n(a - b) * (a + b) = {(a - b) * (a + b)}");

Console.WriteLine($"\na^2-2ab+b^2 = {Math.Pow(a , 2) - 2 * a * b + (Math.Pow(b , 2))}");

Console.WriteLine($"\na^2+2ab+b^2 = {Math.Pow(a, 2) + 2 * a * b + (Math.Pow(b, 2))}");

Console.WriteLine($"\n((a^2-4bc)/(a - a^1/2-ac)-(abc)^3)/(a^2-2ab+b^2) = " +

$"{(Math.Pow(a , 2) - 4 * b * c) / (a - Math.Pow( a , 0.5) - Math.Pow(a , c)) - (Math.Pow( a * b * c , 3)) / (Math.Pow(a , 2 )) - 2 * a * b + Math.Pow( b ,2 )}");

