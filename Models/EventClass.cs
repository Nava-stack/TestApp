using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Helpers;


namespace TestApp.Models
{
    internal class EventClass : Com
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string EventType { get; set; }
        public bool IsIndoor { get; set; }
        public int MaxParticipants { get; set; }

        public DataGridView dgvEvents { get; set; }

        public void AddEvent()
        {
            string sql = $"INSERT INTO Events (EventName, EventDate, Location, EventType, IsIndoor, MaxParticipants) " +
                         $"VALUES ('{EventName}', '{EventDate}', '{Location}', '{EventType}', '{(IsIndoor ? 1 : 0)}', {MaxParticipants})";
            if (executeQuery(sql, FunctionType.insert))
                GetAllEvents();
        }

        public void UpdateEvent()
        {
            string sql = $"UPDATE Events SET EventName='{EventName}', EventDate='{EventDate}', Location='{Location}', " +
                         $"EventType='{EventType}', IsIndoor={(IsIndoor ? 1 : 0)}, MaxParticipants={MaxParticipants} WHERE EventID={EventID}";
            if (executeQuery(sql, FunctionType.update))
                GetAllEvents();
        }

        public void DeleteEvent()
        {
            string sql = $"DELETE FROM Events WHERE EventID={EventID}";
            if (executeQuery(sql, FunctionType.delete))
                GetAllEvents();
        }

        public void GetAllEvents()
        {
            string sql = "SELECT * FROM Events";
            LoadDataInGridView(sql, dgvEvents);
        }

    }
}
