using Prism.Modularity;
using Prism.Regions;
using System;
using HQF.WPF.ToolKitDemos.Views;

namespace HQF.WPF.ToolKitDemos
{
    public class ToolKitDemosModule : IModule
    {
        IRegionManager _regionManager;

        public ToolKitDemosModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainContent", typeof(BusyIndicatorView));
        }
    }
}