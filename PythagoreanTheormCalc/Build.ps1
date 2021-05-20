dotnet publish -c Release -r win-x64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true -o .\bin\Release\win-x64
dotnet publish -c Release -r win-arm64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true -o .\bin\Release\win-arm64
dotnet publish -c Release -r linux-arm64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true -o .\bin\Release\linux-arm64
dotnet publish -c Release -r linux-arm --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true -o .\bin\Release\linux-arm
dotnet publish -c Release -r linux-x64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true -o .\bin\Release\linux-x64
dotnet publish -c Release -r osx-x64 --self-contained true /p:PublishTrimmed=true -p:PublishSingleFile=true -o .\bin\Release\osx-x64

Compress-Archive -Path .\bin\Release\linux-arm -DestinationPath .\bin\Release\linux-arm.zip
Compress-Archive -Path .\bin\Release\linux-arm64 -DestinationPath .\bin\Release\linux-arm64.zip
Compress-Archive -Path .\bin\Release\linux-x64 -DestinationPath .\bin\Release\linux-x64.zip
Compress-Archive -Path .\bin\Release\osx-x64 -DestinationPath .\bin\Release\osx-64.zip
Compress-Archive -Path .\bin\Release\win-arm64 -DestinationPath .\bin\Release\win-arm64.zip
Compress-Archive -Path .\bin\Release\win-x64 -DestinationPath .\bin\Release\win-x64.zip