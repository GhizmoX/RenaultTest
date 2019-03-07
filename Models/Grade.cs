namespace Models
{
    public class Grade
    {
        public long ID { get; set; }
        public long Subject_ID { get; set; }
        public long Student_ID { get; set; }
        public short Score { get; set; }
        public short Partial { get; set; }
    }
}
