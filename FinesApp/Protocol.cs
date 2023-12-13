using System;

namespace FinesApp
{
    public class Protocol
    {
        public int ProtocolId { get; set; }
        public int ViolationId { get; set; }
        public String StsNumber { get; set; }
        public String ViolationDate { get; set; }
        public String ViolationTime { get; set; }
        public String ViolationPlace { get; set; }
        public int StatusId { get; set; }

        public Protocol(int protocol_id, int violation_id, String sts_number, String violation_date, String violation_time, String violation_place, int status_id)
        {
            ProtocolId = protocol_id;
            ViolationId = violation_id;
            StsNumber = sts_number;
            ViolationDate = violation_date;
            ViolationTime = violation_time;
            ViolationPlace = violation_place;
            StatusId = status_id;
        }
    }
}
