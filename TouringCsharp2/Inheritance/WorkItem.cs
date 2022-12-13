using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp2.Inheritance
{
    //internal sealed class WorkItem
    internal class WorkItem
    {
        private static int currentID { get; set; }

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected TimeSpan JobLength { get; set; }
        protected string Description { get; set; }

        public WorkItem()
        {
            this.ID = 0;
            this.Title = "Default Title";
            this.Description = "Default Description";
            this.JobLength = new TimeSpan();
        }

        public WorkItem(
            string title,
            TimeSpan jobLength,
            string description)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.JobLength = jobLength;
            this.Description = Description;

        }

        protected int GetNextID() => ++currentID;

        static WorkItem() => currentID = 0;

        public void Update(string title, TimeSpan jobLength)
        {
            this.Title = title;
            this.JobLength = jobLength;
        }

        public override string ToString() => $"{this.ID} - {this.Title}";
    }
}
