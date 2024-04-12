// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>DestinationLocation</c> DestinationLocation describes the underlying storage location for a Storage Vault.
/// Prior to Comet 17.3.3 this was an embedded part of the DestinationConfig type.
/// Since Version : 17.3.3
/// </summary>
public class DestinationLocation {

	[JsonPropertyName("DestinationType")]
	//One of the DESTINATIONTYPE_ constants
	public ulong DestinationType { get; set; }

	[JsonPropertyName("CometServer")]
	//The URL for the target Comet Server Storage Role, including http/https and trailing slash
	public string CometServer { get; set; } = string.Empty;

	[JsonPropertyName("CometBucket")]
	public string CometBucket { get; set; } = string.Empty;

	[JsonPropertyName("CometBucketKey")]
	public string CometBucketKey { get; set; } = string.Empty;

	[JsonPropertyName("S3Server")]
	public string S3Server { get; set; } = string.Empty;

	[JsonPropertyName("S3UsesTLS")]
	public bool S3UsesTLS { get; set; }

	[JsonPropertyName("S3AccessKey")]
	public string S3AccessKey { get; set; } = string.Empty;

	[JsonPropertyName("S3SecretKey")]
	public string S3SecretKey { get; set; } = string.Empty;

	[JsonPropertyName("S3BucketName")]
	public string S3BucketName { get; set; } = string.Empty;

	[JsonPropertyName("S3Subdir")]
	public string S3Subdir { get; set; } = string.Empty;

	[JsonPropertyName("S3CustomRegion")]
	public string S3CustomRegion { get; set; } = string.Empty;

	[JsonPropertyName("S3UsesV2Signing")]
	//If true, use legacy v2 signing. If false (default), use modern v4 signing
	public bool S3UsesV2Signing { get; set; }

	[JsonPropertyName("S3RemoveDeleted")]
	public bool S3RemoveDeleted { get; set; }

	[JsonPropertyName("S3ObjectLockMode")]
	public byte S3ObjectLockMode { get; set; }

	[JsonPropertyName("S3ObjectLockDays")]
	public long S3ObjectLockDays { get; set; }

	[JsonPropertyName("SFTPServer")]
	public string SFTPServer { get; set; } = string.Empty;

	[JsonPropertyName("SFTPUsername")]
	public string SFTPUsername { get; set; } = string.Empty;

	[JsonPropertyName("SFTPRemotePath")]
	//The directory on the SFTP server in which data is stored.
	public string SFTPRemotePath { get; set; } = string.Empty;

	[JsonPropertyName("SFTPAuthMode")]
	//One of the DESTINATION_SFTP_AUTHMODE_ constants
	public ulong SFTPAuthMode { get; set; }

	[JsonPropertyName("SFTPPassword")]
	//For use with DESTINATION_SFTP_AUTHMODE_PASSWORD only: the SSH password to connect with
	public string SFTPPassword { get; set; } = string.Empty;

	[JsonPropertyName("SFTPPrivateKey")]
	//For use with DESTINATION_SFTP_AUTHMODE_PRIVATEKEY only: the SSH private key to connect with, in OpenSSH format.
	public string SFTPPrivateKey { get; set; } = string.Empty;

	[JsonPropertyName("SFTPCustomAuth_UseKnownHostsFile")]
	//If true, then the SFTPCustomAuth_KnownHostsFile will be used to verify the remote SSH server's host key, using Trust
	//On First Use (TOFU).
	public bool SFTPCustomAuth_UseKnownHostsFile { get; set; }

	[JsonPropertyName("SFTPCustomAuth_KnownHostsFile")]
	//If SFTPCustomAuth_UseKnownHostFile is true, the path to the SSH known_hosts file.
	public string SFTPCustomAuth_KnownHostsFile { get; set; } = string.Empty;

	[JsonPropertyName("FTPServer")]
	public string FTPServer { get; set; } = string.Empty;

	[JsonPropertyName("FTPUsername")]
	public string FTPUsername { get; set; } = string.Empty;

	[JsonPropertyName("FTPPassword")]
	public string FTPPassword { get; set; } = string.Empty;

	[JsonPropertyName("FTPBaseUseHomeDirectory")]
	//If true, store data in the default home directory given by the FTP server. If false, store data in the
	//FTPCustomBaseDirectory path.
	public bool FTPBaseUseHomeDirectory { get; set; }

	[JsonPropertyName("FTPCustomBaseDirectory")]
	//If FTPBaseUseHomeDirectory is false, this field controls the path where data is stored.
	public string FTPCustomBaseDirectory { get; set; } = string.Empty;

	[JsonPropertyName("FTPSMode")]
	//Control whether this is plaintext FTP or secure FTPS by using one of the FTPS_MODE_ constants.
	public long FTPSMode { get; set; }

	[JsonPropertyName("FTPPort")]
	public long FTPPort { get; set; }

	[JsonPropertyName("FTPMaxConnections")]
	//If set to zero, uses a system default value that is not unlimited.
	public long FTPMaxConnections { get; set; }

	[JsonPropertyName("FTPAcceptInvalidSSL")]
	public bool FTPAcceptInvalidSSL { get; set; }

	[JsonPropertyName("AZBAccountName")]
	public string AZBAccountName { get; set; } = string.Empty;

	[JsonPropertyName("AZBAccountKey")]
	public string AZBAccountKey { get; set; } = string.Empty;

	[JsonPropertyName("AZBContainer")]
	public string AZBContainer { get; set; } = string.Empty;

	[JsonPropertyName("AZBRealm")]
	//The base URL for the Azure Blob Storage service. Leave blank to use the global default URL.
	public string AZBRealm { get; set; } = string.Empty;

	[JsonPropertyName("AZBPrefix")]
	public string AZBPrefix { get; set; } = string.Empty;

	[JsonPropertyName("LocalcopyPath")]
	public string LocalcopyPath { get; set; } = string.Empty;

	[JsonPropertyName("LocalcopyWinSMBUsername")]
	//If logging in to a Windows network share (SMB/CIFS) is required, enter the username here.
	public string LocalcopyWinSMBUsername { get; set; } = string.Empty;

	[JsonPropertyName("LocalcopyWinSMBPassword")]
	//If logging in to a Windows network share (SMB/CIFS) is required, enter the password here. The password may be hashed
	//as per the LocalcopyWinSMBPasswordFormat field.
	public string LocalcopyWinSMBPassword { get; set; } = string.Empty;

	[JsonPropertyName("LocalcopyWinSMBPasswordFormat")]
	//One of the PASSWORD_FORMAT_ constants. It controls the hash format of the LocalcopyWinSMBPassword field.
	public ulong LocalcopyWinSMBPasswordFormat { get; set; }

	[JsonPropertyName("Swift")]
	public SwiftDestinationLocation Swift { get; set; }

	[JsonPropertyName("B2")]
	public B2DestinationLocation B2 { get; set; }

	[JsonPropertyName("WebDav")]
	public WebDavDestinationLocation WebDav { get; set; }

	[JsonPropertyName("Storj")]
	public StorjDestinationLocation Storj { get; set; }

	[JsonPropertyName("SMB")]
	public SMBDestinationLocation SMB { get; set; }

	[JsonPropertyName("SpanTargets")]
	//A list of underlying destinations, that will be combined and presented as one.
	public List<DestinationLocation> SpanTargets { get; set; }

	[JsonPropertyName("SpanUseStaticSlots")]
	//If true, this Spanned destination will use a consistent hashing scheme
	//to immediately find specific files on exactly one of the target destinations.
	//In the Static Slots mode, the span targets cannot be moved or merged, and
	//the files must always remain in their original location.
	//
	//If false, the Spanned destination system will search all targets to find
	//the requested file. This is slightly slower, but allows you to freely merge,
	//split, and reorder the underlying destination locations.
	//
	//The default option is false.
	public bool SpanUseStaticSlots { get; set; }

	[JsonPropertyName("Tag")]
	public string Tag { get; set; } = string.Empty;

	public DestinationLocation(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public DestinationLocation FromJson(string jsStr) {
		return JsonSerializer.Deserialize<DestinationLocation>(jsStr);
	}

	public CometDestinationLocation GetEmbeddedCometDestinationLocation() => new CometDestinationLocation {
		CometServer = this.CometServer,
		CometBucket = this.CometBucket,
		CometBucketKey = this.CometBucketKey,
	};

	public void SetEmbeddedCometDestinationLocation(CometDestinationLocation other){
		this.CometServer = other.CometServer;
		this.CometBucket = other.CometBucket;
		this.CometBucketKey = other.CometBucketKey;
	}

	public S3DestinationLocation GetEmbeddedS3DestinationLocation() => new S3DestinationLocation {
		S3Server = this.S3Server,
		S3UsesTLS = this.S3UsesTLS,
		S3AccessKey = this.S3AccessKey,
		S3SecretKey = this.S3SecretKey,
		S3BucketName = this.S3BucketName,
		S3Subdir = this.S3Subdir,
		S3CustomRegion = this.S3CustomRegion,
		S3UsesV2Signing = this.S3UsesV2Signing,
		S3RemoveDeleted = this.S3RemoveDeleted,
		S3ObjectLockMode = this.S3ObjectLockMode,
		S3ObjectLockDays = this.S3ObjectLockDays,
	};

	public void SetEmbeddedS3DestinationLocation(S3DestinationLocation other){
		this.S3Server = other.S3Server;
		this.S3UsesTLS = other.S3UsesTLS;
		this.S3AccessKey = other.S3AccessKey;
		this.S3SecretKey = other.S3SecretKey;
		this.S3BucketName = other.S3BucketName;
		this.S3Subdir = other.S3Subdir;
		this.S3CustomRegion = other.S3CustomRegion;
		this.S3UsesV2Signing = other.S3UsesV2Signing;
		this.S3RemoveDeleted = other.S3RemoveDeleted;
		this.S3ObjectLockMode = other.S3ObjectLockMode;
		this.S3ObjectLockDays = other.S3ObjectLockDays;
	}

	public SFTPDestinationLocation GetEmbeddedSFTPDestinationLocation() => new SFTPDestinationLocation {
		SFTPServer = this.SFTPServer,
		SFTPUsername = this.SFTPUsername,
		SFTPRemotePath = this.SFTPRemotePath,
		SFTPAuthMode = this.SFTPAuthMode,
		SFTPPassword = this.SFTPPassword,
		SFTPPrivateKey = this.SFTPPrivateKey,
		SFTPCustomAuth_UseKnownHostsFile = this.SFTPCustomAuth_UseKnownHostsFile,
		SFTPCustomAuth_KnownHostsFile = this.SFTPCustomAuth_KnownHostsFile,
	};

	public void SetEmbeddedSFTPDestinationLocation(SFTPDestinationLocation other){
		this.SFTPServer = other.SFTPServer;
		this.SFTPUsername = other.SFTPUsername;
		this.SFTPRemotePath = other.SFTPRemotePath;
		this.SFTPAuthMode = other.SFTPAuthMode;
		this.SFTPPassword = other.SFTPPassword;
		this.SFTPPrivateKey = other.SFTPPrivateKey;
		this.SFTPCustomAuth_UseKnownHostsFile = other.SFTPCustomAuth_UseKnownHostsFile;
		this.SFTPCustomAuth_KnownHostsFile = other.SFTPCustomAuth_KnownHostsFile;
	}

	public FTPDestinationLocation GetEmbeddedFTPDestinationLocation() => new FTPDestinationLocation {
		FTPServer = this.FTPServer,
		FTPUsername = this.FTPUsername,
		FTPPassword = this.FTPPassword,
		FTPBaseUseHomeDirectory = this.FTPBaseUseHomeDirectory,
		FTPCustomBaseDirectory = this.FTPCustomBaseDirectory,
		FTPSMode = this.FTPSMode,
		FTPPort = this.FTPPort,
		FTPMaxConnections = this.FTPMaxConnections,
		FTPAcceptInvalidSSL = this.FTPAcceptInvalidSSL,
	};

	public void SetEmbeddedFTPDestinationLocation(FTPDestinationLocation other){
		this.FTPServer = other.FTPServer;
		this.FTPUsername = other.FTPUsername;
		this.FTPPassword = other.FTPPassword;
		this.FTPBaseUseHomeDirectory = other.FTPBaseUseHomeDirectory;
		this.FTPCustomBaseDirectory = other.FTPCustomBaseDirectory;
		this.FTPSMode = other.FTPSMode;
		this.FTPPort = other.FTPPort;
		this.FTPMaxConnections = other.FTPMaxConnections;
		this.FTPAcceptInvalidSSL = other.FTPAcceptInvalidSSL;
	}

	public AzureDestinationLocation GetEmbeddedAzureDestinationLocation() => new AzureDestinationLocation {
		AZBAccountName = this.AZBAccountName,
		AZBAccountKey = this.AZBAccountKey,
		AZBContainer = this.AZBContainer,
		AZBRealm = this.AZBRealm,
		AZBPrefix = this.AZBPrefix,
	};

	public void SetEmbeddedAzureDestinationLocation(AzureDestinationLocation other){
		this.AZBAccountName = other.AZBAccountName;
		this.AZBAccountKey = other.AZBAccountKey;
		this.AZBContainer = other.AZBContainer;
		this.AZBRealm = other.AZBRealm;
		this.AZBPrefix = other.AZBPrefix;
	}

	public LocalDestinationLocation GetEmbeddedLocalDestinationLocation() => new LocalDestinationLocation {
		LocalcopyPath = this.LocalcopyPath,
		LocalcopyWinSMBUsername = this.LocalcopyWinSMBUsername,
		LocalcopyWinSMBPassword = this.LocalcopyWinSMBPassword,
		LocalcopyWinSMBPasswordFormat = this.LocalcopyWinSMBPasswordFormat,
	};

	public void SetEmbeddedLocalDestinationLocation(LocalDestinationLocation other){
		this.LocalcopyPath = other.LocalcopyPath;
		this.LocalcopyWinSMBUsername = other.LocalcopyWinSMBUsername;
		this.LocalcopyWinSMBPassword = other.LocalcopyWinSMBPassword;
		this.LocalcopyWinSMBPasswordFormat = other.LocalcopyWinSMBPasswordFormat;
	}

	public SpannedDestinationLocation GetEmbeddedSpannedDestinationLocation() => new SpannedDestinationLocation {
		SpanTargets = this.SpanTargets,
		SpanUseStaticSlots = this.SpanUseStaticSlots,
	};

	public void SetEmbeddedSpannedDestinationLocation(SpannedDestinationLocation other){
		this.SpanTargets = other.SpanTargets;
		this.SpanUseStaticSlots = other.SpanUseStaticSlots;
	}

}
}
