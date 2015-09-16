using MathReference.Datatypes;

namespace MathReference.Model
{
   class Symbol
   {
      public Symbol()
      {
         Type = SymbolType.TEXT;
      }

      public Symbol( string text )
      {
         Type = SymbolType.TEXT;
         DisplayText = text;
      }

      public string DisplayText { get; set; }
      public SymbolType Type { get; set; }
   }
}
