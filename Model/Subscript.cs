using System.Collections.ObjectModel;
using MathReference.Datatypes;

namespace MathReference.Model
{
   class Subscript : Symbol
   {
      public Subscript( ObservableCollection<Symbol> content )
      {
         Type = SymbolType.SUBSCRIPT;
         Contents = content;
      }

      public ObservableCollection<Symbol> Contents { get; set; }
   }
}
