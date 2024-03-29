﻿using OS_Scheduler_Simulator.Entities;
using OS_Scheduler_Simulator.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Contracts
{
    public interface ISchedulingService
    {
        public SchedulingAlgorithmType Type { get; set; }

        Process GetTask();
    }
}
