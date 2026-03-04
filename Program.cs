using ExcelConsole;

string? csvPath = args.Length > 0 ? args[0] : null;
var app = new SpreadsheetApp(csvPath);
app.Run();
