

namespace Chain_of_Resposibility;
public class ConcreteHandlerA : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 10)
        {
            Console.WriteLine($"Handler A processed request {request}.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }
}