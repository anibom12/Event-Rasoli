
namespace Chain_of_Resposibility;

public class ConcreteHandlerC : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20)
        {
            Console.WriteLine($"Handler C processed request {request}.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}
