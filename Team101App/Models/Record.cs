using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

namespace Team101App.Models
{
    public class Record
    {
        public int RecordId
        {
            get; set;
        }
        public string Time
        {
            get; set;
        }
        public string Location
        {
            get; set;
        }
        public string Purpose
        {
            get; set;
        }
        public string Equipment
        {
            get; set;
        }
    }
}