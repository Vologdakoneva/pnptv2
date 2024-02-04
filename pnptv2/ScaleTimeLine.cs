using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraScheduler;

namespace pnptv
{
    class ScaleTimeLine : TimeScaleHour
    {
            public ScaleTimeLine() { }
        public TimeInterval StartEnd { get; set; }

        public override bool IsDateVisible(DateTime date)
        {
            if (date.Hour >= StartEnd.Start.Hour && date.Hour <= StartEnd.End.Hour)
                    return true;
                else return false;
        }
    }
}
