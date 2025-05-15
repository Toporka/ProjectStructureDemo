using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("Logs/MyLog.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();


UserService service = new UserService();

User anton = new User(1212, "Антон");
User alex = new User(3243, "Алекс");

service.AddUser(anton);
service.AddUser(alex);

User user = service.GetUser(1212);
Log.Information($"\nID: {user.Id}\nName: {user.Name}");