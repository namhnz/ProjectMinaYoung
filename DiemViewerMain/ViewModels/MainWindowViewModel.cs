using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiemViewerMain.Views;
using Prism.Mvvm;
using Prism.Regions;

namespace DiemViewerMain.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            _regionManager.RegisterViewWithRegion("MainContentRegion", typeof(RegisteredWithRegionTestView));

            _regionManager.RequestNavigate("MainContentRegion", "NavigationTestView", result =>
            {

            });
        }
    }
}
