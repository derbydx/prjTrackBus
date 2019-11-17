using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailBusMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailBusMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailBusMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailBusMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailBusMenuItem> MenuItems { get; set; }

            public MasterDetailBusMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailBusMenuItem>(new[]
                {
                    new MasterDetailBusMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailBusMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailBusMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailBusMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailBusMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
