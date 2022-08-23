  ____   __   __  __  __    ___      ____    ____    _  __
 |  _ \  \ \ / / |  \/  |  / _ \    / ___|  |  _ \  | |/ /
 | | | |  \ V /  | |\/| | | | | |   \___ \  | | | | | ' / 
 | |_| |   | |   | |  | | | |_| |    ___) | | |_| | | . \ 
 |____/    |_|   |_|  |_|  \___/    |____/  |____/  |_|\_\

In order to run in all deployment scenarios, please add an intialization
call to your application startup.

DymoSDK.App.Init();

Please refer to the below table to determine which files you will need to
include in your application's deployment. If there is a checkmark (✓) in the
column for the architecture that matches your deployment architecture, the file
is required to be deployed with your app.

+------------------------------------------------+-----+-----+------------------------+---------------------------+
|                      File                      | x86 | x64 | AnyCPU (Prefer-32 bit) | AnyCPU (No Prefer-32 bit) |
+------------------------------------------------+-----+-----+------------------------+---------------------------+
| DYMO.CrossPlatform.Common.dll                  | ✓   | ✓   | ✓                      | ✓                         |
| DYMO.CrossPlatform.Common.PlatformSpecific.dll | ✓   | ✓   | ✓                      | ✓                         |
| DYMO.LabelAPI.dll                              | ✓   | ✓   | ✓                      | ✓                         |
| DYMO.LabelAPI.PlatformSpecific.dll             | ✓   | ✓   | ✓                      | ✓                         |
| DYMO.Common.dll                                | ✓   | ✓   | ✓                      | ✓                         |
| x86/DYMOPrinting.dll                           | ✓   |     | ✓                      | ✓                         |
| x86/PrintingSupportLibrary.dll                 | ✓   |     | ✓                      | ✓                         |
| x86/libdymobarcode.dll                         | ✓   |     | ✓                      | ✓                         |
| x86/usps4cb.dll                                | ✓   |     | ✓                      | ✓                         |
| x86/libSkiaSharp.dll                           | ✓   |     | ✓                      | ✓                         |
| x64/DYMOPrinting.dll                           |     | ✓   |                        | ✓                         |
| x64/PrintingSupportLibrary.dll                 |     | ✓   |                        | ✓                         |
| x64/libdymobarcode.dll                         |     | ✓   |                        | ✓                         |
| x64/usps4cb.dll                                |     | ✓   |                        | ✓                         |
| x64/libSkiaSharp.dll                           |     | ✓   |                        | ✓                         |
+------------------------------------------------+-----+-----+------------------------+---------------------------+

-----------------------------------------------------------------------------------------------
  DYMO.Connect.SDK 																			
  Released since Nov 2019.																	
-----------------------------------------------------------------------------------------------
	Version 	      Release notes                                                               
-----------------------------------------------------------------------------------------------
	1.2.976.48729  First stable version to print, open and update label objects.               
-----------------------------------------------------------------------------------------------
	1.2.976.48730  Added the required dependencies to be downloaded when package is installed. 
-----------------------------------------------------------------------------------------------
 	1.2.977        Fixed bug setting value for QRCode objects. 								
                       Print quality parameter added on print methods.								
-----------------------------------------------------------------------------------------------
	1.2.977.101    Fix issue loading label from XML content(DieCutLabel).						
-----------------------------------------------------------------------------------------------
	1.2.977.106    Fix issue loading label from XML content when Version and Units 			
                       when Version and Units element are switched in XML file.				    
 ----------------------------------------------------------------------------------------------
	1.3.1.115 	   Fix low quality printing on tape printers with labels created from DLS.
-----------------------------------------------------------------------------------------------

