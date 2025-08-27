namespace ScopedVmBundleClean.Application.ValidateText
{
    public class ValidateTextUseCase
    {
        public void Execute(string text, IValidateTextOutputPort outputPort)
        {
            string? error = null;
            if (string.IsNullOrWhiteSpace(text))
                error = "Text cannot be empty.";
            else if (text.Length < 3)
                error = "Text is too short.";

            outputPort.Present(error);
        }
    }

}
