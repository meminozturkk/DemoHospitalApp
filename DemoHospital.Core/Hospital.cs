using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHospital.Core
{
	public class Hospital
	{
		protected List<Patient> patients;
		public string Name { get; set; }

		public Hospital()
		{
			patients = new List<Patient>();

		}

		public void AddPatient(Patient patient)
		{
			patients.Add(patient);
		}

		public ReadOnlyCollection<Patient> GetPatients()
		{
			return patients.AsReadOnly();
		}

	}
}
