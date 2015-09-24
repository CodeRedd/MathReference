// Copyright (c) 2015 Culver Ganem-Redd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
