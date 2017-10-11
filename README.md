# unity-mobile-toast-plugin
Simple plugin for Android that allows you to use the native Android Toast class in your games. 


## Set up 

Import the unity package into your project 

OR

Manually import the project files into your project (under toastplugin/Assets/**)


## How to use 

* include the namespace: 

```
using ToastPlugin; 
```

* Use the method ToastHelper.ShowToast() to call a Toast message
```
ToastHelper.ShowToast(string toastMsg, bool isLong);
```
**toastMsg** corresponds to the message you want to display.

**isLong** corresponds to the length of the Toast message. This uses the *Toast.LENGTH_LONG* or *Toast.LENGTH_SHORT* from the Toast class. 


*iOS Toast classes integrated from [iOS Toast Repo](https://github.com/scalessec/Toast)* (Copyright (c) 2011-2016 Charles Scalesse.)
