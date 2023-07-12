using DemoHospital.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHospitalConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Patient patient = new Patient();
			
			patient.ID = 5;
			patient.InsuranceNo = 1111111;
			patient.Name = "Muhammet Emin";
			patient.Surname = "Ozturk";
			patient.DateOfBirth = new DateTime(1935,5,5);


			CharityHospital charityHospital = new CharityHospital();

			charityHospital.AddPatient(patient);
			ReadOnlyCollection<Patient> patients = charityHospital.GetPatients();

			DisplayPatients(patients);
			Console.ReadLine();

			charityHospital.DisplayTreatmentChargeExemptPatients();
			Console.ReadLine();

		}

		private static void DisplayPatients(ReadOnlyCollection<Patient> patients)
		{
			foreach (Patient patient in patients)
			{
				Console.WriteLine("Id:" + patient.ID);
				Console.WriteLine("Insurance No:" + patient.InsuranceNo);
				Console.WriteLine("Name:" + patient.Name);
				Console.WriteLine("Surname:" + patient.Surname);
				Console.WriteLine("Date of Birth:" + patient.DateOfBirth);
			}
		}

		
	}
}
