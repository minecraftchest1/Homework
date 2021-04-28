dotnet publish -c Release -r win-x64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true
dotnet publish -c Release -r win-arm64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true
dotnet publish -c Release -r linux-arm64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true
dotnet publish -c Release -r linux-arm --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true
dotnet publish -c Release -r linux-x64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true
dotnet publish -c Release -r osx-x64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true