﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07_MilitaryElite
{
    public interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
