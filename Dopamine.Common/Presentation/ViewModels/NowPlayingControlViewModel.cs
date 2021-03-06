﻿using Dopamine.Common.Base;
using Dopamine.Common.Presentation.ViewModels.Base;
using Microsoft.Practices.Unity;
using System.Threading.Tasks;

namespace Dopamine.Common.Presentation.ViewModels
{
    public class NowPlayingControlViewModel : NowPlayingViewModelBase
    {
        #region Construction
        public NowPlayingControlViewModel(IUnityContainer container) : base(container)
        {
        }
        #endregion

        #region Overrides
        protected async override Task LoadedCommandAsync()
        {
            if (!this.IsFirstLoad()) return;
            await Task.Delay(Constants.NowPlayingListLoadDelay);  // Wait for the UI to slide in
            await this.FillListsAsync(); // Fill all the lists
        }
        #endregion
    }
}
