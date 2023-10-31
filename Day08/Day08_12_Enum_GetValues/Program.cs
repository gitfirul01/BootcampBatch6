
class Program {
	static void Main()
	{
		//Enum -> int
		int numberOfDay = (int)StatusCode.NotFound;
		Console.WriteLine(numberOfDay);										// 404

		//int -> enum (undertemine)
		StatusCode day = (StatusCode)404;
		Console.WriteLine(day);												// NotFound
		
		StatusCode[] status = (StatusCode[])Enum.GetValues(typeof(StatusCode));
		var status2 = Enum.GetValues(typeof(StatusCode));
		Console.WriteLine(status);													// StatusCode[]
		StatusCode[] newstatus = {StatusCode.OK, StatusCode.Forbidden, StatusCode.NotFound};
		int x = status.Length;
	}
}

public enum StatusCode
{
	NotFound = 404,
	Forbidden = 403,
	OK = 200
}