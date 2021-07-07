namespace SchoolControlSystem.ModelServices.Enrollment
{
    public interface IEnrollment
    {
        void Enroll(string name, string birthdate);
        string message { get; set; }
    }
}
