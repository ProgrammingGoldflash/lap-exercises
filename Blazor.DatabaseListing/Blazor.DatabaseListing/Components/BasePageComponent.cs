using Microsoft.AspNetCore.Components;

namespace Blazor.DatabaseListing.Components
{
    public class BasePageComponent : ComponentBase
    {
        #region Public Constructors

        public BasePageComponent(NavigationManager navManager, PageHistoryState pageState)
        {
            NavManager = navManager;
            PageState = pageState;
        }

        public BasePageComponent()
        {
        }

        #endregion Public Constructors

        #region Protected Properties

        [Inject]
        protected NavigationManager NavManager { get; set; }

        [Inject]
        protected PageHistoryState PageState { get; set; }

        #endregion Protected Properties

        #region Protected Methods

        protected override void OnInitialized()
        {
            base.OnInitialized();
            PageState.AddPage(NavManager.Uri);
        }

        #endregion Protected Methods
    }
}