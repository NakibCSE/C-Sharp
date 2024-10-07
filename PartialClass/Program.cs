using PartialClass;

Product product = new Product();
product.Name = "Camera";
product.Price = 80000;
product.CalculateDiscountedPrice(20);
product.CalculateDeliveryCharge(200);

