﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceAnalysis
{
    public class TraceRunMain : TraceRun
    {
        public TraceRunMain(DateTime occurredAt, string content)
            : base(occurredAt, content)
        {
        }
    }
}
