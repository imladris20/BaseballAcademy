using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Interface
{
    /// <summary>
    /// 要能投才是投手
    /// </summary>
    public interface IPitchable
    {
        void Pitch();
    }
}