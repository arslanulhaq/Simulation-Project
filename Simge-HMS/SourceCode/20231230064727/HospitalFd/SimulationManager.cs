// **************************************************************************************************
//		CSimulationManager
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
/// The Simulation Manager manages the (multiple) federation execution(s) and the (multiple instances of) joined federate(s).
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using HMS.Som;

namespace HMS
{
  public class CSimulationManager
  {
    #region Declarations
    // Communication layer related structures
    public CHospitalFd federate; //Application-specific federate 
    // Local data structures
    // TODO: user-defined data structures are declared here
    #endregion //Declarations
    
    #region Constructor
    public CSimulationManager()
    {
      // Initialize the application-specific federate
      federate = new CHospitalFd(this);
      // Initialize the federation execution
      federate.FederationExecution.Name = "HMS";
      federate.FederationExecution.FederateType = "NewFederate";
      federate.FederationExecution.ConnectionSettings = "rti://127.0.0.1";
      // Handle RTI type variation
      initialize();
    }
    #endregion //Constructor
    
    #region Methods
    // Handles naming variation according to HLA specification
    private void initialize()
    {
      switch (federate.RTILibrary)
      {
        case RTILibraryType.HLA13_DMSO: case RTILibraryType.HLA13_Portico: case RTILibraryType.HLA13_OpenRti:
                federate.Som.HospitalOC.Name = "objectRoot.Hospital";
                federate.Som.HospitalOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.HospitalDetailsIC.Name = "interactionRoot.HospitalDetails";
                federate.FederationExecution.FDD = @".\HMS.fed";
        break;
        case RTILibraryType.HLA1516e_Portico: case RTILibraryType.HLA1516e_OpenRti:
                federate.Som.HospitalOC.Name = "HLAobjectRoot.Hospital";
                federate.Som.HospitalOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.HospitalDetailsIC.Name = "HLAinteractionRoot.HospitalDetails";
                federate.FederationExecution.FDD = @".\HMS.xml";
        break;
      }
    }
    #endregion //Methods
  }
}
