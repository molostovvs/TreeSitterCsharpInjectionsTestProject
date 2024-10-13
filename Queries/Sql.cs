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

	}
}
