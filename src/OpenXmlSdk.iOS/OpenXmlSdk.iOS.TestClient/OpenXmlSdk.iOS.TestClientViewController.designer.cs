// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace OpenXmlSdk.iOS.TestClient
{
	[Register ("OpenXmlSdk_iOS_TestClientViewController")]
	partial class OpenXmlSdk_iOS_TestClientViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton MyButton { get; set; }

		[Action ("UIButton5_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton5_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (MyButton != null) {
				MyButton.Dispose ();
				MyButton = null;
			}
		}
	}
}
