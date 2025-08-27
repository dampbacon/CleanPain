using ScopedVmBundleClean.Application.SetText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopedVmBundleClean.Presentation.Presenters
{

    public class TextPresenter : ILoadTextOutputPort
    {
        private readonly LoadTextUseCase _loadTextUseCase;
        public required TestViewModel ViewModel { get; set; }

        public TextPresenter(LoadTextUseCase loadTextUseCase)
        {
            _loadTextUseCase = loadTextUseCase;
        }

        public void LoadText()
        {
            _loadTextUseCase.Execute(this);
        }

        public void Present(string text)
        {
            ViewModel.SetText(text);
            ViewModel.SetError(null);
        }
    }
}
