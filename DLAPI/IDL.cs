﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlApi
{
    public interface IDL
    {
        double GetTemparture(int day);
        double GetWindDirection(int day);
    }
}
