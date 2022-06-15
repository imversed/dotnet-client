# a simple script to upload this package to Nuget
# usage:
# 		sh ./upload-nuget.sh version api-key

dotnet pack --configuration=Release
cd bin/Release
dotnet nuget push Imversed.Client.$1.nupkg --api-key=$2 --source https://api.nuget.org/v3/index.json
cd ../..
