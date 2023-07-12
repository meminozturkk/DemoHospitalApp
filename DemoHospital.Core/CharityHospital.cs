using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHospital.Core
{
	public class CharityHospital : Hospital
	{
		public void DisplayTreatmentChargeExemptPatients()
		{

			ReadOnlyCollection<Patient> patients = base.GetPatients();

			foreach (Patient patient in patients)
			{
				TimeSpan age = DateTime.Now.Subtract(patient.DateOfBirth);
				if ((int)(age.TotalDays/365) > 65 )
				{
                    Console.WriteLine("This patient is older than 65: " + patient.Name);
                }
			}
		}
	}
}
