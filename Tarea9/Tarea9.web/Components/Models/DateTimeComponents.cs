namespace Tarea9.web.Components.Models
{
    public class DateTimeRegistroVivencias
    {
        public int Id { get; set; }

        private DateTime dateTimeRv = DateTime.Now;

        public string DateTimeMethot()
        {
            string datetimeMethot = dateTimeRv.ToString();

            return datetimeMethot;
        }
    }

    public class DateTimeListadoVivencias
    {
        public int Id { get; set; }

        private DateTime dateTimeLv = DateTime.Now;

        public string DateTimeMethot()
        {
            string datetimeMethot = dateTimeLv.ToString();

            return datetimeMethot;
        }
    }
}
