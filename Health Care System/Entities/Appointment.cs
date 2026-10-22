using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Care_System.Entities
{
    internal class Appointment
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
