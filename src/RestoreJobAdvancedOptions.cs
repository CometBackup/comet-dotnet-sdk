// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>RestoreJobAdvancedOptions</c>
/// </summary>
public class RestoreJobAdvancedOptions {
	//One of the RESTORETYPE_ constants
	public long Type { get; set; }
	//For RESTORETYPE_FILE
	public bool OverwriteExistingFiles { get; set; }
	//For RESTORETYPE_FILE. If set, OverwriteExistingFiles must be true
	public bool OverwriteIfNewer { get; set; }
	//For RESTORETYPE_FILE. If set, DestPath must be blank
	public bool DestIsOriginalLocation { get; set; }
	//For RESTORETYPE_FILE or RESTORETYPE_PROCESS_xxx
	public string DestPath { get; set; } = string.Empty;
	//For RESTORETYPE_WINDISK only. Must have one entry for each selected restore path
	public List<string> ExactDestPaths { get; set; }
	//For RESTORETYPE_FILE_ARCHIVE or RESTORETYPE_PROCESS_ARCHIVE. Default 0 is *.tar, for backward compatibility
	public long ArchiveFormat { get; set; }
	//For RESTORETYPE_OFFICE365_CLOUD.
	public Office365Credential Office365Credential { get; set; }
	//For RESTORETYPE_MYSQL
	public string Username { get; set; } = string.Empty;
	//For RESTORETYPE_MYSQL
	public string Password { get; set; } = string.Empty;
	//For RESTORETYPE_MYSQL
	public string Host { get; set; } = string.Empty;
	//For RESTORETYPE_MYSQL
	public string Port { get; set; } = string.Empty;
	//For RESTORETYPE_MYSQL
	public bool UseSsl { get; set; }
	//For RESTORETYPE_MYSQL i.e.: Self signed certs
	public bool SslAllowInvalid { get; set; }
	//For RESTORETYPE_MYSQL
	public string SslCaFile { get; set; } = string.Empty;
	//For RESTORETYPE_MYSQL
	public string SslCrtFile { get; set; } = string.Empty;
	//For RESTORETYPE_MYSQL
	public string SslKeyFile { get; set; } = string.Empty;
	//For RESTORETYPE_MSSQL.
	public MSSQLLoginArgs MsSqlConnection { get; set; }

	public RestoreJobAdvancedOptions(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public RestoreJobAdvancedOptions FromJson(string jsStr) {
		return JsonSerializer.Deserialize<RestoreJobAdvancedOptions>(jsStr);
	}

}
}
