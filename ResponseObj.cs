using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class age
{
    [JsonProperty("85+")]
    public double 85 { get; set; }

}

public class deaths
{
    [JsonProperty("suicides")]
    public double suicides { get; set; }

    [JsonProperty("firearm suicides")]
    public double firearmsuicides { get; set; }

    [JsonProperty("homicides")]
    public double homicides { get; set; }

    [JsonProperty("vehicle")]
    public int vehicle { get; set; }

}

public class health
{
    [JsonProperty("poorHealth")]
    public double poorHealth { get; set; }

    [JsonProperty("physicallyUnhealthyDays")]
    public double physicallyUnhealthyDays { get; set; }

    [JsonProperty("mentallyUnhealthyDays")]
    public double mentallyUnhealthyDays { get; set; }

    [JsonProperty("lowBirthweightPercent")]
    public double lowBirthweightPercent { get; set; }

    [JsonProperty("smokersPercent")]
    public double smokersPercent { get; set; }

    [JsonProperty("obesityPercent")]
    public double obesityPercent { get; set; }

    [JsonProperty("foodEnvIndex")]
    public double foodEnvIndex { get; set; }

    [JsonProperty("physicallyInactivePercent")]
    public double physicallyInactivePercent { get; set; }

    [JsonProperty("excessiveDrinkingPercent")]
    public double excessiveDrinkingPercent { get; set; }

    [JsonProperty("Teen Birth Rate")]
    public double teenBirthRate { get; set; }

    [JsonProperty("% Uninsured")]
    public double uninsured { get; set; }

    [JsonProperty("% With Annual Mammogram")]
    public int withAnnualMammogram { get; set; }

    [JsonProperty("% Vaccinated")]
    public int vaccinated { get; set; }

    [JsonProperty("% Children in Poverty")]
    public double childreninPoverty { get; set; }

    [JsonProperty("80th Percentile Income")]
    public int 80thPercentileIncome { get; set; }

    [JsonProperty("20th Percentile Income")]
    public int 20thPercentileIncome { get; set; }

    [JsonProperty("Violent Crime Rate")]
    public double violentCrimeRate { get; set; }

    [JsonProperty("Average Daily PM2.5")]
    public double averageDailyPM25 { get; set; }

    [JsonProperty("% Severe Housing Problems")]
    public double severeHousingProblems { get; set; }

    [JsonProperty("% Drive Alone to Work")]
    public double driveAlonetoWork { get; set; }

}

public class education
{
    [JsonProperty("bachelors+")]
    public double bachelors { get; set; }

    [JsonProperty("lessThanHighSchool")]
    public double lessThanHighSchool { get; set; }

    [JsonProperty("highSchool")]
    public double highSchool { get; set; }

    [JsonProperty("someCollege")]
    public double someCollege { get; set; }

}

public class costOfLiving
{
    [JsonProperty("living_wage")]
    public double livingwage { get; set; }

    [JsonProperty("food_costs")]
    public int foodcosts { get; set; }

    [JsonProperty("medical_costs")]
    public int medicalcosts { get; set; }

    [JsonProperty("housing_costs")]
    public int housingcosts { get; set; }

    [JsonProperty("tax_costs")]
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

    [JsonProperty("avg_income")]
    public int avgincome { get; set; }

    [JsonProperty("health")]
    public health health { get; set; }

    [JsonProperty("landAreaKM2")]
    public double landAreaKM2 { get; set; }

    [JsonProperty("areaKM2")]
    public double areaKM2 { get; set; }

    [JsonProperty("longitude")]
    public double longitude { get; set; }

    [JsonProperty("latitude")]
    public double latitude { get; set; }

    [JsonProperty("zipCodes")]
    public string[] zipCodes { get; set; }

    [JsonProperty("lifeExpectancy")]
    public double lifeExpectancy { get; set; }

    [JsonProperty("education")]
    public education education { get; set; }

    [JsonProperty("povertyRate")]
    public double povertyRate { get; set; }

    [JsonProperty("costOfLiving")]
    public costOfLiving costOfLiving { get; set; }

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
