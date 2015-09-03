namespace MathReference.Model
{
   class Symbol
   {
      public Symbol()
      {

      }

      public Symbol( string characterCode )
      {
         CharacterCode = characterCode;
      }
      #region Properties

      public string CharacterCode { get; set; }

      #endregion
   }
}
