using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Country
{
    public Name name { get; set; }
    public bool independent { get; set; }
    public string status { get; set; }
    public bool unMember { get; set; }

    [JsonPropertyName("currencies")]
    public Dictionary<string, Currency> currencies { get; set; }

    [JsonPropertyName("idd")]
    public Idd idd { get; set; }

    [JsonPropertyName("capital")]
    public List<string> capital { get; set; }

    [JsonPropertyName("altSpellings")]
    public List<string> altSpellings { get; set; }

    [JsonPropertyName("region")]
    public string region { get; set; }

    [JsonPropertyName("subregion")]
    public string subregion { get; set; }

    [JsonPropertyName("languages")]
    public Dictionary<string, string> languages { get; set; }

    [JsonPropertyName("latlng")]
    public List<double> latlng { get; set; }

    [JsonPropertyName("landlocked")]
    public bool landlocked { get; set; }

    [JsonPropertyName("borders")]
    public List<string> borders { get; set; }

    [JsonPropertyName("area")]
    public double area { get; set; }

    [JsonPropertyName("demonyms")]
    public Dictionary<string, Demonym> demonyms { get; set; }

    [JsonPropertyName("cca3")]
    public string cca3 { get; set; }

    [JsonPropertyName("translations")]
    public Dictionary<string, Translation> translations { get; set; }

    [JsonPropertyName("flag")]
    public string flag { get; set; }

    [JsonPropertyName("maps")]
    public Maps maps { get; set; }

    [JsonPropertyName("population")]
    public long population { get; set; }

    [JsonPropertyName("gini")]
    public Dictionary<string, double> gini { get; set; }

    [JsonPropertyName("fifa")]
    public string fifa { get; set; }

    [JsonPropertyName("car")]
    public Car car { get; set; }

    [JsonPropertyName("timezones")]
    public List<string> timezones { get; set; }

    [JsonPropertyName("continents")]
    public List<string> continents { get; set; }

    [JsonPropertyName("flags")]
    public Media flags { get; set; }

    [JsonPropertyName("coatOfArms")]
    public Media coatOfArms { get; set; }

    [JsonPropertyName("startOfWeek")]
    public string startOfWeek { get; set; }

    [JsonPropertyName("capitalInfo")]
    public CapitalInfo capitalInfo { get; set; }

    [JsonPropertyName("postalCode")]
    public PostalCode postalCode { get; set; }
}

public class Name
{
    [JsonPropertyName("common")]
    public string common { get; set; }

    [JsonPropertyName("official")]
    public string official { get; set; }

    [JsonPropertyName("nativeName")]
    public Dictionary<string, Translation> nativeName { get; set; }
}

public class Translation
{
    [JsonPropertyName("official")]
    public string official { get; set; }

    [JsonPropertyName("common")]
    public string common { get; set; }
}

public class Currency
{
    [JsonPropertyName("symbol")]
    public string symbol { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }
}

public class Idd
{
    [JsonPropertyName("root")]
    public string root { get; set; }

    [JsonPropertyName("suffixes")]
    public List<string> suffixes { get; set; }
}

public class Demonym
{
    [JsonPropertyName("f")]
    public string f { get; set; }

    [JsonPropertyName("m")]
    public string m { get; set; }
}

public class Maps
{
    [JsonPropertyName("googleMaps")]
    public string googleMaps { get; set; }

    [JsonPropertyName("openStreetMaps")]
    public string openStreetMaps { get; set; }
}

public class Car
{
    [JsonPropertyName("signs")]
    public List<string> signs { get; set; }

    [JsonPropertyName("side")]
    public string side { get; set; }
}

public class Media
{
    [JsonPropertyName("png")]
    public string png { get; set; }

    [JsonPropertyName("svg")]
    public string svg { get; set; }

    [JsonPropertyName("alt")]
    public string alt { get; set; }
}

public class CapitalInfo
{
    [JsonPropertyName("latlng")]
    public List<double> latlng { get; set; }
}

public class PostalCode
{
    [JsonPropertyName("format")]
    public string format { get; set; }

    [JsonPropertyName("regex")]
    public string regex { get; set; }
}
