using System;
using System.Collections.ObjectModel;
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

      #region Initializers
      //populates combo box full of categories
      private void addEquationCategories()
      {

      }

      //conversion between cartesian and cylindrical
      private void addCylindricalCoordinateConversions()
      {

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
