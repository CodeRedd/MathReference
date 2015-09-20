using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MathReference.Datatypes;
using MathReference.Model;


namespace MathReference.ViewModel
{
   class EquationManager
   {
      public EquationManager()
      {
         EquationList = new ObservableCollection<Equation>();
         CategoryList = new ObservableCollection<string>();
         addEquationCategories();

         addCylindricalCoordinateConversions();
         addSphericalCoordinateConversions();
         addTrigIdentities();
         addLinearAlgebra();
         addCalculusLaws();
         addMathTools();
         addSeriesExpansions();
         addQuantumBasics();
      }

      public ObservableCollection<Equation> EquationList { get; set; }
      public ObservableCollection<string> CategoryList { get; set; }
      public int SelectedCategory { get; set; }

      #region Initializers
      //populates combo box full of categories
      private void addEquationCategories()
      {
         CategoryList.Add( "Cylindrical Coordinates" );
         CategoryList.Add( "Spherical Coordinates" );
         CategoryList.Add( "Trigonometric Identities" );
         CategoryList.Add( "Linear Algebra" );
         CategoryList.Add( "Calculus Laws" );
         CategoryList.Add( "Mathematical Tools" );
         CategoryList.Add( "Series Expansions" );
         CategoryList.Add( "Quantum Basics" );
         SelectedCategory = 0;
      }

      //conversion between cartesian and cylindrical
      private void addCylindricalCoordinateConversions()
      {
         ObservableCollection<Symbol> temp = new ObservableCollection<Symbol>();
         temp.Add( new Symbol( MathStrings.INTEGRAL + " " ) );
         temp.Add( new Fraction( new ObservableCollection<Symbol>() { new Symbol( "x" ) }, new ObservableCollection<Symbol>() { new Symbol( "2" ) } ) );
         temp.Add( new Symbol( "y" ) );
         temp.Add( new Superscript( new ObservableCollection<Symbol>() { new Symbol( "3" ) } ) );
         temp.Add( new Symbol( MathStrings.EPSILON + " " ) );
         temp.Add( new Subscript( new ObservableCollection<Symbol>() { new Symbol( "0" ) } ) );
         EquationList.Add( new Equation( "Test Equation",
                                         temp,
                                         new List<string>() { "Cylindrical Coordinates" } ) );
      }

      //conversion between cartesian and spherical
      private void addSphericalCoordinateConversions()
      {

      }

      //trigonometric identities
      private void addTrigIdentities()
      {

      }

      //matrix math tools (normalization, determinant, etc)
      private void addLinearAlgebra()
      {

      }

      //calculus-related laws (divergence, curl, divergence theorem, green's theorem, etc)
      private void addCalculusLaws()
      {

      }

      //Mathematical tools (fourier transform, gamma functions, beta functions, etc)
      private void addMathTools()
      {

      }

      //Polynomial expansions (legendre polynomials, hermitian polynomials, etc)
      private void addSeriesExpansions()
      {

      }

      //Basics of quantum like waveforms and hamiltonians
      private void addQuantumBasics()
      {

      }

      #endregion
   }
}
