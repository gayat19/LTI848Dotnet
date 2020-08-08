using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace EFWebApiExampleProject.Models
{
    [MetadataType(typeof(MetaDataForTblMovie))]
    public partial class tblMovie
    {
    }

    [DataContract]
    public class MetaDataForTblMovie
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public Nullable<double> duration { get; set; }
    }
}