// Structure of StateTriggerBase implementation based off of work by Morton Nielsen
// License File can be found at https://github.com/dotMorten/WindowsStateTriggers/blob/master/LICENSE
// Copyright (c) Morten Nielsen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using MathReference.Datatypes;
using Windows.UI.Xaml;

namespace MathReference.Triggers
{
   class IsSymbolTypeTrigger : StateTriggerBase
   {
      public SymbolType CurrentType
      {
         get { return (SymbolType)GetValue( SymbolTypeProperty ); }
         set { SetValue( SymbolTypeProperty, value ); }
      }

      public static readonly DependencyProperty SymbolTypeProperty =
        DependencyProperty.Register("SymbolType", typeof(SymbolType), typeof(IsSymbolTypeTrigger),
        new PropertyMetadata(SymbolType.TEXT, OnSymbolTypePropertyChanged));

      private static void OnSymbolTypePropertyChanged( DependencyObject d, DependencyPropertyChangedEventArgs e )
      {
         var obj = (IsSymbolTypeTrigger)d;
         var val = (SymbolType)e.NewValue;
         obj.IsActive = val == obj.TargetType;
      }

      public SymbolType TargetType
      {
         get { return (SymbolType)GetValue( TargetTypeProperty ); }
         set { SetValue( TargetTypeProperty, value ); }
      }

      public static readonly DependencyProperty TargetTypeProperty =
        DependencyProperty.Register("TargetType", typeof(SymbolType), typeof(IsSymbolTypeTrigger),
        new PropertyMetadata(SymbolType.TEXT, OnTargetTypePropertyChanged));

      private static void OnTargetTypePropertyChanged( DependencyObject d, DependencyPropertyChangedEventArgs e )
      {
         var obj = (IsSymbolTypeTrigger)d;
         var val = (SymbolType)e.NewValue;
         obj.IsActive = val == obj.CurrentType;
      }

      #region ITriggerValue

      private bool m_IsActive;

      /// <summary>
      /// Gets a value indicating whether this trigger is active.
      /// </summary>
      /// <value><c>true</c> if this trigger is active; otherwise, <c>false</c>.</value>
      public bool IsActive
      {
         get { return m_IsActive; }
         private set
         {
            if ( m_IsActive != value )
            {
               m_IsActive = value;
               base.SetActive( value );
               if ( IsActiveChanged != null )
                  IsActiveChanged( this, EventArgs.Empty );
            }
         }
      }

      /// <summary>
      /// Occurs when the <see cref="IsActive" /> property has changed.
      /// </summary>
      public event EventHandler IsActiveChanged;

      #endregion ITriggerValue
   }
}
