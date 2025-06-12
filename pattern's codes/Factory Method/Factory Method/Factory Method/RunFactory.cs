

namespace Factory_Method;

public class RunFactory
{

    public void Execute()
    {
        Creator creatorA = new ConcreteCreatorA();
        IProduct productA = creatorA.FactoryMethod();
        productA.ShowInfo();

        Creator creatorB = new ConrerteCreatorB();
        IProduct productB = creatorB.FactoryMethod();
        productB.ShowInfo(); 
    }
}
