using System.Collections.Generic;

namespace calendar.Repository
{
	public class CalendarRepository : ICalendarRepository
	{
		public IEnumerable<CalendarItem> GetAllItems()
		{
			IEnumerable<CalendarItem> results = new CalendarItem[] { 
				new CalendarItem { 
					Summary = "Test summary",
					Title = "Test Title",
					Type = "test type"
				},
				new CalendarItem { 
					Summary = "Test summary 2",
					Title = "Test Title 2",
					Type = "test type 2"
				},
				new CalendarItem { 
					Summary = "Test summary 3",
					Title = "Test Title 3",
					Type = "test type 3"
				}
			};

			return results;
		}

		public CalendarItem GetItem(string id)
		{
			CalendarItem results = new CalendarItem { 
				Summary = "Test summary",
				Title = "Test Title",
				Type = "test type"
			};

			return results;
		}
	}
}