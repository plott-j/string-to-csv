//STRING TO CSV - API

[HttpPost("<endpoint route>")]
[Consumes("multipart/form-data")]
[Produces(MediaTypeNames.Application.Octet)]
public async Task<FileResult> RouteMethod(string newFilename, IFormFile file)
{
	...
	var preparedString = PrepareStringForNewFormat(headers, answers);
	var bytes = Encoding.UTF8.GetBytes(preparedString);

	return File(bytes, "text/csv", newFilename);
}



private string PrepareStringForNewFormat(string headers, string answers) 
{
		StringBuilder fullString = new StringBuilder();
		fullString.Append(headerLine) //.AppendLine() will split lines while writing CSV
							.AppendLine()
							.Append(answerLine);
		
		return fullString;
}					
