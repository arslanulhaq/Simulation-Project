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
    public HlaParameter LimitNumber;
    public HlaParameter NotAvailble;
    public HlaParameter Available;
    public HlaParameter Confirmed;
    #endregion //Declarations
    
    #region Constructor
    public CHospitalDetailsIC() : base()
    {
      // Initialize Class Properties
      Name = "HLAinteractionRoot.HospitalDetails";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Parameters
      // LimitNumber
      LimitNumber = new HlaParameter("LimitNumber");
      Parameters.Add(LimitNumber);
      // NotAvailble
      NotAvailble = new HlaParameter("NotAvailble");
      Parameters.Add(NotAvailble);
      // Available
      Available = new HlaParameter("Available");
      Parameters.Add(Available);
      // Confirmed
      Confirmed = new HlaParameter("Confirmed");
      Parameters.Add(Confirmed);

    }
    #endregion //Constructor
  }
}
