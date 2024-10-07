using InterfaceExample;

void Demo(IProduct item)
{
    item.CalculateServiceCharge();
    item.CalculateDiscount();
}

Demo(new Camera());
