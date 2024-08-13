
using System;

namespace MakePlus.Core
{
    public class BaseEntity
    {
        public int ID_Info { get; set; }
        public int crationUser {  get; set; }
        public DateTime creationDate { get; set; }
        public int? userMod { get; set; }
        public DateTime? modifyDate { get; set; }
        public int? userDelete { get; set; }
        public DateTime? deleteTime { get; set; }
        public bool deleted { get; set; }
    }
}
