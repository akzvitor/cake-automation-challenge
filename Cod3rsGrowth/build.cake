#addin nuget:?package=Cake.Docker&version=1.3.0

var target = Argument("target", "Docker-Build");
var configuration = Argument("configuration", "Release");

Task("Build")
    .Does(() =>
{
    DotNetBuild("./Cod3rsGrowth.sln", new DotNetBuildSettings
    {
        Configuration = configuration,
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetTest("./Cod3rsGrowth.sln", new DotNetTestSettings
    {
        Configuration = configuration,
        NoBuild = true,
    });
});

Task("Docker-Build")
.IsDependentOn("Test")
.Does(() => {
    var settings = new DockerImageBuildSettings { Tag = new[] {"dockerapp:latest" }};
    DockerBuild(settings, "./");
});

RunTarget(target);