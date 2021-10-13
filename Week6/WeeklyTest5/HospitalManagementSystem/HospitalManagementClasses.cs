using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class Patient
    {
        public string name { get; set; }
        public string IDnum { get; set; }
        public int phonenumber { get; set; }
        public string bloodtype { get; set; }

        public List<Patientvisit> Patientvisitlist = new List<Patientvisit>();

        internal class Patientvisit
        {
            public string detailedReport { get; set; }
            public DateTime checkindate { get; set; }
            public DateTime checkoutdate { get; set; }
        }
    }

    class HospitalManagement
    {
        public List<Patient> PatientList = new List<Patient>();
        bool repeatedPatient;
        int patientindex;
        public void PatientRegistration()
        {
            repeatedPatient = false;
            Console.WriteLine("What is your name?");
            string Input1 = Console.ReadLine();
            Console.WriteLine("What is your ID number?");
            string Input2 = Console.ReadLine();
            foreach (Patient patient in PatientList)
            {
                if ((patient.name == Input1) && (patient.IDnum == Input2))
                {
                    repeatedPatient = true;
                    patientindex = PatientList.IndexOf(patient);
                    break;
                }
            }
            if(repeatedPatient == false)
            {
                Console.WriteLine("What is your phone number?");
                int Input3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your blood type?");
                string Input4 = Console.ReadLine();
                Patient newpatient = new Patient();
                newpatient.name = Input1;
                newpatient.IDnum = Input2;
                newpatient.phonenumber = Input3;
                newpatient.bloodtype = Input4;
                PatientList.Add(newpatient);
                
            }
            if(repeatedPatient == true)
            {
                Patient.Patientvisit PV = new Patient.Patientvisit();
                DateTime timeNow = new DateTime();
                timeNow = DateTime.Now;
                PV.checkindate = timeNow;
                PatientList[patientindex].Patientvisitlist.Add(PV);
            }    

        }

        class OutPatientDepartment
        {

        }

        class EmergencyWard
        {

        }

        class ClinicalOperation
        {

        }

        class SpecialistRecommendation
        {

        }
    }

}
