﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHPS_DCZM_Interface.Helpers
{
    public static class CommandHelper
    {
        public const string GetSettings = "GS";
        public const string EraseMemory = "EM";
        public const string SetSettings = "SS";
        public const string DownloadMemory = "GD";
        public const string OperationAccepted = "OK";
        public const string OperationFailed = "OF";
        public const string OperationExecuted = "OS";
        public const string BootLoader = "BL";
    }

    enum DEV_TYPE
    {
        ZM = 0,
        DC = 1
    }
}
