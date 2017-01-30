using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    [DataContract(Namespace = "http://example.com")]
    public class SICLookup : ISICLookup
    {
        [DataMember]
        public string Division { get; set; }
        [DataMember]
        public int MajorGroup { get; set; }
        [DataMember]
        public int IndustryGroup { get; set; }
        [DataMember]
        [Key]
        public int SIC { get; set; }
        [DataMember]
        public string Description { get; set; }

        public SICLookup() { }

        public SICLookup(ISICLookup siclookup)
        {
            this.Description = siclookup.Description;
            this.Division = siclookup.Division;
            this.IndustryGroup = siclookup.IndustryGroup;
            this.MajorGroup = siclookup.MajorGroup;
            this.SIC = siclookup.SIC;
        }
    }
}
