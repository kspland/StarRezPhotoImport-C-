using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPhotoImport.Model
{
    class Entry
    {
        public string LSUID { get; set; } // LSU Resident ID, use string to easily manipulate

        public int EntryID { get; set; } // EntryID is StarRez Primary Key
    }
}
