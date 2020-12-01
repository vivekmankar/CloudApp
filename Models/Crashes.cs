using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CloudApp.Models
{

	public class Crashes
	{
		[JsonProperty("crash_date")]
		public DateTime Crash_date { get; set; }
		[JsonProperty("crash_time")]
		public DateTime Crash_time { get; set; }
		[JsonProperty("borough")]
		public string Borough { get; set; }
		[JsonProperty("zip_code")]
		public string Zip_code { get; set; }
		[JsonProperty("latitude")]
		//public string Latitude { get; set; }
		//[JsonProperty("longitude")]
		//public string Longitude { get; set; }
		//[JsonProperty("location")]
		//public Dictionary<string, Location> Location { get; set; }
		//[JsonProperty("cross_street_name")]
		public string Cross_street_name { get; set; }
		[JsonProperty("number_of_persons_injured")]
		public string Number_of_persons_injured { get; set; }
		[JsonProperty("number_of_persons_killed")]
		public string Number_of_persons_killed { get; set; }
		[JsonProperty("number_of_pedestrians_injured")]
		public string Number_of_pedestrians_injured { get; set; }
		[JsonProperty("number_of_pedestrians_killed")]
		public string Number_of_pedestrians_killed { get; set; }
		[JsonProperty("number_of_cyclist_injured")]
		public string Number_of_cyclist_injured { get; set; }
		[JsonProperty("number_of_cyclist_killed")]
		public string Number_of_cyclist_killed { get; set; }
		[JsonProperty("number_of_motorist_injured")]
		public string Number_of_motorist_injured { get; set; }
		[JsonProperty("number_of_motorist_killed")]
		public string Number_of_motorist_killed { get; set; }
		[JsonProperty("contributing_factor_vehicle_1")]
		public string Contributing_factor_vehicle_1 { get; set; }
		[JsonProperty("contributing_factor_vehicle_2")]
		public string Contributing_factor_vehicle_2 { get; set; }
		[JsonProperty("collision_id")]
		public string Collision_id { get; set; }
		[JsonProperty("vehicle_type_code1")]
		public string Vehicle_type_code1 { get; set; }
		[JsonProperty("vehicle_type_code2")]
		public string Vehicle_type_code2 { get; set; }
		[JsonProperty("on_street_name")]
		public string On_street_name { get; set; }
		[JsonProperty("off_street_name")]
		public string Off_street_name { get; set; }
		[JsonProperty("contributing_factor_vehicle_3")]
		public string Contributing_factor_vehicle_3 { get; set; }
		[JsonProperty("vehicle_type_code_3")]
		public string Vehicle_type_code_3 { get; set; }
		[JsonProperty("contributing_factor_vehicle_4")]
		public string Contributing_factor_vehicle_4 { get; set; }
		[JsonProperty("contributing_factor_vehicle_5")]
		public string Contributing_factor_vehicle_5 { get; set; }
		[JsonProperty("vehicle_type_code_4")]
		public string Vehicle_type_code_4 { get; set; }
		[JsonProperty("vehicle_type_code_5")]
		public string Vehicle_type_code_5 { get; set; }
	}

	//public class Location
	//{
	//	[JsonProperty("latitude")]
	//	public string Latitude { get; set; }
	//	[JsonProperty("longitude")]
	//	public string Longitude { get; set; }
	//}
}

