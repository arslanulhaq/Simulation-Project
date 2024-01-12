// **************************************************************************************************
//		CPatientDetailsIC
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
  public class CPatientDetailsIC : HlaInteractionClass
  {
    #region Declarations
    public HlaParameter PatientName;
    public HlaParameter DiseaseName;
    public HlaParameter Stable;
    public HlaParameter NotStable;
    public HlaParameter IdNumber;
    #endregion //Declarations
    
    #region Constructor
    public CPatientDetailsIC() : base()
    {
      // Initialize Class Properties
      Name = "HLAinteractionRoot.PatientDetails";
      ClassPS = PSKind.Subscribe;
      
      // Create Parameters
      // PatientName
      PatientName = new HlaParameter("PatientName");
      Parameters.Add(PatientName);
      // DiseaseName
      DiseaseName = new HlaParameter("DiseaseName");
      Parameters.Add(DiseaseName);
      // Stable
      Stable = new HlaParameter("Stable");
      Parameters.Add(Stable);
      // NotStable
      NotStable = new HlaParameter("NotStable");
      Parameters.Add(NotStable);
      // IdNumber
      IdNumber = new HlaParameter("IdNumber");
      Parameters.Add(IdNumber);
    }
    #endregion //Constructor
  }
}
