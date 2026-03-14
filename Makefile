watch:
	dotnet watch run --project ./TellahLife/TellahLife.csproj
run:
	dotnet run --project ./TellahLife/TellahLife.csproj
watch-test:
	cd ./TellahLife.UnitTests && dotnet watch test
build:
	dotnet build
outdated:
	dotnet outdated -exc FluentAssertions
outdated-upgrade:
	dotnet outdated -exc FluentAssertions -u