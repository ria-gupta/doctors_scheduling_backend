namespace backendCode.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public string PatientName { get; set; }

        public String DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string SlotStartTime { get; set; }

        public string SlotEndTime { get; set; }

    }
}
