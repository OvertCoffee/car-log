using System;

namespace car_log
{
    public class Record
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public int Odometer { get; set; }
        public double Trip { get; set; }
        public double Gallons { get; set; }
        public double Cost { get; set; }
        public string Notes { get; set; }
    }
}