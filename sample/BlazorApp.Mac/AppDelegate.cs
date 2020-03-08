﻿// <copyright file="AppDelegate.cs" company="Steve Sanderson and Jan-Willem Spuij">
// Copyright 2020 Steve Sanderson and Jan-Willem Spuij
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace BlazorApp.Mac
{
    using AppKit;
    using Foundation;

    /// <summary>
    /// The NSApplicationDelegate for the application. This class is responsible for launching the
    /// User Interface of the application, as well as listening (and optionally responding) to application events from macOS.
    /// </summary>
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        /// <summary>
        /// Override point for customization after application launch.
        /// If not required for your application you can safely delete this method.
        /// </summary>
        /// <param name="notification">The notification.</param>
        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        /// <summary>
        /// Called when the application will terminate..
        /// Use this method to release any resources that were specific to the application.
        /// </summary>
        /// <param name="notification">The notification.</param>
        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
