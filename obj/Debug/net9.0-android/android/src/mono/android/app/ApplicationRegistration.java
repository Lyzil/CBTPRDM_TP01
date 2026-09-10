package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("CBTPRDM_TP01.MainApplication, CBTPRDM_TP01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc648b9677e4920f3faa.MainApplication.class, crc648b9677e4920f3faa.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
