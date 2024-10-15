namespace Queries;

public class Xml
{
    private static void RawStrings()
    {
        //language=xml
        var xml1 = """
            <person>
              <name>John Doe</name>
              <age>30</age>
            </person>
            """;

        //language=xml
        var xml2 = """
            <?xml version="1.0" encoding="UTF-8"?>
            <books>
              <book id="1">
                <title>The Great Gatsby</title>
                <author>F. Scott Fitzgerald</author>
                <year>1925</year>
              </book>
            </books>
            """;

        var xml3 = string.Empty;
        //language=xml
        xml3 = """
            <users>
              <user id="1">
                <name>Alice</name>
                <email>alice@example.com</email>
              </user>
              <user id="2">
                <name>Bob</name>
                <email>bob@example.com</email>
              </user>
            </users>
            """;
    }

    private static void RawInterpolatedStrings()
    {
        var name = "John Doe";
        var age = 30;
        //language=xml
        var xml1 = $"""
            <person>
              <name>{name}</name>
              <age>{age}</age>
            </person>
            """;

        var title = "The Great Gatsby";
        var author = "F. Scott Fitzgerald";
        //language=xml
        var xml2 = $"""
            <?xml version="1.0" encoding="UTF-8"?>
            <book>
              <title>{title}</title>
              <author>{author}</author>
              <year>1925</year>
            </book>
            """;

        var userId = 1;
        var email = "alice@example.com";
        var xml3 = string.Empty;
        //language=xml
        xml3 = $"""
            <users>
              <user id="{userId}">
                <name>Alice</name>
                <email>{email}</email>
              </user>
            </users>
            """;
    }
}
