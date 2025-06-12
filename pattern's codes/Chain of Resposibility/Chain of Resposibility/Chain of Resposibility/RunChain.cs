
namespace Chain_of_Resposibility;

public class RunChain
{
    public void Execute()
    {
        Handler handlerA = new ConcreteHandlerA();
        Handler handlerB = new ConcreteHandlerB();
        Handler handlerC = new ConcreteHandlerC();

        handlerA.SetNext(handlerB);
        handlerB.SetNext(handlerC);

        int[] requests = { 5, 15, 25 };

        foreach (var request in requests)
        {
            handlerA.HandleRequest(request);
        }
    }
}
