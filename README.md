Reproduction for issue [#318](https://github.com/OutSystems/WebView/issues/318) in the OutSystems repo for WebView use with the [WebViewControl-Avalonia](https://www.nuget.org/packages/WebViewControl-Avalonia) nuget package. 

UPDATE: 

The issue is caused by `x64` systems requiring the [WebViewControl-Avalonia](https://www.nuget.org/packages/WebViewControl-Avalonia) nuget package while `arm64` systems require the [WebViewControl-Avalonia-ARM64](https://www.nuget.org/packages/WebViewControl-Avalonia-ARM64) package. Both nuget packages can't be used at the same time.

If you are only targeting `x64` or `arm64` you can use one or the other packages and call it a day. However if you require both you need to update your build configuration to support both `x64` and `arm64` instead of `Any CPU`, and then also modify your `.csproj` so it can handle it like so:

```xml
<ItemGroup Condition="'$(Platform)' == 'x64'">
    <PackageReference Include="WebViewControl-Avalonia" Version="3.120.5" />
</ItemGroup>
<ItemGroup Condition="'$(Platform)' == 'arm64'">
    <PackageReference Include="WebViewControl-Avalonia-ARM64" Version="3.120.5" />
</ItemGroup>
```

Keep in mind while developing if you update one nuget package it won't update the other, nor will it show in our IDE that it needs an update.