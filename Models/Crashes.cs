using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudApp.Models
{
	public class Crashes
	{
		public Crash[] Property1 { get; set; }
	}

	public class Crash
	{
		public DateTime crash_date { get; set; }
		public string crash_time { get; set; }
		public string latitude { get; set; }
		public string longitude { get; set; }
		public Location location { get; set; }
		public string on_street_name { get; set; }
		public string number_of_persons_injured { get; set; }
		public string number_of_persons_killed { get; set; }
		public string number_of_pedestrians_injured { get; set; }
		public string number_of_pedestrians_killed { get; set; }
		public string number_of_cyclist_injured { get; set; }
		public string number_of_cyclist_killed { get; set; }
		public string number_of_motorist_injured { get; set; }
		public string number_of_motorist_killed { get; set; }
		public string contributing_factor_vehicle_1 { get; set; }
		public string contributing_factor_vehicle_2 { get; set; }
		public string collision_id { get; set; }
		public string vehicle_type_code1 { get; set; }
		public string vehicle_type_code2 { get; set; }
		public string borough { get; set; }
		public string zip_code { get; set; }
		public string cross_street_name { get; set; }
		public string off_street_name { get; set; }
		public string contributing_factor_vehicle_3 { get; set; }
		public string vehicle_type_code_3 { get; set; }
		public string contributing_factor_vehicle_4 { get; set; }
		public string vehicle_type_code_4 { get; set; }
		public string contributing_factor_vehicle_5 { get; set; }
		public string vehicle_type_code_5 { get; set; }
	}

	public class Location
	{
		public string latitude { get; set; }
		public string longitude { get; set; }
	}
}







