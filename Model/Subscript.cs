// Copyright (c) 2015 Culver Ganem-Redd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
