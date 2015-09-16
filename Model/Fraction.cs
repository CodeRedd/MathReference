using System.Collections.ObjectModel;

namespace MathReference.Model
{
   class Fraction : Symbol
   {
      public Fraction( ObservableCollection<Symbol> num, ObservableCollection<Symbol> den )
      {
         Numerator = num;
         Denominator = num;
      }

      public ObservableCollection<Symbol> Numerator { get; set; }
      public ObservableCollection<Symbol> Denominator { get; set; }
   }
}
