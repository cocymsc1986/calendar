using System.Collections.Generic;

namespace calendar.Services
{
	public interface ICalendarService {
		IEnumerable<CalendarItem> GetAllItems();
		CalendarItem GetItem(string id);
	}
}