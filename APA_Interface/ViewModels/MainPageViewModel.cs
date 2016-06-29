using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Storage;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using APA_Interface.DataModel;

namespace APA_Interface.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Value = "Designtime value";
            }
        }

        public MainPageViewModel(String uniqueId, String title, String subtitle, String imagePath, String description, String content)
        {
            this.UniqueId = uniqueId;
            this.Title = title;
            this.Subtitle = subtitle;
            this.Description = description;
            this.ImagePath = imagePath;
            this.Content = content;
            //this.Items = new ObservableCollection<SampleDataItem>();
        }
        public string UniqueId { get; private set; }
        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public string Description { get; private set; }
        public string ImagePath { get; private set; }
        public string Content { get; private set; }

        string _Value = "Gas";
        public string Value { get { return _Value; } set { Set(ref _Value, value); } }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
                Value = suspensionState[nameof(Value)]?.ToString();
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(Value)] = Value;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public void GotoDetailsPage() =>
            NavigationService.Navigate(typeof(Views.DetailPage), Value);

        public void GotoAPAMainPage() => NavigationService.Navigate(typeof (Views.APA.MainPage));

        public void GotoSettings() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 0);

        public void GotoPrivacy() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);

        public void GotoAbout() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 2);

        public override string ToString()
        {
            return this.Title;
        }
    }

    public sealed class SampleDataSource
    {
        private static readonly SampleDataSource _sampleDataSource = new SampleDataSource();

        private readonly ObservableCollection<SampleDataGroup> _groups = new ObservableCollection<SampleDataGroup>();

        public ObservableCollection<SampleDataGroup> Groups => this._groups;

        public static async Task<IEnumerable<SampleDataGroup>> GetGroupsAsync()
        {
            await _sampleDataSource.GetSampleDataAsync();

            return _sampleDataSource.Groups;
        }

        public static async Task<SampleDataGroup> GetGroupAsync(string uniqueId)
        {
            await _sampleDataSource.GetSampleDataAsync();
            // Для небольших наборов данных можно использовать простой линейный поиск
            var matches = _sampleDataSource.Groups.Where((group) => group.UniqueId.Equals(uniqueId));
            IEnumerable<SampleDataGroup> sampleDataGroups = matches as IList<SampleDataGroup> ?? matches.ToList();
            if (sampleDataGroups.Count() == 1) return sampleDataGroups.First();
            return null;
        }

        public static async Task<SampleDataItem> GetItemAsync(string uniqueId)
        {
            await _sampleDataSource.GetSampleDataAsync();
            // Для небольших наборов данных можно использовать простой линейный поиск
            var matches =
                _sampleDataSource.Groups.SelectMany(group => group.Items)
                    .Where((item) => item.UniqueId.Equals(uniqueId));
            IEnumerable<SampleDataItem> sampleDataItems = matches as IList<SampleDataItem> ?? matches.ToList();
            if (sampleDataItems.Count() == 1) return sampleDataItems.First();
            return null;
        }

        private async Task GetSampleDataAsync()
        {
            if (this._groups.Count != 0)
                return;

            Uri dataUri = new Uri("ms-appx:///DataModel/SampleData.json");

            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(dataUri);
            string jsonText = await FileIO.ReadTextAsync(file);
            JsonObject jsonObject = JsonObject.Parse(jsonText);
            JsonArray jsonArray = jsonObject["Groups"].GetArray();

            foreach (var jsonValue in jsonArray)
            {
                var groupValue = (JsonValue) jsonValue;
                JsonObject groupObject = groupValue.GetObject();
                SampleDataGroup group = new SampleDataGroup(groupObject["UniqueId"].GetString(),
                    groupObject["Title"].GetString(),
                    groupObject["Subtitle"].GetString(),
                    groupObject["ImagePath"].GetString(),
                    groupObject["Description"].GetString());

                foreach (var jsonValue1 in groupObject["Items"].GetArray())
                {
                    var itemValue = (JsonValue) jsonValue1;
                    JsonObject itemObject = itemValue.GetObject();
                    group.Items.Add(new SampleDataItem(itemObject["UniqueId"].GetString(),
                        itemObject["Title"].GetString(),
                        itemObject["Subtitle"].GetString(),
                        itemObject["ImagePath"].GetString(),
                        itemObject["Description"].GetString(),
                        itemObject["Content"].GetString()));
                }
                this.Groups.Add(group);
            }
        }
    }
}

