using System;

namespace FinesApp
{
    public class Protocol
    {
        public int ProtocolId { get; set; }
        public int ViolationId { get; set; }
        public string StsNumber { get; set; }
        public DateTime ViolationDate { get; set; }
        public DateTime ViolationTime { get; set; }
        public string ViolationPlace { get; set; }
        public int StatusId { get; set; }

        public Protocol(int protocol_id, string sts_number, DateTime violation_date, DateTime violation_time, string violation_place, int status_id)
        {
            ProtocolId = protocol_id;
            StsNumber = sts_number;
            ViolationDate = violation_date;
            ViolationTime = violation_time;
            ViolationPlace = violation_place;
            StatusId = status_id;
        }
    }
}
