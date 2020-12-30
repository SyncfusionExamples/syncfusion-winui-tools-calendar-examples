using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockedDates
{
    class CalendarViewModel : NotificationObject
    {
        private DateTimeOffsetCollection blackoutDates = new DateTimeOffsetCollection();
        public DateTimeOffsetCollection BlackoutDates
        {
            get
            {
                return blackoutDates;
            }
            set
            {
                if (blackoutDates != value)
                {
                    blackoutDates = value;
                    this.RaisePropertyChanged(nameof(this.BlackoutDates));
                }
            }
        }
        public CalendarViewModel()
        {
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 17)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 4)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 5)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 9)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 11)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 13)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 14)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 18)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 19)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 26)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 29)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 31)));
            blackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27)));
        }
    }
}
