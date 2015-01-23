using System;
using System.Drawing;

using Foundation;
using UIKit;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlSdk.iOS.TestClient
{
	public partial class OpenXmlSdk_iOS_TestClientViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public OpenXmlSdk_iOS_TestClientViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}


		partial void UIButton5_TouchUpInside (UIButton sender)
		{
			sender.SetTitle("You Clicked",UIControlState.Normal);
			try
			{
				var doc = new OpenSettings ();
				if (doc != null) 
				{
					sender.SetTitle("Yes",UIControlState.Normal);
				}
				else {			
					sender.SetTitle("No",UIControlState.Normal);
				}
			}
			catch(Exception ex){
				Console.WriteLine(ex);
			}
		}
		#endregion
	}
}

