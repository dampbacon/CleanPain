using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ScopedVmBundleClean.Presentation.Presenters;

namespace ScopedVmBundleClean
{

    public partial class TestViewModel : ObservableObject
    {

        private readonly TextPresenter _textPresenter;
        private readonly ValidationPresenter _validationPresenter;



        public TestViewModel(
            TextPresenter textPresenter,
            ValidationPresenter validationPresenter)
        {
            _textPresenter = textPresenter;
            _validationPresenter = validationPresenter;

            _textPresenter.ViewModel = this;
            _validationPresenter.ViewModel = this;

            LoadTextCommand = new RelayCommand(() => _textPresenter.LoadText());
            ValidateTextCommand = new RelayCommand(() => _validationPresenter.ValidateText(Text ?? ""));
        }


        /* @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
         * An option if we don't want the presenters to have vm logic
         * 
         * We could also if we really wanted to do IObservable/streams If the presentation state of something is shared between screensw
         * Reusing presenters that aren't concrete to the view model 
         * 
         * https://www.nuget.org/packages/System.Reactive DotNet Foundation
         * @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
         
        private void OnLoadText()
        {
            string text = _textPresenter.LoadText();
            SetText(text);
            SetError(null); // reset error when loading
        }

        private void OnValidateText()
        {
            var error = _validationPresenter.ValidateText(Text);
            SetError(error);
        }
         
        */

        [ObservableProperty]
        public partial string? Text { get; private set; }

        [ObservableProperty]
        public partial string? Error { get; private set; }

        public RelayCommand LoadTextCommand { get; }
        public RelayCommand ValidateTextCommand { get; }


        internal void SetText(string text) => Text = text;
        internal void SetError(string? error) => Error = error;

    }

}
