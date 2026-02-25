using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Product[] products = new Product[3]
{
    new Product{Name = "노트북", Price = 1500000, Stock = 5},
    new Product{Name = "마우스", Price = 35000, Stock = 20},
    new Product{Name = "키보드", Price = 89000, Stock = 15}
};

Console.WriteLine("=== 상품 목록 ===");
foreach (var product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine();

Console.WriteLine("=== 거래 ===");
products[0].Sell(2);
products[1].Sell(5);
products[2].Sell(20);
products[2].AddStock(10);
Console.WriteLine();

Console.WriteLine("=== 최종 상품 목록 ===");
foreach (var product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine();

Console.WriteLine("=== 총 재고 가치 ===");
int sum = 0;
foreach (var product in products)
{
    sum += product.GetTotalValue();
    Console.WriteLine($"{product.Name}: {product.GetTotalValue()}원");
}
Console.WriteLine("---");
Console.WriteLine($"전체 재고 총 가치: {sum}원");