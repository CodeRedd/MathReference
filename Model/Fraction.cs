// Copyright (c) 2015 Culver Ganem-Redd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;
using MathReference.Datatypes;

namespace MathReference.Model
{
   class Fraction : Symbol
   {
      public Fraction( ObservableCollection<Symbol> num, ObservableCollection<Symbol> den )
      {
         Type = SymbolType.FRACTION;
         Numerator = num;
         Denominator = num;
      }

      public ObservableCollection<Symbol> Numerator { get; set; }
      public ObservableCollection<Symbol> Denominator { get; set; }
   }
}
