// 
//  Copyright 2012  abhatia
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Facebook.MonoTouch.Sample
{
	public class LoginViewController : UIViewController
	{
		
		
        const string ExtendedPermissions = @"user_about_me,publish_stream,offline_access";
		
		static string AppId = @"";
		static string AppSecret = @"";
		
		Uri _LoginUrl;
		FacebookOAuthClient _AuthClient;
		UIWebView _WebView;
		
		public LoginViewController()
		{
		}
		
		public override void LoadView()
		{
			base.LoadView();
			
			_WebView = new UIWebView();
			
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
		}
		
		
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			
			var req = new NSUrlRequest(new NSUrl(@""));
			_WebView.LoadRequest(req);
				
			
		}
		
		
		public override void ViewWillLayoutSubviews()
		{
			base.ViewWillLayoutSubviews();
			
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			
			//dealloc
		}
	}
}

