using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FoodTruckModel
    {

        public string dayorder { get; set; }
        public string dayofweekstr { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string permit { get; set; }
        public string location { get; set; }
        public string locationdesc { get; set; }
        public string optionaltext { get; set; }
        public string locationid { get; set; }
        public string start24 { get; set; }
        public string end24 { get; set; }
        public string cnn { get; set; }
        public string addr_date_create { get; set; }
        public string addr_date_modified { get; set; }
        public string block { get; set; }
        public string lot { get; set; }
        public string coldtruck { get; set; }
        public string applicant { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public location_2 location_2 { get; set; }

    }

    public class location_2
    {

        public string latitude { get; set; }
        public string longitude { get; set; }
        public string human_address { get; set; }

    }

}
