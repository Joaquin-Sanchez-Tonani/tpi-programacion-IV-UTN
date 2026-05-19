namespace Domain.Entity
{
    public class Schedule
    {
        public int Id { get; set; }

        public Day DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public Guid Id_Class { get; set; }

        public bool IsActive { get; set; } = true;

        public Class? Class { get; set; }
    }

    public enum Day
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }
}