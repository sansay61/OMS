using System;
using System.Text;
using System.Collections.Generic;


namespace QuickFixProcessor.Models {
    
    public class ErNote {
        public virtual int Id { get; set; }
        public virtual int Erid { get; set; }
        public virtual string Notetype { get; set; }
        public virtual string Notelabel { get; set; }
        public virtual string Notetext { get; set; }
        public virtual int? Noteno { get; set; }
    }
}
