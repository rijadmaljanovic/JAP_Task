﻿using JAP_Management.Core.Entities;
using JAP_Management.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP_Management.Repositories.Repositories.Ranks
{
    public interface IRankRepository
    {
        List<Rank> GetRanks();
    }
}
