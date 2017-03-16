using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churchy.Model
{
    public class ChurchNotice
    {
        public int Id { get; set; }
        public int NoticeId { get; set; }
        public Notice Notice { get; set; }
        public int ChurchId { get;set; }
        public Church Church { get; set; }
    }
}
