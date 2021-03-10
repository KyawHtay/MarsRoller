using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarsRoverTest.Interfaces
{
    public interface IPosition
    {
        void StartMoving(List<int> maxPoints, string moves);
    }
}