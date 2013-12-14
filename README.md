[![Build Status](https://ci.protomou.se:443/buildStatus/icon?job=NuHelper)](https://ci.protomou.se:443/job/NuHelper/)

# NuHelper

## commands

### shortFrameworkName 

Given a .NET <a href="http://msdn.microsoft.com/en-us/library/system.runtime.versioning.frameworkname(v=vs.110).aspx)">FrameworkName</a>, return the corresponding NuGet framework string.

    > NuHelper.exe shortFrameworkName .NETPortable,Version=v4.0,Profile=Profile136
    portable-net40+sl50+wp80+win+MonoAndroid10+MonoTouch10