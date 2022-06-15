using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseUpdater
{
    // This class is used to store information of a converted file (id and UUID).
    internal class ConvertedFileInfo
    {
        public long id { get; set; }
        public string UUID { get; set; }

        public ConvertedFileInfo(long id, string UUID)
        {
            this.id = id;
            this.UUID = UUID;
        }
    }
}
