using System.Collections.ObjectModel;


namespace MathReference.Model
{
   class Superscript : Symbol
   {
      public Superscript( ObservableCollection<Symbol> content )
      {
         Contents = content;
      }

      public ObservableCollection<Symbol> Contents { get; set; }
   }
}
