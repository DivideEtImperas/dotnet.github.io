//7. Покупка товара с акциями. Если стоимость больше 1000р скидка 20%. 
//   Если заказ более чем 700р доставка бесплатно/
double price = Random.Shared.Next(5*15)*100;
double delivery = 100;
//double sale = 20;
Console.WriteLine($"price: {price}");
Console.ReadLine();

if(price >1000) price*=0.8;
if(price <= 700) price +=delivery;
//if (price >= 700) {} else price += delivery;

Console.WriteLine($"price: {price}");
