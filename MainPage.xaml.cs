// Copyright (c) 2015 Culver Ganem-Redd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using MathReference.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MathReference.Datatypes;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MathReference
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class MainPage : Page
   {
      private EquationManager _eqnManager;
      
      public MainPage()
      {
         _eqnManager = new EquationManager();
         DataContext = _eqnManager;
         this.InitializeComponent();
      }
   }
}
