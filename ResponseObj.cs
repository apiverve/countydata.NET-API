using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class age
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

public class deaths
{
    [JsonProperty("suicides")]
    public double suicides { get; set; }

    [JsonProperty("homicides")]
    public double homicides { get; set; }

    [JsonProperty("vehicle")]
    public int vehicle { get; set; }

    [JsonProperty("firearmsuicides")]
    public double firearmsuicides { get; set; }

}

public class health
{
    [JsonProperty("poorhealth")]
    public double poorhealth { get; set; }

    [JsonProperty("physicallyunhealthydays")]
    public double physicallyunhealthydays { get; set; }

    [JsonProperty("mentallyunhealthydays")]
    public double mentallyunhealthydays { get; set; }

    [JsonProperty("lowbirthweightpercent")]
    public double lowbirthweightpercent { get; set; }

    [JsonProperty("smokerspercent")]
    public double smokerspercent { get; set; }

    [JsonProperty("obesitypercent")]
    public double obesitypercent { get; set; }

    [JsonProperty("foodenvindex")]
    public double foodenvindex { get; set; }

    [JsonProperty("physicallyinactivepercent")]
    public double physicallyinactivepercent { get; set; }

    [JsonProperty("excessivedrinkingpercent")]
    public double excessivedrinkingpercent { get; set; }

    [JsonProperty("alcoholimpaireddrivingdeaths")]
    public int alcoholimpaireddrivingdeaths { get; set; }

    [JsonProperty("teenbirthrate")]
    public double teenbirthrate { get; set; }

    [JsonProperty("uninsured")]
    public double uninsured { get; set; }

    [JsonProperty("withannualmammogram")]
    public int withannualmammogram { get; set; }

    [JsonProperty("vaccinated")]
    public int vaccinated { get; set; }

    [JsonProperty("childreninpoverty")]
    public double childreninpoverty { get; set; }

    [JsonProperty("80thpercentileincome")]
    public int 80thpercentileincome { get; set; }

    [JsonProperty("20thpercentileincome")]
    public int 20thpercentileincome { get; set; }

    [JsonProperty("childreninsingleparenthouseholds")]
    public double childreninsingleparenthouseholds { get; set; }

    [JsonProperty("violentcrimerate")]
    public double violentcrimerate { get; set; }

    [JsonProperty("averagedailypm25")]
    public double averagedailypm25 { get; set; }

    [JsonProperty("severehousingproblems")]
    public double severehousingproblems { get; set; }

    [JsonProperty("drivealonetowork")]
    public double drivealonetowork { get; set; }

    [JsonProperty("longcommutedrivesalone")]
    public double longcommutedrivesalone { get; set; }

}

public class education
{
    [JsonProperty("lessthanhighschool")]
    public double lessthanhighschool { get; set; }

    [JsonProperty("highschool")]
    public double highschool { get; set; }

    [JsonProperty("somecollege")]
    public double somecollege { get; set; }

    [JsonProperty("bachelors")]
    public double bachelors { get; set; }

}

public class costofliving
{
    [JsonProperty("livingwage")]
    public double livingwage { get; set; }

    [JsonProperty("foodcosts")]
    public int foodcosts { get; set; }

    [JsonProperty("medicalcosts")]
    public int medicalcosts { get; set; }

    [JsonProperty("housingcosts")]
    public int housingcosts { get; set; }

    [JsonProperty("taxcosts")]
    public int taxcosts { get; set; }

}

public class data
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("age")]
    public age age { get; set; }

    [JsonProperty("male")]
    public int male { get; set; }

    [JsonProperty("female")]
    public int female { get; set; }

    [JsonProperty("deaths")]
    public deaths deaths { get; set; }

    [JsonProperty("health")]
    public health health { get; set; }

    [JsonProperty("longitude")]
    public double longitude { get; set; }

    [JsonProperty("latitude")]
    public double latitude { get; set; }

    [JsonProperty("education")]
    public education education { get; set; }

    [JsonProperty("zipcodes")]
    public string[] zipcodes { get; set; }

    [JsonProperty("lifeexpectancy")]
    public double lifeexpectancy { get; set; }

    [JsonProperty("avgincome")]
    public int avgincome { get; set; }

    [JsonProperty("povertyrate")]
    public double povertyrate { get; set; }

    [JsonProperty("costofliving")]
    public costofliving costofliving { get; set; }

    [JsonProperty("landareakm2")]
    public double landareakm2 { get; set; }

    [JsonProperty("areakm2")]
    public double areakm2 { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
