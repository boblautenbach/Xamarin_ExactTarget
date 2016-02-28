using System;

namespace ExactTarget.Push{
	public enum LocationUpdateAppState : int
	{
		/// <summary>
		/// The background
		/// </summary>
		Background,
		/// <summary>
		/// The foreground
		/// </summary>
		Foreground,
	}
	public enum GenericUpdateSendMethod : int
	{
		/// <summary>
		/// The get
		/// </summary>
		Get,
		/// <summary>
		/// The post
		/// </summary>
		Post,
		/// <summary>
		/// The put
		/// </summary>
		Put,
		/// <summary>
		/// The delete
		/// </summary>
		Delete
	}

	partial class Constants
	{
		/// <summary>
		/// The et request base URL
		/// </summary>
		const string ETRequestBaseURL = @"https://consumer.exacttargetapis.com";
	}
/// <summary>
/// Enumeration to keep track of if the request is for Geofences or Proximity messages. 
/// </summary>
public enum ETRegionRequestType : uint
{
	/// <summary>
	/// The unknown
	/// </summary>
	Unknown,
	/// <summary>
	/// The geofence
	/// </summary>
	Geofence,
	/// <summary>
	/// The proximity
	/// </summary>
	Proximity,
}

/// <summary>
/// Enumeration of the type of ETRegion that this is - Circle (Geofence) or Proximity (ibeacon). Polygon is not currently used.
/// </summary>
public enum MobilePushGeofenceType : uint
{
	/// <summary>
	/// The none
	/// </summary>
	None = 0,
	/// <summary>
	/// The circle
	/// </summary>
	Circle,
	/// <summary>
	/// The polygon
	/// </summary>
	[Obsolete]
	Polygon, // Not currently in use.
	/// <summary>
	/// The proximity
	/// </summary>
	Proximity,
}

	public enum MobilePushMessageType : uint
	{
		Unknown,
		Basic,
		Enhanced,
		FenceEntry,
		FenceExit,
		Proximity
	}

	public enum MobilePushContentType : uint
	{
		None = 0,
		AlertMessage = 1 << 0,
		Page = 1 << 1
	}

	public enum MPMessageSource : uint
	{
		Database,
		Remote
	}

	public enum MobilePushMessageFrequencyUnit : uint
	{
		None,
		Year,
		Month,
		Week,
		Day,
		Hour
	}
partial class Constants
{
	/// <summary>
	/// The et app id
	/// </summary>
	const string ETAppID = @"ETAppID";
	/// <summary>
	/// The access token
	/// </summary>
	const string AccessToken = @"AccessToken";
	/// <summary>
	/// The device token
	/// </summary>
	const string DeviceToken = @"DeviceToken";
	/// <summary>
	/// The device identifier
	/// </summary>
	const string DeviceIdentifier = @"DeviceID";
	/// <summary>
	/// The subscriber key
	/// </summary>
	const string SubscriberKey = @"SubscriberKey";

	/// <summary>
	/// The tags
	/// </summary>
	const string Tags = @"Tags";
	/// <summary>
	/// The attributes
	/// </summary>
	const string Attributes = @"Attributes";

	/// <summary>
	/// The cache delimeter
	/// </summary>
	const string CacheDelimeter = @"|^|";
	/// <summary>
	/// The cache key value delimeter
	/// </summary>
	const string CacheKeyValueDelimeter = @"|:|";
}

}

