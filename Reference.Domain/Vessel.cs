using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Domain
{
    public class Vessel
    {
        public virtual int BoatId { get; set; }
        public virtual String IsCurrent { get; set; }
        public virtual String Name { get; set; }
        public virtual String RegistNo { get; set; }
        public virtual String GearId { get; set; }
        public virtual float Grt { get; set; }
        public virtual float Loa { get; set; }
        public virtual String FlagId { get; set; }
        public virtual String FlagRgId { get; set; }
        public virtual String FlagSpcId { get; set; }
        public virtual String FlagOrigId { get; set; }
        public virtual int CompanyId { get; set; }
        public virtual String Call { get; set; }
        public virtual String CategoryId { get; set; }
        public virtual int PBoatId { get; set; }
        public virtual int CBoatId { get; set; }
        public virtual int FfaVid { get; set; }
        public virtual DateTime VessDate { get; set; }
        public virtual String Notes { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual String EnteredBy { get; set; }
        public virtual long Uvi { get; set; }
    }
}
