using System.Collections.ObjectModel;
using MathReference.Datatypes;

namespace MathReference.Model
{
   class Superscript : Symbol
   {
      public Superscript( ObservableCollection<Symbol> content )
      {
         Type = SymbolType.SUPERSCRIPT;
         Contents = content;
      }

      public ObservableCollection<Symbol> Contents { get; set; }
   }
}
