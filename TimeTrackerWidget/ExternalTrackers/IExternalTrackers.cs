using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTrackerWidget.ExternalTrackers
{
    interface IExternalTrackers
    {
        bool AddEntry(DateTime start, DateTime end, string message);
    }
}
