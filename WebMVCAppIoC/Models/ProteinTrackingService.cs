using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCAppIoC.Models
{
    public class ProteinTrackingService : IProteinTrackingService
    {
        IProteinRepository repository;

        public ProteinTrackingService(IProteinRepository repository)
        {
            this.repository = repository;
        }
        public int Goal
        {
            get { return repository.GetData(new DateTime().Date).Goal; }
            set { repository.SetGoal(new DateTime().Date, value); }
        }
        public int Total
        {
            get { return repository.GetData(new DateTime().Date).Total; }
            set { repository.SetTotal(new DateTime().Date, value); }
        }

        public void AddProtein(int amount)
        {
            Total += amount;
        }
    }
}