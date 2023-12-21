using System;

namespace program_connection
{
    internal class DB
    {
        public DB(string v1, string v2, string v3, string v4)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
        }

        public string V1 { get; }
        public string V2 { get; }

        internal void connect()
        {
            throw new NotImplementedException();
        }

        public string V3 { get; }
        public string V4 { get; }
    }
}