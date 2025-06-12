
namespace Factory_Method;

public class ConcreteCreatorA:Creator
{
    public override IProduct FactoryMethod() => new ConcreteProductA();

}
