namespace Queries;

public class Sql
{
	private static void QuotedStrings()
	{
		//language=sql
		var string1 = "select * from users where id = 5;";

		//language=sql
		string string2 = "select * from users where id = 5";

		//language=sql
		const string string3 = "select * from users where id = 5;";

		var string4 = string.Empty;
		//language=sql
		string4 = "select * from users where id = 5;";
	}

	private static void VerbatimStrings()
	{
		//language=sql
		var string1 = @"select * from users where id = 5;";

		//language=sql
		string string2 = @"select * from users where id = 5";

		//language=sql
		const string string3 = @"select * from users where id = 5;";

		var string4 = string.Empty;
		//language=sql
		string4 = @"select * from users where id = 5;";
	}

	private static void RawStrings()
	{
		//language=sql
		var raw1 = """select * from users""";

		//language=sql
		var raw2 = """
			SELECT u.Id, u.Name, u.Email, COUNT(o.Id) AS OrderCount
			FROM users AS u
			INNER JOIN orders AS o ON u.Id = o.OwnerId
			GROUP BY u.Id, u.Name, u.Email;
			""";

		var raw3 = string.Empty;
		//language=sql
		raw3 = """
			SELECT u.Id, u.Name, u.Email, COUNT(o.Id) AS OrderCount
			FROM users AS u
			INNER JOIN orders AS o ON u.Id = o.OwnerId
			GROUP BY u.Id, u.Name, u.Email;
			""";
	}
}
