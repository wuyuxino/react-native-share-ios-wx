
# react-native-share-ios-wx
`纯净版sdk，支持微信分享、登陆等功能`

## Getting started

`$ npm install react-native-share-ios-wx --save`

### Mostly automatic installation

`$ react-native link react-native-share-ios-wx`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-share-ios-wx` and add `RNReactNativeShareIosWx.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeShareIosWx.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<
5. 需要加入的库 libWeChatSDK.a / libsqlite3.0.tbd / libRNReactNativeShareIosWx.a / libz.tbd / SystemConfiguration.framework / CoreTelephony.framework / JavaScriptCore.framework
6.复制libWeChatSDK.a到项目的ios目录下面，然后在添加到项目中，否则会找不到该文件。


#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativeShareIosWxPackage;` to the imports at the top of the file
  - Add `new RNReactNativeShareIosWxPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-share-ios-wx'
  	project(':react-native-share-ios-wx').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-share-ios-wx/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-share-ios-wx')
  	```
    
## Usage
```javascript
import * as RNReactNativeShareIosWx from 'react-native-share-ios-wx';

// TODO: What to do with the module?
RNReactNativeShareIosWx;
```
  
