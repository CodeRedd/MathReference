using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace MathReference.Model
{
   class Equation
   {
      private List<string> ParentCategories { get; set; }

      public Equation( string equationTitle, ObservableCollection<Symbol> equationSymbols, List<string> categories )
      {
         Title = equationTitle;
         DisplaySymbols = equationSymbols;
         ParentCategories = categories;
      }

      #region Properties

      public string Title { get; set; }
      public ObservableCollection<Symbol> DisplaySymbols { get; set; }

      #endregion

      public bool HasTag( string tag )
      {
         return ParentCategories.Contains( tag );
      }
   }
}
