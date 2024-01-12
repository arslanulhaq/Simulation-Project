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
    public HlaAttribute Id;
    public HlaAttribute Condition;
    public HlaAttribute Disease;
    public HlaAttribute Name;
    #endregion //Declarations
    
    #region Constructor
    public CPatientOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Patient";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // Id
      Id = new HlaAttribute("Id", PSKind.PublishSubscribe);
      Attributes.Add(Id);
      // Condition
      Condition = new HlaAttribute("Condition", PSKind.PublishSubscribe);
      Attributes.Add(Condition);
      // Disease
      Disease = new HlaAttribute("Disease", PSKind.PublishSubscribe);
      Attributes.Add(Disease);
      // Name
      Name = new HlaAttribute("Name", PSKind.PublishSubscribe);
      Attributes.Add(Name);
    }
    #endregion //Constructor
  }
}
