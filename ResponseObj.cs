using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Age data
    /// </summary>
    public class Age
    {
        [JsonProperty("0-4")]
        public double 04 { get; set; }

        [JsonProperty("5-9")]
        public double 59 { get; set; }

        [JsonProperty("10-14")]
        public double 1014 { get; set; }

        [JsonProperty("15-19")]
        public double 1519 { get; set; }

        [JsonProperty("20-24")]
        public double 2024 { get; set; }

        [JsonProperty("25-29")]
        public double 2529 { get; set; }

        [JsonProperty("30-34")]
        public double 3034 { get; set; }

        [JsonProperty("35-39")]
        public double 3539 { get; set; }

        [JsonProperty("40-44")]
        public double 4044 { get; set; }

        [JsonProperty("45-49")]
        public double 4549 { get; set; }

        [JsonProperty("50-54")]
        public double 5054 { get; set; }

        [JsonProperty("55-59")]
        public double 5559 { get; set; }

        [JsonProperty("60-64")]
        public double 6064 { get; set; }

        [JsonProperty("65-69")]
        public double 6569 { get; set; }

        [JsonProperty("70-74")]
        public double 7074 { get; set; }

        [JsonProperty("75-79")]
        public double 7579 { get; set; }

        [JsonProperty("80-84")]
        public double 8084 { get; set; }

        [JsonProperty("85+")]
        public double 85 { get; set; }

    }
    /// <summary>
    /// Deaths data
    /// </summary>
    public class Deaths
    {
        [JsonProperty("suicides")]
        public double Suicides { get; set; }

        [JsonProperty("homicides")]
        public double Homicides { get; set; }

        [JsonProperty("vehicle")]
        public int Vehicle { get; set; }

        [JsonProperty("firearmsuicides")]
        public double Firearmsuicides { get; set; }

    }
    /// <summary>
    /// Health data
    /// </summary>
    public class Health
    {
        [JsonProperty("poorhealth")]
        public double Poorhealth { get; set; }

        [JsonProperty("physicallyunhealthydays")]
        public double Physicallyunhealthydays { get; set; }

        [JsonProperty("mentallyunhealthydays")]
        public double Mentallyunhealthydays { get; set; }

        [JsonProperty("lowbirthweightpercent")]
        public double Lowbirthweightpercent { get; set; }

        [JsonProperty("smokerspercent")]
        public double Smokerspercent { get; set; }

        [JsonProperty("obesitypercent")]
        public double Obesitypercent { get; set; }

        [JsonProperty("foodenvindex")]
        public double Foodenvindex { get; set; }

        [JsonProperty("physicallyinactivepercent")]
        public double Physicallyinactivepercent { get; set; }

        [JsonProperty("excessivedrinkingpercent")]
        public double Excessivedrinkingpercent { get; set; }

        [JsonProperty("alcoholimpaireddrivingdeaths")]
        public int Alcoholimpaireddrivingdeaths { get; set; }

        [JsonProperty("teenbirthrate")]
        public double Teenbirthrate { get; set; }

        [JsonProperty("uninsured")]
        public double Uninsured { get; set; }

        [JsonProperty("withannualmammogram")]
        public int Withannualmammogram { get; set; }

        [JsonProperty("vaccinated")]
        public int Vaccinated { get; set; }

        [JsonProperty("childreninpoverty")]
        public double Childreninpoverty { get; set; }

        [JsonProperty("80thpercentileincome")]
        public int 80thpercentileincome { get; set; }

        [JsonProperty("20thpercentileincome")]
        public int 20thpercentileincome { get; set; }

        [JsonProperty("childreninsingleparenthouseholds")]
        public double Childreninsingleparenthouseholds { get; set; }

        [JsonProperty("violentcrimerate")]
        public double Violentcrimerate { get; set; }

        [JsonProperty("averagedailypm25")]
        public double Averagedailypm25 { get; set; }

        [JsonProperty("severehousingproblems")]
        public double Severehousingproblems { get; set; }

        [JsonProperty("drivealonetowork")]
        public double Drivealonetowork { get; set; }

        [JsonProperty("longcommutedrivesalone")]
        public double Longcommutedrivesalone { get; set; }

    }
    /// <summary>
    /// Education data
    /// </summary>
    public class Education
    {
        [JsonProperty("lessthanhighschool")]
        public double Lessthanhighschool { get; set; }

        [JsonProperty("highschool")]
        public double Highschool { get; set; }

        [JsonProperty("somecollege")]
        public double Somecollege { get; set; }

        [JsonProperty("bachelors")]
        public double Bachelors { get; set; }

    }
    /// <summary>
    /// Costofliving data
    /// </summary>
    public class Costofliving
    {
        [JsonProperty("livingwage")]
        public double Livingwage { get; set; }

        [JsonProperty("foodcosts")]
        public int Foodcosts { get; set; }

        [JsonProperty("medicalcosts")]
        public int Medicalcosts { get; set; }

        [JsonProperty("housingcosts")]
        public int Housingcosts { get; set; }

        [JsonProperty("taxcosts")]
        public int Taxcosts { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("age")]
        public Age Age { get; set; }

        [JsonProperty("male")]
        public int Male { get; set; }

        [JsonProperty("female")]
        public int Female { get; set; }

        [JsonProperty("deaths")]
        public Deaths Deaths { get; set; }

        [JsonProperty("health")]
        public Health Health { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("education")]
        public Education Education { get; set; }

        [JsonProperty("zipcodes")]
        public string[] Zipcodes { get; set; }

        [JsonProperty("lifeexpectancy")]
        public double Lifeexpectancy { get; set; }

        [JsonProperty("avgincome")]
        public int Avgincome { get; set; }

        [JsonProperty("povertyrate")]
        public double Povertyrate { get; set; }

        [JsonProperty("costofliving")]
        public Costofliving Costofliving { get; set; }

        [JsonProperty("landareakm2")]
        public double Landareakm2 { get; set; }

        [JsonProperty("areakm2")]
        public double Areakm2 { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
