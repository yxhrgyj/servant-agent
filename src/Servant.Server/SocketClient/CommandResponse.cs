﻿using System;

namespace Servant.Server.SocketClient
{
    public class CommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Guid Guid { get; set; }

        public CommandResponse(Guid guid)
        {
            Guid = guid;
        }
    }
}