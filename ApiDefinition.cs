using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreLocation;
using Mono.Data.Sqlite;

namespace ExactTarget.Push
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
	/// <summary>
	/// LocationUpdateAppState
	/// </summary>

	// @protocol ETGenericUpdateObjectProtocol <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	public partial interface ETGenericUpdateObjectProtocol
	{
		// @required +(instancetype)alloc;
		[Export ("alloc")]
		ETGenericUpdateObjectProtocol Alloc ();

		// @required -(instancetype)initFromDictionary:(NSDictionary *)dict;
		[Export ("initFromDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// @required +(NSString *)remoteRoutePath;
		[Export ("remoteRoutePath")]
		//[Verify (MethodToProperty)]
		string RemoteRoutePath { get; }


		// @required +(NSString *)tableName;
		[Export ("tableName")]
		//[Verify (MethodToProperty)]
		string TableName { get; }


		// @required -(NSString *)jsonPayloadAsString;
		[Export ("jsonPayloadAsString")]
		//[Verify (MethodToProperty)]
		string JsonPayloadAsString { get; }

		// @required -(NSDictionary *)jsonPayloadAsDictionary;
		[Export ("jsonPayloadAsDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonPayloadAsDictionary { get; }

		// @required -(GenericUpdateSendMethod)sendMethod;
		[Export ("sendMethod")]
		//[Verify (MethodToProperty)]
		GenericUpdateSendMethod SendMethod { get; }
	}

	// @interface ETGenericUpdate : NSObject
	[BaseType (typeof(NSObject))]
	interface ETGenericUpdate
	{
		// @property (nonatomic) int tag;
		[Export ("tag")]
		int Tag { get; set; }

		// @property (nonatomic) NSInteger databaseIdentifier;
		[Export ("databaseIdentifier")]
		nint DatabaseIdentifier { get; set; }

		// @property (nonatomic, strong) NSMutableData * responseData;
		[Export ("responseData", ArgumentSemantic.Strong)]
		NSMutableData ResponseData { get; set; }

		// @property (nonatomic, strong) NSHTTPURLResponse * responseCode;
		[Export ("responseCode", ArgumentSemantic.Strong)]
		NSHttpUrlResponse ResponseCode { get; set; }

		// @property (assign, nonatomic) UIBackgroundTaskIdentifier backgroundTaskID;
		[Export ("backgroundTaskID")]
		nuint BackgroundTaskID { get; set; }

		// -(GenericUpdateSendMethod)sendMethod;
		[Export ("sendMethod")]
		//[Verify (MethodToProperty)]
		GenericUpdateSendMethod SendMethod { get; }

		// -(NSString *)remoteRoutePath;
		[Export ("remoteRoutePath")]
		//[Verify (MethodToProperty)]
		string RemoteRoutePath { get; }

		// -(NSString *)jsonPayloadAsString;
		[Export ("jsonPayloadAsString")]
		//[Verify (MethodToProperty)]
		string JsonPayloadAsString { get; }

		// -(NSDictionary *)jsonPayloadAsDictionary;
		[Export ("jsonPayloadAsDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonPayloadAsDictionary { get; }

		// -(void)processResults;
		[Export ("processResults")]
		void ProcessResults ();

		// -(void)handleDataFailure;
		[Export ("handleDataFailure")]
		void HandleDataFailure ();

		// -(BOOL)shouldSaveSelfToDatabase;
		[Export ("shouldSaveSelfToDatabase")]
		//[Verify (MethodToProperty)]
		bool ShouldSaveSelfToDatabase { get; }

		// -(int)dbVersionNumber;
		[Export ("dbVersionNumber")]
		//[Verify (MethodToProperty)]
		int DbVersionNumber { get; }

		// -(NSString *)databaseVersionKey;
		[Export ("databaseVersionKey")]
		//[Verify (MethodToProperty)]
		string DatabaseVersionKey { get; }

		// -(BOOL)generatePersistentDataSchemaInDatabase;
		[Export ("generatePersistentDataSchemaInDatabase")]
		//[Verify (MethodToProperty)]
		bool GeneratePersistentDataSchemaInDatabase { get; }

		// -(NSArray *)insertQueryArguments;
		[Export ("insertQueryArguments")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] InsertQueryArguments { get; }

		// -(NSArray *)updateQueryArguments;
		[Export ("updateQueryArguments")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] UpdateQueryArguments { get; }

		// -(NSString *)insertQuerySyntax;
		[Export ("insertQuerySyntax")]
		//[Verify (MethodToProperty)]
		string InsertQuerySyntax { get; }

		// -(NSString *)updateQuerySyntax;
		[Export ("updateQuerySyntax")]
		//[Verify (MethodToProperty)]
		string UpdateQuerySyntax { get; }

		// -(BOOL)insertSelfIntoDatabase;
		[Export ("insertSelfIntoDatabase")]
		//[Verify (MethodToProperty)]
		bool InsertSelfIntoDatabase { get; }

		// -(NSString *)tableName;
		[Export ("tableName")]
		//[Verify (MethodToProperty)]
		string TableName { get; }


		// +(NSDateFormatter *)formatterOfCorrectFormat;
		[Static]
		[Export ("formatterOfCorrectFormat")]
		//[Verify (MethodToProperty)]
		NSDateFormatter FormatterOfCorrectFormat { get; }

		// +(NSDateFormatter *)alternativeFormatterOfCorrectFormat;
		[Static]
		[Export ("alternativeFormatterOfCorrectFormat")]
		//[Verify (MethodToProperty)]
		NSDateFormatter AlternativeFormatterOfCorrectFormat { get; }

		// +(NSDate *)dateFromString:(NSString *)dateAsString;
		[Static]
		[Export ("dateFromString:")]
		NSDate DateFromString (string dateAsString);

		// +(NSString *)stringFromDate:(NSDate *)date;
		[Static]
		[Export ("stringFromDate:")]
		string StringFromDate (NSDate date);

		// +(NSNumberFormatter *)numberFormatterOfCorrectFormatForDouble;
		[Static]
		[Export ("numberFormatterOfCorrectFormatForDouble")]
		//[Verify (MethodToProperty)]
		NSNumberFormatter NumberFormatterOfCorrectFormatForDouble { get; }
	}

	// @interface ETKeyValueStore : NSObject
	[BaseType (typeof(NSObject))]
	interface ETKeyValueStore
	{
		// +(BOOL)setValue:(NSString *)value forKey:(NSString *)key;
		[Static]
		[Export ("setValue:forKey:")]
		bool SetValue (string value, string key);

		// +(NSString *)valueForKey:(NSString *)key;
		[Static]
		[Export ("valueForKey:")]
		string ValueForKey (string key);
	}

	// @interface ETLandingPagePresenter : UIViewController <UIWebViewDelegate>
	[BaseType (typeof(UIViewController))]
	interface ETLandingPagePresenter : IUIWebViewDelegate
	{
		// @property (copy, nonatomic) NSString * landingPagePath;
		[Export ("landingPagePath")]
		string LandingPagePath { get; set; }

		// -(id)initForLandingPageAt:(NSString *)landingPage;
		[Export ("initForLandingPageAt:")]
		IntPtr Constructor (string landingPage);

		// -(id)initForLandingPageAtWithURL:(NSURL *)landingPage;
		[Export ("initForLandingPageAtWithURL:")]
		IntPtr Constructor (NSUrl landingPage);
	}

	// @interface ETLocationUpdate : ETGenericUpdate
	[BaseType (typeof(ETGenericUpdate))]
	interface ETLocationUpdate
	{
		// @property (nonatomic) CLLocation * location;
		[Export ("location", ArgumentSemantic.Assign)]
		CLLocation Location { get; set; }

		// @property (nonatomic, strong) NSDate * eventDateTime;
		[Export ("eventDateTime", ArgumentSemantic.Strong)]
		NSDate EventDateTime { get; set; }

		// @property (nonatomic) NSNumber * latitude;
		[Export ("latitude", ArgumentSemantic.Assign)]
		NSNumber Latitude { get; set; }

		// @property (nonatomic) NSNumber * longitude;
		[Export ("longitude", ArgumentSemantic.Assign)]
		NSNumber Longitude { get; set; }

		// @property (nonatomic) NSNumber * accuracy;
		[Export ("accuracy", ArgumentSemantic.Assign)]
		NSNumber Accuracy { get; set; }

		// @property (nonatomic) LocationUpdateAppState appState;
		[Export ("appState", ArgumentSemantic.Assign)]
		LocationUpdateAppState AppState { get; set; }

		// +(BOOL)generatePersistentDataSchemaInDatabase;
		[Static]
		[Export ("generatePersistentDataSchemaInDatabase")]
		//[Verify (MethodToProperty)]
		bool GeneratePersistentDataSchemaInDatabase { get; }

		// -(NSString *)tableName;
		[Export ("tableName")]
		//[Verify (MethodToProperty)]
		string TableName { get; }


		// -(id)initWithLocation:(CLLocation *)location forAppState:(LocationUpdateAppState)state;
		[Export ("initWithLocation:forAppState:")]
		IntPtr Constructor (CLLocation location, LocationUpdateAppState state);

		// -(NSString *)remoteRoutePath;
		[Export ("remoteRoutePath")]
		//[Verify (MethodToProperty)]
		string RemoteRoutePath { get; }

		// -(NSString *)formattedDate;
		[Export ("formattedDate")]
		//[Verify (MethodToProperty)]
		string FormattedDate { get; }

		// -(NSString *)jsonPayloadAsString;
		[Export ("jsonPayloadAsString")]
		//[Verify (MethodToProperty)]
		string JsonPayloadAsString { get; }
	}

	// @interface ETRegion : ETGenericUpdate
	[BaseType (typeof(ETGenericUpdate))]
	interface ETRegion
	{
		// @property (nonatomic, strong) NSString * fenceIdentifier;
		[Export ("fenceIdentifier", ArgumentSemantic.Strong)]
		string FenceIdentifier { get; set; }

		// @property (nonatomic, strong) NSNumber * latitude;
		[Export ("latitude", ArgumentSemantic.Strong)]
		NSNumber Latitude { get; set; }

		// @property (nonatomic, strong) NSNumber * longitude;
		[Export ("longitude", ArgumentSemantic.Strong)]
		NSNumber Longitude { get; set; }

		// @property (nonatomic, strong) NSNumber * radius;
		[Export ("radius", ArgumentSemantic.Strong)]
		NSNumber Radius { get; set; }

		// @property (nonatomic, strong) NSMutableArray * messages;
		[Export ("messages", ArgumentSemantic.Strong)]
		NSMutableArray Messages { get; set; }

		// @property (nonatomic, strong) NSString * proximityUUID;
		[Export ("proximityUUID", ArgumentSemantic.Strong)]
		string ProximityUUID { get; set; }

		// @property (nonatomic, strong) NSNumber * majorNumber;
		[Export ("majorNumber", ArgumentSemantic.Strong)]
		NSNumber MajorNumber { get; set; }

		// @property (nonatomic, strong) NSNumber * minorNumber;
		[Export ("minorNumber", ArgumentSemantic.Strong)]
		NSNumber MinorNumber { get; set; }

		// @property (nonatomic, strong) NSNumber * entryCount;
		[Export ("entryCount", ArgumentSemantic.Strong)]
		NSNumber EntryCount { get; set; }

		// @property (nonatomic, strong) NSNumber * exitCount;
		[Export ("exitCount", ArgumentSemantic.Strong)]
		NSNumber ExitCount { get; set; }

		// @property (nonatomic, strong) NSString * regionName;
		[Export ("regionName", ArgumentSemantic.Strong)]
		string RegionName { get; set; }

		// @property (assign, nonatomic) MobilePushGeofenceType locationType;
		[Export ("locationType", ArgumentSemantic.Assign)]
		MobilePushGeofenceType LocationType { get; set; }

		// @property (nonatomic) ETRegionRequestType requestType;
		[Export ("requestType", ArgumentSemantic.Assign)]
		ETRegionRequestType RequestType { get; set; }

		// -(id)initFromDictionary:(NSDictionary *)dict;
		[Export ("initFromDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// -(BOOL)isEqualToRegion:(ETRegion *)region;
		[Export ("isEqualToRegion:")]
		bool IsEqualToRegion (ETRegion region);

		// -(CLLocation *)regionAsLocation;
		[Export ("regionAsLocation")]
		//[Verify (MethodToProperty)]
		CLLocation RegionAsLocation { get; }

		// -(CLRegion *)regionAsCLRegion;
		[Export ("regionAsCLRegion")]
		//[Verify (MethodToProperty)]
		CLRegion RegionAsCLRegion { get; }

		// -(CLBeaconRegion *)regionAsBeaconRegion;
		[Export ("regionAsBeaconRegion")]
		//[Verify (MethodToProperty)]
		CLBeaconRegion RegionAsBeaconRegion { get; }

		// -(BOOL)isGeofenceRegion;
		[Export ("isGeofenceRegion")]
		//[Verify (MethodToProperty)]
		bool IsGeofenceRegion { get; }

		// -(BOOL)isBeaconRegion;
		[Export ("isBeaconRegion")]
		//[Verify (MethodToProperty)]
		bool IsBeaconRegion { get; }

		// +(ETRegion *)getRegionByIdentifier:(NSString *)identifier;
		[Static]
		[Export ("getRegionByIdentifier:")]
		ETRegion GetRegionByIdentifier (string identifier);

		// +(ETRegion *)getBeaconRegionForRegionWithProximityUUID:(NSString *)proximityUUID andMajorNumber:(NSNumber *)majorNumber andMinorNumber:(NSNumber *)minorNumber;
		[Static]
		[Export ("getBeaconRegionForRegionWithProximityUUID:andMajorNumber:andMinorNumber:")]
		ETRegion GetBeaconRegionForRegionWithProximityUUID (string proximityUUID, NSNumber majorNumber, NSNumber minorNumber);

		// +(ETRegion *)getBeaconRegionForRegionWithProximityUUID:(NSString *)proximityUUID;
		[Static]
		[Export ("getBeaconRegionForRegionWithProximityUUID:")]
		ETRegion GetBeaconRegionForRegionWithProximityUUID (string proximityUUID);

		// +(NSSet *)getFencesFromCache;
		[Static]
		[Export ("getFencesFromCache")]
		//[Verify (MethodToProperty)]
		NSSet FencesFromCache { get; }

		// +(NSSet *)getFencesFromCacheIncludingInactive:(BOOL)getInactive;
		[Static]
		[Export ("getFencesFromCacheIncludingInactive:")]
		NSSet GetFencesFromCacheIncludingInactive (bool getInactive);

		// +(BOOL)invalidateAllRegionsForRequestType:(ETRegionRequestType)requestType;
		[Static]
		[Export ("invalidateAllRegionsForRequestType:")]
		bool InvalidateAllRegionsForRequestType (ETRegionRequestType requestType);

		// +(BOOL)invalidateAllRegions;
		[Static]
		[Export ("invalidateAllRegions")]
		//[Verify (MethodToProperty)]
		bool InvalidateAllRegions { get; }

		// +(void)retrieveGeofencesFromET;
		[Static]
		[Export ("retrieveGeofencesFromET")]
		void RetrieveGeofencesFromET ();

		// +(void)retrieveProximityFromET;
		[Static]
		[Export ("retrieveProximityFromET")]
		void RetrieveProximityFromET ();

		// +(BOOL)generatePersistentDataSchemaInDatabase;
		[Static]
		[Export ("generatePersistentDataSchemaInDatabase")]
		//[Verify (MethodToProperty)]
		bool GeneratePersistentDataSchemaInDatabase { get; }
	}

	// @interface ETMessage : ETGenericUpdate
	[BaseType (typeof(ETGenericUpdate))]
	interface ETMessage
	{
		// @property (readonly, nonatomic, strong) NSString * messageIdentifier;
		[Export ("messageIdentifier", ArgumentSemantic.Strong)]
		string MessageIdentifier { get; }

		// @property (nonatomic, strong) NSString * messageName;
		[Export ("messageName", ArgumentSemantic.Strong)]
		string MessageName { get; set; }

		// @property (readonly, nonatomic) MobilePushMessageType messageType;
		[Export ("messageType")]
		MobilePushMessageType MessageType { get; }

		// @property (readonly, nonatomic) MobilePushContentType contentType;
		[Export ("contentType")]
		MobilePushContentType ContentType { get; }

		// @property (readonly, nonatomic, strong) NSString * alert;
		[Export ("alert", ArgumentSemantic.Strong)]
		string Alert { get; }

		// @property (readonly, nonatomic, strong) NSString * sound;
		[Export ("sound", ArgumentSemantic.Strong)]
		string Sound { get; }

		// @property (readonly, nonatomic, strong) NSString * badge;
		[Export ("badge", ArgumentSemantic.Strong)]
		string Badge { get; }

		// @property (readonly, nonatomic, strong) NSString * category;
		[Export ("category", ArgumentSemantic.Strong)]
		string Category { get; }

		// @property (readonly, nonatomic, strong) NSArray * keyValuePairs;
		[Export ("keyValuePairs", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] KeyValuePairs { get; }

		// @property (readonly, nonatomic, strong) NSDate * startDate;
		[Export ("startDate", ArgumentSemantic.Strong)]
		NSDate StartDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * endDate;
		[Export ("endDate", ArgumentSemantic.Strong)]
		NSDate EndDate { get; }

		// @property (readonly, nonatomic, strong) NSString * siteIdentifier;
		[Export ("siteIdentifier", ArgumentSemantic.Strong)]
		string SiteIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSString * siteUrlAsString;
		[Export ("siteUrlAsString", ArgumentSemantic.Strong)]
		string SiteUrlAsString { get; }

		// @property (readonly, nonatomic, strong) NSString * openDirectPayload;
		[Export ("openDirectPayload", ArgumentSemantic.Strong)]
		string OpenDirectPayload { get; }

		// @property (readonly, nonatomic, strong) ETRegion * relatedFence;
		[Export ("relatedFence", ArgumentSemantic.Strong)]
		ETRegion RelatedFence { get; }

		// @property (readonly, nonatomic, strong) NSNumber * messageLimit;
		[Export ("messageLimit", ArgumentSemantic.Strong)]
		NSNumber MessageLimit { get; }

		// @property (readonly, nonatomic, strong) NSNumber * messagesPerPeriod;
		[Export ("messagesPerPeriod", ArgumentSemantic.Strong)]
		NSNumber MessagesPerPeriod { get; }

		// @property (readonly, nonatomic, strong) NSNumber * numberOfPeriods;
		[Export ("numberOfPeriods", ArgumentSemantic.Strong)]
		NSNumber NumberOfPeriods { get; }

		// @property (readonly, nonatomic) MobilePushMessageFrequencyUnit periodType;
		[Export ("periodType")]
		MobilePushMessageFrequencyUnit PeriodType { get; }

		// @property (readonly, getter = isRollingPeriod, nonatomic) BOOL rollingPeriod;
		[Export ("rollingPeriod")]
		bool RollingPeriod { [Bind ("isRollingPeriod")] get; }

		// @property (readonly, nonatomic, strong) NSNumber * minTripped;
		[Export ("minTripped", ArgumentSemantic.Strong)]
		NSNumber MinTripped { get; }

		// @property (readonly, getter = isEphemeralMessage, nonatomic) BOOL ephemeralMessage;
		[Export ("ephemeralMessage")]
		bool EphemeralMessage { [Bind ("isEphemeralMessage")] get; }

		// @property (readonly, nonatomic) CLProximity proximity;
		[Export ("proximity")]
		CLProximity Proximity { get; }

		// @property (readonly, nonatomic) NSInteger loiteringSeconds;
		[Export ("loiteringSeconds")]
		nint LoiteringSeconds { get; }

		// @property (readonly, getter = isRead, nonatomic) BOOL read;
		[Export ("read")]
		bool Read { [Bind ("isRead")] get; }

		// @property (readonly, getter = isActive, nonatomic) BOOL active;
		[Export ("active")]
		bool Active { [Bind ("isActive")] get; }

		// @property (nonatomic, strong) UILocalNotification * notification;
		[Export ("notification", ArgumentSemantic.Strong)]
		UILocalNotification Notification { get; set; }

		// @property (nonatomic) BOOL hasShownForBeacon;
		[Export ("hasShownForBeacon")]
		bool HasShownForBeacon { get; set; }

		// -(instancetype)initFromDictionary:(NSDictionary *)dict;
		[Export ("initFromDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// -(instancetype)initFromDictionary:(NSDictionary *)dict forFence:(ETRegion *)region;
		[Export ("initFromDictionary:forFence:")]
		IntPtr Constructor (NSDictionary dict, ETRegion region);

		// -(NSString *)subject;
		[Export ("subject")]
		//[Verify (MethodToProperty)]
		string Subject { get; }

		// -(NSURL *)siteURL;
		[Export ("siteURL")]
		//[Verify (MethodToProperty)]
		NSUrl SiteURL { get; }

		// -(BOOL)markAsRead;
		[Export ("markAsRead")]
		//[Verify (MethodToProperty)]
		bool MarkAsRead { get; }

		// -(BOOL)messageScheduledForDisplay;
		[Export ("messageScheduledForDisplay")]
		//[Verify (MethodToProperty)]
		bool MessageScheduledForDisplay { get; }

		// -(BOOL)markAsUnread;
		[Export ("markAsUnread")]
		//[Verify (MethodToProperty)]
		bool MarkAsUnread { get; }

		// -(BOOL)markAsDeleted;
		[Export ("markAsDeleted")]
		//[Verify (MethodToProperty)]
		bool MarkAsDeleted { get; }

		// -(NSDate *)getLastShownDate;
		[Export ("getLastShownDate")]
		//[Verify (MethodToProperty)]
		NSDate LastShownDate { get; }

		// -(int)getShowCount;
		[Export ("getShowCount")]
		//[Verify (MethodToProperty)]
		int ShowCount { get; }

		// +(NSArray *)getMessagesByContentType:(MobilePushContentType)contentType;
		[Static]
		[Export ("getMessagesByContentType:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] GetMessagesByContentType (MobilePushContentType contentType);

		// +(ETMessage *)getMessageByIdentifier:(NSString *)identifier;
		[Static]
		[Export ("getMessageByIdentifier:")]
		ETMessage GetMessageByIdentifier (string identifier);

		// +(NSArray *)getMessagesByType:(MobilePushMessageType)type;
		[Static]
		[Export ("getMessagesByType:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] GetMessagesByType (MobilePushMessageType type);

		// +(NSArray *)getMessagesForGeofence:(ETRegion *)fence;
		[Static]
		[Export ("getMessagesForGeofence:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] GetMessagesForGeofence (ETRegion fence);

		// +(NSArray *)getMessagesForGeofence:(ETRegion *)fence andMessageType:(MobilePushMessageType)type;
		[Static]
		[Export ("getMessagesForGeofence:andMessageType:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] GetMessagesForGeofence (ETRegion fence, MobilePushMessageType type);

		// +(NSArray *)getProximityMessagesForRegion:(ETRegion *)region;
		[Static]
		[Export ("getProximityMessagesForRegion:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] GetProximityMessagesForRegion (ETRegion region);

		// +(void)getMessagesFromExactTargetOfMessageType:(MobilePushMessageType)messageType andContentType:(MobilePushContentType)contentType;
		[Static]
		[Export ("getMessagesFromExactTargetOfMessageType:andContentType:")]
		void GetMessagesFromExactTargetOfMessageType (MobilePushMessageType messageType, MobilePushContentType contentType);

		// +(BOOL)invalidateAllMessagesForType:(MobilePushMessageType)type;
		[Static]
		[Export ("invalidateAllMessagesForType:")]
		bool InvalidateAllMessagesForType (MobilePushMessageType type);

		// -(BOOL)isEqualToMessage:(ETMessage *)message;
		[Export ("isEqualToMessage:")]
		bool IsEqualToMessage (ETMessage message);
	}

	// @interface ETLocationManager : NSObject <CLLocationManagerDelegate>
	[BaseType (typeof(NSObject))]
	interface ETLocationManager : ICLLocationManagerDelegate
	{
		// @property (getter = isUpdatingGeofences, nonatomic) BOOL updatingGeofences;
		[Export ("updatingGeofences")]
		bool UpdatingGeofences { [Bind ("isUpdatingGeofences")] get; set; }

		// +(ETLocationManager *)locationManager;
		[Static]
		[Export ("locationManager")]
		//[Verify (MethodToProperty)]
		ETLocationManager LocationManager { get; }

		// -(BOOL)locationEnabled;
		[Export ("locationEnabled")]
		//[Verify (MethodToProperty)]
		bool LocationEnabled { get; }

		// -(void)startWatchingLocation;
		[Export ("startWatchingLocation")]
		void StartWatchingLocation ();

		// -(void)stopWatchingLocation;
		[Export ("stopWatchingLocation")]
		void StopWatchingLocation ();

		// -(void)appInForeground;
		[Export ("appInForeground")]
		void AppInForeground ();

		// -(void)appInBackground;
		[Export ("appInBackground")]
		void AppInBackground ();

		// -(void)updateLocationServerWithLocation:(CLLocation *)loc forAppState:(LocationUpdateAppState)state;
		[Export ("updateLocationServerWithLocation:forAppState:")]
		void UpdateLocationServerWithLocation (CLLocation loc, LocationUpdateAppState state);

		// -(void)monitorRegions:(NSSet *)fences;
		[Export ("monitorRegions:")]
		void MonitorRegions (NSSet fences);

		// -(void)stopMonitoringRegions;
		[Export ("stopMonitoringRegions")]
		void StopMonitoringRegions ();

		// -(void)getAndScheduleAlertsForRegion:(ETRegion *)region andMessageType:(MobilePushMessageType)type;
		[Export ("getAndScheduleAlertsForRegion:andMessageType:")]
		void GetAndScheduleAlertsForRegion (ETRegion region, MobilePushMessageType type);

		// -(NSSet *)monitoredRegions;
		[Export ("monitoredRegions")]
		//[Verify (MethodToProperty)]
		NSSet MonitoredRegions { get; }

		// -(NSDictionary *)lastKnownLocation;
		[Export ("lastKnownLocation")]
		//[Verify (MethodToProperty)]
		NSDictionary LastKnownLocation { get; }

		// -(BOOL)getWatchingLocation;
		[Export ("getWatchingLocation")]
		//[Verify (MethodToProperty)]
		bool WatchingLocation { get; }
	}

	// @protocol ExactTargetOpenDirectDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ExactTargetOpenDirectDelegate
	{
		// @required -(void)didReceiveOpenDirectMessageWithContents:(NSString *)payload;
		[Abstract]
		[Export ("didReceiveOpenDirectMessageWithContents:")]
		void DidReceiveOpenDirectMessageWithContents (string payload);

		// @optional -(BOOL)shouldDeliverOpenDirectMessageIfAppIsRunning;
		[Export ("shouldDeliverOpenDirectMessageIfAppIsRunning")]
		//[Verify (MethodToProperty)]
		bool ShouldDeliverOpenDirectMessageIfAppIsRunning { get; }
	}

	// @interface ETPush : NSObject
	[BaseType (typeof(NSObject))]
	interface ETPush
	{
		// +(ETPush *)pushManager;
		[Static]
		[Export ("pushManager")]
		//[Verify (MethodToProperty)]
		ETPush PushManager { get; }

		// -(void)configureSDKWithAppID:(NSString *)etAppID andAccessToken:(NSString *)accessToken withAnalytics:(BOOL)analyticsState andLocationServices:(BOOL)locState andCloudPages:(BOOL)cpState;
		[Export ("configureSDKWithAppID:andAccessToken:withAnalytics:andLocationServices:andCloudPages:")]
		void ConfigureSDKWithAppID (string etAppID, string accessToken, bool analyticsState, bool locState, bool cpState);

		// -(BOOL)configureSDKWithAppID:(NSString *)etAppID andAccessToken:(NSString *)accessToken withAnalytics:(BOOL)analyticsState andLocationServices:(BOOL)locState andCloudPages:(BOOL)cpState withPIAnalytics:(BOOL)pIAnalyticsState error:(NSError **)configureError;
		[Export ("configureSDKWithAppID:andAccessToken:withAnalytics:andLocationServices:andCloudPages:withPIAnalytics:error:")]
		bool ConfigureSDKWithAppID (string etAppID, string accessToken, bool analyticsState, bool locState, bool cpState, bool pIAnalyticsState, out NSError configureError);

		// -(id<ExactTargetOpenDirectDelegate>)openDirectDelegate;
		// -(void)setOpenDirectDelegate:(id<ExactTargetOpenDirectDelegate>)delegate;
		[Export ("openDirectDelegate")]
		//[Verify (MethodToProperty)]
		ExactTargetOpenDirectDelegate OpenDirectDelegate { get; set; }

		// -(void)updateET;
		[Export ("updateET")]
		void UpdateET ();

		// -(void)registerForRemoteNotifications;
		[Export ("registerForRemoteNotifications")]
		void RegisterForRemoteNotifications ();

		[Export("registerForRemoteNotificationTypes:")]
		void RegisterForRemoteNotificationTypes(UIRemoteNotificationType types);

		// -(BOOL)isRegisteredForRemoteNotifications;
		[Export ("isRegisteredForRemoteNotifications")]
		//[Verify (MethodToProperty)]
		bool IsRegisteredForRemoteNotifications { get; }

		// -(void)registerUserNotificationSettings:(UIUserNotificationSettings *)notificationSettings;
		[Export ("registerUserNotificationSettings:")]
		void RegisterUserNotificationSettings (UIUserNotificationSettings notificationSettings);

		// -(UIUserNotificationSettings *)currentUserNotificationSettings;
		[Export ("currentUserNotificationSettings")]
		//[Verify (MethodToProperty)]
		UIUserNotificationSettings CurrentUserNotificationSettings { get; }

		// -(void)didRegisterUserNotificationSettings:(UIUserNotificationSettings *)notificationSettings;
		[Export ("didRegisterUserNotificationSettings:")]
		void DidRegisterUserNotificationSettings (UIUserNotificationSettings notificationSettings);

		// -(void)registerDeviceToken:(NSData *)deviceToken;
		[Export ("registerDeviceToken:")]
		void RegisterDeviceToken (NSData deviceToken);

		// -(NSString *)deviceToken;
		[Export ("deviceToken")]
		//[Verify (MethodToProperty)]
		string DeviceToken { get; }

		// -(void)applicationDidFailToRegisterForRemoteNotificationsWithError:(NSError *)error;
		[Export ("applicationDidFailToRegisterForRemoteNotificationsWithError:")]
		void ApplicationDidFailToRegisterForRemoteNotificationsWithError (NSError error);

		// -(void)resetBadgeCount;
		[Export ("resetBadgeCount")]
		void ResetBadgeCount ();

		// -(void)shouldDisplayAlertViewIfPushReceived:(BOOL)desiredState;
		[Export ("shouldDisplayAlertViewIfPushReceived:")]
		void ShouldDisplayAlertViewIfPushReceived (bool desiredState);

		// -(void)applicationLaunchedWithOptions:(NSDictionary *)launchOptions;
		[Export ("applicationLaunchedWithOptions:")]
		void ApplicationLaunchedWithOptions (NSDictionary launchOptions);

		// -(void)applicationTerminated;
		[Export ("applicationTerminated")]
		void ApplicationTerminated ();

		// -(void)handleNotification:(NSDictionary *)userInfo forApplicationState:(UIApplicationState)applicationState;
		[Export ("handleNotification:forApplicationState:")]
		void HandleNotification (NSDictionary userInfo, UIApplicationState applicationState);

		// -(void)handleLocalNotification:(UILocalNotification *)notification;
		[Export ("handleLocalNotification:")]
		void HandleLocalNotification (UILocalNotification notification);

		// -(void)setSubscriberKey:(NSString *)subscriberKey;
		[Export ("setSubscriberKey:")]
		void SetSubscriberKey (string subscriberKey);

		// -(NSString *)getSubscriberKey;
		[Export ("getSubscriberKey")]
		//[Verify (MethodToProperty)]
		string SubscriberKey { get; }

		// -(void)addTag:(NSString *)tag;
		[Export ("addTag:")]
		void AddTag (string tag);

		// -(NSString *)removeTag:(NSString *)tag;
		[Export ("removeTag:")]
		string RemoveTag (string tag);

		// -(NSSet *)allTags;
		[Export ("allTags")]
		//[Verify (MethodToProperty)]
		NSSet AllTags { get; }

		// -(void)addAttributeNamed:(NSString *)name value:(NSString *)value;
		[Export ("addAttributeNamed:value:")]
		void AddAttributeNamed (string name, string value);

		// -(NSString *)removeAttributeNamed:(NSString *)name;
		[Export ("removeAttributeNamed:")]
		string RemoveAttributeNamed (string name);

		// -(NSDictionary *)allAttributes;
		[Export ("allAttributes")]
		//[Verify (MethodToProperty)]
		NSDictionary AllAttributes { get; }

		// +(NSString *)safeDeviceIdentifier;
		[Static]
		[Export ("safeDeviceIdentifier")]
		//[Verify (MethodToProperty)]
		string SafeDeviceIdentifier { get; }

		// +(NSString *)hardwareIdentifier;
		[Static]
		[Export ("hardwareIdentifier")]
		//[Verify (MethodToProperty)]
		string HardwareIdentifier { get; }

		// +(BOOL)isPushEnabled;
		[Static]
		[Export ("isPushEnabled")]
		//[Verify (MethodToProperty)]
		bool IsPushEnabled { get; }

		// -(void)startListeningForApplicationNotifications;
		[Export ("startListeningForApplicationNotifications")]
		void StartListeningForApplicationNotifications ();

		// -(void)stopListeningForApplicationNotifications;
		[Export ("stopListeningForApplicationNotifications")]
		void StopListeningForApplicationNotifications ();

		// -(void)applicationDidBecomeActiveNotificationReceived;
		[Export ("applicationDidBecomeActiveNotificationReceived")]
		void ApplicationDidBecomeActiveNotificationReceived ();

		// -(void)applicationDidEnterBackgroundNotificationReceived;
		[Export ("applicationDidEnterBackgroundNotificationReceived")]
		void ApplicationDidEnterBackgroundNotificationReceived ();

		// -(_Bool)setWebAndMobileAnalyticsTitle:(NSString *)title andURL:(NSString *)url andItem:(NSString *)item andSearch:(NSString *)search;
		[Export ("setWebAndMobileAnalyticsTitle:andURL:andItem:andSearch:")]
		bool SetWebAndMobileAnalyticsTitle (string title, string url, string item, string search);

		// +(void)setETLoggerToRequiredState:(BOOL)state;
		[Static]
		[Export ("setETLoggerToRequiredState:")]
		void SetETLoggerToRequiredState (bool state);

		// +(void)ETLogger:(NSString *)stringToBeLogged;
		[Static]
		[Export ("ETLogger:")]
		void ETLogger (string stringToBeLogged);
	}

	// @interface ETSqliteHelper : NSObject
	[BaseType(typeof(NSObject))]
	//[DisableDefaultCtor]
	public partial interface ETSqliteHelper
	{
		// sqlite3 *_db;

		/// <summary>
		/// Constructors this instance.
		/// </summary>
		/// <returns></returns>
		//[Export("init")]
		//IntPtr Constructor();

		/// <summary>
		/// Gets or sets the max retries.
		/// </summary>
		/// <value>
		/// The max retries.
		/// </value>
		[Export("maxRetries")]
		int MaxRetries { get; set; }

		/// <summary>
		/// Gets the max retries.
		/// </summary>
		/// <value>
		/// The max retries.
		/// </value>
		[Export("database")]
		ETSqliteHelper Database { get; }

		/// <summary>
		/// Opens this instance.
		/// </summary>
		/// <returns></returns>
		[Export("open")]
		bool Open();

		/// <summary>
		/// Closes this instance.
		/// </summary>
		[Export("close")]
		void Close();

		/// <summary>
		/// Gets the last error message.
		/// </summary>
		/// <value>
		/// The last error message.
		/// </value>
		[Export("lastErrorMessage")]
		string LastErrorMessage { get; }

		/// <summary>
		/// Gets the last error code.
		/// </summary>
		/// <value>
		/// The last error code.
		/// </value>
		[Export("lastErrorCode")]
		int LastErrorCode { get; }

		/// <summary>
		/// Gets the rows affected.
		/// </summary>
		/// <value>
		/// The rows affected.
		/// </value>
		[Export("rowsAffected")]
		int RowsAffected { get; }

		/// <summary>
		/// Executes the query.
		/// </summary>
		/// <param name="sql">The SQL.</param>
		/// <param name="args">The args.</param>
		/// <returns></returns>
		//[Obsolete]
		//[Export("executeQuery:")]
		//NSObject[] ExecuteQuery(string sql, params object[] args);

		/// <summary>
		/// Executes the query.
		/// </summary>
		/// <param name="sql">The SQL.</param>
		/// <param name="args">The args.</param>
		/// <returns></returns>
		[Export("executeQuery:arguments:")]
		NSObject[] ExecuteQuery(string sql, params NSObject[] args);

		/// <summary>
		/// Executes the query.
		/// </summary>
		/// <param name="sql">The SQL.</param>
		/// <param name="args">The args.</param>
		/// <returns></returns>
		//[Obsolete]
		//[Export("executeUpdate:")]
		//bool ExecuteUpdate(string sql, params object[] args);

		/// <summary>
		/// Executes the query.
		/// </summary>
		/// <param name="sql">The SQL.</param>
		/// <param name="arguments">The arguments.</param>
		/// <returns></returns>
		[Export("executeUpdate:arguments:")]
		bool ExecuteUpdate(string sql, params NSObject[] arguments);

		/// <summary>
		/// Tables the exists.
		/// </summary>
		/// <param name="tableName">Name of the table.</param>
		/// <returns></returns>
		[Export("tableExists:")]
		bool TableExists(string tableName);

		/// <summary>
		/// Begins the transaction.
		/// </summary>
		/// <returns></returns>
		[Export("beginTransaction")]
		bool BeginTransaction();

		/// <summary>
		/// Commits the transaction.
		/// </summary>
		/// <returns></returns>
		[Export("commitTransaction")]
		bool CommitTransaction();

		/// <summary>
		/// Rollbacks the transaction.
		/// </summary>
		/// <returns></returns>
		[Export("rollbackTransaction")]
		bool RollbackTransaction();
	}

	// @interface ExactTargetEnhancedPushDataSource : NSObject <UITableViewDataSource>
	[BaseType (typeof(NSObject))]
	interface ExactTargetEnhancedPushDataSource : IUITableViewDataSource
	{
		// @property (nonatomic, strong) NSArray * messages;
		[Export ("messages", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Messages { get; set; }

		// @property (nonatomic, weak) UITableView * _Nullable inboxTableView;
		[NullAllowed, Export ("inboxTableView", ArgumentSemantic.Weak)]
		UITableView InboxTableView { get; set; }
	}


}

