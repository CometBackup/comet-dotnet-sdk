# Comet .NET SDK

[![@CometBackup on Twitter](http://img.shields.io/badge/twitter-%40CometBackup-blue.svg?style=flat)](https://twitter.com/CometBackup)
![MIT License](https://img.shields.io/github/license/CometBackup/comet-go-sdk)
![Nuget](https://img.shields.io/nuget/v/CometBackup.CometAPI.SDK)

This project is a SDK and base client for Comet Server API using .NET, coded in C#.

# Simple Usage Example
```csharp
using CometBackup.CometAPI.SDK;

public class Test {
    public static void Main(string[] args) {
        using (var client = new CometAPI("http://127.0.0.1:8060", "admin", "admin")) {
            var users = client.AdminListUsers();
            foreach (var user in users) {
                Console.WriteLine(user);
            }
        }
    }
}
```

# Getting Help

Bug reports and pull requests are welcome on GitHub at [https://github.com/CometBackup/comet-dotnet-sdk](https://github.com/CometBackup/comet-dotnet-sdk).

You may also submit issues via the ticket system at [cometbackup.com](https://cometbackup.com/).
