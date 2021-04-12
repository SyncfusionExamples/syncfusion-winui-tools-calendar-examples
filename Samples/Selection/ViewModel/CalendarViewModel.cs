using Syncfusion.UI.Xaml.Calendar;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class CalendarViewModel : NotificationObject
    {
        private CalendarSelectionMode selectionMode = CalendarSelectionMode.Single;
        private SelectionHighlightMode selectionHighlightMode = Syncfusion.UI.Xaml.Calendar.SelectionHighlightMode.Filled;
        private DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
        private int numberOfWeeksInView = 6;
        private SelectionShape selectionShape = SelectionShape.Circle;

        public SelectionShape SelectionShape
        {
            get
            {
                return selectionShape;
            }
            set
            {
                selectionShape = value;
                this.RaisePropertyChanged(nameof(SelectionShape));
            }
        }

        public CalendarSelectionMode SelectionMode
        {
            get
            {
                return selectionMode;
            }
            set
            {
                selectionMode = value;
                this.RaisePropertyChanged(nameof(SelectionMode));
            }
        }

        public SelectionHighlightMode SelectionHighlightMode
        {
            get
            {
                return selectionHighlightMode;
            }
            set
            {
                selectionHighlightMode = value;
                this.RaisePropertyChanged(nameof(SelectionHighlightMode));
            }
        }

        public DayOfWeek FirstDayOfWeek
        {
            get
            {
                return firstDayOfWeek;
            }
            set
            {
                firstDayOfWeek = value;
                this.RaisePropertyChanged(nameof(FirstDayOfWeek));
            }
        }

        public int NumberOfWeeksInView
        {
            get
            {
                return numberOfWeeksInView;
            }
            set
            {
                numberOfWeeksInView = value;
                this.RaisePropertyChanged(nameof(NumberOfWeeksInView));
            }
        }
    }
}
