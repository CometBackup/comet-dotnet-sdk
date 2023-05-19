// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>DestinationLocation</c>
/// </summary>
public class DestinationLocation {
	public ulong DestinationType { get; set; }
	public string CometServer { get; set; } = string.Empty;
	public string CometBucket { get; set; } = string.Empty;
	public string CometBucketKey { get; set; } = string.Empty;
	public string S3Server { get; set; } = string.Empty;
	public bool S3UsesTLS { get; set; }
	public string S3AccessKey { get; set; } = string.Empty;
	public string S3SecretKey { get; set; } = string.Empty;
	public string S3BucketName { get; set; } = string.Empty;
	public string S3Subdir { get; set; } = string.Empty;
	public string S3CustomRegion { get; set; } = string.Empty;
	public bool S3UsesV2Signing { get; set; }
	public bool S3RemoveDeleted { get; set; }
	public long S3ObjectLockDays { get; set; }
	public string SFTPServer { get; set; } = string.Empty;
	public string SFTPUsername { get; set; } = string.Empty;
	public string SFTPRemotePath { get; set; } = string.Empty;
	public ulong SFTPAuthMode { get; set; }
	public string SFTPPassword { get; set; } = string.Empty;
	public string SFTPPrivateKey { get; set; } = string.Empty;
	public bool SFTPCustomAuth_UseKnownHostsFile { get; set; }
	public string SFTPCustomAuth_KnownHostsFile { get; set; } = string.Empty;
	public string FTPServer { get; set; } = string.Empty;
	public string FTPUsername { get; set; } = string.Empty;
	public string FTPPassword { get; set; } = string.Empty;
	public bool FTPBaseUseHomeDirectory { get; set; }
	public string FTPCustomBaseDirectory { get; set; } = string.Empty;
	public long FTPSMode { get; set; }
	public long FTPPort { get; set; }
	public long FTPMaxConnections { get; set; }
	public bool FTPAcceptInvalidSSL { get; set; }
	public string AZBAccountName { get; set; } = string.Empty;
	public string AZBAccountKey { get; set; } = string.Empty;
	public string AZBContainer { get; set; } = string.Empty;
	public string AZBRealm { get; set; } = string.Empty;
	public string AZBPrefix { get; set; } = string.Empty;
	public string LocalcopyPath { get; set; } = string.Empty;
	public string LocalcopyWinSMBUsername { get; set; } = string.Empty;
	public string LocalcopyWinSMBPassword { get; set; } = string.Empty;
	public ulong LocalcopyWinSMBPasswordFormat { get; set; }
	public SwiftDestinationLocation Swift { get; set; }
	public B2DestinationLocation B2 { get; set; }
	public StorjDestinationLocation Storj { get; set; }
	public List<DestinationLocation> SpanTargets { get; set; }
	public bool SpanUseStaticSlots { get; set; }

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
