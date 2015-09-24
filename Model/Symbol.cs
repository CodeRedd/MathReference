// Copyright (c) 2015 Culver Ganem-Redd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
