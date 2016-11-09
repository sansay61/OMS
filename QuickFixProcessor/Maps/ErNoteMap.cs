using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using QuickFixProcessor.Models; 

namespace QuickFixProcessor.Maps {
    
    
    public class ErNoteMap : ClassMap<ErNote> {
        
        public ErNoteMap() {
			Table("ER_NOTES");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Erid).Column("ERID").Not.Nullable().Length(22);
			Map(x => x.Notetype).Column("NOTETYPE").Length(1);
			Map(x => x.Notelabel).Column("NOTELABEL").Length(255);
            Map(x => x.Notetext).Column("NOTETEXT").Length(255);
			Map(x => x.Noteno).Column("NOTENO").Length(22);
        }
    }
}
