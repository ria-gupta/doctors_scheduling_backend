namespace backendCode.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public string PatientName { get; set; }

        public String DoctorName { get; set; }

        public String DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }

        public int SlotId { get; set; }
        public string SlotName { get; set; }

    }
}
