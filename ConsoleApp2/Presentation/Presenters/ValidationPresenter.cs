using ScopedVmBundleClean.Application.ValidateText;

namespace ScopedVmBundleClean.Presentation.Presenters
{
    public class ValidationPresenter : IValidateTextOutputPort
    {

        private readonly ValidateTextUseCase _validateTextUseCase;
        public required TestViewModel ViewModel { get; set; }

        public ValidationPresenter(ValidateTextUseCase validateTextUseCase)
        {
            _validateTextUseCase = validateTextUseCase;
        }

        public void ValidateText(string text)
        {
            _validateTextUseCase.Execute(text, this);
        }

        public void Present(string? error)
        {
            ViewModel.SetError(error);
        }
    }
}
