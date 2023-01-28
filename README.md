# Creating NuGet Packages The Easy Way With .NET Standard In C#

NuGet packages are a way to share versioned code with the world. That allows us to create flexible applications that upgrade parts of itself without upgrading everything. 


## Feed

### Create Feed

<img src="/pictures/feed.png" title="feed"  width="800">
<img src="/pictures/feed2.png" title="feed"  width="800">

Copy the Source Url :

<img src="/pictures/feed3.png" title="feed"  width="800">

Click on the gear :

<img src="/pictures/feed5.png" title="feed"  width="800">

Add a *Package source* :

<img src="/pictures/feed4.png" title="feed"  width="800">

### Build Package

Go into the properties of the project :

<img src="/pictures/package.png" title="package"  width="800">

Right-click on **HelperLibrary** and click **Pack**. That should create a **.nupkg** :

<img src="/pictures/package2.png" title="package"  width="800">

### Publish packages
```
dotnet restore --interactive
cd path/to/package.nupkg
dotnet nuget push --source "AlexeiDemoFeed" --api-key az --force-english-output --interactive AlexeiHelperLibrary.1.0.0.nupkg
```

You should now see the created package in **Azure devops** :

<img src="/pictures/created_package.png" title="created package"  width="800">
```

And you can use it as well in **Visual studio** :

<img src="/pictures/created_package2.png" title="created package"  width="800">


## Devops Repository Setup

### Create Repo

<img src="/pictures/repo.png" title="repo"  width="800">

### Create Classic Editor Pipeline

<img src="/pictures/pipeline.png" title="pipeline"  width="800">
<img src="/pictures/pipeline2.png" title="pipeline"  width="800">
<img src="/pictures/pipeline3.png" title="pipeline"  width="800">
<img src="/pictures/pipeline4.png" title="pipeline"  width="800">
<img src="/pictures/pipeline5.png" title="pipeline"  width="800">
<img src="/pictures/pipeline6.png" title="pipeline"  width="800">
<img src="/pictures/pipeline7.png" title="pipeline"  width="800">
<img src="/pictures/pipeline8.png" title="pipeline"  width="400">

### Release Pipeline

<img src="/pictures/release.png" title="release"  width="800">
<img src="/pictures/release2.png" title="release"  width="800">
