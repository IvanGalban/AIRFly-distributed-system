﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHTChord.Logger
{
    public static class Logger
    {
        public static void Log(string message, string details)
        {
            Console.WriteLine($"{DateTime.Now} {Server.ChordServer.LocalNode} {message} {details}" );
        }
    }
}
