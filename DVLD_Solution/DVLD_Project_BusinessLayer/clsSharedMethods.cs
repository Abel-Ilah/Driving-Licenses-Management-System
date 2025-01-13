using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public static class clsSharedMethods
    {
        public static Dictionary<string, int> GetGeneralStatistics()
        {
            return clsSettings.GetGeneralStatistics();
        }
    }
}
