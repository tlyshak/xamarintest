using Xamarin.Forms;

namespace App3
{
    public class MainPageViewModel : BindableObject
    {
        private string _modelText;

        public string ModelText
        {
            get { return _modelText; }
            set
            {
                _modelText = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            ModelText = "TextFromViewModel";
        }
    }
}