
Task default -depends build

Task build -depends RestoreNugetPackages, Compile, UnitTest

Task rebuild -depends CleanAll, RestoreNugetPackages, Compile

## BUILD

Task Initialize -description "Set script variables used for other build tasks"  {

	$script:dotnet = (Get-Command dotnet.exe).Path
	
	$script:allProjects = Get-ChildItem -Path $PSScriptRoot -Include "*.csproj" -File -Recurse
	$script:unitTestProjects = Get-ChildItem -Path $PSScriptRoot -Include "*UnitTests.csproj" -File -Recurse
	$script:integrationTestProjects = Get-ChildItem -Path $PSScriptRoot -Include "*IntegrationTests.csproj" -File -Recurse
	$script:databaseProjects = Get-ChildItem -Path $PSScriptRoot -Include "*Database.csproj" -File -Recurse
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

## TEST

Task UnitTest -description "Execute all unit tests" {

    $script:unitTestProjects | ForEach-Object {

        & $script:dotnet test $_ --no-build -v n
    }
} -depends Initialize

Task IntegrationTest -description "Execute all integration tests" {

    $script:integrationTestProjects | ForEach-Object {

        & $script:dotnet test $_ --no-build -v n
    }
} -depends Initialize, BuildUpdateDatabases

Task BuildUpdateDatabases -description "Run all database scripts" {

	$script:databaseProjects | ForEach-Object {
	
		& $script:dotnet run --project $_ -v m
	}
} -depends Initialize

## TODO implement DropDatabases (using DropDatabase.For.SqlDatabase(connectionString);)