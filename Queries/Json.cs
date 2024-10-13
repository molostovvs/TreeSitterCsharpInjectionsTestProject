namespace Queries;

public class Json
{
    private static void QuotedStrings()
    {
        //language=json
        var string1 = "{\"name\": \"John\", \"age\": 30}";

        //language=json
        string string2 = "{\"colors\": [\"red\", \"green\", \"blue\"]}";

        //language=json
        const string string3 = "{\"isActive\": true, \"score\": 95.5}";

        var string4 = string.Empty;
        //language=json
        string4 = "{\"city\": \"New York\", \"country\": \"USA\"}";
    }

    private static void VerbatimStrings()
    {
        //language=json
        var string1 = @"{""user"": {""id"": 1, ""name"": ""Alice""}}";

        //language=json
        string string2 = @"{""items"": [{""id"": 1, ""name"": ""Apple""}, {""id"": 2, ""name"": ""Banana""}]}";

        //language=json
        const string string3 = @"{""settings"": {""darkMode"": true, ""fontSize"": 14}}";

        var string4 = string.Empty;
        //language=json
        string4 = @"{""coordinates"": {""x"": 10, ""y"": 20}}";
    }

    private static void RawStrings()
    {
        //language=json
        var raw1 = """{"status": "success", "code": 200}""";

        //language=json
        var raw2 = """
            {
              "person": {
                "name": "Emma",
                "age": 28,
                "hobbies": ["reading", "swimming"]
              }
            }
            """;

        var raw3 = string.Empty;
        //language=json
        raw3 = """
            {
              "product": {
                "id": "p123",
                "name": "Laptop",
                "price": 999.99,
                "inStock": true
              }
            }
            """;
    }
}
