using System.Collections.ObjectModel;

namespace MathReference.Model
{
   class Subscript
   {
      public Subscript( ObservableCollection<Symbol> content )
      {
         Contents = content;
      }

      public ObservableCollection<Symbol> Contents { get; set; }
   }
}
