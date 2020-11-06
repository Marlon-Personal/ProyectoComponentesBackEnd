using System;
using Amazon.DynamoDBv2.DataModel;

namespace Entities_POJO
{
    public class Reservation
    {

        [DynamoDBHashKey]
        public string FullNameRentee { get; set; }
        [DynamoDBRangeKey]
        public int DateTime { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

    }
}
