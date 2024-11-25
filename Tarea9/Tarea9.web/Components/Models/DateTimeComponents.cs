namespace Tarea9.web.Components.Models
{
    public class DateTimeRegistroVivencias
    {
        public int Id { get; set; }

        private DateTime dateTimeRv;

        public DateTimeRegistroVivencias()
        {
            dateTimeRv = DateTime.Now;
        }

        public void UpdateDateTime()
        {
            dateTimeRv = DateTime.Now;
        }

        public string DateTimeMethot()
        {
            return dateTimeRv.ToString();
        }
    }

    public class DateTimeListadoVivencias
    {
        public int Id { get; set; }

        private DateTime dateTimeLv;

        public DateTimeListadoVivencias()
        {
            dateTimeLv = DateTime.Now;
        }

        public void UpdateDateTime()
        {
            dateTimeLv = DateTime.Now;
        }

        public string DateTimeMethot()
        {
            return dateTimeLv.ToString();
        }

    }
}
