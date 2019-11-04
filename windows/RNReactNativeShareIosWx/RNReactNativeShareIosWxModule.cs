using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Share.Ios.Wx.RNReactNativeShareIosWx
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeShareIosWxModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeShareIosWxModule"/>.
        /// </summary>
        internal RNReactNativeShareIosWxModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeShareIosWx";
            }
        }
    }
}
