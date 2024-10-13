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
            <book>
              <title>The Great Gatsby</title>
              <author>F. Scott Fitzgerald</author>
              <year>1925</year>
            </book>
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
}
