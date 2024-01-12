// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Racon
using Racon;
using Racon.RtiLayer;

// Application
using HMS.Som;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace HMS
{
    public class Program
    {
        static public CHospitalFd HospitalFd;
        static public BindingList<CHospitalHlaObject> Hospital;
        static public BindingList<CPatientHlaObject> Patient;
        static void Main(string[] args)
        {
            // Instantiate
            HospitalFd = new CHospitalFd();
            // Initialize the federation execution
            HospitalFd.FederationExecution.Name = "HMS";
            HospitalFd.FederationExecution.FederateType = "FederateHospital";
            HospitalFd.FederationExecution.ConnectionSettings = "rti://127.0.0.1";
            HospitalFd.Som.HospitalOC.Name = "HLAobjectRoot.Hospital";
            HospitalFd.Som.HospitalOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
            HospitalFd.Som.PatientOC.Name = "HLAobjectRoot.Patient";
            HospitalFd.Som.PatientOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
            HospitalFd.Som.HospitalDetailsIC.Name = "HLAinteractionRoot.HospitalDetails";
            HospitalFd.Som.PatientDetailsIC.Name = "HLAinteractionRoot.PatientDetails";
            HospitalFd.FederationExecution.FDD = @".\HMS.xml";

            HospitalFd.StatusMessageChanged += Federate_StatusMessageChanged;
            HospitalFd.LogLevel = LogLevel.ALL;

            // Initialize the federation execution
            Console.WriteLine("HMS Federation Executed");
            // Your setup logic for HospitalFd...

            PrintVersion();

            // Connect to the federation
            HospitalFd.Connect(CallbackModel.EVOKED, HospitalFd.FederationExecution.ConnectionSettings);
            // Create federation execution
            HospitalFd.CreateFederationExecution(HospitalFd.FederationExecution.Name, HospitalFd.FederationExecution.FomModules);
            // Join federation execution
            HospitalFd.JoinFederationExecution(HospitalFd.FederationExecution.FederateName, HospitalFd.FederationExecution.FederateType, HospitalFd.FederationExecution.Name, HospitalFd.FederationExecution.FomModules);

            // Initialize your hospital-specific objects and variables
            Hospital = new BindingList<CHospitalHlaObject>();
            Patient = new BindingList<CPatientHlaObject>();
            // Other initialization logic for your hospital...

            // Declare Capability
            HospitalFd.DeclareCapability();
            do
            {
                HospitalFd.Run();



            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            HospitalFd.FinalizeFederation(HospitalFd.FederationExecution, ResignAction.NO_ACTION);

            // Dumb trace log
            System.IO.StreamWriter file = new System.IO.StreamWriter(@".\TraceLog.txt");
            file.WriteLine(HospitalFd.TraceLog);
            file.Close();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CHospitalFd).StatusMessage);
        }

        private static void PrintVersion()
        {
            Console.WriteLine(
              "***************************************************************************\n"
              + "                        " + "HospitalFdApp v1.0.0" + "\n"
              + "***************************************************************************");
        }

    }

    public partial class CHospitalFd : Racon.CGenericFederate
    {
        //   // Method to handle interactions
        //  if (interaction is CPatientDetailsIC.)
        //     {
        //   // Process the interaction and send a response
        //     string appointmentStatus, availability;

        //        if (appointmentsCount<DefaultLimit)
        //        {
        //        // Book appointment
        //        appointmentsCount++;
        //        appointmentStatus = "Booked";
        //        availability = "Available";
        //         }
        //        else
        //        {
        //            // No more appointments available
        //            appointmentStatus = "Not Booked";
        //            availability = "Not Available";
        //           }

        //     // Send response to the patient
        //     sendAppointmentResponse(interaction.getSource(), appointmentStatus, availability, patient);
        //    }
    }
}
