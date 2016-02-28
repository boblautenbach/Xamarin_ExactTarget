using ObjCRuntime;


[assembly: LinkWith("libJB4ASDK-4.0.3.a", LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true,SmartLink = true, Frameworks = "CoreLocation")]

