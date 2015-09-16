namespace MathReference.Model
{
   class Symbol
   {
      public Symbol()
      {

      }

      public Symbol( string text )
      {
         DisplayText = text;
      }

      public string DisplayText { get; set; }
   }
}
