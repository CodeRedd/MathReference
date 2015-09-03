using System;
using System.Collections.ObjectModel;

namespace MathReference.ViewModel
{
   class EquationManager
   {
      public EquationManager()
      {
         EquationList = new ObservableCollection<string>() { "ListItem1", "ListItem2", "ListItem3" };
      }

      #region Properties
      public ObservableCollection<string> EquationList { get; set; }
      #endregion
   }
}
