using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace noexcuses.Models.SiteConfigViewModels
{
    public class MainConfigModel
    {
        [Key]
        public int id {get; set;}

        public int currentWk {get; set;}
        public int lastWk {get; set;}
    }

    public class MainContentMngrModel
    {
        [Key]
        public int id {get; set;}
        public string firstPlaceHolder {get; set;}
        public string secondPlaceHolder {get; set;}
        public string thirdPlaceHolder {get; set;}
        public string mainFeatureetStrong {get; set;}

        public string subMainFeatureetLight {get; set;}

        public string videoYouTubePath {get; set;}
    }
}
