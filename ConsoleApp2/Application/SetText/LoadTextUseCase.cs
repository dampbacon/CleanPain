namespace ScopedVmBundleClean.Application.SetText
{
    public class LoadTextUseCase
    {
        public void Execute(ILoadTextOutputPort outputPort)
        {
            var text = "Hello from the clean solution!";
            outputPort.Present(text);
        }
    }

}
