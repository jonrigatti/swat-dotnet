using System;

namespace backend
{
    public class Submittals
    {
        public string Id { get; set; }
        public string submittalID { get; set; }
        public string description { get; set; }
        public string owner { get; set; }
        public DateTime receivedDate { get; set; }
        public DateTime needDate { get; set; }
        public DateTime dispositionDate { get; set; }
    }
}