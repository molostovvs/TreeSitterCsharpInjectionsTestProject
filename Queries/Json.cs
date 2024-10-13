namespace Queries;

public class Json
{
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
