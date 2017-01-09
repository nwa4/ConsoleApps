using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCAppIoC.Models
{
    public class DebugProteinRepository : IProteinRepository
    {
        private static ProteinData data = new ProteinData();
        private readonly string dataSource;

        public DebugProteinRepository(string dataSource)
        {
            this.dataSource = dataSource;
        }

        //public ProteinRepository()
        //{

        //}
        public ProteinData GetData(DateTime date)
        {
            return data;
        }


        public void SetGoal(DateTime date, int value)
        {
            data.Goal = value;
        }

        public void SetTotal(DateTime date, int value)
        {
            data.Total = value;
        }
    }
}