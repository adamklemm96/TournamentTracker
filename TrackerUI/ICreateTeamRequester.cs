﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Models;

namespace TrackerUI
{
    public interface ICreateTeamRequester
    {
        void TeamComplete(TeamModel model);
    }
}
