using Syncfusion.UI.Xaml.Calendar;
using Syncfusion.UI.Xaml.Core;
using System;

namespace Selection
{
    class CalendarViewModel : NotificationObject
    {
        private CalendarSelectionMode selectionMode =  CalendarSelectionMode.Single;
        private CalendarItemHighlightMode todayHighlightMode = CalendarItemHighlightMode.FilledRectangle;
        private CalendarItemHighlightMode selectionHighlightMode = CalendarItemHighlightMode.Rectangle;
        private DayOfWeek firstDayOfWeek =  DayOfWeek.Sunday;
        private int numberOfWeeksInView =  6;

        

        public CalendarItemHighlightMode TodayHighlightMode
        {
            get
            {
                return todayHighlightMode;
            }
            set
            {
                todayHighlightMode = value;
                this.RaisePropertyChanged(nameof(TodayHighlightMode));
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

        public CalendarItemHighlightMode SelectionHighlightMode
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
