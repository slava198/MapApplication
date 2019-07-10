using System;

namespace MapApplication.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int BankID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public Currency USD { get; set; }
        public Currency EUR { get; set; }
        public Currency RUR { get; set; }


        public override string ToString()
        {
            return String.Format($"{Date.ToShortDateString()} {Time} - USD{USD.Buy}/{USD.Sell} EUR{EUR.Buy}/{EUR.Sell} RUR{RUR.Buy}/{RUR.Sell}");
        }
    }
}
