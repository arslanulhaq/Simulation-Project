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

    //public class CPatientDetailsIC : HlaInteractionClass
    //{
    //    public int IdNumber { get; set; }
    //    public string PatientName { get; set; }
    //    public string DiseaseName { get; set; }
    //    public string Condition { get; set; }
    //}



    //public class PatientFd : HLAobjectRoot
    //{ 
    //    // Method to gather patient information from the user and send it to HospitalFd
    //    public void GatherAndSendPatientInfo()
    //    {
    //        Console.WriteLine("Enter patient information:");
    //        Console.Write("Patient ID: ");
    //        int idNumber = int.Parse(Console.ReadLine());

    //        Console.Write("Patient Name: ");
    //        string patientName = Console.ReadLine();

    //        Console.Write("Disease Name: ");
    //        string diseaseName = Console.ReadLine();

    //        Console.Write("Condition: ");
    //        string condition = Console.ReadLine();

    //        // Create an instance of PatientDetails
    //        PatientDetails patientDetails = new PatientDetails
    //        {
    //            IdNumber = idNumber,
    //            PatientName = patientName,
    //            DiseaseName = diseaseName,
    //            Condition = condition
    //        };

    //        // Send the patient details to HospitalFd
    //        sendInteraction(patientDetails);
    //    }


    //}

    

    public class Program
    {
        static public CPatientFd PatientFd;
        static public BindingList<CHospitalHlaObject> Hospital;
        static public BindingList<CPatientHlaObject> Patient;
        static void Main(string[] args)
        {
            // Instantiate
            CSimulationManager manager = new CSimulationManager();
            PatientFd = manager.federate;
            //PatientFd = new CPatientFd();
            PatientFd.StatusMessageChanged += Federate_StatusMessageChanged;
            PatientFd.LogLevel = LogLevel.ALL;

            // Initialize the federation execution
            Console.WriteLine("HMS Federation Executed");
            // Your setup logic for HospitalFd...

            PrintVersion();

            // Connect to the federation
            PatientFd.Connect(CallbackModel.EVOKED, PatientFd.FederationExecution.ConnectionSettings);
            // Create federation execution
            PatientFd.CreateFederationExecution(PatientFd.FederationExecution.Name, PatientFd.FederationExecution.FomModules);
            // Join federation execution
            PatientFd.JoinFederationExecution(PatientFd.FederationExecution.FederateName, PatientFd.FederationExecution.FederateType, PatientFd.FederationExecution.Name, PatientFd.FederationExecution.FomModules);

            // Initialize objects and variables
            Patient = new BindingList<CPatientHlaObject>();
            Hospital = new BindingList<CHospitalHlaObject>();

            // Declare Capability
            PatientFd.DeclareCapability();

            //PatientFd.InitializeFederation(PatientFd.FederationExecution);

            do
            {
                PatientFd.Run();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            PatientFd.FinalizeFederation(PatientFd.FederationExecution, ResignAction.NO_ACTION);

            // Dumb trace log
            System.IO.StreamWriter file = new System.IO.StreamWriter(@".\TraceLog.txt");
            file.WriteLine(PatientFd.TraceLog);
            file.Close();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CPatientFd).StatusMessage);
        }

        private static void PrintVersion()
        {
            Console.WriteLine(
              "***************************************************************************\n"
              + "                        " + "PatientFdApp v1.0.0" + "\n"
              + "***************************************************************************");
        }

    }

}

