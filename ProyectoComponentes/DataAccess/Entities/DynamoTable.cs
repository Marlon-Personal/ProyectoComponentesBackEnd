using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    class DynamoTable
    {
        public string PrimaryKey { get; set; }
        public string HashKey { get; set; }
        public string RangeKey { get; set; }
    }
}
