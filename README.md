# Xamarin ExactTarget (Marketing Cloud) Binding dll

In Appdelegate: <BR>

		class HandleOpenDirectDelegate: ExactTarget.Push.ExactTargetOpenDirectDelegate {
			public virtual bool ShouldDeliverOpenDirectMessageIfAppIsRunning {
				get {
					return false;
				}
			}
			override 

			public  void DidReceiveOpenDirectMessageWithContents (string payload)
			{
				//todo: handle payload

			}
		}


		public override void WillEnterForeground (UIApplication application)
		{
			ETPush.PushManager.ResetBadgeCount();
		}

	
		public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
		{

			try {

				ETPush.PushManager.ConfigureSDKWithAppID ("APPID", "TOKEN", true, true, true);
				ETPush.PushManager.OpenDirectDelegate = new HandleOpenDirectDelegate();
				ETPush.PushManager.ShouldDisplayAlertViewIfPushReceived(true);
				ETLocationManager.LocationManager.StartWatchingLocation ();

				ETPush.PushManager.AddTag ("tag1");
				ETPush.PushManager.AddTag ("tag2");
				ETPush.PushManager.AddAttributeNamed ("@FirstName", "Robert");
				ETPush.PushManager.AddAttributeNamed (@"GlobalID", "1212");
		
				var d = ETPush.PushManager.AllAttributes;
				ETPush.PushManager.RegisterDeviceToken (deviceToken);

				Console.WriteLine("== DEVICE ID ==\\nThe ExactTarget Device ID is: {0}", ETPush.SafeDeviceIdentifier);
				
			} catch (Exception ex) {
				Console.WriteLine ("Error Message {0}", ex.Message);
			}
		}

			public override void FailedToRegisterForRemoteNotifications (UIApplication application, NSError error)
		{
			ETPush.PushManager.ApplicationDidFailToRegisterForRemoteNotificationsWithError (error);
		}

		public override void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
		{
			ETPush.PushManager.HandleNotification (userInfo, application.ApplicationState);
		}
