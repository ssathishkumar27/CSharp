using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{/// <summary>
/// stores vaccine details
/// object(int,Dosage,DateTime)
/// </summary>
    public class VaccineDetails
    {
        public VaccineType Vaccine { get; set; }
        public int Dosage { get; set; }
        public DateTime VaccinatedDate { get; set; }
        public VaccineDetails(int vaccine, DateTime date, int dose)
        {
            Vaccine = (VaccineType)vaccine;
            VaccinatedDate = date;
            Dosage = dose;
        }

    }
    /// <summary>
    ///     To choose vaccine types(Covaxin,Covishield,Sputnic)
    /// </summary>
    public enum VaccineType
    {
        Covaxin = 1, Covishield, Sputnic
    }
}