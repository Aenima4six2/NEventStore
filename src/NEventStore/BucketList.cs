using System.Collections.Generic;
using System.Linq.Expressions;

namespace NEventStore.Persistence.Sql
{
    public class BucketList
    {
        public string BucketId { get; set; }
        public string BucketId2 { get; set; }
        public string BucketId3 { get; set; }
        public string BucketId4 { get; set; }
        public string BucketId5 { get; set; }
        public string BucketId6 { get; set; }
        public string BucketId7 { get; set; }
        public string BucketId8 { get; set; }
        public string BucketId9 { get; set; }
        public string BucketId10 { get; set; }

        public IList<string> ToList()
        {
            return new List<string>
            {
                this.BucketId,
                this.BucketId2,
                this.BucketId3,
                this.BucketId4,
                this.BucketId5,
                this.BucketId6,
                this.BucketId7,
                this.BucketId8,
                this.BucketId9,
                this.BucketId10
            };
        }
    }
}