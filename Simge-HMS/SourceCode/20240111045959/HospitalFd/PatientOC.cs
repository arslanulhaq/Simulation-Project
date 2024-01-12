// **************************************************************************************************
//		CPatientOC
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Thursday, 11 January 2024 4:59:59 pm
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
  public class CPatientOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute Disease;
    public HlaAttribute Name;
    public HlaAttribute Condition;
    public HlaAttribute Id;
    #endregion //Declarations
    
    #region Constructor
    public CPatientOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Patient";
      ClassPS = PSKind.Subscribe;
      
      // Create Attributes
      // Disease
      Disease = new HlaAttribute("Disease", PSKind.Subscribe);
      Attributes.Add(Disease);
      // Name
      Name = new HlaAttribute("Name", PSKind.Subscribe);
      Attributes.Add(Name);
      // Condition
      Condition = new HlaAttribute("Condition", PSKind.Subscribe);
      Attributes.Add(Condition);
      // Id
      Id = new HlaAttribute("Id", PSKind.Subscribe);
      Attributes.Add(Id);
    }
    #endregion //Constructor
  }
}
