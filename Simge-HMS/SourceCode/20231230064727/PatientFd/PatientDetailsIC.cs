// **************************************************************************************************
//		CPatientDetailsIC
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
  public class CPatientDetailsIC : HlaInteractionClass
  {
    #region Declarations
    public HlaParameter IdNumber;
    public HlaParameter NotStable;
    public HlaParameter Stable;
    public HlaParameter DiseaseName;
    public HlaParameter PatientName;
    #endregion //Declarations
    
    #region Constructor
    public CPatientDetailsIC() : base()
    {
      // Initialize Class Properties
      Name = "HLAinteractionRoot.PatientDetails";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Parameters
      // IdNumber
      IdNumber = new HlaParameter("IdNumber");
      Parameters.Add(IdNumber);
      // NotStable
      NotStable = new HlaParameter("NotStable");
      Parameters.Add(NotStable);
      // Stable
      Stable = new HlaParameter("Stable");
      Parameters.Add(Stable);
      // DiseaseName
      DiseaseName = new HlaParameter("DiseaseName");
      Parameters.Add(DiseaseName);
      // PatientName
      PatientName = new HlaParameter("PatientName");
      Parameters.Add(PatientName);
    }
    #endregion //Constructor
  }
}
