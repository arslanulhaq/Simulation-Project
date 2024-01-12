// **************************************************************************************************
//		CHospitalDetailsIC
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
  public class CHospitalDetailsIC : HlaInteractionClass
  {
    #region Declarations
    public HlaParameter Confirmed;
    public HlaParameter Available;
    public HlaParameter NotAvailable;
    public HlaParameter LimitNumber;
    #endregion //Declarations
    
    #region Constructor
    public CHospitalDetailsIC() : base()
    {
      // Initialize Class Properties
      Name = "HLAinteractionRoot.HospitalDetails";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Parameters
      // Confirmed
      Confirmed = new HlaParameter("Confirmed");
      Parameters.Add(Confirmed);
      // Available
      Available = new HlaParameter("Available");
      Parameters.Add(Available);
      // NotAvailable
      NotAvailable = new HlaParameter("NotAvailable");
      Parameters.Add(NotAvailable);
      // LimitNumber
      LimitNumber = new HlaParameter("LimitNumber");
      Parameters.Add(LimitNumber);
    }
    #endregion //Constructor
  }
}
