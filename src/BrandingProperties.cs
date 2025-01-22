// AUTOGENERATED, DO NOT EDIT

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CometBackup.CometAPI.SDK {
/// <summary>
/// Class <c>BrandingProperties</c>
/// </summary>
public class BrandingProperties {

	[JsonPropertyName("ProductName")]
	public string ProductName { get; set; } = string.Empty;

	[JsonPropertyName("CompanyName")]
	public string CompanyName { get; set; } = string.Empty;

	[JsonPropertyName("HelpURL")]
	public string HelpURL { get; set; } = string.Empty;

	[JsonPropertyName("HelpIsPopup")]
	public bool HelpIsPopup { get; set; }

	[JsonPropertyName("DefaultLoginServerURL")]
	public string DefaultLoginServerURL { get; set; } = string.Empty;

	[JsonPropertyName("TileBackgroundColor")]
	public string TileBackgroundColor { get; set; } = string.Empty;

	[JsonPropertyName("AccountRegisterURL")]
	public string AccountRegisterURL { get; set; } = string.Empty;

	[JsonPropertyName("HideBackgroundLogo")]
	public bool HideBackgroundLogo { get; set; }

	[JsonPropertyName("CloudStorageName")]
	public string CloudStorageName { get; set; } = string.Empty;

	[JsonPropertyName("AdminHidePreBuiltClientOption")]
	public bool AdminHidePreBuiltClientOption { get; set; }

	[JsonPropertyName("AdminHideBrandedCloudStorage")]
	public bool AdminHideBrandedCloudStorage { get; set; }

	[JsonPropertyName("BuildMode")]
	//One of the CLIENTBRANDINGBUILD_ constants
	public long BuildMode { get; set; }

	[JsonPropertyName("PathIcoFile")]
	public string PathIcoFile { get; set; } = string.Empty;

	[JsonPropertyName("PathIcnsFile")]
	public string PathIcnsFile { get; set; } = string.Empty;

	[JsonPropertyName("PathMenuBarIcnsFile")]
	public string PathMenuBarIcnsFile { get; set; } = string.Empty;

	[JsonPropertyName("PathEulaRtf")]
	public string PathEulaRtf { get; set; } = string.Empty;

	[JsonPropertyName("PathTilePng")]
	public string PathTilePng { get; set; } = string.Empty;

	[JsonPropertyName("PathHeaderImage")]
	public string PathHeaderImage { get; set; } = string.Empty;

	[JsonPropertyName("PathAppIconImage")]
	public string PathAppIconImage { get; set; } = string.Empty;

	[JsonPropertyName("PackageIdentifier")]
	public string PackageIdentifier { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignMethod")]
	//One of the WINDOWSCODESIGN_METHOD_ constants
	public long WindowsCodeSignMethod { get; set; }

	[JsonPropertyName("WindowsCodeSignPKCS12FilePath")]
	public string WindowsCodeSignPKCS12FilePath { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS12PasswordFormat")]
	//One of the ENCRYPTIONMETHOD_ constants
	public ulong WindowsCodeSignPKCS12PasswordFormat { get; set; }

	[JsonPropertyName("WindowsCodeSignPKCS12Password")]
	public string WindowsCodeSignPKCS12Password { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11Engine")]
	public string WindowsCodeSignPKCS11Engine { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11Module")]
	public string WindowsCodeSignPKCS11Module { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11Certfile")]
	//This field was deprecated between 23.3.0 and 23.6.x, but is now used again.
	public string WindowsCodeSignPKCS11Certfile { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11KeyID")]
	public string WindowsCodeSignPKCS11KeyID { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignPKCS11PasswordFormat")]
	//One of the ENCRYPTIONMETHOD_ constants
	public ulong WindowsCodeSignPKCS11PasswordFormat { get; set; }

	[JsonPropertyName("WindowsCodeSignPKCS11Password")]
	public string WindowsCodeSignPKCS11Password { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureVaultName")]
	public string WindowsCodeSignAzureVaultName { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureCertName")]
	public string WindowsCodeSignAzureCertName { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureAppID")]
	public string WindowsCodeSignAzureAppID { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureAppSecretFormat")]
	//One of the ENCRYPTIONMETHOD_ constants
	public ulong WindowsCodeSignAzureAppSecretFormat { get; set; }

	[JsonPropertyName("WindowsCodeSignAzureAppSecret")]
	public string WindowsCodeSignAzureAppSecret { get; set; } = string.Empty;

	[JsonPropertyName("WindowsCodeSignAzureTenantID")]
	public string WindowsCodeSignAzureTenantID { get; set; } = string.Empty;

	[JsonPropertyName("MacOSCodeSign")]
	public MacOSCodeSignProperties MacOSCodeSign { get; set; }

	public BrandingProperties(){ }

	public string ToJson() {
		return JsonSerializer.Serialize(this);
	}

	static public BrandingProperties FromJson(string jsStr) {
		return JsonSerializer.Deserialize<BrandingProperties>(jsStr);
	}

	public PublicBrandingProperties GetEmbeddedPublicBrandingProperties() => new PublicBrandingProperties {
		ProductName = this.ProductName,
		CompanyName = this.CompanyName,
		HelpURL = this.HelpURL,
		HelpIsPopup = this.HelpIsPopup,
		DefaultLoginServerURL = this.DefaultLoginServerURL,
		TileBackgroundColor = this.TileBackgroundColor,
		AccountRegisterURL = this.AccountRegisterURL,
		HideBackgroundLogo = this.HideBackgroundLogo,
		CloudStorageName = this.CloudStorageName,
		AdminHidePreBuiltClientOption = this.AdminHidePreBuiltClientOption,
		AdminHideBrandedCloudStorage = this.AdminHideBrandedCloudStorage,
	};

	public void SetEmbeddedPublicBrandingProperties(PublicBrandingProperties other){
		this.ProductName = other.ProductName;
		this.CompanyName = other.CompanyName;
		this.HelpURL = other.HelpURL;
		this.HelpIsPopup = other.HelpIsPopup;
		this.DefaultLoginServerURL = other.DefaultLoginServerURL;
		this.TileBackgroundColor = other.TileBackgroundColor;
		this.AccountRegisterURL = other.AccountRegisterURL;
		this.HideBackgroundLogo = other.HideBackgroundLogo;
		this.CloudStorageName = other.CloudStorageName;
		this.AdminHidePreBuiltClientOption = other.AdminHidePreBuiltClientOption;
		this.AdminHideBrandedCloudStorage = other.AdminHideBrandedCloudStorage;
	}

	public PrivateBrandingProperties GetEmbeddedPrivateBrandingProperties() => new PrivateBrandingProperties {
		BuildMode = this.BuildMode,
		PathIcoFile = this.PathIcoFile,
		PathIcnsFile = this.PathIcnsFile,
		PathMenuBarIcnsFile = this.PathMenuBarIcnsFile,
		PathEulaRtf = this.PathEulaRtf,
		PathTilePng = this.PathTilePng,
		PathHeaderImage = this.PathHeaderImage,
		PathAppIconImage = this.PathAppIconImage,
		PackageIdentifier = this.PackageIdentifier,
		WindowsCodeSignMethod = this.WindowsCodeSignMethod,
		WindowsCodeSignPKCS12FilePath = this.WindowsCodeSignPKCS12FilePath,
		WindowsCodeSignPKCS12PasswordFormat = this.WindowsCodeSignPKCS12PasswordFormat,
		WindowsCodeSignPKCS12Password = this.WindowsCodeSignPKCS12Password,
		WindowsCodeSignPKCS11Engine = this.WindowsCodeSignPKCS11Engine,
		WindowsCodeSignPKCS11Module = this.WindowsCodeSignPKCS11Module,
		WindowsCodeSignPKCS11Certfile = this.WindowsCodeSignPKCS11Certfile,
		WindowsCodeSignPKCS11KeyID = this.WindowsCodeSignPKCS11KeyID,
		WindowsCodeSignPKCS11PasswordFormat = this.WindowsCodeSignPKCS11PasswordFormat,
		WindowsCodeSignPKCS11Password = this.WindowsCodeSignPKCS11Password,
		WindowsCodeSignAzureVaultName = this.WindowsCodeSignAzureVaultName,
		WindowsCodeSignAzureCertName = this.WindowsCodeSignAzureCertName,
		WindowsCodeSignAzureAppID = this.WindowsCodeSignAzureAppID,
		WindowsCodeSignAzureAppSecretFormat = this.WindowsCodeSignAzureAppSecretFormat,
		WindowsCodeSignAzureAppSecret = this.WindowsCodeSignAzureAppSecret,
		WindowsCodeSignAzureTenantID = this.WindowsCodeSignAzureTenantID,
		MacOSCodeSign = this.MacOSCodeSign,
	};

	public void SetEmbeddedPrivateBrandingProperties(PrivateBrandingProperties other){
		this.BuildMode = other.BuildMode;
		this.PathIcoFile = other.PathIcoFile;
		this.PathIcnsFile = other.PathIcnsFile;
		this.PathMenuBarIcnsFile = other.PathMenuBarIcnsFile;
		this.PathEulaRtf = other.PathEulaRtf;
		this.PathTilePng = other.PathTilePng;
		this.PathHeaderImage = other.PathHeaderImage;
		this.PathAppIconImage = other.PathAppIconImage;
		this.PackageIdentifier = other.PackageIdentifier;
		this.WindowsCodeSignMethod = other.WindowsCodeSignMethod;
		this.WindowsCodeSignPKCS12FilePath = other.WindowsCodeSignPKCS12FilePath;
		this.WindowsCodeSignPKCS12PasswordFormat = other.WindowsCodeSignPKCS12PasswordFormat;
		this.WindowsCodeSignPKCS12Password = other.WindowsCodeSignPKCS12Password;
		this.WindowsCodeSignPKCS11Engine = other.WindowsCodeSignPKCS11Engine;
		this.WindowsCodeSignPKCS11Module = other.WindowsCodeSignPKCS11Module;
		this.WindowsCodeSignPKCS11Certfile = other.WindowsCodeSignPKCS11Certfile;
		this.WindowsCodeSignPKCS11KeyID = other.WindowsCodeSignPKCS11KeyID;
		this.WindowsCodeSignPKCS11PasswordFormat = other.WindowsCodeSignPKCS11PasswordFormat;
		this.WindowsCodeSignPKCS11Password = other.WindowsCodeSignPKCS11Password;
		this.WindowsCodeSignAzureVaultName = other.WindowsCodeSignAzureVaultName;
		this.WindowsCodeSignAzureCertName = other.WindowsCodeSignAzureCertName;
		this.WindowsCodeSignAzureAppID = other.WindowsCodeSignAzureAppID;
		this.WindowsCodeSignAzureAppSecretFormat = other.WindowsCodeSignAzureAppSecretFormat;
		this.WindowsCodeSignAzureAppSecret = other.WindowsCodeSignAzureAppSecret;
		this.WindowsCodeSignAzureTenantID = other.WindowsCodeSignAzureTenantID;
		this.MacOSCodeSign = other.MacOSCodeSign;
	}

}
}
