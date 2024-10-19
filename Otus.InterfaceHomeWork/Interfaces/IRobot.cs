﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.InterfaceHomeWork.Interfaces
{
    public interface IRobot
    {
        public string GetInfo();
        public List<string> GetComponents();
        public string GetRobotType() => "I am a simple robot.";
    }
}
