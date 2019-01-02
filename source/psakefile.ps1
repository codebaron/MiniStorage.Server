
Task default -depends build

Task build -depends CleanAll, RestoreNugetPackages, Compile

Task Initialize -description "Set script variables used for other build tasks"  {

	$script:dotnet = (Get-Command dotnet.exe).Path
	
	$script:allProjects = Get-ChildItem -Path $PSScriptRoot -Include "*.csproj" -File -Recurse
	$script:testProjects = Get-ChildItem -Path $PSScriptRoot -Include "*Tests.csproj" -File -Recurse
}

Task CleanAll -depends CleanNugetPackages, CleanProjects

Task CleanProjects -description "Removes the built assemblies for all projects" {
    	
    $script:allProjects | ForEach-Object {

        Remove-Item -Path (Join-Path $_.Directory bin) -Force -Recurse -ErrorAction SilentlyContinue
        Remove-Item -Path (Join-Path $_.Directory obj) -Force -Recurse -ErrorAction SilentlyContinue
    }

} -depends Initialize

Task CleanNugetPackages -description "Remove nuget package cache from current users home" {
    
    Remove-Item (Join-Path $HOME .nuget\packages) -Force -Recurse -ErrorAction SilentlyContinue
}

Task RestoreNugetPackages -description "Restore nuget dependencies for all projects" {
    
    $script:allProjects | ForEach-Object {

        & $script:dotnet restore $_
    }
} -depends Initialize

Task Compile -description "Compile all projects" {

    $script:allProjects | ForEach-Object {

        & $script:dotnet build $_
    }
} -depends Initialize