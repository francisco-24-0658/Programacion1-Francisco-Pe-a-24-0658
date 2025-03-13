Console.WriteLine("Utiliza matemáticas");

var sum = new Suma(3,2, 4);
var mul = new Multi(3,2, 4);
var res = new Resta(3,2,3);
var div = new Divid(3, 3, 4);
var sumraiz = new SumarRaiz(1,3,4);
Console.WriteLine(sum.Sumar(0));
Console.WriteLine(res.Sumar(2));
Console.WriteLine(mul.Sumar(3));
Console.WriteLine(div.Sumar(3));
Console.WriteLine(sumraiz.Sumar(3));