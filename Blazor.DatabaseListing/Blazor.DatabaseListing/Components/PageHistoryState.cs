using System.Collections.Generic;
using System.Linq;

namespace Blazor.DatabaseListing.Components
{
    public class PageHistoryState
    {
        #region Private Fields

        private readonly List<string> _previousPages = new List<string>();

        #endregion Private Fields

        #region Public Methods

        public void AddPage(string pageName)
        {
            _previousPages.Add(pageName);
        }

        public bool CanGoBack()
        {
            return _previousPages.Count > 1;
        }

        public string PreviousPage()
        {
            if (_previousPages.Count > 1)
            {
                // You add a page on initialization, so you need to return the 2nd from the last
                return _previousPages.ElementAt(_previousPages.Count - 3);
            }

            // Can't go back because you didn't navigate enough
            return _previousPages.FirstOrDefault();
        }

        #endregion Public Methods
    }
}