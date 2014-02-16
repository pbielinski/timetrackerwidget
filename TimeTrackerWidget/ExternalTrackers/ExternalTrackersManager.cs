using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTrackerWidget.Utils;

namespace TimeTrackerWidget.ExternalTrackers
{
    class ExternalTrackersManager
    {
        private IList<IExternalTrackers> trackers = new List<IExternalTrackers>();

        public static ExternalTrackersManager Instance
        {
            get
            {
                return SingletonGenericProvider<ExternalTrackersManager>.Instance;
            }
        }

        public ExternalTrackersManager()
        {
            this.LoadTrackers();
        }

        private void LoadTrackers()
        {
            IEnumerable<Type> trackersTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(IExternalTrackers).IsAssignableFrom(p));
            foreach(Type t in trackersTypes)
            {
                IExternalTrackers et = (IExternalTrackers)Activator.CreateInstance(t);
                trackers.Add(et);
            }
        }
    }
}
