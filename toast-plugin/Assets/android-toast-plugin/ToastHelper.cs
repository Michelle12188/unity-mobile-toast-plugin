using UnityEngine;

namespace ToastPlugin {

    public static class ToastHelper {

        /// <summary>
        /// Show a Toast message from Android.
        /// </summary>
        /// <param name="toastMsg">the message you want to show</param>
        /// <param name="isLong">does the message appear for a short of long amount of time (time is default from android)</param>
        public static void ShowToast(string toastMsg, bool isLong) {
            var toastPlugin = new AndroidJavaClass("missing.toastplugin.ToastHelper");
            if (toastPlugin != null)
                toastPlugin.CallStatic("showToast", toastMsg, getActivity(), isLong);

        }

        /// <summary>
        /// Get the unity activity for context. 
        /// </summary>
        /// <returns></returns>
        private static AndroidJavaObject getActivity() {
            var actClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject act = actClass.GetStatic<AndroidJavaObject>("currentActivity");
            return act;
        }
    }
}

