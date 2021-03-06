﻿using System.Net.Sockets;
using System.Diagnostics;

namespace P4FLauncher
{
    public class PlayerInfo
    {
        public string version;
        public long userId;
        public long exIp, exPort;
        public long inIp, inPort;
        public long nat = 0;
        public long loc;
        public long slot;
        public long stat;
        public long cntx;
        public bool isServer;
        public GameInfo game;
        public NetworkStream ns;
        public Profile profile;
        public Stopwatch timeout;
    }
}
