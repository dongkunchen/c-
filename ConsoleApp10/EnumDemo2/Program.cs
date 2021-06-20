using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo2
{
    public enum QQState
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            QQState onLine = QQState.OnLine;
        }
    }
}
