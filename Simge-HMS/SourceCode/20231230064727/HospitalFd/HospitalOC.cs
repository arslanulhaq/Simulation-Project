// **************************************************************************************************
//		CHospitalOC
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
  public class CHospitalOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute Limit;
    public HlaAttribute Status;
    public HlaAttribute Appointment;
    #endregion //Declarations
    
    #region Constructor
    public CHospitalOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Hospital";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // Limit
      Limit = new HlaAttribute("Limit", PSKind.PublishSubscribe);
      Attributes.Add(Limit);
      // Status
      Status = new HlaAttribute("Status", PSKind.PublishSubscribe);
      Attributes.Add(Status);
      // Appointment
      Appointment = new HlaAttribute("Appointment", PSKind.PublishSubscribe);
      Attributes.Add(Appointment);
    }
    #endregion //Constructor
  }
}
