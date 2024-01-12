// **************************************************************************************************
//		FederateSom
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Saturday, 30 December 2023 6:47:27 pm
//		compatible with		: 	RACoN v.0.0.2.5
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// This class is extended from the object model of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using HMS.Som;


namespace HMS.Som
{
  public class FederateSom : Racon.ObjectModel.CObjectModel
  {
    #region Declarations
    #region SOM Declaration
    public HMS.Som.CHospitalOC HospitalOC;
    public HMS.Som.CHospitalDetailsIC HospitalDetailsIC;
    #endregion
    #endregion //Declarations
    
    #region Constructor
    public FederateSom() : base()
    {
      // Construct SOM
      HospitalOC = new HMS.Som.CHospitalOC();
      AddToObjectModel(HospitalOC);
      HospitalDetailsIC = new HMS.Som.CHospitalDetailsIC();
      AddToObjectModel(HospitalDetailsIC);
    }
    #endregion //Constructor
  }
}
