using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackBus
{
    public class MasterDetailBusMenuItem
    {
        public MasterDetailBusMenuItem()
        {
            TargetType = typeof(MasterDetailBusDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
