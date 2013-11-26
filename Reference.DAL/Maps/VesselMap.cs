using FluentNHibernate.Mapping;
using Reference.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.DAL.Maps
{
    public class VesselMap : ClassMap<Vessel>
    {
        public VesselMap()
        {
            Schema("ves");
            Table("vessel");
            Id(x => x.BoatId).Column("boat_id");
            Map(x => x.IsCurrent,"is_current");
            Map(x => x.Name).Column("vesselname");
            Map(x => x.RegistNo).Column("regist_no");
            Map(x => x.GearId).Column("gr_id");
            Map(x => x.Grt).Column("grt");
            Map(x => x.Loa).Column("loa");
            Map(x => x.FlagId).Column("flag_id");
            Map(x => x.FlagRgId).Column("flag_rg_id");
            Map(x => x.FlagSpcId).Column("flag_spc_id");
            Map(x => x.FlagOrigId).Column("flag_orig_id");
            Map(x => x.CompanyId).Column("company_id");
            Map(x => x.Call).Column("call");
            Map(x => x.CategoryId).Column("category_id");
            Map(x => x.PBoatId).Column("p_boat_id");
            Map(x => x.CBoatId).Column("c_boat_id");
            Map(x => x.FfaVid).Column("ffa_vid");
            Map(x => x.VessDate).Column("vessdate");
            Map(x => x.Notes).Column("notes");
            Map(x => x.StartDate).Column("start_date");
            Map(x => x.EndDate).Column("end_date");
            Map(x => x.EnteredBy).Column("enteredby");
            Map(x => x.Uvi).Column("uvi");


        }
    }
}
