﻿namespace BHM.Entities
{
    class SessionDetail
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int SmtpAccountId { get; set; }
        public int SmtpServerId { get; set; }
        public int ProxyServerId { get; set; }
        public int EmailId { get; set; }
        public int Status { get; set; }
    }
}
