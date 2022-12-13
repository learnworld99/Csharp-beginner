using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp2.Inheritance
{
    internal class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }
        public ChangeRequest()
        {

        }

        public ChangeRequest(string title,
            string desc,
            TimeSpan jobLength,
            int originalID)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.JobLength = jobLength;

            this.originalItemID = originalID;
        }
    }
}
